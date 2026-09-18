Public Class Frm_Village
    Dim rs As New ADODB.Recordset

    Private Sub Frm_Unit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.FormatString = "ລດ |<ລະຫັດແຂວງ         |<ຊື່ແຂວງ                 |<ລະຫັດເມືອງ         |<ຊື່ເມືອງ                             |<ລະຫັດບ້ານ        |<ຊື່ບ້ານ                      "
        fg.set_ColHidden(1, True)
        fg.set_ColHidden(2, True)
        fg.set_ColHidden(3, True)
        fg.set_ColHidden(4, True)
        TxtPV_NM.Items.Clear()
        Call load_Cmb(" SELECT PV_nm FROM AP_Province ORDER BY PV_ID ", "PV_nm", TxtPV_NM)
        If TxtPV_NM.Items.Count > 0 Then
            TxtPV_NM.SelectedIndex = 0
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtDt_id.Text = "" Then MsgBox("Please add product Type ID !", MsgBoxStyle.OkOnly) : TxtDt_id.Focus() : Exit Sub
        If TxtDt_id.Enabled = True Then
            If TxtDt_Nm.Text = "" Then MsgBox("Please add Unit Type name !", MsgBoxStyle.OkOnly) : TxtDt_Nm.Focus() : Exit Sub
            Call LoadRs("SELECT Vl_ID FROM AP_Village WHERE Vl_ID = '" & Trim(TxtDt_id.Text) & "' AND PV_ID='" & TxtPV_ID.Text & "' AND Dt_id='" & TxtPV_ID.Text & "'", RSC)
            If RSC.RecordCount > 0 Then
                MsgBox("ລະຫັດສາຍນີ້ມີແລ້ວ : " & Trim(TxtDt_id.Text) & "  ກະລຸນາປ່ຽນເລກໃໝ່!", MsgBoxStyle.OkOnly)
                TxtDt_id.Focus()
                If RSC.State = ConnectionState.Open Then RSC.Close()
                Exit Sub
            End If
            If RSC.State = ConnectionState.Open Then RSC.Close()
        End If
        Call save()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
        Call LoadData()
        TxtDt_id.Focus()
    End Sub
    Public Sub save()
        Call LoadRs("SELECT Vl_ID FROM AP_Village WHERE Vl_ID = '" & txtvl_id.Text & "'  ", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO AP_Village (PV_id,Dt_id,Vl_ID,Vl_nm) " & _
                   " VALUES(N'" & Apostrophe(TxtPV_ID.Text.Trim) & "'," & _
                  " N'" & Apostrophe(TxtDt_id.Text.Trim) & "'," & _
                    " N'" & Apostrophe(txtvl_id.Text.Trim) & "'," & _
                   " N'" & txtvl_Nm.Text & "')")
            Else
                Conn.Execute("UPDATE AP_Village SET " & _
                   " PV_id=N'" & TxtPV_ID.Text & "', " & _
                    " Dt_id=N'" & TxtDt_id.Text & "', " & _
                   " Vl_nm=N'" & txtvl_Nm.Text & "' " & _
                   " WHERE Vl_ID= '" & (txtvl_id.Text) & "'  ")
            End If
        End With

    End Sub
    Public Sub LoadData()
        fg.Rows = 1
        With rs
            Call LoadRs(" SELECT     dbo.AP_Village.*, dbo.AP_Province.PV_nm, dbo.AP_District.Dt_nm  " & _
                      " FROM         dbo.AP_Village INNER JOIN  " & _
                      " dbo.AP_Province ON dbo.AP_Village.PV_id = dbo.AP_Province.PV_ID INNER JOIN " & _
                      " dbo.AP_District ON dbo.AP_Village.Dt_id = dbo.AP_District.Dt_id Where dbo.AP_District.Dt_id ='" & TxtDt_id.Text & "' order by  dbo.AP_Village.Dt_id  ", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    fg.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("PV_ID").Value.ToString) & _
                      Chr(9) & (.Fields("PV_nm").Value.ToString) & _
                      Chr(9) & (.Fields("Dt_id").Value.ToString) & _
                    Chr(9) & (.Fields("Dt_nm").Value.ToString) & _
                       Chr(9) & (.Fields("Vl_ID").Value.ToString) & _
                    Chr(9) & (.Fields("Vl_nm").Value.ToString))
                    .MoveNext()
                End While
            End If
        End With

    End Sub
    Public Sub LoadData_Dt()
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
        txtvl_id.Enabled = False
        TxtPV_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        TxtPV_NM.Text = fg.get_TextMatrix(fg.Row, 2)
        TxtDt_id.Text = fg.get_TextMatrix(fg.Row, 3)
        TxtDt_Nm.Text = fg.get_TextMatrix(fg.Row, 4)
        txtvl_id.Text = fg.get_TextMatrix(fg.Row, 5)
        txtvl_Nm.Text = fg.get_TextMatrix(fg.Row, 6)
    End Sub

    Private Sub fg_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.SelChange

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        TxtDt_id.Text = ""
        TxtDt_Nm.Text = ""
        TxtDt_id.Visible = True
        TxtDt_id.Enabled = True
        txtvl_id.Text = ""
        txtvl_Nm.Text = ""
        txtvl_id.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການນີ້: " & Trim(fg.get_TextMatrix(fg.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From AP_Village Where Vl_ID='" & txtvl_id.Text & "' AND  Dt_id='" & TxtDt_id.Text & "' AND PV_ID='" & TxtPV_ID.Text & "'")
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


        TxtDt_Nm.Items.Clear()
        Call load_Cmb(" SELECT Dt_nm FROM AP_District  WHERE PV_ID='" & TxtPV_ID.Text & "' ORDER BY Dt_id ", "Dt_nm", TxtDt_Nm)
        If TxtDt_Nm.Items.Count > 0 Then
            TxtDt_Nm.SelectedIndex = 0
            TxtDt_Nm.Text = ""
            TxtDt_id.Text = ""

        End If
    End Sub

    Private Sub TxtDt_Nm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDt_Nm.SelectedIndexChanged
        Call LoadRs("Select *  From AP_District Where   Dt_nm =N'" & Trim(TxtDt_Nm.Text) & "'  and pv_id =N'" & Trim(TxtPV_ID.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            TxtDt_id.Text = Trim(rs("Dt_id").Value)
        End If

        Call LoadData()
    End Sub
End Class