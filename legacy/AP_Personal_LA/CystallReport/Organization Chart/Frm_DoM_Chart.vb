Public Class Frm_DoM_Chart
    Dim rs As New ADODB.Recordset

    Private Sub Frm_DoM_Chart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.FormatString = "ລ/ດ   |<ຊື່ ແລະ ນາມສະກຸນ    |<ບ່ອນປະຈຳການ               |<ຕຳແໜ່ງ                     |<ພະແນກ                     |<ຊັ້ນ/ຂັນ |<ບ້ານຢູ່ປະຈຸບັນ |<ເມືອງ            |<ແຂວງ           "
        fg.set_ColHidden(6, True)
        fg.set_ColHidden(7, True)
        fg.set_ColHidden(8, True)

        Conn.Execute("  update RPT_DoM set RPT_DoM.P_all  = ( select COUNT (AP_CV .Name_L) from ap_cv  where ap_cv.Sections_id=005  )  " & _
                   " update RPT_DoM set RPT_DoM.Man   = ( select COUNT (AP_CV .Name_L) from ap_cv  where ap_cv.gender =N'ຊາຍ' and ap_cv.Sections_id=005  )   " & _
                    " update RPT_DoM set RPT_DoM.Women   = ( select COUNT (AP_CV .Name_L) from ap_cv  where ap_cv.gender =N'ຍິງ'  and ap_cv.Sections_id=005  )   " & _
                    " update RPT_DoM set RPT_DoM.Eak = ( select COUNT (AP_CV .Name_L) from ap_cv  where ap_cv.Sections_id=005  and ap_cv.study_ID=01)   " & _
                    " update RPT_DoM set RPT_DoM.tho = ( select COUNT (AP_CV .Name_L) from ap_cv  where ap_cv.Sections_id=005  and ap_cv.study_ID=03)   " & _
                    " update RPT_DoM set RPT_DoM.tee = ( select COUNT (AP_CV .Name_L) from ap_cv  where ap_cv.Sections_id=005  and ap_cv.study_ID=05)   " & _
                " update RPT_DoM set RPT_DoM.Soung  = ( select COUNT (AP_CV .Name_L) from ap_cv  where ap_cv.Sections_id=005  and ap_cv.study_ID=06)   " & _
             " update RPT_DoM set RPT_DoM.kang  = ( select COUNT (AP_CV .Name_L) from ap_cv  where ap_cv.Sections_id=005  and ap_cv.study_ID=07)  ")

        Dim rs As New ADODB.Recordset


        Call LoadRs("SELECT  * from RPT_DoM ", rs)
        With rs
            If .RecordCount > 0 Then
                Txt_all.Text = Trim(.Fields("P_all").Value.ToString)
                txtman.Text = Trim(.Fields("Man").Value.ToString)
                Txtwomen.Text = Trim(.Fields("Women").Value.ToString)
                txteak.Text = Trim(.Fields("Eak").Value.ToString)
                txttho.Text = Trim(.Fields("tho").Value.ToString)
                txttee.Text = Trim(.Fields("tee").Value.ToString)
                txtsoung.Text = Trim(.Fields("Soung").Value.ToString)
                txtkang.Text = Trim(.Fields("kang").Value.ToString)
            End If
        End With

        Call LoadData()
        'BtnAddNew_Click(sender, e)
    End Sub
    Private Sub AutoNumber()
        Dim VIOT As New ADODB.Recordset
        Dim VIOTNEW As String
        Call LoadRs("SELECT top 1 LV_ID from Level    Order by LV_ID DESC", VIOT)
        If VIOT.RecordCount <> 0 Then
            VIOTNEW = Format(Val(Mid(VIOT.Fields("LV_ID").Value, 1, 2)) + 1, "0")
        Else
            VIOTNEW = "1"

        End If
        Txt_all.Text = Trim(CStr(VIOTNEW.ToString))
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Txt_all.Text = "" Then MsgBox("Type ID !", MsgBoxStyle.OkOnly) : Txt_all.Focus() : Exit Sub

        Call save()
        MsgBox("Save complete!", MsgBoxStyle.OkOnly)
        Call LoadData()
        Txt_all.Focus()
    End Sub
    Public Sub save()
        Call LoadRs("SELECT * FROM Level WHERE LV_ID = '" & Txt_all.Text & "'  ", rs)
        With rs
            If .RecordCount = 0 Then
                Conn.Execute("INSERT INTO Level (LV_ID,LV_Nm) " & _
                   " VALUES(" & CDbl(Txt_all.Text) & "," & _
                                 " N'" & Txtwomen.Text & "')")
            Else
                Conn.Execute("UPDATE Level SET " & _
                   " LV_ID=" & CDbl(Txt_all.Text) & ", " & _
                        " LV_Nm=N'" & Txtwomen.Text & "' " & _
                   " WHERE LV_ID= '" & (Txt_all.Text) & "'  ")
            End If
        End With

    End Sub
    Public Sub LoadData()
        fg.Rows = 1

        With RSC
            Dim aa As String
            aa = "SELECT    AP_CV.*, AP_Village.Vl_nm, AP_District.Dt_id, AP_District.Dt_nm, AP_Province.PV_ID, AP_Province.PV_nm, " & _
                   "   AP_Village_1.Vl_nm AS Vl_nm1, AP_District_1.Dt_nm AS Dt_nm1, AP_Province_1.PV_nm AS PV_nm1 " & _
                   "   FROM         AP_CV INNER JOIN " & _
                   "   AP_Village ON AP_CV.BVill_ID = AP_Village.Vl_ID INNER JOIN  " & _
                    "  AP_District ON AP_Village.Dt_id = AP_District.Dt_id INNER JOIN " & _
                    "  AP_Province ON AP_District.PV_id = AP_Province.PV_ID INNER JOIN " & _
                    "  AP_Village AS AP_Village_1 ON AP_CV.Add_Vill_ID = AP_Village_1.Vl_ID INNER JOIN " & _
                    "  AP_District AS AP_District_1 ON AP_Village_1.Dt_id = AP_District_1.Dt_id INNER JOIN " & _
                   "   AP_Province AS AP_Province_1 ON AP_District_1.PV_id = AP_Province_1.PV_ID   " & _
                   "   where 1=1 and  AP_CV.Sections_id='005'  ORDER BY   AP_CV.E_id   "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    fg.AddItem(.AbsolutePosition & _
                                Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                                 Chr(9) & Trim((RSC.Fields("Sections").Value).ToString) & _
                                             Chr(9) & Trim((RSC.Fields("job_lut").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("Department").Value).ToString) & _
                                                 Chr(9) & Trim((RSC.Fields("txtV_C").Value).ToString) & _
                                      Chr(9) & Trim((RSC.Fields("Vl_nm1").Value).ToString) & _
                                      Chr(9) & Trim((RSC.Fields("Dt_nm1").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("PV_nm1").Value).ToString))

                    .MoveNext()
                End While
            Else
                fg.Rows = 2
            End If
        End With
    End Sub

    Private Sub fg_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.ClickEvent
        'Txt_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        'txtno.Text = fg.get_TextMatrix(fg.Row, 2)
        'Txt_name.Text = fg.get_TextMatrix(fg.Row, 2)
    End Sub

    Private Sub fg_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DblClick
        'If fg.Row = 0 Or fg.get_TextMatrix(fg.Row, 1) = "" Then Exit Sub
        'Txt_ID.Enabled = False
        'TxtPV_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        'TxtPV_NM.Text = fg.get_TextMatrix(fg.Row, 2)
        'txtno.Text = fg.get_TextMatrix(fg.Row, 2)
        'Txt_ID.Text = fg.get_TextMatrix(fg.Row, 1)
        'Txt_name.Text = fg.get_TextMatrix(fg.Row, 2)
    End Sub

    Private Sub fg_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.SelChange

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Txt_all.Text = ""
        Txtwomen.Text = ""
        Txt_all.Visible = True
        Txt_all.Enabled = True
        txtman.Text = ""
        AutoNumber()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("ທ່ານຕ້ອງການລຶບລາຍການນີ້: " & Trim(fg.get_TextMatrix(fg.Row, 1)) & "  ນີ້ແທ້ບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Conn.Execute("Delete From Level Where  LV_ID=N'" & Trim(fg.get_TextMatrix(fg.Row, 1)) & "' ")
            Call LoadData()
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TxtPV_NM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPV_NM.SelectedIndexChanged
        Call LoadRs("Select *  From AP_Province Where   PV_nm =N'" & Trim(TxtPV_NM.Text) & "'", rs)
        If rs.RecordCount > 0 Then
            TxtPV_ID.Text = Trim(rs("PV_ID").Value)
        End If
        Call LoadData()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim aa As String
        Dim RSC As New ADODB.Recordset
        Dim rs1 As New ADODB.Recordset
        Dim s1_no As Integer = 0
        Dim s2_no As Integer = 0
        Dim s3_no As Integer = 0
        Dim s4_no As Integer = 0
        Dim s5_no As Integer = 0
        Dim s6_no As Integer = 0
        Dim s7_no As Integer = 0

        Dim s1 As String = ""
        Dim s2 As String = ""
        Dim s3 As String = ""
        Dim s4 As String = ""
        Dim s5 As String = ""
        Dim s6 As String = ""
        Dim s7 As String = ""
        With rs1
            Call LoadRs("select * from  AP_CV   ", rs1)
            If .RecordCount <> 0 Then
                While Not .EOF()
                    'ພະແນກບໍລິຫານ ແລະ ສັງລວມ
                    If Trim((.Fields("Sections_id").Value).ToString) = "005" And Trim((.Fields("Department_id").Value).ToString) = "005-001" Then
                        s1_no = s1_no + 1 & vbCr
                        s1 = s1 & s1_no & "/ " & Trim((.Fields("Name_L").Value).ToString) & " " & Trim((.Fields("job_lut").Value).ToString) & vbCr
                    End If
                    'ພະແນກນະໂຍບາຍແລະ(ສຳປະທານບໍ່ແຮ່)

                    If Trim((.Fields("Sections_id").Value).ToString) = "005" And Trim((.Fields("Department_id").Value).ToString) = "005-002" Then
                        s2_no = s2_no + 1 & vbCr
                        s2 = s2 & s2_no & "/ " & Trim((.Fields("Name_L").Value).ToString) & " " & Trim((.Fields("job_lut").Value).ToString) & vbCr
                    End If
                    'ພະແນກຂຸດຄົ້ນ ແລະ  ໂລຫະກິດເຕັກໂນໂລຊີ()

                    If Trim((.Fields("Sections_id").Value).ToString) = "005" And Trim((.Fields("Department_id").Value).ToString) = "005-003" Then
                        s3_no = s3_no + 1 & vbCr
                        s3 = s3 & s3_no & "/ " & Trim((.Fields("Name_L").Value).ToString) & " " & Trim((.Fields("job_lut").Value).ToString) & vbCr
                    End If
                    'ພະແນກເສດຖະກິດ ແລະ  ພັດທະນາຊຸມຊົນ()

                    If Trim((.Fields("Sections_id").Value).ToString) = "005" And Trim((.Fields("Department_id").Value).ToString) = "005-004" Then
                        s4_no = s4_no + 1 & vbCr
                        s4 = s4 & s4_no & "/ " & Trim((.Fields("Name_L").Value).ToString) & " " & Trim((.Fields("job_lut").Value).ToString) & vbCr

                    End If
                    'ພະແນກຄວາມປອດໄພ,ສຸຂະພາບ ແລະ ສິ່ງແວດລ້ອມ

                    If Trim((.Fields("Sections_id").Value).ToString) = "005" And Trim((.Fields("Department_id").Value).ToString) = "005-005" Then
                        s5_no = s5_no + 1 & vbCr
                        s5 = s5 & s5_no & "/ " & Trim((.Fields("Name_L").Value).ToString) & " " & Trim((.Fields("job_lut").Value).ToString) & vbCr
                    End If
                    'ພະແນກຂໍ້ມູນ ແລະ ປະເມີນຜົນ

                    If Trim((.Fields("Sections_id").Value).ToString) = "005" And Trim((.Fields("Department_id").Value).ToString) = "005-006" Then
                        s6_no = s6_no + 1 & vbCr
                        s6 = s6 & s6_no & "/ " & Trim((.Fields("Name_L").Value).ToString) & " " & Trim((.Fields("job_lut").Value).ToString) & vbCr
                    End If
           
                    .MoveNext()
                End While

            End If
        End With

        aa = "    update RPT_DoM set RPT_DoM.office_nm1 = AP_CV .Name_L from ap_cv  where ap_cv.Sections_id=005  and ap_cv.job_lut_ID=003 " & _
      "  update RPT_DoM set RPT_DoM.office_nm2 = AP_CV .Name_L from ap_cv  where ap_cv.Sections_id=005 and ap_cv.job_lut_ID=008  and ap_cv.txthong=1 " & _
       " update RPT_DoM set RPT_DoM.office_nm3 = AP_CV .Name_L from ap_cv  where ap_cv.Sections_id=005 and ap_cv.job_lut_ID=008  and ap_cv.txthong=2   " & _
     "   update RPT_DoM set RPT_DoM.office_nm4 = AP_CV .Name_L from ap_cv  where ap_cv.Sections_id=005 and ap_cv.job_lut_ID=008   and ap_cv.txthong=3 " & _
      "  update RPT_DoM set RPT_DoM.office_nm5 = AP_CV .Name_L from ap_cv  where ap_cv.Sections_id=005 and ap_cv.job_lut_ID=008   and ap_cv.txthong=4 "
        Conn.Execute(aa)

        With RSC
            aa = "select N'" & s1 & "' as s1 ,N'" & s2 & "' as s2 ,N'" & s3 & "' as s3 ,N'" & s4 & "' as s4 ,N'" & s5 & "' as s5 ,N'" & s6 & "' as s6   , *  from RPT_DoM  "
            Call LoadRs(aa, RSC)
            If .RecordCount = 0 Then MsgBox("Data empty", vbInformation, "Check") : Exit Sub
            Dim Frm As New FrmPreview
            Dim Rpt As New Report_DoM_Chart
            '=========================================================
            'Dim myText2 As CrystalDecisions.CrystalReports.Engine.TextObject
            'myText2 = CType(Rpt.ReportDefinition.ReportObjects.Item("Textc"), CrystalDecisions.CrystalReports.Engine.TextObject)
            'myText2.Text = "" & MDKHT & ""
            '=========================================================
            'If rs1.RecordCount > 0 Then
            '    Rpt.Subreports(0).SetDataSource(rs1)
            'End If
            'If rs2.RecordCount > 0 Then
            '    Rpt.Subreports(1).SetDataSource(rs2)
            'End If

            'If rs3.RecordCount > 0 Then
            '    Rpt.Subreports(2).SetDataSource(rs3)
            'End If

            'If rs4.RecordCount > 0 Then
            '    Rpt.Subreports(3).SetDataSource(rs4)
            'End If

            Rpt.SetDataSource(RSC)
            Rpt.Refresh()

            Frm.ReportViewer.ReportSource = Rpt
            Frm.ReportViewer.Zoom(100%)
            Frm.ReportViewer.DisplayGroupTree = False
            Frm.WindowState = FormWindowState.Maximized
            Frm.Show()
        End With
        If RSC.State = ConnectionState.Open Then RSC.Close()


    End Sub
End Class