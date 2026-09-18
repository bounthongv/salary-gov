Public Class Frm_Books
    Dim rs As New ADODB.Recordset
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Call Addnew()

    End Sub
    Private Sub Addnew()
        Cmb_Tolet.SelectedIndex = 0
        CMB.SelectedIndex = 0
        FG.Rows = 1
        FG.Rows = 2
        txt_BabyTh.SelectedIndex = 0
        Chk_SSO.Checked = False
        Chk_SSO.Checked = False
        Chk_SSO.Checked = False
        txtcomment.Text = ""
        RDO1.Checked = True
        txtDate1.Text = ""
        txtDate2.Text = ""
        Cmb_Vaccin.SelectedIndex = 0
        txt_Unit.Text = ""
        txt_Mobail1.Text = ""
        txt_Mobail2.Text = ""
        txt_Baby_Name.Text = ""
        txt_BabyTh.Text = "1"
        txt_Dad_Name.Text = ""
        txtWork_Add.Text = ""
        txt_Profession.Text = ""
        txt_Height.Text = "0"
        txt_Age.Text = "0"
        txtBook_Id.Text = ""
        txtCust_ID.Text = ""
        txtCust_Nm.Text = ""
        txtStff_Id.Text = MUserID
        txtStff_NmL.Text = MUserName
        'txtBill_no.Enabled = False
        'txtBill_no.Text = ""
        If MWorkSetting = "" Then
            txt_dt.Value = Date.Today
            txt_DateofBirth_M.Value = Date.Today
            txt_Last_Date.Value = Date.Today
            txt_Expect_Date.Value = Date.Today
            txt_Birth_Date.Value = Date.Today
        Else
            txt_dt.Value = MWorkSetting
            txt_DateofBirth_M.Value = MWorkSetting
            txt_Last_Date.Value = MWorkSetting
            txt_Expect_Date.Value = MWorkSetting
            txt_Birth_Date.Value = MWorkSetting
        End If
        Call RunBarcode()

      
    End Sub

    Private Sub Frm_Books_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FG.FormatString = "ລ/ດ |^ເຂັມທີ  |^ວັນທີສັກ       |<ສະຖານທີ່ ແລະ ຊື່ ແພດສັກ "

        If MDWrite = 0 Then
            BtnAddNew.Enabled = False
        Else
            BtnAddNew.Enabled = True
        End If


      
        Cmb_Watter.Items.Clear()
        Call load_Cmb(" SELECT *  FROM Watter  ORDER BY Wat_ID ", "Watter", Cmb_Watter)
        If Cmb_Watter.Items.Count > 0 Then
            Cmb_Watter.SelectedIndex = 0
        End If

        TxtPV_NM.Items.Clear()
        Call load_Cmb(" SELECT PV_nm FROM AP_Province WHERE 1=1   AND PV_ID<>'00' ORDER BY PV_ID ", "PV_nm", TxtPV_NM)
        If TxtPV_NM.Items.Count > 0 Then
            TxtPV_NM.SelectedIndex = 0
        End If

        If Sym = "CT" Then
            txt_Bk_nm.Items.Clear()
            Call load_Cmb(" SELECT *  FROM AP_Location_Hos_Center where BK_ID='" & MDST & "'    ORDER BY Hos_id ", "Bk_nm", txt_Bk_nm)
            If txt_Bk_nm.Items.Count > 0 Then
                txt_Bk_nm.SelectedIndex = 0
            End If
            txt_Bk_ID.Text = FrmLogin.txtDepart_id.Text
            CheckBox6.Enabled = False
        Else
            txt_Bk_ID.Text = FrmLogin.txtDepart_id.Text
        
        

        End If
 


        If EditActive = False Then
            Call Addnew()
            Button4.Visible = True
            txtBar_Code.ReadOnly = True

        Else
            txtStff_Id.Text = MUserID
            txtStff_NmL.Text = MUserName
            Call LoadData()
            txtBar_Code.ReadOnly = False
            Button4.Visible = False
            edit_item()
        End If
    End Sub
    Private Sub LoadData()
        Dim rs As New ADODB.Recordset
        Dim sa As String
        txtBill_no.Enabled = False
        With rs
            sa = " SELECT     dbo.AP_Books.Bill_no, dbo.AP_Books.Bill_Dt, dbo.AP_Books.Stff_Id, dbo.AP_Books.Cust_nm, dbo.AP_Books.Book_id, dbo.AP_Books.Bar_Code, dbo.AP_Books.Age,AP_Books.Place_id,AP_Books.Place ,AP_Books.BirthM, " & _
                     " dbo.AP_Books.Height, dbo.AP_Books.Profession, dbo.AP_Books.Work_Add, dbo.AP_Books.Dad_Name, dbo.AP_Books.BabyTh, dbo.AP_Books.Baby_Name,AP_Books.Health_Service, " & _
                     " dbo.AP_Books.PV_id, dbo.AP_Books.Dt_ID, dbo.AP_Books.Vl_Id, dbo.AP_Books.Mobile1, dbo.AP_Books.Mobile2, dbo.AP_Books.Unit, dbo.AP_Books.Date_of_BirthM, " & _
                     " dbo.AP_Books.Last_Date, dbo.AP_Books.Expect_Date, dbo.AP_Books.Birth_Date, dbo.AP_Books.Remark, dbo.AP_Books.Get_date, dbo.AP_Books.lst_usr,AP_Books.Chk_SSO,AP_Books.Chk_SASS,AP_Books.Chk_SSO_S,AP_Books.Chk_PRF,AP_Books.Chk_other,AP_Books.AGL_Comment," & _
                     " dbo.AP_Books.Pc_nm, dbo.AP_Village.Vl_nm, dbo.AP_District.Dt_nm, dbo.AP_Province.PV_nm, dbo.AP_LocationBk.Bk_nm, dbo.AP_Books.Unit,AP_Books.Vaccin_Check,AP_Books.Vaccin_No,AP_Books.Vaccin_Date,AP_Books.Tolet_nm ,AP_Books.Tolet_ID,AP_Books.Tolet,AP_Books.Watter_id,AP_Books.Watter " & _
                     " FROM         dbo.AP_Books INNER JOIN " & _
                     " dbo.AP_Province ON dbo.AP_Books.PV_id = dbo.AP_Province.PV_ID INNER JOIN " & _
                     " dbo.AP_District ON dbo.AP_Books.Dt_ID = dbo.AP_District.Dt_id INNER JOIN " & _
                     " dbo.AP_Village ON dbo.AP_Books.Vl_Id = dbo.AP_Village.Vl_ID LEFT OUTER JOIN " & _
                     " dbo.AP_LocationBk ON dbo.AP_Books.Book_id = dbo.AP_LocationBk.BK_ID WHERE AP_Books.Bill_no='" & SaleID & "' AND Book_id='" & Book_id & "' "
            Call LoadRs(sa, rs)

            If rs.RecordCount <> 0 Then
                txtFG.Text = (rs.Fields("Vaccin_No").Value.ToString)
                txtCust_Nm.Text = (rs.Fields("Cust_nm").Value.ToString)
                txt_Bk_ID.Text = (rs.Fields("Book_id").Value.ToString)
                txtdist_id.Text = Trim(rs("Place_id").Value)
                txt_Bk_nm.Text = (rs.Fields("Place").Value.ToString)
                txtBar_Code.Text = (rs.Fields("Bar_Code").Value.ToString)
                txtBill_no.Text = (rs.Fields("Bill_no").Value.ToString)
                txt_dt.Text = (rs.Fields("Bill_Dt").Value.ToString)
                txt_Age.Text = (rs.Fields("Age").Value.ToString)
                txt_Height.Text = (rs.Fields("Height").Value.ToString)
                txt_Profession.Text = (rs.Fields("Profession").Value.ToString)
                txtWork_Add.Text = (rs.Fields("Work_Add").Value.ToString)
                txt_Dad_Name.Text = (rs.Fields("Dad_Name").Value.ToString)
                txt_BabyTh.Text = (rs.Fields("BabyTh").Value.ToString)
                txt_Baby_Name.Text = (rs.Fields("Baby_Name").Value.ToString)

                If (rs.Fields("Health_Service").Value.ToString) <> "" Then
                    CheckBox6.Checked = True
                    Cmb_Health.Text = (rs.Fields("Health_Service").Value.ToString)

                Else
                    CheckBox6.Checked = False
                End If

                If (rs.Fields("Date_of_BirthM").Value.ToString) <> "" Then
                    txt_DateofBirth_M.Value = (rs.Fields("Date_of_BirthM").Value.ToString)
                End If
                txt_Last_Date.Text = (rs.Fields("Last_Date").Value.ToString)
                txt_Expect_Date.Text = (rs.Fields("Expect_Date").Value.ToString)
                If (rs.Fields("Birth_Date").Value.ToString) <> "" Then
                    chk_Birth_Date.Checked = True
                End If
                If (rs.Fields("Vaccin_Check").Value.ToString) = 2 Then
                    RDO1.Checked = True
                    txtDate1.Text = (rs.Fields("Vaccin_Date").Value.ToString)
                    txtDate2.Text = ""
                    Cmb_Vaccin.SelectedIndex = 0
                Else
                    RDO2.Checked = True
                    Cmb_Vaccin.Text = (rs.Fields("Vaccin_No").Value.ToString)
                    txtDate2.Text = (rs.Fields("Vaccin_Date").Value.ToString)
                    txtDate1.Text = ""
                End If
                If (rs.Fields("Chk_SSO").Value.ToString) = "1" Then
                    Chk_SSO.Checked = True
                Else
                    Chk_SSO.Checked = False
                End If
                If (rs.Fields("Chk_SSO_S").Value.ToString) = "1" Then
                    Chk_SSO_S.Checked = True
                Else
                    Chk_SSO_S.Checked = False
                End If
                If (rs.Fields("Chk_SASS").Value.ToString) = "1" Then
                    Chk_SASS.Checked = True
                Else
                    Chk_SASS.Checked = False
                End If
                If (rs.Fields("Chk_PRF").Value.ToString) = "1" Then
                    Chk_PRF.Checked = True
                Else
                    Chk_PRF.Checked = False
                End If
                If (rs.Fields("Chk_other").Value.ToString) = "1" Then
                    Chk_other.Checked = True
                Else
                    Chk_other.Checked = False
                End If

                If (rs.Fields("BirthM").Value.ToString) = "1" Then
                    CHK_DOB_MOM.Checked = True
                Else
                    CHK_DOB_MOM.Checked = False
                End If


                txtcomment.Text = (rs.Fields("AGL_Comment").Value.ToString)

                txt_Birth_Date.Text = (rs.Fields("Birth_Date").Value.ToString)
                CMB.Text = (rs.Fields("Tolet_nm").Value.ToString)
                Cmb_Tolet.Text = (rs.Fields("Tolet").Value.ToString)
                Cmb_Watter.Text = (rs.Fields("Watter").Value.ToString)
    
                txt_Remark.Text = (rs.Fields("Remark").Value.ToString)
                txt_Mobail1.Text = (rs.Fields("Mobile1").Value.ToString)
                txt_Mobail2.Text = (rs.Fields("Mobile1").Value.ToString)
                txt_Unit.Text = (rs.Fields("Unit").Value.ToString)
                txtProvince.Text = (rs.Fields("PV_id").Value.ToString)
                TxtPV_NM.Text = (rs.Fields("PV_nm").Value.ToString)
                txtDistrict.Text = (rs.Fields("Dt_ID").Value.ToString)
                TxtDt_Nm.Text = (rs.Fields("Dt_nm").Value.ToString)
                txtVillage.Text = (rs.Fields("Vl_Id").Value.ToString)
                txtVillage_nm.Text = (rs.Fields("Vl_nm").Value.ToString)
            End If
        End With
    End Sub




    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        FrmCustomer_item.ShowDialog()
        If CustID = "" Then
            txtCust_ID.Focus() : Exit Sub
        Else
            txtCust_ID.Text = CustID
            txtCust_Nm.Text = CustNm
        End If
        Button4_Click(sender, e)
        txtBook_Id.Focus()
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
        Me.txtBar_Code.Text = newBarCode

        If (newBarCode) = "0" Then Me.txtBar_Code.Text = "" : RunBarcode()
        Dim Rschk As New ADODB.Recordset
        With Rschk
            Call LoadRs("Select Top 1  Bar_Code From AP_Books WHERE Bar_Code=N'" & newBarCode & "'", Rschk)
            If .RecordCount <> 0 Then txtBar_Code.Text = "" : RunBarcode()
        End With
    End Sub

    Private Sub txt_Age_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Age.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txt_Height.Focus()
        End Select

    End Sub

    Private Sub txt_Age_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Age.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                'txt_DateofBirth_M.Value = DateAdd(DateInterval.Year, -CDbl(txt_Age.Text), txt_DateofBirth_M.Value)
                e.Handled = True
        End Select
    End Sub

    Private Sub txt_Age_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Age.LostFocus

    End Sub

    Private Sub txt_Age_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Age.TextChanged

    End Sub

    Private Sub txtBook_Id_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBook_Id.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txt_Age.Focus()
        End Select

    End Sub

    Private Sub txtBook_Id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBook_Id.TextChanged

    End Sub

    Private Sub txt_Height_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Height.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txt_Profession.Focus()
        End Select

    End Sub

    Private Sub txt_Height_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Height.TextChanged

    End Sub

    Private Sub txt_Profession_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Profession.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtWork_Add.Focus()
        End Select

    End Sub

    Private Sub txt_Profession_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Profession.TextChanged

    End Sub

    Private Sub txtWork_Add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtWork_Add.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txt_Dad_Name.Focus()
        End Select

    End Sub

    Private Sub txtWork_Add_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWork_Add.TextChanged

    End Sub

    Private Sub txt_Dad_Name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Dad_Name.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txt_BabyTh.Focus()
        End Select

    End Sub

    Private Sub txt_Dad_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Dad_Name.TextChanged

    End Sub

    Private Sub txt_Baby_Name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Baby_Name.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txt_DateofBirth_M.Focus()
        End Select
    End Sub

    Private Sub txt_Baby_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Baby_Name.TextChanged

    End Sub

    Private Sub txt_BabyTh_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter
                txt_Baby_Name.Focus()
        End Select
    End Sub

    Private Sub txt_BabyTh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'If txtCust_ID.Text = "" Then MsgBox("ກະລຸນາເລືອກລູກຄ້າກ່ອນ !", MsgBoxStyle.OkOnly) : txtCust_ID.Focus() : Exit Sub
        If txt_Bk_ID.Text = "" Then MsgBox("ກະລຸນາໃສ່ເລກທີ່ປື້ມກ່ອນ !", MsgBoxStyle.OkOnly) : txt_Bk_ID.Focus() : Exit Sub
        If txtBill_no.Text = "" Then
         
        End If
        Call save()
        Conn.Execute("delete from  AP_Books_Item WHERE Bill_no = '" & txtBill_no.Text & "'")
        Save_item()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
    End Sub
    Private Sub Save_item()
        Dim ww As String
        Dim i As Integer
        Dim rss As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT Bill_no FROM AP_Books_Item WHERE Bill_no = '" & txtBill_no.Text & "'", rs)
            For i = 1 To FG.Rows - 1
                If .RecordCount = 0 Then
                    ww = " INSERT INTO  AP_Books_Item (  Bill_no, Vaccin_No, Vacin_Date, Docter_Nm)" & _
                        "VALUES( " & _
                            " '" & Trim(txtBill_no.Text.ToString) & "'," & _
                                  " N'" & FG.get_TextMatrix(i, 1) & "'," & _
                                      " N'" & FG.get_TextMatrix(i, 2) & "'," & _
                                    "N'" & FG.get_TextMatrix(i, 3) & "' )"
                    Conn.Execute(ww)
                End If
            Next i
        End With
    End Sub
    Private Sub edit_item()
        Dim aa As String
        Dim RSC As New ADODB.Recordset
        FG.Rows = 1
        With RSC
            aa = "SELECT  * from AP_Books_Item  where Bill_no = '" & txtBill_no.Text & "' order by Vaccin_No  "
            Call LoadRs(aa, RSC)
            If .RecordCount > 0 Then
                While Not .EOF
                    FG.AddItem(.AbsolutePosition & _
                          Chr(9) & .Fields("Vaccin_No").Value & _
                      Chr(9) & .Fields("Vacin_Date").Value & _
                            Chr(9) & .Fields("Docter_Nm").Value)
                    .MoveNext()
                End While
            Else
                FG.Rows = 2
            End If
        End With
    End Sub
    Private Sub AutoNumber_HSV()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 Bill_no from AP_Books Where Health_Service_id='" & txtHealth_ID.Text & "'  Order by Bill_no DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("Bill_no").Value, 8, 12)) + 1, "00000")
        Else
            VIOTNEW = "00001"

        End If
        txtBill_no.Text = txtProvince.Text & "-" & txtHealth_ID.Text & "-" & Trim(CStr(VIOTNEW.ToString))
    End Sub
    Private Sub AutoNumber_Dist()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 Bill_no from AP_Books Where Place_id='" & txtdist_id.Text & "'  Order by Bill_no DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("Bill_no").Value, 9, 13)) + 1, "00000")
        Else
            VIOTNEW = "00001"

        End If
        txtBill_no.Text = txtProvince.Text & "-" & txtdist_id.Text & "-" & Trim(CStr(VIOTNEW.ToString))
    End Sub
    Private Sub AutoNumber_pro()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 Bill_no from AP_Books Where Place_id='" & txtdist_id.Text & "'  Order by Bill_no DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("Bill_no").Value, 4, 8)) + 1, "00000")
        Else
            VIOTNEW = "00001"

        End If
        txtBill_no.Text = txtProvince.Text & "-" & Trim(CStr(VIOTNEW.ToString))
    End Sub

    Private Sub AutoNumber_Hcenter()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 Bill_no from AP_Books Where Book_id='" & txt_Bk_ID.Text & "'  Order by Bill_no DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("Bill_no").Value, 7, 11)) + 1, "00000")
        Else
            VIOTNEW = "00001"

        End If
        txtBill_no.Text = "01-" & FrmLogin.txtHost_id.Text & "-" & Trim(CStr(VIOTNEW.ToString))
    End Sub
    Private Sub save()
        Dim rss As New ADODB.Recordset
        With rs
            Call LoadRs("SELECT bill_no FROM AP_Books WHERE bill_no = '" & txtBill_no.Text & "' AND Book_id='" & txt_Bk_ID.Text & "'  ", rs)
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO AP_Books (  Bill_no, Bill_Dt, Stff_Id, Cust_nm, Dist_locat,Book_id, Bar_Code,Place_id,Place, Age, Height, Profession, Work_Add, Dad_Name, BabyTh, " & _
                             " Baby_Name, Date_of_BirthM, Last_Date, Expect_Date,PV_id,Dt_ID,Vl_Id,Mobile1,Mobile2,Unit,Tolet_Chk,Tolet_nm,Tolet_ID,Tolet,Watter_id,Watter,AGL_Comment, Remark, Vaccin_No,Get_date, lst_usr, Pc_nm) " & _
                   " VALUES('" & (txtBill_no.Text) & "'," & _
                     " '" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                       " '" & (txtStff_Id.Text) & "'," & _
                       " N'" & (txtCust_Nm.Text) & "'," & _
                          " N'" & (txtdist_id.Text) & "'," & _
                        " N'" & (txt_Bk_ID.Text) & "'," & _
                          " N'" & (txtBar_Code.Text) & "'," & _
                            " N'" & (txtdist_id.Text) & "'," & _
                      " N'" & (txt_Bk_nm.Text) & "'," & _
                             " " & CDbl(txt_Age.Text) & "," & _
                               " N'" & (txt_Height.Text) & "'," & _
                                " N'" & (txt_Profession.Text) & "'," & _
                                  " N'" & (txtWork_Add.Text) & "'," & _
                                  " N'" & (txt_Dad_Name.Text) & "'," & _
                                   " " & CDbl(txt_BabyTh.Text) & "," & _
                                    " N'" & (txt_Baby_Name.Text) & "'," & _
                                     " '" & Format(txt_DateofBirth_M.Value, "yyyy-MM-dd") & "'," & _
                                      " '" & Format(txt_Last_Date.Value, "yyyy-MM-dd") & "'," & _
                                       " '" & Format(txt_Expect_Date.Value, "yyyy-MM-dd") & "'," & _
                                           " N'" & (txtProvince.Text) & "'," & _
                                              " N'" & (txtDistrict.Text) & "'," & _
                                                 " N'" & (txtVillage.Text) & "'," & _
                                                     " N'" & (txt_Mobail1.Text) & "'," & _
                                                         " N'" & (txt_Mobail2.Text) & "'," & _
                                                             " N'" & (txt_Unit.Text) & "'," & _
                                                               " N'" & (txtchk.Text) & "'," & _
                                                                   " N'" & (CMB.Text) & "'," & _
                " N'" & (txtTolet_ID.Text) & "'," & _
                " N'" & (Cmb_Tolet.Text) & "'," & _
                " N'" & (txtWatter_ID.Text) & "'," & _
                " N'" & (Cmb_Watter.Text) & "'," & _
                  " N'" & (txtcomment.Text) & "'," & _
                   " N'" & (txt_Remark.Text) & "'," & _
                   " N'" & (txtFG.Text) & "'," & _
                   " Getdate()," & _
                   " N'" & MUserName & "'," & _
                   " '" & MDServerName & "')")

            Else

                Conn.Execute(" UPDATE AP_Books SET " & _
                            " Bill_Dt='" & Format(txt_dt.Value, "yyyy-MM-dd") & "'," & _
                            " Stff_Id='" & (txtStff_Id.Text) & "'," & _
                             " Cust_nm=N'" & (txtCust_Nm.Text) & "'," & _
                                   " Dist_locat=N'" & (txtdist_id.Text) & "'," & _
                             " Book_id=N'" & (txt_Bk_ID.Text) & "'," & _
                          " Bar_Code=N'" & (txtBar_Code.Text) & "'," & _
                           " Place_id=N'" & (txtdist_id.Text) & "'," & _
                            " Place=N'" & (txt_Bk_nm.Text) & "'," & _
                             " Age=" & CDbl(txt_Age.Text) & "," & _
                               " Height=N'" & (txt_Height.Text) & "'," & _
                                " Profession=N'" & (txt_Profession.Text) & "'," & _
                                  " Work_Add=N'" & (txtWork_Add.Text) & "'," & _
                                  " Dad_Name=N'" & (txt_Dad_Name.Text) & "'," & _
                                   " BabyTh=" & CDbl(txt_BabyTh.Text) & "," & _
                                    " Baby_Name=N'" & (txt_Baby_Name.Text) & "'," & _
                                                                         " Last_Date='" & Format(txt_Last_Date.Value, "yyyy-MM-dd") & "'," & _
                                       " Expect_Date='" & Format(txt_Expect_Date.Value, "yyyy-MM-dd") & "'," & _
                                                            " PV_id=N'" & (txtProvince.Text) & "'," & _
                                              " Dt_ID=N'" & (txtDistrict.Text) & "'," & _
                                                 " Vl_Id=N'" & (txtVillage.Text) & "'," & _
                                                    " Mobile1=N'" & (txt_Mobail1.Text) & "'," & _
                                                         " Mobile2=N'" & (txt_Mobail2.Text) & "'," & _
                                                            " Unit=N'" & (txt_Unit.Text) & "'," & _
                                                                  "Tolet_Chk=N'" & (txtchk.Text) & "'," & _
                    "Tolet_nm=N'" & (CMB.Text) & "'," & _
                          " Tolet_ID=N'" & (txtTolet_ID.Text) & "'," & _
                    " Tolet=N'" & (Cmb_Tolet.Text) & "'," & _
                      " Watter_id=N'" & (txtWatter_ID.Text) & "'," & _
                        " Watter=N'" & (Cmb_Watter.Text) & "'," & _
                          " AGL_Comment=N'" & (txtcomment.Text) & "'," & _
                             " Remark=N'" & (txt_Remark.Text) & "'," & _
                                  " Vaccin_No=N'" & (txtFG.Text) & "'," & _
                   " Get_date=Getdate()," & _
                     " lst_usr=N'" & MUserName & "'," & _
                   "pc_nm='" & MDServerName & "'" & _
                   "WHERE bill_no= '" & (txtBill_no.Text) & "'")
            End If

            If chk_Birth_Date.Checked = True Then
                Conn.Execute(" UPDATE AP_Books SET " & _
                    " Birth_Date='" & Format(txt_Birth_Date.Value, "yyyy-MM-dd") & "'" & _
                        "WHERE bill_no= '" & (txtBill_no.Text) & "'")
            Else
                Dim aa As String
                aa = " UPDATE AP_Books SET  Birth_Date =NULL" & _
                   " WHERE bill_no= '" & (txtBill_no.Text) & "'"
                Conn.Execute(aa)
            End If

            If CHK_DOB_MOM.Checked = True Then
                Conn.Execute(" UPDATE AP_Books SET BirthM=1, Date_of_BirthM='" & Format(txt_DateofBirth_M.Value, "yyyy-MM-dd") & "' " & _
                        "WHERE bill_no= '" & (txtBill_no.Text) & "'")
            Else
                Dim aa As String
                aa = " UPDATE AP_Books SET BirthM=0, Date_of_BirthM =NULL" & _
                        " WHERE bill_no= '" & (txtBill_no.Text) & "'"
                Conn.Execute(aa)
            End If
            If CMB.SelectedIndex = 1 Then
                Dim aa As String
                aa = " UPDATE AP_Books SET Tolet_ID =NULL ,Tolet=NULL " & _
                        " WHERE bill_no= '" & (txtBill_no.Text) & "'"
                Conn.Execute(aa)
            End If

            If RDO1.Checked = True Then
                Dim aa As String
                aa = " UPDATE AP_Books SET Vaccin_Check =1 " & _
                        " WHERE bill_no= '" & (txtBill_no.Text) & "'"
                Conn.Execute(aa)
            Else
                Dim aa As String
                aa = " UPDATE AP_Books SET Vaccin_Check =2 " & _
                                     " WHERE bill_no= '" & (txtBill_no.Text) & "'"
                Conn.Execute(aa)
            End If

            'If CheckBox6.Checked = True Then
            '    Conn.Execute(" UPDATE AP_Books SET " & _
            '                  " Place_id=N'" & txtHealth_ID.Text & "'," & _
            '             "WHERE bill_no= '" & (txtBill_no.Text) & "'")


            'End If

            If CheckBox6.Checked = True Then
                Conn.Execute(" UPDATE AP_Books SET " & _
                              " Health_Service_id=N'" & txtHealth_ID.Text & "'," & _
                    " Health_Service=N'" & Cmb_Health.Text & "'" & _
                        "WHERE bill_no= '" & (txtBill_no.Text) & "'")

            Else

                Dim aa As String
                aa = " UPDATE AP_Books SET  Health_Service =NULL" & _
                   " WHERE bill_no= '" & (txtBill_no.Text) & "'"
                Conn.Execute(aa)
            End If


            If Chk_SSO.Checked = True Then
                Conn.Execute(" UPDATE AP_Books SET  " & _
                    " Chk_SSO =1" & _
                        "WHERE bill_no= '" & (txtBill_no.Text) & "'")
            Else
                Conn.Execute(" UPDATE AP_Books SET  " & _
                                " Chk_SSO =0" & _
                                    "WHERE bill_no= '" & (txtBill_no.Text) & "'")
            End If

            If Chk_SASS.Checked = True Then
                Conn.Execute(" UPDATE AP_Books SET  " & _
                       " Chk_SASS =1" & _
                           "WHERE bill_no= '" & (txtBill_no.Text) & "'")
            Else
                Conn.Execute(" UPDATE AP_Books SET  " & _
                        " Chk_SASS =0" & _
                            "WHERE bill_no= '" & (txtBill_no.Text) & "'")
            End If

            If Chk_SSO_S.Checked = True Then
                Conn.Execute(" UPDATE AP_Books SET  " & _
                       " Chk_SSO_S =1" & _
                           "WHERE bill_no= '" & (txtBill_no.Text) & "'")
            Else
                Conn.Execute(" UPDATE AP_Books SET  " & _
                        " Chk_SSO_S =0" & _
                            "WHERE bill_no= '" & (txtBill_no.Text) & "'")
            End If

            If Chk_PRF.Checked = True Then
                Conn.Execute(" UPDATE AP_Books SET  " & _
                       " Chk_PRF =1" & _
                           "WHERE bill_no= '" & (txtBill_no.Text) & "'")
            Else
                Conn.Execute(" UPDATE AP_Books SET  " & _
                        " Chk_PRF =0" & _
                            "WHERE bill_no= '" & (txtBill_no.Text) & "'")
            End If

            If Chk_other.Checked = True Then
                Conn.Execute(" UPDATE AP_Books SET  " & _
                       " Chk_other =1" & _
                           "WHERE bill_no= '" & (txtBill_no.Text) & "'")
            Else
                Conn.Execute(" UPDATE AP_Books SET  " & _
                        " Chk_other =0" & _
                            "WHERE bill_no= '" & (txtBill_no.Text) & "'")
            End If
        End With

    End Sub

    Private Sub TxtPV_NM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPV_NM.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Province Where   PV_nm =N'" & Trim(TxtPV_NM.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtProvince.Text = Trim(rs("PV_ID").Value)
        End If


        TxtDt_Nm.Items.Clear()
        Call load_Cmb(" SELECT Dt_nm FROM AP_District  WHERE PV_ID='" & txtProvince.Text & "' ORDER BY Dt_id ", "Dt_nm", TxtDt_Nm)
        If TxtDt_Nm.Items.Count > 0 Then
            TxtDt_Nm.SelectedIndex = 0
        End If
    End Sub

    Private Sub TxtDt_Nm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDt_Nm.SelectedIndexChanged
        Call LoadRs("Select *  From AP_District Where   Dt_nm =N'" & Trim(TxtDt_Nm.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtDistrict.Text = Trim(rs("Dt_id").Value)
        End If


        txtVillage_nm.Items.Clear()
        Call load_Cmb(" SELECT * FROM AP_Village  WHERE Dt_id='" & txtDistrict.Text & "' ORDER BY Vl_ID ", "Vl_nm", txtVillage_nm)
        If txtVillage_nm.Items.Count > 0 Then
            txtVillage_nm.SelectedIndex = 0


        End If
    End Sub

    Private Sub txtVillage_nm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage_nm.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Village Where   Dt_id =N'" & Trim(txtDistrict.Text) & "'and   Vl_nm =N'" & Trim(txtVillage_nm.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtVillage.Text = Trim(rs("Vl_ID").Value)
        End If
    End Sub

    Private Sub txt_Bk_nm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Bk_nm.SelectedIndexChanged
        'Call LoadRs("Select *  From AP_LocationBk Where   Bk_nm =N'" & Trim(txt_Bk_nm.Text) & "'", rs)
        'If rs.RecordCount > 0 Then
        '    txt_Bk_ID.Text = Trim(rs("BK_ID").Value)
        '    txtdist_id.Text = Trim(rs("Dist_Id").Value)
        'AutoNumber()
        'AutoNumber_Hcenter()
        'End If
    End Sub

    Private Sub chk_Birth_Date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Birth_Date.CheckedChanged
        If chk_Birth_Date.Checked = True Then
            txt_Birth_Date.Enabled = True
        Else
            txt_Birth_Date.Enabled = False
        End If
    End Sub

    Private Sub txt_DateofBirth_M_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_DateofBirth_M.ValueChanged
        If CHK_DOB_MOM.Checked Then
            txt_Age.Text = DateDiff(DateInterval.Year, txt_DateofBirth_M.Value, Today)
        End If
    End Sub

    Private Sub txtBill_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBill_no.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub txtCust_Nm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCust_Nm.TextChanged

    End Sub

    Private Sub txtBar_Code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBar_Code.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SSO.CheckedChanged
        'If CheckBox1.Checked = True Then
        '    CheckBox2.Checked = False
        '    CheckBox3.Checked = False


        'End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SASS.CheckedChanged
        'If CheckBox2.Checked = True Then
        '    CheckBox1.Checked = False
        '    CheckBox3.Checked = False


        'End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_other.CheckedChanged
        If Chk_other.Checked = True Then
            'CheckBox2.Checked = False
            'CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button62.Click
        FG.Rows = FG.Rows + 1
    End Sub

    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button61.Click
        If FG.get_TextMatrix(FG.Row, 1) = "" Then
            FG.RemoveItem(FG.Row)
        Else
            AccCD = FG.get_TextMatrix(FG.Row, 1)
            If MessageBox.Show("Do you want to cancle '" & AccCD & "' yes or no ?", "Cancle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                FG.RemoveItem(FG.Row)
                If FG.Rows = 1 Then FG.Rows = 1
            End If
        End If
    End Sub

    Private Sub FG_AfterEdit(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_AfterEditEvent) Handles FG.AfterEdit
        If FG.get_TextMatrix(FG.Row, 1) = "" Then
            txtFG.Text = 0
        Else
            txtFG.Text = FG.Rows - 1
        End If

    End Sub

    Private Sub FG_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles FG.ClickEvent
        If FG.Col = 1 Or 2 Or 3 Then

            FG.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If
        If FG.get_TextMatrix(FG.Row, 1) = "" Then
            Exit Sub
        Else
            txtFG.Text = FG.Rows - 1
        End If

    End Sub

    Private Sub FG_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FG.SelChange
        If FG.Col = 1 Or 2 Or 3 Then

            FG.Editable = VSFlex8U.EditableSettings.flexEDKbdMouse
        Else
            FG.Editable = VSFlex8U.EditableSettings.flexEDNone
        End If

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then

            Cmb_Health.Items.Clear()
            Call load_Cmb(" SELECT *  FROM AP_Health_Service  Where 1=1 " & Location_Dist_id & "  ORDER BY Heal_ID ", "Health_Name", Cmb_Health)
            If Cmb_Health.Items.Count > 0 Then
                Cmb_Health.SelectedIndex = 0
            End If
            Cmb_Health.Enabled = True
        Else
            Cmb_Health.Items.Clear()
            Cmb_Health.Text = ""
            Cmb_Health.Enabled = False
         
        End If
    End Sub

    Private Sub Cmb_Health_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Health.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Health_Service Where   Health_Name =N'" & Trim(Cmb_Health.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtHealth_ID.Text = Trim(rs("Heal_ID").Value)
        End If

        If CheckBox6.Checked = True Then
            Dim VIOT As New ADODB.Recordset
            Dim VIOTNEW As String
            Call LoadRs("SELECT top 1 Bill_no from AP_Books Where Health_Service_id='" & txtHealth_ID.Text & "'  Order by Bill_no DESC", VIOT)
            If VIOT.RecordCount <> 0 Then
                VIOTNEW = Format(Val(Mid(VIOT.Fields("Bill_no").Value, 11, 15)) + 1, "00000")
            Else
                VIOTNEW = "00001"

            End If
            txtBill_no.Text = txtProvince.Text & "-" & txtHealth_ID.Text & "-" & Trim(CStr(VIOTNEW.ToString))
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SSO_S.CheckedChanged

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_PRF.CheckedChanged

    End Sub

    Private Sub Cmb_Watter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Watter.SelectedIndexChanged
        Call LoadRs("Select *  From Watter Where    Watter =N'" & Trim(Cmb_Watter.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            txtWatter_ID.Text = Trim(rs("Wat_ID").Value)
        End If
    End Sub

    Private Sub Cmb_Tolet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Tolet.SelectedIndexChanged
        If Cmb_Tolet.SelectedIndex = 0 Then
            txtTolet_ID.Text = "a"
        Else
            txtTolet_ID.Text = "b"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Frm_Watter.ShowDialog()
        Cmb_Watter.Items.Clear()
        Call load_Cmb(" SELECT *  FROM Watter  ORDER BY Wat_ID ", "Watter", Cmb_Watter)
        If Cmb_Watter.Items.Count > 0 Then
            Cmb_Watter.SelectedIndex = 0
        End If
    End Sub



    Private Sub CMB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB.SelectedIndexChanged
        If CMB.SelectedIndex = 0 Then
            Cmb_Tolet.Visible = True
            txtchk.Text = 1
        Else
            Cmb_Tolet.Visible = False
            'Cmb_Tolet.Text =""

            txtchk.Text = 0
        End If
    End Sub

    Private Sub CHK_DOB_MON_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_DOB_MOM.CheckedChanged
        If CHK_DOB_MOM.Checked = True Then
            txt_DateofBirth_M.Enabled = True
        Else

            txt_DateofBirth_M.Enabled = False
        End If
    End Sub

    Private Sub txt_Last_Date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Last_Date.ValueChanged

    End Sub
End Class