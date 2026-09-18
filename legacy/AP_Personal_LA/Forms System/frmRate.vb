
Public Class frmRate
    Dim Sql As String
    Private Sub Rate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FG.FormatString = "No    |<ປະເທດ                      |< ສະກຸນເງິນ     |<ເງິນ                                      "
        Sql = ""
        Call loadlistEDIT()
    End Sub

    Private Sub loadlistEDIT1()
        Dim aa As String
        FG.Rows = 1
        With RSC
            aa = "  SELECT * from AP_Rate_Item    order by  Dt_Rate "
            'aa = "  SELECT * from AP_Rate_Item WHERE   month(Dt_Rate) ='" & Format((dtp_Month.Value), "MM") & "' order by cnt "
            Call LoadRs(aa, RSC)
            If .RecordCount > 0 Then

                While Not .EOF
                    FG.AddItem(.AbsolutePosition & _
                               Chr(9) & .Fields("Curr").Value & _
                                      Chr(9) & .Fields("cuntry").Value & _
                         Chr(9) & Format(CDbl(.Fields("money").Value), "##,##0.00"))

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


    Private Sub loadlistEDIT()
        Dim aa As String
        FG.Rows = 1
        With RSC
            aa = "  SELECT  * from AP_Rate_Item WHERE 1=1 " & Sql & "   order by cnt "
            'aa = "  SELECT * from AP_Rate_Item WHERE   month(Dt_Rate) ='" & Format((dtp_Month.Value), "MM") & "' order by cnt "
            Call LoadRs(aa, RSC)
            If .RecordCount > 0 Then

                While Not .EOF
                    FG.AddItem(.AbsolutePosition & _
                               Chr(9) & .Fields("Curr").Value & _
                                      Chr(9) & .Fields("cuntry").Value & _
                         Chr(9) & Format(CDbl(.Fields("money").Value), "##,##0.00"))

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

    Private Sub FG_AfterEdit(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_AfterEditEvent) Handles FG.AfterEdit
        FG.set_TextMatrix(FG.Row, 3, Format(CDbl(FG.get_TextMatrix(FG.Row, 3)), "#,##0.00"))
    End Sub

    Private Sub FG_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG.ClickEvent
        If FG.Col = 1 Or 2 Or 3 Or 4 Then

            FG.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
        FG.set_TextMatrix(FG.Row, 3, Format(CDbl(FG.get_TextMatrix(FG.Row, 3)), "#,##0.00"))
    End Sub

    Private Sub FG_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG.SelChange
        If FG.Col = 1 Or 2 Or 3 Then

            FG.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
        FG.set_TextMatrix(FG.Row, 3, Format(CDbl(FG.get_TextMatrix(FG.Row, 3)), "#,##0.00"))
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        FG.Rows = FG.Rows + 1
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If FG.get_TextMatrix(FG.Row, 1) = "" Then
            FG.RemoveItem(FG.Row)
        Else
            AccCD = FG.get_TextMatrix(FG.Row, 1)
            If MessageBox.Show("Do you want to cancle '" & AccCD & "' yes or no ?", "Cancle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                FG.RemoveItem(FG.Row)
                If FG.Rows = 1 Then FG.Rows = 1
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Conn.Execute("DELETE FROM AP_Rate_Item  ")
        'Conn.Execute("DELETE FROM AP_Rate_Item where  month(Dt_Rate) ='" & Month(dtp_Month.Value) & "' and year(Dt_Rate) ='" & Year(dtp_Month.Value) & "'  ")
        Call SaveItem()
        MsgBox("ບັນທຶກສຳເລັດ")
    End Sub
    Private Sub SaveItem()
        Dim ww As String
        Dim i As Integer
        Dim RcItem As New ADODB.Recordset
        With RcItem
            Call LoadRs("SELECT * FROM  AP_Rate_Item ", RcItem)
            For i = 1 To FG.Rows - 1
                If .RecordCount = 0 Then

                    ww = " INSERT INTO  AP_Rate_Item ( Dt_Rate,cuntry,Curr,money,Lst_Updt,Lst_Usr,pc_nm) " & _
                        "VALUES( " & _
                            " '" & Format((dtp_Month.Value), "yyyy-MM-dd") & "'," & _
                             "N'" & FG.get_TextMatrix(i, 1) & "'," & _
                                "N'" & FG.get_TextMatrix(i, 2) & "'," & _
                           "" & CDbl(FG.get_TextMatrix(i, 3)) & "," & _
                         " '" & Format(Date.Today, "yyyy-MM-dd") & "'," & _
                         " N'" & MUserName & "', " & _
                   " N'" & MDServerName & "')"
                    Conn.Execute(ww)

                Else
                End If
            Next i
        End With

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub dtp_Month_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Month.ValueChanged
        Sql = " and month(Dt_Rate) ='" & Month(dtp_Month.Value) & "' and year(Dt_Rate) ='" & Year(dtp_Month.Value) & "' "
        Call loadlistEDIT()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub
End Class