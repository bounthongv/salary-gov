Module MultiLangauge
    Public Lang As Boolean = True
    Public Lng As Long = 9999
    Public LngL(Lng) As String
    Public LngE(Lng) As String
    '=======================
    Dim cnn As New OleDb.OleDbConnection
    Dim da As New OleDb.OleDbDataAdapter
    Dim dr As OleDb.OleDbDataReader
    Dim Cm As OleDb.OleDbCommand
    Dim sql As String
    Dim ds As New DataSet

    Public Sub Connet_Language()
        With cnn
            .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & Application.StartupPath & "\Connection.mdb;Persist Security Info=True;Jet OLEDB:Database Password=linda"
            'Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =Connection.mdb;Persist Security Info=True;Jet OLEDB:Database Password=2459428"
            If .State = ConnectionState.Open Then .Close()
            .Open()
        End With
    End Sub

    Public Sub LoadLng()


        Dim i As Integer = 0
        Call Connet_Language()
        da = New OleDb.OleDbDataAdapter("Select * from tblLng ORDER BY LngID ASC", cnn)
        da.Fill(ds, "tblLng")
        Lng = ds.Tables("tblLng").Rows.Count
        For i = 0 To ds.Tables("tblLng").Rows.Count - 1
            LngE(CLng(ds.Tables("tblLng").Rows(i).Item("LngID"))) = ds.Tables("tblLng").Rows(i).Item("LngE")
            LngL(CLng(ds.Tables("tblLng").Rows(i).Item("LngID"))) = ds.Tables("tblLng").Rows(i).Item("LngL")
        Next
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        sql = "SELECT Lg_Default FROM Defaul_Lg"
        Cm = New OleDb.OleDbCommand(sql, cnn)
        dr = Cm.ExecuteReader
        With dr
            While .Read
                If .Item("Lg_Default") = "LA" Then
                    Lang = False
                ElseIf .Item("Lg_Default") = "En" Then
                    Lang = True
                End If
            End While
        End With
        cnn.Close()
      
    End Sub


    Public Sub SetControlText(ByVal frm As Form)
        On Error GoTo ProcedureError
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim Ctl As Control
        Dim msg As MessageBox
        For Each Ctl In frm.Controls
            Select Case TypeName(Ctl)
                Case "MenuStrip", "MenuStrip.items"
                    Dim mn As Windows.Forms.MenuStrip
                    mn = Ctl
                    With mn
                        For i = 0 To .Items.Count - 1
                            If Lang = True Then
                                .Items(i).Text = LngE(CInt(.Items(i).Tag))
                            Else
                                .Items(i).Text = LngL(CInt(.Items(i).Tag))
                            End If
                        Next
                    End With

                    'Case "ListView"
                    '    Dim lv As Windows.Forms.ListView
                    '    lv = Ctl
                    '    With lv
                    '        For i = 0 To .Columns.Count - 1
                    '            If Lang = True Then
                    '                .Columns.Item(i).Text = LngL(CInt(.Columns.Item(i).Tag))
                    '            Else
                    '                .Columns.Item(i).Text = LngE(CInt(.Columns.Item(i).Tag))
                    '            End If
                    '        Next
                    '    End With

                    'Case "AxVSFlexGrid"
                    '    Dim MG As AxVSFlex8U.AxVSFlexGrid
                    '    'Dim MG As AxVSFlex8.AxVSFlexGrid
                    '    MG = Ctl
                    '    For i = 0 To MG.Cols - 1
                    '        If Lang = True Then
                    '            'MG.FormatString = LngL(CInt(Ctl.Tag))
                    '            MG.set_TextMatrix(0, i, LngE(CInt(MG.Tag) + i))
                    '        Else
                    '            'MG.FormatString = LngE(CInt(Ctl.Tag))
                    '            MG.set_TextMatrix(0, i, LngL(CInt(MG.Tag) + i))
                    '        End If
                    '    Next
                Case "DataGridView"
                    Dim Dg As Windows.Forms.DataGridView
                    Dg = Ctl
                    With Dg
                        For i = 0 To .Columns.Count - 1
                            If Lang = True Then
                                .Columns.Item(i).HeaderText = LngE(CInt(.Columns.Item(i).Tag))
                            Else
                                .Columns.Item(i).HeaderText = LngL(CInt(.Columns.Item(i).Tag))
                            End If
                        Next
                    End With
                Case "CheckBox"
                    If Ctl.GetType Is GetType(CheckBox) Then
                        If Lang = True Then
                            CType(Ctl, CheckBox).Text = LngE(CInt(Ctl.Tag))
                        Else
                            CType(Ctl, CheckBox).Text = LngL(CInt(Ctl.Tag))
                        End If
                    End If
                Case "Button"
                    If Ctl.GetType Is GetType(Button) Then
                        If Lang = True Then
                            CType(Ctl, Button).Text = LngE(CInt(Ctl.Tag))
                        Else
                            CType(Ctl, Button).Text = LngL(CInt(Ctl.Tag))
                        End If
                    End If

                Case "Label", "LinkLabel"
                    If Ctl.GetType Is GetType(Label) Then
                        If Lang = True Then
                            CType(Ctl, Label).Text = LngE(CInt(Ctl.Tag))
                        Else
                            CType(Ctl, Label).Text = LngL(CInt(Ctl.Tag))
                        End If
                    End If
                    If Ctl.GetType Is GetType(LinkLabel) Then
                        If Lang = True Then
                            CType(Ctl, LinkLabel).Text = LngE(CInt(Ctl.Tag))
                        Else
                            CType(Ctl, LinkLabel).Text = LngL(CInt(Ctl.Tag))
                        End If
                    End If
                Case "GroupBox"
                    If Ctl.GetType Is GetType(GroupBox) Then
                        If Lang = True Then
                            CType(Ctl, GroupBox).Text = LngL(CInt(Ctl.Tag))
                            For i = 0 To Ctl.Controls.Count - 1


                                If Ctl.Controls(i).GetType Is GetType(RadioButton) Then CType(Ctl.Controls(i), RadioButton).Text = LngE(CInt(Ctl.Tag))
                                If Ctl.Controls(i).GetType Is GetType(CheckBox) Then CType(Ctl.Controls(i), CheckBox).Text = LngE(CInt(Ctl.Tag))
                                If Ctl.Controls(i).GetType Is GetType(Label) Then CType(Ctl.Controls(i), Label).Text = LngE(CInt(Ctl.Tag))
                                If Ctl.Controls(i).GetType Is GetType(Button) Then CType(Ctl.Controls(i), Button).Text = LngE(CInt(Ctl.Tag))

                                'If Ctl.Controls(i).GetType Is GetType(RadioButton) Then CType(Ctl.Controls(i), RadioButton).Text = LngE(CInt(Ctl.Tag))
                                'If Ctl.Controls(i).GetType Is GetType(CheckBox) Then CType(Ctl.Controls(i), CheckBox).Text = LngE(CInt(Ctl.Tag))
                                'If Ctl.Controls(i).GetType Is GetType(Label) Then CType(Ctl.Controls(i), Label).Text = LngE(CInt(Ctl.Tag))
                                'If Ctl.Controls(i).GetType Is GetType(Button) Then CType(Ctl.Controls(i), Button).Text = LngE(CInt(Ctl.Tag))
                            Next
                        Else
                            CType(Ctl, GroupBox).Text = LngE(CInt(Ctl.Tag))
                            For i = 0 To Ctl.Controls.Count - 1
                                If Ctl.Controls(i).GetType Is GetType(RadioButton) Then CType(Ctl.Controls(i), RadioButton).Text = LngL(CInt(Ctl.Tag))
                                If Ctl.Controls(i).GetType Is GetType(CheckBox) Then CType(Ctl.Controls(i), CheckBox).Text = LngL(CInt(Ctl.Tag))
                                If Ctl.Controls(i).GetType Is GetType(Label) Then CType(Ctl.Controls(i), Label).Text = LngL(CInt(Ctl.Tag))
                                If Ctl.Controls(i).GetType Is GetType(Button) Then CType(Ctl.Controls(i), Button).Text = LngL(CInt(Ctl.Tag))

                                'If Ctl.Controls(i).GetType Is GetType(RadioButton) Then CType(Ctl.Controls(i), RadioButton).Text = LngL(CInt(Ctl.Tag))
                                'If Ctl.Controls(i).GetType Is GetType(CheckBox) Then CType(Ctl.Controls(i), CheckBox).Text = LngL(CInt(Ctl.Tag))
                                'If Ctl.Controls(i).GetType Is GetType(Label) Then CType(Ctl.Controls(i), Label).Text = LngL(CInt(Ctl.Tag))
                                'If Ctl.Controls(i).GetType Is GetType(Button) Then CType(Ctl.Controls(i), Button).Text = LngL(CInt(Ctl.Tag))
                            Next
                        End If
                    End If
                Case "Panel"
                    Dim D As Windows.Forms.Panel
                    D = Ctl
                    'With Dg
                    If D.GetType Is GetType(Panel) Then
                        If Lang = True Then
                            CType(D, Panel).Text = LngE(CInt(D.Tag))


                            For i = 0 To D.Controls.Count - 1
                                'CType(Ctl, Label).Text = LngE(CInt(Ctl.Tag))
                                If Ctl.Controls(i).GetType Is GetType(RadioButton) Then CType(Ctl.Controls(i), RadioButton).Text = LngE(CInt(Ctl.Tag))
                                If Ctl.Controls(i).GetType Is GetType(CheckBox) Then CType(Ctl.Controls(i), CheckBox).Text = LngE(CInt(Ctl.Tag))
                                If D.Controls(i).GetType Is GetType(Label) Then CType(D.Controls(i), Label).Text = LngE(CInt(D.Tag))
                                If Ctl.Controls(i).GetType Is GetType(Button) Then CType(Ctl.Controls(i), Button).Text = LngE(CInt(Ctl.Tag))

                                'If Ctl.Controls(i).GetType Is GetType(RadioButton) Then CType(Ctl.Controls(i), RadioButton).Text = LngE(CInt(Ctl.Tag))
                                'If Ctl.Controls(i).GetType Is GetType(CheckBox) Then CType(Ctl.Controls(i), CheckBox).Text = LngE(CInt(Ctl.Tag))
                                'If Ctl.Controls(i).GetType Is GetType(Label) Then CType(Ctl.Controls(i), Label).Text = LngE(CInt(Ctl.Tag))
                                'If Ctl.Controls(i).GetType Is GetType(Button) Then CType(Ctl.Controls(i), Button).Text = LngE(CInt(Ctl.Tag))
                            Next
                        Else

                            'CType(D, Panel).Text = LngL(CInt(D.Tag))
                            For i = 0 To Ctl.Controls.Count - 1
                                'CType(Dg, Label).Text = LngL(CInt(Ctl.Tag))
                                If Ctl.Controls(i).GetType Is GetType(RadioButton) Then CType(Ctl.Controls(i), RadioButton).Text = LngL(CInt(Ctl.Tag))
                                If Ctl.Controls(i).GetType Is GetType(CheckBox) Then CType(Ctl.Controls(i), CheckBox).Text = LngL(CInt(Ctl.Tag))
                                If Ctl.Controls(i).GetType Is GetType(Label) Then CType(Ctl.Controls(i), Label).Text = LngL(CInt(Ctl.Tag))
                                If Ctl.Controls(i).GetType Is GetType(Button) Then CType(Ctl.Controls(i), Button).Text = LngL(CInt(Ctl.Tag))

                                'If Ctl.Controls(i).GetType Is GetType(RadioButton) Then CType(Ctl.Controls(i), RadioButton).Text = LngL(CInt(Ctl.Tag))
                                'If Ctl.Controls(i).GetType Is GetType(CheckBox) Then CType(Ctl.Controls(i), CheckBox).Text = LngL(CInt(Ctl.Tag))
                                'If Ctl.Controls(i).GetType Is GetType(Label) Then CType(Ctl.Controls(i), Label).Text = LngL(CInt(Ctl.Tag))

                                'If Ctl.Controls(i).GetType Is GetType(Button) Then CType(Ctl.Controls(i), Button).Text = LngL(CInt(Ctl.Tag))

                                CType(Ctl, Label).Text = LngL(CInt(Ctl.Tag))

                            Next

                        End If

                    End If
                Case "RadioButton"
                    If Ctl.GetType Is GetType(RadioButton) Then
                        If Lang = True Then
                            CType(Ctl, RadioButton).Text = LngE(CInt(Ctl.Tag))
                        Else
                            CType(Ctl, RadioButton).Text = LngL(CInt(Ctl.Tag))
                        End If
                    End If
            End Select
        Next
