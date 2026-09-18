Public Class Frm_EP_Table
    Dim rs As New ADODB.Recordset

    Private Sub Frm_Type_donw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.FormatString = "ລດ |<ປີການ|<ລະດັບຄວາມຄ່ອງແຄ້ວ/ຄວາມຊຳນານ                           |<ປີການ                  |>ລວມ      |>ບສ    |>ກພ    |>ນບ     |>ພມ    "
        fg.set_ColHidden(1, True)
        'fg.set_ColHidden(2, True)

        Cmb_Sections.Items.Clear()
        Call load_Cmb("select Sec_nmL from AP_Sections", "Sec_nmL", Cmb_Sections)
        Cmb_Sections.SelectedIndex = 0

        cmb_Department.Items.Clear()
        Call load_Cmb("select DP_Name from Department", "DP_Name", cmb_Department)
        cmb_Department.SelectedIndex = 0

        If MDEdit = False Then
            Load_list()
            BtnAddNew_Click(sender, e)
        Else
            Editdata()
            Call LoadData()
        End If




    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 EP_Bill from AP_EP    Order by EP_Bill DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("EP_Bill").Value, 1, 3)) + 1, "000")
        Else
            VIOTNEW = "001"

        End If
        Txt_ID.Text = Trim(CStr(VIOTNEW.ToString))
    End Sub
    Private Sub Editdata()
        Dim aa As String
        Dim rs As New ADODB.Recordset
        aa = "SELECT    * from AP_EP  where  EP_Bill=N'" & SaleID & "' "
        Call LoadRs(aa, rs)
        With rs
            If .RecordCount > 0 Then
                Txt_ID.Text = Trim(.Fields("EP_Bill").Value.ToString)
                DT_up.Value = Trim(.Fields("DT_EP").Value.ToString)
                txtSection_ID.Text = Trim(.Fields("Sections_id").Value.ToString)
                Cmb_Sections.Text = Trim(.Fields("Sections").Value.ToString)
                txtdepart_ID.Text = Trim(.Fields("Department_id").Value.ToString)
                cmb_Department.Text = Trim(.Fields("Department").Value.ToString)
                Txtremark.Text = Trim(.Fields("remark").Value.ToString)

            End If
        End With
    End Sub

    Public Sub Load_list()
        fg.Rows = 1
        With rs
            Call LoadRs("SELECT   * from dbo.EP_List order by EP_ID ", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    fg.AddItem(.AbsolutePosition & _
        Chr(9) & (.Fields("EP_ID").Value.ToString) & _
            Chr(9) & (.Fields("EP_nm").Value.ToString) & _
             Chr(9) & (.Fields("EP_year").Value.ToString) & _
              Chr(9) & (.Fields("EP_Total").Value.ToString) & _
              Chr(9) & (.Fields("EP1").Value.ToString) & _
              Chr(9) & (.Fields("EP2").Value.ToString) & _
              Chr(9) & (.Fields("EP3").Value.ToString) & _
           Chr(9) & (.Fields("EP4").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Txt_ID.Text = "" Then MsgBox("Type ID !", MsgBoxStyle.OkOnly) : Txt_ID.Focus() : Exit Sub

        Call save()
        Conn.Execute("delete from   AP_EP_Item WHERE  EP_Bill= '" & (Txt_ID.Text) & "'")
        Save_item()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)

        Txt_ID.Focus()
    End Sub
    Public Sub save()
        Call LoadRs("SELECT * FROM AP_EP WHERE EP_Bill = '" & Txt_ID.Text & "'  ", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO AP_EP (EP_Bill,DT_EP,Sections_id,Sections,Department_id,Department,Remark) " & _
                   " VALUES('" & (Txt_ID.Text) & "'," & _
                    " '" & Format(DT_up.Value, "yyyy-MM-dd") & "'," & _
                        " N'" & (txtSection_ID.Text) & "'," & _
                   " N'" & (Cmb_Sections.Text) & "'," & _
                     " N'" & (txtdepart_ID.Text) & "'," & _
                   " N'" & (cmb_Department.Text) & "'," & _
                            " N'" & Txtremark.Text & "')")
            Else
                Conn.Execute("delete from   AP_EP WHERE  EP_Bill= '" & (Txt_ID.Text) & "'")
                Conn.Execute("INSERT INTO AP_EP (EP_Bill,DT_EP,Sections_id,Sections,Department_id,Department,Remark) " & _
                  " VALUES('" & (Txt_ID.Text) & "'," & _
                   " '" & Format(DT_up.Value, "yyyy-MM-dd") & "'," & _
                       " N'" & (txtSection_ID.Text) & "'," & _
                  " N'" & (Cmb_Sections.Text) & "'," & _
                    " N'" & (txtdepart_ID.Text) & "'," & _
                  " N'" & (cmb_Department.Text) & "'," & _
                           " N'" & Txtremark.Text & "')")

                'Conn.Execute("UPDATE Type_Donw SET " & _
                '       " dn_nm=N'" & Txtremark.Text & "' " & _
                '   " WHERE dn_id= '" & (Txt_ID.Text) & "'  ")
            End If
        End With

    End Sub
    Private Sub Save_item()
        Dim ww As String
        Dim i As Integer
        Dim rs As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT EP_Bill FROM AP_EP_Item WHERE EP_Bill = '" & Txt_ID.Text & "'", rs)
            For i = 1 To FG.Rows - 1
                If .RecordCount = 0 Then
                    ww = " INSERT INTO  AP_EP_Item (  EP_Bill, EP_ID, EP_nm, EP_year,EP_Total,EP1,EP2,EP3,EP4)" & _
                        "VALUES( " & _
                            " '" & Trim(Txt_ID.Text.ToString) & "'," & _
                             " N'" & fg.get_TextMatrix(i, 1) & "'," & _
                                " N'" & fg.get_TextMatrix(i, 2) & "'," & _
                                   " N'" & fg.get_TextMatrix(i, 3) & "'," & _
                                  " " & CDbl(fg.get_TextMatrix(i, 4)) & "," & _
                                  " " & CDbl(fg.get_TextMatrix(i, 5)) & "," & _
                                    " " & CDbl(fg.get_TextMatrix(i, 6)) & "," & _
                                    " " & CDbl(fg.get_TextMatrix(i, 7)) & "," & _
                                    " " & CDbl(fg.get_TextMatrix(i, 8)) & " )"
                    Conn.Execute(ww)
                End If
            Next i
        End With
    End Sub
    Public Sub LoadData()
        Dim rs As New ADODB.Recordset
        fg.Rows = 1
        With rs
            Call LoadRs("SELECT   *  from AP_EP_Item where EP_bill='" & Txt_ID.Text & "'", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    fg.AddItem(.AbsolutePosition & _
                  Chr(9) & (.Fields("EP_ID").Value.ToString) & _
            Chr(9) & (.Fields("EP_nm").Value.ToString) & _
             Chr(9) & (.Fields("EP_year").Value.ToString) & _
              Chr(9) & (.Fields("EP_Total").Value.ToString) & _
              Chr(9) & (.Fields("EP1").Value.ToString) & _
              Chr(9) & (.Fields("EP2").Value.ToString) & _
              Chr(9) & (.Fields("EP3").Value.ToString) & _
           Chr(9) & (.Fields("EP4").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub fg_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.ClickEvent
        If fg.Col = 8 Or fg.Col = 4 Or fg.Col = 5 Or fg.Col = 6 Or fg.Col = 7 Then

            fg.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            fg.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
    End Sub
 
 

    Private Sub fg_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.SelChange
        If fg.Col = 3 Or fg.Col = 4 Or fg.Col = 5 Or fg.Col = 6 Or fg.Col = 7 Then

            fg.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            fg.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Txt_ID.Text = ""
        Txtremark.Text = ""
        Txt_ID.Visible = True
        Txt_ID.Enabled = True
        txtno.Text = ""
        Load_list()
        AutoNumber()
    End Sub

     

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtPV_NM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPV_NM.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Province Where   PV_nm =N'" & Trim(TxtPV_NM.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            TxtPV_ID.Text = Trim(rs("PV_ID").Value)
        End If
        Call LoadData()
    End Sub

    Private Sub Cmb_Sections_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Sections.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Sections Where Sec_nmL=N'" & Trim(Cmb_Sections.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtSection_ID.Text = Trim(RSC("Sec_id").Value)
        End If
    End Sub

    Private Sub cmb_Department_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Department.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Department Where DP_name=N'" & Trim(cmb_Department.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtdepart_ID.Text = Trim(RSC("DP_ID").Value)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        With RSC
            Dim sa As String = "SELECT     AP_EP.EP_Bill, AP_EP.DT_EP, AP_EP.Sections_id, AP_EP.Sections, AP_EP.Department_id, AP_EP.Department, AP_EP.Remark, AP_EP_Item.EP_ID, " & _
          "  AP_EP_Item.EP_nm, AP_EP_Item.EP_year, AP_EP_Item.EP_Total, AP_EP_Item.EP1, AP_EP_Item.EP2, AP_EP_Item.EP3, AP_EP_Item.EP4 " & _
         " FROM         AP_EP INNER JOIN " & _
                    "  AP_EP_Item ON AP_EP.EP_Bill = AP_EP_Item.EP_Bill  WHERE  AP_EP.EP_Bill='" & Txt_ID.Text & "'   ORDER BY  AP_EP_Item.EP_ID  "
            Call LoadRs(sa, RSC)
            If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
            Dim Frm As New FrmPreview
            Dim Rpt As New Report_EP_list
            'Dim myTextObjectOnReport As CrystalDecisions.CrystalReports.Engine.TextObject
            'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("Text13"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'myTextObjectOnReport.Text = FrmAPInvioce.Label1.Text


            'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("T1"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'myTextObjectOnReport.Text = txtFdate.Value


            'myTextObjectOnReport = CType(Rpt.ReportDefinition.ReportObjects.Item("T2"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'myTextObjectOnReport.Text = txtTdate.Value

            Rpt.SetDataSource(RSC)
            Rpt.Refresh()
            Frm.ReportViewer.ReportSource = Rpt
            Frm.ReportViewer.Zoom(100%)
            Frm.ReportViewer.DisplayGroupTree = False
            Frm.WindowState = FormWindowState.Maximized
            Frm.Show()
        End With
    End Sub
End Class