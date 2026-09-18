Public Class Frm_Education
    Dim rs As New ADODB.Recordset

    Private Sub Frm_Location_ForCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.FormatString = "ລດ |<ລະຫັດ         |<ຊື່                            "
        'fg.set_ColHidden(1, True)
        'fg.set_ColHidden(2, True)

        Call LoadData()
        BtnAddNew_Click(sender, e)
    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 E_ID from Education    Order by E_ID DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("E_ID").Value, 1, 2)) + 1, "00")
        Else
            VIOTNEW = "01"

        End If
        Txt_ID.Text = Trim(CStr(VIOTNEW.ToString))
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Txt_ID.Text = "" Then MsgBox("Type ID !", MsgBoxStyle.OkOnly) : Txt_ID.Focus() : Exit Sub

        Call save()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
        Call LoadData()
        Txt_ID.Focus()
    End Sub
    Public Sub save()
        Call LoadRs("SELECT * FROM Education WHERE E_ID = '" & Txt_ID.Text & "'  ", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO Education (E_ID,E_Nm) " & _
                   " VALUES('" & (Txt_ID.Text) & "'," & _
                                 " N'" & Txt_name.Text & "')")
            Else
                Conn.Execute("UPDATE Education SET " & _
                        " E_Nm=N'" & Txt_name.Text & "' " & _
                   " WHERE E_ID= '" & (Txt_ID.Text) & "'  ")
            End If
        End With

    End Sub
    Public Sub LoadData()
        fg.Rows = 1
        With rs
            Call LoadRs("SELECT   * from Education order by  E_ID", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    fg.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("E_ID").Value.ToString) & _
                    Chr(9) & (.Fields("E_Nm").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub fg_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.ClickEvent
        Txt_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        txtno.Text = fg.get_TextMatrix(fg.Row, 2)
        Txt_name.Text = fg.get_TextMatrix(fg.Row, 2)
    End Sub

    Private Sub fg_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DblClick
        If fg.Row = 0 Or fg.get_TextMatrix(fg.Row, 1) = "" Then Exit Sub
        Txt_ID.Enabled = False
        TxtPV_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        TxtPV_NM.Text = fg.get_TextMatrix(fg.Row, 2)
        txtno.Text = fg.get_TextMatrix(fg.Row, 2)
        Txt_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        Txt_name.Text = fg.get_TextMatrix(fg.Row, 2)
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
        AutoNumber()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການນີ້: " & Trim(fg.get_TextMatrix(fg.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From Education Where  E_ID=N'" & Trim(fg.get_TextMatrix(fg.Row, 1)) & "' ")
            Call LoadData()
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TxtPV_NM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPV_NM.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Province Where   PV_nm =N'" & Trim(TxtPV_NM.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            TxtPV_ID.Text = Trim(rs("PV_ID").Value)
        End If
        Call LoadData()
    End Sub
End Class