Public Class Frm_CV
    Private Sub Frm_CV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        addnew()
        Load_Tax()
        Load_SSO()
        loadCMB()

        If EditActive = True Then
            Editdata()
            Fm_Image.Img_ID.Text = txtid.Text
            Fm_Image.ImgType.Text = "Em"
            Call LoadPhoto()
            Pic.Image = Fm_Image.PictureBox1.Image
            Fm_Image.OpenFileDialog1.FileName = " C:\Users\Public\Pictures\Sample Pictures\Penguins.jpg"

        Else
            EditActive = False
            addnew()

            loadCMB()
        End If
    End Sub
    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        SelectImge()
        Pic.Image = Fm_Image.PictureBox1.Image
        If SUPD = 1 Then
            Fm_Image.Img_ID.Text = txtid.Text
            Fm_Image.ImgType.Text = "Em"

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtid.Text = "" Then MsgBox("ໃສ່ລະຫັດພະນັກງານກ່ອນ") : Exit Sub

        'If txtEM_ID.Text = "" Then MsgBox("ໃສ່ລະຫັດພະນັກງານກ່ອນ") : txtEM_ID.Focus() : Exit Sub
       
        Fm_Image.Img_ID.Text = txtid.Text
        Fm_Image.ImgType.Text = "Em"
       
        Insert_Image()
        Save()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)

    End Sub

    Private Sub Save()

        Dim rs As New ADODB.Recordset
        With rs
             
            Call LoadRs("SELECT * FROM AP_CV WHERE E_ID = '" & txtid.Text & "'", rs)
            If .RecordCount = 0 Then
                Dim aa As String
                aa = "INSERT INTO AP_CV (  E_ID, Sections_id, Sections, Department_id, Department,type_in_id, type_in_nm,  Name_L, Name_E, Phone, Bank_no, SSO_no, DT_strt_work, start_work_ID,start_work,txtmoney_basic, DT_Work_now," & _
                  "   cmbclass, cmblevel, txtV_C,txt_parts_id,cmb_parts,txt_work_id,cmb_work, percen, DOB, age,Status_Per_id, Status_Per,gender,BProv_ID, BVill_ID, Add_Vill_ID, houeNo, Road, Street, Card_no, dateOutID,txt_hours_money, Level_Clss_Money, Tumnang_Money, year_money,  " & _
                  "    txttotal, AGL, Total_remaining, Tax, khongsep, txtson, txtson_Money, txtmom, txtMom_mony,txtWomen_mony,txtoil_mony,txtPhone_money, txtToltal_All, duties_Id, duties, " & _
                  " CmbNation1_ID, CmbNation1, CmbNation2_ID, CmbNation2, CmbNation3_ID,CmbNation3, CmbReligion_id, CmbReligion,  lst_updt,lst_usr, Pc_nm) " & _
                   " VALUES('" & (txtid.Text) & "'," & _
                         " N'" & (txtSection_ID.Text) & "'," & _
                       " N'" & (Cmb_Sections.Text) & "'," & _
                         " N'" & (txtdepart_ID.Text) & "'," & _
                       " N'" & (cmb_Department.Text) & "'," & _
                            " N'" & (txt_type_in_id.Text) & "'," & _
                       " N'" & (cmb_type_in.Text) & "'," & _
                          " N'" & (TxtPersonNmL.Text) & "'," & _
                     " N'" & (TxtPersonNmE.Text) & "'," & _
                          " N'" & (TxtTel.Text) & "'," & _
                       " N'" & (TxtAccountNo.Text) & "'," & _
                       " N'" & (txtAPSocial.Text) & "'," & _
                            " '" & Format(DT_start_work.Value, "yyyy-MM-dd") & "'," & _
                         " N'" & (txtjobnew_ID.Text) & "'," & _
                          " N'" & (cmbjobnew.Text) & "'," & _
                            " " & CDbl(txtmoney_basic.Text) & "," & _
                           " '" & Format(DT_Work_now.Value, "yyyy-MM-dd") & "'," & _
                        " N'" & (cmbclass.Text) & "'," & _
                             " N'" & (cmblevel.Text) & "'," & _
                         " N'" & (txtV_C.Text) & "'," & _
                          " N'" & (txt_parts_id.Text) & "'," & _
                           " N'" & (cmb_parts.Text) & "'," & _
                            " N'" & (txt_work_id.Text) & "'," & _
                             " N'" & (cmb_work.Text) & "'," & _
                              " " & CDbl(cmb_percen.Text) & "," & _
                           " '" & Format(DBirthday.Value, "yyyy-MM-dd") & "'," & _
                              " N'" & (txtage.Text) & "'," & _
                                 " N'" & (txt_stutus_id.Text) & "'," & _
                                " N'" & (cmb_stutus.Text) & "'," & _
                      " N'" & (CmbSex.Text) & "'," & _
                          " N'" & (txtB_ProID.Text) & "'," & _
                        " N'" & (txtB_VillID.Text) & "'," & _
                            " N'" & (txtA_VillID.Text) & "'," & _
                        " N'" & (txthoueNo.Text) & "'," & _
                       " N'" & (txtRoad.Text) & "'," & _
                        " N'" & (TxtStreet.Text) & "'," & _
                        " N'" & (txtIdentificationCard.Text) & "'," & _
                          " '" & Format(dateOutID.Value, "yyyy-MM-dd") & "'," & _
                                 " " & CDbl(txt_hours_money.Text) & "," & _
                        " " & CDbl(txtLevel_Clss_Money.Text) & "," & _
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
                                     " " & CDbl(txtwomen_money.Text) & "," & _
                                    " " & CDbl(txtoil.Text) & "," & _
                                      " " & CDbl(txtphone_money.Text) & "," & _
                                      " " & CDbl(txtToltal_All.Text) & "," & _
                                                " N'" & (txt_duties_id.Text) & "'," & _
                                              " N'" & (cmb_duties.Text) & "'," & _
                                             " N'" & (txtNa1.Text) & "'," & _
                                       " N'" & (CmbNation1.Text) & "'," & _
                                           " N'" & (txtNa2.Text) & "'," & _
                                       " N'" & (CmbNation2.Text) & "'," & _
                                           " N'" & (txtNa3.Text) & "'," & _
                                       " N'" & (CmbNation3.Text) & "'," & _
                                            " N'" & (txtReliID.Text) & "'," & _
                                        " N'" & (CmbReligion.Text) & "'," & _
                                       " Getdate()," & _
                                   " N'" & MUserName & "'," & _
                                " '" & MDServerName & "')"
                Conn.Execute(aa)
            Else
                'Conn.Execute("delete from AP_CV WHERE E_ID= '" & (txtid.Text) & "'")
                Dim aa As String
                aa = " UPDATE AP_CV SET " & _
             " Sections_id=N'" & txtSection_ID.Text & "'," & _
              " Sections=N'" & Cmb_Sections.Text & "'," & _
                " Department_id=N'" & txtdepart_ID.Text & "'," & _
               " Department=N'" & cmb_Department.Text & "'," & _
                " type_in_id=N'" & txt_type_in_id.Text & "'," & _
                 " type_in_nm=N'" & cmb_type_in.Text & "'," & _
                  " Name_L=N'" & TxtPersonNmL.Text & "'," & _
                   " Name_E=N'" & TxtPersonNmE.Text & "'," & _
                             " Phone=N'" & TxtTel.Text & "'," & _
                                    " Bank_no=N'" & TxtAccountNo.Text & "'," & _
                      " SSO_no=N'" & txtAPSocial.Text & "'," & _
                     " DT_strt_work=N'" & Format(DT_start_work.Value, "yyyy-MM-dd") & "'," & _
                      " start_work_ID=N'" & txtjobnew_ID.Text & "'," & _
                       " start_work=N'" & cmbjobnew.Text & "'," & _
                        " txtmoney_basic=" & CDbl(txtmoney_basic.Text) & "," & _
                         " DT_Work_now=N'" & Format(DT_Work_now.Value, "yyyy-MM-dd") & "'," & _
                          " cmbclass=N'" & cmbclass.Text & "'," & _
                     " cmblevel=N'" & cmblevel.Text & "'," & _
                          " txt_parts_id=N'" & txtV_C.Text & "'," & _
                          " cmb_parts=N'" & cmb_parts.Text & "'," & _
                          " txt_work_id=N'" & txt_work_id.Text & "'," & _
                            " cmb_work=N'" & cmb_work.Text & "'," & _
                           " txtV_C=N'" & txtV_C.Text & "'," & _
                          " percen=" & CDbl(cmb_percen.Text) & "," & _
                      " DOB=N'" & Format(DBirthday.Value, "yyyy-MM-dd") & "'," & _
                     " age=N'" & txtage.Text & "'," & _
                   " gender=N'" & CmbSex.Text & "'," & _
                     " Status_Per_id=N'" & txt_stutus_id.Text & "'," & _
                    " Status_Per=N'" & cmb_stutus.Text & "'," & _
                              " BProv_ID=N'" & txtB_ProID.Text & "'," & _
                       " BVill_ID=N'" & txtB_VillID.Text & "'," & _
                     " Add_Vill_ID=N'" & txtA_VillID.Text & "'," & _
                        " houeNo=N'" & txthoueNo.Text & "'," & _
                  " Road=N'" & txtRoad.Text & "'," & _
                  " Street=N'" & TxtStreet.Text & "'," & _
                  " Card_no=N'" & txtIdentificationCard.Text & "'," & _
                    " dateOutID=N'" & Format(dateOutID.Value, "yyyy-MM-dd") & "'," & _
                     " txt_hours_money=" & CDbl(txt_hours_money.Text) & "," & _
                  " Level_Clss_Money=" & CDbl(txtLevel_Clss_Money.Text) & "," & _
                   " Tumnang_Money=" & CDbl(txtTumnang_Money.Text) & "," & _
                    " year_money=" & CDbl(txtyear_money.Text) & "," & _
                     " txttotal=" & CDbl(txttotal.Text) & "," & _
                      " AGL=" & CDbl(txtAGL.Text) & "," & _
                       " Total_remaining=" & CDbl(txtTotal_remaining.Text) & "," & _
                      " Tax=N'" & CDbl(txtTax.Text) & "'," & _
                         " khongsep=" & CDbl(txtkhongsep.Text) & "," & _
                            " txtson=" & CDbl(txtson.Text) & "," & _
                                 " txtson_Money=" & CDbl(txtson_Money.Text) & "," & _
                               " txtmom=" & CDbl(txtmom.Text) & "," & _
                                  " txtMom_mony=" & CDbl(txtMom_mony.Text) & "," & _
                                      " txtWomen_mony=" & CDbl(txtwomen_money.Text) & "," & _
                                          " txtoil_mony=" & CDbl(txtoil.Text) & "," & _
                                              " txtPhone_money=" & CDbl(txtphone_money.Text) & "," & _
                                    " txtToltal_All=" & CDbl(txtToltal_All.Text) & "," & _
                                      " duties_Id=N'" & txt_duties_id.Text & "'," & _
                                        " duties=N'" & cmb_duties.Text & "'," & _
                                          " CmbNation1_ID=N'" & txtNa1.Text & "'," & _
                                            " CmbNation1=N'" & CmbNation1.Text & "'," & _
                                              " CmbNation2_ID=N'" & txtNa2.Text & "'," & _
                                               " CmbNation2=N'" & CmbNation2.Text & "'," & _
                                                " CmbNation3_ID=N'" & txtNa3.Text & "'," & _
                                                 " CmbNation3=N'" & CmbNation3.Text & "'," & _
                                                   " CmbReligion_id=N'" & txtReliID.Text & "'," & _
             " CmbReligion=N'" & CmbReligion.Text & "' " & _
             " WHERE E_ID= '" & (txtid.Text) & "'"
                Conn.Execute(aa)
                '          aa = "INSERT INTO AP_CV (  E_ID, Sections_id, Sections, Department_id, Department,type_in_id, type_in_nm, Name_L, Name_E, Phone, Bank_no, SSO_no, DT_strt_work, start_work_ID,start_work,txtmoney_basic, DT_Work_now," & _
                '"   cmbclass, cmblevel, txtV_C, percen, DOB, age, gender, BVill_ID, Add_Vill_ID, houeNo, Road, Street, Card_no, dateOutID, Level_Clss_Money, Tumnang_Money, year_money,  " & _
                '"    txttotal, AGL, Total_remaining, Tax, khongsep, txtson, txtson_Money, txtmom, txtMom_mony, txtToltal_All, duties_Id, duties, " & _
                '" CmbNation1_ID, CmbNation1, CmbNation2_ID, CmbNation2, CmbNation3_ID,CmbNation3, CmbReligion_id, CmbReligion,  lst_updt,lst_usr, Pc_nm) " & _
                ' " VALUES('" & (txtid.Text) & "'," & _
                '       " N'" & (txtSection_ID.Text) & "'," & _
                '     " N'" & (Cmb_Sections.Text) & "'," & _
                '       " N'" & (txtdepart_ID.Text) & "'," & _
                '     " N'" & (cmb_Department.Text) & "'," & _
                '          " N'" & (txt_type_in_id.Text) & "'," & _
                '                 " N'" & (cmb_type_in.Text) & "'," & _
                '        " N'" & (TxtPersonNmL.Text) & "'," & _
                '   " N'" & (TxtPersonNmE.Text) & "'," & _
                '        " N'" & (TxtTel.Text) & "'," & _
                '     " N'" & (TxtAccountNo.Text) & "'," & _
                '     " N'" & (txtAPSocial.Text) & "'," & _
                '          " '" & Format(DT_start_work.Value, "yyyy-MM-dd") & "'," & _
                '       " N'" & (txtjobnew_ID.Text) & "'," & _
                '        " N'" & (cmbjobnew.Text) & "'," & _
                '          " " & CDbl(txtmoney_basic.Text) & "," & _
                '         " '" & Format(DT_Work_now.Value, "yyyy-MM-dd") & "'," & _
                '      " N'" & (cmbclass.Text) & "'," & _
                '           " N'" & (cmblevel.Text) & "'," & _
                '       " N'" & (txtV_C.Text) & "'," & _
                '                 " " & CDbl(cmb_percen.Text) & "," & _
                '         " '" & Format(DBirthday.Value, "yyyy-MM-dd") & "'," & _
                '            " N'" & (txtage.Text) & "'," & _
                '    " N'" & (CmbSex.Text) & "'," & _
                '      " N'" & (txtB_VillID.Text) & "'," & _
                '          " N'" & (txtA_VillID.Text) & "'," & _
                '      " N'" & (txthoueNo.Text) & "'," & _
                '     " N'" & (txtRoad.Text) & "'," & _
                '      " N'" & (TxtStreet.Text) & "'," & _
                '      " N'" & (txtIdentificationCard.Text) & "'," & _
                '        " '" & Format(dateOutID.Value, "yyyy-MM-dd") & "'," & _
                '      " " & CDbl(txtLevel_Clss_Money.Text) & "," & _
                '             " " & CDbl(txtTumnang_Money.Text) & "," & _
                '                 " " & CDbl(txtyear_money.Text) & "," & _
                '         " " & CDbl(txttotal.Text) & "," & _
                '           " " & CDbl(txtAGL.Text) & "," & _
                '             " " & CDbl(txtTotal_remaining.Text) & "," & _
                '               " " & CDbl(txtTax.Text) & "," & _
                '                 " " & CDbl(txtkhongsep.Text) & "," & _
                '                                " " & CDbl(txtson.Text) & "," & _
                '             " " & CDbl(txtson_Money.Text) & "," & _
                '               " " & CDbl(txtmom.Text) & "," & _
                '                 " " & CDbl(txtMom_mony.Text) & "," & _
                '                    " " & CDbl(txtToltal_All.Text) & "," & _
                '                              " N'" & (txt_duties_id.Text) & "'," & _
                '                            " N'" & (cmb_duties.Text) & "'," & _
                '                           " N'" & (txtNa1.Text) & "'," & _
                '                     " N'" & (CmbNation1.Text) & "'," & _
                '                         " N'" & (txtNa2.Text) & "'," & _
                '                     " N'" & (CmbNation2.Text) & "'," & _
                '                         " N'" & (txtNa3.Text) & "'," & _
                '                     " N'" & (CmbNation3.Text) & "'," & _
                '                          " N'" & (txtReliID.Text) & "'," & _
                '                      " N'" & (CmbReligion.Text) & "'," & _
                '                     " Getdate()," & _
                '                 " N'" & MUserName & "'," & _
                '              " '" & MDServerName & "')"
                '          Conn.Execute(aa)

            End If
        End With

        If chk_lut.Checked = True Then
            Conn.Execute(" UPDATE AP_CV SET " & _
                      " chk_lut=1," & _
                  " dt_Lut=N'" & Format(dt_Lut.Value, "yyyy-MM-dd") & "'" & _
                      " WHERE E_ID= '" & (txtid.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_CV SET " & _
                 " chk_lut=0," & _
             " dt_Lut=NULL " & _
                 " WHERE E_ID= '" & (txtid.Text) & "'")
        End If

        If chk_Phuk_sumhong.Checked = True Then
            Conn.Execute(" UPDATE AP_CV SET " & _
                      " chk_Phuk_sumhong=1," & _
                  " dt_Phuk_sumhong=N'" & Format(Dt_Phuk_sumhong.Value, "yyyy-MM-dd") & "'" & _
                      " WHERE E_ID= '" & (txtid.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_CV SET " & _
                 " chk_Phuk_sumhong=0," & _
             " dt_Phuk_sumhong=NULL " & _
                 " WHERE E_ID= '" & (txtid.Text) & "'")
        End If
        If chk_Phuk.Checked = True Then
            Conn.Execute(" UPDATE AP_CV SET " & _
                     " chk_Phuk=1," & _
                 " dt_Phuk=N'" & Format(Dt_Phuk.Value, "yyyy-MM-dd") & "'" & _
                     " WHERE E_ID= '" & (txtid.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_CV SET " & _
                 " chk_Phuk=0," & _
             " dt_Phuk=NULL " & _
                 " WHERE E_ID= '" & (txtid.Text) & "'")
        End If

        If chk_Job_Phuk.Checked = True Then
            Conn.Execute(" UPDATE AP_CV SET " & _
                     " chk_Job_Phuk=1," & _
                 " job_phuk_ID=N'" & txt_job_phuk_id.Text & "'," & _
                       " job_phuk=N'" & cmb_job_phuk.Text & "'" & _
                     " WHERE E_ID= '" & (txtid.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_CV SET " & _
                      " chk_Job_Phuk=0," & _
                  " job_phuk_ID=NULL," & _
                        " job_phuk=NULL " & _
                      " WHERE E_ID= '" & (txtid.Text) & "'")
        End If

        If chk_job_lut.Checked = True Then
            Conn.Execute(" UPDATE AP_CV SET " & _
                     " chk_job_lut=1," & _
                 " job_lut_ID=N'" & txt_job_lut_id.Text & "'," & _
                       " job_lut=N'" & cmb_job_lut.Text & "'," & _
                         " txthong=N'" & txthong.Text & "'" & _
                     " WHERE E_ID= '" & (txtid.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_CV SET " & _
                      " chk_job_lut=0," & _
                  " job_lut_ID=NULL," & _
                       " txthong=0, " & _
                        " job_lut=NULL " & _
                      " WHERE E_ID= '" & (txtid.Text) & "'")
        End If
        If chk_job_lut_visakan.Checked = True Then
            Conn.Execute(" UPDATE AP_CV SET " & _
                     " chk_job_lut_visakan=1," & _
                 " job_lut_visakan=N'" & cmb_job_lut_visakan.Text & "'" & _
                     " WHERE E_ID= '" & (txtid.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_CV SET " & _
                 " chk_job_lut_visakan=0," & _
             " job_lut_visakan=NULL " & _
                 " WHERE E_ID= '" & (txtid.Text) & "'")
        End If

        If chk_study.Checked = True Then
            Conn.Execute(" UPDATE AP_CV SET " & _
                     " chk_study=1," & _
                         " DT_study=N'" & Format(DT_study.Value, "yyyy-MM-dd") & "'," & _
                 " study_ID=N'" & txtstudy_id.Text & "'," & _
                       " study=N'" & cmb_study.Text & "'" & _
                     " WHERE E_ID= '" & (txtid.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_CV SET " & _
                      " chk_study=0," & _
                  " DT_study=NULL," & _
                  " study_ID=NULL," & _
                        " study=NULL " & _
                      " WHERE E_ID= '" & (txtid.Text) & "'")
        End If

        If chk_study.Checked = True Then
            Conn.Execute(" UPDATE AP_CV SET " & _
                     " chk_study=1," & _
                         " DT_study=N'" & Format(DT_study.Value, "yyyy-MM-dd") & "'," & _
                 " study_ID=N'" & txtstudy_id.Text & "'," & _
                       " study=N'" & cmb_study.Text & "'," & _
                         " txtvisa_id=N'" & txtvisa_id.Text & "'," & _
                            " txtvisa=N'" & txtvisa.Text & "'," & _
                      " Study_cuntry_id=N'" & txt_Nation_id.Text & "'," & _
                " Study_cuntry=N'" & cmb_Nation.Text & "'" & _
                     " WHERE E_ID= '" & (txtid.Text) & "'")
            If chk_start.Checked = True Then
                Conn.Execute(" UPDATE AP_CV SET " & _
                         " chk_start=1," & _
                             " DT_Start=N'" & Format(DT_Start.Value, "yyyy-MM-dd") & "' " & _
                         " WHERE E_ID= '" & (txtid.Text) & "'")
            Else
                Conn.Execute(" UPDATE AP_CV SET " & _
                                     " chk_start=0," & _
                                       " DT_Start=NULL " & _
                                     " WHERE E_ID= '" & (txtid.Text) & "'")
            End If
        Else
            Conn.Execute(" UPDATE AP_CV SET " & _
                      " chk_study=0," & _
                  " DT_study=NULL," & _
                  " study_ID=NULL," & _
                   " study=NULL," & _
                        " txtvisa_id=NULL," & _
                             " Study_cuntry_id=NULL," & _
                                  " Study_cuntry=NULL," & _
                        " txtvisa=NULL " & _
                      " WHERE E_ID= '" & (txtid.Text) & "'")
            Conn.Execute(" UPDATE AP_CV SET " & _
                                 " chk_start=0," & _
                                   " DT_Start=NULL " & _
                                 " WHERE E_ID= '" & (txtid.Text) & "'")
        End If

        If chk_study2.Checked = True Then
            Conn.Execute(" UPDATE AP_CV SET " & _
                     " chk_study2=1," & _
                         " DT_study2=N'" & Format(DT_study2.Value, "yyyy-MM-dd") & "'," & _
                            " txtstudy2=N'" & txtstudy2.Text & "'" & _
                     " WHERE E_ID= '" & (txtid.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_CV SET " & _
                      " chk_study2=0," & _
                  " DT_study2=NULL," & _
                  " txtstudy2=NULL " & _
                      " WHERE E_ID= '" & (txtid.Text) & "'")
        End If


        If chk_lang.Checked = True Then
            Conn.Execute(" UPDATE AP_CV SET " & _
                     " chk_lang=1," & _
                     " lang_id=N'" & txt_Lang_id.Text & "'," & _
                        " lang=N'" & cmb_lang.Text & "'" & _
                     " WHERE E_ID= '" & (txtid.Text) & "'")
        Else
            Conn.Execute(" UPDATE AP_CV SET " & _
                      " chk_lang=0," & _
                      " lang_ID=NULL, " & _
                          " lang=NULL " & _
                      " WHERE E_ID= '" & (txtid.Text) & "'")
        End If
    End Sub
   
  
    Private Sub Editdata()
        Dim aa As String
        Dim rs As New ADODB.Recordset
        aa = "SELECT     AP_CV.E_ID, AP_CV.*, AP_Village.Vl_nm, AP_District.Dt_id, " & _
    "    AP_District.Dt_nm, AP_Province.PV_ID, AP_Province.PV_nm, AP_Village_1.Vl_nm AS Vl_nm1, AP_District_1.Dt_nm AS Dt_nm1, AP_Province_1.PV_nm AS PV_nm1,  " & _
      "    AP_Sections.Sec_nmL, Department.DP_Name, Type_In.In_nm , job.job_nm " & _
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
                   "   AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id  where AP_CV.E_ID='" & SaleID & "'"
        Call LoadRs(aa, rs)
        With rs
            If .RecordCount > 0 Then
                txtid.Text = Trim(.Fields("E_ID").Value.ToString)
                Cmb_Sections.Text = Trim(.Fields("Sec_nmL").Value.ToString)

                TxtPersonNmL.Text = Trim(.Fields("Name_L").Value.ToString)
                TxtPersonNmE.Text = Trim(.Fields("Name_E").Value.ToString)
                TxtTel.Text = Trim(.Fields("Phone").Value.ToString)
                cmb_stutus.Text = Trim(.Fields("Status_Per").Value.ToString)

                TxtAccountNo.Text = Trim(.Fields("Bank_no").Value.ToString)
                txtAPSocial.Text = Trim(.Fields("SSO_no").Value.ToString)
                DT_start_work.Value = Trim(.Fields("DT_strt_work").Value.ToString)
                cmbjobnew.Text = Trim(.Fields("start_work").Value.ToString)
                DT_Work_now.Value = Trim(.Fields("DT_Work_now").Value.ToString)
                cmbclass.Text = Trim(.Fields("cmbclass").Value.ToString)
                cmblevel.Text = Trim(.Fields("cmblevel").Value.ToString)
                txtV_C.Text = Trim(.Fields("txtV_C").Value.ToString)
                cmb_parts.Text = Trim(.Fields("cmb_parts").Value.ToString)
                cmb_work.Text = Trim(.Fields("cmb_work").Value.ToString)

                cmb_percen.Text = Trim(.Fields("percen").Value.ToString)
                DBirthday.Value = Trim(.Fields("DOB").Value.ToString)
                txtage.Text = Trim(.Fields("age").Value.ToString)
                CmbSex.Text = Trim(.Fields("gender").Value.ToString)
                CmbBProvince.Text = Trim(.Fields("PV_nm").Value.ToString)
                CmbBDistrict.Text = Trim(.Fields("Dt_nm").Value.ToString)
                CmbBVillage.Text = Trim(.Fields("Vl_nm").Value.ToString)

                CmbAProvince.Text = Trim(.Fields("PV_nm1").Value.ToString)
                CmbADistrict.Text = Trim(.Fields("Dt_nm1").Value.ToString)
                CmbAVillage.Text = Trim(.Fields("Vl_nm1").Value.ToString)
                txthoueNo.Text = Trim(.Fields("houeNo").Value.ToString)
                txtRoad.Text = Trim(.Fields("Road").Value.ToString)
                TxtStreet.Text = Trim(.Fields("Street").Value.ToString)
                txtIdentificationCard.Text = Trim(.Fields("Card_no").Value.ToString)
                dateOutID.Value = Trim(.Fields("dateOutID").Value.ToString)

                txt_hours_money.Text = Format(CDbl(.Fields("txt_hours_money").Value), "##,##0.00")
                txtLevel_Clss_Money.Text = Format(CDbl(.Fields("Level_Clss_Money").Value), "##,##0.00")
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
                txtwomen_money.Text = Format(CDbl(.Fields("txtWomen_mony").Value), "##,##0.00")
                txtoil.Text = Format(CDbl(.Fields("txtoil_mony").Value), "##,##0.00")
                txtphone_money.Text = Format(CDbl(.Fields("txtPhone_money").Value), "##,##0.00")
                txtToltal_All.Text = Format(CDbl(.Fields("txtToltal_All").Value), "##,##0.00")

                cmb_duties.Text = Trim(.Fields("job_nm").Value.ToString)
                CmbNation1.Text = Trim(.Fields("CmbNation1").Value.ToString)
                CmbNation2.Text = Trim(.Fields("CmbNation2").Value.ToString)
                CmbNation3.Text = Trim(.Fields("CmbNation3").Value.ToString)
                CmbReligion.Text = Trim(.Fields("CmbReligion").Value.ToString)

                cmb_Department.Text = Trim(.Fields("DP_Name").Value.ToString)
                'If .Fields("Department").Value <> "" Then
                '    CheckBox1.Checked = True
                '    cmb_Department.Text = Trim(.Fields("Department").Value.ToString)
                'End If

                If .Fields("chk_lut").Value = 1 Then
                    chk_lut.Checked = True
                    dt_Lut.Value = Trim(.Fields("dt_Lut").Value.ToString)
                End If

                If .Fields("chk_Phuk_sumhong").Value = 1 Then
                    chk_Phuk_sumhong.Checked = True
                    Dt_Phuk_sumhong.Value = Trim(.Fields("Dt_Phuk_sumhong").Value.ToString)
                End If

                If .Fields("chk_Phuk").Value = 1 Then
                    chk_Phuk.Checked = True
                    Dt_Phuk.Value = Trim(.Fields("Dt_Phuk").Value.ToString)
                End If


                If .Fields("chk_Job_Phuk").Value = 1 Then
                    chk_Job_Phuk.Checked = True
                    cmb_job_phuk.Text = Trim(.Fields("job_phuk").Value.ToString)
                End If

                If .Fields("chk_job_lut").Value = 1 Then
                    chk_job_lut.Checked = True
                    cmb_job_lut.Text = Trim(.Fields("job_lut").Value.ToString)
                    txthong.Text = Trim(.Fields("txthong").Value.ToString)
                End If

                If .Fields("chk_job_lut_visakan").Value = 1 Then
                    chk_job_lut_visakan.Checked = True
                    cmb_job_lut_visakan.Text = Trim(.Fields("job_lut_visakan").Value.ToString)
                End If


                If .Fields("chk_study").Value = 1 Then
                    chk_study.Checked = True
                    DT_study.Value = Trim(.Fields("DT_study").Value.ToString)
                    cmb_study.Text = Trim(.Fields("study").Value.ToString)
                    txtvisa.Text = Trim(.Fields("txtvisa").Value.ToString)
                    cmb_Nation.Text = Trim(.Fields("Study_cuntry").Value.ToString)
                End If
                If .Fields("chk_start").Value = 1 Then
                    chk_start.Checked = True
                    DT_Start.Value = Trim(.Fields("DT_Start").Value.ToString)

                End If
                If .Fields("chk_study2").Value = 1 Then
                    chk_study2.Checked = True
                    DT_study2.Value = Trim(.Fields("DT_study2").Value.ToString)
                    txtstudy2.Text = Trim(.Fields("txtstudy2").Value.ToString)
                End If

                If .Fields("chk_lang").Value = 1 Then
                    chk_lang.Checked = True
                    cmb_lang.Text = Trim(.Fields("lang").Value.ToString)
                End If

            End If
        End With

        Dim rsc As New ADODB.Recordset
        Call LoadRs("SELECT * FROM Level_class where name='" & txtV_C.Text & "'  ", rsc)
        With rsc
            If .RecordCount <> 0 Then
                cmbclass.Text = (.Fields("Leve").Value.ToString)
                cmblevel.Text = (.Fields("Class").Value.ToString)
           
            End If
        End With
    End Sub
    Private Sub loadCMB()
        Cmb_Sections.Items.Clear()
        Call load_Cmb("select Sec_nmL from AP_Sections", "Sec_nmL", Cmb_Sections)
        Cmb_Sections.SelectedIndex = 0

        cmb_Department.Items.Clear()
        Call load_Cmb("select DP_Name from Department", "DP_Name", cmb_Department)
        cmb_Department.SelectedIndex = 0

        cmb_type_in.Items.Clear()
        Call load_Cmb("select In_nm from Type_In", "In_nm", cmb_type_in)
        cmb_type_in.SelectedIndex = 0


        CmbBProvince.Items.Clear()
        Call load_Cmb("select PV_nm from AP_Province", "PV_nm", CmbBProvince)
        CmbBProvince.SelectedIndex = 0

        CmbAProvince.Items.Clear()
        Call load_Cmb("select PV_nm from AP_Province", "PV_nm", CmbAProvince)
        CmbAProvince.SelectedIndex = 0

        cmbjobnew.Items.Clear()
        Call load_Cmb("select name from Level_class", "name", cmbjobnew)
        cmbjobnew.SelectedIndex = 0

        cmbclass.Items.Clear()
        Call load_Cmb("select cl_ID from Class", "cl_ID", cmbclass)
        cmbclass.SelectedIndex = 0

        cmblevel.Items.Clear()
        Call load_Cmb("select LV_ID from Level", "LV_ID", cmblevel)
        cmblevel.SelectedIndex = 0


        cmb_duties.Items.Clear()
        Call load_Cmb("select job_nm from job", "job_nm", cmb_duties)
        cmb_duties.SelectedIndex = 0

        CmbNation1.Items.Clear()
        Call load_Cmb("select NationNmL from Nationall", "NationNmL", CmbNation1)
        CmbNation1.SelectedIndex = 0

        CmbNation2.Items.Clear()
        Call load_Cmb("select Country_Name from Countries", "Country_Name", CmbNation2)
        CmbNation2.SelectedIndex = 0

        CmbNation3.Items.Clear()
        Call load_Cmb("select EthnicNm from APListEthnic", "EthnicNm", CmbNation3)
        CmbNation3.SelectedIndex = 0

        CmbReligion.Items.Clear()
        Call load_Cmb("select NameReligoin from Religoin", "NameReligoin", CmbReligion)
        CmbReligion.SelectedIndex = 0

        


       


     




    End Sub

    Private Sub CmbBProvince_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBProvince.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Province Where  PV_nm=N'" & Trim(CmbBProvince.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtB_ProID.Text = Trim(RSC("PV_ID").Value)
        End If

        CmbBDistrict.Items.Clear()
        Call load_Cmb(" Select * From AP_District  where PV_id =N'" & Trim(txtB_ProID.Text) & "'   ORDER BY Dt_id ", "Dt_nm", CmbBDistrict)
        If CmbBDistrict.Items.Count > 0 Then
            CmbBDistrict.SelectedIndex = 0
        End If
    End Sub

    Private Sub CmbBDistrict_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBDistrict.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_District Where  Dt_nm=N'" & Trim(CmbBDistrict.Text) & "'  and PV_id =N'" & Trim(txtB_ProID.Text) & "'    ", RSC)
        If RSC.RecordCount > 0 Then
            txtB_DistID.Text = Trim(RSC("Dt_id").Value)
        End If

        CmbBVillage.Items.Clear()
        Call load_Cmb(" Select * From AP_Village  where Dt_id =N'" & Trim(txtB_DistID.Text) & "'   ORDER BY Vl_ID ", "Vl_nm", CmbBVillage)
        If CmbBVillage.Items.Count > 0 Then
            CmbBVillage.SelectedIndex = 0
        End If
    End Sub

    Private Sub CmbBVillage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBVillage.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Village Where  Vl_nm=N'" & Trim(CmbBVillage.Text) & "' and Dt_id =N'" & Trim(txtB_DistID.Text) & "'     ", RSC)
        If RSC.RecordCount > 0 Then
            txtB_VillID.Text = Trim(RSC("Vl_ID").Value)
        End If


    End Sub

    Private Sub CmbAProvince_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAProvince.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Province Where  PV_nm=N'" & Trim(CmbAProvince.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtA_ProID.Text = Trim(RSC("PV_ID").Value)
        End If

        CmbADistrict.Items.Clear()
        Call load_Cmb(" Select * From AP_District  where PV_id =N'" & Trim(txtA_ProID.Text) & "'   ORDER BY Dt_id ", "Dt_nm", CmbADistrict)
        If CmbADistrict.Items.Count > 0 Then
            CmbADistrict.SelectedIndex = 0
        End If
    End Sub

    Private Sub CmbADistrict_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbADistrict.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_District Where  Dt_nm=N'" & Trim(CmbADistrict.Text) & "'  and PV_id =N'" & Trim(txtA_ProID.Text) & "'    ", RSC)
        If RSC.RecordCount > 0 Then
            txtA_DistID.Text = Trim(RSC("Dt_id").Value)
        End If

        CmbAVillage.Items.Clear()
        Call load_Cmb(" Select * From AP_Village  where Dt_id =N'" & Trim(txtA_DistID.Text) & "'   ORDER BY Vl_ID ", "Vl_nm", CmbAVillage)
        If CmbAVillage.Items.Count > 0 Then
            CmbAVillage.SelectedIndex = 0
        End If
    End Sub

    Private Sub CmbAVillage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAVillage.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Village Where  Vl_nm=N'" & Trim(CmbAVillage.Text) & "' and Dt_id =N'" & Trim(txtA_DistID.Text) & "'     ", RSC)
        If RSC.RecordCount > 0 Then
            txtA_VillID.Text = Trim(RSC("Vl_ID").Value)
        End If

    End Sub

    Private Sub Bclos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclos.Click
        Me.Close()
    End Sub

     

  

    Private Sub cmblevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblevel.SelectedIndexChanged
        txtV_C.Text = cmbclass.Text & "/" & cmblevel.Text
        loadmonet_class()
        Load_sum_tax()
    End Sub
    Private Sub loadmonet_class()
        Dim rs As New ADODB.Recordset
        Call LoadRs("select * from Level_class where name='" & Trim(Apostrophe(txtV_C.Text)) & "'", rs)
        With rs
            If .RecordCount > 0 Then

                txtLevel_Clss_Money.Text = Format(CDbl(.Fields("Toltle").Value), "##,##0.00")

            Else
                txtLevel_Clss_Money.Text = 0

            End If
        End With

        txttotal.Text = Format(CDbl(txtLevel_Clss_Money.Text) + CDbl(txtTumnang_Money.Text) + CDbl(txtyear_money.Text), "##,##0.00")
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

    Private Sub cmbjobnew_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbjobnew.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Level_class Where name=N'" & Trim(cmbjobnew.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtjobnew_ID.Text = Trim(RSC("ID").Value)
            txtmoney_basic.Text = Trim(RSC("Toltle").Value)
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

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

    Private Sub DBirthday_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBirthday.ValueChanged
        txtage.Text = DateDiff(DateInterval.Year, DBirthday.Value, Today)
    End Sub

    Private Sub CmbSex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSex.SelectedIndexChanged
        If CmbSex.SelectedIndex = 0 Then
            txtsex_id.Text = 1
        Else
            txtsex_id.Text = 2
        End If
    End Sub

    Private Sub Badd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badd.Click
        cmb_percen.SelectedIndex = 0
        addnew()
    End Sub
    Private Sub addnew()
        TxtPersonNmL.Text = ""
        TxtPersonNmE.Text = ""
        TxtTel.Text = ""
        TxtAccountNo.Text = ""
        txtAPSocial.Text = ""
        txt_hours_money.Text = 0
        txtTumnang_Money.Text = 0
        txtyear_money.Text = 0
        txtAGL.Text = 0
        txtTax.Text = 0
        txtkhongsep.Text = 0
        txtson.Text = 0
        txtmom.Text = 0
        txtson_Money.Text = 0
        txtMom_mony.Text = 0
        txtage.Text = 0
        txtwomen_money.Text = 0
        txtoil.Text = 0
        txtphone_money.Text = 0
        cmb_percen.SelectedIndex = 0
        CmbSex.SelectedIndex = 0
        txthong.Text = 0
        cmb_stutus.SelectedIndex = 0
        cmb_parts.SelectedIndex = 0
        cmb_work.SelectedIndex = 0


        AutoNumber()
    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 E_ID from AP_CV    Order by E_ID DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("E_ID").Value, 2, 6)) + 1, "00000")
        Else
            VIOTNEW = "00001"

        End If
        txtid.Text = "E" & Trim(CStr(VIOTNEW.ToString))
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        Pic.Image = Nothing
    End Sub

    Private Sub txtage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkhongsep.TextChanged

    End Sub

    Private Sub chk_lut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_lut.CheckedChanged
        If chk_lut.Checked = True Then
            dt_Lut.Enabled = True
        Else
            dt_Lut.Enabled = False
        End If
    End Sub

    Private Sub chk_Phuk_sumhong_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Phuk_sumhong.CheckedChanged
        If chk_Phuk_sumhong.Checked = True Then
            Dt_Phuk_sumhong.Enabled = True
        Else
            Dt_Phuk_sumhong.Enabled = False
        End If
    End Sub

    Private Sub chk_Phuk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Phuk.CheckedChanged
        If chk_Phuk.Checked = True Then
            Dt_Phuk.Enabled = True
        Else
            Dt_Phuk.Enabled = False
        End If
    End Sub

    Private Sub chk_Job_Phuk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Job_Phuk.CheckedChanged
        If chk_Job_Phuk.Checked = True Then
            cmb_job_phuk.Enabled = True
            cmb_job_phuk.Items.Clear()
            Call load_Cmb("select phuk_id,Phuk_nm from Phuk", "Phuk_nm", cmb_job_phuk)
            cmb_job_phuk.SelectedIndex = 0
            Button15.Enabled = True
        Else
            cmb_job_phuk.Items.Clear()
            cmb_job_phuk.Text = ""
            cmb_job_phuk.Enabled = False
            Button15.Enabled = False
        End If
    End Sub

    Private Sub cmb_job_phuk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_phuk.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Phuk Where  Phuk_nm=N'" & Trim(cmb_job_phuk.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_job_phuk_id.Text = Trim(RSC("phuk_id").Value)
        End If

    End Sub

    Private Sub chk_job_lut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_job_lut.CheckedChanged
        If chk_job_lut.Checked = True Then
            cmb_job_lut.Enabled = True
            cmb_job_lut.Items.Clear()
            Call load_Cmb("select lut_id,lut_nm from lut", "lut_nm", cmb_job_lut)
            cmb_job_lut.SelectedIndex = 0
            Button91.Enabled = True

        Else
            cmb_job_lut.Items.Clear()
            cmb_job_lut.Text = ""
            cmb_job_lut.Enabled = False
            Button91.Enabled = False
        End If
    End Sub

    Private Sub cmb_job_lut_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_lut.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From lut Where  lut_nm=N'" & Trim(cmb_job_lut.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_job_lut_id.Text = Trim(RSC("lut_id").Value)
        End If

        If cmb_job_lut.SelectedIndex = 10 Then
            chk_job_lut_visakan.Checked = True
        Else
            chk_job_lut_visakan.Checked = False
        End If

        If cmb_job_lut.SelectedIndex > 6 And cmb_job_lut.SelectedIndex < 12 Then
            L_hong.Visible = True
            txthong.Visible = True

        Else
            L_hong.Visible = False
            txthong.Visible = False
        End If
    End Sub

    Private Sub chk_job_lut_visakan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_job_lut_visakan.CheckedChanged
        If chk_job_lut_visakan.Checked = True Then
            cmb_job_lut_visakan.Enabled = True
            cmb_job_lut_visakan.Text = "ວິຊາການ"

        Else

            cmb_job_lut_visakan.Text = ""
            cmb_job_lut_visakan.Enabled = False
        End If
    End Sub

    Private Sub cmb_duties_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_duties.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From job Where  job_nm=N'" & Trim(cmb_duties.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_duties_id.Text = Trim(RSC("job_id").Value)
        End If
    End Sub

    Private Sub CmbNation1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNation1.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Nationall Where  NationNmL=N'" & Trim(CmbNation1.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtNa1.Text = Trim(RSC("NationID").Value)
        End If
    End Sub

    Private Sub CmbNation2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNation2.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Countries Where  Country_Name=N'" & Trim(CmbNation1.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtNa2.Text = Trim(RSC("Country_ID").Value)
        End If
    End Sub

    Private Sub CmbNation3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNation3.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From APListEthnic Where EthnicNm =N'" & Trim(CmbNation3.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtNa3.Text = Trim(RSC("EthnicCD").Value)
        End If
    End Sub

    Private Sub CmbReligion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbReligion.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Religoin Where  NameReligoin=N'" & Trim(CmbReligion.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtReliID.Text = Trim(RSC("Religoin_ID").Value)
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Frm_phuk.ShowDialog()
        cmb_job_phuk.Items.Clear()
        Call load_Cmb("select phuk_id,Phuk_nm from Phuk", "Phuk_nm", cmb_job_phuk)
        cmb_job_phuk.SelectedIndex = 0
    End Sub

    Private Sub Button91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button91.Click
        Frm_lut.ShowDialog()
        cmb_job_lut.Items.Clear()
        Call load_Cmb("select lut_id,lut_nm from lut", "lut_nm", cmb_job_lut)
        cmb_job_lut.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Frm_job.ShowDialog()
        cmb_duties.Items.Clear()
        Call load_Cmb("select job_nm from job", "job_nm", cmb_duties)
        cmb_duties.SelectedIndex = 0
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        FrmNationall.ShowDialog()
        CmbNation1.Items.Clear()
        Call load_Cmb("select NationNmL from Nationall", "NationNmL", CmbNation1)
        CmbNation1.SelectedIndex = 0
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Countries.ShowDialog()
        CmbNation2.Items.Clear()
        Call load_Cmb("select Country_Name from Countries", "Country_Name", CmbNation2)
        CmbNation2.SelectedIndex = 0
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        FrmAPListEthnic.ShowDialog()
        CmbNation3.Items.Clear()
        Call load_Cmb("select EthnicNm from APListEthnic", "EthnicNm", CmbNation3)
        CmbNation3.SelectedIndex = 0


    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        frmreligoin.ShowDialog()
        CmbReligion.Items.Clear()
        Call load_Cmb("select NameReligoin from Religoin", "NameReligoin", CmbReligion)
        CmbReligion.SelectedIndex = 0
    End Sub

    Private Sub cmb_study_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_study.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Education Where  E_nm=N'" & Trim(cmb_study.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtstudy_id.Text = Trim(RSC("E_id").Value)
        End If
    End Sub

    Private Sub chk_study_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_study.CheckedChanged
        If chk_study.Checked = True Then
            cmb_study.Enabled = True
            cmb_study.Items.Clear()
            Call load_Cmb("select E_nm from Education where E_id<10 ", "E_nm", cmb_study)
            cmb_study.SelectedIndex = 0
            DT_study.Enabled = True
            txtvisa.Enabled = True
            txtvisa.Text = ""

            txtvisa.Items.Clear()
            Call load_Cmb("select Field_Name from Study_Field where Field_ID>003 ", "Field_Name", txtvisa)
            txtvisa.SelectedIndex = 0
            Button3.Enabled = True

            chk_start.Enabled = True


            cmb_Nation.Items.Clear()
            Call load_Cmb("select NationNmL from Nationall", "NationNmL", cmb_Nation)
            cmb_Nation.SelectedIndex = 0
        Else
            DT_study.Enabled = False
            txtvisa.Enabled = False
            txtvisa.Text = ""
            cmb_study.Items.Clear()
            cmb_study.Text = ""
            cmb_study.Enabled = False

            chk_start.Enabled = False
            cmb_Nation.Items.Clear()
            cmb_Nation.Text = ""
            Button3.Enabled = False
        End If
    End Sub

    Private Sub chk_study2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_study2.CheckedChanged
        If chk_study2.Checked = True Then
            DT_study2.Enabled = True
            txtstudy2.Enabled = True
            txtstudy2.Text = ""

        Else
            DT_study2.Enabled = False
            txtstudy2.Enabled = False
            txtstudy2.Text = ""
        End If
    End Sub

    Private Sub chk_lang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_lang.CheckedChanged
        If chk_lang.Checked = True Then
            cmb_lang.Enabled = True

            cmb_lang.Items.Clear()
            Call load_Cmb("select Country_Name from Countries where Country_ID>001", "Country_Name", cmb_lang)
            cmb_lang.SelectedIndex = 0
        Else
            cmb_lang.Enabled = False
            cmb_lang.Items.Clear()
            cmb_lang.Text = ""

        End If
    End Sub

    Private Sub cmb_lang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_lang.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Countries Where  Country_Name=N'" & Trim(cmb_lang.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_Lang_id.Text = Trim(RSC("Country_ID").Value)
        End If
    End Sub

    Private Sub txtLevel_Clss_Money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLevel_Clss_Money.TextChanged

    End Sub

    Private Sub cmbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclass.SelectedIndexChanged
        'cmblevel.Text = 1
        txtV_C.Text = cmbclass.Text & "/" & cmblevel.Text

        If cmblevel.Text <> "" Then
            loadmonet_class()
            Load_sum_tax()
        End If

    End Sub

    Private Sub txtTotal_remaining_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal_remaining.TextChanged

    End Sub

    Private Sub cmb_type_in_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_type_in.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Type_In Where In_nm=N'" & Trim(cmb_type_in.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_type_in_id.Text = Trim(RSC("In_ID").Value)
        End If
    End Sub

    Private Sub cmb_job_lut_visakan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_lut_visakan.SelectedIndexChanged

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Dim rs As New ADODB.Recordset
            With rs
                Call LoadRs("SELECT   * from Department where Sec_id='" & txtSection_ID.Text & "' order by  DP_ID", rs)
                If .RecordCount > 0 Then
                    cmb_Department.Items.Clear()
                    Call load_Cmb("select DP_Name from Department where Sec_id='" & txtSection_ID.Text & "' ", "DP_Name", cmb_Department)
                    cmb_Department.SelectedIndex = 0
                Else
                    cmb_Department.Items.Clear()
                    cmb_Department.Text = ""
                    txtdepart_ID.Text = ""

                End If
            End With
        Else
            cmb_Department.Items.Clear()
            cmb_Department.Text = ""
            txtdepart_ID.Text = ""

        End If
    End Sub

    Private Sub cmb_visa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvisa.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Study_Field Where  Field_Name=N'" & Trim(txtvisa.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtvisa_id.Text = Trim(RSC("Field_ID").Value)
            'shr_job_phuk = " AND AP_CV.job_phuk_ID = N'" & txtvisa_id.Text & "' "
        End If
    End Sub

    Private Sub chk_start_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_start.CheckedChanged
        If chk_start.Checked = True Then
            DT_Start.Enabled = True
        Else
            DT_Start.Enabled = False
        End If
    End Sub

    Private Sub cmb_Nation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Nation.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Nationall Where  NationNmL=N'" & Trim(cmb_Nation.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_Nation_id.Text = Trim(RSC("NationID").Value)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Frm_Study.ShowDialog()
        txtvisa.Items.Clear()
        Call load_Cmb("select Field_Name from Study_Field where Field_ID>003 ", "Field_Name", txtvisa)
        txtvisa.SelectedIndex = 0
    End Sub

    Private Sub cmb_parts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_parts.SelectedIndexChanged
        If cmb_parts.SelectedIndex = 0 Then
            txt_parts_id.Text = "01"
        Else
            txt_parts_id.Text = "02"
        End If
    End Sub

    Private Sub cmb_work_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_work.SelectedIndexChanged
        If cmb_work.SelectedIndex = 0 Then
            txt_work_id.Text = "01"
        ElseIf cmb_work.SelectedIndex = 1 Then
            txt_work_id.Text = "02"
        Else
            txt_work_id.Text = "03"
        End If
    End Sub

    Private Sub cmb_stutus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_stutus.SelectedIndexChanged
        If cmb_stutus.SelectedIndex = 0 Then
            txt_stutus_id.Text = "01"
        ElseIf cmb_stutus.SelectedIndex = 1 Then
            txt_stutus_id.Text = "02"
        ElseIf cmb_stutus.SelectedIndex = 2 Then
            txt_stutus_id.Text = "03"
        Else
            txt_stutus_id.Text = "04"
        End If
    End Sub
 
    Private Sub txtphone_money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphone_money.TextChanged

    End Sub

    Private Sub txttotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub txtTumnang_Money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTumnang_Money.TextChanged

    End Sub

    Private Sub txtyear_money_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtyear_money.TextChanged

    End Sub
End Class