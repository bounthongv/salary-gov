Public Class Frm_Salary

    Private Sub Frm_Salary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    


        'Load_Tax()
        loadCMB()


        If EditActive = True Then
            Editdata()


        Else
            EditActive = False
            addnew()


        End If
    End Sub
    Private Sub Editdata()
        Dim aa As String
        Dim rs As New ADODB.Recordset
        aa = "SELECT      AP_Salary.*, AP_CV.Name_E,AP_CV.Bank_no,AP_CV.SSO_no, " & _
         "   AP_CV.Phone,AP_CV.txtV_C, AP_Sections.Sec_nmL, AP_Sections.Sec_id,   " & _
         "   Department.DP_ID, Department.DP_Name ,Salary_group.Group_SLR_nm " & _
              "   FROM         AP_Salary INNER JOIN  " & _
                 "     AP_CV ON AP_Salary.E_ID = AP_CV.E_ID INNER JOIN " & _
                 "     AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id INNER JOIN " & _
                "      Department ON AP_CV.Department_id = Department.DP_ID INNER JOIN " & _
                    "  Salary_group ON AP_Salary.txtgroup_id = Salary_group.Group_SLR_id   where AP_Salary.E_ID=N'" & E_ID & "'"
        Call LoadRs(aa, rs)
        With rs
            If .RecordCount > 0 Then
                txtid.Text = Trim(.Fields("E_ID").Value.ToString)
                Cmb_Sections.Text = Trim(.Fields("Sec_nmL").Value.ToString)
                cmb_Department.Text = Trim(.Fields("DP_Name").Value.ToString)
                cmb_group.Text = Trim(.Fields("Group_SLR_nm").Value.ToString)

                TxtPersonNmL.Text = Trim(.Fields("Name_L").Value.ToString)
                TxtPersonNmE.Text = Trim(.Fields("Name_E").Value.ToString)
                TxtTel.Text = Trim(.Fields("Phone").Value.ToString)
                TxtAccountNo.Text = Trim(.Fields("Bank_no").Value.ToString)
                txtAPSocial.Text = Trim(.Fields("SSO_no").Value.ToString)

                cmb_percen.Text = Trim(.Fields("percen").Value.ToString)

                cmbclass.Text = Trim(.Fields("txtclass").Value.ToString)
                cmblevel.Text = Trim(.Fields("txtlevel").Value.ToString)
                txtV_C.Text = Trim(.Fields("txtV_C").Value.ToString)
                cmbKip.Text = Trim(.Fields("cmbKip").Value.ToString)
                txtsalary.Text = Format(CDbl(.Fields("txtsalary").Value), "##,##0")
                txtTum_money.Text = Format(CDbl(.Fields("txtTum_money").Value), "##,##0.00")

                txt_hours_money.Text = Format(CDbl(.Fields("txt_hours_money").Value), "##,##0.00")

                txtoil.Text = Trim(.Fields("txtoil").Value.ToString)

                txtphone_money.Text = Format(CDbl(.Fields("txtphone_money").Value), "##,##0.00")

                txtremark.Text = Trim(.Fields("remark").Value.ToString)

            End If
        End With
    End Sub
    Private Sub addnew()
        cmbclass.Text = 1
        cmblevel.Text = 1
        cmb_group.SelectedIndex = 0
        cmbKip.SelectedIndex = 0
        txtsalary.Text = 0
        txt_hours_money.Text = 0
        txtoil.Text = 0
        txtphone_money.Text = 0
   
        cmb_percen.SelectedIndex = 0
        txt_3.Text = 3
        AutoNumber()
    End Sub
    Private Sub loadCMB()
        'Cmb_Sections.Items.Clear()
        'Call load_Cmb("select Sec_nmL from AP_Sections", "Sec_nmL", Cmb_Sections)
        'Cmb_Sections.SelectedIndex = 0

        'cmb_Department.Items.Clear()
        'Call load_Cmb("select DP_Name from Department", "DP_Name", cmb_Department)
        'cmb_Department.SelectedIndex = 0


        cmbclass.Items.Clear()
        Call load_Cmb("select cl_ID from Class", "cl_ID", cmbclass)
        cmbclass.SelectedIndex = 0

        cmblevel.Items.Clear()
        Call load_Cmb("select LV_ID from Level", "LV_ID", cmblevel)
        cmblevel.SelectedIndex = 0


        cmbKip.Items.Clear()
        Call load_Cmb("  SELECT Cuntry    FROM AP_Rate_Item   group by Cuntry   ", "Cuntry", cmbKip)
        cmbKip.SelectedIndex = 0



        cmb_group.Items.Clear()
        Call load_Cmb("select Group_SLR_nm from Salary_group", "Group_SLR_nm", cmb_group)
        cmb_group.SelectedIndex = 0

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmCustomer_item.ShowDialog()
        If MDCusID = "" Then Exit Sub
        addnew()
        LoadData_CV()
        AutoNumber()
    End Sub
    Private Sub LoadData_CV()
        Dim rs As New ADODB.Recordset
        Dim aa As String
        With rs
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
             "   AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id  WHERE 1=1  AND AP_CV.E_ID=N'" & CustID & "' "
            Call LoadRs(aa, rs)
            If .RecordCount <> 0 Then
                txtid.Text = (rs.Fields("E_ID").Value.ToString)
                TxtPersonNmL.Text = (rs.Fields("Name_L").Value.ToString)
                TxtPersonNmE.Text = (rs.Fields("Name_E").Value.ToString)
                Cmb_Sections.Text = (rs.Fields("Sec_nmL").Value.ToString)
                cmb_Department.Text = (rs.Fields("DP_Name").Value.ToString)
                txtSection_ID.Text = Trim(rs("Sections_id").Value)
                txtdepart_ID.Text = Trim(rs("Department_id").Value)
                cmb_type_in.Text = (.Fields("In_nm").Value.ToString)
                TxtTel.Text = (.Fields("Phone").Value.ToString)
                TxtAccountNo.Text = (.Fields("Bank_no").Value.ToString)
                txtAPSocial.Text = (.Fields("SSO_no").Value.ToString)
                cmbclass.Text = (.Fields("cmbclass").Value.ToString)
                cmblevel.Text = (.Fields("cmblevel").Value.ToString)


                'txtLevel_Clss_Money_Now.Text = Format(CDbl(.Fields("Level_Clss_Money").Value), "##,##0.00")
                'txtson.Text = (.Fields("txtson").Value.ToString)
                'txtson_Money.Text = Format(CDbl(.Fields("txtson_Money").Value), "##,##0.00")
                'txtmom.Text = (.Fields("txtmom").Value.ToString)
                'txtMom_mony.Text = Format(CDbl(.Fields("txtMom_mony").Value), "##,##0.00")
                txtV_C.Text = (.Fields("txtV_C").Value.ToString)
            End If
        End With

        Dim rsc As New ADODB.Recordset
        Call LoadRs("SELECT * FROM Level_class where name='" & txtV_C.Text & "'  ", rsc)
        With rsc
            If .RecordCount <> 0 Then
                cmbclass.Text = (.Fields("Leve").Value.ToString)
                cmblevel.Text = (.Fields("Class").Value.ToString)

            Else
                cmbclass.Text = 0
                cmblevel.Text = 0
                txtV_C.Text = 0
            End If
        End With
    End Sub

    Private Sub Bclos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclos.Click
        Me.Close()
    End Sub

    Private Sub Cmb_Sections_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Sections.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Sections Where Sec_nmL=N'" & Trim(Cmb_Sections.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtSection_ID.Text = Trim(RSC("Sec_id").Value)
        End If
    End Sub

    Private Sub cmb_Department_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Department.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Department Where DP_name=N'" & Trim(cmb_Department.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtdepart_ID.Text = Trim(RSC("DP_ID").Value)
        End If
    End Sub

    Private Sub cmbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclass.SelectedIndexChanged
        'Load_Tax()

        'txtV_C.Text = cmbclass.Text & "/" & cmblevel.Text

        'If cmblevel.Text <> "" Then
        '    loadmonet_class()
        '    Load_sum_tax()
        'End If
    End Sub

    Private Sub cmblevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblevel.SelectedIndexChanged
        'Load_Tax()

        'txtV_C.Text = cmbclass.Text & "/" & cmblevel.Text

        'loadmonet_class()
        'Load_sum_tax()
    End Sub
    Private Sub loadmonet_class()
        Dim rs As New ADODB.Recordset
        Call LoadRs("select * from Level_class where name='" & Trim(Apostrophe(txtV_C.Text)) & "'", rs)
        With rs
            If .RecordCount > 0 Then

                txtsalary.Text = Format(CDbl(.Fields("Toltle").Value), "##,##0.00")

            Else
                txtsalary.Text = 0

            End If
        End With
        If cmb_percen.Text <> "" Then
            txtsalary.Text = Format(CDbl(txtsalary.Text) * CDbl(cmb_percen.Text) / 100, "##,##0.00")
        End If


        'txttotal.Text = Format(CDbl(txtLevel_Clss_Money_Now.Text) + CDbl(txtTumnang_Money.Text) + CDbl(txtyear_money.Text), "##,##0.00")
        'txtTotal_remaining.Text = Format(CDbl(txttotal.Text) - CDbl(txtAGL.Text), "##,##0.00")


    End Sub
    Private Sub Load_sum_tax()
        'txttotal_amount.Text = Format(CDbl(txtworday_month.Text) * CDbl(txtmoney_per_day.Text), "##,##0.00")
        'txtTotal_remaining.Text = Format(CDbl(txtworday_month.Text) * CDbl(txtmoney_per_day.Text), "##,##0.00")
        'txttotal_Befor.Text = Format(CDbl(txttotal_Befor.Text) + CDbl(txtcost_living_total.Text), "##,##0")

        If Format(CDbl(txtTotal_remaining.Text), "##,##0") > CDbl(Tax_LAK1) Or Format(CDbl(txtTotal_remaining.Text), "##,##0") = CDbl(Tax_LAK2) Then
            If Format(CDbl(txtTotal_remaining.Text), "##,##0.00") > CDbl(Tax_LAK2) Then
                Tax1_cut = CDbl(Tax_LAK2) - CDbl(Tax_LAK1)
                Tax1_Sum = CDbl(Tax1_cut) * CDbl(Tax2) / 100
                Tax2_Sum = 0
                Tax3_Sum = 0
                Tax4_Sum = 0
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
            Else
                Tax1_cut = Format(CDbl(txtTotal_remaining.Text), "##,##0.00") - CDbl(Tax_LAK1)
                Tax1_Sum = CDbl(Tax1_cut) * CDbl(Tax2) / 100
                'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                Tax2_Sum = 0
                Tax3_Sum = 0
                Tax4_Sum = 0
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
            End If
        Else
            Tax1_Sum = 0
        End If

        If Format(CDbl(txtTotal_remaining.Text), "##,##0") > CDbl(Tax_LAK2) Or Format(CDbl(txtTotal_remaining.Text), "##,##0") = CDbl(Tax_LAK3) Then
            If Format(CDbl(txtTotal_remaining.Text), "##,##0") > CDbl(Tax_LAK3) Then
                Tax2_cut = CDbl(Tax_LAK3) - CDbl(Tax_LAK2)
                Tax2_Sum = CDbl(Tax2_cut) * CDbl(Tax3) / 100
                Tax3_Sum = 0
                Tax4_Sum = 0
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
            Else
                Tax2_cut = Format(CDbl(txtTotal_remaining.Text), "##,##0.00") - CDbl(Tax_LAK2)
                Tax2_Sum = CDbl(Tax2_cut) * CDbl(Tax3) / 100
                'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                Tax3_Sum = 0
                Tax4_Sum = 0
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
            End If
        End If

        If Format(CDbl(txtTotal_remaining.Text), "##,##0") > CDbl(Tax_LAK3) Or Format(CDbl(txtTotal_remaining.Text), "##,##0") = CDbl(Tax_LAK4) Then
            If Format(CDbl(txtTotal_remaining.Text), "##,##0.00") > CDbl(Tax_LAK3) Then
                Tax3_cut = CDbl(Tax_LAK4) - CDbl(Tax_LAK3)
                Tax3_Sum = CDbl(Tax3_cut) * CDbl(Tax4) / 100
                Tax4_Sum = 0
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
            Else
                Tax3_cut = Format(CDbl(txtTotal_remaining.Text), "##,##0.00") - CDbl(Tax_LAK3)
                Tax3_Sum = CDbl(Tax3_cut) * CDbl(Tax4) / 100
                'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                Tax4_Sum = 0
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
            End If
        End If

        If Format(CDbl(txtTotal_remaining.Text), "##,##0.00") > CDbl(Tax_LAK4) Or Format(CDbl(txtTotal_remaining.Text), "##,##0.00") = CDbl(Tax_LAK5) Then
            If Format(CDbl(txtTotal_remaining.Text), "##,##0.00") > CDbl(Tax_LAK4) Then
                Tax4_cut = CDbl(Tax_LAK5) - CDbl(Tax_LAK4)
                Tax4_Sum = CDbl(Tax4_cut) * CDbl(Tax5) / 100
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
            Else
                Tax4_cut = Format(CDbl(txtTotal_remaining.Text), "##,##0.00") - CDbl(Tax_LAK4)
                Tax4_Sum = CDbl(Tax4_cut) * CDbl(Tax5) / 100
                'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
            End If
        End If

        If Format(CDbl(txtTotal_remaining.Text), "##,##0.00") > CDbl(Tax_LAK5) Or Format(CDbl(txtTotal_remaining.Text), "##,##0.00") = CDbl(Tax_LAK6) Then
            If Format(CDbl(txtTotal_remaining.Text), "##,##0.00") > CDbl(Tax_LAK5) Then
                Tax5_cut = CDbl(Tax_LAK6) - CDbl(Tax_LAK5)
                Tax5_Sum = CDbl(Tax5_cut) * CDbl(Tax6) / 100
                Tax6_Sum = 0
                Tax7_Sum = 0
            Else
                Tax5_cut = Format(CDbl(txtTotal_remaining.Text), "##,##0.00") - CDbl(Tax_LAK5)
                Tax5_Sum = CDbl(Tax5_cut) * CDbl(Tax6) / 100
                'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                Tax6_Sum = 0
                Tax7_Sum = 0
            End If
        End If

        If Format(CDbl(txtTotal_remaining.Text), "##,##0.00") > CDbl(Tax_LAK6) Then

            Tax6_cut = Format(CDbl(txtTotal_remaining.Text), "##,##0.00") - CDbl(Tax_LAK6)
            Tax6_Sum = CDbl(Tax6_cut) * CDbl(Tax7) / 100
            'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
        End If


        'txtTax.Text = Format(CDbl(Tax1_Sum) + CDbl(Tax2_Sum) + CDbl(Tax3_Sum) + CDbl(Tax4_Sum) + CDbl(Tax5_Sum) + CDbl(Tax6_Sum) + CDbl(Tax7_Sum), "##,##0.00")
        'txtToltal_All.Text = Format(CDbl(txtTotal_remaining.Text) - CDbl(txtTax.Text) + CDbl(txtkhongsep.Text) + CDbl(txtson_Money.Text) + CDbl(txtMom_mony.Text) - CDbl(txtTax.Text), "##,##0.00")
        'txtToltal_All.Text = Format(CDbl(txtTotal_remaining.Text) - CDbl(txtTax.Text), "##,##0")
        'txtnet_money.Text = Format(CDbl(txttotal_after.Text), "##,##0")

    End Sub

    Private Sub Badd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badd.Click
        addnew()
    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 Bill_no from AP_donw_Personal    Order by Bill_no DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("Bill_no").Value, 1, 6)) + 1, "000000")
        Else
            VIOTNEW = "000001"

        End If
        txt_no.Text = Trim(CStr(VIOTNEW.ToString))
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtid.Text = "" Then MsgBox("ໃສ່ລະຫັດພະນັກງານກ່ອນ") : Exit Sub

        'If txtEM_ID.Text = "" Then MsgBox("ໃສ່ລະຫັດພະນັກງານກ່ອນ") : txtEM_ID.Focus() : Exit Sub


        Save()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub Save()

        Dim rs As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT * FROM  AP_Salary WHERE   E_ID = '" & txtid.Text & "'", rs)
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO   AP_Salary (E_ID, Name_L, percen, txtclass, txtlevel, txtV_C, txtgroup_id, cmbKip, txtsalary, txtTum_money,txt_hours_money, txtoil, txtphone_money, remark, lst_updt, lst_usr, Pc_nm) " & _
               " VALUES(N'" & (txtid.Text) & "'," & _
                      " N'" & (TxtPersonNmL.Text) & "'," & _
                " " & CDbl(cmb_percen.Text) & "," & _
                   " N'" & (cmbclass.Text) & "'," & _
                    " N'" & (cmblevel.Text) & "'," & _
                     " N'" & (txtV_C.Text) & "'," & _
                  " N'" & (txtgroup_id.Text) & "'," & _
                   " N'" & (cmbKip.Text) & "'," & _
                  " " & CDbl(txtsalary.Text) & "," & _
                   " " & CDbl(txtTum_money.Text) & "," & _
                  " " & CDbl(txt_hours_money.Text) & "," & _
                 " " & CDbl(txtoil.Text) & "," & _
                     " " & CDbl(txtphone_money.Text) & "," & _
                 " N'" & (txtremark.Text) & "'," & _
                                  " Getdate()," & _
                               " N'" & MUserName & "'," & _
                            " '" & MDServerName & "')"
                Conn.Execute(aa)
            Else
                Conn.Execute("delete from   AP_Salary WHERE    E_ID= '" & (txtid.Text) & "'")
                Dim aa As String
                aa = "INSERT INTO   AP_Salary (E_ID, Name_L, percen, txtclass, txtlevel, txtV_C, txtgroup_id, cmbKip, txtsalary,txtTum_money, txt_hours_money, txtoil, txtphone_money, remark, lst_updt, lst_usr, Pc_nm) " & _
                 " VALUES(N'" & (txtid.Text) & "'," & _
                        " N'" & (TxtPersonNmL.Text) & "'," & _
                     " " & CDbl(cmb_percen.Text) & "," & _
                     " N'" & (cmbclass.Text) & "'," & _
                      " N'" & (cmblevel.Text) & "'," & _
                       " N'" & (txtV_C.Text) & "'," & _
                    " N'" & (txtgroup_id.Text) & "'," & _
                     " N'" & (cmbKip.Text) & "'," & _
                    " " & CDbl(txtsalary.Text) & "," & _
                                   " " & CDbl(txtTum_money.Text) & "," & _
                    " " & CDbl(txt_hours_money.Text) & "," & _
                   " " & CDbl(txtoil.Text) & "," & _
                       " " & CDbl(txtphone_money.Text) & "," & _
                   " N'" & (txtremark.Text) & "'," & _
                                    " Getdate()," & _
                                 " N'" & MUserName & "'," & _
                              " '" & MDServerName & "')"
                Conn.Execute(aa)
            End If
        End With


        'Conn.Execute(" UPDATE AP_CV SET " & _
        '               " percen=" & CDbl(cmb_percen.Text) & "," & _
        '          " cmbclass='" & cmbclass.Text & "'," & _
        '           " cmblevel='" & cmblevel.Text & "'," & _
        '           " txtV_C='" & txtV_C.Text & "'," & _
        '           " Level_Clss_Money=" & CDbl(txtLevel_Clss_Money_Now.Text) & "," & _
        '            " Tumnang_Money=" & CDbl(txtTumnang_Money.Text) & "," & _
        '             " year_money=" & CDbl(txtyear_money.Text) & "," & _
        '              " txttotal=" & CDbl(txttotal.Text) & "," & _
        '               " AGL=" & CDbl(txtAGL.Text) & "," & _
        '                " Total_remaining=" & CDbl(txtTotal_remaining.Text) & "," & _
        '                 " Tax=" & CDbl(txtTax.Text) & "," & _
        '                  " khongsep=" & CDbl(txtkhongsep.Text) & "," & _
        '                   " txtson=" & CDbl(txtson.Text) & "," & _
        '                    " txtson_Money=" & CDbl(txtson_Money.Text) & "," & _
        '                     " txtmom=" & CDbl(txtmom.Text) & "," & _
        '                      " txtMom_mony=" & CDbl(txtMom_mony.Text) & "," & _
        '                        " txtToltal_All=" & CDbl(txtToltal_All.Text) & "" & _
        '          " WHERE E_ID= '" & (txtid.Text) & "'")



    End Sub



    Private Sub cmb_percen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_percen.SelectedIndexChanged

        'Load_Tax()
        'txtV_C.Text = cmbclass.Text & "/" & cmblevel.Text
        'txtLevel_Clss_Money_Now.Text = 0
        'txtLevel_Clss_Money_Now.Text = Format(CDbl(txtLevel_Clss_Money_Now.Text) * CDbl(cmb_percen.Text) / 100, "##,##0.00")
        'loadmonet_class()
        'Load_sum_tax()

    End Sub


    Private Sub txtTumnang_Money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtkhongsep_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter
                loadmonet_class()
                Load_sum_tax()

        End Select
    End Sub

    Private Sub txtkhongsep_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtyear_money_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter
                loadmonet_class()
                Load_sum_tax()
                'txtyear_money.Text = Format(CDbl(txtyear_money.Text), "##,##0.00")
        End Select
    End Sub

    Private Sub txtyear_money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtLevel_Clss_Money_Now_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsalary.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                'loadmonet_class()
                'Load_sum_tax()
                txtsalary.Text = Format(CDbl(txtsalary.Text), "##,##0.00")
                txtTum_money.Focus()

                txt_hours_money.Text = Format(CDbl(txtsalary.Text) / CDbl(txt_group.Text), "##,##0.00")
        End Select
    End Sub

    Private Sub txtLevel_Clss_Money_Now_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsalary.TextChanged

    End Sub

    Private Sub cmb_group_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_group.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Salary_group Where Group_SLR_nm=N'" & Trim(cmb_group.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtgroup_id.Text = Trim(RSC("Group_SLR_id").Value)
            txt_group.Text = Trim(RSC("Group_100").Value)


            txt_hours_money.Text = Format(CDbl(txtsalary.Text) / CDbl(txt_group.Text), "##,##0")

        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txt_hours_money_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_hours_money.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                'loadmonet_class()
                'Load_sum_tax()
                txt_hours_money.Text = Format(CDbl(txt_hours_money.Text), "##,##0")
                txtoil.Focus()
        End Select
    End Sub

    Private Sub txt_hours_money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_hours_money.TextChanged

    End Sub

    Private Sub txtoil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtoil.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                'loadmonet_class()
                'Load_sum_tax()

                txtphone_money.Focus()
        End Select
    End Sub

    Private Sub txtoil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoil.TextChanged

    End Sub

    Private Sub txtphone_money_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtphone_money.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                'loadmonet_class()
                'Load_sum_tax()
                txtphone_money.Text = Format(CDbl(txtphone_money.Text), "##,##0.00")

        End Select
    End Sub

    Private Sub txtphone_money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphone_money.TextChanged

    End Sub

    Private Sub txtTum_money_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTum_money.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                'loadmonet_class()
                'Load_sum_tax()
                txtTum_money.Text = Format(CDbl(txtTum_money.Text), "##,##0")
                txt_hours_money.Focus()
        End Select
    End Sub

    Private Sub txtTum_money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTum_money.TextChanged

    End Sub

    Private Sub txt_3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_3.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                'loadmonet_class()
                'Load_sum_tax()
           

                txt_hours_money.Text = Format(CDbl(txtsalary.Text) / CDbl(txt_group.Text), "##,##0")
        End Select
    End Sub

    Private Sub txt_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_3.TextChanged
   
    End Sub

    Private Sub txt_group_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_group.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                'loadmonet_class()
                'Load_sum_tax()


                txt_hours_money.Text = Format(CDbl(txtsalary.Text) / CDbl(txt_group.Text), "##,##0")
        End Select
    End Sub

    Private Sub txt_group_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_group.TextChanged

    End Sub
End Class