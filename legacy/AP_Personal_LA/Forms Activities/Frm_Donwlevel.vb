Public Class Frm_Donwlevel

    Private Sub Frm_Donwlevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTumnang_Money.Text = 0
        txtyear_money.Text = 0
        txtAGL.Text = 0
        txtTax.Text = 0
        txtkhongsep.Text = 0
        txtson.Text = 0
        txtmom.Text = 0
        txtson_Money.Text = 0
        txtMom_mony.Text = 0
        addnew()

        Load_Tax()
        loadCMB()


        If EditActive = True Then
            Editdata()


        Else
            EditActive = False
            'addnew()
            LoadData_CV()

        End If
    End Sub
    Private Sub Editdata()
        Dim aa As String
        Dim rs As New ADODB.Recordset
        aa = "SELECT    * from AP_donw_Personal  where E_ID=N'" & E_ID & "' and Bill_no=N'" & Bill_no & "'"
        Call LoadRs(aa, rs)
        With rs
            If .RecordCount > 0 Then
                txt_no.Text = Trim(.Fields("Bill_no").Value.ToString)
                txtid.Text = Trim(.Fields("E_ID").Value.ToString)
                DT_up.Value = Trim(.Fields("DT_dn").Value.ToString)
                Cmb_Sections.Text = Trim(.Fields("Sections").Value.ToString)
                cmb_Department.Text = Trim(.Fields("Department").Value.ToString)
                TxtPersonNmL.Text = Trim(.Fields("Name_L").Value.ToString)
                TxtPersonNmE.Text = Trim(.Fields("Name_E").Value.ToString)
                TxtTel.Text = Trim(.Fields("Phone").Value.ToString)

                TxtAccountNo.Text = Trim(.Fields("Bank_no").Value.ToString)
                txtAPSocial.Text = Trim(.Fields("SSO_no").Value.ToString)

                txtclass_old.Text = Trim(.Fields("txtclass_old").Value.ToString)
                txtlevel_old.Text = Trim(.Fields("txtlevel_old").Value.ToString)
                txt_V_C_old.Text = Trim(.Fields("txtV_C_old").Value.ToString)
                txtLevel_Clss_Money.Text = Format(CDbl(.Fields("Level_Clss_Money_old").Value), "##,##0.00")
                cmb_percen_old.Text = Trim(.Fields("percen_old").Value.ToString)
                cmb_percen.Text = Trim(.Fields("percen").Value.ToString)

                cmbclass.Text = Trim(.Fields("txtclass").Value.ToString)
                cmblevel.Text = Trim(.Fields("txtlevel").Value.ToString)
                txtV_C.Text = Trim(.Fields("txtV_C").Value.ToString)
                txtLevel_Clss_Money_Now.Text = Format(CDbl(.Fields("Level_Clss_Money").Value), "##,##0.00")
                txtTumnang_Money.Text = Format(CDbl(.Fields("Tumnang_Money").Value), "##,##0.00")
                txtyear_money.Text = Format(CDbl(.Fields("year_money").Value), "##,##0.00")
                txttotal.Text = Format(CDbl(.Fields("txttotal").Value), "##,##0.00")
                txtAGL.Text = Format(CDbl(.Fields("AGL").Value), "##,##0.00")
                txtTotal_remaining.Text = Format(CDbl(.Fields("Total_remaining").Value), "##,##0.00")
                txtTax.Text = Format(CDbl(.Fields("Tax").Value), "##,##0.00")
                txtkhongsep.Text = Format(CDbl(.Fields("khongsep").Value), "##,##0.00")
                txtson.Text = Format(CDbl(.Fields("txtson").Value), "##,##0")
                txtson_Money.Text = Format(CDbl(.Fields("txtson_Money").Value), "##,##0.00")
                txtmom.Text = Format(CDbl(.Fields("txtmom").Value), "##,##0")
                txtMom_mony.Text = Format(CDbl(.Fields("txtMom_mony").Value), "##,##0.00")
                txtToltal_All.Text = Format(CDbl(.Fields("txtToltal_All").Value), "##,##0.00")

                txtkhor_tok_long.Text = Trim(.Fields("txtkhor_tok_long").Value.ToString)
                txtAccount_clss_level.Text = Trim(.Fields("txtAccount_clss_level").Value.ToString)

                cmb_type_dn.Text = Trim(.Fields("type_dn").Value.ToString)
                txtremark.Text = Trim(.Fields("remark").Value.ToString)

            End If
        End With
    End Sub
    Private Sub addnew()
        'txt_V_C_old.Text = ""
        'cmb_percen_old.Text = 100
        'cmb_percen_old.SelectedIndex = 0
        'cmb_Department.SelectedIndex = 0
        'cmb_percen.SelectedIndex = 0
        'txtid.Text = ""
        'TxtPersonNmL.Text = ""
        'TxtPersonNmE.Text = ""
        'TxtTel.Text = ""
        'TxtAccountNo.Text = ""
        'txtAPSocial.Text = ""

        cmbclass.Text = 1
        cmblevel.Text = 1
        txtTumnang_Money.Text = 0
        txtyear_money.Text = 0
        txtAGL.Text = 0
        txtTax.Text = 0
        txtkhongsep.Text = 0
        txtson.Text = 0
        txtmom.Text = 0
        txtson_Money.Text = 0
        txtMom_mony.Text = 0

        txtkhor_tok_long.Text = ""
        txtAccount_clss_level.Text = ""


        AutoNumber()
    End Sub
    Private Sub loadCMB()
        Cmb_Sections.Items.Clear()
        Call load_Cmb("select Sec_nmL from AP_Sections", "Sec_nmL", Cmb_Sections)
        Cmb_Sections.SelectedIndex = 0

        cmb_Department.Items.Clear()
        Call load_Cmb("select DP_Name from Department", "DP_Name", cmb_Department)
        cmb_Department.SelectedIndex = 0

        Call load_Cmb("select dn_nm from Type_donw", "dn_nm", cmb_type_dn)
        cmb_type_dn.SelectedIndex = 0

        cmbclass.Items.Clear()
        Call load_Cmb("select cl_ID from Class", "cl_ID", cmbclass)
        cmbclass.SelectedIndex = 0

        cmblevel.Items.Clear()
        Call load_Cmb("select LV_ID from Level", "LV_ID", cmblevel)
        cmblevel.SelectedIndex = 0
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmCustomer_item.ShowDialog()
        If MDCusID = "" Then Exit Sub
        LoadData_CV()
        AutoNumber()
        loadmonet_class()
        Load_sum_tax()
    End Sub
    Private Sub LoadData_CV()
        Dim rs As New ADODB.Recordset
        Dim aa As String
        With rs
            aa = "SELECT    AP_CV.*, AP_Village.Vl_nm, AP_District.Dt_id, AP_District.Dt_nm, AP_Province.PV_ID, AP_Province.PV_nm, " & _
                    "   AP_Village_1.Vl_nm AS Vl_nm1, AP_District_1.Dt_nm AS Dt_nm1, AP_Province_1.PV_nm AS PV_nm1 " & _
                    "   FROM         AP_CV INNER JOIN " & _
                    "   AP_Village ON AP_CV.BVill_ID = AP_Village.Vl_ID INNER JOIN  " & _
                     "  AP_District ON AP_Village.Dt_id = AP_District.Dt_id INNER JOIN " & _
                     "  AP_Province ON AP_District.PV_id = AP_Province.PV_ID INNER JOIN " & _
                     "  AP_Village AS AP_Village_1 ON AP_CV.Add_Vill_ID = AP_Village_1.Vl_ID INNER JOIN " & _
                     "  AP_District AS AP_District_1 ON AP_Village_1.Dt_id = AP_District_1.Dt_id INNER JOIN " & _
                    "   AP_Province AS AP_Province_1 ON AP_District_1.PV_id = AP_Province_1.PV_ID WHERE 1=1  AND AP_CV.E_ID=N'" & CustID & "' "
            Call LoadRs(aa, rs)
            If .RecordCount <> 0 Then
                txtid.Text = (.Fields("E_ID").Value.ToString)
                TxtPersonNmL.Text = (.Fields("Name_L").Value.ToString)
                TxtPersonNmE.Text = (.Fields("Name_E").Value.ToString)
                Cmb_Sections.Text = (.Fields("Sections").Value.ToString)
                cmb_Department.Text = (.Fields("Department").Value.ToString)
                TxtTel.Text = (.Fields("Phone").Value.ToString)
                TxtAccountNo.Text = (.Fields("Bank_no").Value.ToString)
                txtAPSocial.Text = (.Fields("SSO_no").Value.ToString)
                cmb_percen_old.Text = (.Fields("percen").Value.ToString)
                txtclass_old.Text = (.Fields("cmbclass").Value.ToString)
                txtlevel_old.Text = (.Fields("cmblevel").Value.ToString)
                txt_V_C_old.Text = (.Fields("txtV_C").Value.ToString)
                txtLevel_Clss_Money.Text = Format(CDbl(.Fields("Level_Clss_Money").Value), "##,##0.00")

                cmb_percen.Text = (.Fields("percen").Value.ToString)
                cmbclass.Text = (.Fields("cmbclass").Value.ToString)
                cmblevel.Text = (.Fields("cmblevel").Value.ToString)
                txtV_C.Text = (.Fields("txtV_C").Value.ToString)
                txtson.Text = (.Fields("txtson").Value.ToString)
                txtson_Money.Text = Format(CDbl(.Fields("txtson_Money").Value), "##,##0.00")
                txtmom.Text = (.Fields("txtmom").Value.ToString)
                txtMom_mony.Text = Format(CDbl(.Fields("txtMom_mony").Value), "##,##0.00")

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
        Load_Tax()

        txtV_C.Text = cmbclass.Text & "/" & cmblevel.Text

        If cmblevel.Text <> "" Then
            loadmonet_class()
            Load_sum_tax()
        End If
    End Sub

    Private Sub cmblevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblevel.SelectedIndexChanged
        Load_Tax()

        txtV_C.Text = cmbclass.Text & "/" & cmblevel.Text

        loadmonet_class()
        Load_sum_tax()
    End Sub
    Private Sub loadmonet_class()
        Dim rs As New ADODB.Recordset
        Call LoadRs("select * from Level_class where name='" & Trim(Apostrophe(txtV_C.Text)) & "'", rs)
        With rs
            If .RecordCount > 0 Then

                txtLevel_Clss_Money_Now.Text = Format(CDbl(.Fields("Toltle").Value), "##,##0.00")

            Else
                txtLevel_Clss_Money_Now.Text = 0

            End If
        End With
        If cmb_percen.Text <> "" Then
            txtLevel_Clss_Money_Now.Text = Format(CDbl(txtLevel_Clss_Money_Now.Text) * CDbl(cmb_percen.Text) / 100, "##,##0.00")
        End If


        txttotal.Text = Format(CDbl(txtLevel_Clss_Money_Now.Text) + CDbl(txtTumnang_Money.Text) + CDbl(txtyear_money.Text), "##,##0.00")
        txtTotal_remaining.Text = Format(CDbl(txttotal.Text) - CDbl(txtAGL.Text), "##,##0.00")
        'txtToltal_All.Text = Format(CDbl(txtTotal_remaining.Text) - CDbl(txtTax.Text) + CDbl(txtkhongsep.Text) + CDbl(txtson_Money.Text) + CDbl(txtMom_mony.Text), "##,##0.00")

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


        txtTax.Text = Format(CDbl(Tax1_Sum) + CDbl(Tax2_Sum) + CDbl(Tax3_Sum) + CDbl(Tax4_Sum) + CDbl(Tax5_Sum) + CDbl(Tax6_Sum) + CDbl(Tax7_Sum), "##,##0.00")
        txtToltal_All.Text = Format(CDbl(txtTotal_remaining.Text) - CDbl(txtTax.Text) + CDbl(txtkhongsep.Text) + CDbl(txtson_Money.Text) + CDbl(txtMom_mony.Text) - CDbl(txtTax.Text), "##,##0.00")
        'txtToltal_All.Text = Format(CDbl(txtTotal_remaining.Text) - CDbl(txtTax.Text), "##,##0")
        'txtnet_money.Text = Format(CDbl(txttotal_after.Text), "##,##0")

    End Sub

    Private Sub Badd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badd.Click
        txt_V_C_old.Text = ""
        cmb_percen_old.Text = 100
        cmb_Department.SelectedIndex = 0
        cmb_percen.SelectedIndex = 0
        txtid.Text = ""
        TxtPersonNmL.Text = ""
        TxtPersonNmE.Text = ""
        TxtTel.Text = ""
        TxtAccountNo.Text = ""
        txtAPSocial.Text = ""
        txtLevel_Clss_Money.Text = 0
        txtkhor_tok_long.Text = ""
        txtAccount_clss_level.Text = ""
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

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Frm_Type_donw.ShowDialog()
        cmb_type_dn.Items.Clear()
        Call load_Cmb("select dn_nm from Type_donw", "dn_nm", cmb_type_dn)
        cmb_type_dn.SelectedIndex = 0
    End Sub


    Private Sub cmb_type_up_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_type_dn.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Type_donw Where dn_nm=N'" & Trim(cmb_type_dn.Text) & "' ", RSC)
        If RSC.RecordCount > 0 Then
            txtdn_id.Text = Trim(RSC("dn_id").Value)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txt_no.Text = "" Then MsgBox("ໃສ່ລະຫັດພະນັກງານກ່ອນ") : Exit Sub

        'If txtEM_ID.Text = "" Then MsgBox("ໃສ່ລະຫັດພະນັກງານກ່ອນ") : txtEM_ID.Focus() : Exit Sub


        Save()
        Conn.Execute(" UPDATE ap_cv SET Status_donw=1 where E_ID='" & txtid.Text & "'")
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub Save()

        Dim rs As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT * FROM  AP_donw_Personal WHERE  Bill_no= '" & (txt_no.Text) & "' and E_ID = '" & txtid.Text & "'", rs)
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO   AP_donw_Personal (  Bill_no, E_ID, DT_dn, Sections_id, Sections, Department_id, Department, Name_L, Name_E, Phone, Bank_no, SSO_no,percen_old, txtclass_old, txtlevel_old, " & _
               "   txtV_C_old, Level_Clss_Money_old, txtclass, txtlevel, txtV_C, Level_Clss_Money, Tumnang_Money, year_money, txttotal, AGL, Total_remaining, Tax, khongsep,  " & _
       "     txtson, txtson_Money, txtmom, txtMom_mony, txtToltal_All, txtkhor_tok_long, txtAccount_clss_level, type_dn_id, type_dn,percen, remark, lst_updt, lst_usr, Pc_nm) " & _
               " VALUES(N'" & (txt_no.Text) & "'," & _
                 " N'" & (txtid.Text) & "'," & _
                " '" & Format(DT_up.Value, "yyyy-MM-dd") & "'," & _
                     " N'" & (txtSection_ID.Text) & "'," & _
                   " N'" & (Cmb_Sections.Text) & "'," & _
                     " N'" & (txtdepart_ID.Text) & "'," & _
                   " N'" & (cmb_Department.Text) & "'," & _
                      " N'" & (TxtPersonNmL.Text) & "'," & _
                 " N'" & (TxtPersonNmE.Text) & "'," & _
                      " N'" & (TxtTel.Text) & "'," & _
                   " N'" & (TxtAccountNo.Text) & "'," & _
                   " N'" & (txtAPSocial.Text) & "'," & _
                   " " & CDbl(cmb_percen_old.Text) & "," & _
                        " N'" & (txtclass_old.Text) & "'," & _
                         " N'" & (txtlevel_old.Text) & "'," & _
                     " N'" & (txt_V_C_old.Text) & "'," & _
                           " " & CDbl(txtLevel_Clss_Money.Text) & "," & _
                                   " N'" & (cmbclass.Text) & "'," & _
                                        " N'" & (cmblevel.Text) & "'," & _
                                             " N'" & (txtV_C.Text) & "'," & _
                               " " & CDbl(txtLevel_Clss_Money_Now.Text) & "," & _
                    " " & CDbl(txtTumnang_Money.Text) & "," & _
                               " " & CDbl(txtyear_money.Text) & "," & _
                       " " & CDbl(txttotal.Text) & "," & _
                         " " & CDbl(txtAGL.Text) & "," & _
                           " " & CDbl(txtTotal_remaining.Text) & "," & _
                             " " & CDbl(txtTax.Text) & "," & _
                               " " & CDbl(txtkhongsep.Text) & "," & _
                                      " " & CDbl(txtson.Text) & "," & _
                           " " & CDbl(txtson_Money.Text) & "," & _
                             " " & CDbl(txtmom.Text) & "," & _
                               " " & CDbl(txtMom_mony.Text) & "," & _
                                  " " & CDbl(txtToltal_All.Text) & "," & _
                                      " N'" & (txtkhor_tok_long.Text) & "'," & _
                       " N'" & (txtAccount_clss_level.Text) & "'," & _
                     " N'" & (txtdn_id.Text) & "'," & _
                   " N'" & (cmb_type_dn.Text) & "'," & _
                      " " & CDbl(cmb_percen.Text) & "," & _
                      " N'" & (txtremark.Text) & "'," & _
                                        " Getdate()," & _
                               " N'" & MUserName & "'," & _
                            " '" & MDServerName & "')"
                Conn.Execute(aa)
            Else
                Conn.Execute("delete from   AP_donw_Personal WHERE  Bill_no= '" & (txt_no.Text) & "' and  E_ID= '" & (txtid.Text) & "'")
                Dim aa As String
                aa = "INSERT INTO   AP_donw_Personal (  Bill_no, E_ID, DT_dn, Sections_id, Sections, Department_id, Department, Name_L, Name_E, Phone, Bank_no, SSO_no,percen_old, txtclass_old, txtlevel_old, " & _
              "   txtV_C_old, Level_Clss_Money_old, txtclass, txtlevel, txtV_C, Level_Clss_Money, Tumnang_Money, year_money, txttotal, AGL, Total_remaining, Tax, khongsep,  " & _
      "     txtson, txtson_Money, txtmom, txtMom_mony, txtToltal_All, txtkhor_tok_long, txtAccount_clss_level, type_dn_id, type_dn,percen, remark, lst_updt, lst_usr, Pc_nm) " & _
              " VALUES(N'" & (txt_no.Text) & "'," & _
                " N'" & (txtid.Text) & "'," & _
               " '" & Format(DT_up.Value, "yyyy-MM-dd") & "'," & _
                    " N'" & (txtSection_ID.Text) & "'," & _
                  " N'" & (Cmb_Sections.Text) & "'," & _
                    " N'" & (txtdepart_ID.Text) & "'," & _
                  " N'" & (cmb_Department.Text) & "'," & _
                     " N'" & (TxtPersonNmL.Text) & "'," & _
                " N'" & (TxtPersonNmE.Text) & "'," & _
                     " N'" & (TxtTel.Text) & "'," & _
                  " N'" & (TxtAccountNo.Text) & "'," & _
                  " N'" & (txtAPSocial.Text) & "'," & _
                  " " & CDbl(cmb_percen_old.Text) & "," & _
                       " N'" & (txtclass_old.Text) & "'," & _
                        " N'" & (txtlevel_old.Text) & "'," & _
                    " N'" & (txt_V_C_old.Text) & "'," & _
                          " " & CDbl(txtLevel_Clss_Money.Text) & "," & _
                                  " N'" & (cmbclass.Text) & "'," & _
                                       " N'" & (cmblevel.Text) & "'," & _
                                            " N'" & (txtV_C.Text) & "'," & _
                              " " & CDbl(txtLevel_Clss_Money_Now.Text) & "," & _
                   " " & CDbl(txtTumnang_Money.Text) & "," & _
                              " " & CDbl(txtyear_money.Text) & "," & _
                      " " & CDbl(txttotal.Text) & "," & _
                        " " & CDbl(txtAGL.Text) & "," & _
                          " " & CDbl(txtTotal_remaining.Text) & "," & _
                            " " & CDbl(txtTax.Text) & "," & _
                              " " & CDbl(txtkhongsep.Text) & "," & _
                                     " " & CDbl(txtson.Text) & "," & _
                          " " & CDbl(txtson_Money.Text) & "," & _
                            " " & CDbl(txtmom.Text) & "," & _
                              " " & CDbl(txtMom_mony.Text) & "," & _
                                 " " & CDbl(txtToltal_All.Text) & "," & _
                                     " N'" & (txtkhor_tok_long.Text) & "'," & _
                      " N'" & (txtAccount_clss_level.Text) & "'," & _
                    " N'" & (txtdn_id.Text) & "'," & _
                  " N'" & (cmb_type_dn.Text) & "'," & _
                     " " & CDbl(cmb_percen.Text) & "," & _
                     " N'" & (txtremark.Text) & "'," & _
                                       " Getdate()," & _
                              " N'" & MUserName & "'," & _
                           " '" & MDServerName & "')"
                Conn.Execute(aa)
            End If
        End With


        Conn.Execute(" UPDATE AP_CV SET " & _
                       " percen=" & CDbl(cmb_percen.Text) & "," & _
                  " cmbclass='" & cmbclass.Text & "'," & _
                   " cmblevel='" & cmblevel.Text & "'," & _
                   " txtV_C='" & txtV_C.Text & "'," & _
                      " DT_Work_now='" & Format(DT_up.Value, "yyyy-MM-dd") & "'," & _
                   " Level_Clss_Money=" & CDbl(txtLevel_Clss_Money_Now.Text) & "," & _
                    " Tumnang_Money=" & CDbl(txtTumnang_Money.Text) & "," & _
                     " year_money=" & CDbl(txtyear_money.Text) & "," & _
                      " txttotal=" & CDbl(txttotal.Text) & "," & _
                       " AGL=" & CDbl(txtAGL.Text) & "," & _
                        " Total_remaining=" & CDbl(txtTotal_remaining.Text) & "," & _
                         " Tax=" & CDbl(txtTax.Text) & "," & _
                          " khongsep=" & CDbl(txtkhongsep.Text) & "," & _
                           " txtson=" & CDbl(txtson.Text) & "," & _
                            " txtson_Money=" & CDbl(txtson_Money.Text) & "," & _
                             " txtmom=" & CDbl(txtmom.Text) & "," & _
                              " txtMom_mony=" & CDbl(txtMom_mony.Text) & "," & _
                                " txtToltal_All=" & CDbl(txtToltal_All.Text) & "" & _
                  " WHERE E_ID= '" & (txtid.Text) & "'")

        Conn.Execute(" UPDATE AP_Salary SET " & _
                   " percen=" & CDbl(cmb_percen.Text) & "," & _
              " txtclass='" & cmbclass.Text & "'," & _
               " txtlevel='" & cmblevel.Text & "'," & _
               " txtV_C='" & txtV_C.Text & "'," & _
                 " DT_Work_now='" & Format(DT_up.Value, "yyyy-MM-dd") & "'," & _
               " Level_Clss_Money=" & CDbl(txtLevel_Clss_Money_Now.Text) & "," & _
                " Tumnang_Money=" & CDbl(txtTumnang_Money.Text) & "," & _
                 " year_money=" & CDbl(txtyear_money.Text) & "," & _
                  " txttotal=" & CDbl(txttotal.Text) & "," & _
                   " AGL=" & CDbl(txtAGL.Text) & "," & _
                    " Total_remaining=" & CDbl(txtTotal_remaining.Text) & "," & _
                     " Tax=" & CDbl(txtTax.Text) & "," & _
                      " khongsep=" & CDbl(txtkhongsep.Text) & "," & _
                       " txtson=" & CDbl(txtson.Text) & "," & _
                        " txtson_Money=" & CDbl(txtson_Money.Text) & "," & _
                         " txtmom=" & CDbl(txtmom.Text) & "," & _
                          " txtMom_mony=" & CDbl(txtMom_mony.Text) & "," & _
                            " txtToltal_All=" & CDbl(txtToltal_All.Text) & "" & _
              " WHERE E_ID= '" & (txtid.Text) & "'")


    End Sub

 

    Private Sub cmb_percen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_percen.SelectedIndexChanged

        Load_Tax()
        txtV_C.Text = cmbclass.Text & "/" & cmblevel.Text
        txtLevel_Clss_Money_Now.Text = 0
        txtLevel_Clss_Money_Now.Text = Format(CDbl(txtLevel_Clss_Money_Now.Text) * CDbl(cmb_percen.Text) / 100, "##,##0.00")
        loadmonet_class()
        Load_sum_tax()

    End Sub

    Private Sub txtTumnang_Money_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTumnang_Money.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                loadmonet_class()
                Load_sum_tax()
                txtTumnang_Money.Text = Format(CDbl(txtTumnang_Money.Text), "##,##0.00")
        End Select
    End Sub

  
 
    Private Sub txtTumnang_Money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTumnang_Money.TextChanged

    End Sub

    Private Sub txtyear_money_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtyear_money.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                loadmonet_class()
                Load_sum_tax()
                txtyear_money.Text = Format(CDbl(txtyear_money.Text), "##,##0.00")
        End Select
    End Sub

    Private Sub txtyear_money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtyear_money.TextChanged

    End Sub

    Private Sub txtkhongsep_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkhongsep.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                loadmonet_class()
                Load_sum_tax()
                txtkhongsep.Text = Format(CDbl(txtkhongsep.Text), "##,##0.00")
        End Select
    End Sub

    Private Sub txtkhongsep_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkhongsep.TextChanged

    End Sub

   
End Class