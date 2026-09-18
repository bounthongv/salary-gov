Public Class Frm_E1_Table
    Dim rs As New ADODB.Recordset

    Private Sub Frm_E1_Table_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.FormatString = "ລດ |<ຊື່ວິຊາ                |<ນັບແຕ່ປີຈົບ(ລະດັບການສືກສາສູູງສຸດທີ່ໄດ້ຮັບ)|>ລວມ    |>ເອກ    |>ໂທ     |>ຕີ     |>ສູງ   |>ກາງ   |>ລວມ   |>ເອກ   |>ໂທ   |>ຕີ   |>ສູງ   |>ກາງ |<ໝາຍເຫດ     "
        'fg.set_ColHidden(1, True)
        'fg.set_ColHidden(2, True)

        Cmb_Sections.Items.Clear()
        Call load_Cmb("select Sec_nmL from AP_Sections", "Sec_nmL", Cmb_Sections)
        Cmb_Sections.SelectedIndex = 0

        cmb_Department.Items.Clear()
        Call load_Cmb("select DP_Name from Department", "DP_Name", cmb_Department)
        cmb_Department.SelectedIndex = 0

        If MDEdit = False Then

            BtnAddNew_Click(sender, e)
        Else
            Editdata()
            Call LoadData()
        End If




    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 E1_Bill from AP_E1   Order by E1_Bill DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("E1_Bill").Value, 1, 3)) + 1, "000")
        Else
            VIOTNEW = "001"

        End If
        Txt_ID.Text = Trim(CStr(VIOTNEW.ToString))
    End Sub
    Private Sub Editdata()
        Dim aa As String
        Dim rs As New ADODB.Recordset
        aa = "SELECT    * from AP_E1  where  E1_Bill=N'" & SaleID & "' "
        Call LoadRs(aa, rs)
        With rs
            If .RecordCount > 0 Then
                Txt_ID.Text = Trim(.Fields("E1_Bill").Value.ToString)
                DT_up.Value = Trim(.Fields("DT_E1").Value.ToString)
                txtSection_ID.Text = Trim(.Fields("Sections_id").Value.ToString)
                Cmb_Sections.Text = Trim(.Fields("Sections").Value.ToString)
                txtdepart_ID.Text = Trim(.Fields("Department_id").Value.ToString)
                cmb_Department.Text = Trim(.Fields("Department").Value.ToString)

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
        Conn.Execute("delete from   AP_E1_Item WHERE  E1_Bill= '" & (Txt_ID.Text) & "'")
        Save_item()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)

        Txt_ID.Focus()
    End Sub
    Public Sub save()
        Call LoadRs("SELECT * FROM AP_E1 WHERE E1_Bill = '" & Txt_ID.Text & "'  ", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO AP_E1 (E1_Bill,DT_E1,Sections_id,Sections,Department_id,Department) " & _
                   " VALUES('" & (Txt_ID.Text) & "'," & _
                    " '" & Format(DT_up.Value, "yyyy-MM-dd") & "'," & _
                        " N'" & (txtSection_ID.Text) & "'," & _
                   " N'" & (Cmb_Sections.Text) & "'," & _
                     " N'" & (txtdepart_ID.Text) & "'," & _
                            " N'" & cmb_Department.Text & "')")
            Else
                Conn.Execute("delete from   AP_E1 WHERE  E1_Bill= '" & (Txt_ID.Text) & "'")
                Conn.Execute("INSERT INTO AP_E1 (E1_Bill,DT_E1,Sections_id,Sections,Department_id,Department) " & _
                  " VALUES('" & (Txt_ID.Text) & "'," & _
                   " '" & Format(DT_up.Value, "yyyy-MM-dd") & "'," & _
                       " N'" & (txtSection_ID.Text) & "'," & _
                  " N'" & (Cmb_Sections.Text) & "'," & _
                    " N'" & (txtdepart_ID.Text) & "'," & _
                           " N'" & cmb_Department.Text & "')")

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
            Call LoadRs("SELECT E1_Bill FROM AP_E1_Item WHERE E1_Bill = '" & Txt_ID.Text & "'", rs)
            For i = 1 To FG.Rows - 1
                If .RecordCount = 0 Then
                    ww = " INSERT INTO  AP_E1_Item (   E1_Bill, visa_nm, E1_year, Total_in, ek_in, tho_in, tee_in, soung_in, kang_in, " & _
                    " Total_out, ek_out, tho_out, tee_out, soung_out, kang_out, reamrk)" & _
                        "VALUES( " & _
                            " '" & Trim(Txt_ID.Text.ToString) & "'," & _
                             " N'" & fg.get_TextMatrix(i, 1) & "'," & _
                                " N'" & fg.get_TextMatrix(i, 2) & "'," & _
                                   " N'" & fg.get_TextMatrix(i, 3) & "'," & _
                             " N'" & fg.get_TextMatrix(i, 4) & "'," & _
                              " N'" & fg.get_TextMatrix(i, 5) & "'," & _
                                " N'" & fg.get_TextMatrix(i, 6) & "'," & _
                                     " N'" & fg.get_TextMatrix(i, 7) & "'," & _
                                       " N'" & fg.get_TextMatrix(i, 8) & "'," & _
                                         " N'" & fg.get_TextMatrix(i, 9) & "'," & _
                                           " N'" & fg.get_TextMatrix(i, 10) & "'," & _
                                             " N'" & fg.get_TextMatrix(i, 11) & "'," & _
                                               " N'" & fg.get_TextMatrix(i, 12) & "'," & _
                                                 " N'" & fg.get_TextMatrix(i, 13) & "'," & _
                                                   " N'" & fg.get_TextMatrix(i, 14) & "'," & _
                                    " N'" & fg.get_TextMatrix(i, 15) & "' )"
                    Conn.Execute(ww)
                End If
            Next i
        End With
    End Sub
    Public Sub LoadData()
        Dim rs As New ADODB.Recordset
        fg.Rows = 1
        With rs
            Call LoadRs("SELECT   *  from AP_E1_Item where E1_Bill='" & Txt_ID.Text & "'", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    fg.AddItem(.AbsolutePosition & _
                        Chr(9) & (.Fields("visa_nm").Value.ToString) & _
             Chr(9) & (.Fields("E1_year").Value.ToString) & _
              Chr(9) & (.Fields("Total_in").Value.ToString) & _
              Chr(9) & (.Fields("ek_in").Value.ToString) & _
              Chr(9) & (.Fields("tho_in").Value.ToString) & _
              Chr(9) & (.Fields("tee_in").Value.ToString) & _
                   Chr(9) & (.Fields("soung_in").Value.ToString) & _
                        Chr(9) & (.Fields("kang_in").Value.ToString) & _
                                      Chr(9) & (.Fields("Total_out").Value.ToString) & _
              Chr(9) & (.Fields("ek_out").Value.ToString) & _
              Chr(9) & (.Fields("tho_out").Value.ToString) & _
              Chr(9) & (.Fields("tee_out").Value.ToString) & _
                   Chr(9) & (.Fields("soung_out").Value.ToString) & _
                        Chr(9) & (.Fields("kang_out").Value.ToString) & _
           Chr(9) & (.Fields("reamrk").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub fg_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.ClickEvent
        If fg.Col = 1 Or fg.Col = 2 Or fg.Col = 3 Or fg.Col = 4 Or fg.Col = 5 Or fg.Col = 6 Or fg.Col = 7 Or fg.Col = 8 Or fg.Col = 9 Or fg.Col = 10 Or fg.Col = 11 Or fg.Col = 12 Or fg.Col = 13 Or fg.Col = 14 Or fg.Col = 15 Then

            fg.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            fg.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
    End Sub



    Private Sub fg_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.SelChange
        If fg.Col = 1 Or fg.Col = 2 Or fg.Col = 3 Or fg.Col = 4 Or fg.Col = 5 Or fg.Col = 6 Or fg.Col = 7 Or fg.Col = 8 Or fg.Col = 9 Or fg.Col = 10 Or fg.Col = 11 Or fg.Col = 12 Or fg.Col = 13 Or fg.Col = 14 Or fg.Col = 15 Then

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
            Dim sa As String
            sa = "SELECT   AP_E1.E1_Bill, AP_E1.DT_E1, AP_E1.Sections_id, AP_E1.Sections, AP_E1.Department_id, AP_E1.Department, AP_E1_Item.visa_nm, AP_E1_Item.E1_year, " & _
                   "   AP_E1_Item.Total_in, AP_E1_Item.ek_in, AP_E1_Item.tho_in, AP_E1_Item.tee_in, AP_E1_Item.soung_in, AP_E1_Item.kang_in, AP_E1_Item.Total_out,  " & _
          "  AP_E1_Item.ek_out, AP_E1_Item.tho_out, AP_E1_Item.tee_out, AP_E1_Item.soung_out, AP_E1_Item.kang_out, AP_E1_Item.reamrk " & _
         "    FROM         AP_E1 INNER JOIN " & _
               "       AP_E1_Item ON AP_E1.E1_Bill = AP_E1_Item.E1_Bill  WHERE  AP_EP.E1_Bill='" & Txt_ID.Text & "'   ORDER BY  AP_EP_Item.EP_ID  "
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

    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button62.Click
        fg.Rows = fg.Rows + 1
    End Sub

    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button61.Click
        If fg.get_TextMatrix(fg.Row, 1) = "" Then
            fg.RemoveItem(fg.Row)
        Else
            AccCD = fg.get_TextMatrix(fg.Row, 1)
            If MessageBox.Show("Do you want to cancle '" & AccCD & "' yes or no ?", "Cancle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                fg.RemoveItem(fg.Row)
                If fg.Rows = 1 Then fg.Rows = 1
            End If
        End If
    End Sub
End Class