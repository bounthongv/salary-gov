Module AllUser
    Public a, b, c, d, e, f, g, h As String
    'Public Closing_Accnt As Boolean
    'Public RPT_Only As Boolean
    Public Ac_Save, flag As Boolean
    Public MDSTPV_ID As String = ""
    Public MDST As String = ""
    Public HM As String = ""
    Public PVID As String = ""
    Public PERMIT As String = ""
    Public MDPV_ID As String = ""
    Public MDN_ID As String = ""
    Public MDPV_ID1 As String = ""
    Public MDN_ID1 As String = ""
    Public Count_K As Double = 0
    Public Book_id As String = ""
    Public Baby_id As String = ""
    Public BarCode As String = ""
    Public IDCOMPANY As String = ""
    Public CURR_E As String
    Public CURR_P As Double
    Public AMT_SN As Double
    Public DE_ID As String
    Public CURRP As String
    Public RT_CURR As Double
    Public K_IDM, K_NmM, K_price As String
    Public KID As String
    Public RSC As New ADODB.Recordset
    Public KIDP, KNMP As String
    Public P_id, P_nm, P_Snm, CHK_P As String
    Public Price_H, MDVAT, Price_C, Price_L As Integer
    Public Price_T, Price_T2 As Integer
    Public EditActive As Boolean = False
    Public EditCuspiad As Boolean = False
    Public Lng As Boolean = False
    'Public Lang As Boolean = False
    Public VSysError As Boolean
    Public Apimage As Boolean
    Public CHKBill, CHKBillNEW As String
    Public ChStockin, E_ID, Bill_no As String
    Public codr_ID, codr_NM As String
    Public Suppid, SuppName As String
    Public MDLanguage, MDPriceType As Integer
    Public MWorkSetting, MDProduct, Mu_Id As String
    Public Edit_Pro As Integer = 0
    Public MDSearchAcccode As String
    Public Discr_ID, Discr_Nm, Vaccin_ID, Vaccin_Date, Office_NM As String
    Public QtyCK As Double
    Public CatNml As String
    Public OPDate, OPID, OPNm, OPCost, Sizess, OPBox, OPWrap, OPQty As String
    Public MDGroupID, MDCatgoryIDss, MDCatgoryName, MDBox, MDWrap, MDGroup, Carssl As String
    Public MPermit, Off_Id, Company As String : Public MSection As Integer
    Public Vsearch As String
    Public MDPG As String
    Public MUserID, MUserName, MPws, Mpermiss, Mpermiss_ID, MUSTID As String
    Public CateRecode, CateTotal, ProRecode, PorToatl As String
    Public CTyID, CTyName, MDCusID, MDCusName, CustID, CustNm As String
    Public MDGrpID, MDGrpName, INternet As String
    Public MDForMain As String
    Public MDBarcode As String
    Public AccCD, SaleID, Chk_Bill, Chk_Date, STOCK, K As String
    Public K_IDH, Office As String
    Public MDServerPassword, MDServerUser, MDDatabaName, MDServerName As String
    Public MDCatID As String
    Public MDCusBill As String
    Public MDCusUnpiad As String
    Public MDProCate, MDProCut As Integer
    Public MDProID, MDProNm As String
    Public MDStrID, MDStrNm As String
    Public MDRecCnt, MSCateQty As Integer
    Public ForStaff As Integer = 0
    Public MDWrite, MDEdit, MDDelete As Integer
    Public MDChangID, MDChangGrpID As String
    Public MDProList As String
    Public CateID, CateNm, CateUnit, CatePrice As String
    Public MDBpaidID, MDBpaidNm, MDBpaidUnit As String
    Public SaveCateID, SaveOldPrice, SaveNewPrice As String
    Public MDSuppID, MDSuppNm As String
    Public MDStocProID, MDStocCateNm, MDStocUnit, MDStocCost, MDUnit, MDPriceK, Location_Dist_id As String
    Public MDStocCateID As String
    Public Prov_Id, Prov_nm, Location_nm, Dist, Sym, Dist_Locat As String
    Public MDSecID, MDSecNm As String
    Public MDTCatID, MDTCatnm, MDTP, MDTPK, MDQTY As String
    Public BCateID, ProID, ProNm, ProUnit, ProCost As String
    Public SCost, ChCateID, ChCateNm, ChCateCost As String
    Public MDSStockID, MDSStockNm As String
    Public ChCostID, ChPrice, ChSection, ChRefound, ChStock, ChSupp As String
    Public SuppID1, SuppName1, Curr1 As String
    Public StaffID, StaffNm As String
    Public Car_id, Car_nm, Car_no, Car_P As String
    Public ET, ST As Double
    Public BsCateID As String
    Public StIn_No As String
    Public MDSBill_no As String
    Public MDCusPiad, MDCusPiadB As String
    Public MsStockTurn_no, MsStockCateID, MsStockProID, MsStockCateNm, MsStockUnit, MsStockCost As String
    Public MsSectTurn_no, MsSectCateID, MsSectProID, MsSectCateNm, MsSectUnit, MsSectCost As String
    Public MCBill_No, MCCat_ID, MCCat_Nm, MCPro_id, MCUnitL, MCcost, MCprice As String
    Public MSCateID, MSCateNm, MSCateUnit, MSCatePro As String
    Public MFTurn_no, MFCateID, MFProID, MFCateNm, MFUnit, MFCost, MFQty As String
    Public HisCatID As String
    Public Cat_In As Boolean = False
    Public FileAddress, FileNm As String
    Public MDHead, MDNO, MDSig1, MDSig2, MDSig3, MDSig4, MDLocate As String
    Public MDAgeRegistrtion As String
    Public MDStarDate, MDUsingDay, MDSerielAge, MDSeriel As String
    Public MDCatgoryID, MDCusPaidBill As String
    Public CatIn As Boolean = True
    Public CK, CB, CD, CU, CP, QK, QB, QD, QU, QP, PK, PB, PD, PU, PP As Integer
    Public MDLang As Integer
    Public MSCatePrice As Double
    Public Path_connect As String = ""
    Public lang_set As String = ""
    Public load_Item_Ticket_list As Boolean = False
    '==========================

    '===========shr========
    Public shr_section, shr_Department, shr_job_phuk, shr_job_lut, shr_type_in, shr_phuk_sumhong, shr_phuk, shr_Class_vel, Shr_persen, shr_type_dn, shr_Month, DP_id As String
    Public shr_year_Study, shr_study, shr_visa, shr_Nation, shr_lang, shr_year_phuksumhong, shr_year_phuk, shr_year_lut, shr_year_DOB As String
    '=====================

    Public Bill_ID As String = ""
    Public Edit_Quotation As Integer = 0
    Public Edit_Quotation5 As Integer = 0


    Public Bill_plaid As String = ""
    Public Edit_plaid As Integer = 0

    Public Dep_percent As String = ""

    Public cus_ID_Rpt As String = ""
    Public Cus_Name_RPT As String = ""

    Public Staff_Add_New As Integer = 0
    Public Cus_Add_New As Integer = 0

    Public Dep_List As String = ""



    Public Grp_ID_AD As String = ""
    Public Cust_Depart_ADD As String = ""
    Public Cty_id_ADD As String = ""
    Public Cty_Nm_ADD As String = ""

    Public DatabaseServer_ON As Boolean = True
    Public Mworking As Date = Format(Date.Now, "dd-MM-yyyy")
    Public CRR As String


End Module
