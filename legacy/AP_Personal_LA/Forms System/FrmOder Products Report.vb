Public Class FrmOder_Products_Report
    Dim RsPro As New ADODB.Recordset
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub FrmOder_Products_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MWorkSetting = "" Then
            Me.DTfrom.Value = Date.Today
            Me.DTTo.Value = Date.Today
        Else
            Me.DTfrom.Value = MWorkSetting
            Me.DTTo.Value = MWorkSetting
        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Do you want to update ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Conn.Execute(" UPDATE AP_SaleForStock_item_ST Set AP_SaleForStock_item_ST.price = AP_SaleForStock_Item.price FROM AP_SaleForStock_item_ST, AP_SaleForStock_Item " & _
                            " WHERE AP_SaleForStock_item_ST.Bill_No= AP_SaleForStock_Item.Bill_no AND AP_SaleForStock_item_ST.Cat_ID= AP_SaleForStock_Item.Cat_ID " & _
                            " AND AP_SaleForStock_item_ST.Bill_Dt between '" & Format(Me.DTfrom.Value, "yyyy-MM-dd") & "' and '" & Format(Me.DTTo.Value, "yyyy-MM-dd") & "' ")
            MsgBox("Updating Completed", MsgBoxStyle.OkOnly) : Exit Sub
        End If
    End Sub
End Class