ProcedureExit:
        Exit Sub
ProcedureError:
        ' If ErrMsgBox("mDeclare.SetControlCaptionStrings") = vbRetry Then Resume Next
    End Sub

    Public Function ErrMsgBox(ByVal Msg As String) As Integer
        ErrMsgBox = MsgBox("Error: " & Err.Number & ". " & Err.Description, vbRetryCancel + vbCritical, Msg)
    End Function

    Public Sub ChgChildForm()
        For Each ChildForm As Form In FrmAPInvioce.MdiChildren
            SetControlText(ChildForm)
        Next
    End Sub

    Public Sub Loadlang()
        'Sub Menu........................................
        With FrmAPInvioce
            '===============ລະບົບ
         
            '.ToolStripMenuItem5.Text = ChgeLang(.ToolStripMenuItem5.Tag)
            '.ToolStripMenuItem11.Text = ChgeLang(.ToolStripMenuItem11.Tag)
            '.ToolStripMenuItem12.Text = ChgeLang(.ToolStripMenuItem12.Tag)
            ' ''===============LONG
            '.ToolStripMenuItem13.Text = ChgeLang(.ToolStripMenuItem13.Tag)
            '.ToolStripMenuItem14.Text = ChgeLang(.ToolStripMenuItem14.Tag)
            '.ToolStripMenuItem10.Text = ChgeLang(.ToolStripMenuItem10.Tag)
            '===============ຂໍ້ມູນເພີ້ມເຕີມ
            '.ToolStripMenuItem6.Text = ChgeLang(.ToolStripMenuItem6.Tag)
         

            .LaoToolStripMenuItem.Text = ChgeLang(.LaoToolStripMenuItem.Tag)

            '.MnUser.Tag = 1102

            '.MnPassword.Tag = 1103

            '.MnCollector.Text = ChgeLang(.MnCollector.Tag)
            '.MnBackUp.Text = ChgeLang(.MnBackUp.Tag)


            .ToolStripMenuItem71.Text = ChgeLang(.ToolStripMenuItem71.Tag)

            '.ToolStripMenuItem2.Text = ChgeLang(.ToolStripMenuItem2.Tag)
            '.ToolStripMenuItem1.Text = ChgeLang(.ToolStripMenuItem1.Tag)
 
            '============= Location ========== ==================
            '.Button2.Text = ChgeLang(.Button2.Tag)
          



            '============= Back========== ==================
        
            '=============HouseKeeping======== ==================
   
            '============ Consumer Information Maintenance======= ==================

        
            '=============&Billing====== ==================
  
            '.Panel1.Text = ChgeLang(.Panel1.Tag)
        End With
        '-------------------------------------------
    End Sub

    Public Function ChgeLang(ByVal LangValue As Long) As String
        ChgeLang = IIf(Lang = False, LngL(LangValue), LngE(LangValue))
    End Function
End Module
