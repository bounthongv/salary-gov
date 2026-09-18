Public Class Frm_Employee_Ticket

    Private Sub Frm_Employee_Ticket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FG.FormatString = "ລ/ດ |<ວັນທີ      |<ເນື້ອໃນ                  |<ຂໍໃຫ້  |<ຊື່ ແລະ ນາມສະກຸນ ຄົນໃນຄອບຄົວ|>ຈ/ນ ມື້ລາພັກ |>ຈ/ນ ມື້ປ່ວຍ |>ຈ/ນ ປີ້|^FOC           |^90%             |^75%             |^50%             "
        addnew()

        Load_Tax()
        loadCMB()


        If EditActive = True Then
            Editdata()
            Editdata_Item()

        Else
            EditActive = False
            'addnew()


        End If
    End Sub
    Private Sub Editdata_Item()
        Dim aa As String
        Dim RSC As New ADODB.Recordset
        FG.Rows = 1
        With RSC
            aa = "SELECT  * from AP_Employee_Tecket_item  where Bill_no = '" & txt_no.Text & "' and E_ID = '" & txtid.Text & "' order by bill_no  "
            Call LoadRs(aa, RSC)
            If .RecordCount > 0 Then
                While Not .EOF
                    FG.AddItem(.AbsolutePosition & _
                                 Chr(9) & .Fields("DT").Value & _
                            Chr(9) & .Fields("detail").Value & _
                             Chr(9) & .Fields("gave_to").Value & _
                              Chr(9) & .Fields("Nm_family").Value & _
                           Chr(9) & .Fields("Day_year").Value & _
                               Chr(9) & .Fields("sick").Value & _
                             Chr(9) & .Fields("QTY_Ticket").Value & _
                         Chr(9) & .Fields("FOC").Value & _
                               Chr(9) & .Fields("to_90").Value & _
                      Chr(9) & .Fields("to_75").Value & _
                            Chr(9) & .Fields("to_50").Value)
                    .MoveNext()
                End While
            Else
                FG.Rows = 2
                For i = 1 To FG.Rows - 1
                    FG.set_TextMatrix(i, 0, i)
                Next i
            End If
        End With
    End Sub
    Private Sub Editdata()
        Dim rsc As New ADODB.Recordset
        Call LoadRs("SELECT       AP_Employee_Tecket.Bill_no, AP_Employee_Tecket.DT_year, AP_Employee_Tecket.E_ID, AP_Employee_Tecket.E_nm, AP_Employee_Tecket.Tecket_year,  " & _
                "      AP_Employee_Tecket.Tecket_use, AP_Employee_Tecket.about, AP_Employee_Tecket.Remark, AP_Employee_Tecket.lst_usr, AP_Employee_Tecket.lst_updt,  " & _
                  "    AP_Employee_Tecket.Pc_nm, AP_Employee_Tecket.cnt, AP_CV.Name_L, AP_CV.Name_E, AP_CV.Phone, AP_Sections.Sec_nmL, AP_Sections.Sec_id,  " & _
      "  Department.DP_ID, Department.DP_Name " & _
           "     FROM         AP_Employee_Tecket INNER JOIN " & _
              "        AP_CV ON AP_Employee_Tecket.E_ID = AP_CV.E_ID INNER JOIN " & _
                  "    AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id INNER JOIN " & _
                   "   Department ON AP_CV.Department_id = Department.DP_ID  WHERE   AP_Employee_Tecket.Bill_no = N'" & SaleID & "'  and  AP_Employee_Tecket.E_ID = N'" & CustID & "'   ", rsc)
        With rsc
            If rsc.RecordCount > 0 Then
                txt_no.Text = (rsc.Fields("Bill_no").Value.ToString)
                txtid.Text = (rsc.Fields("E_ID").Value.ToString)
                TxtPersonNmL.Text = (rsc.Fields("Name_L").Value.ToString)
                TxtPersonNmE.Text = (rsc.Fields("Name_E").Value.ToString)
                Cmb_Sections.Text = (rsc.Fields("Sec_nmL").Value.ToString)
                cmb_Department.Text = (rsc.Fields("DP_Name").Value.ToString)
                TxtTel.Text = (rsc.Fields("Phone").Value.ToString)
                txtTecket_year.Text = Trim(rsc("Tecket_year").Value)
                txtTecket_use.Text = Trim(rsc("Tecket_use").Value)
                txtabount.Text = Trim(rsc("about").Value)
                txtremark.Text = Trim(rsc("Remark").Value)


            End If
        End With
    End Sub
    Private Sub addnew()

        txtabount.Text = ""
        txtremark.Text = ""
        txtTecket_year.Text = 0
        txtTecket_use.Text = 0




        AutoNumber()
    End Sub
    Private Sub loadCMB()
        'Cmb_Sections.Items.Clear()
        'Call load_Cmb("select Sec_nmL from AP_Sections", "Sec_nmL", Cmb_Sections)
        'Cmb_Sections.SelectedIndex = 0

        'cmb_Department.Items.Clear()
        'Call load_Cmb("select DP_Name from Department", "DP_Name", cmb_Department)
        'cmb_Department.SelectedIndex = 0


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmCustomer_item.ShowDialog()
        If MDCusID = "" Then Exit Sub
        Dim rs As New ADODB.Recordset
        Dim rsc As New ADODB.Recordset
        Call LoadRs("SELECT       AP_Employee_Tecket.Bill_no, AP_Employee_Tecket.DT_year, AP_Employee_Tecket.E_ID, AP_Employee_Tecket.E_nm, AP_Employee_Tecket.Tecket_year,  " & _
                "      AP_Employee_Tecket.Tecket_use, AP_Employee_Tecket.about, AP_Employee_Tecket.Remark, AP_Employee_Tecket.lst_usr, AP_Employee_Tecket.lst_updt,  " & _
                  "    AP_Employee_Tecket.Pc_nm, AP_Employee_Tecket.cnt, AP_CV.Name_L, AP_CV.Name_E, AP_CV.Phone, AP_Sections.Sec_nmL, AP_Sections.Sec_id,  " & _
      "  Department.DP_ID, Department.DP_Name " & _
           "     FROM         AP_Employee_Tecket INNER JOIN " & _
              "        AP_CV ON AP_Employee_Tecket.E_ID = AP_CV.E_ID INNER JOIN " & _
                  "    AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id INNER JOIN " & _
                   "   Department ON AP_CV.Department_id = Department.DP_ID  WHERE   AP_Employee_Tecket.E_ID = N'" & CustID & "'  and year(AP_Employee_Tecket.DT_year) ='" & Year(DT_year.Value) & "'  ", rsc)

        If rsc.RecordCount > 0 Then
            txt_no.Text = (rsc.Fields("Bill_no").Value.ToString)
            txtid.Text = (rsc.Fields("E_ID").Value.ToString)
            TxtPersonNmL.Text = (rsc.Fields("Name_L").Value.ToString)
            TxtPersonNmE.Text = (rsc.Fields("Name_E").Value.ToString)
            Cmb_Sections.Text = (rsc.Fields("Sec_nmL").Value.ToString)
            cmb_Department.Text = (rsc.Fields("DP_Name").Value.ToString)
            TxtTel.Text = (rsc.Fields("Phone").Value.ToString)
            txtTecket_year.Text = Trim(rsc("Tecket_year").Value)
            txtTecket_use.Text = Trim(rsc("Tecket_use").Value)
            txtabount.Text = Trim(rsc("about").Value)
            txtremark.Text = Trim(rsc("Remark").Value)
        Else
            Dim aa As String
            aa = "SELECT     AP_CV.E_ID, AP_CV.*, AP_Village.Vl_nm, AP_District.Dt_id, " & _
    "    AP_District.Dt_nm, AP_Province.PV_ID, AP_Province.PV_nm, AP_Village_1.Vl_nm AS Vl_nm1, AP_District_1.Dt_nm AS Dt_nm1, AP_Province_1.PV_nm AS PV_nm1,  " & _
    "    AP_Sections.Sec_nmL, Department.DP_Name, Type_In.In_nm  , job.job_nm  " & _
    "    FROM         AP_CV INNER JOIN " & _
    "   AP_Village ON AP_CV.BVill_ID = AP_Village.Vl_ID INNER JOIN " & _
        "       AP_District ON AP_Village.Dt_id = AP_District.Dt_id INNER JOIN " & _
             "  AP_Province ON AP_District.PV_id = AP_Province.PV_ID INNER JOIN " & _
            "   AP_Village AS AP_Village_1 ON AP_CV.Add_Vill_ID = AP_Village_1.Vl_ID INNER JOIN " & _
            "   AP_District AS AP_District_1 ON AP_Village_1.Dt_id = AP_District_1.Dt_id INNER JOIN " & _
            "   AP_Province AS AP_Province_1 ON AP_District_1.PV_id = AP_Province_1.PV_ID LEFT OUTER JOIN " & _
            "   job ON AP_CV.duties_Id = job.job_id LEFT OUTER JOIN " & _
            "   Type_In ON AP_CV.type_in_id = Type_In.In_ID LEFT OUTER JOIN " & _
           "    Department ON AP_CV.Department_id = Department.DP_ID LEFT OUTER JOIN " & _
            "   AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id  WHERE   E_ID = N'" & CustID & "'   "
            Call LoadRs(aa, rs)
            If rs.RecordCount > 0 Then
                txtid.Text = (rs.Fields("E_ID").Value.ToString)
                TxtPersonNmL.Text = (rs.Fields("Name_L").Value.ToString)
                TxtPersonNmE.Text = (rs.Fields("Name_E").Value.ToString)
                Cmb_Sections.Text = (rs.Fields("Sec_nmL").Value.ToString)
                cmb_Department.Text = (rs.Fields("DP_Name").Value.ToString)
                TxtTel.Text = (rs.Fields("Phone").Value.ToString)
                txtSection_ID.Text = Trim(rs("Sections_id").Value)
                txtdepart_ID.Text = Trim(rs("Department_id").Value)
                'txtabount.Text = (rs.Fields("txtabount").Value.ToString)
                'txtson_Money.Text = Format(CDbl(rs.Fields("txtson_Money").Value), "##,##0.00")
                'txtremark.Text = (rs.Fields("remark").Value.ToString)
                txtTecket_year.Text = 0
                txtTecket_use.Text = 0
                txtabount.Text = ""
                txtremark.Text = ""
                AutoNumber()
            Else
                DT_year.Value = Today
                txtTecket_year.Text = 0
                txtTecket_use.Text = 0
                txtabount.Text = ""
            End If


        End If



        LoadData_family()
    End Sub
    Private Sub LoadData_family()
        Dim aa As String
        Dim RSC As New ADODB.Recordset
        FG.Rows = 1
        With RSC
            aa = "SELECT  * from AP_Persion_Family  where E_ID = '" & txtid.Text & "' order by bill_no  "
            Call LoadRs(aa, RSC)
            If .RecordCount > 0 Then
                While Not .EOF
                    FG.AddItem(.AbsolutePosition & _
                          Chr(9) & "" & _
                      Chr(9) & .Fields("cmb_Relation").Value & _
                            Chr(9) & .Fields("txtname_relation").Value)
                    .MoveNext()
                End While
            Else
                FG.Rows = 2
                For i = 1 To FG.Rows - 1
                    FG.set_TextMatrix(i, 0, i)
                Next i
            End If
        End With
    End Sub

    Private Sub Bclos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclos.Click
        Me.Close()
    End Sub

    Private Sub Cmb_Sections_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Sections.SelectedIndexChanged
        'Dim RSC As New ADODB.Recordset
        'Call LoadRs("Select * From AP_Sections Where Sec_nmL=N'" & Trim(Cmb_Sections.Text) & "'   ", RSC)
        'If RSC.RecordCount > 0 Then
        '    txtSection_ID.Text = Trim(RSC("Sec_id").Value)
        'End If
    End Sub

    Private Sub cmb_Department_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Department.SelectedIndexChanged
        'Dim RSC As New ADODB.Recordset
        'Call LoadRs("Select * From Department Where DP_name=N'" & Trim(cmb_Department.Text) & "'   ", RSC)
        'If RSC.RecordCount > 0 Then
        '    txtdepart_ID.Text = Trim(RSC("DP_ID").Value)
        'End If
    End Sub

    Private Sub Badd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badd.Click
        addnew()
    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 Bill_no from AP_Employee_Tecket    Order by Bill_no DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("Bill_no").Value, 1, 6)) + 1, "000000")
        Else
            VIOTNEW = "000001"

        End If
        txt_no.Text = Trim(CStr(VIOTNEW.ToString))
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txt_no.Text = "" Then MsgBox("ໃສ່ລະຫັດພະນັກງານກ່ອນ") : Exit Sub

        If txtid.Text = "" Then MsgBox("ໃສ່ລະຫັດພະນັກງານກ່ອນ") : txtid.Focus() : Exit Sub


        Save()
        Conn.Execute("delete from  AP_Employee_Tecket_item WHERE Bill_no = '" & txt_no.Text & "'  and  E_ID = '" & txtid.Text & "' ")
        Save_item()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
    End Sub
    Private Sub Save_item()
        Dim ww As String
        Dim i As Integer
        Dim rss As New ADODB.Recordset
        With rss
            Call LoadRs("SELECT Bill_no FROM AP_Employee_Tecket_item WHERE Bill_no = '" & txt_no.Text & "' and  E_ID = '" & txtid.Text & "' ", rss)
            For i = 1 To FG.Rows - 1
                If .RecordCount = 0 Then
                    ww = " INSERT INTO  AP_Employee_Tecket_item (  Bill_no,E_ID, DT,detail, gave_to, Nm_family,Day_year,sick,QTY_Ticket,FOC,to_90,to_75,to_50)" & _
                        "VALUES( " & _
                            " '" & Trim(txt_no.Text.ToString) & "'," & _
                               " N'" & Trim(txtid.Text.ToString) & "'," & _
                                " N'" & FG.get_TextMatrix(i, 1) & "'," & _
                                  " N'" & FG.get_TextMatrix(i, 2) & "'," & _
                                      " N'" & FG.get_TextMatrix(i, 3) & "'," & _
                                      " N'" & FG.get_TextMatrix(i, 4) & "'," & _
                                       " N'" & FG.get_TextMatrix(i, 5) & "'," & _
                                        " N'" & FG.get_TextMatrix(i, 6) & "'," & _
                                         " N'" & FG.get_TextMatrix(i, 7) & "'," & _
                                          " N'" & FG.get_TextMatrix(i, 8) & "'," & _
                                           " N'" & FG.get_TextMatrix(i, 9) & "'," & _
                                            " N'" & FG.get_TextMatrix(i, 10) & "'," & _
                                    "N'" & FG.get_TextMatrix(i, 11) & "' )"
                    Conn.Execute(ww)
                End If
            Next i
        End With
    End Sub

    Private Sub Save()

        Dim rs As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT * FROM  AP_Employee_Tecket WHERE    E_ID = '" & txtid.Text & "' and year(DT_year) ='" & Year(DT_year.Value) & "'", rs)
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO AP_Employee_Tecket (Bill_no,DT_year,E_ID,E_nm,Tecket_year,Tecket_use,about,Remark,lst_updt,lst_usr,Pc_nm) " & _
                      " VALUES('" & (txt_no.Text) & "'," & _
                       " '" & Format(DT_year.Value, "yyyy-MM-dd") & "'," & _
                           " N'" & (txtid.Text) & "'," & _
                      " N'" & (TxtPersonNmL.Text) & "'," & _
                        " " & CDbl(txtTecket_year.Text) & "," & _
                          " " & CDbl(txtTecket_use.Text) & "," & _
                    " N'" & (txtabount.Text) & "'," & _
                  " N'" & (txtremark.Text) & "'," & _
                           " Getdate()," & _
               " N'" & MUserName & "', " & _
                 " N'" & MDServerName & "')"
                Conn.Execute(aa)

            Else
                Conn.Execute("delete from   AP_Employee_Tecket WHERE    E_ID= '" & (txtid.Text) & "' and year(DT_year) ='" & Year(DT_year.Value) & "' ")
                Dim aa As String
                aa = "INSERT INTO AP_Employee_Tecket (Bill_no,DT_year,E_ID,E_nm,Tecket_year,Tecket_use,about,Remark,lst_updt,lst_usr,Pc_nm) " & _
                  " VALUES('" & (txt_no.Text) & "'," & _
                   " '" & Format(DT_year.Value, "yyyy-MM-dd") & "'," & _
                       " N'" & (txtid.Text) & "'," & _
                  " N'" & (TxtPersonNmL.Text) & "'," & _
                    " " & CDbl(txtTecket_year.Text) & "," & _
                      " " & CDbl(txtTecket_use.Text) & "," & _
                " N'" & (txtabount.Text) & "'," & _
              " N'" & (txtremark.Text) & "'," & _
                       " Getdate()," & _
           " N'" & MUserName & "', " & _
             " N'" & MDServerName & "')"
                Conn.Execute(aa)
            End If
        End With


        'Conn.Execute("delete from   AP_CV WHERE    E_ID= '" & (txtid.Text) & "' ")
        'Conn.Execute(" UPDATE AP_CV SET Status_out=1 " & _
        ' " WHERE E_ID= '" & (txtid.Text) & "'")


    End Sub


    Private Sub txtson_Money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FG_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG.ClickEvent
        If FG.Col = 1 Or FG.Col = 2 Or FG.Col = 3 Or FG.Col = 4 Or FG.Col = 5 Or FG.Col = 6 Or FG.Col = 7 Or FG.Col = 8 Or FG.Col = 9 Or FG.Col = 10 Then

            FG.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
    End Sub

    Private Sub FG_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG.SelChange
        If FG.Col = 1 Or FG.Col = 2 Or FG.Col = 3 Or FG.Col = 4 Or FG.Col = 5 Or FG.Col = 6 Or FG.Col = 7 Or FG.Col = 8 Or FG.Col = 9 Or FG.Col = 10 Then

            FG.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
    End Sub
 
    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button62.Click
        FG.Rows = FG.Rows + 1
        For i = 1 To FG.Rows - 1
            FG.set_TextMatrix(i, 0, i)
        Next i
    End Sub

    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button61.Click
        If FG.get_TextMatrix(FG.Row, 1) = "" And FG.get_TextMatrix(FG.Row, 2) = "" Then
            FG.RemoveItem(FG.Row)
        Else
            AccCD = FG.get_TextMatrix(FG.Row, 1)
            If MessageBox.Show("Do you want to cancle '" & AccCD & "' yes or no ?", "Cancle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                FG.RemoveItem(FG.Row)
                If FG.Rows = 1 Then FG.Rows = 1
            End If
        End If
        For i = 1 To FG.Rows - 1
            FG.set_TextMatrix(i, 0, i)
        Next i
    End Sub
End Class