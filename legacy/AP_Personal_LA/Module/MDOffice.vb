Module MDOffice
    Public MDOffName, MDOffTel, MDOffFax, Acc1, Acc2, Acc3, Bnk1, Bnk2, Bnk3, Street, Village, Dristic, Provice, Shr_Dristic, Shr_HSV, Shr_ALL As String
    Public MDSql As String
    'Public Logo As PictureBox
    Public Sub Office()
        Dim Rs As New ADODB.Recordset
        With Rs
            Call loadrs("SELECT * " & _
                         "FROM AP_Office" & _
                         " WHERE off_id <>''" & MDSql & " ORDER BY off_id ", Rs)
            If .RecordCount = 0 Then Exit Sub
            MDOffName = Trim(.Fields("off_nm").Value)
            MDOffTel = Trim(.Fields("Tel").Value)
            MDOffFax = Trim(.Fields("Fax").Value)
            Acc1 = Trim(.Fields("Acc1").Value)
            Acc2 = Trim(.Fields("Acc2").Value)
            Acc3 = Trim(.Fields("Acc3").Value)
            Bnk1 = Trim(.Fields("Bnk1").Value)
            Bnk2 = Trim(.Fields("Bnk2").Value)
            Bnk3 = Trim(.Fields("Bnk3").Value)
            Street = Trim(.Fields("off_StrtL").Value)
            Village = Trim(.Fields("off_VillageL").Value)
            Dristic = Trim(.Fields("Off_DistL").Value)
            Provice = Trim(.Fields("Off_ProvL").Value)
            'Logo = (.Fields("Logo").Value)
            .MoveNext()
        End With
    End Sub
End Module
