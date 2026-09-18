Option Explicit On
Option Strict On
Module MDConnection
    'Public Conn As New ADODB.Connection
    Public Conn As New ADODB.Connection
    Public Sub ConnectionData()
        Try
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.ConnectionString = "Provider = SQLOLEDB; Password = " & MDServerPassword & "; Persist Security Info = True; " & _
            "User ID = " & MDServerUser & "; Initial Catalog = " & MDDatabaName & "; Data Source =" & MDServerName & ""
            Conn.Open()
        Catch ex As Exception
            VSysError = True
        End Try
    End Sub
 
  
    Public Sub LoadRs(ByVal sql As String, ByVal rs As ADODB.Recordset)
        With rs
            If .State = ConnectionState.Open Then .Close()
            .ActiveConnection = Conn
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .CursorType = ADODB.CursorTypeEnum.adOpenForwardOnly
            .LockType = ADODB.LockTypeEnum.adLockOptimistic
            .Open(sql)
            .Requery()
        End With
    End Sub
End Module



