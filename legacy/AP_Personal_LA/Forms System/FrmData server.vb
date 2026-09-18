Public Class FrmData_server
    Dim rsProj As New ADODB.Recordset
    Public editProj As Boolean
    Dim Sql As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MDForMain <> "Kantana" Then
            FrmLogin.Close()
        End If
        If MDForMain = "Kantana" Then
            Me.Close()
        End If

    End Sub
    Private Sub FrmData_server_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmLogin.Hide()
        Dim Conn As New ADODB.Connection
        Call Connect()
        Call LoadDatabaseServer()
    End Sub
    Private Sub LoadDatabaseServer()
        Call LoadData("SELECT * FROM Conn WHERE ServerID<>'" & Sql & "' order by ServerID ", rsProj)
        With rsProj
            If .RecordCount <> 0 Then
                txtServerID.Text = (.Fields("ServerID").Value.ToString)
                txtServer.Text = (.Fields("ServerNm").Value.ToString)
                txtData.Text = (.Fields("DataNm").Value.ToString)
                txtUserNm.Text = (.Fields("UserNm").Value.ToString)
                txtPass.Text = (.Fields("UserPass").Value.ToString)
            End If
        End With
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim rs As New ADODB.Recordset
            Call LoadData("select * from Conn where ServerID='" & txtServerID.Text & "'", rs)
            CNN.Execute("Update Conn Set ServerNm ='" & txtServer.Text.ToString & "', DataNm='" & txtData.Text.ToString & "', UserNm='" & txtUserNm.Text.ToString & "', UserPass='" & txtPass.Text.ToString & "' " & _
                         " WHERE ServerID='" & txtServerID.Text.ToString & "' ")
            'Me.Hide()
            'FrmLogin.Visible = True
            'Test Connection Database server
            With Conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = "Provider = SQLOLEDB.1; Password = " & txtPass.Text & "; Persist Security Info = True; " & _
                "User ID = " & txtUserNm.Text & "; Initial Catalog = " & txtData.Text & "; Data Source =" & txtServer.Text & ""
                .Open()
            End With
            MsgBox("Conect To Server Completed!", MsgBoxStyle.OkOnly)
            If MDForMain <> "Kantana" Then
                FrmLogin.Visible = True
                Me.Close()
            End If
            If MDForMain = "Kantana" Then
                Call LoadDatabaseServer()
                'FrmAPCashier.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("ຂໍ້ມູນໃນການຕິດຕໍ່ ຖານຂໍ້ມູນ ບໍ່ຖືກຕ້ອງ !!" & vbCrLf & ex.Message)
        End Try

    End Sub
End Class