Public Class Frm_District
    Dim rs As New ADODB.Recordset

    Private Sub Frm_Unit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.FormatString = "ລດ |<ລະຫັດແຂວງ         |<ຊື່ແຂວງ                 |<ລະຫັດເມືອງ         |<ຊື່ເມືອງ                             "
        fg.set_ColHidden(1, True)
        fg.set_ColHidden(2, True)
        TxtPV_NM.Items.Clear()
        Call load_Cmb(" SELECT PV_nm FROM AP_Province ORDER BY PV_ID ", "PV_nm", TxtPV_NM)
        If TxtPV_NM.Items.Count > 0 Then
            TxtPV_NM.SelectedIndex = 0
        End If
        Call LoadData()
        BtnAddNew_Click(sender, e)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Txt_ID.Text = "" Then MsgBox("Please add product Type ID !", MsgBoxStyle.OkOnly) : Txt_ID.Focus() : Exit Sub
        If Txt_ID.Enabled = True Then
            If Txt_name.Text = "" Then MsgBox("Please add Unit Type name !", MsgBoxStyle.OkOnly) : Txt_name.Focus() : Exit Sub
            Call LoadRs("SELECT Dt_id FROM AP_District WHERE Dt_id = '" & Trim(Txt_ID.Text) & "' AND PV_ID='" & TxtPV_ID.Text & "'", RSC)
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
        Call LoadRs("SELECT Dt_id FROM AP_District WHERE Dt_id = '" & Txt_ID.Text & "'  ", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO AP_District (PV_id,Dt_id,Dt_nm) " & _
                   " VALUES(N'" & Apostrophe(TxtPV_ID.Text.Trim) & "'," & _
                  " N'" & Apostrophe(Txt_ID.Text.Trim) & "'," & _
                   " N'" & Txt_name.Text & "')")
            Else
                Conn.Execute("UPDATE AP_District SET " & _
                   " PV_id=N'" & TxtPV_ID.Text & "', " & _
                   " Dt_nm=N'" & Txt_name.Text & "' " & _
                   " WHERE Dt_id= '" & (Txt_ID.Text) & "'  ")
            End If
        End With

    End Sub
    Public Sub LoadData()
        fg.Rows = 1
        With rs
            Call LoadRs("SELECT     dbo.AP_District.*, dbo.AP_Province.PV_nm " & _
                      " FROM         dbo.AP_District INNER JOIN " & _
                     " dbo.AP_Province ON dbo.AP_District.PV_id = dbo.AP_Province.PV_ID Where dbo.AP_Province.PV_ID='" & TxtPV_ID.Text & "' order by  dbo.AP_District.Dt_id", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    fg.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("PV_ID").Value.ToString) & _
                      Chr(9) & (.Fields("PV_nm").Value.ToString) & _
                      Chr(9) & (.Fields("Dt_id").Value.ToString) & _
                    Chr(9) & (.Fields("Dt_nm").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub fg_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DblClick
        If fg.Row = 0 Or fg.get_TextMatrix(fg.Row, 1) = "" Then Exit Sub
        Txt_ID.Enabled = False
        TxtPV_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        TxtPV_NM.Text = fg.get_TextMatrix(fg.Row, 2)
        Txt_ID.Text = fg.get_TextMatrix(fg.Row, 3)
        Txt_name.Text = fg.get_TextMatrix(fg.Row, 4)
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
        TxtPV_NM.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການນີ້: " & Trim(fg.get_TextMatrix(fg.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_District Where  Dt_id='" & Trim(Txt_ID.Text) & "' AND PV_ID='" & TxtPV_ID.Text & "'")
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