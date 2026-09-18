Public Class Frm_Birth_Data
    Dim rs As New ADODB.Recordset

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Call Addnew()
    End Sub
    Private Sub Addnew()
        FG.Rows = 1
        FG.Rows = 2
        txtvaccin2.Text = "01"
        txtvaccin1.Text = "02.01"
        txtMom_Symptom.SelectedIndex = 1
        txtBirth_Type.SelectedIndex = 0
        txt_Position.SelectedIndex = 0
        CmbNathong.SelectedIndex = 0
        txtUterus_Position.SelectedIndex = 0
        ComHopthong.SelectedIndex = 0
        CmbUterus.SelectedIndex = 0
        txt_HearthBeat.SelectedIndex = 0
        Cmbfish_Watter.SelectedIndex = 0
        CmbHearth_Baby.SelectedIndex = 0
        txt_HearthBeat.SelectedIndex = 0
        txtHopHov.Text = 0
        txtHopErk.Text = 0
        txt_Place.Text = ""
        txtDoctor_Name.Text = ""
        txtDeliver_Name.Text = ""
        RD1.Checked = True

        txt_Baby_Name.Text = ""
        txtBaby_Health.Text = ""
        txtABKA_1.Text = ""
        txtABKA_5.Text = ""
        txtInnormal.Text = ""

        txtGender.SelectedIndex = 0
        txtWeight.Text = "0"
        txtHeight.Text = "0"
        txtPregn_Age.Text = "0"
        txtSymptom.SelectedIndex = 1
        txtSymptom_Comment.Text = ""
        txtBlood_Pressure.SelectedIndex = 0
        txtBlood_Pressure2.SelectedIndex = 0
        txtrematk.Text = ""
        txtC.Text = 0
        chk_Vaccin1.Checked = False
        chk_Vaccin2.Checked = False
        ChkBaby_Daerth.Checked = False
        Chk_Mom_Dearth.Checked = False
        txtKamajone.Text = 0
        txtbaby_id.Text = ""
        Button4.Visible = True
        txtBar_Code.Text = ""
        'txt_TimeTh.SelectedIndex = 0
        txtBook_Id.Text = ""
        txtName.Text = ""

        txtStff_Id.Text = MUserID
        txtStff_NmL.Text = MUserName
        txtBill_no.Enabled = False
        txtBill_no.Text = ""
        If MWorkSetting = "" Then
            txt_dt.Value = Date.Today
        Else
            txt_dt.Value = MWorkSetting
        End If
        'txtrematk.Text = MDST
        Call AutoNumber()
        RunBarcode()
    End Sub

    Private Sub Frm_Birth_Data_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FG.FormatString = "ລ/ດ |<ເລກທີ                |<ລະຫັດປື້ມ       |<ບາໂຄດປື້ມ   |<ຊື່ ແລະນາມສະກຸນແມ່ |<ເບີໂທຕິດຕໍ່      |<ລະຫັດຂອງເດັກ  |<ບາໂຄດເດັກ      |<ຊື່ເດັກ           |^ວັນທີເກີດ     |^ເວລາເກີດ|^ສະຖານທີ່ເກີດ      |^ພະນັກງານແພດ|<ໝໍຕຳແຍທີ່ໄດ້ອົບຮົມ" & _
       "|^ຊ່ວຍເກີດໂດຍ..(ວິທີອື່ນໆ)|<ທຳມະດາ/ຜ່າຕັດ/ໃຊ້ເຄື່ອງມືຊ່ວຍ|<ເດັກແຂງແຮງ/ບໍ່ແຂງແຮງ/ບັດ|<ອາບກາ 1 ນາທີ|<ອາບກາ 5 ນາທີ|<ຜິດປົກກະຕິ|<ເພດ|<ນໍ້າໜັກ|<ລວງສູງ|<ອາຍຸຖືພາ|<ມີອາການສົນ|<ໝາຍເຫດ"
        txtvaccin2.Text = "01"
        txtvaccin1.Text = "02.01"
        txtvitaminK.Text = "09.01"
       
        If Mpermiss_ID = 2 Or Mpermiss_ID = 3 Then
            Call load_Cmb(" SELECT *  FROM AP_Location_ForCheck where   Locat_ID > 1  ORDER BY Locat_ID ", "Locat_nm", txt_Place)
            If txt_Place.Items.Count > 0 Then
                txt_Place.SelectedIndex = 0
            End If

        ElseIf Mpermiss_ID = 4 Or Mpermiss_ID = 5 Then
            Call load_Cmb(" SELECT *  FROM  AP_Location_ForCheck  where Locat_ID > 2  ORDER BY Locat_ID ", "Locat_nm", txt_Place)
            If txt_Place.Items.Count > 0 Then
                txt_Place.SelectedIndex = 0
            End If
        Else
            txt_Place.Enabled = True

            txt_Place.Items.Clear()
            Call load_Cmb(" SELECT *  FROM AP_Location_ForCheck where Locat_ID <2  ORDER BY Locat_ID ", "Locat_nm", txt_Place)
            If txt_Place.Items.Count > 0 Then
                txt_Place.SelectedIndex = 0
            End If
        End If

        If EditActive = False Then
            Call Addnew()
            
        Else
          

            Button4.Visible = False
            txtStff_Id.Text = MUserID
            txtStff_NmL.Text = MUserName
            Dim rs As New ADODB.Recordset
            Dim aa As String
            With rs
                aa = "SELECT    * from AP_Brith_Data  where   Book_id=N'" & Book_id & "' "
                Call LoadRs(aa, rs)
                If .RecordCount <> 0 Then
                    txt_dt.Text = (.Fields("B_Date").Value.ToString)
                    txtBook_Id.Text = (.Fields("Book_id").Value.ToString)
                    txtBar_Code.Text = (.Fields("Bar_Code").Value.ToString)
                    txtName.Text = (.Fields("M_Name").Value.ToString)
                End If
            End With
            Call LoadDat()
        End If
        'Call loaddata()
    End Sub
    Private Sub LoadDat()
        Dim rs As New ADODB.Recordset
        Dim aa As String
        txtBill_no.Enabled = False
        With rs
            aa = "SELECT     AP_Brith_Data_List.* ,  AP_Books.Mobile1 " & _
               " FROM         AP_Brith_Data_List INNER JOIN " & _
        "     AP_Books ON AP_Brith_Data_List.Book_id = AP_Books.Bill_no    where   AP_Brith_Data_List.Brith_no=N'" & SaleID & "' "
            Call LoadRs(aa, rs)

            If .RecordCount <> 0 Then


                txtBill_no.Text = (.Fields("Brith_no").Value.ToString)
                txt_dt.Text = (.Fields("B_Date").Value.ToString)
                txtBook_Id.Text = (.Fields("Book_id").Value.ToString)
                txtBar_Code.Text = (.Fields("Bar_Code").Value.ToString)
                txtName.Text = (.Fields("M_Name").Value.ToString)
                txtB_Time.Text = (.Fields("B_Time").Value.ToString)
                txt_Place_ID.Text = (.Fields("Place_id").Value.ToString)
                txt_Place.Text = (.Fields("Place").Value.ToString)
                txtHealth_ID.Text = (.Fields("Health_Service_id").Value.ToString)
                Cmb_Health.Text = (.Fields("Health_Service").Value.ToString)
                Cmb_HDist.Text = (.Fields("Health_Service").Value.ToString)
                txt_Dist_id.Text = (.Fields("Health_Service_id").Value.ToString)

                txtDoctor_Name.Text = (.Fields("Doctor_Name").Value.ToString)
                txtDeliver_Name.Text = (.Fields("Deliver_Name").Value.ToString)
                txtBirth_Tools.Text = (.Fields("Birth_Tools").Value.ToString)
                txtBirth_Type.Text = (.Fields("Birth_Type").Value.ToString)
                txtbaby_id.Text = (.Fields("Baby_ID").Value.ToString)
                txtBar_Code_Baby.Text = (.Fields("Bar_Code_Baby").Value.ToString)
                txt_Baby_Name.Text = (.Fields("Baby_Name").Value.ToString)
                txtABKA_1.Text = (.Fields("ABKA_1").Value.ToString)
                txtABKA_5.Text = (.Fields("ABKA_5").Value.ToString)
                CmbHearth_Baby.Text = (.Fields("Baby_Health").Value.ToString)
                txt_HearthBeat.Text = (.Fields("Baby_Health_Time").Value.ToString)
                txtWeight.Text = (.Fields("Weight").Value.ToString)
                txtHeight.Text = (.Fields("Height").Value.ToString)
                txtHopErk.Text = (.Fields("HopErk").Value.ToString)
                txtHopHov.Text = (.Fields("HopHov").Value.ToString)
                txtSymptom.Text = (.Fields("Symptom").Value.ToString)
                txtSymptom_Comment.Text = (.Fields("Symptom_Com").Value.ToString)
                txtGender.Text = (.Fields("Gender").Value.ToString)
                txtPregn_Age.Text = (.Fields("Pregn_Age").Value.ToString)
                txtC.Text = (.Fields("Temperature").Value.ToString)
                txtKamajone.Text = (.Fields("Kamajone").Value.ToString)
                txtBlood_Pressure.Text = (.Fields("Blood_Pressure1").Value.ToString)
                txtBlood_Pressure2.Text = (.Fields("Blood_Pressure2").Value.ToString)
                '========================================
                CmbNathong.Text = (.Fields("Nathong").Value.ToString)
                txtNathong_Comment.Text = (.Fields("Nathong_Com").Value.ToString)
                txtUterus_Position.Text = (.Fields("Uterus_Position").Value.ToString)
                ComHopthong.Text = (.Fields("Hopthong").Value.ToString)

                txt_Position.Text = (.Fields("Position").Value.ToString)
                txt_Position_Other.Text = (.Fields("Position_Com").Value.ToString)

                CmbUterus.Text = (.Fields("Uterus").Value.ToString)
                Cmbfish_Watter.Text = (.Fields("fish_Watter").Value.ToString)

                txtrematk.Text = (.Fields("Remark").Value.ToString)
                txtStff_Id.Text = (.Fields("Stff_Id").Value.ToString)
                txtMom_Symptom.Text = (.Fields("MomSymptom").Value.ToString)
                '=========
                txtLocat.Text = (.Fields("Moving_Service").Value.ToString)
                If .Fields("Moving_Service_id").Value.ToString = 1 Then
                    Chk_LBLocat.Checked = True
                Else
                    Chk_LBLocat.Checked = False
                    txtLocat.Text = ""
                End If

                If .Fields("Innormal_ID").Value.ToString = 1 Then
                    chk_Innormal.Checked = True
                    txtInnormal.Text = (.Fields("Innormal").Value.ToString)
                Else
                    chk_Innormal.Checked = False
                    txtInnormal.Text = ""
                End If
                If .Fields("Baby_Health_But").Value.ToString = 1 Then
                    RD1.Checked = True
                    txtbut.Text = (.Fields("Baby_Health_But_Time").Value.ToString)
                Else
                    RD2.Checked = True
                    txtbut.Text = "0"
                End If

                If .Fields("Vaccin1").Value.ToString = 1 Then
                    chk_Vaccin1.Checked = True
                Else
                    chk_Vaccin1.Checked = False
                End If
                If .Fields("Vaccin2").Value.ToString = 1 Then
                    chk_Vaccin2.Checked = True
                Else
                    chk_Vaccin2.Checked = False
                End If
                If .Fields("Baby_Eat_Milk").Value.ToString = 1 Then
                    chk_EatMil1.Checked = True
                Else
                    chk_EatMil1.Checked = False
                End If

                If .Fields("Baby_death").Value.ToString = 1 Then
                    ChkBaby_Daerth.Checked = True
                    CmbBaby_Daerth.Enabled = True
                    txtBaby_Daerth_why.Text = (.Fields("Baby_death_Why").Value.ToString)
                    CmbBaby_Daerth.Text = (.Fields("Baby_death_Type").Value.ToString)
                Else
                    CmbBaby_Daerth.Text = ""
                    CmbBaby_Daerth.Enabled = False
                    ChkBaby_Daerth.Checked = False
                End If

                If .Fields("Mom_Death_ID").Value.ToString = 1 Then
                    Chk_Mom_Dearth.Checked = True
                    CmbMomDaeth.Text = (.Fields("Mom_Death").Value.ToString)
                    txtMomDaet_Time.Text = (.Fields("Mom_Death_Time").Value.ToString)

                Else
                    Chk_Mom_Dearth.Checked = False
                    CmbMomDaeth.Text = ""

                    txtMomDaet_Time.Text = ""
                End If
                If .Fields("Have90Unit").Value.ToString = 1 Then
                    chk_90unit.Checked = True
                Else
                    chk_90unit.Checked = False
                End If
                If .Fields("VitaminK").Value.ToString = 1 Then
                    Chk_VitaminK.Checked = True
                Else
                    Chk_VitaminK.Checked = False
                End If

            End If
        End With
    End Sub





    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call RunBarcode()
    End Sub
    Private Sub RunBarcode()
        Dim tempEven As Long
        Dim tempOdd As Long
        Dim tempTotal
        Dim newBarCode As String
        Dim Checksum As Integer
        Dim Pos As Integer
        Randomize()
        newBarCode = Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10)
        For Pos = 2 To 12 Step 2
            tempEven = tempEven + Val(Mid(newBarCode, Pos, 1))
        Next
        For Pos = 1 To 11 Step 2
            tempOdd = tempOdd + Val(Mid(newBarCode, Pos, 1))
        Next
        tempEven = tempEven * 3
        tempTotal = tempOdd + tempEven
        Checksum = tempTotal Mod 10
        If Checksum > 0 Then
            Checksum = 10 - Checksum
        End If
        newBarCode = newBarCode & Checksum
        If Checksum <> Mid(newBarCode, 13, 1) Then
            MsgBox("ລະຫັດບາໂຄດທີ່ທ່າ¬ສັ່ງປະຕິບັດບໍ່ສາມາດ¬ນຳໃຊ້ໄດ້, ກະລຸ¬າສັ່ງໃໝ່ !", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Me.txtBar_Code_Baby.Text = newBarCode

        If (newBarCode) = "0" Then Me.txtBar_Code_Baby.Text = "" : RunBarcode()
        Dim Rschk As New ADODB.Recordset
        With Rschk
            Call LoadRs("Select Top 1  Bar_Code_Baby From AP_Brith_Data WHERE Bar_Code_Baby=N'" & newBarCode & "'", Rschk)
            If .RecordCount <> 0 Then txtBar_Code_Baby.Text = "" : RunBarcode()
        End With
    End Sub

    Private Sub txt_Age_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt_Age_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_Age_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtBook_Id_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBook_Id.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Book_id = " AND AP_Books.Bill_no=N'" & txtBook_Id.Text & "'"
                LoadData_BK()
                'Call loaddata_Cust()
        End Select
    End Sub
    Private Sub loaddata_Cust()
        Call LoadData_BK()
        If CustID <> "" Then
            Call LoadData_Count()
        End If
    End Sub

    Private Sub txtBook_Id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBook_Id.TextChanged

    End Sub
    Private Sub LoadData_BK()
        Dim rs As New ADODB.Recordset
        Dim sa As String
        With rs
            sa = " SELECT     dbo.AP_Books.*, dbo.AP_Village.Vl_nm " & _
                 " FROM         dbo.AP_Books INNER JOIN " & _
                 " dbo.AP_Village ON dbo.AP_Books.Vl_Id = dbo.AP_Village.Vl_ID  WHERE 1=1 " & Book_id & " AND Book_id='" & MDST & "' "
            Call LoadRs(sa, rs)
            If .RecordCount <> 0 Then
                txtBook_Id.Text = (.Fields("Bill_no").Value.ToString)
                txtName.Text = (.Fields("Cust_nm").Value.ToString)
                txtBar_Code.Text = (.Fields("Bar_Code").Value.ToString)
                CustID = (.Fields("Cust_nm").Value.ToString)

                txt_Baby_Name.Text = (.Fields("Baby_Name").Value.ToString)
                Button4.Visible = True
                AutoNumbe_Baby()
                AutoNumber()
                loaddata()
            End If
        End With

    End Sub
    Private Sub LoadData_Count()
        Dim rs As New ADODB.Recordset
        Dim sa As String
        With rs
            sa = " SELECT Count(TimeTh) As TimeTh From AP_Check  WHERE 1=1 AND  Cust_id=N'" & CustID & "' "
            Call LoadRs(sa, rs)
            If .RecordCount <> 0 Then
                Count_K = (.Fields("TimeTh").Value.ToString) + 1
                If Count_K < 6 Then
                    If Count_K = 1 Then
                        txt_TimeTh.SelectedIndex = 1
                    ElseIf Count_K = 2 Then
                        txt_TimeTh.SelectedIndex = 2
                    ElseIf Count_K = 3 Then
                        txt_TimeTh.SelectedIndex = 3
                    ElseIf Count_K = 4 Then
                        txt_TimeTh.SelectedIndex = 4
                    ElseIf Count_K = 5 Then
                        txt_TimeTh.SelectedIndex = 5
                    End If
                Else
                    MsgBox("ກະລຸນາກວດສອບການສັກຢາຂອງທ່ານຄືນໃໝ່")
                    Call Addnew()
                    Exit Sub

                End If

            Else


            End If
        End With

    End Sub


    Private Sub txt_Height_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_Profession_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtWork_Add_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_Dad_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_Baby_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_BabyTh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If txtName.Text = "" Then MsgBox("ກະລຸນາເລືອກລູກຄ້າກ່ອນ !", MsgBoxStyle.OkOnly) : txtName.Focus() : Exit Sub
        If txtBook_Id.Text = "" Then MsgBox("ກະລຸນາໃສ່ເລກທີ່ປື້ມກ່ອນ !", MsgBoxStyle.OkOnly) : txtBook_Id.Focus() : Exit Sub
        If txtBill_no.Text = "" Then
            Call AutoNumber()
        End If
        'Dim rss As New ADODB.Recordset
        'Call LoadRs("SELECT Book_id FROM AP_Brith_Data_List WHERE Book_id = '" & txtBook_Id.Text & "'", rss)
        'If rss.RecordCount = 0 Then


        'End If
        Call save()
        Call Save_item()
        save_baby()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
        loaddata()

    End Sub


    Private Sub save_baby()
        Dim rss As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT Book_id FROM AP_Baby_Chart WHERE Baby_ID= '" & txtbaby_id.Text & "' ", rs)
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO  AP_Baby_Chart  (DT_in,Birth_Date, Book_id, Baby_ID, Bar_Code, Bar_Code_Baby ," & _
                             " Weight,Height,Remark, Stff_Id,office, Get_date, lst_usr, Pc_nm) " & _
                   " VALUES('" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                       " '" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                         " N'" & (txtBook_Id.Text) & "'," & _
                        " N'" & (txtbaby_id.Text) & "'," & _
                       " N'" & (txtBar_Code.Text) & "'," & _
                       " N'" & (txtBar_Code_Baby.Text) & "'," & _
                    " " & CDbl(txtWeight.Text) & "," & _
                      " " & CDbl(txtHeight.Text) & "," & _
                          " N'" & (txtrematk.Text) & "'," & _
                  " '" & (txtStff_Id.Text) & "'," & _
                    " N'" & (MDST) & "'," & _
                    " Getdate()," & _
                   " N'" & MUserName & "'," & _
                   " '" & MDServerName & "')")
            Else
                Conn.Execute("delete from  AP_Baby_Chart WHERE  Baby_ID= '" & txtbaby_id.Text & "' ")
                Conn.Execute("INSERT INTO  AP_Baby_Chart ( DT_in,Birth_Date, Book_id, Baby_ID, Bar_Code, Bar_Code_Baby," & _
                                 " Weight,Height,Remark, Stff_Id,office, Get_date, lst_usr, Pc_nm) " & _
                       " VALUES('" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                           " '" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                             " N'" & (txtBook_Id.Text) & "'," & _
                            " N'" & (txtbaby_id.Text) & "'," & _
                           " N'" & (txtBar_Code.Text) & "'," & _
                           " N'" & (txtBar_Code_Baby.Text) & "'," & _
                        " " & CDbl(txtWeight.Text) & "," & _
                          " " & CDbl(txtHeight.Text) & "," & _
                                " N'" & (txtrematk.Text) & "'," & _
                      " '" & (txtStff_Id.Text) & "'," & _
                        " N'" & (MDST) & "'," & _
                        " Getdate()," & _
                       " N'" & MUserName & "'," & _
                       " '" & MDServerName & "')")
            End If
        End With



    End Sub
    Private Sub save_Vaccin1()
        Dim rss As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT Bill_no FROM AP_Baby_Vaccin WHERE Vaccin_ID = '" & txtvaccin1.Text & "' and Baby_ID= '" & txtbaby_id.Text & "' ", rs)
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO  AP_Baby_Vaccin ( Vaccin_Date,Birth_Date, Book_id, Baby_ID, Bar_Code, Bar_Code_Baby,  Doctor," & _
                                 "Place_id,Place,Weight,Height,Vaccin_ID,Remark, Stff_Id,office, Get_date, lst_usr, Pc_nm) " & _
                   " VALUES('" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                   " '" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                         " N'" & (txtBook_Id.Text) & "'," & _
                       " N'" & (txtbaby_id.Text) & "'," & _
                       " N'" & (txtBar_Code.Text) & "'," & _
                       " N'" & (txtBar_Code_Baby.Text) & "'," & _
                               " N'" & (txtDoctor_Name.Text) & "'," & _
                                   " N'" & (txt_Place_ID.Text) & "'," & _
                                    " N'" & (txt_Place.Text) & "'," & _
                                      " " & CDbl(txtWeight.Text) & "," & _
                                        " " & CDbl(txtHeight.Text) & "," & _
                             " N'" & (txtvaccin1.Text) & "'," & _
                                     " N'" & (txtrematk.Text) & "'," & _
                            " '" & (txtStff_Id.Text) & "'," & _
                             " N'" & (MDST) & "'," & _
                    " Getdate()," & _
                   " N'" & MUserName & "'," & _
                   " '" & MDServerName & "')")
            Else
                Conn.Execute("delete from  AP_Baby_Vaccin WHERE Vaccin_ID = '" & txtvaccin1.Text & "' and Baby_ID= '" & txtbaby_id.Text & "' ")
                Conn.Execute("INSERT INTO  AP_Baby_Vaccin ( Vaccin_Date, Birth_Date,Book_id, Baby_ID, Bar_Code, Bar_Code_Baby,  Doctor," & _
                                   "Place_id,Place,Weight,Height,Vaccin_ID,Remark, Stff_Id,office, Get_date, lst_usr, Pc_nm) " & _
                     " VALUES('" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                           " '" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                           " N'" & (txtBook_Id.Text) & "'," & _
                         " N'" & (txtbaby_id.Text) & "'," & _
                         " N'" & (txtBar_Code.Text) & "'," & _
                         " N'" & (txtBar_Code_Baby.Text) & "'," & _
                                 " N'" & (txtDoctor_Name.Text) & "'," & _
                                         " N'" & (txt_Place_ID.Text) & "'," & _
                                      " N'" & (txt_Place.Text) & "'," & _
                                        " " & CDbl(txtWeight.Text) & "," & _
                                          " " & CDbl(txtHeight.Text) & "," & _
                               " N'" & (txtvaccin1.Text) & "'," & _
                                       " N'" & (txtrematk.Text) & "'," & _
                              " '" & (txtStff_Id.Text) & "'," & _
                               " N'" & (MDST) & "'," & _
                      " Getdate()," & _
                     " N'" & MUserName & "'," & _
                     " '" & MDServerName & "')")
            End If
        End With


        If txt_Place.Text = "ໂຮງໝໍສູນກາງ" Then
            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
                          " Health_Service_id=N'" & txtcenter_ID.Text & "'," & _
                " Health_Service=N'" & Cmb_Center.Text & "'" & _
                    "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")

        ElseIf txt_Place.Text = "ໂຮງໝໍເມືອງ" Then
            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
                          " Health_Service_id=N'" & txt_Dist_id.Text & "'," & _
                " Health_Service=N'" & Cmb_HDist.Text & "'" & _
                    "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")
        ElseIf txt_Place.Text = "ສຸກສາລາ" Then
            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
                        " Health_Service_id=N'" & txtHealth_ID.Text & "'," & _
              " Health_Service=N'" & Cmb_Health.Text & "'" & _
                  "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")
        ElseIf txt_Place.Text = "ຢູ່ບ້ານ ຫຼື ສະຖານທີອື່ນ" Then
            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
           " Health_Service=N'" & txtLocat.Text & "'" & _
             "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")
        ElseIf txt_Place.Text = "ໂຮງໝໍແຂວງ" Then

            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
                           " Health_Service_id=N'" & txtProv_id.Text & "'," & _
                 " Health_Service=N'" & Cmb_Prov.Text & "'" & _
                   "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")
        End If

    End Sub
    Private Sub save_Vaccin2()
        Dim rss As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT Bill_no FROM AP_Baby_Vaccin WHERE Vaccin_ID = '" & txtvaccin2.Text & "' and Baby_ID= '" & txtbaby_id.Text & "' ", rs)
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO  AP_Baby_Vaccin ( Vaccin_Date,Birth_Date, Book_id, Baby_ID, Bar_Code, Bar_Code_Baby,  Doctor," & _
                                 "Place_id,Place,Weight,Height,Vaccin_ID,Remark, Stff_Id,office, Get_date, lst_usr, Pc_nm) " & _
                   " VALUES('" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                       " '" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                         " N'" & (txtBook_Id.Text) & "'," & _
                                       " N'" & (txtbaby_id.Text) & "'," & _
                       " N'" & (txtBar_Code.Text) & "'," & _
                       " N'" & (txtBar_Code_Baby.Text) & "'," & _
                               " N'" & (txtDoctor_Name.Text) & "'," & _
                                " N'" & (txt_Place_ID.Text) & "'," & _
                                    " N'" & (txt_Place.Text) & "'," & _
                                      " " & CDbl(txtWeight.Text) & "," & _
                                        " " & CDbl(txtHeight.Text) & "," & _
                             " N'" & (txtvaccin2.Text) & "'," & _
                                " N'" & (txtrematk.Text) & "'," & _
                            " '" & (txtStff_Id.Text) & "'," & _
                             " N'" & (MDST) & "'," & _
                    " Getdate()," & _
                   " N'" & MUserName & "'," & _
                   " '" & MDServerName & "')")
            Else
                Conn.Execute("delete from  AP_Baby_Vaccin WHERE Vaccin_ID = '" & txtvaccin2.Text & "' and Baby_ID= '" & txtbaby_id.Text & "' ")
                Conn.Execute("INSERT INTO  AP_Baby_Vaccin ( Vaccin_Date, Birth_Date,Book_id, Baby_ID, Bar_Code, Bar_Code_Baby,  Doctor," & _
                               "Place_id,Place,Weight,Height,Vaccin_ID,Remark, Stff_Id,office, Get_date, lst_usr, Pc_nm) " & _
                 " VALUES('" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                   " '" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                       " N'" & (txtBook_Id.Text) & "'," & _
                     " N'" & (txtbaby_id.Text) & "'," & _
                     " N'" & (txtBar_Code.Text) & "'," & _
                     " N'" & (txtBar_Code_Baby.Text) & "'," & _
                             " N'" & (txtDoctor_Name.Text) & "'," & _
                                 " N'" & (txt_Place_ID.Text) & "'," & _
                                  " N'" & (txt_Place.Text) & "'," & _
                                    " " & CDbl(txtWeight.Text) & "," & _
                                      " " & CDbl(txtHeight.Text) & "," & _
                           " N'" & (txtvaccin2.Text) & "'," & _
                              " N'" & (txtrematk.Text) & "'," & _
                          " '" & (txtStff_Id.Text) & "'," & _
                           " N'" & (MDST) & "'," & _
                  " Getdate()," & _
                 " N'" & MUserName & "'," & _
                 " '" & MDServerName & "')")
            End If
        End With



        If txt_Place.Text = "ໂຮງໝໍສູນກາງ" Then
            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
                          " Health_Service_id=N'" & txtcenter_ID.Text & "'," & _
                " Health_Service=N'" & Cmb_Center.Text & "'" & _
                    "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")

        ElseIf txt_Place.Text = "ໂຮງໝໍເມືອງ" Then
            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
                          " Health_Service_id=N'" & txt_Dist_id.Text & "'," & _
                " Health_Service=N'" & Cmb_HDist.Text & "'" & _
                    "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")
        ElseIf txt_Place.Text = "ສຸກສາລາ" Then
            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
                        " Health_Service_id=N'" & txtHealth_ID.Text & "'," & _
              " Health_Service=N'" & Cmb_Health.Text & "'" & _
                  "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")
        ElseIf txt_Place.Text = "ຢູ່ບ້ານ ຫຼື ສະຖານທີອື່ນ" Then
            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
           " Health_Service=N'" & txtLocat.Text & "'" & _
             "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")
        ElseIf txt_Place.Text = "ໂຮງໝໍແຂວງ" Then

            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
                           " Health_Service_id=N'" & txtProv_id.Text & "'," & _
                 " Health_Service=N'" & Cmb_Prov.Text & "'" & _
                   "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")
        End If
    End Sub

    Private Sub save_Vaccin3()
        Dim rss As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT Bill_no FROM AP_Baby_Vaccin WHERE Vaccin_ID = '" & txtvitaminK.Text & "' and Baby_ID= '" & txtbaby_id.Text & "' ", rs)
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO  AP_Baby_Vaccin ( Vaccin_Date,Birth_Date, Book_id, Baby_ID, Bar_Code, Bar_Code_Baby,  Doctor," & _
                                 "Place_id,Place,Weight,Height,Vaccin_ID,Remark, Stff_Id,office, Get_date, lst_usr, Pc_nm) " & _
                   " VALUES('" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                       " '" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                         " N'" & (txtBook_Id.Text) & "'," & _
                                       " N'" & (txtbaby_id.Text) & "'," & _
                       " N'" & (txtBar_Code.Text) & "'," & _
                       " N'" & (txtBar_Code_Baby.Text) & "'," & _
                               " N'" & (txtDoctor_Name.Text) & "'," & _
                        " N'" & (txt_Place_ID.Text) & "'," & _
                                        " N'" & (txt_Place.Text) & "'," & _
                                      " " & CDbl(txtWeight.Text) & "," & _
                                        " " & CDbl(txtHeight.Text) & "," & _
                             " N'" & (txtvitaminK.Text) & "'," & _
                                " N'" & (txtrematk.Text) & "'," & _
                            " '" & (txtStff_Id.Text) & "'," & _
                             " N'" & (MDST) & "'," & _
                    " Getdate()," & _
                   " N'" & MUserName & "'," & _
                   " '" & MDServerName & "')")
            Else
                Conn.Execute("delete from  AP_Baby_Vaccin WHERE Vaccin_ID = '" & txtvitaminK.Text & "' and Baby_ID= '" & txtbaby_id.Text & "' ")
                Conn.Execute("INSERT INTO  AP_Baby_Vaccin ( Vaccin_Date, Birth_Date,Book_id, Baby_ID, Bar_Code, Bar_Code_Baby,  Doctor," & _
                               "Place_id,Place,Weight,Height,Vaccin_ID,Remark, Stff_Id,office, Get_date, lst_usr, Pc_nm) " & _
                 " VALUES('" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                   " '" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                       " N'" & (txtBook_Id.Text) & "'," & _
                     " N'" & (txtbaby_id.Text) & "'," & _
                     " N'" & (txtBar_Code.Text) & "'," & _
                     " N'" & (txtBar_Code_Baby.Text) & "'," & _
                             " N'" & (txtDoctor_Name.Text) & "'," & _
                                " N'" & (txt_Place_ID.Text) & "'," & _
                                  " N'" & (txt_Place.Text) & "'," & _
                                    " " & CDbl(txtWeight.Text) & "," & _
                                      " " & CDbl(txtHeight.Text) & "," & _
                           " N'" & (txtvitaminK.Text) & "'," & _
                              " N'" & (txtrematk.Text) & "'," & _
                          " '" & (txtStff_Id.Text) & "'," & _
                           " N'" & (MDST) & "'," & _
                  " Getdate()," & _
                 " N'" & MUserName & "'," & _
                 " '" & MDServerName & "')")
            End If
        End With


        If txt_Place.Text = "ໂຮງໝໍສູນກາງ" Then
            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
                          " Health_Service_id=N'" & txtcenter_ID.Text & "'," & _
                " Health_Service=N'" & Cmb_Center.Text & "'" & _
                    "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")

        ElseIf txt_Place.Text = "ໂຮງໝໍເມືອງ" Then
            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
                          " Health_Service_id=N'" & txt_Dist_id.Text & "'," & _
                " Health_Service=N'" & Cmb_HDist.Text & "'" & _
                    "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")
        ElseIf txt_Place.Text = "ສຸກສາລາ" Then
            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
                        " Health_Service_id=N'" & txtHealth_ID.Text & "'," & _
              " Health_Service=N'" & Cmb_Health.Text & "'" & _
                  "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")
        ElseIf txt_Place.Text = "ຢູ່ບ້ານ ຫຼື ສະຖານທີອື່ນ" Then
            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
           " Health_Service=N'" & txtLocat.Text & "'" & _
             "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")
        ElseIf txt_Place.Text = "ໂຮງໝໍແຂວງ" Then

            Conn.Execute(" UPDATE AP_Baby_Vaccin SET " & _
                           " Health_Service_id=N'" & txtProv_id.Text & "'," & _
                 " Health_Service=N'" & Cmb_Prov.Text & "'" & _
                   "WHERE AP_Baby_Vaccin.Baby_ID=N'" & txtbaby_id.Text & "' and  AP_Baby_Vaccin.Vaccin_Date='" & Format(CDate(txt_dt.Value), "yyyy-MM-dd") & "'")
        End If

    End Sub
    Private Sub loaddata()
        FG.Rows = 1
        With RSC
            Dim aa As String
            aa = "SELECT     AP_Brith_Data_List.Brith_no, AP_Brith_Data_List.B_Date, AP_Brith_Data_List.Book_id, AP_Brith_Data_List.Bar_Code, AP_Brith_Data_List.M_Name, AP_Brith_Data_List.Place, " & _
               "      AP_Brith_Data_List.B_Time, AP_Brith_Data_List.Doctor_Name, AP_Brith_Data_List.Deliver_Name, AP_Brith_Data_List.Birth_Tools,AP_Brith_Data_List.Birth_Type_id, AP_Brith_Data_List.Birth_Type, AP_Brith_Data_List.Baby_ID,  " & _
              "      AP_Brith_Data_List.Bar_Code_Baby,AP_Brith_Data_List.Baby_Name,AP_Brith_Data_List.Baby_Health_id,AP_Brith_Data_List.Baby_Health, AP_Brith_Data_List.ABKA_1, AP_Brith_Data_List.ABKA_5, AP_Brith_Data_List.Innormal, AP_Brith_Data_List.Gender, AP_Brith_Data_List.Weight,  " & _
          " AP_Brith_Data_List.Height, AP_Brith_Data_List.Pregn_Age, AP_Brith_Data_List.Symptom, AP_Brith_Data_List.Remark, AP_Brith_Data_List.Stff_Id, AP_Books.Mobile1 " & _
         "     FROM         AP_Brith_Data_List INNER JOIN " & _
             "        AP_Books ON AP_Brith_Data_List.Book_id = AP_Books.Bill_no  where   AP_Brith_Data_List.Book_id=N'" & txtBook_Id.Text & "' AND  AP_Brith_Data_List.office=N'" & MDST & "' ORDER BY  AP_Brith_Data_List.Brith_no "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    FG.AddItem(.AbsolutePosition & _
                                   Chr(9) & Trim((RSC.Fields("Brith_no").Value)) & _
                                 Chr(9) & Trim((RSC.Fields("Book_id").Value).ToString) & _
                                    Chr(9) & Trim((RSC.Fields("Bar_Code").Value).ToString) & _
                                         Chr(9) & Trim((RSC.Fields("M_Name").Value).ToString) & _
                                              Chr(9) & Trim((RSC.Fields("Mobile1").Value).ToString) & _
                                               Chr(9) & Trim((RSC.Fields("Baby_ID").Value).ToString) & _
                                             Chr(9) & Trim((RSC.Fields("Bar_Code_Baby").Value).ToString) & _
                                                   Chr(9) & Trim((RSC.Fields("Baby_Name").Value).ToString) & _
                                   Chr(9) & Format(CDate(RSC.Fields("B_Date").Value), "dd/MM/yyyy") & _
                                   Chr(9) & Trim((RSC.Fields("B_Time").Value).ToString) & _
                                   Chr(9) & Trim((RSC.Fields("Place").Value).ToString) & _
                                     Chr(9) & Trim((RSC.Fields("Doctor_Name").Value).ToString) & _
                                        Chr(9) & Trim((RSC.Fields("Deliver_Name").Value).ToString) & _
                                   Chr(9) & Trim((RSC.Fields("Birth_Tools").Value).ToString) & _
                                    Chr(9) & Trim((RSC.Fields("Birth_Type").Value).ToString) & _
                                               Chr(9) & Trim((RSC.Fields("Baby_Health").Value).ToString) & _
                                            Chr(9) & Trim((RSC.Fields("ABKA_1").Value).ToString) & _
                                               Chr(9) & Trim((RSC.Fields("ABKA_5").Value).ToString) & _
                                                  Chr(9) & Trim((RSC.Fields("Innormal").Value).ToString) & _
                                                     Chr(9) & Trim((RSC.Fields("Gender").Value).ToString) & _
                                                        Chr(9) & Trim((RSC.Fields("Weight").Value).ToString) & _
                                                           Chr(9) & Trim((RSC.Fields("Height").Value).ToString) & _
                                                               Chr(9) & Trim((RSC.Fields("Pregn_Age").Value).ToString) & _
                                                                   Chr(9) & Trim((RSC.Fields("Symptom").Value).ToString) & _
                                            Chr(9) & Trim((RSC.Fields("Remark").Value).ToString))

                    .MoveNext()
                End While

            End If
        End With

    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 Brith_no from AP_Brith_Data_List  where office=N'" & MDST & "' and Book_id=N'" & txtBook_Id.Text & "'    Order by Brith_no DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("Brith_no").Value, 10, 14)) + 1, "00000")
        Else
            VIOTNEW = "00001"

        End If
        txtBill_no.Text = txtBook_Id.Text & "-" & Trim(CStr(VIOTNEW.ToString))
    End Sub
    Private Sub Save_item()

        Dim rss As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT Brith_no FROM AP_Brith_Data_List WHERE Brith_no = '" & txtBill_no.Text & "'", rs)
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO AP_Brith_Data_List ( Brith_no, B_Date, Book_id, Bar_Code, M_Name,Place_id, Place, B_Time, Doctor_Name, Deliver_Name, Birth_Tools, Birth_Type_id, Birth_Type, " & _
                    "  Baby_ID, Bar_Code_Baby, Baby_Name,   Baby_Health_id, Baby_Health, Baby_Health_Time, ABKA_1, ABKA_5, " & _
                    "   Weight, Height, HopErk, HopHov, Gender, Pregn_Age, Temperature, Kamajone, Blood_Pressure1, Blood_Pressure2, Symptom_ID, Symptom, " & _
                  "    Symptom_Com, Remark,  Nathong_ID, Nathong, Nathong_Com, Position_ID, Position, Position_Com, " & _
                    "  Uterus_ID, Uterus,fish_Watter_ID,fish_Watter,Uterus_Position,Hopthong,MomSymptom_ID,MomSymptom,MomSymptom_Com,Stff_Id, office,Get_date, lst_usr, Pc_nm) " & _
                   " VALUES('" & (txtBill_no.Text) & "'," & _
                     " '" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                    " N'" & (txtBook_Id.Text) & "'," & _
                       " N'" & (txtBar_Code.Text) & "'," & _
                       " N'" & (txtName.Text) & "'," & _
                        " N'" & (txt_Place_ID.Text) & "'," & _
                            " N'" & (txt_Place.Text) & "'," & _
                          " N'" & (txtB_Time.Text) & "'," & _
                       " N'" & (txtDoctor_Name.Text) & "'," & _
                       " N'" & (txtDeliver_Name.Text) & "'," & _
                         " N'" & (txtBirth_Tools.Text) & "'," & _
                          " N'" & (txtBirth_Type_id.Text) & "'," & _
                        " N'" & (txtBirth_Type.Text) & "'," & _
                             " N'" & (txtbaby_id.Text) & "'," & _
                         " N'" & (txtBar_Code_Baby.Text) & "'," & _
                                   " N'" & (txt_Baby_Name.Text) & "'," & _
                                    " N'" & (txtHearth_Baby_Id.Text) & "'," & _
                        " N'" & (CmbHearth_Baby.Text) & "'," & _
                                 " " & CDbl(txt_HearthBeat.Text) & "," & _
                          " N'" & (txtABKA_1.Text) & "'," & _
                       " N'" & (txtABKA_5.Text) & "'," & _
                         " " & CDbl(txtWeight.Text) & "," & _
                           " " & CDbl(txtHeight.Text) & "," & _
                               " " & CDbl(txtHopErk.Text) & "," & _
                                   " " & CDbl(txtHopHov.Text) & "," & _
                                   " N'" & (txtGender.Text) & "'," & _
                           " " & CDbl(txtPregn_Age.Text) & "," & _
                             " " & CDbl(txtC.Text) & "," & _
                               " " & CDbl(txtKamajone.Text) & "," & _
                                 " " & CDbl(txtBlood_Pressure.Text) & "," & _
                                   " " & CDbl(txtBlood_Pressure2.Text) & "," & _
                                     " N'" & (txtSymptom_ID.Text) & "'," & _
                                        " N'" & (txtSymptom.Text) & "'," & _
                                              " N'" & (txtSymptom_Comment.Text) & "'," & _
                                             " N'" & (txtrematk.Text) & "'," & _
                                       " N'" & (txtNathong_ID.Text) & "'," & _
                                        " N'" & (CmbNathong.Text) & "'," & _
                                         " N'" & (txtNathong_Comment.Text) & "'," & _
                                         " N'" & (txt_Place_ID.Text) & "'," & _
                                        " N'" & (txt_Position.Text) & "'," & _
                                       " N'" & (txt_Position_Other.Text) & "'," & _
                                                " N'" & (CmbUterus_ID.Text) & "'," & _
                                        " N'" & (CmbUterus.Text) & "'," & _
                                                " N'" & (txtfish_Watter_ID.Text) & "'," & _
                                        " N'" & (Cmbfish_Watter.Text) & "'," & _
                                        " " & CDbl(txtUterus_Position.Text) & "," & _
                           " " & CDbl(ComHopthong.Text) & "," & _
                              " N'" & (txtMomSymptom_ID.Text) & "'," & _
                                             " N'" & (txtMom_Symptom.Text) & "'," & _
                                                   " N'" & (txtMom_Symptom_Comment.Text) & "'," & _
                            " '" & (txtStff_Id.Text) & "'," & _
                             " N'" & (MDST) & "'," & _
                    " Getdate()," & _
                   " N'" & MUserName & "'," & _
                   " '" & MDServerName & "')"
                Conn.Execute(aa)
            Else
                Conn.Execute("delete from AP_Brith_Data_List WHERE Brith_no= '" & (txtBill_no.Text) & "'")

                Dim aa As String
                aa = "INSERT INTO AP_Brith_Data_List ( Brith_no, B_Date, Book_id, Bar_Code, M_Name, Place_id,Place, B_Time, Doctor_Name, Deliver_Name, Birth_Tools, Birth_Type_id, Birth_Type, " & _
                    "  Baby_ID, Bar_Code_Baby, Baby_Name,   Baby_Health_id, Baby_Health, Baby_Health_Time, ABKA_1, ABKA_5, " & _
                    "   Weight, Height, HopErk, HopHov, Gender, Pregn_Age, Temperature, Kamajone, Blood_Pressure1, Blood_Pressure2, Symptom_ID, Symptom, " & _
                  "    Symptom_Com, Remark,  Nathong_ID, Nathong, Nathong_Com, Position_ID, Position, Position_Com, " & _
                    "  Uterus_ID, Uterus,fish_Watter_ID,fish_Watter,Uterus_Position,Hopthong,MomSymptom_ID,MomSymptom,MomSymptom_Com,Stff_Id, office,Get_date, lst_usr, Pc_nm) " & _
                   " VALUES('" & (txtBill_no.Text) & "'," & _
                     " '" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                    " N'" & (txtBook_Id.Text) & "'," & _
                       " N'" & (txtBar_Code.Text) & "'," & _
                       " N'" & (txtName.Text) & "'," & _
                          " N'" & (txt_Place_ID.Text) & "'," & _
                     " N'" & (txt_Place.Text) & "'," & _
                          " N'" & (txtB_Time.Text) & "'," & _
                       " N'" & (txtDoctor_Name.Text) & "'," & _
                       " N'" & (txtDeliver_Name.Text) & "'," & _
                         " N'" & (txtBirth_Tools.Text) & "'," & _
                          " N'" & (txtBirth_Type_id.Text) & "'," & _
                        " N'" & (txtBirth_Type.Text) & "'," & _
                             " N'" & (txtbaby_id.Text) & "'," & _
                         " N'" & (txtBar_Code_Baby.Text) & "'," & _
                                   " N'" & (txt_Baby_Name.Text) & "'," & _
                                    " N'" & (txtHearth_Baby_Id.Text) & "'," & _
                        " N'" & (CmbHearth_Baby.Text) & "'," & _
                                 " " & CDbl(txt_HearthBeat.Text) & "," & _
                          " N'" & (txtABKA_1.Text) & "'," & _
                       " N'" & (txtABKA_5.Text) & "'," & _
                         " " & CDbl(txtWeight.Text) & "," & _
                           " " & CDbl(txtHeight.Text) & "," & _
                               " " & CDbl(txtHopErk.Text) & "," & _
                                   " " & CDbl(txtHopHov.Text) & "," & _
                                   " N'" & (txtGender.Text) & "'," & _
                           " " & CDbl(txtPregn_Age.Text) & "," & _
                             " " & CDbl(txtC.Text) & "," & _
                               " " & CDbl(txtKamajone.Text) & "," & _
                                 " " & CDbl(txtBlood_Pressure.Text) & "," & _
                                   " " & CDbl(txtBlood_Pressure2.Text) & "," & _
                                     " N'" & (txtSymptom_ID.Text) & "'," & _
                                        " N'" & (txtSymptom.Text) & "'," & _
                                              " N'" & (txtSymptom_Comment.Text) & "'," & _
                                             " N'" & (txtrematk.Text) & "'," & _
                                       " N'" & (txtNathong_ID.Text) & "'," & _
                                        " N'" & (CmbNathong.Text) & "'," & _
                                         " N'" & (txtNathong_Comment.Text) & "'," & _
                                         " N'" & (txt_Place_ID.Text) & "'," & _
                                        " N'" & (txt_Position.Text) & "'," & _
                                       " N'" & (txt_Position_Other.Text) & "'," & _
                                                " N'" & (CmbUterus_ID.Text) & "'," & _
                                        " N'" & (CmbUterus.Text) & "'," & _
                                                " N'" & (txtfish_Watter_ID.Text) & "'," & _
                                        " N'" & (Cmbfish_Watter.Text) & "'," & _
                                        " " & CDbl(txtUterus_Position.Text) & "," & _
                           " " & CDbl(ComHopthong.Text) & "," & _
                              " N'" & (txtMomSymptom_ID.Text) & "'," & _
                                             " N'" & (txtMom_Symptom.Text) & "'," & _
                                                   " N'" & (txtMom_Symptom_Comment.Text) & "'," & _
                            " '" & (txtStff_Id.Text) & "'," & _
                             " N'" & (MDST) & "'," & _
                    " Getdate()," & _
                   " N'" & MUserName & "'," & _
                   " '" & MDServerName & "')"
                Conn.Execute(aa)
            End If
        End With
        'ສຸກຂະພາບເດັກ:
        If RD1.Checked = True Then
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Baby_Health_But=1 ," & _
                         " Baby_Health_But_Nm = N'" & RD1.Text & "'" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
        ElseIf RD2.Checked = True Then
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Baby_Health_But=2 ," & _
                       " Baby_Health_But_Nm = N'" & RD2.Text & "'," & _
                               " Baby_Health_But_Time = N'" & txtbut.Text & "'" & _
                          " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
        End If
        'ວັນທີເກີດ:
        Conn.Execute(" UPDATE AP_Books SET " & _
          " Birth_Date='" & Format(txt_dt.Value, "yyyy-MM-dd") & "'" & _
              " WHERE Bill_no= '" & (txtBook_Id.Text) & "'")

        'ສະຖານທີ່ເກີດ:
        If txt_Place.Text = "ໂຮງໝໍສູນກາງ" Then
            Conn.Execute(" UPDATE AP_Brith_Data_List SET " & _
                          " Health_Service_id=N'" & txtcenter_ID.Text & "'," & _
                " Health_Service=N'" & Cmb_Center.Text & "'" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'")

        ElseIf txt_Place.Text = "ໂຮງໝໍເມືອງ" Then
            Conn.Execute(" UPDATE AP_Brith_Data_List SET " & _
                          " Health_Service_id=N'" & txt_Dist_id.Text & "'," & _
                " Health_Service=N'" & Cmb_HDist.Text & "'" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'")
        ElseIf txt_Place.Text = "ສຸກສາລາ" Then
            Conn.Execute(" UPDATE AP_Brith_Data_List SET " & _
                        " Health_Service_id=N'" & txtHealth_ID.Text & "'," & _
              " Health_Service=N'" & Cmb_Health.Text & "'" & _
                  "WHERE Brith_no= '" & (txtBill_no.Text) & "'")
        ElseIf txt_Place.Text = "ຢູ່ບ້ານ ຫຼື ສະຖານທີອື່ນ" Then
            Conn.Execute(" UPDATE AP_Brith_Data_List SET " & _
           " Health_Service=N'" & txtLocat.Text & "'" & _
               " WHERE Brith_no= '" & (txtBill_no.Text) & "'")
        ElseIf txt_Place.Text = "ໂຮງໝໍແຂວງ" Then

            Conn.Execute(" UPDATE AP_Brith_Data_List SET " & _
                           " Health_Service_id=N'" & txtProv_id.Text & "'," & _
                 " Health_Service=N'" & Cmb_Prov.Text & "'" & _
                     " WHERE Brith_no= '" & (txtBill_no.Text) & "'")
        End If
        If Chk_LBLocat.Checked = True Then
            Conn.Execute(" UPDATE AP_Brith_Data_List SET " & _
             " Moving_Service_id=1,Moving_Service=N'" & txtLocat.Text & "'" & _
                  " WHERE Brith_no= '" & (txtBill_no.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_Brith_Data_List SET " & _
               " Moving_Service_id=0,Moving_Service=NULL" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'")
        End If



        'ຜິດປົກກະຕິຫຼືບ່(ແຈ້ງ):
        If chk_Innormal.Checked = True Then
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Innormal_ID=1 ," & _
                         " Innormal = N'" & txtInnormal.Text & "'" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
        Else
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Innormal_ID=0 ," & _
                         " Innormal =NULL" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
        End If

        If Chk_Mom_Dearth.Checked = True Then
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Mom_Death_ID=1 ," & _
                 " Mom_Death = N'" & CmbMomDaeth.Text & "'," & _
                         " Mom_Death_Time = N'" & txtMomDaet_Time.Text & "'" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
        Else
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Mom_Death_ID=0 ," & _
                              " Mom_Death =NULL ," & _
                                   " Mom_Death_Time =NULL" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
        End If
        If chk_90unit.Checked = True Then
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Have90Unit=1" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
        Else
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Have90Unit=0" & _
            " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
        End If

        If chk_Vaccin1.Checked = True Then
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Vaccin1=1" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
            Call save_Vaccin1()
        Else
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Vaccin1=0" & _
            " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
            Conn.Execute("delete from  AP_Baby_Vaccin WHERE Vaccin_ID = '" & txtvaccin1.Text & "' and Baby_ID= '" & txtbaby_id.Text & "' ")
        End If

        If chk_Vaccin2.Checked = True Then
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Vaccin2=1" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
            Call save_Vaccin2()
        Else
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Vaccin2=0" & _
            " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
            Conn.Execute("delete from  AP_Baby_Vaccin WHERE Vaccin_ID = '" & txtvaccin2.Text & "' and Baby_ID= '" & txtbaby_id.Text & "' ")
        End If


        If chk_EatMil1.Checked = True Then
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Baby_Eat_Milk=1" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
        Else
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Baby_Eat_Milk=0" & _
            " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
        End If
        If ChkBaby_Daerth.Checked = True Then
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Baby_death=1," & _
             " Baby_death_id = N'" & txtBaby_Daerth_id.Text & "'," & _
               " Baby_death_Type = N'" & CmbBaby_Daerth.Text & "'," & _
               " Baby_death_Why = N'" & txtBaby_Daerth_why.Text & "'" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)


        Else
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET Baby_death=0," & _
             " Baby_death_id = NULL," & _
              " Baby_death_Type = NULL," & _
               " Baby_death_Why = NULL" & _
            " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
        End If

        If Chk_VitaminK.Checked = True Then
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET VitaminK=1" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
            Call save_Vaccin3()
        Else
            Dim aa As String
            aa = " UPDATE AP_Brith_Data_List SET VitaminK=0" & _
            " WHERE Brith_no= '" & (txtBill_no.Text) & "'"
            Conn.Execute(aa)
            Conn.Execute("delete from  AP_Baby_Vaccin WHERE Vaccin_ID = '" & txtvitaminK.Text & "' and Baby_ID= '" & txtbaby_id.Text & "' ")
        End If

    End Sub

    Private Sub save()
        Dim rss As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT Brith_no FROM AP_Brith_Data WHERE Book_id = '" & txtBook_Id.Text & "'", rs)
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO AP_Brith_Data ( Brith_no, B_Date, Book_id, Bar_Code, M_Name, Place_id,Place, B_Time, Doctor_Name, Deliver_Name, Birth_Tools, Birth_Type_id, Birth_Type, " & _
                    "  Baby_ID, Bar_Code_Baby, Baby_Name,   Baby_Health_id, Baby_Health, Baby_Health_Time, ABKA_1, ABKA_5, " & _
                    "   Weight, Height, HopErk, HopHov, Gender, Pregn_Age, Temperature, Kamajone, Blood_Pressure1, Blood_Pressure2, Symptom_ID, Symptom, " & _
                  "    Symptom_Com, Remark,  Nathong_ID, Nathong, Nathong_Com, Position_ID, Position, Position_Com, " & _
                    "  Uterus_ID, Uterus,fish_Watter_ID,fish_Watter,MomSymptom_ID,MomSymptom,MomSymptom_Com, Stff_Id, office,Get_date, lst_usr, Pc_nm) " & _
                   " VALUES('" & (txtBill_no.Text) & "'," & _
                     " '" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                    " N'" & (txtBook_Id.Text) & "'," & _
                       " N'" & (txtBar_Code.Text) & "'," & _
                       " N'" & (txtName.Text) & "'," & _
                          " N'" & (txt_Place_ID.Text) & "'," & _
                     " N'" & (txt_Place.Text) & "'," & _
                          " N'" & (txtB_Time.Text) & "'," & _
                       " N'" & (txtDoctor_Name.Text) & "'," & _
                       " N'" & (txtDeliver_Name.Text) & "'," & _
                         " N'" & (txtBirth_Tools.Text) & "'," & _
                          " N'" & (txtBirth_Type_id.Text) & "'," & _
                        " N'" & (txtBirth_Type.Text) & "'," & _
                             " N'" & (txtbaby_id.Text) & "'," & _
                         " N'" & (txtBar_Code_Baby.Text) & "'," & _
                                   " N'" & (txt_Baby_Name.Text) & "'," & _
                                    " N'" & (txtHearth_Baby_Id.Text) & "'," & _
                        " N'" & (CmbHearth_Baby.Text) & "'," & _
                                 " " & CDbl(txt_HearthBeat.Text) & "," & _
                          " N'" & (txtABKA_1.Text) & "'," & _
                       " N'" & (txtABKA_5.Text) & "'," & _
                         " " & CDbl(txtWeight.Text) & "," & _
                           " " & CDbl(txtHeight.Text) & "," & _
                               " " & CDbl(txtHopErk.Text) & "," & _
                                   " " & CDbl(txtHopHov.Text) & "," & _
                                   " N'" & (txtGender.Text) & "'," & _
                           " " & CDbl(txtPregn_Age.Text) & "," & _
                             " " & CDbl(txtC.Text) & "," & _
                               " " & CDbl(txtKamajone.Text) & "," & _
                                 " " & CDbl(txtBlood_Pressure.Text) & "," & _
                                   " " & CDbl(txtBlood_Pressure2.Text) & "," & _
                                     " N'" & (txtSymptom_ID.Text) & "'," & _
                                        " N'" & (txtSymptom.Text) & "'," & _
                                              " N'" & (txtSymptom_Comment.Text) & "'," & _
                                             " N'" & (txtrematk.Text) & "'," & _
                                       " N'" & (txtNathong_ID.Text) & "'," & _
                                        " N'" & (CmbNathong.Text) & "'," & _
                                         " N'" & (txtNathong_Comment.Text) & "'," & _
                                         " N'" & (txt_Place_ID.Text) & "'," & _
                                        " N'" & (txt_Position.Text) & "'," & _
                                       " N'" & (txt_Position_Other.Text) & "'," & _
                                                " N'" & (CmbUterus_ID.Text) & "'," & _
                                        " N'" & (CmbUterus.Text) & "'," & _
                                                " N'" & (txtfish_Watter_ID.Text) & "'," & _
                                        " N'" & (Cmbfish_Watter.Text) & "'," & _
                                           " N'" & (txtMomSymptom_ID.Text) & "'," & _
                                             " N'" & (txtMom_Symptom.Text) & "'," & _
                                                   " N'" & (txtMom_Symptom_Comment.Text) & "'," & _
                            " '" & (txtStff_Id.Text) & "'," & _
                             " N'" & (MDST) & "'," & _
                    " Getdate()," & _
                   " N'" & MUserName & "'," & _
                   " '" & MDServerName & "')"
                Conn.Execute(aa)
            Else
                Conn.Execute("delete from AP_Brith_Data WHERE Book_id= '" & (txtBook_Id.Text) & "'")
                Dim aa As String
                aa = "INSERT INTO AP_Brith_Data ( Brith_no, B_Date, Book_id, Bar_Code, M_Name,Place_id, Place, B_Time, Doctor_Name, Deliver_Name, Birth_Tools, Birth_Type_id, Birth_Type, " & _
                   "  Baby_ID, Bar_Code_Baby, Baby_Name,   Baby_Health_id, Baby_Health, Baby_Health_Time, ABKA_1, ABKA_5, " & _
                   "   Weight, Height, HopErk, HopHov, Gender, Pregn_Age, Temperature, Kamajone, Blood_Pressure1, Blood_Pressure2, Symptom_ID, Symptom, " & _
                 "    Symptom_Com, Remark,  Nathong_ID, Nathong, Nathong_Com, Position_ID, Position, Position_Com, " & _
                   "  Uterus_ID, Uterus,fish_Watter_ID,fish_Watter,MomSymptom_ID,MomSymptom,MomSymptom_Com, Stff_Id, office,Get_date, lst_usr, Pc_nm) " & _
                  " VALUES('" & (txtBill_no.Text) & "'," & _
                    " '" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                   " N'" & (txtBook_Id.Text) & "'," & _
                      " N'" & (txtBar_Code.Text) & "'," & _
                      " N'" & (txtName.Text) & "'," & _
                              " N'" & (txt_Place_ID.Text) & "'," & _
                    " N'" & (txt_Place.Text) & "'," & _
                         " N'" & (txtB_Time.Text) & "'," & _
                      " N'" & (txtDoctor_Name.Text) & "'," & _
                      " N'" & (txtDeliver_Name.Text) & "'," & _
                        " N'" & (txtBirth_Tools.Text) & "'," & _
                         " N'" & (txtBirth_Type_id.Text) & "'," & _
                       " N'" & (txtBirth_Type.Text) & "'," & _
                            " N'" & (txtbaby_id.Text) & "'," & _
                        " N'" & (txtBar_Code_Baby.Text) & "'," & _
                                  " N'" & (txt_Baby_Name.Text) & "'," & _
                                   " N'" & (txtHearth_Baby_Id.Text) & "'," & _
                       " N'" & (CmbHearth_Baby.Text) & "'," & _
                                " " & CDbl(txt_HearthBeat.Text) & "," & _
                         " N'" & (txtABKA_1.Text) & "'," & _
                      " N'" & (txtABKA_5.Text) & "'," & _
                        " " & CDbl(txtWeight.Text) & "," & _
                          " " & CDbl(txtHeight.Text) & "," & _
                              " " & CDbl(txtHopErk.Text) & "," & _
                                  " " & CDbl(txtHopHov.Text) & "," & _
                                  " N'" & (txtGender.Text) & "'," & _
                          " " & CDbl(txtPregn_Age.Text) & "," & _
                            " " & CDbl(txtC.Text) & "," & _
                              " " & CDbl(txtKamajone.Text) & "," & _
                                " " & CDbl(txtBlood_Pressure.Text) & "," & _
                                  " " & CDbl(txtBlood_Pressure2.Text) & "," & _
                                    " N'" & (txtSymptom_ID.Text) & "'," & _
                                       " N'" & (txtSymptom.Text) & "'," & _
                                             " N'" & (txtSymptom_Comment.Text) & "'," & _
                                            " N'" & (txtrematk.Text) & "'," & _
                                      " N'" & (txtNathong_ID.Text) & "'," & _
                                       " N'" & (CmbNathong.Text) & "'," & _
                                        " N'" & (txtNathong_Comment.Text) & "'," & _
                                        " N'" & (txt_Place_ID.Text) & "'," & _
                                       " N'" & (txt_Position.Text) & "'," & _
                                      " N'" & (txt_Position_Other.Text) & "'," & _
                                               " N'" & (CmbUterus_ID.Text) & "'," & _
                                       " N'" & (CmbUterus.Text) & "'," & _
                                               " N'" & (txtfish_Watter_ID.Text) & "'," & _
                                       " N'" & (Cmbfish_Watter.Text) & "'," & _
                                          " N'" & (txtMomSymptom_ID.Text) & "'," & _
                                            " N'" & (txtMom_Symptom.Text) & "'," & _
                                                  " N'" & (txtMom_Symptom_Comment.Text) & "'," & _
                           " '" & (txtStff_Id.Text) & "'," & _
                            " N'" & (MDST) & "'," & _
                   " Getdate()," & _
                  " N'" & MUserName & "'," & _
                  " '" & MDServerName & "')"

                Conn.Execute(aa)

            End If
        End With

        
        If txt_Place.Text = "ໂຮງໝໍສູນກາງ" Then
            Conn.Execute(" UPDATE AP_Brith_Data SET " & _
                          " Health_Service_id=N'" & txtcenter_ID.Text & "'," & _
                " Health_Service=N'" & Cmb_Center.Text & "'" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'")

        ElseIf txt_Place.Text = "ໂຮງໝໍເມືອງ" Then
            Conn.Execute(" UPDATE AP_Brith_Data SET " & _
                          " Health_Service_id=N'" & txt_Dist_id.Text & "'," & _
                " Health_Service=N'" & Cmb_HDist.Text & "'" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'")
        ElseIf txt_Place.Text = "ສຸກສາລາ" Then
            Conn.Execute(" UPDATE AP_Brith_Data SET " & _
                        " Health_Service_id=N'" & txtHealth_ID.Text & "'," & _
              " Health_Service=N'" & Cmb_Health.Text & "'" & _
                  " WHERE Brith_no= '" & (txtBill_no.Text) & "'")
        ElseIf txt_Place.Text = "ຢູ່ບ້ານ ຫຼື ສະຖານທີອື່ນ" Then
            Conn.Execute(" UPDATE AP_Brith_Data SET " & _
           " Health_Service=N'" & txtLocat.Text & "'" & _
               " WHERE Brith_no= '" & (txtBill_no.Text) & "'")
        ElseIf txt_Place.Text = "ໂຮງໝໍແຂວງ" Then

            Conn.Execute(" UPDATE AP_Brith_Data SET " & _
                           " Health_Service_id=N'" & txtProv_id.Text & "'," & _
                 " Health_Service=N'" & Cmb_Prov.Text & "'" & _
                     " WHERE Brith_no= '" & (txtBill_no.Text) & "'")
        End If

        If Chk_LBLocat.Checked = True Then
            Conn.Execute(" UPDATE AP_Brith_Data SET " & _
             " Moving_Service_id=1,Moving_Service=N'" & txtLocat.Text & "'" & _
                  " WHERE Brith_no= '" & (txtBill_no.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_Brith_Data SET " & _
               " Moving_Service_id=0,Moving_Service=NULL" & _
                    " WHERE Brith_no= '" & (txtBill_no.Text) & "'")
        End If
    End Sub

    Private Sub txt_Place_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrematk.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub txtBar_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBar_Code.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Book_id = " AND AP_Books.Bar_Code=N'" & txtBar_Code.Text & "'"
                'Call loaddata_Cust()
                LoadData_BK()
        End Select
    End Sub

    Private Sub txtBar_Code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBar_Code.TextChanged

    End Sub

    Private Sub txt_Mobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub txt_Position_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_Baby_Move_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBaby_Health.TextChanged

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub txt_Anaemic_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtABKA_1.TextChanged

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chk_next_day_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Vaccin2.CheckedChanged
        If chk_Vaccin2.Checked = True Then
            txtvaccin2.Text = "01"
       
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmCustomer_item.ShowDialog()
        If MDCusID = "" Then
            txtBook_Id.Focus() : Exit Sub
        Else
            txtBook_Id.Text = MDCusID

        End If

        Book_id = " AND AP_Books.Bill_no=N'" & CustID & "'"
        LoadData_BK()
        txtBook_Id.Focus()
    End Sub

    Private Sub txt_Pregn_Age_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chk_Birth_Date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Vaccin1.CheckedChanged
        If chk_Vaccin1.Checked = True Then
            txtvaccin1.Text = "02.01"
         
        End If
    End Sub

    Private Sub txtbaby_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbaby_id.TextChanged

    End Sub
    Private Sub AutoNumbe_Baby()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 Baby_ID from AP_Brith_Data where Book_id =N'" & txtBook_Id.Text & "' Order by Baby_ID DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("Baby_ID").Value, 10, 11)) + 1, "00")
        Else
            VIOTNEW = "01"

        End If
        txtbaby_id.Text = txtBook_Id.Text & "." & Trim(CStr(VIOTNEW.ToString))
    End Sub

    Private Sub txtBar_Code_Baby_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBar_Code_Baby.KeyDown
        'Select Case e.KeyCode
        '    Case Keys.Enter
        '        Book_id = " AND AP_Brith_Data.Bar_Code_Baby=N'" & txtBar_Code_Baby.Text & "'"
        '        'Call loaddata_Cust()
        '        LoadData_BK()
        'End Select
    End Sub

    Private Sub txtBar_Code_Baby_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBar_Code_Baby.TextChanged

    End Sub

    Private Sub txtBirth_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBirth_Type.SelectedIndexChanged
        If txtBirth_Type.SelectedIndex = 0 Then
            txtBirth_Type_id.Text = 1
        ElseIf txtBirth_Type.SelectedIndex = 1 Then
            txtBirth_Type_id.Text = 2
        Else
            txtBirth_Type_id.Text = 3

        End If
    End Sub

    Private Sub txtPlace_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Place.SelectedIndexChanged

        Call LoadRs("Select *  From AP_Location_ForCheck Where   Locat_nm =N'" & Trim(txt_Place.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txt_Place_ID.Text = Trim(rs("Locat_ID").Value)

        End If
        If txt_Place.Text = "ໂຮງໝໍແຂວງ" Then

            Cmb_Prov.Items.Clear()
            Call load_Cmb(" SELECT ProV_nm FROM AP_Users_Item  where Prov_Id=N'" & Prov_Id & "' and Usr_id=N'" & FrmLogin.txtUserID.Text & "'  ORDER BY ProV_id ", "ProV_nm", Cmb_Prov)
            If Cmb_Prov.Items.Count > 0 Then
                Cmb_Prov.SelectedIndex = 0
            End If
            Cmb_Prov.Visible = True

            Lab_Hdist.Visible = False
            Cmb_HDist.Visible = False

            Cmb_Health.Visible = False
            LBHS.Visible = False
            txtLocat.Visible = False
            Chk_LBLocat.Visible = False
            Cmb_Center.Visible = False
            Chk_LBLocat.Checked = False
        ElseIf txt_Place.Text = "ໂຮງໝໍເມືອງ" Then
            Cmb_HDist.Items.Clear()
            Call load_Cmb(" SELECT *  FROM AP_District where   PV_id =N'" & Trim(Prov_Id) & "' " & Dist & "   ORDER BY Dt_id ", "Dt_nm", Cmb_HDist)
            If Cmb_HDist.Items.Count > 0 Then
                Cmb_HDist.SelectedIndex = 0
            End If
            Cmb_Prov.Visible = False
            Lab_Hdist.Visible = True
            Cmb_HDist.Visible = True
            LBHS.Visible = False
            txtLocat.Visible = False
            Chk_LBLocat.Visible = False
            Chk_LBLocat.Checked = False
            Cmb_Center.Visible = False
            Cmb_Health.Visible = False
        ElseIf txt_Place.Text = "ສຸກສາລາ" Then
            Cmb_Health.Items.Clear()
            Call load_Cmb(" SELECT *  FROM AP_Health_Service  Where 1=1 " & Location_Dist_id & " ORDER BY Heal_ID ", "Health_Name", Cmb_Health)
            If Cmb_Health.Items.Count > 0 Then
                Cmb_Health.SelectedIndex = 0
            End If
            Cmb_Prov.Visible = False
            Cmb_Health.Visible = True
            LBHS.Visible = True
            txtLocat.Visible = True
            Chk_LBLocat.Visible = True
            Lab_Hdist.Visible = False
            Cmb_HDist.Visible = False
            Cmb_Center.Visible = False
        ElseIf txt_Place.Text = "ຢູ່ບ້ານ ຫຼື ສະຖານທີອື່ນ" Then
            Cmb_Prov.Visible = False
            Cmb_Health.Visible = False
            LBHS.Visible = False
            txtLocat.Visible = True
            Chk_LBLocat.Visible = True
            Lab_Hdist.Visible = False
            Cmb_HDist.Visible = False
            Cmb_Center.Visible = False
            Chk_LBLocat.Checked = False
        ElseIf txt_Place.Text = "ໂຮງໝໍສູນກາງ" Then
            Cmb_Center.Items.Clear()
            Call load_Cmb(" SELECT *  FROM AP_Location_Hos_Center where BK_ID='" & MDST & "'    ORDER BY Hos_id ", "Bk_nm", Cmb_Center)
            If Cmb_Center.Items.Count > 0 Then
                Cmb_Center.SelectedIndex = 0
            End If
            Cmb_Center.Visible = True

            Lab_Hdist.Visible = False
            Cmb_HDist.Visible = False
            Cmb_Prov.Visible = False
            Cmb_Health.Visible = False
            LBHS.Visible = False
            txtLocat.Visible = False
            Chk_LBLocat.Visible = False
            Chk_LBLocat.Checked = False
        End If
    End Sub

    Private Sub FG_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG.ClickEvent
        SaleID = FG.get_TextMatrix(FG.Row, 1)
    End Sub

    Private Sub FG_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG.DblClick
        Button4.Visible = False
        Call LoadDat()
    End Sub

    Private Sub FG_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG.SelChange

    End Sub

    Private Sub Cmb_Health_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Health.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Health_Service Where   Health_Name =N'" & Trim(Cmb_Health.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtHealth_ID.Text = Trim(rs("Heal_ID").Value)
        End If
    End Sub

    Private Sub RD2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RD2.CheckedChanged
        If RD2.Checked = True Then
            txtbut.Text = 0
            txtbut.Enabled = True
        Else
            txtbut.Enabled = False
            txtbut.Text = ""

        End If
    End Sub

    Private Sub txt_Position_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Position.SelectedIndexChanged
        If txt_Position.SelectedIndex = 0 Then
            txt_Position_ID.Text = "a"
            txt_Position_Other.Visible = False
            txt_Position_Other.Text = ""
        ElseIf txt_Position.SelectedIndex = 1 Then
            txt_Position_ID.Text = "b"
            txt_Position_Other.Visible = False
            txt_Position_Other.Text = ""

        ElseIf txt_Position.SelectedIndex = 2 Then
            txt_Position_ID.Text = "c"
            txt_Position_Other.Visible = False
            txt_Position_Other.Text = ""
        Else
            txt_Position_ID.Text = "d"
            txt_Position_Other.Visible = True
        End If
      
    End Sub

    Private Sub txtMomDaet_Time_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMomDaet_Time.TextChanged

    End Sub

    Private Sub ChkBaby_Daerth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBaby_Daerth.CheckedChanged
        If ChkBaby_Daerth.Checked = True Then
            txtBaby_Daerth_why.Enabled = True
            txtBaby_Daerth_why.Text = ""
            CmbBaby_Daerth.Enabled = True
            CmbBaby_Daerth.SelectedIndex = 0
            txtBaby_Daerth_id.Text = "a"
        Else
            txtBaby_Daerth_why.Enabled = False
            CmbBaby_Daerth.Enabled = False
            txtBaby_Daerth_why.Text = ""
            txtBaby_Daerth_id.Text = ""
            CmbBaby_Daerth.Text = ""
        End If
    End Sub

    Private Sub Chk_Mom_Dearth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Mom_Dearth.CheckedChanged
        If Chk_Mom_Dearth.Checked = True Then
            CmbMomDaeth.Enabled = True
            txtMomDaet_Time.Enabled = True
            txtMomDaet_Time.Text = 0

            CmbMomDaeth.SelectedIndex = 0
        Else
            CmbMomDaeth.Enabled = False
            txtMomDaet_Time.Enabled = False
            txtMomDaet_Time.Text = ""
            CmbMomDaeth.Text = ""
        End If
    End Sub

    Private Sub CmbNathong_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNathong.SelectedIndexChanged
        If CmbNathong.SelectedIndex = 0 Then
            txtNathong_ID.Text = "a"
            txtNathong_Comment.Visible = False
            txtNathong_Comment.Text = ""
        ElseIf CmbNathong.SelectedIndex = 1 Then
            txtNathong_ID.Text = "b"
            txtNathong_Comment.Visible = False
            txtNathong_Comment.Text = ""
        ElseIf CmbNathong.SelectedIndex = 2 Then
            txtNathong_ID.Text = "b"
            txtNathong_Comment.Visible = False
            txtNathong_Comment.Text = ""
        Else
            txtNathong_ID.Text = "d"
            txtNathong_Comment.Visible = True

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Innormal.CheckedChanged
        If chk_Innormal.Checked = True Then
            txtInnormal.Enabled = True
        Else
            txtInnormal.Enabled = False
            txtInnormal.Text = ""

        End If
    End Sub

    Private Sub CmbMomDaeth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMomDaeth.SelectedIndexChanged
        If CmbMomDaeth.SelectedIndex = 0 Then
            txtMomDaeth_id.Text = "a"
        Else
            txtMomDaeth_id.Text = "b"

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub txtBirth_Tools_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBirth_Tools.TextChanged

    End Sub

    Private Sub CmbUterus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbUterus.SelectedIndexChanged
        If CmbUterus.SelectedIndex = 0 Then
            CmbUterus_ID.Text = "a"
          
        ElseIf CmbUterus.SelectedIndex = 1 Then
            CmbUterus_ID.Text = "b"
       
        ElseIf CmbUterus.SelectedIndex = 2 Then
            CmbUterus_ID.Text = "c"
         
        Else
            CmbUterus_ID.Text = "d"


        End If
    End Sub

    Private Sub CmbHearth_Baby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbHearth_Baby.SelectedIndexChanged
        If CmbHearth_Baby.SelectedIndex = 0 Then
            txtHearth_Baby_Id.Text = "a"
        Else
            txtHearth_Baby_Id.Text = "b"

        End If
    End Sub

    Private Sub Cmbfish_Watter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbfish_Watter.SelectedIndexChanged
        If Cmbfish_Watter.SelectedIndex = 0 Then
            txtfish_Watter_ID.Text = "a"
        ElseIf Cmbfish_Watter.SelectedIndex = 1 Then
            txtfish_Watter_ID.Text = "b"
        ElseIf Cmbfish_Watter.SelectedIndex = 2 Then
            txtfish_Watter_ID.Text = "c"
        End If

    End Sub

    Private Sub txtSymptom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSymptom.SelectedIndexChanged
        If txtSymptom.SelectedIndex = 0 Then
            txtSymptom_ID.Text = "a"
        Else
            txtSymptom_ID.Text = "b"
        End If

    End Sub

    Private Sub txtGender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGender.SelectedIndexChanged

    End Sub

    Private Sub txtBlood_Pressure_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBlood_Pressure.SelectedIndexChanged

    End Sub

    Private Sub txtMom_Symptom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMom_Symptom.SelectedIndexChanged
        If txtMom_Symptom.SelectedIndex = 0 Then
            txtMomSymptom_ID.Text = "a"
        Else
            txtMomSymptom_ID.Text = "b"
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'If txtName.Text = "" Then MsgBox("ກະລຸນາເລືອກລູກຄ້າກ່ອນ !", MsgBoxStyle.OkOnly) : txtName.Focus() : Exit Sub
        If txtBook_Id.Text = "" Then MsgBox("ກະລຸນາໃສ່ເລກທີ່ປື້ມກ່ອນ !", MsgBoxStyle.OkOnly) : txtBook_Id.Focus() : Exit Sub

    End Sub

    Private Sub txtMomSymptom_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMomSymptom_ID.TextChanged

    End Sub

 
    Private Sub CmbBaby_Daerth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBaby_Daerth.SelectedIndexChanged
        If CmbBaby_Daerth.SelectedIndex = 0 Then
            txtBaby_Daerth_id.Text = "a"
        Else
            txtBaby_Daerth_id.Text = "b"
        End If
    End Sub

    Private Sub Cmb_HDist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_HDist.SelectedIndexChanged
        Dim rs As New ADODB.Recordset
        Call LoadRs("Select *  From AP_District Where   Dt_nm =N'" & Trim(Cmb_HDist.Text) & "' and  PV_id =N'" & Trim(Prov_Id) & "' ", rs)
        If rs.RecordCount > 0 Then
            txt_Dist_id.Text = Trim(rs("Dt_id").Value)
        End If
    End Sub

    Private Sub Cmb_Center_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Center.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Location_Hos_Center Where   Bk_nm =N'" & Trim(Cmb_Center.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtcenter_ID.Text = Trim(rs("Hos_id").Value)
        End If
    End Sub

    Private Sub Cmb_Prov_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Prov.SelectedIndexChanged
        Cmb_Prov.Items.Clear()
        Call LoadRs("Select *  From AP_Province Where   PV_nm =N'" & Trim(Cmb_Prov.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtProv_id.Text = Trim(rs("PV_ID").Value)

        End If
    End Sub

    Private Sub Chk_LBLocat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_LBLocat.CheckedChanged
        If Chk_LBLocat.Checked = True Then
            txtLocat.Enabled = True
        Else
            txtLocat.Enabled = False
        End If
    End Sub

    Private Sub txtBill_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBill_no.TextChanged

    End Sub
End Class