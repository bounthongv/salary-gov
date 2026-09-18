Public Class frm_salary_calculate
    Dim v1 As String
    Dim o150 As Integer = 0
    Dim o200 As Integer = 0
    Dim o250 As Integer = 0
    Dim o300 As Integer = 0

    Dim Group_ID As String

    Dim Group_100 As Double = 0
    Dim Group_percen100 As Double = 0
    Dim Group_90 As Double = 0
    Dim Group_percen90 As Double = 0
    Dim Group_80 As Double = 0
    Dim Group_percen80 As Double = 0
    Dim Group_70 As Double = 0
    Dim Group_percen70 As Double = 0
    Dim Group_60 As Double = 0
    Dim Group_percen60 As Double = 0
    Dim Group_50 As Double = 0
    Dim Group_percen50 As Double = 0


 


    Private Sub frm_salary_calculate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call txtworday_month.Focus()
        Lang = False
        load_lang()
        Load_Tax()
        Load_SSO()
        load_overtime()
        'txtcost_living_day.Text = Format(CDbl(Cost_of_living), "##,##0.00")
        FG.FormatString = "^No|<Code|<Description      |>Amount Money  "
        FG2.FormatString = "^No|<Code|<Description     |>Amount Money  "
        FG1_After.FormatString = "^No|<Code|<Description      |>Amount Money  "
        FG2_After.FormatString = "^No|<Code|<Description                  |>Amount Money "

       
        If MDEdit = True Then
            txtUnifrom_male.Text = 0
            txtUnifrom_Female.Text = 0
            txthous_after.Text = 0
            txtother_cut.Text = 0
            txtnet_money.Text = 0
            txttest.Text = 0
            txtnet.Text = 0
            txtnet2.Text = 0
            txtsala.Text = 0
            txtother_T.Text = 0
            txtcurren.Text = 0
            txtmoney_over.Text = 0


            Load_Rate()
            Load_Tax()

            Call Load_Edit()

            dt_month.Enabled = False
            'txtdat_month.Text = Format(CDbl(txtdat_month.Text), "##,##0.00")
            'txtsala.Text = Format(CDbl(txtsalary.Text), "##,##0.00")
            'txtsala.Text = Format(CDbl(txtsalary.Text) * CDbl(txtRate.Text), "##,##0.00")
            'Label45.Text = Label18.Text
            'txtmoney_per_day.Text = Format(CDbl(txtsala.Text) / CDbl(txtdat_month.Text), "##,##0.00")
            Load_Edit_Item()
            Load_Edit_Item2()
            Load_Edit_Item3()
            Load_Edit_Item4()
            Call Sum_Item()

        Else
            'dt_month.Value = Frm_Salary_in_month_List.DT_Month.Value
            'dt_month.Enabled = False

            txtUnifrom_male.Text = 0
            txtUnifrom_Female.Text = 0
            txthous_after.Text = 0
            txtother_cut.Text = 0
            txtmoney_over.Text = 0


            Load_Data()
            'txtdat_month.Text = 22
            Load_Tax()
            Rate_set = Label18.Text
            Label45.Text = Label18.Text
            Load_Rate()
            'txtdat_month.Text = Format(CDbl(txtdat_month.Text), "##,##0.00")
            'txtsala.Text = Format(CDbl(txtsalary.Text), "##,##0.00")
            'txtsala.Text = Format(CDbl(txtsalary.Text) * CDbl(Rate_All), "##,##0.00")
            'txtmoney_per_day.Text = Format(CDbl(txtsala.Text) / CDbl(txtdat_month.Text), "##,##0.00")
            txtRate.Text = Format(CDbl(Rate_All), "##,##0.00")
            addnew()
            ComboBox1.SelectedIndex = 0
            txtworday_month.Focus()
            cmb_over_per.SelectedIndex = 0
            Load_Item1()
            Load_Item2()
            Load_Item3()
            Load_Item4()
            Call Sum_Item()
            chk_tax.Checked = True
            ChkSocial.Checked = True
        End If


    End Sub
    Private Sub load_lang()
        If Lang = True Then
            Label3.Text = "Month :"
            Label2.Text = "Employee ID :"
            Label4.Text = "Employee Name :"
            Label31.Text = "Department :"
            Label1.Text = "Contract Type :"
            Label21.Text = "Salary :"
            Label5.Text = "Day of Month :"
            Label6.Text = "Money Per Day (LAK) :"
            Label7.Text = "Work Day of Month :"
            Label8.Text = "Total Amount (LAK) :"
            ChkSocial.Text = "Social Calculate"
            Label9.Text = "Employee (LAK) :"
            Label10.Text = "Employer (LAK) :"
            Label11.Text = "Overtime (H) :"
            Label12.Text = "Overtime (H) 200% :"
            Label13.Text = "Overtime (H) 250% :"
            Label14.Text = "Overtime (H) 300% :"
            Label15.Text = "Money Overtime :"
            Label16.Text = "Other Benifit :"
            Label20.Text = "Additional  Befor Tax"
            Label36.Text = "Deductions Befor Tax"
            Label22.Text = "Tax Type :"
            Label23.Text = "Total money befor tax (LAK) :"
            'Label24.Text = "Tax money (LAK)  :"
            Label25.Text = "Total money after tax :"
            Label28.Text = "Position :"
            Label40.Text = "Additional  After Tax"
            Label39.Text = "Deductions After Tax"
            Chk_AGL.Text = "AGL Calculate"
            Label29.Text = "AGL insurance out :"
            Label30.Text = "AGL insurance In :"
            Label34.Text = "Total money in LAK :"
            Label44.Text = "Total money currency :"

        Else
            Label3.Text = "ເດືອນ :"
            Label2.Text = "ລະຫັດພະນັກງານ :"
            Label4.Text = "ຊື່ ພະນັກງານ :"
            Label31.Text = "ພະແໜກ :"
            Label28.Text = "ບ່ອນປະຈຳການ :"
            Label1.Text = "ກຸ້ມເງີນເດືອນ :"
            Label21.Text = "ເງີນເດືອນພື້ນຖານ :"
            Label5.Text = "ຈຳນວນຊົວໂມງ/ໃນເດືນ :"
            Label6.Text = "ຈຳນວນເງີນ/ຊົວໂມງ (LAK) :"
            Label7.Text = "ຈຳນວນຊົວໂມງຮັດວຽກຕົວຈີງ :"
            Label8.Text = "ລວມເງີນ (LAK) :"
            ChkSocial.Text = "ເງີນປະກັນສັງຄົມ"
            Label9.Text = "ພະນັກງານ (LAK) :"
            Label10.Text = "ຜູ້ຈ້າງ (LAK) :"
            Label11.Text = "ລ່ວງເວລາ (H) :"
            Label12.Text = "ລ່ວງເວລາ (H) 200% :"
            Label13.Text = "ລ່ວງເວລາ (H) 250% :"
            Label14.Text = "ລ່ວງເວລາ (H) 300% :"
            Label15.Text = "ລວມເງີນ ລ່ວງເວລາ :"
            Label16.Text = "Other Benifit :"
            Label20.Text = "ເງີນເພີມກ່ອນ ຄິດໄລ່ອາກອນ :"
            Label36.Text = "ເງີນຫັກກ່ອນ ຄິດໄລ່ອາກອນ :"
            Label22.Text = "ປະເພດ ອາກອນ :"
            Label23.Text = "ລວມເງີນກ່ອນ ຄິດໄລ່ອາກອນ (LAK) :"
            'Label24.Text = "ເງີນ ອາກອນ (LAK)  :"
            Label25.Text = "ລວມເງີນຫຼັງ ຄິດໄລ່ອາກອນ (LAK) :"

            Label40.Text = "ເງີນເພີມຫຼັງ ຄິດໄລ່ອາກອນ :"
            Label39.Text = "ເງີນຫັກຫຼັງ ຄິດໄລ່ອາກອນ :"
            Chk_AGL.Text = "AGL Calculate"
            Label29.Text = "AGL insurance out :"
            Label30.Text = "AGL insurance In :"
            Label34.Text = "ລວມເງີນຕ້ອງຈ່າຍທັງໝົດ (LAK) :"
            Label44.Text = "ລວມເງີນຕ້ອງຈ່າຍທັງໝົດ :"


        End If

    End Sub

    Private Sub Sum_Item()
        txtTotal_Other.Text = Format(CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        sum()
        sum2()
        txtTotal_Other.Text = Format(CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        sum3()
        If txtSum3.Text > 0 Then
            txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        End If
        'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        sum4()
        If txtSum3.Text > 0 Then
            txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        End If
        'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        If txtTotal_Other.Text > 0 Then
            txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
            Load_sum_tax()
        End If
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")

    End Sub
    Private Sub Load_Item1()
        Dim aa As String
        FG.Rows = 1
        With RSC

            aa = "select Code, Add_Dition_Befor, Money_QTY, chk FROM   List_Add_Befor "
            Call LoadRs(aa, RSC)

            Dim CHK As String
            If .RecordCount > 0 Then
                While Not .EOF
                    If .Fields("chk").Value = 0 Then
                        CHK = 0
                    Else
                        CHK = Format(CDbl(.Fields("Money_QTY").Value), "##,##0")
                    End If
                    FG.AddItem(.AbsolutePosition & _
                                Chr(9) & .Fields("Code").Value & _
                                      Chr(9) & .Fields("Add_Dition_Befor").Value & _
                           Chr(9) & CHK)
                    .MoveNext()
                End While
            Else
                FG.Rows = 2
            End If
        End With
    End Sub
    Private Sub Load_Item2()
        Dim aa As String
        FG2.Rows = 1
        With RSC

            aa = "select Code, Deduc_Befor, Money_QTY, chk FROM   List_Deduc_Befor "
            Call LoadRs(aa, RSC)

            Dim CHK As String
            If .RecordCount > 0 Then
                While Not .EOF
                    If .Fields("chk").Value = 0 Then
                        CHK = 0
                    Else
                        CHK = Format(CDbl(.Fields("Money_QTY").Value), "##,##0")
                    End If
                    FG2.AddItem(.AbsolutePosition & _
                                Chr(9) & .Fields("Code").Value & _
                                      Chr(9) & .Fields("Deduc_Befor").Value & _
                           Chr(9) & CHK)
                    .MoveNext()
                End While
            Else
                FG2.Rows = 2
            End If
        End With
    End Sub
    Private Sub Load_Item3()
        Dim aa As String
        FG1_After.Rows = 1
        With RSC

            aa = "select Code, Add_Dition_AfTer, Money_QTY, chk FROM   List_Add_After "
            Call LoadRs(aa, RSC)

            Dim CHK As String
            If .RecordCount > 0 Then
                While Not .EOF
                    If .Fields("chk").Value = 0 Then
                        CHK = 0
                    Else
                        CHK = Format(CDbl(.Fields("Money_QTY").Value), "##,##0")
                    End If
                    FG1_After.AddItem(.AbsolutePosition & _
                                Chr(9) & .Fields("Code").Value & _
                                      Chr(9) & .Fields("Add_Dition_AfTer").Value & _
                           Chr(9) & CHK)
                    .MoveNext()
                End While
            Else
                FG1_After.Rows = 2
            End If
        End With
    End Sub

    Private Sub Load_Item4()
        Dim aa As String
        FG2_After.Rows = 1
        With RSC

            aa = "select Code, Deduc_After, Money_QTY, chk FROM   List_Deduc_After "
            Call LoadRs(aa, RSC)

            Dim CHK As String
            If .RecordCount > 0 Then
                While Not .EOF
                    If .Fields("chk").Value = 0 Then
                        CHK = 0
                    Else
                        CHK = Format(CDbl(.Fields("Money_QTY").Value), "##,##0")
                    End If
                    FG2_After.AddItem(.AbsolutePosition & _
                                Chr(9) & .Fields("Code").Value & _
                                      Chr(9) & .Fields("Deduc_After").Value & _
                           Chr(9) & CHK)
                    .MoveNext()
                End While
            Else
                FG2_After.Rows = 2
            End If
        End With
    End Sub

    Private Sub Load_Edit_Item()
        Dim aa As String
        FG.Rows = 1
        With RSC

            'aa = "select PersonID, AtMonth, Other_nm, Money_QTY, cnt FROM   AP_Salary_Item  where 1=1 and  month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID =N'" & myE_Id & "' "
            aa = "       SELECT     AP_Salary_Item.PersonID, AP_Salary_Item.Code, AP_Salary_Item.AtMonth, AP_Salary_Item.Other_nm, AP_Salary_Item.Money_QTY, AP_Salary_Item.cnt, " & _
          "  List_Add_Befor.Add_Dition_Befor" & _
                "        FROM         AP_Salary_Item INNER JOIN" & _
                   "   List_Add_Befor ON AP_Salary_Item.Code = List_Add_Befor.Code  where 1=1 and  month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID =N'" & E_ID & "' "
            Call LoadRs(aa, RSC)

            'Dim f As String
            If .RecordCount > 0 Then
                While Not .EOF

                    FG.AddItem(.AbsolutePosition & _
                                   Chr(9) & .Fields("Code").Value & _
                                      Chr(9) & .Fields("Add_Dition_Befor").Value & _
                                            Chr(9) & Format(CDbl(.Fields("Money_QTY").Value), "##,##0"))
                    .MoveNext()
                End While
            Else
                FG.Rows = 2
            End If
        End With
    End Sub
    Private Sub Load_Edit_Item2()
        Dim aa As String
        FG2.Rows = 1
        With RSC

            aa = "SELECT     AP_Salary_Item2.PersonID, AP_Salary_Item2.Code, AP_Salary_Item2.AtMonth, AP_Salary_Item2.Other_nm, AP_Salary_Item2.Money_QTY, AP_Salary_Item2.cnt,  " & _
         "   List_Deduc_Befor.Deduc_Befor " & _
             "         FROM         AP_Salary_Item2 INNER JOIN " & _
                   "   List_Deduc_Befor ON AP_Salary_Item2.Code = List_Deduc_Befor.Code  where 1=1 and  month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID =N'" & E_ID & "' "
            Call LoadRs(aa, RSC)

            'Dim f As String
            If .RecordCount > 0 Then
                While Not .EOF

                    FG2.AddItem(.AbsolutePosition & _
                                  Chr(9) & .Fields("Code").Value & _
                                      Chr(9) & .Fields("Deduc_Befor").Value & _
                                            Chr(9) & Format(CDbl(.Fields("Money_QTY").Value), "##,##0"))
                    .MoveNext()
                End While
            Else
                FG2.Rows = 2
            End If
        End With
    End Sub
    Private Sub Load_Edit_Item3()
        Dim aa As String
        FG1_After.Rows = 1
        With RSC

            aa = "SELECT     AP_Salary_Item3.PersonID, AP_Salary_Item3.Code, AP_Salary_Item3.AtMonth, AP_Salary_Item3.Other_nm_Add_After, AP_Salary_Item3.Money_QTY_Add_After, " & _
        "    AP_Salary_Item3.cnt, List_Add_After.Add_Dition_AfTer" & _
            " FROM         AP_Salary_Item3 INNER JOIN" & _
                 "     List_Add_After ON AP_Salary_Item3.Code = List_Add_After.Code  where 1=1 and  month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID =N'" & E_ID & "' "
            Call LoadRs(aa, RSC)

            'Dim f As String
            If .RecordCount > 0 Then
                While Not .EOF

                    FG1_After.AddItem(.AbsolutePosition & _
                                        Chr(9) & .Fields("Code").Value & _
                                      Chr(9) & .Fields("Add_Dition_AfTer").Value & _
                                            Chr(9) & Format(CDbl(.Fields("Money_QTY_Add_After").Value), "##,##0"))
                    .MoveNext()
                End While
            Else
                FG1_After.Rows = 2
            End If
        End With
    End Sub
    Private Sub Load_Edit_Item4()
        Dim aa As String
        FG2_After.Rows = 1
        With RSC

            aa = "SELECT     AP_Salary_Item4.PersonID, AP_Salary_Item4.Code, AP_Salary_Item4.AtMonth, AP_Salary_Item4.Other_nm_Deduc_After, AP_Salary_Item4.Money_QTY_Deduc_After, " & _
        "    AP_Salary_Item4.cnt, List_Deduc_After.Deduc_After " & _
              "FROM         AP_Salary_Item4 INNER JOIN " & _
                    "  List_Deduc_After ON AP_Salary_Item4.Code = List_Deduc_After.Code  where 1=1 and  month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID =N'" & E_ID & "' "
            Call LoadRs(aa, RSC)

            'Dim f As String
            If .RecordCount > 0 Then
                While Not .EOF

                    FG2_After.AddItem(.AbsolutePosition & _
                                           Chr(9) & .Fields("Code").Value & _
                                      Chr(9) & .Fields("Deduc_After").Value & _
                                            Chr(9) & Format(CDbl(.Fields("Money_QTY_Deduc_After").Value), "##,##0"))
                    .MoveNext()
                End While
            Else
                FG2_After.Rows = 2
            End If
        End With
    End Sub
    Private Sub Load_Edit()
        'Dim M, T As String
        Dim aa As String
        Dim rs As New ADODB.Recordset

        ' aa = " select PersonID, AtMonth,Title_ID, Empoyee_Nm,Department_ID, Position_id,Department, Contract_Type,cost_living_total, Salary, SalaryCurrency, Rate, RateDate, DayOfMonth, MPerDayCurrent, WDayOfMonth, total_amount, " & _
        '           "  Chk_Social, Employee_LAK, Employer_LAK, HOvertime150, HOvertime200, HOvertime250, HOvertime300, MOvertimeTotal, Bonus, tax_type, Money_Befor, " & _
        '        "     Tax_Level1,Tax_Level2,Tax_Level3,Tax_Level4,Tax_Level5,Tax_Level6,Tax_Level7,tax_money," & _
        '"Money_After, Housing_After, Money_Cut, Net_Money, Chk_AGL, AGL_out, AGL_in, Unifron_Male, Unifron_FeMale, Total_Money_curr, Lst_Updt, Lst_Usr, " & _
        '         "    pc_nm,Sum_Addtional,Sum_Deducation, Total_Other,Total_Other_After,Sum_Addtional_After,Sum_Deducation_After,Total_Money_curr_Exing FROM  " & _
        '    "  AP_Salary  where 1=1 and  month(AtMonth) ='" & Month(Frm_Salary_in_month_List.DT_Month.Value) & "' and year(AtMonth) ='" & Year(Frm_Salary_in_month_List.DT_Month.Value) & "' and PersonID =N'" & E_ID & "' "

        aa = "SELECT      AP_Salary_in_Month.*, AP_CV.Name_E,AP_CV.Bank_no,AP_CV.SSO_no, " & _
              "   AP_CV.Phone,AP_CV.txtV_C, AP_Sections.Sec_nmL, AP_Sections.Sec_id,   " & _
         "   Department.DP_ID, Department.DP_Name ,Salary_group.Group_SLR_nm , Type_In.In_ID, Type_In.In_nm , AP_Salary_in_Month.txtcontract_type_id ,Salary_group.Group_100 " & _
           "   FROM         AP_Salary_in_Month INNER JOIN  " & _
            "     AP_CV ON AP_Salary_in_Month.PersonID = AP_CV.E_ID INNER JOIN " & _
           "     AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id INNER JOIN " & _
           "      Department ON AP_CV.Department_id = Department.DP_ID INNER JOIN " & _
             "  Salary_group ON AP_Salary_in_Month.txtcontract_type_id = Salary_group.Group_SLR_id  INNER JOIN " & _
           "      Type_In ON AP_CV.type_in_id = Type_In.In_ID  " & _
         "    where 1=1 and  month(AP_Salary_in_Month.AtMonth) ='" & Month(Frm_Salary_in_month_List.DT_Month.Value) & "' and year(AP_Salary_in_Month.AtMonth) ='" & Year(Frm_Salary_in_month_List.DT_Month.Value) & "' and AP_Salary_in_Month.PersonID =N'" & E_ID & "' "

        Call LoadRs(aa, rs)
        With rs
            If rs.RecordCount <> 0 Then
                'txtTitle_Id.Text = .Fields("Title_ID").Value.ToString
                Tax_LAK1 = Format(CDbl(.Fields("Tax_Level1").Value), "##,##0")
                Tax1_Sum = Format(CDbl(.Fields("Tax_Level2").Value), "##,##0")
                Tax2_Sum = Format(CDbl(.Fields("Tax_Level3").Value), "##,##0")
                Tax3_Sum = Format(CDbl(.Fields("Tax_Level4").Value), "##,##0")
                Tax4_Sum = Format(CDbl(.Fields("Tax_Level5").Value), "##,##0")
                Tax5_Sum = Format(CDbl(.Fields("Tax_Level6").Value), "##,##0")
                Tax6_Sum = Format(CDbl(.Fields("Tax_Level7").Value), "##,##0")
                txtdat_month.Text = .Fields("Group_100").Value.ToString



                Label18.Text = .Fields("SalaryCurrency").Value.ToString
                Label35.Text = .Fields("SalaryCurrency").Value.ToString
                txtid.Text = .Fields("PersonID").Value
                dt_month.Value = .Fields("AtMonth").Value
                txt_Nane.Text = .Fields("Name_L").Value.ToString
                txtPosition_id.Text = .Fields("Sec_id").Value.ToString
                txtPosition.Text = .Fields("Sec_nmL").Value.ToString
                txtdepartment_id.Text = .Fields("DP_ID").Value.ToString
                txtdepartment.Text = .Fields("DP_Name").Value.ToString
                txtcontract_type_id.Text = .Fields("txtcontract_type_id").Value.ToString
                txtcontract_type.Text = .Fields("Group_SLR_nm").Value.ToString

                txtsalary.Text = Format(CDbl(.Fields("Salary").Value), "##,##0")
                txtdat_month.Text = Format(CDbl(.Fields("DayOfMonth").Value), "##,##0")
                txtpercen.Text = .Fields("percen").Value.ToString
                txtTum_money.Text = Format(CDbl(.Fields("txtTum_money").Value), "##,##0")

                txtmoney_per_day.Text = Format(CDbl(.Fields("MPerDayCurrent").Value), "##,##0.00")
                'txtmoney_per_day.Text = Format(CDbl(txtsala.Text) / CDbl(txtdat_month.Text), "##,##0.00")
                txtworday_month.Text = Format(CDbl(.Fields("WDayOfMonth").Value), "##,##0")
                'txtcost_living_total.Text = Format(CDbl(txtcost_living_day.Text) * CDbl(txtworday_month.Text), "##,##0")
                txttotal_amount.Text = Format(CDbl(.Fields("total_amount").Value), "##,##0")
                txtEmployLAK.Text = Format(CDbl(.Fields("Employee_LAK").Value), "##,##0")
                txtEmployerLAK.Text = Format(CDbl(.Fields("Employer_LAK").Value), "##,##0")
                txtovertime150.Text = Format(CDbl(.Fields("HOvertime150").Value), "##,##0")
                txtovertime200.Text = Format(CDbl(.Fields("HOvertime200").Value), "##,##0")
                txtovertime250.Text = Format(CDbl(.Fields("HOvertime250").Value), "##,##0")
                txtovertime300.Text = Format(CDbl(.Fields("HOvertime300").Value), "##,##0")
                txtmoney_over.Text = Format(CDbl(.Fields("MOvertimeTotal").Value), "##,##0")
                txtother_money.Text = Format(CDbl(.Fields("Bonus").Value), "##,##0")
                txtcost_living_total.Text = Format(CDbl(.Fields("cost_living_total").Value), "##,##0")
                txtTax.Text = .Fields("tax_type").Value.ToString
         
                txttotal_Befor.Text = Format(CDbl(.Fields("Money_Befor").Value), "##,##0")
                txtTax_money.Text = Format(CDbl(.Fields("tax_money").Value), "##,##0")
                txttotal_after.Text = Format(CDbl(.Fields("Money_After").Value), "##,##0")
                txthous_after.Text = Format(CDbl(.Fields("Housing_After").Value), "##,##0")
                txtother_cut.Text = Format(CDbl(.Fields("Money_Cut").Value), "##,##0")
                txtnet_money.Text = Format(CDbl(.Fields("Net_Money").Value), "##,##0")
                txtAGL_ount.Text = Format(CDbl(.Fields("AGL_Out").Value), "##,##0")
                txtAGL_in.Text = Format(CDbl(.Fields("AGL_In").Value), "##,##0")
                txtUnifrom_male.Text = Format(CDbl(.Fields("Unifron_Male").Value), "##,##0")
                txtUnifrom_Female.Text = Format(CDbl(.Fields("Unifron_FeMale").Value), "##,##0")
                txtTotal_money_Curren.Text = Format(CDbl(.Fields("Total_Money_curr").Value), "##,##0")
                txtTotal_Other.Text = Format(CDbl(.Fields("Total_Other").Value), "##,##0")
                txtother_T.Text = Format(CDbl(.Fields("Total_Other").Value), "##,##0")
                txttest.Text = Format(CDbl(.Fields("total_amount").Value), "##,##0")
                txtSum1.Text = Format(CDbl(.Fields("Sum_Addtional").Value), "##,##0")
                txtSum2.Text = Format(CDbl(.Fields("Sum_Deducation").Value), "##,##0")
                txtTotal_Other2.Text = Format(CDbl(.Fields("Total_Other_After").Value), "##,##0")
                txtSum3.Text = Format(CDbl(.Fields("Sum_Addtional_After").Value), "##,##0")
                txtSum4.Text = Format(CDbl(.Fields("Sum_Deducation_After").Value), "##,##0")
                txtRate.Text = Format(CDbl(.Fields("Rate").Value), "##,##0")



                If .Fields("tax_money").Value > 0 Then
                    chk_tax.Checked = True
                End If
                txtTotal_money_Curren_Exiting.Text = Format(CDbl(.Fields("Total_Money_curr_Exing").Value), "##,##0")

                If .Fields("Chk_Social").Value = 1 Then
                    ChkSocial.Checked = True
                End If

                If .Fields("Chk_AGL").Value = 1 Then
                    Chk_AGL.Checked = True
                End If

                If .Fields("txtpeple").Value.ToString = "0" Then
                    ChkSocial.Checked = False
                ElseIf .Fields("txtpeple").Value.ToString = "1" Then
                    ChkSocial.Checked = True
                    ComboBox1.SelectedIndex = 0

                Else
                    ChkSocial.Checked = True
                    ComboBox1.SelectedIndex = 1
                    'ComboBox1.Text = "ຄົນຕ່າງປະເທດ"
                End If

                txtpeple.Text = .Fields("txtpeple").Value.ToString
            End If


        End With
    End Sub
    Private Sub addnew()
        FG.Rows = 2
        FG.Rows = 1
        FG.Rows = 2
        Tax1_Sum = 0
        Tax2_Sum = 0
        Tax3_Sum = 0
        Tax4_Sum = 0
        Tax5_Sum = 0
        Tax6_Sum = 0
        Tax7_Sum = 0
        txttotal_amount.Text = 0
        txtEmployLAK.Text = 0
        txtEmployerLAK.Text = 0
        txtovertime150.Text = 0
        txtovertime200.Text = 0
        txtovertime250.Text = 0
        txtovertime300.Text = 0
        txtmoney_over.Text = 0
        txtother_money.Text = 0
        'txtTax.Text = ""
        txttotal_Befor.Text = 0
        txtTax_money.Text = 0
        txttotal_after.Text = 0
        txthous_after.Text = 0
        txtother_cut.Text = 0
        txtnet_money.Text = 0
        txtAGL_ount.Text = 0
        txtAGL_in.Text = 0
        txtUnifrom_male.Text = 0
        txtUnifrom_Female.Text = 0
        txtTotal_money_Curren.Text = 0

        txttest.Text = 0
        txtnet.Text = 0
        txtnet2.Text = 0
        txtsala.Text = 0
        txtother_T.Text = 0
        txtcurren.Text = 0
    End Sub
    Private Sub Load_Data()
        'Dim M, T As String
        Dim aa As String
        Dim rs As New ADODB.Recordset
        aa = "SELECT      AP_Salary.*, AP_CV.Name_E,AP_CV.Bank_no,AP_CV.SSO_no, " & _
     "   AP_CV.Phone,AP_CV.txtV_C, AP_Sections.Sec_nmL, AP_Sections.Sec_id,   " & _
     "   Department.DP_ID, Department.DP_Name ,Salary_group.Group_SLR_nm , Type_In.In_ID, Type_In.In_nm , Salary_group.Group_100 , Salary_group.Group_SLR_id " & _
          "   FROM         AP_Salary INNER JOIN  " & _
             "     AP_CV ON AP_Salary.E_ID = AP_CV.E_ID INNER JOIN " & _
             "     AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id INNER JOIN " & _
            "      Department ON AP_CV.Department_id = Department.DP_ID INNER JOIN " & _
                "  Salary_group ON AP_Salary.txtgroup_id = Salary_group.Group_SLR_id  INNER JOIN " & _
                 "      Type_In ON AP_CV.type_in_id = Type_In.In_ID   WHERE    AP_Salary.E_ID=N'" & E_ID & "'  "
        Call LoadRs(aa, rs)
        With rs
            If rs.RecordCount <> 0 Then
                txtdat_month.Text = .Fields("Group_100").Value.ToString
                txtmoney_per_day.Text = Format(CDbl(.Fields("txt_hours_money").Value), "##,##0.00")
                txtworday_month.Text = Format(CDbl(.Fields("Group_100").Value), "##,##0")
                txtpercen.Text = .Fields("percen").Value.ToString
                txtdepartment_id.Text = .Fields("DP_ID").Value.ToString
                Label18.Text = .Fields("cmbKip").Value.ToString
                Label35.Text = .Fields("cmbKip").Value.ToString
                txtid.Text = .Fields("E_ID").Value
                txt_Nane.Text = .Fields("Name_L").Value.ToString
                txtdepartment.Text = .Fields("DP_Name").Value.ToString
                txtcontract_type_id.Text = .Fields("Group_SLR_id").Value.ToString
                txtcontract_type.Text = .Fields("Group_SLR_nm").Value.ToString
                txtPosition.Text = .Fields("Sec_nmL").Value.ToString
                'txtPosition_id.Text = .Fields("Position_ID").Value.ToString
                txtsalary.Text = Format(CDbl(.Fields("txtsalary").Value), "##,##0")
                txtTum_money.Text = Format(CDbl(.Fields("txtTum_money").Value), "##,##0")

                'txtTitle_Id.Text = .Fields("Title_ID1").Value.ToString
                'Dim s As String
                '    If .Fields("tax").Value = 1 Then
                '        s = "Lao Tax"
                '    Else
                '        s = "Foreigner Tax"
                '    End If
                '    txtTax.Text = s
                txtTax.Text = "Lao Tax"
            End If


        End With
    End Sub
    Private Sub sum()
        Dim s, w, eth, sw As String
        s = 0
        w = 0
        eth = 0
        sw = 0
        For i = 1 To FG.Rows - 1

            If IsNumeric(FG.get_TextMatrix(i, 3)) = False Or FG.get_TextMatrix(i, 3) = "" Then
                FG.set_TextMatrix(i, 3, Format(CDbl(0), "##,##0"))
            End If
            'If IsNumeric(FG.get_TextMatrix(i, 5)) = False Or FG.get_TextMatrix(i, 5) = "" Then
            '    FG.set_TextMatrix(i, 5, Format(CDbl(0), "##,##0.00"))
            'End If
            'If IsNumeric(FG.get_TextMatrix(i, 6)) = False Or FG.get_TextMatrix(i, 6) = "" Then
            '    FG.set_TextMatrix(i, 6, Format(CDbl(0), "##,##0.00"))
            'End If
            's = s + CDbl(FG.get_TextMatrix(i, 3))
            w = w + CDbl(FG.get_TextMatrix(i, Format(CDbl(3), "##,##0")))
            'eth = eth + CDbl(FG.get_TextMatrix(i, 5))
            'sw = sw + CDbl(FG.get_TextMatrix(i, 6))
        Next

        txtSum1.Text = Format(CDbl(w), "##,##0")
        txtTotal_Other.Text = Format(CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        'txtTotalNon_repayable_Grant.Text = Format(CDbl(eth), "##,##0.00")
        'txtTotalRepayment.Text = Format(CDbl(sw), "##,##0.00")

    End Sub
    Private Sub sum2()
        Dim s, w, eth, sw As String
        s = 0
        w = 0
        eth = 0
        sw = 0
        For i = 1 To FG2.Rows - 1

            If IsNumeric(FG2.get_TextMatrix(i, 3)) = False Or FG.get_TextMatrix(i, 3) = "" Then
                FG2.set_TextMatrix(i, 3, Format(CDbl(0), "##,##0"))
            End If
            'If IsNumeric(FG.get_TextMatrix(i, 5)) = False Or FG.get_TextMatrix(i, 5) = "" Then
            '    FG.set_TextMatrix(i, 5, Format(CDbl(0), "##,##0.00"))
            'End If
            'If IsNumeric(FG.get_TextMatrix(i, 6)) = False Or FG.get_TextMatrix(i, 6) = "" Then
            '    FG.set_TextMatrix(i, 6, Format(CDbl(0), "##,##0.00"))
            'End If
            's = s + CDbl(FG.get_TextMatrix(i, 3))
            w = w + CDbl(FG2.get_TextMatrix(i, Format(CDbl(3), "##,##0")))
            'eth = eth + CDbl(FG.get_TextMatrix(i, 5))
            'sw = sw + CDbl(FG.get_TextMatrix(i, 6))
        Next

        txtSum2.Text = Format(CDbl(w), "##,##0")
        txtTotal_Other.Text = Format(CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        'txtTotalNon_repayable_Grant.Text = Format(CDbl(eth), "##,##0.00")
        'txtTotalRepayment.Text = Format(CDbl(sw), "##,##0.00")

    End Sub
    Private Sub sum3()
        Dim s, w, eth, sw As String
        s = 0
        w = 0
        eth = 0
        sw = 0
        For i = 1 To FG1_After.Rows - 1

            If IsNumeric(FG1_After.get_TextMatrix(i, 3)) = False Or FG1_After.get_TextMatrix(i, 3) = "" Then
                FG1_After.set_TextMatrix(i, 2, Format(CDbl(0), "##,##0"))
            End If
            'If IsNumeric(FG.get_TextMatrix(i, 5)) = False Or FG.get_TextMatrix(i, 5) = "" Then
            '    FG.set_TextMatrix(i, 5, Format(CDbl(0), "##,##0.00"))
            'End If
            'If IsNumeric(FG.get_TextMatrix(i, 6)) = False Or FG.get_TextMatrix(i, 6) = "" Then
            '    FG.set_TextMatrix(i, 6, Format(CDbl(0), "##,##0.00"))
            'End If
            's = s + CDbl(FG.get_TextMatrix(i, 3))
            w = w + CDbl(FG1_After.get_TextMatrix(i, Format(CDbl(3), "##,##0")))
            'eth = eth + CDbl(FG.get_TextMatrix(i, 5))
            'sw = sw + CDbl(FG.get_TextMatrix(i, 6))
        Next

        txtSum3.Text = Format(CDbl(w), "##,##0")
        If txtSum3.Text > 0 Then
            txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        End If
        'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        'txtTotalNon_repayable_Grant.Text = Format(CDbl(eth), "##,##0.00")
        'txtTotalRepayment.Text = Format(CDbl(sw), "##,##0.00")

    End Sub
    Private Sub sum4()
        Dim s, w, eth, sw As String
        s = 0
        w = 0
        eth = 0
        sw = 0
        For i = 1 To FG2_After.Rows - 1

            If IsNumeric(FG2_After.get_TextMatrix(i, 3)) = False Or FG2_After.get_TextMatrix(i, 3) = "" Then
                FG2_After.set_TextMatrix(i, 3, Format(CDbl(0), "##,##0.00"))
            End If
            'If IsNumeric(FG.get_TextMatrix(i, 5)) = False Or FG.get_TextMatrix(i, 5) = "" Then
            '    FG.set_TextMatrix(i, 5, Format(CDbl(0), "##,##0.00"))
            'End If
            'If IsNumeric(FG.get_TextMatrix(i, 6)) = False Or FG.get_TextMatrix(i, 6) = "" Then
            '    FG.set_TextMatrix(i, 6, Format(CDbl(0), "##,##0.00"))
            'End If
            's = s + CDbl(FG.get_TextMatrix(i, 3))
            w = w + CDbl(FG2_After.get_TextMatrix(i, Format(CDbl(3), "##,##0.00")))
            'eth = eth + CDbl(FG.get_TextMatrix(i, 5))
            'sw = sw + CDbl(FG.get_TextMatrix(i, 6))
        Next

        txtSum4.Text = Format(CDbl(w), "##,##0")
        If txtSum3.Text > 0 Then
            txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        End If
        'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        'txtTotalNon_repayable_Grant.Text = Format(CDbl(eth), "##,##0.00")
        'txtTotalRepayment.Text = Format(CDbl(sw), "##,##0.00")

    End Sub
    Private Sub FG_AfterEdit(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_AfterEditEvent) Handles FG.AfterEdit
        FG.set_TextMatrix(FG.Row, 3, Format(CDbl(FG.get_TextMatrix(FG.Row, 3)), "#,##0"))
        txtTotal_Other.Text = Format(CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        sum()
        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        If txtTotal_Other.Text > 0 Then
            txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
            Load_sum_tax()
        End If
        Load_sum_tax()
        If chk_tax.Checked = True Then
            Load_sum_tax()
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
        Else
            txtTax_money.Text = 0
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
        End If
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
    End Sub
    Private Sub Load_sum_tax()
        'txttotal_amount.Text = Format(CDbl(txtworday_month.Text) * CDbl(txtmoney_per_day.Text), "##,##0.00")
        'txttotal_Befor.Text = Format(CDbl(txtworday_month.Text) * CDbl(txtmoney_per_day.Text), "##,##0.00")
        'txttotal_Befor.Text = Format(CDbl(txttotal_Befor.Text) + CDbl(txtcost_living_total.Text), "##,##0")
        txttotal_Befor1.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
        If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK1) Or Format(CDbl(txttotal_Befor1.Text), "##,##0.00") <= CDbl(Tax_LAK2) Then
            If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK2) Then
                Tax1_cut = CDbl(Tax_LAK2) - CDbl(Tax_LAK1)
                Tax1_Sum = CDbl(Tax1_cut) * CDbl(Tax2) / 100
                Tax2_Sum = 0
                Tax3_Sum = 0
                Tax4_Sum = 0
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
            Else
                Tax1_cut = Format(CDbl(txttotal_Befor1.Text), "##,##0.00") - CDbl(Tax_LAK1)
                Tax1_Sum = CDbl(Tax1_cut) * CDbl(Tax2) / 100
                'txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                Tax2_Sum = 0
                Tax3_Sum = 0
                Tax4_Sum = 0
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
            End If
        End If

        If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK2) And Format(CDbl(txttotal_Befor1.Text), "##,##0.00") <= CDbl(Tax_LAK3) Then
            'If Format(CDbl(txttotal_Befor.Text), "##,##0.00") > CDbl(Tax_LAK3) Then
            Tax2_cut = Format(CDbl(txttotal_Befor1.Text), "##,##0.00") - CDbl(Tax_LAK2)
            'Tax2_cut = CDbl(Tax_LAK3) - CDbl(Tax_LAK2)
            Tax2_Sum = CDbl(Tax2_cut) * CDbl(Tax3) / 100
            Tax3_Sum = 0
            Tax4_Sum = 0
            Tax5_Sum = 0
            Tax6_Sum = 0
            Tax7_Sum = 0
        ElseIf Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK3) Then
            Tax2_cut = CDbl(Tax_LAK3) - CDbl(Tax_LAK2)
            'Tax2_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK2)
            Tax2_Sum = CDbl(Tax2_cut) * CDbl(Tax3) / 100
            'txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0.00")
            Tax3_Sum = 0
            Tax4_Sum = 0
            Tax5_Sum = 0
            Tax6_Sum = 0
            Tax7_Sum = 0
            'End If
        End If

        If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK3) And Format(CDbl(txttotal_Befor1.Text), "##,##0.00") <= CDbl(Tax_LAK4) Then
            Tax3_cut = Format(CDbl(txttotal_Befor1.Text), "##,##0.00") - CDbl(Tax_LAK3)

            Tax3_Sum = CDbl(Tax3_cut) * CDbl(Tax4) / 100
            Tax4_Sum = 0
            Tax5_Sum = 0
            Tax6_Sum = 0
            Tax7_Sum = 0
        ElseIf Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK4) Then
            Tax3_cut = CDbl(Tax_LAK4) - CDbl(Tax_LAK3)
            'Tax3_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK3)
            Tax3_Sum = CDbl(Tax3_cut) * CDbl(Tax4) / 100
            'txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0.00")
            Tax4_Sum = 0
            Tax5_Sum = 0
            Tax6_Sum = 0
            Tax7_Sum = 0
            'End If
        End If

        If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK4) And Format(CDbl(txttotal_Befor1.Text), "##,##0.00") <= CDbl(Tax_LAK5) Then
            Tax4_cut = Format(CDbl(txttotal_Befor1.Text), "##,##0.00") - CDbl(Tax_LAK4)

            Tax4_Sum = CDbl(Tax4_cut) * CDbl(Tax5) / 100
            Tax5_Sum = 0
            Tax6_Sum = 0
            Tax7_Sum = 0
        ElseIf Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK5) Then
            'Tax4_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK4)
            Tax4_cut = CDbl(Tax_LAK5) - CDbl(Tax_LAK4)
            Tax4_Sum = CDbl(Tax4_cut) * CDbl(Tax5) / 100
            'txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0.00")
            Tax5_Sum = 0
            Tax6_Sum = 0
            Tax7_Sum = 0

        End If

        If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK5) And Format(CDbl(txttotal_Befor1.Text), "##,##0.00") <= CDbl(Tax_LAK6) Then
            Tax5_cut = Format(CDbl(txttotal_Befor1.Text), "##,##0.00") - CDbl(Tax_LAK5)
            Tax5_Sum = CDbl(Tax5_cut) * CDbl(Tax6) / 100
            Tax6_Sum = 0
            Tax7_Sum = 0
        ElseIf Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK6) Then
            'Tax5_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK5)
            Tax5_cut = CDbl(Tax_LAK6) - CDbl(Tax_LAK5)
            Tax5_Sum = CDbl(Tax5_cut) * CDbl(Tax6) / 100
            'txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0.00")
            Tax6_Sum = 0
            Tax7_Sum = 0

        End If

        If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK6) Then

            Tax6_cut = Format(CDbl(txttotal_Befor1.Text), "##,##0.00") - CDbl(Tax_LAK6)
            Tax6_Sum = CDbl(Tax6_cut) * CDbl(Tax7) / 100
            'txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0.00")
        End If
        If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") < CDbl(Tax_LAK1) Then
            Tax1_Sum = 0
            Tax2_Sum = 0
            Tax3_Sum = 0
            Tax4_Sum = 0
            Tax5_Sum = 0
            Tax6_Sum = 0
            Tax7_Sum = 0

        End If

        'If Format(CDbl(txttotal_Befor.Text), "##,##0") > CDbl(Tax_LAK1) Or Format(CDbl(txttotal_Befor.Text), "##,##0") = CDbl(Tax_LAK2) Then
        '    If Format(CDbl(txttotal_Befor.Text), "##,##0.00") > CDbl(Tax_LAK2) Then
        '        Tax1_cut = CDbl(Tax_LAK2) - CDbl(Tax_LAK1)
        '        Tax1_Sum = CDbl(Tax1_cut) * CDbl(Tax2) / 100
        '        Tax2_Sum = 0
        '        Tax3_Sum = 0
        '        Tax4_Sum = 0
        '        Tax5_Sum = 0
        '        Tax6_Sum = 0
        '        Tax7_Sum = 0
        '    Else
        '        Tax1_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK1)
        '        Tax1_Sum = CDbl(Tax1_cut) * CDbl(Tax2) / 100
        '        'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
        '        Tax2_Sum = 0
        '        Tax3_Sum = 0
        '        Tax4_Sum = 0
        '        Tax5_Sum = 0
        '        Tax6_Sum = 0
        '        Tax7_Sum = 0
        '    End If
        'End If

        'If Format(CDbl(txttotal_Befor.Text), "##,##0") > CDbl(Tax_LAK2) Or Format(CDbl(txttotal_Befor.Text), "##,##0") = CDbl(Tax_LAK3) Then
        '    If Format(CDbl(txttotal_Befor.Text), "##,##0") > CDbl(Tax_LAK3) Then
        '        Tax2_cut = CDbl(Tax_LAK3) - CDbl(Tax_LAK2)
        '        Tax2_Sum = CDbl(Tax2_cut) * CDbl(Tax3) / 100
        '        Tax3_Sum = 0
        '        Tax4_Sum = 0
        '        Tax5_Sum = 0
        '        Tax6_Sum = 0
        '        Tax7_Sum = 0
        '    Else
        '        Tax2_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK2)
        '        Tax2_Sum = CDbl(Tax2_cut) * CDbl(Tax3) / 100
        '        'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
        '        Tax3_Sum = 0
        '        Tax4_Sum = 0
        '        Tax5_Sum = 0
        '        Tax6_Sum = 0
        '        Tax7_Sum = 0
        '    End If
        'End If

        'If Format(CDbl(txttotal_Befor.Text), "##,##0") > CDbl(Tax_LAK3) Or Format(CDbl(txttotal_Befor.Text), "##,##0") = CDbl(Tax_LAK4) Then
        '    If Format(CDbl(txttotal_Befor.Text), "##,##0.00") > CDbl(Tax_LAK3) Then
        '        Tax3_cut = CDbl(Tax_LAK4) - CDbl(Tax_LAK3)
        '        Tax3_Sum = CDbl(Tax3_cut) * CDbl(Tax4) / 100
        '        Tax4_Sum = 0
        '        Tax5_Sum = 0
        '        Tax6_Sum = 0
        '        Tax7_Sum = 0
        '    Else
        '        Tax3_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK3)
        '        Tax3_Sum = CDbl(Tax3_cut) * CDbl(Tax4) / 100
        '        'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
        '        Tax4_Sum = 0
        '        Tax5_Sum = 0
        '        Tax6_Sum = 0
        '        Tax7_Sum = 0
        '    End If
        'End If

        'If Format(CDbl(txttotal_Befor.Text), "##,##0.00") > CDbl(Tax_LAK4) And Format(CDbl(txttotal_Befor.Text), "##,##0.00") <= CDbl(Tax_LAK5) Then
        '    Tax4_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK4)

        '    Tax4_Sum = CDbl(Tax4_cut) * CDbl(Tax5) / 100
        '    Tax5_Sum = 0
        '    Tax6_Sum = 0
        '    Tax7_Sum = 0
        'ElseIf Format(CDbl(txttotal_Befor.Text), "##,##0.00") > CDbl(Tax_LAK5) Then
        '    'Tax4_cut = Format(CDbl(txttotal_amount.Text), "##,##0.00") - CDbl(Tax_LAK4)
        '    Tax4_cut = CDbl(Tax_LAK5) - CDbl(Tax_LAK4)
        '    Tax4_Sum = CDbl(Tax4_cut) * CDbl(Tax5) / 100
        '    'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
        '    Tax5_Sum = 0
        '    Tax6_Sum = 0
        '    Tax7_Sum = 0

        'End If




        'If Format(CDbl(txttotal_Befor.Text), "##,##0.00") > CDbl(Tax_LAK5) And Format(CDbl(txttotal_Befor.Text), "##,##0.00") <= CDbl(Tax_LAK6) Then
        '    Tax5_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK5)
        '    Tax5_Sum = CDbl(Tax5_cut) * CDbl(Tax6) / 100
        '    Tax6_Sum = 0
        '    Tax7_Sum = 0
        'ElseIf Format(CDbl(txttotal_Befor.Text), "##,##0.00") > CDbl(Tax_LAK6) Then

        '    Tax5_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK5)
        '    Tax5_cut = CDbl(Tax_LAK6) - CDbl(Tax_LAK5)
        '    Tax5_Sum = CDbl(Tax5_cut) * CDbl(Tax6) / 100
        '    'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
        '    Tax6_Sum = 0
        '    Tax7_Sum = 0

        'End If

        'If Format(CDbl(txttotal_Befor.Text), "##,##0.00") > CDbl(Tax_LAK6) Then

        '    Tax6_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK6)
        '    Tax6_Sum = CDbl(Tax6_cut) * CDbl(Tax7) / 100
        '    'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
        'End If
        'If Format(CDbl(txttotal_Befor.Text), "##,##0.00") < CDbl(Tax_LAK1) Then
        '    Tax1_Sum = 0
        '    Tax2_Sum = 0
        '    Tax3_Sum = 0
        '    Tax4_Sum = 0
        '    Tax5_Sum = 0
        '    Tax6_Sum = 0
        '    Tax7_Sum = 0

        'End If

        'If Format(CDbl(txttotal_Befor.Text), "##,##0.00") > CDbl(Tax_LAK5) Or Format(CDbl(txttotal_Befor.Text), "##,##0.00") = CDbl(Tax_LAK6) Then
        '    If Format(CDbl(txttotal_Befor.Text), "##,##0.00") > CDbl(Tax_LAK5) Then
        '        Tax5_cut = CDbl(Tax_LAK6) - CDbl(Tax_LAK5)
        '        Tax5_Sum = CDbl(Tax5_cut) * CDbl(Tax6) / 100
        '        Tax6_Sum = 0
        '        Tax7_Sum = 0
        '    Else
        '        Tax5_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK5)
        '        Tax5_Sum = CDbl(Tax5_cut) * CDbl(Tax6) / 100
        '        'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
        '        Tax6_Sum = 0
        '        Tax7_Sum = 0
        '    End If
        'End If
        'If Format(CDbl(txttotal_Befor.Text), "##,##0.00") > CDbl(Tax_LAK6) Then

        '    Tax6_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK6)
        '    Tax6_Sum = CDbl(Tax6_cut) * CDbl(Tax7) / 100
        '    'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
        'End If




        txtTax_money.Text = CDbl(Tax1_Sum) + CDbl(Tax2_Sum) + CDbl(Tax3_Sum) + CDbl(Tax4_Sum) + CDbl(Tax5_Sum) + CDbl(Tax6_Sum) + CDbl(Tax7_Sum)


        txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text), "##,##0")

        TextBox2.Text = Format(CDbl(txttotal_Befor.Text) + CDbl(txtEmployerLAK.Text) + CDbl(txtEmployLAK.Text) + CDbl(txtTax_money.Text), "##,##0")

    End Sub
    Private Sub FG_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG.ClickEvent
        If FG.Col = 3 Then
            FG.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
        FG.set_TextMatrix(FG.Row, 3, Format(CDbl(FG.get_TextMatrix(FG.Row, 3)), "#,##0"))
        sum()
    End Sub

    Private Sub FG_KeyPressEvent(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_KeyPressEvent) Handles FG.KeyPressEvent
        If e.keyAscii = 13 Then
            sum()
            txtTotal_Other.Text = Format(CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
            'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
            'If txtTotal_Other.Text > 0 Then
            txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
            'End If


            txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTotal_Other2.Text) + CDbl(txtTax_money.Text), "##,##0")
            Load_sum_tax()
            If chk_tax.Checked = True Then
                Load_sum_tax()
                txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
            Else
                txtTax_money.Text = 0
                txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
            End If


            txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
        End If
    End Sub

    Private Sub FG_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG.SelChange
        If FG.Col = 3 Then

            FG.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
        sum()
        txtTotal_Other.Text = Format(CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        'txttest.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        If txtTotal_Other.Text > 0 Then
            txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
            Load_sum_tax()
        End If
        Load_sum_tax()
        If chk_tax.Checked = True Then
            Load_sum_tax()
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
        Else
            txtTax_money.Text = 0
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
        End If

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        FG.Rows = FG.Rows + 1
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If FG.get_TextMatrix(FG.Row, 1) = "" Then
            FG.RemoveItem(FG.Row)
            If FG.Rows > 1 Then
                FG.RemoveItem(FG.Row)
            Else
                FG.Rows = 1
                FG.Rows = 2
            End If
        Else
            AccCD = FG.get_TextMatrix(FG.Row, 1)
            If MessageBox.Show("Do you want to cancle '" & AccCD & "' yes or no ?", "Cancle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If FG.Rows > 1 Then
                    FG.RemoveItem(FG.Row)
                Else
                    FG.Rows = 1
                    FG.Rows = 2
                End If
            End If
        End If
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub txtdat_month_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdat_month.TextChanged
        If IsNumeric(txtdat_month.Text) = False Or txtdat_month.Text = "" Then
            txtdat_month.Text = 22
            txtdat_month.Text = Format(CDbl(txtdat_month.Text), "##,##0")
        End If
        txtmoney_per_day.Text = Format(CDbl(txtsalary.Text) / CDbl(txtdat_month.Text), "##,##0")
    End Sub
    Public Sub juskan()

        Dim Vatx As String = txttotal_amount.Text
        Dim n As String = Microsoft.VisualBasic.Right(Vatx, 2)
        Dim m As String = Microsoft.VisualBasic.Left(Vatx, CDbl(Len(Vatx)) - 2)
        If n > 50 Then
            v1 = CDbl(m & "00") + 100
        End If
        If n < 50 Then
            v1 = m & "00"
        End If
        txttotal_amount.Text = Format(CDbl(v1), "##,##0")
        txttotal_Befor.Text = Format(CDbl(v1), "##,##0")

    End Sub
    Private Sub txtworday_month_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtworday_month.KeyPress
        If e.KeyChar = Chr(13) Then
            txttotal_Befor1.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
            'If txtworday_month.Text > 30 Then MsgBox("Day of work canot bigger than 30!") : txtworday_month.Text = 22 : Exit Sub
            'txttotal_amount.Text = Format(CDbl(txtworday_month.Text) * CDbl(txtmoney_per_day.Text), "##,##0")
            'txtcost_living_total.Text = Format(CDbl(txtcost_living_day.Text) * CDbl(txtworday_month.Text), "##,##0")
            'txttotal_Befor.Text = CDbl(txtmoney_per_day.Text) * Format(CDbl(txtworday_month.Text), "##,##0")
            'txttotal_Befor.Text = Format(CDbl(txttotal_Befor.Text) + CDbl(txtcost_living_total.Text), "##,##0")
            Dim aa As String
            Dim rs As New ADODB.Recordset
            Dim rst As New ADODB.Recordset
            aa = "SELECT    *  from  AP_Salary  WHERE    E_ID=N'" & txtid.Text & "'  "
            Call LoadRs(aa, rs)
            With rs
                If rs.RecordCount <> 0 Then
                    aa = "SELECT    *  from  Salary_group  WHERE    Group_SLR_id=N'" & .Fields("txtgroup_id").Value.ToString & "'  "
                    Call LoadRs(aa, rst)
                    If rst.RecordCount <> 0 Then
                        Group_ID = rst.Fields("Group_SLR_id").Value.ToString

                        Group_100 = rst.Fields("Group_100").Value.ToString
                        Group_percen100 = rst.Fields("Group_percen100").Value.ToString

                        Group_90 = rst.Fields("Group_90").Value.ToString
                        Group_percen90 = rst.Fields("Group_percen90").Value.ToString

                        Group_80 = rst.Fields("Group_80").Value.ToString
                        Group_percen80 = rst.Fields("Group_percen80").Value.ToString

                        Group_70 = rst.Fields("Group_70").Value.ToString
                        Group_percen70 = rst.Fields("Group_percen70").Value.ToString

                        Group_60 = rst.Fields("Group_60").Value.ToString
                        Group_percen60 = rst.Fields("Group_percen60").Value.ToString

                        'Group_50 = rst.Fields("Group_50").Value.ToString
                        'Group_percen50 = rst.Fields("Group_percen50").Value.ToString
                    End If


                    If chk_year_holiday.Checked = False Then

                        '====================== ssssssssssss
                        If .Fields("txtgroup_id").Value.ToString = Group_ID Then
                            If CDbl(txtworday_month.Text) > CDbl(Group_90) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")

                                TextBox3.Text = Group_percen100
                            End If

                            If Format(CDbl(txtworday_month.Text), "##,##0.00") > CDbl(Group_80) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(Group_90) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Group_percen90 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = Group_percen90
                            End If


                            If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(Group_70) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(Group_80) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Group_percen80 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = Group_percen80
                            End If

                            If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(Group_60) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(Group_70) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Group_percen70 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = Group_percen70
                            End If
                            If Format(CDbl(txtworday_month.Text), "##,##0.00") < CDbl(Group_60) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Group_percen60 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = Group_percen60
                            End If
                        End If

                        '====================== zzzzzzzzzz

                        'If .Fields("txtgroup_id").Value.ToString = "01" Then
                        '    If CDbl(txtworday_month.Text) > CDbl(79) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")

                        '        TextBox3.Text = 100
                        '    End If

                        '    If Format(CDbl(txtworday_month.Text), "##,##0.00") > CDbl(69) And Format(CDbl(txtworday_month.Text), "##,##0.00") < CDbl(80) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 90 / 100, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 90
                        '    End If


                        '    If Format(CDbl(txtworday_month.Text), "##,##0.00") > CDbl(59) And Format(CDbl(txtworday_month.Text), "##,##0.00") < CDbl(70) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 80 / 100, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 80
                        '    End If

                        '    If Format(CDbl(txtworday_month.Text), "##,##0.00") > CDbl(51) And Format(CDbl(txtworday_month.Text), "##,##0.00") < CDbl(60) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 70 / 100, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 70
                        '    End If
                        '    If Format(CDbl(txtworday_month.Text), "##,##0.00") < CDbl(50) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 60 / 100, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 60
                        '    End If
                        'End If


                        'If .Fields("txtgroup_id").Value.ToString = "02" Then
                        '    If CDbl(txtworday_month.Text) >= CDbl(200) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 100
                        '    End If

                        '    If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(190) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(199) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 90 / 100, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 90
                        '    End If


                        '    If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(180) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(189) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 80 / 100, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 80
                        '    End If

                        '    If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(170) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(179) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 70 / 100, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 70
                        '    End If
                        '    If Format(CDbl(txtworday_month.Text), "##,##0.00") < CDbl(170) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 60 / 100, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 60
                        '    End If
                        'End If


                        'If .Fields("txtgroup_id").Value.ToString = "03" Then
                        '    If CDbl(txtworday_month.Text) >= CDbl(184) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 100
                        '    End If

                        '    If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(175) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(183) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 90 / 100, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 90
                        '    End If


                        '    If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(165) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(174) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 80 / 100, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 80
                        '    End If

                        '    If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(155) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(164) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 70 / 100, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 70
                        '    End If
                        '    If Format(CDbl(txtworday_month.Text), "##,##0.00") < CDbl(155) Then
                        '        txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 60 / 100, "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '        txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '        TextBox3.Text = 60
                        '    End If

                        'End If

                        'If .Fields("txtgroup_id").Value.ToString = "04" Then
                        '    txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '    txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 50 / 100, "##,##0")
                        '    txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '    txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '    txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '    TextBox3.Text = 50
                        'End If

                        'If .Fields("txtgroup_id").Value.ToString = "05" Then
                        '    txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                        '    txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 95 / 100, "##,##0")
                        '    txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '    txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '    txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        '    TextBox3.Text = 95

                        'End If
                        '==========
                    Else
                        '=========
                        'If .Fields("txtgroup_id").Value.ToString = Group_ID Then

                        '    txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                        '    txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                        '    txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        'End If
                        '=========
                        If .Fields("txtgroup_id").Value.ToString = "01" Then

                            txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        End If

                        If .Fields("txtgroup_id").Value.ToString = "02" Then

                            txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")

                        End If


                        If .Fields("txtgroup_id").Value.ToString = "03" Then

                            txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        End If

                        If .Fields("txtgroup_id").Value.ToString = "04" Then
                            txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 50 / 100, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        End If

                        If .Fields("txtgroup_id").Value.ToString = "05" Then
                            txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 95 / 100, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        End If

                        '=============
                    End If
                End If
            End With





            'juskan()
            'If ChkSocial.Checked = True Then
            '    If CDbl(txttotal_amount.Text) < CDbl(2000000) Then
            '        'txtEmployLAK.Text = Format(CDbl(txttotal_amount.Text) * 4.5 / 100, "##,##0")
            '        'txtEmployerLAK.Text = Format(CDbl(txttotal_amount.Text) * 5 / 100, "##,##0")
            '        txtEmployLAK.Text = Format(CDbl(txttotal_amount.Text) * SSO_Employee / 100, "##,##0")
            '        txtEmployerLAK.Text = Format(CDbl(txttotal_amount.Text) * SSO_Employer / 100, "##,##0")
            '    Else
            '        txtEmployLAK.Text = Format(CDbl(90000), "##,##0")
            '        txtEmployerLAK.Text = Format(CDbl(100000), "##,##0")
            '    End If
            'Else
            '    txtEmployLAK.Text = 0
            '    txtEmployerLAK.Text = 0
            'End If

            If ChkSocial.Checked = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    txtpeple.Text = 1
                    If CDbl(txttotal_amount.Text) + txtmoney_over.Text < CDbl(2000000) Then
                        txtEmployLAK.Text = Format(CDbl(CDbl(txttotal_amount.Text) + CDbl(txtmoney_over.Text)) * SSO_Employee / 100, "##,##0")
                        txtEmployerLAK.Text = Format(CDbl(CDbl(txttotal_amount.Text) + CDbl(txtmoney_over.Text)) * SSO_Employer / 100, "##,##0")
                    Else
                        txtEmployLAK.Text = Format(CDbl(110000), "##,##0")
                        txtEmployerLAK.Text = Format(CDbl(120000), "##,##0")
                    End If
                Else
                    txtpeple.Text = 2
                    txtEmployLAK.Text = Format(CDbl(2000000) * 10 / 100, "##,##0")
                    txtEmployerLAK.Text = Format(CDbl(2000000) * 10 / 100, "##,##0")

                    'txtEmployLAK.Text = Format(CDbl(txttotal_amount.Text) * 10 / 100, "##,##0")
                    'txtEmployerLAK.Text = Format(CDbl(txttotal_amount.Text) * 10 / 100, "##,##0")

                    'txtEmployLAK.Text = Format(CDbl(90000), "##,##0")
                    'txtEmployerLAK.Text = Format(CDbl(100000), "##,##0")
                End If
            End If
                'If Format(CDbl(txttotal_amount.Text), "##,##0.00") < CDbl(Tax_LAK1) Then
                '    'MsgBox("< 1000,000.00")
                'ElseIf Format(CDbl(txttotal_amount.Text), "##,##0.00") = CDbl(Tax_LAK1) Then

                '    'MsgBox("=1000,000.00")
                'End If
                txttest.Text = Format(CDbl(txttotal_Befor.Text), "##,##0.00")
                txttest.Text = Format(CDbl(txttotal_Befor.Text), "##,##0.00")

                If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK1) Or Format(CDbl(txttotal_Befor1.Text), "##,##0.00") <= CDbl(Tax_LAK2) Then
                    If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK2) Then
                        Tax1_cut = CDbl(Tax_LAK2) - CDbl(Tax_LAK1)
                        Tax1_Sum = CDbl(Tax1_cut) * CDbl(Tax2) / 100
                        Tax2_Sum = 0
                        Tax3_Sum = 0
                        Tax4_Sum = 0
                        Tax5_Sum = 0
                        Tax6_Sum = 0
                        Tax7_Sum = 0
                    Else
                        Tax1_cut = Format(CDbl(txttotal_Befor1.Text), "##,##0.00") - CDbl(Tax_LAK1)
                        Tax1_Sum = CDbl(Tax1_cut) * CDbl(Tax2) / 100
                        'txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                        Tax2_Sum = 0
                        Tax3_Sum = 0
                        Tax4_Sum = 0
                        Tax5_Sum = 0
                        Tax6_Sum = 0
                        Tax7_Sum = 0
                    End If
                End If

                If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK2) And Format(CDbl(txttotal_Befor1.Text), "##,##0.00") <= CDbl(Tax_LAK3) Then
                    'If Format(CDbl(txttotal_Befor.Text), "##,##0.00") > CDbl(Tax_LAK3) Then
                    Tax2_cut = Format(CDbl(txttotal_Befor1.Text), "##,##0.00") - CDbl(Tax_LAK2)
                    'Tax2_cut = CDbl(Tax_LAK3) - CDbl(Tax_LAK2)
                    Tax2_Sum = CDbl(Tax2_cut) * CDbl(Tax3) / 100
                    Tax3_Sum = 0
                    Tax4_Sum = 0
                    Tax5_Sum = 0
                    Tax6_Sum = 0
                    Tax7_Sum = 0
                ElseIf Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK3) Then
                    Tax2_cut = CDbl(Tax_LAK3) - CDbl(Tax_LAK2)
                    'Tax2_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK2)
                    Tax2_Sum = CDbl(Tax2_cut) * CDbl(Tax3) / 100
                    'txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                    Tax3_Sum = 0
                    Tax4_Sum = 0
                    Tax5_Sum = 0
                    Tax6_Sum = 0
                    Tax7_Sum = 0
                    'End If
                End If

                If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK3) And Format(CDbl(txttotal_Befor1.Text), "##,##0.00") <= CDbl(Tax_LAK4) Then
                    Tax3_cut = Format(CDbl(txttotal_Befor1.Text), "##,##0.00") - CDbl(Tax_LAK3)

                    Tax3_Sum = CDbl(Tax3_cut) * CDbl(Tax4) / 100
                    Tax4_Sum = 0
                    Tax5_Sum = 0
                    Tax6_Sum = 0
                    Tax7_Sum = 0
                ElseIf Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK4) Then
                    Tax3_cut = CDbl(Tax_LAK4) - CDbl(Tax_LAK3)
                    'Tax3_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK3)
                    Tax3_Sum = CDbl(Tax3_cut) * CDbl(Tax4) / 100
                    'txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                    Tax4_Sum = 0
                    Tax5_Sum = 0
                    Tax6_Sum = 0
                    Tax7_Sum = 0
                    'End If
                End If

                If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK4) And Format(CDbl(txttotal_Befor1.Text), "##,##0.00") <= CDbl(Tax_LAK5) Then
                    Tax4_cut = Format(CDbl(txttotal_Befor1.Text), "##,##0.00") - CDbl(Tax_LAK4)

                    Tax4_Sum = CDbl(Tax4_cut) * CDbl(Tax5) / 100
                    Tax5_Sum = 0
                    Tax6_Sum = 0
                    Tax7_Sum = 0
                ElseIf Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK5) Then
                    'Tax4_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK4)
                    Tax4_cut = CDbl(Tax_LAK5) - CDbl(Tax_LAK4)
                    Tax4_Sum = CDbl(Tax4_cut) * CDbl(Tax5) / 100
                    'txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                    Tax5_Sum = 0
                    Tax6_Sum = 0
                    Tax7_Sum = 0

                End If

                If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK5) And Format(CDbl(txttotal_Befor1.Text), "##,##0.00") <= CDbl(Tax_LAK6) Then
                    Tax5_cut = Format(CDbl(txttotal_Befor1.Text), "##,##0.00") - CDbl(Tax_LAK5)
                    Tax5_Sum = CDbl(Tax5_cut) * CDbl(Tax6) / 100
                    Tax6_Sum = 0
                    Tax7_Sum = 0
                ElseIf Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK6) Then
                    'Tax5_cut = Format(CDbl(txttotal_Befor.Text), "##,##0.00") - CDbl(Tax_LAK5)
                    Tax5_cut = CDbl(Tax_LAK6) - CDbl(Tax_LAK5)
                    Tax5_Sum = CDbl(Tax5_cut) * CDbl(Tax6) / 100
                    'txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                    Tax6_Sum = 0
                    Tax7_Sum = 0

                End If

                If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") > CDbl(Tax_LAK6) Then

                    Tax6_cut = Format(CDbl(txttotal_Befor1.Text), "##,##0.00") - CDbl(Tax_LAK6)
                    Tax6_Sum = CDbl(Tax6_cut) * CDbl(Tax7) / 100
                    'txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                End If
                If Format(CDbl(txttotal_Befor1.Text), "##,##0.00") < CDbl(Tax_LAK1) Then
                    Tax1_Sum = 0
                    Tax2_Sum = 0
                    Tax3_Sum = 0
                    Tax4_Sum = 0
                    Tax5_Sum = 0
                    Tax6_Sum = 0
                    Tax7_Sum = 0

                End If

                txtTax_money.Text = CDbl(Tax1_Sum) + CDbl(Tax2_Sum) + CDbl(Tax3_Sum) + CDbl(Tax4_Sum) + CDbl(Tax5_Sum) + CDbl(Tax6_Sum)

                txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")

                txtnet_money.Text = Format(CDbl(txttotal_after.Text), "##,##0")
                'txttest.Text = Format(CDbl(txttotal_Befor.Text), "##,##0.00")
                If ChkSocial.Checked = True Then
                    txttotal_Befor.Text = Format(CDbl(txttest.Text) - CDbl(txtEmployLAK.Text), "##,##0")
                    txttest.Text = Format(CDbl(txttest.Text) - CDbl(txtEmployLAK.Text), "##,##0")
                    txttotal_Befor1.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
                    If txtEmployLAK.Text > 0 Then
                        'txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
                        Load_sum_tax()
                    End If
                Else
                    txttotal_Befor.Text = Format(CDbl(txttotal_Befor.Text) + CDbl(txtEmployLAK.Text), "##,##0")
                    txttest.Text = Format(CDbl(txttest.Text) + CDbl(txtEmployLAK.Text), "##,##0")
                    txttotal_Befor1.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
                    If txtEmployLAK.Text > 0 Then
                        'txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
                        Load_sum_tax()
                    End If

                End If

                txtovertime150.Focus()
                Call Sum_Item()
                Load_sum_tax()
                If chk_tax.Checked = True Then
                    Load_sum_tax()
                    txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
                Else
                    txtTax_money.Text = 0
                    txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
                End If
                txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")

                txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")



            End If
    End Sub

    Private Sub txtworday_month_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtworday_month.MouseMove

    End Sub

    Private Sub txtworday_month_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtworday_month.TextChanged
        If IsNumeric(txtworday_month.Text) = False Or txtworday_month.Text = "" Then
            txtworday_month.Text = 0
            txtworday_month.Text = Format(CDbl(txtworday_month.Text), "##,##0")
        End If

    End Sub

    Private Sub txtmoney_per_day_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmoney_per_day.TextChanged

    End Sub

    Private Sub txttotal_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal_amount.TextChanged

    End Sub

    Private Sub txtsalary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsalary.TextChanged

    End Sub

    Private Sub txtTax_money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax_money.TextChanged
        txtTax_money.Text = Format(CDbl(txtTax_money.Text), "##,##0")
    End Sub

    Private Sub txttotal_Befor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal_Befor.TextChanged

    End Sub

    Private Sub txttotal_after_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal_after.TextChanged
        txtnet.Text = Format(CDbl(txttotal_after.Text), "##,##0")
        txtcurren.Text = Format(CDbl(txttotal_after.Text), "##,##0")


        'txttotal_after.Text = Format(CDbl(txttotal_after.Text), "##,##0.00")
        txtTotal_money_Curren.Text = Format(CDbl(txtTotal_money_Curren.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txtcurren.Text) + CDbl(txtUnifrom_male.Text) + CDbl(txtUnifrom_Female.Text), "##,##0")
        txtnet_money.Text = Format(CDbl(txtnet.Text) - CDbl(txthous_after.Text), "##,##0")
        txtnet_money.Text = Format(CDbl(txtnet.Text) - CDbl(txtother_cut.Text), "##,##0")
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text), "##,##0")
    End Sub

    Private Sub txtTotal_Other_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal_Other.TextChanged
        'txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        frmRate.ShowDialog()
    End Sub

    Private Sub txthous_after_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthous_after.KeyPress
        If e.KeyChar = Chr(13) Then
            txtnet_money.Text = Format(CDbl(txtnet.Text) - CDbl(txthous_after.Text), "##,##0")
            txtnet2.Text = Format(CDbl(txtnet.Text) - CDbl(txthous_after.Text), "##,##0")
            txthous_after.Text = Format(CDbl(txthous_after.Text), "##,##0")
            txtother_cut.Focus()
        End If

    End Sub

    Private Sub txthous_after_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthous_after.TextChanged
        'txtnet_money.Text = Format(CDbl(txtnet_money.Text) - CDbl(txthous_after.Text), "##,##0.00")
    End Sub

    Private Sub txtother_cut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtother_cut.KeyPress
        If e.KeyChar = Chr(13) Then

            txtnet_money.Text = Format(CDbl(txtnet2.Text) - CDbl(txtother_cut.Text), "##,##0")
            txtother_cut.Text = Format(CDbl(txtother_cut.Text), "##,##0")
            txtUnifrom_male.Focus()
        End If
    End Sub

    Private Sub txtother_cut_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtother_cut.TextChanged
        'txtnet_money.Text = Format(CDbl(txtnet_money.Text) - CDbl(txtother_cut.Text), "##,##0.00")
    End Sub

    Private Sub txtUnifrom_male_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnifrom_male.KeyPress
        If e.KeyChar = Chr(13) Then
            txtTotal_money_Curren.Text = Format(CDbl(txtcurren.Text) + CDbl(txtUnifrom_male.Text) + CDbl(txtUnifrom_Female.Text), "##,##0")
            txtUnifrom_male.Text = Format(CDbl(txtUnifrom_male.Text), "##,##0")
            txtUnifrom_Female.Focus()
        End If
    End Sub

    Private Sub txtUnifrom_male_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnifrom_male.TextChanged
        'txtTotal_money_Curren.Text = Format(CDbl(txtTotal_money_Curren.Text) + CDbl(txtUnifrom_male.Text) + CDbl(txtUnifrom_Female.Text), "##,##0.00")
    End Sub

    Private Sub txtUnifrom_Female_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnifrom_Female.KeyPress
        If e.KeyChar = Chr(13) Then
            txtTotal_money_Curren.Text = Format(CDbl(txtcurren.Text) + CDbl(txtUnifrom_male.Text) + CDbl(txtUnifrom_Female.Text), "##,##0")
            txtUnifrom_Female.Text = Format(CDbl(txtUnifrom_Female.Text), "##,##0")
        End If
    End Sub

    Private Sub txtUnifrom_Female_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnifrom_Female.TextChanged
        'txtTotal_money_Curren.Text = Format(CDbl(txtTotal_money_Curren.Text) + CDbl(txtUnifrom_Female.Text) + CDbl(txtUnifrom_male.Text), "##,##0.00")
    End Sub

    Private Sub txtnet_money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnet_money.TextChanged
        'txtnet2.Text = Format(CDbl(txtnet_money.Text), "##,##0")
    End Sub

    Private Sub txtTax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtid.Text = "" Then Exit Sub
        If txtSum1.Text > 0 Then
            Conn.Execute("DELETE FROM AP_Salary_Item where  month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID=N'" & txtid.Text & "' ")
        End If
        If txtSum2.Text > 0 Then
            Conn.Execute("DELETE FROM AP_Salary_Item2 where  month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID=N'" & txtid.Text & "' ")
        End If
        If txtSum3.Text > 0 Then
            Conn.Execute("DELETE FROM AP_Salary_Item3 where  month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID=N'" & txtid.Text & "' ")
        End If
        If txtSum4.Text > 0 Then
            Conn.Execute("DELETE FROM AP_Salary_Item4 where  month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID=N'" & txtid.Text & "' ")
        End If

        SAVE()
        Call SaveItem()
        Call SaveItem2()
        Call SaveItem3()
        Call SaveItem4()


        MsgBox("Save Complete!", MsgBoxStyle.OkOnly)
    End Sub
    Private Sub SaveItem()
        'If txtSum1.Text = 0 Then Exit Sub
        Dim ww As String
        Dim i As Integer
        Dim RcItem As New ADODB.Recordset
        With RcItem
            Call LoadRs("SELECT * FROM  AP_Salary_Item WHERE     month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID=N'" & txtid.Text & "'", RcItem)
            For i = 1 To FG.Rows - 1
                If .RecordCount = 0 Then

                    ww = " INSERT INTO  AP_Salary_Item ( PersonID,Department_ID,AtMonth,Code,Other_nm,Money_QTY) " & _
                        "VALUES( " & _
                              " N'" & Trim(txtid.Text.ToString) & "'," & _
                               " N'" & Trim(txtdepartment_id.Text.ToString) & "'," & _
                            " '" & Format((dt_month.Value), "yyyy-MM-dd") & "'," & _
                              "N'" & FG.get_TextMatrix(i, 1) & "'," & _
                                 "N'" & FG.get_TextMatrix(i, 2) & "'," & _
                           "" & CDbl(FG.get_TextMatrix(i, 3)) & ")"
                    Conn.Execute(ww)

                Else
                End If
            Next i
        End With

    End Sub

    Private Sub SaveItem2()
        'If txtSum2.Text = 0 Then Exit Sub
        Dim ww As String
        Dim i As Integer
        Dim RcItem As New ADODB.Recordset
        With RcItem
            Call LoadRs("SELECT * FROM  AP_Salary_Item2 WHERE     month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID=N'" & txtid.Text & "'", RcItem)
            For i = 1 To FG2.Rows - 1
                If .RecordCount = 0 Then

                    ww = " INSERT INTO  AP_Salary_Item2 ( PersonID,Department_ID,AtMonth,Code,Other_nm,Money_QTY) " & _
                        "VALUES( " & _
                              " N'" & Trim(txtid.Text.ToString) & "'," & _
                               " N'" & Trim(txtdepartment_id.Text.ToString) & "'," & _
                            " '" & Format((dt_month.Value), "yyyy-MM-dd") & "'," & _
                              "N'" & FG2.get_TextMatrix(i, 1) & "'," & _
                                 "N'" & FG2.get_TextMatrix(i, 2) & "'," & _
                            "" & CDbl(FG2.get_TextMatrix(i, 3)) & ")"
                    Conn.Execute(ww)

                Else
                End If
            Next i
        End With

    End Sub
    Private Sub SaveItem3()
        'If txtSum3.Text = 0 Then Exit Sub
        Dim ww As String
        Dim i As Integer
        Dim RcItem As New ADODB.Recordset
        With RcItem
            Call LoadRs("SELECT * FROM  AP_Salary_Item3 WHERE     month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID=N'" & txtid.Text & "'", RcItem)
            For i = 1 To FG1_After.Rows - 1
                If .RecordCount = 0 Then

                    ww = " INSERT INTO  AP_Salary_Item3 ( PersonID,Department_ID,AtMonth,Code,Other_nm_Add_After,Money_QTY_Add_After) " & _
                        "VALUES( " & _
                              " N'" & Trim(txtid.Text.ToString) & "'," & _
                                " N'" & Trim(txtdepartment_id.Text.ToString) & "'," & _
                            " '" & Format((dt_month.Value), "yyyy-MM-dd") & "'," & _
                              "N'" & FG1_After.get_TextMatrix(i, 1) & "'," & _
                                 "N'" & FG1_After.get_TextMatrix(i, 2) & "'," & _
                            "" & CDbl(FG1_After.get_TextMatrix(i, 3)) & ")"
                    Conn.Execute(ww)

                Else
                End If
            Next i
        End With

    End Sub
    Private Sub SaveItem4()
        'If txtSum4.Text = 0 Then Exit Sub
        Dim ww As String
        Dim i As Integer
        Dim RcItem As New ADODB.Recordset
        With RcItem
            Call LoadRs("SELECT * FROM  AP_Salary_Item4 WHERE     month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID=N'" & txtid.Text & "'", RcItem)
            For i = 1 To FG2_After.Rows - 1
                If .RecordCount = 0 Then

                    ww = " INSERT INTO  AP_Salary_Item4 ( PersonID,Department_ID,AtMonth,Code,Other_nm_Deduc_After,Money_QTY_Deduc_After) " & _
                        "VALUES( " & _
                              " N'" & Trim(txtid.Text.ToString) & "'," & _
                                 " N'" & Trim(txtdepartment_id.Text.ToString) & "'," & _
                            " '" & Format((dt_month.Value), "yyyy-MM-dd") & "'," & _
                              "N'" & FG2_After.get_TextMatrix(i, 1) & "'," & _
                                "N'" & FG2_After.get_TextMatrix(i, 2) & "'," & _
                            "" & CDbl(FG2_After.get_TextMatrix(i, 3)) & ")"
                    Conn.Execute(ww)

                Else
                End If
            Next i
        End With

    End Sub
    Private Sub SAVE()
        Dim sssss As String
        Dim rs As New ADODB.Recordset
        Call LoadRs("SELECT * FROM AP_Salary_in_Month WHERE   month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID=N'" & txtid.Text & "'", rs)
        If rs.RecordCount = 0 Then
            sssss = "INSERT INTO AP_Salary_in_Month(PersonID,AtMonth,Name_L,txtcontract_type_id,percen,Salary, SalaryCurrency, Rate, RateDate, DayOfMonth, MPerDayCurrent, WDayOfMonth, " & _
                    "   total_amount,txtTum_money, Employee_LAK, Employer_LAK, HOvertime150, HOvertime200, HOvertime250, HOvertime300, MOvertimeTotal,txt_H_oertime, Bonus,Sum_Addtional,Sum_Deducation,Total_Other,Sum_Addtional_After,Sum_Deducation_After,Total_Other_After, tax_type, Money_Befor,  " & _
                     " Tax_Level1,Tax_Level2,Tax_Level3,Tax_Level4,Tax_Level5,Tax_Level6,Tax_Level7, tax_money," & _
 "    Money_After, Housing_After, Money_Cut, Net_Money, AGL_Out, AGL_In, Unifron_Male, Unifron_FeMale, Total_Money_curr,Total_Money_curr_Exing,txtpeple, Lst_Updt, Lst_Usr, pc_nm) " & _
            " VALUES( N'" & Trim(txtid.Text.ToString) & "'," & _
                " N'" & (Format(dt_month.Value, "yyyy-MM-dd")) & "'," & _
               " N'" & Trim(txt_Nane.Text.ToString) & "'," & _
                   " N'" & Trim(txtcontract_type_id.Text.ToString) & "'," & _
                  " " & CDbl(txtpercen.Text) & "," & _
                        " " & CDbl(txtsalary.Text) & "," & _
              " N'" & Trim(Label18.Text.ToString) & "'," & _
                 " " & CDbl(txtRate.Text) & "," & _
             " N'" & (Format(dt_month.Value, "yyyy-MM-dd")) & "'," & _
             " " & CDbl(txtdat_month.Text) & "," & _
            " " & CDbl(txtmoney_per_day.Text) & "," & _
           " " & CDbl(txtworday_month.Text) & "," & _
             " " & CDbl(txttotal_amount.Text) & "," & _
               " " & CDbl(txtTum_money.Text) & "," & _
              " " & CDbl(txtEmployLAK.Text) & "," & _
            " " & CDbl(txtEmployerLAK.Text) & "," & _
           " " & CDbl(txtovertime150.Text) & "," & _
             " " & CDbl(txtovertime200.Text) & "," & _
               " " & CDbl(txtovertime250.Text) & "," & _
             " " & CDbl(txtovertime300.Text) & "," & _
                " " & CDbl(txtmoney_over.Text) & "," & _
                   " " & CDbl(txt_H_oertime.Text) & "," & _
                          "  " & CDbl(txtother_money.Text) & "," & _
               " " & CDbl(txtSum1.Text) & "," & _
               "  " & CDbl(txtSum2.Text) & "," & _
                 "  " & CDbl(txtTotal_Other.Text) & "," & _
                  " " & CDbl(txtSum3.Text) & "," & _
               "  " & CDbl(txtSum4.Text) & "," & _
                 "  " & CDbl(txtTotal_Other2.Text) & "," & _
                   " N'" & Trim(txtTax.Text.ToString) & "'," & _
                  " " & CDbl(txttotal_Befor.Text) & "," & _
                  " " & CDbl(Tax_LAK1) & "," & _
                      " " & CDbl(Tax1_Sum) & "," & _
                         " " & CDbl(Tax2_Sum) & "," & _
                            " " & CDbl(Tax3_Sum) & "," & _
                               " " & CDbl(Tax4_Sum) & "," & _
                                  " " & CDbl(Tax5_Sum) & "," & _
                                     " " & CDbl(Tax6_Sum) & "," & _
                                       " " & CDbl(txtTax_money.Text) & "," & _
               " " & CDbl(txttotal_after.Text) & "," & _
             " " & CDbl(txthous_after.Text) & "," & _
                " " & CDbl(txtother_cut.Text) & "," & _
               "  " & CDbl(txtnet_money.Text) & "," & _
                " " & CDbl(txtAGL_ount.Text) & "," & _
             " " & CDbl(txtAGL_in.Text) & "," & _
                " " & CDbl(txtUnifrom_male.Text) & "," & _
               "  " & CDbl(txtUnifrom_Female.Text) & "," & _
                "  " & CDbl(txtTotal_money_Curren.Text) & "," & _
                 "  " & CDbl(txtTotal_money_Curren_Exiting.Text) & "," & _
                              " '" & (txtpeple.Text) & "'," & _
                    " '" & Format(Date.Today, "yyyy-MM-dd") & "'," & _
          " N'" & MUserName & "', " & _
    " N'" & MDServerName & "')"


            Conn.Execute(sssss)
            If ChkSocial.Checked = True Then
                Conn.Execute(" Update AP_Salary_in_Month set  Chk_Social ='1' where PersonID=N'" & txtid.Text & "' ")
            End If
            If Chk_AGL.Checked = True Then
                Conn.Execute(" Update AP_Salary_in_Month set Chk_AGL ='1' where PersonID=N'" & txtid.Text & "' ")
            End If

        Else
            Conn.Execute("DELETE FROM AP_Salary_in_Month WHERE  month(AtMonth) ='" & Month(dt_month.Value) & "' and year(AtMonth) ='" & Year(dt_month.Value) & "' and PersonID=N'" & txtid.Text & "' ")
            sssss = "INSERT INTO AP_Salary_in_Month(PersonID,AtMonth,Name_L,txtcontract_type_id,percen,Salary, SalaryCurrency, Rate, RateDate, DayOfMonth, MPerDayCurrent, WDayOfMonth, " & _
              "   total_amount,txtTum_money, Employee_LAK, Employer_LAK, HOvertime150, HOvertime200, HOvertime250, HOvertime300, MOvertimeTotal,txt_H_oertime, Bonus,Sum_Addtional,Sum_Deducation,Total_Other,Sum_Addtional_After,Sum_Deducation_After,Total_Other_After, tax_type, Money_Befor,  " & _
               " Tax_Level1,Tax_Level2,Tax_Level3,Tax_Level4,Tax_Level5,Tax_Level6,Tax_Level7, tax_money," & _
