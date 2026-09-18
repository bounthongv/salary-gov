Option Explicit On
Imports System.Data.SqlClient
Public Class FrmMonthlyclosingaccount_S
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim Sdate As String
    Dim ClsAcc As Integer = 1
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim RsCheck As New ADODB.Recordset
        With RsCheck
            Call LoadRs("select Open_dt from AP_open_bl_S WHERE month(Open_dt)= '" & Month(DateAdd("m", 1, CDate(Me.lblFromDate.Text & "/" & Me.lblToDate.Text))) & "'  and  year(Open_dt)='" & Year(DateAdd("m", 1, CDate(Me.lblFromDate.Text & "/" & Me.lblToDate.Text))) & "'", RsCheck)
            If .RecordCount <> 0 Then
                MsgBox("Month " & Me.txtMonth.Value & "/" & Me.txtYear.Value & " do to close account", MsgBoxStyle.OkOnly)
                RsCheck = Nothing
                Exit Sub
            Else
                Call LoadRs("select Open_dt from AP_open_bl_S WHERE month(Open_dt)= '" & (Me.lblFromDate.Text) & "'  and  year(Open_dt)='" & (Me.lblToDate.Text) & "' ", RsCheck)
                If .RecordCount = 0 Then
                    MsgBox("¨Open balance of month " & Format(CDate(Me.txtMonth.Value), "MM") & "/" & Format(CDate(txtYear.Value), "yyyy") & " no have", MsgBoxStyle.OkOnly)
                    Exit Sub
                Else
                    If MsgBox("Do you want to Monthly closing account " & Format(CDate(Me.txtMonth.Value), "MM") & "/" & Format(CDate(Me.txtYear.Value), "yyyy") & " Yes or no?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        'Call Backup()
                        Call Clse_Year()
                        MsgBox("Monthly closing account " & Format(CDate(Me.txtMonth.Value), "MM") & "/" & Format(CDate(Me.txtYear.Value), "yyyy") & " complete.", MsgBoxStyle.OkOnly)
                    End If
                End If
            End If
        End With
    End Sub
    Private Sub Backup()
        con = New SqlConnection("Data Source='" & MDServerName & "';Integrated Security=SSPI;Initial Catalog='" & MDDatabaName & "'")
        cmd = New SqlCommand("backup database " & MDDatabaName & " to disk='" & txtSaveIn.Text & "\" & txtFileNane.Text & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        Me.Close()
    End Sub
    Private Sub txtYear_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtYear.MouseUp
        Me.lblFromDate.Text = Format(CDate(txtMonth.Value), "MM")
        Me.lblToDate.Text = Format(CDate(txtYear.Value), "yyyy")
        Sdate = Format(CDate("01/" & Month(Me.txtMonth.Value) & "/" & Year(Me.txtYear.Value)), "dd/MM/yyyy")
        txtSdate.Text = Format(DateAdd("d", -1, DateAdd("m", 1, (Month(Me.txtMonth.Value) & "/" & Year(Me.txtYear.Value)))), "dd/MM/yyyy")

        'TextBox1.Text = Format(DateAdd("m", 1, CDate("01/" & Month(txtMonth.Value) & "/" & Year(txtYear.Value))), "dd/MM/yyyy")
        If Month(txtMonth.Value) = 12 Then
            TextBox1.Text = Format(CDate("01/" & "01" & "/" & Year(txtYear.Value)), "dd/MM/yyyy")
        Else
            TextBox1.Text = Format(CDate("01/" & Month(txtMonth.Value) + 1 & "/" & Year(txtYear.Value)), "dd/MM/yyyy")
        End If
    End Sub
    Private Sub txtYear_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear.ValueChanged
        Me.lblFromDate.Text = Format(CDate(txtMonth.Value), "MM")
        Me.lblToDate.Text = Format(CDate(txtYear.Value), "yyyy")
        Sdate = Format(CDate("01/" & Month(Me.txtMonth.Value) & "/" & Year(Me.txtYear.Value)), "dd/MM/yyyy")
        txtSdate.Text = Format(DateAdd("d", -1, DateAdd("m", 1, (Month(Me.txtMonth.Value) & "/" & Year(Me.txtYear.Value)))), "dd/MM/yyyy")

        ' TextBox1.Text = Format(DateAdd("m", 1, CDate("01/" & Month(txtMonth.Value) & "/" & Year(txtYear.Value))), "dd/MM/yyyy")
        If Month(txtMonth.Value) = 12 Then
            TextBox1.Text = Format(CDate("01/" & "01" & "/" & Year(txtYear.Value)), "dd/MM/yyyy")
        Else
            TextBox1.Text = Format(CDate("01/" & Month(txtMonth.Value) + 1 & "/" & Year(txtYear.Value)), "dd/MM/yyyy")
        End If
    End Sub
    Private Sub FrmMonthly_closing_account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFileNane.Text = "Ap_Stock-Backup-End-Of-Month" & Format(Date.Today, "dd-MM-yyyy") & ".bak"
        txtSaveIn.Text = "C:\Backup data"
        If MWorkSetting = "" Then
            txtMonth.Value = Date.Today
            txtYear.Value = Date.Today
        Else
            txtMonth.Value = (MWorkSetting)
            txtYear.Value = (MWorkSetting)
        End If
        Me.lblFromDate.Text = Format(CDate(txtMonth.Value), "MM")
        Me.lblToDate.Text = Format(CDate(txtYear.Value), "yyyy")
        Sdate = Format(CDate("01/" & Month(Me.txtMonth.Value) & "/" & Year(Me.txtYear.Value)), "dd/MM/yyyy")
        txtSdate.Text = Format(DateAdd("d", -1, DateAdd("m", 1, (Month(Me.txtMonth.Value) & "/" & Year(Me.txtYear.Value)))), "dd/MM/yyyy")
        'txtFileNane.Text = "APCashier-" & DateString


        '  TextBox1.Text = Format(DateAdd("m", 1, CDate("01/" & Month(txtMonth.Value) & "/" & Year(txtYear.Value))), "dd/MM/yyyy")
        If Month(txtMonth.Value) = 12 Then
            TextBox1.Text = Format(CDate("01/" & "01" & "/" & Year(txtYear.Value)), "dd/MM/yyyy")
        Else
            TextBox1.Text = Format(CDate("01/" & Month(txtMonth.Value) + 1 & "/" & Year(txtYear.Value)), "dd/MM/yyyy")
        End If
        If MDLanguage = 0 Then
            Call LangLao()
        Else
            Call Langs()
        End If

    End Sub
    Private Sub Langs()

        Label1.Text = "Monthly closing account"
        Label2.Text = "Month:"
        Label3.Text = "Year:"

    End Sub
    Private Sub LangLao()

        Label1.Text = "ປິດບັນຊີປະຈໍາເດືອນ"
        Label2.Text = "ເດືອນ:"
        Label3.Text = "ປີ :"

    End Sub
    Private Sub txtMonth_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMonth.MouseUp
        Me.lblFromDate.Text = Format(CDate(txtMonth.Value), "MM")
        Me.lblToDate.Text = Format(CDate(txtYear.Value), "yyyy")
        Sdate = Format(CDate("01/" & Month(Me.txtMonth.Value) & "/" & Year(Me.txtYear.Value)), "dd/MM/yyyy")
        txtSdate.Text = Format(DateAdd("d", -1, DateAdd("m", 1, (Month(Me.txtMonth.Value) & "/" & Year(Me.txtYear.Value)))), "dd/MM/yyyy")

        '  TextBox1.Text = Format(DateAdd("m", 1, CDate("01/" & Month(txtMonth.Value) & "/" & Year(txtYear.Value))), "dd/MM/yyyy")
        If Month(txtMonth.Value) = 12 Then
            TextBox1.Text = Format(CDate("01/" & "01" & "/" & Year(txtYear.Value)), "dd/MM/yyyy")
        Else
            TextBox1.Text = Format(CDate("01/" & Month(txtMonth.Value) + 1 & "/" & Year(txtYear.Value)), "dd/MM/yyyy")
        End If
    End Sub
    Private Sub txtMonth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonth.ValueChanged
        Me.lblFromDate.Text = Format(CDate(txtMonth.Value), "MM")
        Me.lblToDate.Text = Format(CDate(txtYear.Value), "yyyy")
        Sdate = Format(CDate("01/" & Month(Me.txtMonth.Value) & "/" & Year(Me.txtYear.Value)), "dd/MM/yyyy")
        txtSdate.Text = Format(DateAdd("d", -1, DateAdd("m", 1, (Month(Me.txtMonth.Value) & "/" & Year(Me.txtYear.Value)))), "dd/MM/yyyy")
        If Month(txtMonth.Value) = 12 Then
            TextBox1.Text = Format(CDate("01/" & "01" & "/" & Year(txtYear.Value)), "dd/MM/yyyy")
        Else
            TextBox1.Text = Format(CDate("01/" & Month(txtMonth.Value) + 1 & "/" & Year(txtYear.Value)), "dd/MM/yyyy")
        End If
    End Sub
    Private Sub Clse_Year()
        Dim RsPro As New ADODB.Recordset
        Conn.Execute("UPDATE A SET A.Qty=B.Rem_Qty FROM AP_Products_S A, RPT_Inventory B WHERE (A.Pro_ID=B.Pro_ID)")
        'Conn.Execute("DELETE FROM AP_Products_S WHERE Qty=0")
        Conn.Execute("INSERT INTO AP_Clse_Yr_Accnt(Open_Yr, Cat_ID, Pro_ID_Old, Pro_ID_New, Cost, Qty, Lst_Updt, Lst_usr,  PC_nm) " & _
        "SELECT " & Year(txtYear.Value) & ", Cat_ID, Pro_ID, Pro_ID, Cost, Qty, " & Sdate & ", '" & MUserName & "',  '" & MDServerName & "' FROM AP_Products_S ORDER BY Cat_ID, Pro_Cnt")
        Conn.Execute("UPDATE A SET A.Pro_ID=B.Pro_ID_New FROM AP_Products_S A, AP_Clse_Yr_Accnt B WHERE (A.Pro_ID=B.Pro_ID_OLD)")
        Conn.Execute("UPDATE A SET A.Pro_ID=B.Pro_ID_New FROM AP_open_bl_S A, AP_Clse_Yr_Accnt B WHERE (A.Pro_ID=B.Pro_ID_OLD)")
        'Conn.Execute("UPDATE AP_Stockin SET Close_accnt=1 WHERE Month(in_dt)=" & Month(txtMonth.Value) & " AND Year(in_dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_SectTurn SET Close_accnt=1 WHERE Month(Turn_dt)=" & Month(txtMonth.Value) & " AND Year(Turn_dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_CustTurn SET Close_accnt=1 WHERE Month(Turn_dt)=" & Month(txtMonth.Value) & " AND Year(Turn_dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_StockReceipt SET Close_accnt=1 WHERE Month(SR_dt)=" & Month(txtMonth.Value) & " AND Year(SR_dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_Bills SET close_accnt=1 WHERE Month(bill_dt)=" & Month(txtMonth.Value) & " AND Year(bill_dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_TurnToSupp SET close_accnt=1 WHERE Month(Ref_Dt)=" & Month(txtMonth.Value) & " AND Year(Ref_Dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_SaleForStock SET close_accnt=1 WHERE Month(Bill_Dt)=" & Month(txtMonth.Value) & " AND Year(Bill_Dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_Fix_bl SET close_accnt=1 WHERE Month(Fix_dt)=" & Month(txtMonth.Value) & " AND Year(Fix_dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_Bill_Custpaid SET close_accnt=1 WHERE Month(Lft_Dt)=" & Month(txtMonth.Value) & " AND Year(Lft_Dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_SaleForStockDE SET close_accnt=1 WHERE Month(Bill_Dt)=" & Month(txtMonth.Value) & " AND Year(Bill_Dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_SaleForStockPO SET close_accnt=1 WHERE Month(Bill_Dt)=" & Month(txtMonth.Value) & " AND Year(Bill_Dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_Bill_CustpaidDE SET close_accnt=1 WHERE Month(Lft_Dt)=" & Month(txtMonth.Value) & " AND Year(Lft_Dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_Bill_CustpaidPO SET close_accnt=1 WHERE Month(Lft_Dt)=" & Month(txtMonth.Value) & " AND Year(Lft_Dt)=" & Year(txtYear.Value))
        Call ClseMnth_Accnt()
    End Sub
    Private Sub ClseMnth_Accnt()
        Dim ClseDt As Date
        If Month(txtMonth.Value) = 12 Then
            ClseDt = CDate("01/" & "01" & "/" & Year(txtYear.Value) + 1)
        Else
            ClseDt = CDate("01/" & Month(txtMonth.Value) + 1 & "/" & Year(txtYear.Value))
        End If
        Conn.Execute("INSERT INTO AP_open_bl_S (Open_dt, Cat_ID, Pro_id, cost, open_qty, lst_updt, lst_usr, pc_nm) " & _
       "SELECT     '" & Format(ClseDt, "yyyy-MM-dd") & "', " & _
       "Cat_id, Pro_id, cost, Qty, getdate(), '" & Trim(MUserName) & "','" & Trim(MDServerName) & "' FROM AP_Products_S WHERE (Cut_qty = 1)")
        'Conn.Execute("UPDATE AP_Stockin SET Close_accnt=1 WHERE Month(in_dt)=" & Month(txtMonth.Value) & " AND Year(in_dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_SectTurn SET Close_accnt=1 WHERE Month(Turn_dt)=" & Month(txtMonth.Value) & " AND Year(Turn_dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_CustTurn SET Close_accnt=1 WHERE Month(Turn_dt)=" & Month(txtMonth.Value) & " AND Year(Turn_dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_StockReceipt SET Close_accnt=1 WHERE Month(SR_dt)=" & Month(txtMonth.Value) & " AND Year(SR_dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_Bills SET close_accnt=1 WHERE Month(bill_dt)=" & Month(txtMonth.Value) & " AND Year(bill_dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_TurnToSupp SET close_accnt=1 WHERE Month(Ref_Dt)=" & Month(txtMonth.Value) & " AND Year(Ref_Dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_SaleForStock SET close_accnt=1 WHERE Month(Bill_Dt)=" & Month(txtMonth.Value) & " AND Year(Bill_Dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_SaleForStockDE SET close_accnt=1 WHERE Month(Bill_Dt)=" & Month(txtMonth.Value) & " AND Year(Bill_Dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_SaleForStockPO SET close_accnt=1 WHERE Month(Bill_Dt)=" & Month(txtMonth.Value) & " AND Year(Bill_Dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_Fix_bl SET close_accnt=1 WHERE Month(Fix_dt)=" & Month(txtMonth.Value) & " AND Year(Fix_dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_Bill_Custpaid SET close_accnt=1 WHERE Month(Lft_Dt)=" & Month(txtMonth.Value) & " AND Year(Lft_Dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_Bill_CustpaidDE SET close_accnt=1 WHERE Month(Lft_Dt)=" & Month(txtMonth.Value) & " AND Year(Lft_Dt)=" & Year(txtYear.Value))
        'Conn.Execute("UPDATE AP_Bill_CustpaidPO SET close_accnt=1 WHERE Month(Lft_Dt)=" & Month(txtMonth.Value) & " AND Year(Lft_Dt)=" & Year(txtYear.Value))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Backup()
        MsgBox("OK", MsgBoxStyle.OkOnly)
    End Sub
End Class