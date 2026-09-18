Public Class Frm_Location
    Dim rs As New ADODB.Recordset

    Private Sub Frm_Unit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.FormatString = "ລດ |<ລະຫັດ               |<ລາຍການພາກສ່ວນ                          "
        Call LoadData()
        BtnAddNew_Click(sender, e)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Txt_ID.Text = "" Then MsgBox("Please add product Type ID !", MsgBoxStyle.OkOnly) : Txt_ID.Focus() : Exit Sub
        If Txt_ID.Enabled = True Then
            If Txt_name.Text = "" Then MsgBox("Please add Unit Type name !", MsgBoxStyle.OkOnly) : Txt_name.Focus() : Exit Sub
            Call LoadRs("SELECT PV_ID FROM AP_Province WHERE PV_ID = '" & Trim(Txt_ID.Text) & "'", RSC)
            If RSC.RecordCount > 0 Then
                MsgBox("ລະຫັດສາຍນີ້ມີແລ້ວ : " & Trim(Txt_ID.Text) & "  ກະລຸນາປ່ຽນເລກໃໝ່!", MsgBoxStyle.OkOnly)
                Txt_ID.Focus()
                If RSC.State = ConnectionState.Open Then RSC.Close()
                Exit Sub
            End If
            If RSC.State = ConnectionState.Open Then RSC.Close()
        End If
        Call save()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
        Call LoadData()
        Txt_ID.Focus()
    End Sub
    Public Sub save()
        Call LoadRs("SELECT PV_ID FROM AP_Province WHERE PV_ID = '" & Txt_ID.Text & "'  ", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO AP_Province (PV_ID,PV_nm) " & _
                   " VALUES(N'" & Apostrophe(Txt_ID.Text.Trim) & "'," & _
                   " N'" & Txt_name.Text & "')")
            Else
                Conn.Execute("UPDATE AP_Province SET " & _
                   " PV_nm=N'" & Txt_name.Text & "' " & _
                   " WHERE PV_ID= '" & (Txt_ID.Text) & "'  ")
            End If
        End With

    End Sub
    Public Sub LoadData()
        fg.Rows = 1
        With rs
            Call LoadRs("select *  from AP_Province order by PV_ID", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    fg.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("PV_ID").Value.ToString) & _
                    Chr(9) & (.Fields("PV_nm").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub fg_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DblClick
        If fg.Row = 0 Or fg.get_TextMatrix(fg.Row, 1) = "" Then Exit Sub
        Txt_ID.Enabled = False
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
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການນີ້: " & Trim(fg.get_TextMatrix(fg.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Province Where  PV_ID='" & Trim(fg.get_TextMatrix(fg.Row, 1) & "'"))
            Call LoadData()
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class