"    Money_After, Housing_After, Money_Cut, Net_Money, AGL_Out, AGL_In, Unifron_Male, Unifron_FeMale, Total_Money_curr,Total_Money_curr_Exing,txtpeple, Lst_Updt, Lst_Usr, pc_nm) " & _
      " VALUES( N'" & Trim(txtid.Text.ToString) & "'," & _
          " N'" & (Format(dt_month.Value, "yyyy-MM-dd")) & "'," & _
         " N'" & Trim(txt_Nane.Text.ToString) & "'," & _
             " N'" & Trim(txtcontract_type_id.Text.ToString) & "'," & _
          " " & CDbl(txtpercen.Text) & "," & _
                  " " & CDbl(txtsalary.Text) & "," & _
        " N'" & Trim(Label18.Text.ToString) & "'," & _
           " " & CDbl(txtRate.Text) & "," & _
       " N'" & (Format(dt_month.Value, "yyyy-MM-dd")) & "'," & _
       " " & CDbl(txtdat_month.Text) & "," & _
      " " & CDbl(txtmoney_per_day.Text) & "," & _
     " " & CDbl(txtworday_month.Text) & "," & _
       " " & CDbl(txttotal_amount.Text) & "," & _
         " " & CDbl(txtTum_money.Text) & "," & _
        " " & CDbl(txtEmployLAK.Text) & "," & _
      " " & CDbl(txtEmployerLAK.Text) & "," & _
     " " & CDbl(txtovertime150.Text) & "," & _
       " " & CDbl(txtovertime200.Text) & "," & _
         " " & CDbl(txtovertime250.Text) & "," & _
       " " & CDbl(txtovertime300.Text) & "," & _
          " " & CDbl(txtmoney_over.Text) & "," & _
            " " & CDbl(txt_H_oertime.Text) & "," & _
         "  " & CDbl(txtother_money.Text) & "," & _
         " " & CDbl(txtSum1.Text) & "," & _
         "  " & CDbl(txtSum2.Text) & "," & _
           "  " & CDbl(txtTotal_Other.Text) & "," & _
            " " & CDbl(txtSum3.Text) & "," & _
         "  " & CDbl(txtSum4.Text) & "," & _
           "  " & CDbl(txtTotal_Other2.Text) & "," & _
             " N'" & Trim(txtTax.Text.ToString) & "'," & _
            " " & CDbl(txttotal_Befor.Text) & "," & _
            " " & CDbl(Tax_LAK1) & "," & _
                " " & CDbl(Tax1_Sum) & "," & _
                   " " & CDbl(Tax2_Sum) & "," & _
                      " " & CDbl(Tax3_Sum) & "," & _
                         " " & CDbl(Tax4_Sum) & "," & _
                            " " & CDbl(Tax5_Sum) & "," & _
                               " " & CDbl(Tax6_Sum) & "," & _
                                 " " & CDbl(txtTax_money.Text) & "," & _
         " " & CDbl(txttotal_after.Text) & "," & _
       " " & CDbl(txthous_after.Text) & "," & _
          " " & CDbl(txtother_cut.Text) & "," & _
         "  " & CDbl(txtnet_money.Text) & "," & _
          " " & CDbl(txtAGL_ount.Text) & "," & _
       " " & CDbl(txtAGL_in.Text) & "," & _
          " " & CDbl(txtUnifrom_male.Text) & "," & _
         "  " & CDbl(txtUnifrom_Female.Text) & "," & _
          "  " & CDbl(txtTotal_money_Curren.Text) & "," & _
           "  " & CDbl(txtTotal_money_Curren_Exiting.Text) & "," & _
                               " '" & (txtpeple.Text) & "'," & _
              " '" & Format(Date.Today, "yyyy-MM-dd") & "'," & _
          " N'" & MUserName & "', " & _
          " N'" & MDServerName & "')"


            Conn.Execute(sssss)
            If ChkSocial.Checked = True Then
                Conn.Execute(" Update AP_Salary_in_Month set  Chk_Social ='1' where PersonID=N'" & txtid.Text & "' ")
            End If
            If Chk_AGL.Checked = True Then
                Conn.Execute(" Update AP_Salary_in_Month set Chk_AGL ='1' where PersonID=N'" & txtid.Text & "' ")
            End If
        End If

    End Sub

    Private Sub txtovertime150_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtovertime150.KeyDown

    End Sub


    Private Sub txtovertime150_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtovertime150.KeyPress
        If e.KeyChar = Chr(13) Then
            If txttotal_amount.Text = 0 Then Exit Sub
            'o150 = Format(CDbl(txtmoney_per_day.Text) / CDbl(Hour_Day) * 150 * Format(CDbl(txtovertime150.Text)) / 100, "##,##0")
            'o150 = Format(CDbl(txtovertime150.Text) * Format(CDbl(txtmoney_per_day.Text)), "##,##0")
            If chk_year_holiday.Checked = False Then

                'o150 = Format(CDbl(o150)) * Format(CDbl(txtRate.Text), "##,##0")
                If CheckBox1.Checked = True Then
                    o150 = Format(CDbl(txtovertime150.Text) * Format(CDbl(txtmoney_per_day.Text)), "##,##0")
                Else
                    o150 = Format(CDbl(txtovertime150.Text) * Format(CDbl(txtsalary.Text / txtdat_month.Text)), "##,##0")
                End If
            Else
                
                o150 = Format(CDbl(txtovertime150.Text) * Format(CDbl(txtsalary.Text * cmb_over_per.Text / 100)) / CDbl(txtdat_month.Text), "##,##0")
            End If


        txtmoney_over.Text = Format(CDbl(o150) + CDbl(o200) + Format(CDbl(o250)) + Format(CDbl(o300)) * ((txtRate.Text)), "##,##0")
        txtmoney_over.Text = Format(CDbl(txtmoney_over.Text) * CDbl(txtRate.Text), "##,##0")
        txtovertime200.Focus()

        If ChkSocial.Checked = True Then
            If ComboBox1.SelectedIndex = 0 Then
                txtpeple.Text = 1
                If CDbl(txttotal_amount.Text) + txtmoney_over.Text < CDbl(2000000) Then
                    txtEmployLAK.Text = Format(CDbl(CDbl(txttotal_amount.Text) + CDbl(txtmoney_over.Text)) * SSO_Employee / 100, "##,##0")
                    txtEmployerLAK.Text = Format(CDbl(CDbl(txttotal_amount.Text) + CDbl(txtmoney_over.Text)) * SSO_Employer / 100, "##,##0")
                Else
                    txtEmployLAK.Text = Format(CDbl(110000), "##,##0")
                    txtEmployerLAK.Text = Format(CDbl(120000), "##,##0")
                End If
            Else
                txtpeple.Text = 2
                txtEmployLAK.Text = Format(CDbl(2000000) * 10 / 100, "##,##0")
                txtEmployerLAK.Text = Format(CDbl(2000000) * 10 / 100, "##,##0")

            End If

        End If




        Load_sum_tax()

        'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtmoney_over.Text), "##,##0")
        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        If txtmoney_over.Text > 0 Then
            txtmoney_over.Text = Format(CDbl(txtmoney_over.Text), "##,##0")
            Load_sum_tax()
        End If
        Load_sum_tax()
        If chk_tax.Checked = True Then
            Load_sum_tax()
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
        Else
            txtTax_money.Text = 0
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
        End If
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
        txt_H_oertime.Text = Format(CDbl(txtovertime150.Text) + CDbl(txtovertime200.Text) + CDbl(txtovertime250.Text) + CDbl(txtovertime300.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtSum4.Focus()
            End If
    End Sub



    Private Sub txtovertime150_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtovertime150.TextChanged
        If IsNumeric(txtovertime150.Text) = False Or txtovertime150.Text = "" Then txtovertime150.Text = 0 : Exit Sub
    End Sub

    Private Sub txtovertime200_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtovertime200.KeyPress
        If e.KeyChar = Chr(13) Then
            If txttotal_amount.Text = 0 Then Exit Sub
            o200 = Format(CDbl(txtmoney_per_day.Text) / CDbl(Hour_Day) * 200 * Format(CDbl(txtovertime200.Text)) / 100, "##,##0.00")
            txtmoney_over.Text = Format(CDbl(o150) + CDbl(o200) + Format(CDbl(o250)) + Format(CDbl(o300)), "##,##0")
            txtovertime250.Focus()
            Load_sum_tax()
            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
            'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtmoney_over.Text), "##,##0")
            If txtmoney_over.Text > 0 Then
                txtmoney_over.Text = Format(CDbl(txtmoney_over.Text), "##,##0")
                Load_sum_tax()
            End If
            Load_sum_tax()
            If chk_tax.Checked = True Then
                Load_sum_tax()
                txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
            Else
                txtTax_money.Text = 0
                txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
            End If
            txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
            txt_H_oertime.Text = Format(CDbl(txtovertime150.Text) + CDbl(txtovertime200.Text) + CDbl(txtovertime250.Text) + CDbl(txtovertime300.Text), "##,##0")
        End If

    End Sub



    Private Sub txtovertime200_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtovertime200.TextChanged
        If IsNumeric(txtovertime200.Text) = False Or txtovertime200.Text = "" Then txtovertime200.Text = 0 : Exit Sub
    End Sub

    Private Sub txtovertime300_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtovertime300.KeyPress
        If e.KeyChar = Chr(13) Then
            If txttotal_amount.Text = 0 Then Exit Sub
            o300 = Format(CDbl(txtmoney_per_day.Text) / CDbl(Hour_Day) * 300 * Format(CDbl(txtovertime300.Text)) / 100, "##,##0")
            txtmoney_over.Text = Format(CDbl(o150) + CDbl(o200) + Format(CDbl(o250)) + Format(CDbl(o300)), "##,##0.00")
            Load_sum_tax()
            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtTotal_Other.Text), "##,##0")
            'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtmoney_over.Text), "##,##0")
            If txtmoney_over.Text > 0 Then
                txtmoney_over.Text = Format(CDbl(txtmoney_over.Text), "##,##0")
                Load_sum_tax()
            End If
            Load_sum_tax()
            txtother_money.Focus()
            If chk_tax.Checked = True Then
                Load_sum_tax()
                txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
            Else
                txtTax_money.Text = 0
                txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
            End If
            txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTotal_Other2.Text) + CDbl(txtTax_money.Text), "##,##0")
            txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTotal_Other2.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text), "##,##0")
            txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
            txt_H_oertime.Text = Format(CDbl(txtovertime150.Text) + CDbl(txtovertime200.Text) + CDbl(txtovertime250.Text) + CDbl(txtovertime300.Text), "##,##0")
        End If
    End Sub

    Private Sub txtovertime300_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtovertime300.TextChanged
        If IsNumeric(txtovertime300.Text) = False Or txtovertime300.Text = "" Then txtovertime300.Text = 0 : Exit Sub
    End Sub

    Private Sub txtovertime250_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtovertime250.KeyPress
        If e.KeyChar = Chr(13) Then
            If txttotal_amount.Text = 0 Then Exit Sub
            o250 = Format(CDbl(txtmoney_per_day.Text) / CDbl(Hour_Day) * 250 * Format(CDbl(txtovertime250.Text)) / 100, "##,##0.00")
            txtmoney_over.Text = Format(CDbl(o150) + CDbl(o200) + Format(CDbl(o250)) + Format(CDbl(o300)), "##,##0")
            txtovertime300.Focus()
            Load_sum_tax()
            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtTotal_Other.Text), "##,##0")
            'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtmoney_over.Text), "##,##0")
            If txtmoney_over.Text > 0 Then
                txtmoney_over.Text = Format(CDbl(txtmoney_over.Text), "##,##0")
                Load_sum_tax()
            End If
            Load_sum_tax()
            If chk_tax.Checked = True Then
                Load_sum_tax()
                txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
            Else
                txtTax_money.Text = 0
                txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
            End If
            txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTotal_Other2.Text) + CDbl(txtTax_money.Text), "##,##0")
            txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTotal_Other2.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text), "##,##0")
            txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
            txt_H_oertime.Text = Format(CDbl(txtovertime150.Text) + CDbl(txtovertime200.Text) + CDbl(txtovertime250.Text) + CDbl(txtovertime300.Text), "##,##0")
        End If
    End Sub

    Private Sub txtovertime250_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtovertime250.KeyUp

    End Sub

    Private Sub txtovertime250_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtovertime250.TextChanged
        If IsNumeric(txtovertime250.Text) = False Or txtovertime250.Text = "" Then txtovertime250.Text = 0 : Exit Sub
    End Sub

    Private Sub txtother_money_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtother_money.KeyPress
        If e.KeyChar = Chr(13) Then
            If txttotal_amount.Text = 0 Then Exit Sub
            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtTotal_Other.Text), "##,##0")
            'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtother_money.Text) + CDbl(txtmoney_over.Text) + CDbl(txtTotal_Other.Text), "##,##0")
            If txtother_money.Text > 0 Then
                txtother_money.Text = Format(CDbl(txtother_money.Text), "##,##0")
                Load_sum_tax()
            End If
            txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTotal_Other2.Text) + CDbl(txtTax_money.Text), "##,##0")
            txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTotal_Other2.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text), "##,##0")
        End If
    End Sub


    Private Sub txtmoney_over_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmoney_over.TextChanged
        txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtmoney_over.Text), "##,##0")
        If txtmoney_over.Text > 0 Then
            txtmoney_over.Text = Format(CDbl(txtmoney_over.Text), "##,##0")
            Load_sum_tax()

        End If

    End Sub

    Private Sub FG2_AfterEdit(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_AfterEditEvent) Handles FG2.AfterEdit
        sum2()
        FG2.set_TextMatrix(FG2.Row, 3, Format(CDbl(FG2.get_TextMatrix(FG2.Row, 3)), "#,##0"))


        txtTotal_Other.Text = Format(CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        If txtTotal_Other.Text > 0 Then
            txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
            Load_sum_tax()

        End If
        If chk_tax.Checked = True Then
            Load_sum_tax()
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
        Else
            txtTax_money.Text = 0
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
        End If
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
    End Sub

    Private Sub FG2_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG2.ClickEvent
        If FG2.Col = 3 Then
            FG2.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG2.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
        FG2.set_TextMatrix(FG2.Row, 3, Format(CDbl(FG2.get_TextMatrix(FG2.Row, 3)), "#,##0"))
        sum2()


    End Sub

    Private Sub FG2_KeyPressEvent(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_KeyPressEvent) Handles FG2.KeyPressEvent
        If e.keyAscii = 13 Then
            sum2()
            txtTotal_Other.Text = Format(CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
            'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtTotal_Other.Text), "##,##0")
            'If txtTotal_Other.Text > 0 Then
            txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
            Load_sum_tax()
            'End If
        End If
        sum2()
        txtTotal_Other.Text = Format(CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        'If txtTotal_Other.Text > 0 Then
        txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
        Load_sum_tax()

        If chk_tax.Checked = True Then
            Load_sum_tax()
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
        Else
            txtTax_money.Text = 0
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
        End If
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTotal_Other2.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
    End Sub



    Private Sub FG2_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG2.SelChange
        If FG2.Col = 3 Then

            FG2.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG2.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
        sum2()
        txtTotal_Other.Text = Format(CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        'If txtTotal_Other.Text > 0 Then
        txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
        Load_sum_tax()
        If chk_tax.Checked = True Then
            Load_sum_tax()
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
        Else
            txtTax_money.Text = 0
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
        End If
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FG2.Rows = FG2.Rows + 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If FG2.get_TextMatrix(FG2.Row, 1) = "" Then
            FG2.RemoveItem(FG2.Row)
            If FG2.Rows > 1 Then
                FG2.RemoveItem(FG2.Row)
            Else
                FG2.Rows = 1
                FG2.Rows = 2
            End If
        Else
            AccCD = FG2.get_TextMatrix(FG2.Row, 1)
            If MessageBox.Show("Do you want to cancle '" & AccCD & "' yes or no ?", "Cancle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If FG2.Rows > 1 Then
                    FG2.RemoveItem(FG.Row)
                Else
                    FG2.Rows = 1
                    FG2.Rows = 2
                End If
            End If
        End If
    End Sub

    Private Sub ChkSocial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSocial.CheckedChanged
        If ChkSocial.Checked = True Then
            If ComboBox1.SelectedIndex = 0 Then
                txtpeple.Text = 1
                If CDbl(txttotal_amount.Text) + txtmoney_over.Text < CDbl(2000000) Then
                    txtEmployLAK.Text = Format(CDbl(CDbl(txttotal_amount.Text) + CDbl(txtmoney_over.Text)) * SSO_Employee / 100, "##,##0")
                    txtEmployerLAK.Text = Format(CDbl(CDbl(txttotal_amount.Text) + CDbl(txtmoney_over.Text)) * SSO_Employer / 100, "##,##0")
                Else
                    txtEmployLAK.Text = Format(CDbl(110000), "##,##0")
                    txtEmployerLAK.Text = Format(CDbl(120000), "##,##0")
                End If
            Else
                txtpeple.Text = 2
                txtEmployLAK.Text = Format(CDbl(2000000) * 10 / 100, "##,##0")
                txtEmployerLAK.Text = Format(CDbl(2000000) * 10 / 100, "##,##0")

                'txtEmployLAK.Text = Format(CDbl(txttotal_amount.Text) * 10 / 100, "##,##0")
                'txtEmployerLAK.Text = Format(CDbl(txttotal_amount.Text) * 10 / 100, "##,##0")

                'txtEmployLAK.Text = Format(CDbl(90000), "##,##0")
                'txtEmployerLAK.Text = Format(CDbl(100000), "##,##0")

            End If

        txttotal_Befor.Text = Format(CDbl(txttest.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        txttest.Text = Format(CDbl(txttest.Text) - CDbl(txtEmployLAK.Text), "##,##0")
        If txtEmployLAK.Text > 0 Then
            'txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
            Load_sum_tax()
        End If
        Else
            txtpeple.Text = 0
            txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
            txttest.Text = Format(CDbl(txttest.Text) + CDbl(txtEmployLAK.Text), "##,##0")
            If txtEmployLAK.Text > 0 Then
                'txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
                Load_sum_tax()
            End If
            txtEmployLAK.Text = 0
            txtEmployerLAK.Text = 0
        End If
        'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtmoney_over.Text), "##,##0")
        If txtmoney_over.Text > 0 Then
            txtmoney_over.Text = Format(CDbl(txtmoney_over.Text), "##,##0")
            Load_sum_tax()
        End If
        If chk_tax.Checked = True Then
            Load_sum_tax()
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
        Else
            txtTax_money.Text = 0
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
        End If
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
    End Sub

    Private Sub txtEmployLAK_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployLAK.TextChanged

    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FG1_After.Rows = FG1_After.Rows + 1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If FG1_After.get_TextMatrix(FG1_After.Row, 1) = "" Then
            FG1_After.RemoveItem(FG1_After.Row)
            If FG1_After.Rows > 1 Then
                FG1_After.RemoveItem(FG1_After.Row)
            Else
                FG1_After.Rows = 1
                FG1_After.Rows = 2
            End If
        Else
            AccCD = FG1_After.get_TextMatrix(FG1_After.Row, 1)
            If MessageBox.Show("Do you want to cancle '" & AccCD & "' yes or no ?", "Cancle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If FG1_After.Rows > 1 Then
                    FG1_After.RemoveItem(FG.Row)
                Else
                    FG1_After.Rows = 1
                    FG1_After.Rows = 2
                End If
            End If
        End If
    End Sub

    Private Sub FG1_After_AfterEdit(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_AfterEditEvent) Handles FG1_After.AfterEdit
        sum3()
        FG1_After.set_TextMatrix(FG1_After.Row, 3, Format(CDbl(FG1_After.get_TextMatrix(FG1_After.Row, 3)), "#,##0"))

        If txtSum3.Text > 0 Then
            'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        End If
        'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
        'txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        ''txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        'If txtTotal_Other.Text > 0 Then
        '    txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
        '    Load_sum_tax()
        'End If

    End Sub

    Private Sub FG1_After_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG1_After.ClickEvent
        If FG1_After.Col = 3 Then
            FG1_After.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG1_After.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
        'FG.set_TextMatrix(FG.Row, 2, Format(CDbl(FG.get_TextMatrix(FG.Row, 2)), "#,##0"))
        sum3()

    End Sub

    Private Sub FG1_After_KeyPressEvent(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_KeyPressEvent) Handles FG1_After.KeyPressEvent
        If e.keyAscii = 13 Then
            sum3()
            If txtSum3.Text > 0 Then
                txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            End If
            'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
            'txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtTotal_Other.Text), "##,##0")
            'If txtTotal_Other.Text > 0 Then
            'txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
            'Load_sum_tax()
            'End If

        End If
    End Sub


    Private Sub FG1_After_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG1_After.SelChange
        If FG1_After.Col = 3 Then

            FG1_After.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG1_After.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
        sum3()
        If txtSum3.Text > 0 Then
            'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        End If
        'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        'txttest.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        'txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        'If txtTotal_Other.Text > 0 Then
        '    txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
        '    Load_sum_tax()
        'End If

    End Sub


    Private Sub FG2_After_AfterEdit(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_AfterEditEvent) Handles FG2_After.AfterEdit
        sum4()
        FG2_After.set_TextMatrix(FG2_After.Row, 3, Format(CDbl(FG2_After.get_TextMatrix(FG2_After.Row, 3)), "#,##0"))

        If txtSum3.Text > 0 Then
            'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        End If
        'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
        'txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        ''txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        'If txtTotal_Other.Text > 0 Then
        '    txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
        '    Load_sum_tax()
        'End If

    End Sub

    Private Sub FG2_After_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG2_After.ClickEvent
        If FG2_After.Col = 3 Then
            FG2_After.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG2_After.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
        'FG.set_TextMatrix(FG.Row, 2, Format(CDbl(FG.get_TextMatrix(FG.Row, 2)), "#,##0"))
        sum3()
    End Sub

    Private Sub FG2_After_KeyPressEvent(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_KeyPressEvent) Handles FG2_After.KeyPressEvent
        If e.keyAscii = 13 Then
            sum4()
            If txtSum3.Text > 0 Then
                'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            End If
            'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
            'txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtTotal_Other.Text), "##,##0")
            'If txtTotal_Other.Text > 0 Then
            'txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
            'Load_sum_tax()
            'End If

        End If
    End Sub

    Private Sub FG2_After_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG2_After.SelChange

        If FG2_After.Col = 3 Then

            FG2_After.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG2_After.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
        sum4()
        If txtSum3.Text > 0 Then
            'txtTotal_Other2.Text = Format(CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        End If

        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        'txttest.Text = Format(CDbl(txttest.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        'txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtTotal_Other.Text), "##,##0")
        'If txtTotal_Other.Text > 0 Then
        '    txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
        '    Load_sum_tax()
        'End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        FG2_After.Rows = FG2_After.Rows + 1
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If FG2_After.get_TextMatrix(FG2_After.Row, 1) = "" Then
            FG2_After.RemoveItem(FG2_After.Row)
            If FG2_After.Rows > 1 Then
                FG2_After.RemoveItem(FG2_After.Row)
            Else
                FG2_After.Rows = 1
                FG2_After.Rows = 2
            End If
        Else
            AccCD = FG2_After.get_TextMatrix(FG1_After.Row, 1)
            If MessageBox.Show("Do you want to cancle '" & AccCD & "' yes or no ?", "Cancle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If FG2_After.Rows > 1 Then
                    FG2_After.RemoveItem(FG.Row)
                Else
                    FG2_After.Rows = 1
                    FG2_After.Rows = 2
                End If
            End If
        End If
    End Sub
    Private Sub txtTotal_money_Curren_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal_money_Curren.TextChanged
        'txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtTotal_money_Curren.Text) / CDbl(txtRate.Text), "##,##0")
    End Sub



    Private Sub Chk_AGL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_AGL.CheckedChanged

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        '    Dim aa As String
        '    With RSC

        '        aa = "SELECT     AP_Salary.AtMonth, Person.Job_Level_Id, Person.Employ_Type, AP_Salary.Empoyee_Nm, Person.Fuul_Name,Person.Fuul_Name_E, " & _
        '                "  Person.Famiry_Name, AP_Salary.Department, AP_Salary.Contract_Type, AP_Salary.SalaryCurrency, AP_Salary.Salary, AP_Salary.Rate, " & _
        '                 " AP_Salary.RateDate, AP_Salary.MPerDayCurrent, AP_Salary.WDayOfMonth, AP_Salary.total_amount, AP_Salary.Employee_LAK, AP_Salary.Employer_LAK, " & _
        '                "  AP_Salary.MOvertimeTotal, AP_Salary.tax_type, AP_Salary.Money_Befor, AP_Salary.tax_money, AP_Salary.Money_After, AP_Salary.Housing_After, " & _
        '                "  AP_Salary.Money_Cut, AP_Salary.Net_Money, AP_Salary.AGL_Out, AP_Salary.AGL_In, AP_Salary.Unifron_Male + AP_Salary.Unifron_FeMale AS Unifron," & _
        '                "  AP_Salary.Total_Money_curr, Person.PersonID, AP_Salary.Sum_Addtional, AP_Salary.DayOfMonth, AP_Salary.Chk_Social, AP_Salary.Sum_Deducation, " & _
        '                "  AP_Salary.Total_Other_After, AP_Salary.Sum_Addtional_After, AP_Salary.Sum_Deducation_After, AP_Salary.Total_Money_curr_Exing, AP_Salary.Total_Other," & _
        '                "  AP_Salary.Bonus + AP_Salary.Total_Other_After AS Total_Other_After_Bonus, AP_Salary.Bonus " & _
        '               "  FROM         AP_Salary INNER JOIN" & _
        '               "   Person ON AP_Salary.PersonID = Person.PersonID where 1=1 and    month(AtMonth) ='" & Month(frmSalary_List.dt_month.Value) & "' and year(AtMonth) ='" & Year(frmSalary_List.dt_month.Value) & "' and Person.PersonID =N'" & txtid.Text & "' "

        '        Call LoadRs(aa, RSC)
        '        If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
        '        Dim Frm As New FrmPreview
        '        If Lang = True Then
        '            Dim Rpt As New Report_PaySlip
        '            Rpt.SetDataSource(RSC)
        '            Rpt.Refresh()
        '            Frm.CrystalReportViewer1.ReportSource = Rpt
        '        Else
        '            Dim Rpt As New Report_PaySlip
        '            Rpt.SetDataSource(RSC)
        '            Rpt.Refresh()
        '            Frm.CrystalReportViewer1.ReportSource = Rpt
        '        End If

        '        '=========================================================
        '        'Dim myText2 As CrystalDecisions.CrystalReports.Engine.TextObject
        '        'myText2 = CType(Rpt.ReportDefinition.ReportObjects.Item("Textc"), CrystalDecisions.CrystalReports.Engine.TextObject)
        '        'myText2.Text = "" & MDKHT & ""
        '        '=========================================================

        '        Frm.CrystalReportViewer.Zoom(100%)
        '        Frm.CrystalReportViewer1.DisplayGroupTree = False
        '        Frm.WindowState = FormWindowState.Maximized
        '        Frm.Show()
        '    End With
        '    If RSC.State = ConnectionState.Open Then RSC.Close()
    End Sub

    Private Sub chk_tax_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_tax.CheckedChanged
        If chk_tax.Checked = True Then
         
            txttotal_Befor.Text = Format(CDbl(txttest.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtTotal_Other.Text), "##,##0")
            txttest.Text = Format(CDbl(txttest.Text) - CDbl(txtEmployLAK.Text), "##,##0")
            If txtEmployLAK.Text > 0 Then
                'txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
                Load_sum_tax()
            End If
        Else
            txtTax_money.Text = 0
            txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtTotal_Other.Text), "##,##0")
            txttest.Text = Format(CDbl(txttest.Text) + CDbl(txtEmployLAK.Text), "##,##0")
            If txtEmployLAK.Text > 0 Then
                'txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
                Load_sum_tax()
            End If
           
        End If
        'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtmoney_over.Text), "##,##0")
        If txtmoney_over.Text > 0 Then
            txtmoney_over.Text = Format(CDbl(txtmoney_over.Text), "##,##0")
            Load_sum_tax()
        End If
        If chk_tax.Checked = True Then
            Load_sum_tax()
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
        Else
            txtTax_money.Text = 0
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")

        End If
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTotal_Other2.Text) + CDbl(txtTax_money.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTotal_Other2.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text), "##,##0")
        txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
    End Sub

    Private Sub txtSum4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSum4.KeyPress
        If e.KeyChar = Chr(13) Then
            txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
            txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
            txtSum4.Text = Format(CDbl(txtSum4.Text), "##,##0")
        End If
    End Sub

    Private Sub txtSum4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSum4.TextChanged

    End Sub

    Private Sub txtpercen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpercen.KeyPress
        If e.KeyChar = Chr(13) Then
            'If txtworday_month.Text > 30 Then MsgBox("Day of work canot bigger than 30!") : txtworday_month.Text = 22 : Exit Sub
            'txttotal_amount.Text = Format(CDbl(txtworday_month.Text) * CDbl(txtmoney_per_day.Text), "##,##0")
            'txtcost_living_total.Text = Format(CDbl(txtcost_living_day.Text) * CDbl(txtworday_month.Text), "##,##0")
            'txttotal_Befor.Text = CDbl(txtmoney_per_day.Text) * Format(CDbl(txtworday_month.Text), "##,##0")
            'txttotal_Befor.Text = Format(CDbl(txttotal_Befor.Text) + CDbl(txtcost_living_total.Text), "##,##0")
            Dim aa As String
            Dim rs As New ADODB.Recordset
            aa = "SELECT    * from  AP_Salary  WHERE    E_ID=N'" & txtid.Text & "'  "
            Call LoadRs(aa, rs)
            With rs
                If rs.RecordCount <> 0 Then

                    If chk_year_holiday.Checked = False Then
                        If .Fields("txtgroup_id").Value.ToString = "01" Then
                            If CDbl(txtworday_month.Text) > CDbl(79) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")

                                TextBox3.Text = 100
                            End If

                            If Format(CDbl(txtworday_month.Text), "##,##0.00") > CDbl(69) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(79) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 90 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 90
                            End If


                            If Format(CDbl(txtworday_month.Text), "##,##0.00") > CDbl(59) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(69) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 80 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 80
                            End If

                            If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(50) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(59) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 70 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 70
                            End If
                            If Format(CDbl(txtworday_month.Text), "##,##0.00") < CDbl(50) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 60 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 60
                            End If
                        End If


                        If .Fields("txtgroup_id").Value.ToString = "02" Then
                            If CDbl(txtworday_month.Text) >= CDbl(200) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 100
                            End If

                            If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(190) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(199) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 90 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 90
                            End If


                            If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(180) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(189) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 80 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 80
                            End If

                            If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(170) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(179) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 70 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 70
                            End If
                            If Format(CDbl(txtworday_month.Text), "##,##0.00") < CDbl(170) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 60 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 60
                            End If
                        End If


                        If .Fields("txtgroup_id").Value.ToString = "03" Then
                            If CDbl(txtworday_month.Text) >= CDbl(184) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 100
                            End If

                            If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(175) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(183) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 90 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 90
                            End If


                            If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(165) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(174) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 80 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 80
                            End If

                            If Format(CDbl(txtworday_month.Text), "##,##0.00") >= CDbl(155) And Format(CDbl(txtworday_month.Text), "##,##0.00") <= CDbl(164) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 70 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 70
                            End If
                            If Format(CDbl(txtworday_month.Text), "##,##0.00") < CDbl(155) Then
                                txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 60 / 100, "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                                txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                                txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                                TextBox3.Text = 60
                            End If

                        End If

                        If .Fields("txtgroup_id").Value.ToString = "04" Then
                            txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 50 / 100, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                            TextBox3.Text = 50
                        End If

                        If .Fields("txtgroup_id").Value.ToString = "05" Then
                            txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 95 / 100, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                            TextBox3.Text = 95

                        End If
                        '==========
                    Else
                        '=========
                        If .Fields("txtgroup_id").Value.ToString = "01" Then

                            txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        End If

                        If .Fields("txtgroup_id").Value.ToString = "02" Then

                            txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")

                        End If


                        If .Fields("txtgroup_id").Value.ToString = "03" Then

                            txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All + CDbl(txtTum_money.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        End If

                        If .Fields("txtgroup_id").Value.ToString = "04" Then
                            txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 50 / 100, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        End If

                        If .Fields("txtgroup_id").Value.ToString = "05" Then
                            txttotal_amount.Text = Format(CDbl(.Fields("txtsalary").Value) * Rate_All, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * 95 / 100, "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * Rate_All + CDbl(txtTum_money.Text), "##,##0")
                            txttotal_amount.Text = Format(CDbl(txttotal_amount.Text) * CDbl(txtpercen.Text) / 100, "##,##0")
                            txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text), "##,##0")
                        End If

                        '=============
                    End If


                End If
            End With





            'juskan()
            If ChkSocial.Checked = True Then
                If CDbl(txttotal_amount.Text) + txtmoney_over.Text < CDbl(2000000) Then
                    'txtEmployLAK.Text = Format(CDbl(txttotal_amount.Text) * 4.5 / 100, "##,##0")
                    'txtEmployerLAK.Text = Format(CDbl(txttotal_amount.Text) * 5 / 100, "##,##0")
                    txtEmployLAK.Text = Format(CDbl(CDbl(txttotal_amount.Text) + CDbl(txtmoney_over.Text)) * SSO_Employee / 100, "##,##0")
                    txtEmployerLAK.Text = Format(CDbl(CDbl(txttotal_amount.Text) + CDbl(txtmoney_over.Text)) * SSO_Employer / 100, "##,##0")
                Else
                    txtEmployLAK.Text = Format(CDbl(110000), "##,##0")
                    txtEmployerLAK.Text = Format(CDbl(120000), "##,##0")
                End If
            Else
                txtEmployLAK.Text = 0
                txtEmployerLAK.Text = 0
            End If
            'If Format(CDbl(txttotal_amount.Text), "##,##0.00") < CDbl(Tax_LAK1) Then
            '    'MsgBox("< 1000,000.00")
            'ElseIf Format(CDbl(txttotal_amount.Text), "##,##0.00") = CDbl(Tax_LAK1) Then

            '    'MsgBox("=1000,000.00")
            'End If
            txttest.Text = Format(CDbl(txttotal_Befor.Text), "##,##0.00")
            txttest.Text = Format(CDbl(txttotal_Befor.Text), "##,##0.00")

            If Format(CDbl(txttotal_amount.Text), "##,##0.00") > CDbl(Tax_LAK1) Or Format(CDbl(txttotal_amount.Text), "##,##0.00") <= CDbl(Tax_LAK2) Then
                If Format(CDbl(txttotal_amount.Text), "##,##0.00") > CDbl(Tax_LAK2) Then
                    Tax1_cut = CDbl(Tax_LAK2) - CDbl(Tax_LAK1)
                    Tax1_Sum = CDbl(Tax1_cut) * CDbl(Tax2) / 100
                    Tax2_Sum = 0
                    Tax3_Sum = 0
                    Tax4_Sum = 0
                    Tax5_Sum = 0
                    Tax6_Sum = 0
                    Tax7_Sum = 0
                Else
                    Tax1_cut = Format(CDbl(txttotal_amount.Text), "##,##0.00") - CDbl(Tax_LAK1)
                    Tax1_Sum = CDbl(Tax1_cut) * CDbl(Tax2) / 100
                    'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                    Tax2_Sum = 0
                    Tax3_Sum = 0
                    Tax4_Sum = 0
                    Tax5_Sum = 0
                    Tax6_Sum = 0
                    Tax7_Sum = 0
                End If
            End If

            If Format(CDbl(txttotal_amount.Text), "##,##0.00") > CDbl(Tax_LAK2) And Format(CDbl(txttotal_amount.Text), "##,##0.00") <= CDbl(Tax_LAK3) Then
                'If Format(CDbl(txttotal_amount.Text), "##,##0.00") > CDbl(Tax_LAK3) Then
                Tax2_cut = Format(CDbl(txttotal_amount.Text), "##,##0.00") - CDbl(Tax_LAK2)
                'Tax2_cut = CDbl(Tax_LAK3) - CDbl(Tax_LAK2)
                Tax2_Sum = CDbl(Tax2_cut) * CDbl(Tax3) / 100
                Tax3_Sum = 0
                Tax4_Sum = 0
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
            ElseIf Format(CDbl(txttotal_amount.Text), "##,##0.00") > CDbl(Tax_LAK3) Then
                Tax2_cut = CDbl(Tax_LAK3) - CDbl(Tax_LAK2)
                'Tax2_cut = Format(CDbl(txttotal_amount.Text), "##,##0.00") - CDbl(Tax_LAK2)
                Tax2_Sum = CDbl(Tax2_cut) * CDbl(Tax3) / 100
                'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                Tax3_Sum = 0
                Tax4_Sum = 0
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
                'End If
            End If

            If Format(CDbl(txttotal_amount.Text), "##,##0.00") > CDbl(Tax_LAK3) And Format(CDbl(txttotal_amount.Text), "##,##0.00") <= CDbl(Tax_LAK4) Then
                Tax3_cut = Format(CDbl(txttotal_amount.Text), "##,##0.00") - CDbl(Tax_LAK3)
                'If Format(CDbl(txttotal_amount.Text), "##,##0.00") > CDbl(Tax_LAK3) Then
                'Tax3_cut = CDbl(Tax_LAK4) - CDbl(Tax_LAK3)
                Tax3_Sum = CDbl(Tax3_cut) * CDbl(Tax4) / 100
                Tax4_Sum = 0
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
            ElseIf Format(CDbl(txttotal_amount.Text), "##,##0.00") > CDbl(Tax_LAK4) Then
                Tax3_cut = CDbl(Tax_LAK4) - CDbl(Tax_LAK3)
                'Tax3_cut = Format(CDbl(txttotal_amount.Text), "##,##0.00") - CDbl(Tax_LAK3)
                Tax3_Sum = CDbl(Tax3_cut) * CDbl(Tax4) / 100
                'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                Tax4_Sum = 0
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
                'End If
            End If

            If Format(CDbl(txttotal_amount.Text), "##,##0.00") > CDbl(Tax_LAK4) And Format(CDbl(txttotal_amount.Text), "##,##0.00") <= CDbl(Tax_LAK5) Then
                Tax4_cut = Format(CDbl(txttotal_amount.Text), "##,##0.00") - CDbl(Tax_LAK4)

                Tax4_Sum = CDbl(Tax4_cut) * CDbl(Tax5) / 100
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0
            ElseIf Format(CDbl(txttotal_amount.Text), "##,##0.00") > CDbl(Tax_LAK5) Then
                'Tax4_cut = Format(CDbl(txttotal_amount.Text), "##,##0.00") - CDbl(Tax_LAK4)
                Tax4_cut = CDbl(Tax_LAK5) - CDbl(Tax_LAK4)
                Tax4_Sum = CDbl(Tax4_cut) * CDbl(Tax5) / 100
                'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0

            End If

            If Format(CDbl(txttotal_amount.Text), "##,##0.00") > CDbl(Tax_LAK5) And Format(CDbl(txttotal_amount.Text), "##,##0.00") <= CDbl(Tax_LAK6) Then
                Tax5_cut = Format(CDbl(txttotal_amount.Text), "##,##0.00") - CDbl(Tax_LAK5)
                Tax5_Sum = CDbl(Tax5_cut) * CDbl(Tax6) / 100
                Tax6_Sum = 0
                Tax7_Sum = 0
            ElseIf Format(CDbl(txttotal_amount.Text), "##,##0.00") > CDbl(Tax_LAK6) Then
                'Tax5_cut = Format(CDbl(txttotal_amount.Text), "##,##0.00") - CDbl(Tax_LAK5)
                Tax5_cut = CDbl(Tax_LAK6) - CDbl(Tax_LAK5)
                Tax5_Sum = CDbl(Tax5_cut) * CDbl(Tax6) / 100
                'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
                Tax6_Sum = 0
                Tax7_Sum = 0

            End If

            If Format(CDbl(txttotal_amount.Text), "##,##0.00") > CDbl(Tax_LAK6) Then

                Tax6_cut = Format(CDbl(txttotal_amount.Text), "##,##0.00") - CDbl(Tax_LAK6)
                Tax6_Sum = CDbl(Tax6_cut) * CDbl(Tax7) / 100
                'txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text), "##,##0.00")
            End If
            If Format(CDbl(txttotal_amount.Text), "##,##0.00") < CDbl(Tax_LAK1) Then
                Tax1_Sum = 0
                Tax2_Sum = 0
                Tax3_Sum = 0
                Tax4_Sum = 0
                Tax5_Sum = 0
                Tax6_Sum = 0
                Tax7_Sum = 0

            End If


            txtTax_money.Text = CDbl(Tax1_Sum) + CDbl(Tax2_Sum) + CDbl(Tax3_Sum) + CDbl(Tax4_Sum) + CDbl(Tax5_Sum) + CDbl(Tax6_Sum)

            txttotal_after.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtTax_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")

            txtnet_money.Text = Format(CDbl(txttotal_after.Text), "##,##0")
            'txttest.Text = Format(CDbl(txttotal_Befor.Text), "##,##0.00")
            If ChkSocial.Checked = True Then
                txttotal_Befor.Text = Format(CDbl(txttest.Text) - CDbl(txtEmployLAK.Text), "##,##0")
                txttest.Text = Format(CDbl(txttest.Text) - CDbl(txtEmployLAK.Text), "##,##0")
                If txtEmployLAK.Text > 0 Then
                    'txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
                    Load_sum_tax()
                End If
            Else
                txttotal_Befor.Text = Format(CDbl(txttotal_Befor.Text) + CDbl(txtEmployLAK.Text), "##,##0")
                txttest.Text = Format(CDbl(txttest.Text) + CDbl(txtEmployLAK.Text), "##,##0")
                If txtEmployLAK.Text > 0 Then
                    'txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
                    Load_sum_tax()
                End If

            End If

            txtovertime150.Focus()
            Call Sum_Item()
            Load_sum_tax()
            If chk_tax.Checked = True Then
                Load_sum_tax()
                txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
            Else
                txtTax_money.Text = 0
                txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
            End If
            txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")

            txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")


            txtworday_month.Focus()
        End If
    End Sub

    Private Sub txtpercen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpercen.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ChkSocial.Checked = True Then
            If ComboBox1.SelectedIndex = 0 Then
                txtpeple.Text = 1
                If CDbl(txttotal_amount.Text) + txtmoney_over.Text < CDbl(2000000) Then
                    txtEmployLAK.Text = Format(CDbl(CDbl(txttotal_amount.Text) + CDbl(txtmoney_over.Text)) * SSO_Employee / 100, "##,##0")
                    txtEmployerLAK.Text = Format(CDbl(CDbl(txttotal_amount.Text) + CDbl(txtmoney_over.Text)) * SSO_Employer / 100, "##,##0")
                Else
                    txtEmployLAK.Text = Format(CDbl(110000), "##,##0")
                    txtEmployerLAK.Text = Format(CDbl(120000), "##,##0")
                End If
            Else
                txtpeple.Text = 2
                txtEmployLAK.Text = Format(CDbl(2000000) * 10 / 100, "##,##0")
                txtEmployerLAK.Text = Format(CDbl(2000000) * 10 / 100, "##,##0")

                'txtEmployLAK.Text = Format(CDbl(txttotal_amount.Text) * 10 / 100, "##,##0")
                'txtEmployerLAK.Text = Format(CDbl(txttotal_amount.Text) * 10 / 100, "##,##0")

                'txtEmployLAK.Text = Format(CDbl(90000), "##,##0")
                'txtEmployerLAK.Text = Format(CDbl(100000), "##,##0")

            End If

            txttotal_Befor.Text = Format(CDbl(txttest.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
            txttest.Text = Format(CDbl(txttest.Text) - CDbl(txtEmployLAK.Text), "##,##0")
            If txtEmployLAK.Text > 0 Then
                'txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
                Load_sum_tax()
            End If
        Else
            txtpeple.Text = 0
            txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
            txttest.Text = Format(CDbl(txttest.Text) + CDbl(txtEmployLAK.Text), "##,##0")
            If txtEmployLAK.Text > 0 Then
                'txtother_T.Text = Format(CDbl(txtTotal_Other.Text), "##,##0")
                Load_sum_tax()
            End If
            txtEmployLAK.Text = 0
            txtEmployerLAK.Text = 0
        End If
        'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtmoney_over.Text), "##,##0")
        If txtmoney_over.Text > 0 Then
            txtmoney_over.Text = Format(CDbl(txtmoney_over.Text), "##,##0")
            Load_sum_tax()
        End If
        If chk_tax.Checked = True Then
            Load_sum_tax()
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
        Else
            txtTax_money.Text = 0
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
        End If
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
    End Sub

    Private Sub cmb_over_per_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_over_per.SelectedIndexChanged
        If txttotal_amount.Text = 0 Then Exit Sub
        'o150 = Format(CDbl(txtmoney_per_day.Text) / CDbl(Hour_Day) * 150 * Format(CDbl(txtovertime150.Text)) / 100, "##,##0")
        'o150 = Format(CDbl(txtovertime150.Text) * Format(CDbl(txtmoney_per_day.Text)), "##,##0")
        If chk_year_holiday.Checked = False Then
            o150 = Format(CDbl(txtovertime150.Text) * Format(CDbl(txtsalary.Text / txtdat_month.Text)), "##,##0")
            'o150 = Format(CDbl(o150)) * Format(CDbl(txtRate.Text), "##,##0")
        Else
            o150 = Format(CDbl(txtovertime150.Text) * Format(CDbl(txtsalary.Text * cmb_over_per.Text / 100)) / CDbl(txtdat_month.Text), "##,##0")
        End If


        txtmoney_over.Text = Format(CDbl(o150) + CDbl(o200) + Format(CDbl(o250)) + Format(CDbl(o300)) * ((txtRate.Text)), "##,##0")
        txtmoney_over.Text = Format(CDbl(txtmoney_over.Text) * CDbl(txtRate.Text), "##,##0")
        txtovertime200.Focus()

        If ChkSocial.Checked = True Then
            If ComboBox1.SelectedIndex = 0 Then
                txtpeple.Text = 1
                If CDbl(txttotal_amount.Text) + txtmoney_over.Text < CDbl(2000000) Then
                    txtEmployLAK.Text = Format(CDbl(CDbl(txttotal_amount.Text) + CDbl(txtmoney_over.Text)) * SSO_Employee / 100, "##,##0")
                    txtEmployerLAK.Text = Format(CDbl(CDbl(txttotal_amount.Text) + CDbl(txtmoney_over.Text)) * SSO_Employer / 100, "##,##0")
                Else
                    txtEmployLAK.Text = Format(CDbl(110000), "##,##0")
                    txtEmployerLAK.Text = Format(CDbl(120000), "##,##0")
                End If
            Else
                txtpeple.Text = 2
                txtEmployLAK.Text = Format(CDbl(2000000) * 10 / 100, "##,##0")
                txtEmployerLAK.Text = Format(CDbl(2000000) * 10 / 100, "##,##0")

            End If

        End If




        Load_sum_tax()

        'txttotal_Befor.Text = Format(CDbl(txttest.Text) + CDbl(txtmoney_over.Text), "##,##0")
        txttotal_Befor.Text = Format(CDbl(txttotal_amount.Text) - CDbl(txtEmployLAK.Text) + CDbl(txtmoney_over.Text) + CDbl(txtother_money.Text) + CDbl(txtSum1.Text) - CDbl(txtSum2.Text), "##,##0")
        If txtmoney_over.Text > 0 Then
            txtmoney_over.Text = Format(CDbl(txtmoney_over.Text), "##,##0")
            Load_sum_tax()
        End If
        Load_sum_tax()
        If chk_tax.Checked = True Then
            Load_sum_tax()
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text) - CDbl(txtTax_money.Text), "##,##0")
        Else
            txtTax_money.Text = 0
            txttotal_after.Text = Format(CDbl(txttotal_Befor.Text), "##,##0")
        End If
        txtnet_money.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtTax_money.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren.Text = Format(CDbl(txttotal_after.Text) + CDbl(txtAGL_ount.Text) + CDbl(txtAGL_in.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtTotal_money_Curren_Exiting.Text = Format(CDbl(txtnet_money.Text) / CDbl(txtRate.Text), "##,##0")
        txt_H_oertime.Text = Format(CDbl(txtovertime150.Text) + CDbl(txtovertime200.Text) + CDbl(txtovertime250.Text) + CDbl(txtovertime300.Text) + CDbl(txtSum3.Text) - CDbl(txtSum4.Text), "##,##0")
        txtSum4.Focus()
    End Sub
End Class