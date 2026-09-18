Option Explicit On
Option Strict On
Module MDconnectAccess
    Public CNN As New ADODB.Connection
    Public Sub Connect()
        'Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =Connection.mdb;Persist Security Info=False"
        Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =Connection.mdb;Persist Security Info=True;Jet OLEDB:Database Password=2459428"
        Try
            If CNN.State = ConnectionState.Open Then CNN.Close()
            CNN.Open(strConn)
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດເຊື່ອມຕໍ່ກັບຖານຂໍ້ມູນໄດ້ຍ້ອນ: " & vbNewLine _
            & ex.ToString, "ການເຊື່ອມຕໍ່ກັບຖານຂໍ້ມູນຜິດພາດ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseServer_ON = False
        End Try
    End Sub
    Public Sub LoadData(ByVal sql As String, ByVal rs As ADODB.Recordset)
        With rs
            If .State = ConnectionState.Open Then .Close()
            .ActiveConnection = CNN
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .CursorType = ADODB.CursorTypeEnum.adOpenForwardOnly
            .LockType = ADODB.LockTypeEnum.adLockOptimistic
            .Open(sql)
            .Requery()
        End With
    End Sub
    Public Sub Load_Ptah()
        If IO.File.Exists(Application.StartupPath & "\ConnectServer.txt") Then
            Dim oRead As System.IO.StreamReader
            oRead = IO.File.OpenText(Application.StartupPath & "\ConnectServer.txt")
            Path_connect = oRead.ReadToEnd()
        End If
    End Sub
    Public Sub Load_LanSET()
        If IO.File.Exists(Application.StartupPath & "\lang.txt") Then
            Dim oRead As System.IO.StreamReader
            oRead = IO.File.OpenText(Application.StartupPath & "\lang.txt")
            lang_set = oRead.ReadToEnd()
            If lang_set <> "LA" And lang_set <> "EN" Then
                lang_set = "LA"
            End If
        End If
    End Sub

End Module
