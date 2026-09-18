Public Class frmTax_Unit

    Private Sub frmTax_Unit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FG.FormatString = "^No  |^For Month    |<Unit Tax1|>Money Tax LAK|<Unit Tax2|>Money Tax LAK|<Unit Tax3|>Money Tax LAK|<Unit Tax4|>Money Tax LAK|<Unit Tax5|>Money Tax LAK|<Unit Tax6|>Money Tax LAK|<Unit Tax7|>Money Tax LAK          "
        loadlistEDIT()
    End Sub

    Private Sub loadlistEDIT()
        Dim aa As String
        FG.Rows = 1
        With RSC
            aa = "  SELECT * from Unit_Tax   order by cnt "
            'aa = "  SELECT * from Unit_Tax WHERE   month(For_month) ='" & Month(dt_month.Value) & "' and year(For_month) ='" & Year(dt_month.Value) & "'  order by cnt "
            Call LoadRs(aa, RSC)
            If .RecordCount > 0 Then

                While Not .EOF
                FG.AddItem(.AbsolutePosition & _
                             Chr(9) & Format(CDate(.Fields("For_month").Value), "MM/yyyy") & _
                           Chr(9) & .Fields("Tax1").Value & _
                      Chr(9) & Format(CDbl(.Fields("Tax_LAK1").Value), "##,##0.00") & _
                            Chr(9) & .Fields("Tax2").Value & _
                      Chr(9) & Format(CDbl(.Fields("Tax_LAK2").Value), "##,##0.00") & _
                            Chr(9) & .Fields("Tax3").Value & _
                      Chr(9) & Format(CDbl(.Fields("Tax_LAK3").Value), "##,##0.00") & _
                            Chr(9) & .Fields("Tax4").Value & _
                      Chr(9) & Format(CDbl(.Fields("Tax_LAK4").Value), "##,##0.00") & _
                            Chr(9) & .Fields("Tax5").Value & _
                      Chr(9) & Format(CDbl(.Fields("Tax_LAK5").Value), "##,##0.00") & _
                            Chr(9) & .Fields("Tax6").Value & _
                      Chr(9) & Format(CDbl(.Fields("Tax_LAK6").Value), "##,##0.00") & _
                            Chr(9) & .Fields("Tax7").Value & _
                     Chr(9) & Format(CDbl(.Fields("Tax_LAK7").Value), "##,##0.00"))

                    .MoveNext()


                End While
            Else
                FG.Rows = 2
            End If
        End With

        For i = 1 To FG.Rows - 1
            FG.set_TextMatrix(i, 0, i)
        Next i
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SAVE()
        MsgBox("ບັນທຶກສຳເລັດ!", MsgBoxStyle.OkOnly)
        loadlistEDIT()
    End Sub
    Private Sub SAVE()
        Dim sssss, aaa As String
        Dim rs As New ADODB.Recordset
        aaa = "SELECT * FROM Unit_Tax WHERE  month(For_month) ='" & (dt_month.Value.Month) & "' and year(For_month) ='" & (dt_month.Value.Year) & "'"
        Call LoadRs(aaa, rs)

        If rs.RecordCount = 0 Then
            sssss = "INSERT INTO Unit_Tax(For_month, Tax1, Tax_LAK1, Tax2, Tax_LAK2, Tax3, Tax_LAK3, Tax4, Tax_LAK4, Tax5, Tax_LAK5, Tax6, Tax_LAK6, Tax7, Tax_LAK7, Lst_Updt, Lst_Usr, pc_nm) " & _
              " VALUES( N'" & (Format(dt_month.Value, "yyyy-MM-dd")) & "'," & _
                                 "" & CDbl(txtTax1.Text) & "," & _
                                     "" & CDbl(txtTax_LAK1.Text) & "," & _
                                       "" & CDbl(txtTax2.Text) & "," & _
                                     "" & CDbl(txtTax_LAK2.Text) & "," & _
                                       "" & CDbl(txtTax3.Text) & "," & _
                                     "" & CDbl(txtTax_LAK3.Text) & "," & _
                                       "" & CDbl(txtTax4.Text) & "," & _
                                     "" & CDbl(txtTax_LAK4.Text) & "," & _
                                       "" & CDbl(txtTax5.Text) & "," & _
                                     "" & CDbl(txtTax_LAK5.Text) & "," & _
                                       "" & CDbl(txtTax6.Text) & "," & _
                                     "" & CDbl(txtTax_LAK6.Text) & "," & _
                                       "" & CDbl(txtTax7.Text) & "," & _
                                     "" & CDbl(txtTax_LAK7.Text) & "," & _
                           " '" & Format(Date.Today, "yyyy-MM-dd") & "'," & _
            " N'" & MUserName & "', " & _
      " N'" & MDServerName & "')"

            Conn.Execute(sssss)
        Else
            Conn.Execute("DELETE FROM Unit_Tax WHERE  month(For_month) ='" & Month(dt_month.Value) & "' and year(For_month) ='" & Year(dt_month.Value) & "' ")
            sssss = "INSERT INTO Unit_Tax(For_month, Tax1, Tax_LAK1, Tax2, Tax_LAK2, Tax3, Tax_LAK3, Tax4, Tax_LAK4, Tax5, Tax_LAK5, Tax6, Tax_LAK6, Tax7, Tax_LAK7, Lst_Updt, Lst_Usr, pc_nm) " & _
                " VALUES( N'" & (Format(dt_month.Value, "yyyy-MM-dd")) & "'," & _
                                   "" & CDbl(txtTax1.Text) & "," & _
                                       "" & CDbl(txtTax_LAK1.Text) & "," & _
                                         "" & CDbl(txtTax2.Text) & "," & _
                                       "" & CDbl(txtTax_LAK2.Text) & "," & _
                                         "" & CDbl(txtTax3.Text) & "," & _
                                       "" & CDbl(txtTax_LAK3.Text) & "," & _
                                         "" & CDbl(txtTax4.Text) & "," & _
                                       "" & CDbl(txtTax_LAK4.Text) & "," & _
                                         "" & CDbl(txtTax5.Text) & "," & _
                                       "" & CDbl(txtTax_LAK5.Text) & "," & _
                                         "" & CDbl(txtTax6.Text) & "," & _
                                       "" & CDbl(txtTax_LAK6.Text) & "," & _
                                         "" & CDbl(txtTax7.Text) & "," & _
                                       "" & CDbl(txtTax_LAK7.Text) & "," & _
                             " '" & Format(Date.Today, "yyyy-MM-dd") & "'," & _
              " N'" & MUserName & "', " & _
        " N'" & MDServerName & "')"
            CNN.Execute(sssss)


        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub txtTax1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax1.TextChanged
        If IsNumeric(txtTax1.Text) = False Or txtTax1.Text = "" Then
            txtTax1.Text = 0

        End If
    End Sub

    Private Sub txtTax_LAK1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTax_LAK1.KeyPress
        If e.KeyChar = Chr(13) Then

            txtTax_LAK1.Text = Format(CDbl(txtTax_LAK1.Text), "#,##0.00")
         
            txtTax_LAK2.Focus()
        End If
    End Sub

    Private Sub txtTax_LAK1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax_LAK1.TextChanged
        If IsNumeric(txtTax_LAK1.Text) = False Or txtTax_LAK1.Text = "" Then
            txtTax_LAK1.Text = 0
            txtTax_LAK1.Text = Format(CDbl(txtTax_LAK1.Text), "##,##0.00")
        End If
  
    End Sub

    Private Sub txtTax_LAK2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTax_LAK2.KeyPress
        If e.KeyChar = Chr(13) Then

            txtTax_LAK2.Text = Format(CDbl(txtTax_LAK2.Text), "#,##0.00")

            txtTax_LAK3.Focus()
        End If
    End Sub

    Private Sub txtTax_LAK2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax_LAK2.TextChanged

        If IsNumeric(txtTax_LAK2.Text) = False Or txtTax_LAK2.Text = "" Then
            txtTax_LAK2.Text = 0
            txtTax_LAK2.Text = Format(CDbl(txtTax_LAK1.Text), "##,##0.00")
        End If
    End Sub

    Private Sub txtTax_LAK3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTax_LAK3.KeyPress
        If e.KeyChar = Chr(13) Then

            txtTax_LAK3.Text = Format(CDbl(txtTax_LAK3.Text), "#,##0.00")

            txtTax_LAK4.Focus()
        End If
    End Sub

    Private Sub txtTax_LAK3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax_LAK3.TextChanged
        If IsNumeric(txtTax_LAK3.Text) = False Or txtTax_LAK3.Text = "" Then
            txtTax_LAK3.Text = 0
            txtTax_LAK3.Text = Format(CDbl(txtTax_LAK3.Text), "##,##0.00")
        End If

    End Sub

    Private Sub txtTax_LAK4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTax_LAK4.KeyPress
        If e.KeyChar = Chr(13) Then

            txtTax_LAK4.Text = Format(CDbl(txtTax_LAK4.Text), "#,##0.00")

            txtTax_LAK5.Focus()
        End If
    End Sub

    Private Sub txtTax_LAK4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax_LAK4.TextChanged
        If IsNumeric(txtTax_LAK4.Text) = False Or txtTax_LAK4.Text = "" Then
            txtTax_LAK4.Text = 0
            txtTax_LAK4.Text = Format(CDbl(txtTax_LAK4.Text), "##,##0.00")
        End If
         
    End Sub

    Private Sub txtTax_LAK5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTax_LAK5.KeyPress
        If e.KeyChar = Chr(13) Then

            txtTax_LAK5.Text = Format(CDbl(txtTax_LAK5.Text), "#,##0.00")

            txtTax_LAK6.Focus()
        End If
    End Sub

    Private Sub txtTax_LAK5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax_LAK5.TextChanged
        If IsNumeric(txtTax_LAK5.Text) = False Or txtTax_LAK5.Text = "" Then
            txtTax_LAK5.Text = 0
            txtTax_LAK5.Text = Format(CDbl(txtTax_LAK5.Text), "##,##0.00")
        End If
         
    End Sub

    Private Sub txtTax_LAK6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTax_LAK6.KeyPress
        If e.KeyChar = Chr(13) Then

            txtTax_LAK6.Text = Format(CDbl(txtTax_LAK6.Text), "#,##0.00")

            txtTax_LAK7.Focus()
        End If
    End Sub

    Private Sub txtTax_LAK6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax_LAK6.TextChanged

        If IsNumeric(txtTax_LAK6.Text) = False Or txtTax_LAK6.Text = "" Then
            txtTax_LAK6.Text = 0
            txtTax_LAK6.Text = Format(CDbl(txtTax_LAK6.Text), "##,##0.00")
        End If
    End Sub

    Private Sub txtTax2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax2.TextChanged
        If IsNumeric(txtTax2.Text) = False Or txtTax2.Text = "" Then
            txtTax2.Text = 0

        End If
    End Sub

    Private Sub txtTax3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax3.TextChanged
        If IsNumeric(txtTax3.Text) = False Or txtTax3.Text = "" Then
            txtTax3.Text = 0

        End If
    End Sub

    Private Sub txtTax4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax4.TextChanged
        If IsNumeric(txtTax4.Text) = False Or txtTax4.Text = "" Then
            txtTax4.Text = 0

        End If
    End Sub

    Private Sub txtTax5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax5.TextChanged
        If IsNumeric(txtTax5.Text) = False Or txtTax5.Text = "" Then
            txtTax5.Text = 0

        End If
    End Sub

    Private Sub txtTax6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax6.TextChanged
        If IsNumeric(txtTax6.Text) = False Or txtTax6.Text = "" Then
            txtTax6.Text = 0

        End If
    End Sub

    Private Sub txtTax7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax7.TextChanged
        If IsNumeric(txtTax7.Text) = False Or txtTax7.Text = "" Then
            txtTax7.Text = 0

        End If
    End Sub

    Private Sub txtTax_LAK7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax_LAK7.TextChanged
        If IsNumeric(txtTax_LAK7.Text) = False Or txtTax_LAK7.Text = "" Then
            txtTax_LAK7.Text = 0
            txtTax_LAK7.Text = Format(CDbl(txtTax_LAK7.Text), "##,##0.00")
        End If
    End Sub

    Private Sub FG_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG.ClickEvent
        dt_month.Text = FG.get_TextMatrix(FG.Row, 1)
        txtTax1.Text = FG.get_TextMatrix(FG.Row, 2)
        txtTax_LAK1.Text = Format(CDbl(FG.get_TextMatrix(FG.Row, 3)), "##,##0.00")
        txtTax2.Text = FG.get_TextMatrix(FG.Row, 4)
        txtTax_LAK2.Text = Format(CDbl(FG.get_TextMatrix(FG.Row, 5)), "##,##0.00")
        txtTax3.Text = FG.get_TextMatrix(FG.Row, 6)
        txtTax_LAK3.Text = Format(CDbl(FG.get_TextMatrix(FG.Row, 7)), "##,##0.00")
        txtTax4.Text = FG.get_TextMatrix(FG.Row, 8)
        txtTax_LAK4.Text = Format(CDbl(FG.get_TextMatrix(FG.Row, 9)), "##,##0.00")
        txtTax5.Text = FG.get_TextMatrix(FG.Row, 10)
        txtTax_LAK5.Text = Format(CDbl(FG.get_TextMatrix(FG.Row, 11)), "##,##0.00")
        txtTax6.Text = FG.get_TextMatrix(FG.Row, 12)
        txtTax_LAK6.Text = Format(CDbl(FG.get_TextMatrix(FG.Row, 13)), "##,##0.00")
        txtTax7.Text = FG.get_TextMatrix(FG.Row, 14)
        txtTax_LAK7.Text = Format(CDbl(FG.get_TextMatrix(FG.Row, 15)), "##,##0.00")


        'Dim aa As String
        'Dim rs As New ADODB.Recordset
        'aa = "  SELECT * from Unit_Tax   order by cnt "
        ''aa = "  SELECT * from Unit_Tax WHERE   month(For_month) ='" & Month(dt_month.Value) & "' and year(For_month) ='" & Year(dt_month.Value) & "'  order by cnt "
        'Call LoadRs(aa, rs)
        'With rs
        '    If rs.RecordCount <> 0 Then



        '        'dt_month.Text = .Fields("For_month").Value
        '        'txtTax_LAK1.Text = .Fields("Tax1").Value.ToString
        '        'txtTax_LAK1.Text = Format(CDbl(.Fields("Tax_LAK1").Value), "##,##0.00")
        '        'txtTax_LAK2.Text = .Fields("Tax2").Value.ToString
        '        'txtTax_LAK2.Text = Format(CDbl(.Fields("Tax_LAK2").Value), "##,##0.00")
        '        'txtTax_LAK3.Text = .Fields("Tax3").Value.ToString
        '        'txtTax_LAK3.Text = Format(CDbl(.Fields("Tax_LAK3").Value), "##,##0.00")
        '        'txtTax_LAK4.Text = .Fields("Tax4").Value.ToString
        '        'txtTax_LAK4.Text = Format(CDbl(.Fields("Tax_LAK4").Value), "##,##0.00")
        '        'txtTax_LAK5.Text = .Fields("Tax5").Value.ToString
        '        'txtTax_LAK5.Text = Format(CDbl(.Fields("Tax_LAK5").Value), "##,##0.00")
        '        'txtTax_LAK6.Text = .Fields("Tax6").Value.ToString
        '        'txtTax_LAK6.Text = Format(CDbl(.Fields("Tax_LAK6").Value), "##,##0.00")
        '        'txtTax_LAK7.Text = .Fields("Tax7").Value.ToString
        '        'txtTax_LAK7.Text = Format(CDbl(.Fields("Tax_LAK7").Value), "##,##0.00")
        '    End If


        'End With
    End Sub

    Private Sub FG_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG.SelChange

    End Sub

    Private Sub dt_month_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_month.ValueChanged
        loadlistEDIT()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to delete  ?'" & FG.get_TextMatrix(FG.Row, 1) & "' ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            CNN.Execute("DELETE FROM Unit_Tax WHERE  month(For_month) ='" & Month(dt_month.Value) & "' and year(For_month) ='" & Year(dt_month.Value) & "' ")

            If FG.Rows > 1 Then
                FG.RemoveItem(FG.Row)
            Else
                FG.Rows = 1
                FG.Rows = 2
            End If

        End If

    End Sub
End Class