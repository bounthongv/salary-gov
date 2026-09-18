Module MDRateSetting
    Public MDJPY, MDLAK, MDTHB, MDUSD, MDEUR, MDUSD_LAK, MDTHB_LAK, MDEUR_LAK, MDEUR_THB, MDUSD_THB, MDEUR_USD As Double
    Public MDJPY_LAK, MDJPY_THB, MDJPY_USA As Double
    Public MDJPY1, MDLAK1, MDTHB1, MDUSD1, MDEUR1, MDUSD_LAK1, MDTHB_LAK1, MDEUR_LAK1, MDEUR_THB1, MDUSD_THB1, MDEUR_USD1 As Double
    Public Tax_Month, Tax1, Tax_LAK1, Tax2, Tax_LAK2, Tax3, Tax_LAK3, Tax4, Tax_LAK4, Tax5, Tax_LAK5, Tax6, Tax_LAK6, Tax7, Tax_LAK7, SSO_Employee, SSO_Employer As String
    Public Level, Day_year, Ann_Day, Day_Month, Hour_Day, SSO_Com, SSO_Em, AGL_in, AGL_out, Deprat, Position, Cost_of_living As String
    Public LAK, THB, USD, Rate_set, Rate_All, DT_rate As String
    Public Tax1_Sum, Tax2_Sum, Tax3_Sum, Tax4_Sum, Tax5_Sum, Tax6_Sum, Tax7_Sum As String
    Public Tax1_cut, Tax2_cut, Tax3_cut, Tax4_cut, Tax5_cut, Tax6_cut, Tax7_cut As String
    Public MDRate_Curr, myID As String
    ' Public StrDate As String
    Public StrDate As Date
    Public Sub RateSetting()
        Dim Rs As New ADODB.Recordset
        With Rs
            Call LoadRs("select * from AP_Rate_history ORDER BY rate_dt DESC ", Rs)
            If .RecordCount > 0 Then
                StrDate = Trim(.Fields("rate_dt").Value)
                MDLAK = Trim(.Fields("LAK").Value)
                MDTHB = Trim(.Fields("THB").Value)
                MDUSD = Trim(.Fields("USD").Value)
                MDEUR = Trim(.Fields("EUR").Value)
                MDUSD_LAK = Trim(.Fields("USD_LAK").Value)
                MDTHB_LAK = Trim(.Fields("THB_LAK").Value)
                MDEUR_LAK = Trim(.Fields("EUR_LAK").Value)
                MDEUR_THB = Trim(.Fields("EUR_THB").Value)
                MDUSD_THB = Trim(.Fields("USD_THB").Value)
                MDEUR_USD = Trim(.Fields("EUR_USD").Value)
                MDRate_Curr = Trim(.Fields("Curr").Value)
                .MoveNext()
            Else
                Call LoadRs("select * from AP_Rate WHERE status=1", Rs)
                MDLAK = Trim(.Fields("LAK").Value)
                MDTHB = Trim(.Fields("THB").Value)
                MDUSD = Trim(.Fields("USD").Value)
                MDEUR = Trim(.Fields("EUR").Value)
                'MDJPY = Trim(.Fields("JPY").Value)
                MDUSD_LAK = Trim(.Fields("USD_LAK").Value)
                MDTHB_LAK = Trim(.Fields("THB_LAK").Value)
                MDEUR_LAK = Trim(.Fields("EUR_LAK").Value)
                'MDJPY_LAK = Trim(.Fields("JPY_LAK").Value)
                MDEUR_THB = Trim(.Fields("EUR_THB").Value)
                MDUSD_THB = Trim(.Fields("USD_THB").Value)
                'MDJPY_THB = Trim(.Fields("JPY_THB").Value)
                MDEUR_USD = Trim(.Fields("EUR_USD").Value)
                'MDJPY_THB = Trim(.Fields("JPY_USD").Value)
                MDRate_Curr = Trim(.Fields("Curr").Value)
                .MoveNext()
            End If
        End With
    End Sub
    Public Sub RateSetting1()
        Dim Rs As New ADODB.Recordset
        With Rs
            Call LoadRs("select * from APListCurrency ORDER BY TimeUpdate DESC ", Rs)
            If .RecordCount > 0 Then
                StrDate = Trim(.Fields("TimeUpdate").Value)
                MDUSD_LAK1 = Trim(.Fields("Rate_LAK").Value)
                .MoveNext()
            Else
                '            Call LoadRs("select * from AP_Rate WHERE status=1", Rs)
                '            MDLAK = Trim(.Fields("LAK").Value)
                '            MDTHB = Trim(.Fields("THB").Value)
                '            MDUSD = Trim(.Fields("USD").Value)
                '            MDEUR = Trim(.Fields("EUR").Value)
                '            MDJPY = Trim(.Fields("JPY").Value)
                '            MDUSD_LAK = Trim(.Fields("USD_LAK").Value)
                '            MDTHB_LAK = Trim(.Fields("THB_LAK").Value)
                '            MDEUR_LAK = Trim(.Fields("EUR_LAK").Value)
                '            MDJPY_LAK = Trim(.Fields("JPY_LAK").Value)
                '            MDEUR_THB = Trim(.Fields("EUR_THB").Value)
                '            MDUSD_THB = Trim(.Fields("USD_THB").Value)
                '            MDJPY_THB = Trim(.Fields("JPY_THB").Value)
                '            MDEUR_USD = Trim(.Fields("EUR_USD").Value)
                '            MDJPY_THB = Trim(.Fields("JPY_USD").Value)
                '            MDRate_Curr = Trim(.Fields("Curr").Value)
                '            .MoveNext()
            End If
        End With


    End Sub
    Public Sub Load_Tax()
        Dim aa As String
        Dim rs As New ADODB.Recordset
        aa = " SELECT TOP 1 *   FROM Unit_Tax  order by For_month desc  "

        Call LoadRs(aa, rs)
        With rs
            If rs.RecordCount <> 0 Then

                Tax_Month = .Fields("For_month").Value.ToString
                Tax1 = .Fields("Tax1").Value.ToString
                Tax_LAK1 = Format(CDbl(.Fields("Tax_LAK1").Value), "##,##0.00")
                Tax2 = .Fields("Tax2").Value.ToString
                Tax_LAK2 = Format(CDbl(.Fields("Tax_LAK2").Value), "##,##0.00")
                Tax3 = .Fields("Tax3").Value.ToString
                Tax_LAK3 = Format(CDbl(.Fields("Tax_LAK3").Value), "##,##0.00")
                Tax4 = .Fields("Tax4").Value.ToString
                Tax_LAK4 = Format(CDbl(.Fields("Tax_LAK4").Value), "##,##0.00")
                Tax5 = .Fields("Tax5").Value.ToString
                Tax_LAK5 = Format(CDbl(.Fields("Tax_LAK5").Value), "##,##0.00")
                Tax6 = .Fields("Tax6").Value.ToString
                Tax_LAK6 = Format(CDbl(.Fields("Tax_LAK6").Value), "##,##0.00")
                Tax7 = .Fields("Tax7").Value.ToString
                Tax_LAK7 = Format(CDbl(.Fields("Tax_LAK7").Value), "##,##0.00")
            End If
        End With

    End Sub

    Public Sub Load_SSO()
        Dim aa As String
        Dim rs As New ADODB.Recordset
        aa = " SELECT TOP 1 *   FROM SSO  order by DT_SSO desc  "

        Call LoadRs(aa, rs)
        With rs
            If rs.RecordCount <> 0 Then

                SSO_Employee = .Fields("employee").Value.ToString
                SSO_Employer = .Fields("employer").Value.ToString

            End If
        End With
    End Sub
    Public Sub load_overtime()
        'Level, Day_year, Ann_Day, Day_Month, Hour_Day, SSO_Com, SSO_Em, AGL_in, AGL_out
        Dim dd As String
        Dim rs As New ADODB.Recordset
        dd = " SELECT TOP 1 *  FROM UnitSalary   order by AtMonth desc  "
        Call LoadRs(dd, rs)
        With rs
            If rs.RecordCount <> 0 Then
                Level = .Fields("LevelID").Value.ToString
                Day_year = Format(CDbl(.Fields("WorkYearDays").Value), "##,##0")
                Ann_Day = Format(CDbl(.Fields("AnnualDays").Value), "##,##0")
                Day_Month = Format(CDbl(.Fields("WorkDays").Value), "##,##0")
                Hour_Day = Format(CDbl(.Fields("WorkHours").Value), "##,##0")
                SSO_Com = Format(CDbl(.Fields("PCompanySocial").Value), "##,##0")
                SSO_Em = Format(CDbl(.Fields("PPersonSocial").Value), "##,##0")
                AGL_in = Format(CDbl(.Fields("AGLInsuranceIn").Value), "##,##0.00")
                AGL_out = Format(CDbl(.Fields("AGLInsuranceOut").Value), "##,##0.00")

                Cost_of_living = Format(CDbl(.Fields("Cost_of_living").Value), "##,##0.00")
            End If
        End With
    End Sub
    Public Sub Load_Rate()
        Dim aa As String
        Dim rs As New ADODB.Recordset
        aa = " SELECT TOP 1 *   FROM AP_Rate_Item  where cuntry =N'" & Rate_set & "' order by Dt_Rate desc  "
        Call LoadRs(aa, rs)
        With rs
            If rs.RecordCount <> 0 Then
                Rate_All = Format(CDbl(.Fields("money").Value), "##,##0.00")
                DT_rate = Format(CDate(.Fields("Dt_Rate").Value), "dd-MM-yyyy")
                'Public MWorking As Date = Format(Date.Now, "dd-MM-yyyy")
            End If
        End With
    End Sub
End Module
