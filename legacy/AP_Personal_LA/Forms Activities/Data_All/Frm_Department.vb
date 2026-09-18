Public Class Frm_Department
    Dim rs As New ADODB.Recordset

    Private Sub Frm_Department_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.FormatString = "ລດ |<ລະຫັດ     |<ເລກຈັດລຽງ       |<ຊື່                             |<ລະຫັດ     |<ລະຫັດ     |<ລາຍການສາຂາ(ບ່ອນປະຈຳການ)             "
        fg.set_ColHidden(4, True)
        'fg.set_ColHidden(2, True)
        'Cmb_Sections.Items.Clear()
        'Call load_Cmb("select Sec_nmL from AP_Sections  ", "Sec_nmL", Cmb_Sections)
        Cmb_Sections.SelectedIndex = 0


        BtnAddNew_Click(sender, e)
        Call LoadData()
    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 DP_ID from Department order by DP_ID desc ", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("DP_ID").Value, 1, 3)) + 1, "000")
        Else
            VIOTNEW = "001"

        End If
        Txt_ID.Text = Trim(CStr(VIOTNEW.ToString))
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Txt_ID.Text = "" Then MsgBox("Type ID !", MsgBoxStyle.OkOnly) : Txt_ID.Focus() : Exit Sub

        Call save()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
        Call LoadData()
        AutoNumber()
        Txt_name.Text = ""
        Txt_name.Focus()
    End Sub
    Public Sub save()
        Call LoadRs("SELECT * FROM Department WHERE Dp_ID = '" & Txt_ID.Text & "'  ", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO Department (Sec_id,DP_ID,Group_SLR_id,DP_Name,section_id,section_nm) " & _
                   " VALUES('" & (txtoerder_no.Text) & "'," & _
                  " N'" & (Txt_ID.Text) & "'," & _
                   " N'" & (txttype_Id.Text) & "'," & _
                        " N'" & (Txt_name.Text) & "'," & _
                           " N'" & (txtSection_ID.Text) & "'," & _
                                 " N'" & Cmb_Sections.Text & "')")
            Else
                Conn.Execute("UPDATE Department SET " & _
                                       " Sec_id=N'" & txtoerder_no.Text & "', " & _
                                          " Group_SLR_id=N'" & txttype_Id.Text & "', " & _
                                              " DP_Name=N'" & Txt_name.Text & "', " & _
                                         " section_id=N'" & txtSection_ID.Text & "', " & _
                                              " section_nm=N'" & Cmb_Sections.Text & "' " & _
                   " WHERE DP_ID= '" & (Txt_ID.Text) & "'  ")
            End If
        End With

    End Sub
    Public Sub LoadData()
        fg.Rows = 1
        With rs
            Call LoadRs("SELECT   * from Department   order by  sec_ID", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    fg.AddItem(.AbsolutePosition & _
                          Chr(9) & (.Fields("dp_id").Value.ToString) & _
                                Chr(9) & (.Fields("Sec_id").Value.ToString) & _
                                     Chr(9) & (.Fields("DP_Name").Value.ToString) & _
                                           Chr(9) & (.Fields("Group_SLR_id").Value.ToString) & _
                                                 Chr(9) & (.Fields("section_id").Value.ToString) & _
                    Chr(9) & (.Fields("section_nm").Value.ToString))
                    .MoveNext()
                End While
            Else
                fg.Rows = 2
            End If
        End With
    End Sub

    Private Sub fg_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.ClickEvent

        'Dim aa, bb As String
        'Dim rs As New ADODB.Recordset
        'aa = "SELECT * from AP_Sections where Sec_id='" & fg.get_TextMatrix(fg.Row, 1) & "'  "
        'Call LoadRs(aa, rs)
        'With rs
        '    If .RecordCount > 0 Then
        '        Cmb_Sections.Text = Trim(.Fields("Sec_nmL").Value.ToString)
        '    End If
        'End With





        Txt_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        txtoerder_no.Text = fg.get_TextMatrix(fg.Row, 2)
        Txt_name.Text = fg.get_TextMatrix(fg.Row, 3)

        Cmb_Sections.Text = fg.get_TextMatrix(fg.Row, 6)
        txtSection_ID.Text = fg.get_TextMatrix(fg.Row, 5)
        Dim r As New ADODB.Recordset
        Dim bb As String
        bb = "SELECT * from Department where Group_SLR_id='" & fg.get_TextMatrix(fg.Row, 4) & "'  "
        Call LoadRs(bb, r)
        With r
            If .RecordCount > 0 Then
                If (.Fields("Group_SLR_id").Value.ToString) = 1 Then
                    cmb_type.SelectedIndex = 0
                Else
                    cmb_type.SelectedIndex = 1
                End If


            End If
        End With
    End Sub

    Private Sub fg_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.ClientSizeChanged

    End Sub

    Private Sub fg_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DblClick
        'If fg.Row = 0 Or fg.get_TextMatrix(fg.Row, 1) = "" Then Exit Sub
        'Txt_ID.Enabled = False
        'txtSection_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        'Cmb_Sections.Text = fg.get_TextMatrix(fg.Row, 2)
        'txtno.Text = fg.get_TextMatrix(fg.Row, 2)
        'Txt_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        'Txt_name.Text = fg.get_TextMatrix(fg.Row, 2)
    End Sub

    Private Sub fg_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.SelChange

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Txt_ID.Text = ""
        Txt_name.Text = ""
        Txt_ID.Visible = True
        Txt_ID.Enabled = True
        txtno.Text = ""
        cmb_type.SelectedIndex = 0
        AutoNumber()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການນີ້: " & Trim(fg.get_TextMatrix(fg.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From Department Where  Dp_ID=N'" & Trim(fg.get_TextMatrix(fg.Row, 1)) & "' ")
            Call LoadData()
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TxtPV_NM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Sections.SelectedIndexChanged
        'Dim RSC As New ADODB.Recordset
        'Call LoadRs("Select * From AP_Sections Where Sec_nmL=N'" & Trim(Cmb_Sections.Text) & "'   ", RSC)
        'If RSC.RecordCount > 0 Then
        '    txtSection_ID.Text = Trim(RSC("Sec_id").Value)
        'End If
        'AutoNumber()
        'Txt_name.Text = "" 
        'Call LoadData()
        If Cmb_Sections.SelectedIndex = 0 Then
            txtSection_ID.Text = "01"
        ElseIf Cmb_Sections.SelectedIndex = 1 Then
            txtSection_ID.Text = "02"
        Else
            txtSection_ID.Text = "03"
        End If
    End Sub

    Private Sub cmb_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_type.SelectedIndexChanged
        If cmb_type.SelectedIndex = 0 Then
            txttype_Id.Text = 1
        Else
            txttype_Id.Text = 2
        End If
    End Sub
End Class