Public Class FrmCustomer_item
    Public RSC As New ADODB.Recordset
    Public EditActive As Boolean
    Dim itemfgacc As Boolean
    Dim rs As New ADODB.Recordset
    Dim Sql As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CustID = ""
        Me.Close()
    End Sub
    Private Sub FrmCustomer_item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chk_all.Checked = True
        chk_department.Checked = False
        chk_Job_lut.Checked = False
        chk_section.Checked = False
        chk_Job_Phuk.Checked = False
        Sql = ""
        Fg.FormatString = "ລ/ດ |<ລະຫັດພະນັກງານ |<ຊື່ ແລະ ນາມສະກຸນ              |<ຊື່ (ພາສາອັງກິດ)            |<ເບີໂທລະສັບ  |<ບ່ອນປະຈຳການ     |<ພະແນກ           |<ໜ້າທີ່ຮັບຜິດຊອບ   |^ວັນທີເລີມເຮັດການ|<ຊັ້ນ/ຂັນ|^ວັນທີ່ເລື່ອນຊັ້ນຂັ້ນ|<ຊັ້ນ/ຂັນ|<ປະເພດພະນັກງານ         "
        'Fg.FormatString = "ລ/ດ |<ລະຫັດພະນັກງານ |<ຊື່ ແລະ ນາມສະກຸນ      |<ຊື່ (ພາສາອັງກິດ)|<ເບີໂທລະສັບ    |<ບ່ອນປະຈຳການ   |<ພະແນກ    |<ວັນທີເລີມເຮັດການ|<ຊັ້ນ/ຂັນ |<ວັນທີ່ເລື່ອນຊັ້ນຂັ້ນ|<ຊັ້ນ/ຂັນ  |<ຮັບເງີນເດືອນຕົວຈີງ(%) |<ເງີນເດືອນຕາມ ຊັ້ນ/ຂັ້ນ|<ບ້ານຢູ່ປະຈຸບັນ |<ເມືອງ           |<ແຂວງ             "
        'Fg1.set_ColHidden(8, True)

        chk_department.Checked = True
        loaddata()
        
    End Sub
    Private Sub loaddata()
        Fg.Rows = 1
        With RSC
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
                   "   AP_Sections ON AP_CV.Sections_id = AP_Sections.Sec_id     where 1=1   " & _
                  " " & Sql & " " & shr_section & " " & shr_Department & " " & shr_job_phuk & "" & shr_type_in & " " & shr_job_lut & " ORDER BY     AP_CV.duties_Id  "
            Call LoadRs(aa, RSC)

            If .RecordCount <> 0 Then

                While Not .EOF()
                    Fg.AddItem(.AbsolutePosition & _
                                         Chr(9) & Trim((RSC.Fields("E_ID").Value).ToString) & _
                                Chr(9) & Trim((RSC.Fields("Name_L").Value).ToString) & _
                                 Chr(9) & Trim((RSC.Fields("Name_E").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("Phone").Value).ToString) & _
                                                 Chr(9) & Trim((RSC.Fields("Sec_nmL").Value).ToString) & _
                                          Chr(9) & Trim(RSC.Fields("DP_Name").Value.ToString) & _
                                                          Chr(9) & Trim(RSC.Fields("job_nm").Value.ToString) & _
                                      Chr(9) & Trim((RSC.Fields("DT_strt_work").Value).ToString) & _
                                      Chr(9) & Trim((RSC.Fields("start_work").Value).ToString) & _
                                              Chr(9) & Trim((RSC.Fields("DT_Work_now").Value).ToString) & _
                                      Chr(9) & Trim((RSC.Fields("txtV_C").Value).ToString) & _
                                  Chr(9) & Trim((RSC.Fields("In_nm").Value).ToString))

                    .MoveNext()
                End While

            End If
        End With
    End Sub
    Public Sub Lngs()

        'Label1.Text = "CustomerID:"
        Label2.Text = "Customer name:"
        Fg.FormatString = "NO |<CustomerID|<Customer name     |<Customer type |<Phone number"

    End Sub
    Public Sub LngLao()
        'Label1.Text = "ລະຫັດລູກຄ້າ:"
        Label2.Text = "ລູກຄ້າ:"
        Fg.FormatString = "ລ/ດ |<ລະຫັດປື້ມ       |<ບາໂຄດ           |<ບ່ອນອອກປື້ມ           |<ຊື່ ແລະ ນາມສະກຸນ            |<ເບີໂທລະສັບ          |<ປະຈູບັນຢູ່ບ້ານ    |<ເມືອງ            |<ແຂວງ          "

    End Sub

    Private Sub txtCusNm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCusNm.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Sql = " AND AP_CV.Name_L = N'" & txtCusNm.Text & "' "
                Call loaddata()
        End Select
    End Sub
   
    Private Sub txtCusNm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCusNm.KeyPress
     

    End Sub

    Private Sub Fg_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fg.ClickEvent
        loadColor()
    End Sub
    Private Sub loadColor()
        Dim J As Integer
        Dim i As Integer
        Dim aa As Integer
        aa = Fg.Row
        For i = 1 To Fg.Cols - 1
            For J = 1 To Fg.Rows - 1
                Fg.Row = J
                If aa = J Then
                    Fg.Col = i
                    Fg.CellForeColor = Color.Red
                Else
                    Fg.Col = i
                    Fg.CellForeColor = Color.Black
                End If
            Next J
        Next i
    End Sub
    Private Sub Fg_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fg.DblClick
        'MDCusID = Fg.get_TextMatrix(Fg.Row, 1)
        'MDCusName = Fg.get_TextMatrix(Fg.Row, 2)
        'CustID = Fg.get_TextMatrix(Fg.Row, 1)
        'CustNm = Fg.get_TextMatrix(Fg.Row, 2)
        Me.Close()
    End Sub
    Private Sub Fg_MouseUpEvent(ByVal sender As Object, ByVal e As AxVSFlex8U._IVSFlexGridEvents_MouseUpEvent) Handles Fg.MouseUpEvent
        MDCusID = Fg.get_TextMatrix(Fg.Row, 1)
        MDCusName = Fg.get_TextMatrix(Fg.Row, 2)
        CustID = Fg.get_TextMatrix(Fg.Row, 1)
        CustNm = Fg.get_TextMatrix(Fg.Row, 2)
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmCustomers.ShowDialog()
        Fg.Rows = 1
        With rs
            Call LoadRs("select *  from AP_Customers WHERE Cust_id<>'' " & Sql & " order by Cust_id", rs)
            If .RecordCount > 0 Then
                While Not .EOF()
                    Fg.AddItem(.AbsolutePosition & _
                    Chr(9) & (.Fields("Cust_id").Value) & _
                    Chr(9) & (.Fields("Cust_nmL").Value))
                    .MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub FgCust_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FgCust.SelChange
      
    End Sub

    Private Sub txtCusID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCusID.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Sql = " AND AP_CV.E_ID = N'" & txtCusNm.Text & "' "
              Call loaddata()
        End Select
    End Sub

    Private Sub txtCusID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCusID.TextChanged
        Sql = " AND AP_CV.E_ID LIKE N'%" & txtCusID.Text & "%' "
        Call loaddata()
    End Sub

    Private Sub txtCusNm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCusNm.TextChanged
        Sql = " AND AP_CV.Name_L LIKE N'%" & txtCusNm.Text & "%' "
        Call loaddata()
    End Sub

    Private Sub Fg_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fg.SelChange

    End Sub

    Private Sub txtbarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbarcode.TextChanged

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If CustID = "" Then MsgBox("ເລືອກລາຍການກ່ອນ") : Exit Sub
        Me.Close()
    End Sub

    

    Private Sub chk_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        If chk_all.Checked = True Then
            Sql = ""
            shr_section = ""
            shr_Department = ""
            shr_job_phuk = ""
            Call loaddata()

        Else
            Call loaddata()
        End If
    End Sub

    Private Sub chk_Job_Phuk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chk_department_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_department.CheckedChanged
        If chk_department.Checked = True Then
            cmb_Department.Items.Clear()
            Call load_Cmb("select DP_Name from Department  order by sec_id", "DP_Name", cmb_Department)

            cmb_Department.SelectedIndex = 0
            'where sec_id='" & Frm_Salary_List.txtdepart_ID.Text & "' 

            Dim RSC As New ADODB.Recordset
            Call LoadRs("Select * From Department Where DP_ID=N'" & DP_id & "'   ", RSC)
            If RSC.RecordCount > 0 Then
                cmb_Department.Text = Trim(RSC("DP_Name").Value)

            End If
            shr_Department = " AND AP_CV.Department_id = N'" & txtdepart_ID.Text & "' "

        Else

            cmb_Department.Items.Clear()
            cmb_Department.Text = ""
            shr_Department = ""
        End If
        Call loaddata()
    End Sub

    Private Sub cmb_Department_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Department.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Department Where DP_name=N'" & Trim(cmb_Department.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtdepart_ID.Text = Trim(RSC("DP_ID").Value)
            shr_Department = " AND AP_CV.Department_id = N'" & txtdepart_ID.Text & "' "
        End If
        Call loaddata()
    End Sub

    Private Sub chk_Job_Phuk_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Job_Phuk.CheckedChanged
        If chk_Job_Phuk.Checked = True Then

            cmb_job_phuk.Items.Clear()
            Call load_Cmb("select phuk_id,Phuk_nm from Phuk", "Phuk_nm", cmb_job_phuk)
            cmb_job_phuk.SelectedIndex = 0
            shr_job_phuk = " AND AP_CV.job_phuk_ID = N'" & txt_job_phuk_id.Text & "' "

        Else
            cmb_job_phuk.Items.Clear()
            cmb_job_phuk.Text = ""
            shr_job_phuk = ""
        End If
        Call loaddata()
    End Sub

    Private Sub cmb_job_phuk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_phuk.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From Phuk Where  Phuk_nm=N'" & Trim(cmb_job_phuk.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_job_phuk_id.Text = Trim(RSC("phuk_id").Value)
            shr_job_phuk = " AND AP_CV.job_phuk_ID = N'" & txt_job_phuk_id.Text & "' "
        End If
        Call loaddata()
    End Sub

    Private Sub chk_section_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_section.CheckedChanged
        If chk_section.Checked = True Then
            Cmb_Sections.Items.Clear()
            Call load_Cmb("select Sec_nmL from AP_Sections", "Sec_nmL", Cmb_Sections)
            Cmb_Sections.SelectedIndex = 0
            shr_section = " AND AP_CV.Sections_id = N'" & txtSection_ID.Text & "' "

        Else
            Cmb_Sections.Items.Clear()
            shr_section = ""
        End If
        Call loaddata()
    End Sub

    Private Sub Cmb_Sections_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Sections.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From AP_Sections Where Sec_nmL=N'" & Trim(Cmb_Sections.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txtSection_ID.Text = Trim(RSC("Sec_id").Value)
            shr_section = " AND AP_CV.Sections_id = N'" & txtSection_ID.Text & "' "

        End If
        Call loaddata()
    End Sub

    Private Sub chk_Job_lut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Job_lut.CheckedChanged
        If chk_Job_lut.Checked = True Then
            cmb_job_lut.Enabled = True
            cmb_job_lut.Items.Clear()
            Call load_Cmb("select lut_id,lut_nm from lut", "lut_nm", cmb_job_lut)
            cmb_job_lut.SelectedIndex = 0
            shr_job_lut = " AND AP_CV.job_lut_ID = N'" & txt_job_lut_id.Text & "' "

        Else
            shr_job_lut = ""
            cmb_job_lut.Items.Clear()
            cmb_job_lut.Text = ""
        End If
        Call loaddata()
    End Sub

    Private Sub cmb_job_lut_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_job_lut.SelectedIndexChanged
        Dim RSC As New ADODB.Recordset
        Call LoadRs("Select * From lut Where  lut_nm=N'" & Trim(cmb_job_lut.Text) & "'   ", RSC)
        If RSC.RecordCount > 0 Then
            txt_job_lut_id.Text = Trim(RSC("lut_id").Value)
            shr_job_lut = " AND AP_CV.job_lut_ID = N'" & txt_job_lut_id.Text & "' "
            Call loaddata()
        End If
    End Sub

    Private Sub txt_job_lut_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_job_lut_id.TextChanged

    End Sub
End Class