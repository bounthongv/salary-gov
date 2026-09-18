Public Class Frm_Index
    Dim rs As New ADODB.Recordset

    Private Sub Frm_Index_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.FormatString = "ລດ |<ລະຫັດ         |<ເລກລຳດັບຈັກລຽງ |<ລາຍລະອຽດ |<ດັດສະນິ |<ຄ່າດັດສະນິ |<ເປັນເງີນ               "
        'fg.set_ColHidden(1, True)
        'fg.set_ColHidden(2, True)

        Call LoadData()
        BtnAddNew_Click(sender, e)
        With rs
            Call LoadRs("select * from AP_Office  ", rs)
            If .RecordCount <> 0 Then
                txtindex_money.Text = Format(CDbl(.Fields("index_monney").Value), "##,##0.00")

            End If
        End With
    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 no from Level_class    Order by no DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("no").Value, 1, 3)) + 1, "000")
        Else
            VIOTNEW = "001"

        End If
        Txt_ID.Text = Trim(CStr(VIOTNEW.ToString))
        txtno.Text = Trim(CStr(VIOTNEW.ToString))
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Txt_ID.Text = "" Then MsgBox("Type ID !", MsgBoxStyle.OkOnly) : Txt_ID.Focus() : Exit Sub

        Call save()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
        Call LoadData()
        Txt_ID.Focus()
    End Sub
    Public Sub save()
        Call LoadRs("SELECT * FROM Level_class WHERE id = '" & Txt_ID.Text & "'  ", rs)
        With rs
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO Level_class (id,no,name,index_type,index_monney,Toltle) " & _
                   " VALUES('" & (Txt_ID.Text) & "'," & _
                   " N'" & txtno.Text & "', " & _
                       " N'" & Txt_name.Text & "', " & _
                        " " & CDbl(txtindex.Text) & ", " & _
                         " " & CDbl(txtindex_money.Text) & ", " & _
                                 " " & CDbl(txttoltle.Text) & ")"
                Conn.Execute(aa)
            Else
                Conn.Execute("UPDATE Level_class SET " & _
                     " no=N'" & txtno.Text & "', " & _
                     " name=N'" & Txt_name.Text & "', " & _
                       " index_type=" & CDbl(txtindex.Text) & ", " & _
                      " index_monney=" & CDbl(txtindex_money.Text) & ", " & _
                       " Toltle=" & CDbl(txttoltle.Text) & " " & _
                   " WHERE ID= '" & (Txt_ID.Text) & "'  ")
            End If
        End With

    End Sub
    Public Sub LoadData()
        fg.Rows = 1
        With rs
            Call LoadRs("SELECT   * from Level_class order by no ", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    fg.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("id").Value.ToString) & _
                       Chr(9) & (.Fields("no").Value.ToString) & _
                    Chr(9) & (.Fields("name").Value.ToString) & _
                       Chr(9) & (.Fields("index_type").Value.ToString) & _
                            Chr(9) & Format(.Fields("index_monney").Value, "##,##0.00") & _
                              Chr(9) & Format(.Fields("Toltle").Value, "##,##0.00"))
                    .MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub fg_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.ClickEvent
        txtindex.Text = fg.get_TextMatrix(fg.Row, 4)
        txtindex_money.Text = fg.get_TextMatrix(fg.Row, 5)
        txttoltle.Text = fg.get_TextMatrix(fg.Row, 6)
        txtno.Text = fg.get_TextMatrix(fg.Row, 2)
        Txt_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        Txt_name.Text = fg.get_TextMatrix(fg.Row, 3)
    End Sub

    Private Sub fg_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DblClick
        If fg.Row = 0 Or fg.get_TextMatrix(fg.Row, 1) = "" Then Exit Sub
        Txt_ID.Enabled = False
        txtindex.Text = fg.get_TextMatrix(fg.Row, 4)
        txtindex_money.Text = fg.get_TextMatrix(fg.Row, 5)
        txttoltle.Text = fg.get_TextMatrix(fg.Row, 6)
        txtno.Text = fg.get_TextMatrix(fg.Row, 2)
        Txt_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        Txt_name.Text = fg.get_TextMatrix(fg.Row, 3)
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
        'txtno.Text = ""
        'txtindex.Text = 0
        'txtindex_money.Text = 0
        txttoltle.Text = 0
        AutoNumber()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການນີ້: " & Trim(fg.get_TextMatrix(fg.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From Level_class Where  no=N'" & Trim(fg.get_TextMatrix(fg.Row, 2)) & "' ")
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

    Private Sub txtindex_money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtindex_money.TextChanged

        txtindex_money.Text = Format(CDbl(txtindex_money.Text), "#,##0.00")

    End Sub

    Private Sub txtindex_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtindex.KeyPress
        If e.KeyChar = Chr(13) Then

            txttoltle.Text = CDbl(txtindex.Text) * CDbl(txtindex_money.Text)
            txttoltle.Text = Format(CDbl(txttoltle.Text), "#,##0.00")
        End If
    End Sub

    Private Sub txtindex_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtindex.TextChanged

    End Sub

    Private Sub txttoltle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttoltle.TextChanged

    End Sub
End Class