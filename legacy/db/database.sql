USE [master]
GO
/****** Object:  Database [AP_Personal_LA]    Script Date: 17/09/2026 5:02:32 PM ******/
CREATE DATABASE [AP_Personal_LA]
 CONTAINMENT = NONE
 ON  PRIMARY
( NAME = N'AP_SATA', FILENAME = N'D:\APIS_SOFTWARE\AP_Personal_LA.mdf' , SIZE = 1778496KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON
( NAME = N'AP_SATA_log', FILENAME = N'D:\APIS_SOFTWARE\AP_Personal_LA.ldf' , SIZE = 4672KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AP_Personal_LA] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AP_Personal_LA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AP_Personal_LA] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [AP_Personal_LA] SET ANSI_NULLS OFF
GO
ALTER DATABASE [AP_Personal_LA] SET ANSI_PADDING OFF
GO
ALTER DATABASE [AP_Personal_LA] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [AP_Personal_LA] SET ARITHABORT OFF
GO
ALTER DATABASE [AP_Personal_LA] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [AP_Personal_LA] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [AP_Personal_LA] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [AP_Personal_LA] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [AP_Personal_LA] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [AP_Personal_LA] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [AP_Personal_LA] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [AP_Personal_LA] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [AP_Personal_LA] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [AP_Personal_LA] SET  DISABLE_BROKER
GO
ALTER DATABASE [AP_Personal_LA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [AP_Personal_LA] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [AP_Personal_LA] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [AP_Personal_LA] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [AP_Personal_LA] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [AP_Personal_LA] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [AP_Personal_LA] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [AP_Personal_LA] SET RECOVERY SIMPLE
GO
ALTER DATABASE [AP_Personal_LA] SET  MULTI_USER
GO
ALTER DATABASE [AP_Personal_LA] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [AP_Personal_LA] SET DB_CHAINING OFF
GO
ALTER DATABASE [AP_Personal_LA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
GO
ALTER DATABASE [AP_Personal_LA] SET TARGET_RECOVERY_TIME = 0 SECONDS
GO
ALTER DATABASE [AP_Personal_LA] SET DELAYED_DURABILITY = DISABLED
GO
ALTER DATABASE [AP_Personal_LA] SET ACCELERATED_DATABASE_RECOVERY = OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'AP_Personal_LA', N'ON'
GO
ALTER DATABASE [AP_Personal_LA] SET QUERY_STORE = OFF
GO
USE [AP_Personal_LA]
GO
/****** Object:  Table [dbo].[AP_Books]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Books](
	[Bill_no] [nvarchar](50) NULL,
	[Bill_Dt] [datetime] NULL,
	[Cust_nm] [nvarchar](50) NULL,
	[Book_id] [nvarchar](50) NULL,
	[Dist_locat] [nvarchar](50) NULL,
	[Bar_Code] [nvarchar](50) NULL,
	[Place_id] [nvarchar](50) NULL,
	[Place] [nvarchar](50) NULL,
	[Health_Service_id] [nvarchar](50) NULL,
	[Health_Service] [nvarchar](50) NULL,
	[Age] [float] NULL,
	[Height] [nvarchar](50) NULL,
	[Profession] [nvarchar](250) NULL,
	[Work_Add] [nvarchar](250) NULL,
	[Dad_Name] [nvarchar](250) NULL,
	[BabyTh] [float] NULL,
	[Baby_Name] [nvarchar](250) NULL,
	[PV_id] [nvarchar](50) NULL,
	[Dt_ID] [nvarchar](50) NULL,
	[Vl_Id] [nvarchar](50) NULL,
	[Mobile1] [nvarchar](50) NULL,
	[Mobile2] [nvarchar](50) NULL,
	[Unit] [nvarchar](50) NULL,
	[BirthM] [nvarchar](1) NULL,
	[Date_of_BirthM] [datetime] NULL,
	[Last_Date] [datetime] NULL,
	[Expect_Date] [datetime] NULL,
	[Birth_Date] [datetime] NULL,
	[Remark] [nvarchar](500) NULL,
	[Vaccin_Check] [nvarchar](1) NULL,
	[Vaccin_No] [nvarchar](1) NULL,
	[Vaccin_Date] [nvarchar](50) NULL,
	[Chk_SSO] [nvarchar](1) NULL,
	[Chk_SASS] [nvarchar](1) NULL,
	[Chk_SSO_S] [nvarchar](1) NULL,
	[Chk_PRF] [nvarchar](1) NULL,
	[Chk_other] [nvarchar](50) NULL,
	[AGL_Comment] [nvarchar](50) NULL,
	[Tolet_Chk] [nvarchar](1) NULL,
	[Tolet_nm] [nvarchar](50) NULL,
	[Tolet_ID] [nvarchar](50) NULL,
	[Tolet] [nvarchar](50) NULL,
	[Watter_id] [nvarchar](50) NULL,
	[Watter] [nvarchar](50) NULL,
	[Stff_Id] [nvarchar](50) NULL,
	[Get_date] [datetime] NULL,
	[lst_usr] [nvarchar](50) NULL,
	[Pc_nm] [nvarchar](150) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Books_Item]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Books_Item](
	[Bill_no] [nvarchar](50) NULL,
	[Vaccin_No] [nvarchar](50) NULL,
	[Vacin_Date] [nvarchar](50) NULL,
	[Docter_Nm] [nvarchar](50) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Brith_Data]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Brith_Data](
	[Brith_no] [nvarchar](50) NULL,
	[B_Date] [datetime] NULL,
	[Book_id] [nvarchar](50) NULL,
	[Bar_Code] [nvarchar](50) NULL,
	[M_Name] [nvarchar](100) NULL,
	[Place_ID] [nvarchar](100) NULL,
	[Place] [nvarchar](100) NULL,
	[Health_Service_id] [nvarchar](50) NULL,
	[Health_Service] [nvarchar](100) NULL,
	[Moving_Service_id] [nvarchar](1) NULL,
	[Moving_Service] [nvarchar](100) NULL,
	[B_Time] [nvarchar](50) NULL,
	[Doctor_Name] [nvarchar](100) NULL,
	[Deliver_Name] [nvarchar](100) NULL,
	[Birth_Tools] [nvarchar](50) NULL,
	[Birth_Type_id] [nvarchar](1) NULL,
	[Birth_Type] [nvarchar](50) NULL,
	[Baby_ID] [nvarchar](50) NULL,
	[Bar_Code_Baby] [nvarchar](50) NULL,
	[Baby_Name] [nvarchar](50) NULL,
	[Baby_Health_But] [nvarchar](1) NULL,
	[Baby_Health_But_Nm] [nvarchar](50) NULL,
	[Baby_Health_But_Time] [nvarchar](20) NULL,
	[Baby_Health_id] [nvarchar](1) NULL,
	[Baby_Health] [nvarchar](50) NULL,
	[Baby_Health_Time] [decimal](18, 0) NULL,
	[ABKA_1] [nvarchar](50) NULL,
	[ABKA_5] [nvarchar](50) NULL,
	[Innormal_ID] [nvarchar](1) NULL,
	[Innormal] [nvarchar](100) NULL,
	[Weight] [decimal](18, 0) NULL,
	[Height] [decimal](18, 0) NULL,
	[HopErk] [decimal](18, 0) NULL,
	[HopHov] [decimal](18, 0) NULL,
	[Gender] [nvarchar](50) NULL,
	[Pregn_Age] [decimal](18, 0) NULL,
	[Temperature] [decimal](18, 0) NULL,
	[Kamajone] [decimal](18, 0) NULL,
	[Blood_Pressure1] [decimal](18, 0) NULL,
	[Blood_Pressure2] [decimal](18, 0) NULL,
	[Symptom_ID] [nvarchar](50) NULL,
	[Symptom] [nvarchar](50) NULL,
	[Symptom_Com] [nvarchar](50) NULL,
	[Remark] [nvarchar](500) NULL,
	[Vaccin1] [nvarchar](1) NULL,
	[Vaccin2] [nvarchar](1) NULL,
	[Baby_Eat_Milk] [nvarchar](1) NULL,
	[Baby_death] [nvarchar](1) NULL,
	[Baby_death_Why] [nvarchar](100) NULL,
	[Nathong_ID] [nvarchar](1) NULL,
	[Nathong] [nvarchar](50) NULL,
	[Nathong_Com] [nvarchar](50) NULL,
	[Position_ID] [nvarchar](1) NULL,
	[Position] [nvarchar](50) NULL,
	[Position_Com] [nvarchar](100) NULL,
	[Uterus_ID] [nvarchar](50) NULL,
	[Uterus] [nvarchar](50) NULL,
	[fish_Watter_ID] [nvarchar](50) NULL,
	[fish_Watter] [nvarchar](50) NULL,
	[Have90Unit] [nvarchar](1) NULL,
	[Chk_ath_ID] [nvarchar](1) NULL,
	[Mom_Death_ID] [nvarchar](1) NULL,
	[Mom_Death] [nvarchar](50) NULL,
	[Mom_Death_Time] [nvarchar](10) NULL,
	[MomSymptom_ID] [nvarchar](50) NULL,
	[MomSymptom] [nvarchar](50) NULL,
	[MomSymptom_Com] [nvarchar](50) NULL,
	[Stff_Id] [nvarchar](50) NULL,
	[office] [nvarchar](50) NULL,
	[Get_date] [datetime] NULL,
	[lst_usr] [nvarchar](50) NULL,
	[Pc_nm] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Brith_Data_List]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Brith_Data_List](
	[Brith_no] [nvarchar](50) NULL,
	[B_Date] [datetime] NULL,
	[Book_id] [nvarchar](50) NULL,
	[Bar_Code] [nvarchar](50) NULL,
	[M_Name] [nvarchar](100) NULL,
	[Place_id] [nvarchar](50) NULL,
	[Place] [nvarchar](100) NULL,
	[Health_Service_id] [nvarchar](50) NULL,
	[Health_Service] [nvarchar](100) NULL,
	[Moving_Service_id] [nvarchar](1) NULL,
	[Moving_Service] [nvarchar](100) NULL,
	[B_Time] [nvarchar](50) NULL,
	[Doctor_Name] [nvarchar](100) NULL,
	[Deliver_Name] [nvarchar](100) NULL,
	[Birth_Tools] [nvarchar](50) NULL,
	[Birth_Type_id] [nvarchar](1) NULL,
	[Birth_Type] [nvarchar](50) NULL,
	[Baby_ID] [nvarchar](50) NULL,
	[Bar_Code_Baby] [nvarchar](50) NULL,
	[Baby_Name] [nvarchar](50) NULL,
	[Baby_Health_But] [nvarchar](1) NULL,
	[Baby_Health_But_Nm] [nvarchar](50) NULL,
	[Baby_Health_But_Time] [nvarchar](20) NULL,
	[Baby_Health_id] [nvarchar](1) NULL,
	[Baby_Health] [nvarchar](50) NULL,
	[Baby_Health_Time] [decimal](18, 0) NULL,
	[ABKA_1] [nvarchar](50) NULL,
	[ABKA_5] [nvarchar](50) NULL,
	[Innormal_ID] [nvarchar](1) NULL,
	[Innormal] [nvarchar](100) NULL,
	[Weight] [decimal](18, 0) NULL,
	[Height] [decimal](18, 0) NULL,
	[HopErk] [decimal](18, 0) NULL,
	[HopHov] [decimal](18, 0) NULL,
	[Gender] [nvarchar](50) NULL,
	[Pregn_Age] [decimal](18, 0) NULL,
	[Temperature] [decimal](18, 0) NULL,
	[Kamajone] [decimal](18, 0) NULL,
	[Blood_Pressure1] [decimal](18, 0) NULL,
	[Blood_Pressure2] [decimal](18, 0) NULL,
	[Symptom_ID] [nvarchar](50) NULL,
	[Symptom] [nvarchar](50) NULL,
	[Symptom_Com] [nvarchar](50) NULL,
	[Remark] [nvarchar](500) NULL,
	[Vaccin1] [nvarchar](1) NULL,
	[Vaccin2] [nvarchar](1) NULL,
	[Baby_Eat_Milk] [nvarchar](1) NULL,
	[Baby_death] [nvarchar](1) NULL,
	[Baby_death_ID] [nvarchar](1) NULL,
	[Baby_death_Type] [nvarchar](50) NULL,
	[Baby_death_Why] [nvarchar](100) NULL,
	[Nathong_ID] [nvarchar](1) NULL,
	[Nathong] [nvarchar](50) NULL,
	[Nathong_Com] [nvarchar](50) NULL,
	[Position_ID] [nvarchar](1) NULL,
	[Position] [nvarchar](50) NULL,
	[Position_Com] [nvarchar](100) NULL,
	[Uterus_ID] [nvarchar](50) NULL,
	[Uterus] [nvarchar](50) NULL,
	[fish_Watter_ID] [nvarchar](50) NULL,
	[fish_Watter] [nvarchar](50) NULL,
	[Have90Unit] [nvarchar](1) NULL,
	[Chk_ath_ID] [nvarchar](1) NULL,
	[Mom_Death_ID] [nvarchar](1) NULL,
	[Mom_Death] [nvarchar](50) NULL,
	[Mom_Death_Time] [nvarchar](10) NULL,
	[Uterus_Position] [decimal](18, 0) NULL,
	[Hopthong] [decimal](18, 0) NULL,
	[MomSymptom_ID] [nvarchar](50) NULL,
	[MomSymptom] [nvarchar](50) NULL,
	[MomSymptom_Com] [nvarchar](50) NULL,
	[VitaminK] [nvarchar](1) NULL,
	[Stff_Id] [nvarchar](50) NULL,
	[office] [nvarchar](50) NULL,
	[Get_date] [datetime] NULL,
	[lst_usr] [nvarchar](50) NULL,
	[Pc_nm] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Customers]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Customers](
	[Shop_ID] [nvarchar](50) NULL,
	[Cty_id] [nvarchar](50) NULL,
	[Cust_id] [nvarchar](50) NULL,
	[Cust_nmL] [nvarchar](50) NULL,
	[Cust_nmE] [nvarchar](50) NULL,
	[street] [nvarchar](50) NULL,
	[Village] [nvarchar](50) NULL,
	[District] [nvarchar](50) NULL,
	[Province] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Fax] [nvarchar](50) NULL,
	[Bank_accnt] [nvarchar](50) NULL,
	[Contact_PP] [nvarchar](50) NULL,
	[Lst_order] [datetime] NULL,
	[Remark] [nvarchar](200) NULL,
	[Lst_updt] [datetime] NULL,
	[Lst_usr] [nvarchar](50) NULL,
	[Pc_nm] [nvarchar](50) NULL,
	[Rec_Cnt] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[Advance] [nvarchar](50) NULL,
	[Cust_Com] [float] NULL,
	[Cust_Over] [float] NULL,
	[LocatID] [nchar](10) NULL,
	[cust_depart] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_CV]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_CV](
	[E_ID] [nvarchar](50) NULL,
	[Sections_id] [nvarchar](200) NULL,
	[Sections] [nvarchar](200) NULL,
	[Department_id] [nvarchar](50) NULL,
	[Department] [nvarchar](200) NULL,
	[type_in_id] [nvarchar](50) NULL,
	[type_in_nm] [nvarchar](200) NULL,
	[Name_L] [nvarchar](200) NULL,
	[Name_E] [nvarchar](200) NULL,
	[Phone] [nvarchar](50) NULL,
	[Bank_no] [nvarchar](50) NULL,
	[SSO_no] [nvarchar](50) NULL,
	[DT_strt_work] [datetime] NULL,
	[start_work_ID] [nvarchar](50) NULL,
	[start_work] [nvarchar](50) NULL,
	[txtmoney_basic] [decimal](18, 0) NULL,
	[DT_Work_now] [datetime] NULL,
	[cmbclass] [nvarchar](50) NULL,
	[cmblevel] [nvarchar](50) NULL,
	[txtV_C] [nvarchar](50) NULL,
	[txt_parts_id] [nvarchar](50) NULL,
	[cmb_parts] [nvarchar](50) NULL,
	[txt_work_id] [nvarchar](50) NULL,
	[cmb_work] [nvarchar](50) NULL,
	[percen] [decimal](18, 0) NULL,
	[DOB] [datetime] NULL,
	[age] [nvarchar](50) NULL,
	[gender] [nvarchar](50) NULL,
	[BProv_ID] [nvarchar](50) NULL,
	[BVill_ID] [nvarchar](50) NULL,
	[Add_Vill_ID] [nvarchar](50) NULL,
	[houeNo] [nvarchar](50) NULL,
	[Road] [nvarchar](50) NULL,
	[Street] [nvarchar](50) NULL,
	[Card_no] [nvarchar](100) NULL,
	[dateOutID] [datetime] NULL,
	[txt_hours_money] [decimal](18, 0) NULL,
	[Level_Clss_Money] [decimal](18, 0) NULL,
	[Tumnang_Money] [decimal](18, 0) NULL,
	[year_money] [decimal](18, 0) NULL,
	[txttotal] [decimal](18, 0) NULL,
	[AGL] [decimal](18, 0) NULL,
	[Total_remaining] [decimal](18, 0) NULL,
	[Tax] [decimal](18, 0) NULL,
	[khongsep] [decimal](18, 0) NULL,
	[txtson] [decimal](18, 0) NULL,
	[txtson_Money] [decimal](18, 0) NULL,
	[txtmom] [decimal](18, 0) NULL,
	[txtMom_mony] [decimal](18, 0) NULL,
	[txtWomen_mony] [decimal](18, 0) NULL,
	[txtoil_mony] [decimal](18, 0) NULL,
	[txtPhone_money] [decimal](18, 0) NULL,
	[txtToltal_All] [decimal](18, 0) NULL,
	[chk_lut] [nvarchar](1) NULL,
	[dt_Lut] [datetime] NULL,
	[chk_Phuk_sumhong] [nvarchar](1) NULL,
	[Dt_Phuk_sumhong] [datetime] NULL,
	[chk_Phuk] [nvarchar](1) NULL,
	[Dt_Phuk] [datetime] NULL,
	[chk_Job_Phuk] [nvarchar](1) NULL,
	[job_phuk_ID] [nvarchar](50) NULL,
	[job_phuk] [nvarchar](100) NULL,
	[chk_job_lut] [nvarchar](1) NULL,
	[job_lut_ID] [nvarchar](50) NULL,
	[job_lut] [nvarchar](100) NULL,
	[txthong] [nvarchar](50) NULL,
	[chk_job_lut_visakan] [nvarchar](1) NULL,
	[job_lut_visakan] [nvarchar](100) NULL,
	[duties_Id] [nvarchar](50) NULL,
	[duties] [nvarchar](100) NULL,
	[chk_study] [nvarchar](1) NULL,
	[DT_study] [datetime] NULL,
	[chk_start] [nvarchar](1) NULL,
	[DT_Start] [datetime] NULL,
	[study_ID] [nvarchar](100) NULL,
	[study] [nvarchar](100) NULL,
	[txtvisa_id] [nvarchar](100) NULL,
	[txtvisa] [nvarchar](100) NULL,
	[Study_cuntry_id] [nvarchar](50) NULL,
	[Study_cuntry] [nvarchar](50) NULL,
	[chk_study2] [nvarchar](1) NULL,
	[DT_study2] [datetime] NULL,
	[txtstudy2] [nvarchar](100) NULL,
	[chk_lang] [nvarchar](1) NULL,
	[lang_ID] [nvarchar](100) NULL,
	[lang] [nvarchar](100) NULL,
	[CmbNation1_ID] [nvarchar](50) NULL,
	[CmbNation1] [nvarchar](50) NULL,
	[CmbNation2_ID] [nvarchar](50) NULL,
	[CmbNation2] [nvarchar](50) NULL,
	[CmbNation3_ID] [nvarchar](50) NULL,
	[CmbNation3] [nvarchar](50) NULL,
	[CmbReligion_id] [nvarchar](50) NULL,
	[CmbReligion] [nvarchar](100) NULL,
	[Status_son] [nvarchar](1) NULL,
	[Status_Mom] [nvarchar](1) NULL,
	[Status_donw] [nvarchar](1) NULL,
	[Status_Up] [nvarchar](1) NULL,
	[Status_Per_id] [nvarchar](100) NULL,
	[Status_Per] [nvarchar](100) NULL,
	[Status_out] [nvarchar](1) NULL,
	[lst_usr] [nvarchar](100) NULL,
	[lst_updt] [datetime] NULL,
	[Pc_nm] [nvarchar](100) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL,
	[order_no] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_District]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_District](
	[Dt_id] [nvarchar](50) NULL,
	[PV_id] [nvarchar](50) NULL,
	[Dt_nm] [nvarchar](250) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL,
	[dis] [nvarchar](50) NULL,
	[pro] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Donw_Personal]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Donw_Personal](
	[Bill_no] [nvarchar](50) NULL,
	[E_ID] [nvarchar](50) NULL,
	[DT_dn] [datetime] NULL,
	[Sections_id] [nvarchar](200) NULL,
	[Sections] [nvarchar](200) NULL,
	[Department_id] [nvarchar](50) NULL,
	[Department] [nvarchar](200) NULL,
	[Name_L] [nvarchar](200) NULL,
	[Name_E] [nvarchar](200) NULL,
	[Phone] [nvarchar](50) NULL,
	[Bank_no] [nvarchar](50) NULL,
	[SSO_no] [nvarchar](50) NULL,
	[percen_old] [decimal](18, 0) NULL,
	[txtclass_old] [nvarchar](50) NULL,
	[txtlevel_old] [nvarchar](50) NULL,
	[txtV_C_old] [nvarchar](50) NULL,
	[Level_Clss_Money_old] [decimal](18, 0) NULL,
	[txtclass] [nvarchar](50) NULL,
	[txtlevel] [nvarchar](50) NULL,
	[txtV_C] [nvarchar](50) NULL,
	[Level_Clss_Money] [decimal](18, 0) NULL,
	[Tumnang_Money] [decimal](18, 0) NULL,
	[year_money] [decimal](18, 0) NULL,
	[txttotal] [decimal](18, 0) NULL,
	[AGL] [decimal](18, 0) NULL,
	[Total_remaining] [decimal](18, 0) NULL,
	[Tax] [decimal](18, 0) NULL,
	[khongsep] [decimal](18, 0) NULL,
	[txtson] [decimal](18, 0) NULL,
	[txtson_Money] [decimal](18, 0) NULL,
	[txtmom] [decimal](18, 0) NULL,
	[txtMom_mony] [decimal](18, 0) NULL,
	[txtToltal_All] [decimal](18, 0) NULL,
	[txtkhor_tok_long] [nvarchar](100) NULL,
	[txtAccount_clss_level] [nvarchar](100) NULL,
	[type_dn_id] [nvarchar](50) NULL,
	[type_dn] [nvarchar](100) NULL,
	[percen] [decimal](18, 0) NULL,
	[remark] [nvarchar](500) NULL,
	[lst_updt] [datetime] NULL,
	[lst_usr] [nvarchar](100) NULL,
	[Pc_nm] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_E1]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_E1](
	[E1_Bill] [nvarchar](50) NULL,
	[DT_E1] [datetime] NULL,
	[Sections_id] [nvarchar](200) NULL,
	[Sections] [nvarchar](200) NULL,
	[Department_id] [nvarchar](50) NULL,
	[Department] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_E1_Item]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_E1_Item](
	[E1_Bill] [nvarchar](50) NULL,
	[visa_nm] [nvarchar](50) NULL,
	[E1_year] [nvarchar](50) NULL,
	[Total_in] [nvarchar](50) NULL,
	[ek_in] [nvarchar](50) NULL,
	[tho_in] [nvarchar](50) NULL,
	[tee_in] [nvarchar](50) NULL,
	[soung_in] [nvarchar](50) NULL,
	[kang_in] [nvarchar](50) NULL,
	[Total_out] [nvarchar](50) NULL,
	[ek_out] [nvarchar](50) NULL,
	[tho_out] [nvarchar](50) NULL,
	[tee_out] [nvarchar](50) NULL,
	[soung_out] [nvarchar](50) NULL,
	[kang_out] [nvarchar](50) NULL,
	[reamrk] [nvarchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Employee_out]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Employee_out](
	[Bill_no] [nvarchar](50) NULL,
	[DT_out] [datetime] NULL,
	[E_ID] [nvarchar](50) NULL,
	[Sections_id] [nvarchar](200) NULL,
	[Sections] [nvarchar](200) NULL,
	[Department_id] [nvarchar](50) NULL,
	[Department] [nvarchar](200) NULL,
	[type_in_id] [nvarchar](50) NULL,
	[type_in_nm] [nvarchar](200) NULL,
	[Name_L] [nvarchar](200) NULL,
	[Name_E] [nvarchar](200) NULL,
	[Phone] [nvarchar](50) NULL,
	[Bank_no] [nvarchar](50) NULL,
	[SSO_no] [nvarchar](50) NULL,
	[DT_strt_work] [datetime] NULL,
	[start_work_ID] [nvarchar](50) NULL,
	[start_work] [nvarchar](50) NULL,
	[txtmoney_basic] [decimal](18, 0) NULL,
	[DT_Work_now] [datetime] NULL,
	[cmbclass] [nvarchar](50) NULL,
	[cmblevel] [nvarchar](50) NULL,
	[txtV_C] [nvarchar](50) NULL,
	[txt_parts_id] [nvarchar](50) NULL,
	[cmb_parts] [nvarchar](50) NULL,
	[txt_work_id] [nvarchar](50) NULL,
	[cmb_work] [nvarchar](50) NULL,
	[percen] [decimal](18, 0) NULL,
	[DOB] [datetime] NULL,
	[age] [nvarchar](50) NULL,
	[gender] [nvarchar](50) NULL,
	[BProv_ID] [nvarchar](50) NULL,
	[BVill_ID] [nvarchar](50) NULL,
	[Add_Vill_ID] [nvarchar](50) NULL,
	[houeNo] [nvarchar](50) NULL,
	[Road] [nvarchar](50) NULL,
	[Street] [nvarchar](50) NULL,
	[Card_no] [nvarchar](100) NULL,
	[dateOutID] [datetime] NULL,
	[txt_hours_money] [decimal](18, 0) NULL,
	[Level_Clss_Money] [decimal](18, 0) NULL,
	[Tumnang_Money] [decimal](18, 0) NULL,
	[year_money] [decimal](18, 0) NULL,
	[txttotal] [decimal](18, 0) NULL,
	[AGL] [decimal](18, 0) NULL,
	[Total_remaining] [decimal](18, 0) NULL,
	[Tax] [decimal](18, 0) NULL,
	[khongsep] [decimal](18, 0) NULL,
	[txtson] [decimal](18, 0) NULL,
	[txtson_Money] [decimal](18, 0) NULL,
	[txtmom] [decimal](18, 0) NULL,
	[txtMom_mony] [decimal](18, 0) NULL,
	[txtWomen_mony] [decimal](18, 0) NULL,
	[txtoil_mony] [decimal](18, 0) NULL,
	[txtPhone_money] [decimal](18, 0) NULL,
	[txtToltal_All] [decimal](18, 0) NULL,
	[chk_lut] [nvarchar](1) NULL,
	[dt_Lut] [datetime] NULL,
	[chk_Phuk_sumhong] [nvarchar](1) NULL,
	[Dt_Phuk_sumhong] [datetime] NULL,
	[chk_Phuk] [nvarchar](1) NULL,
	[Dt_Phuk] [datetime] NULL,
	[chk_Job_Phuk] [nvarchar](1) NULL,
	[job_phuk_ID] [nvarchar](50) NULL,
	[job_phuk] [nvarchar](100) NULL,
	[chk_job_lut] [nvarchar](1) NULL,
	[job_lut_ID] [nvarchar](50) NULL,
	[job_lut] [nvarchar](100) NULL,
	[txthong] [nvarchar](50) NULL,
	[chk_job_lut_visakan] [nvarchar](1) NULL,
	[job_lut_visakan] [nvarchar](100) NULL,
	[duties_Id] [nvarchar](50) NULL,
	[duties] [nvarchar](100) NULL,
	[chk_study] [nvarchar](1) NULL,
	[DT_study] [datetime] NULL,
	[chk_start] [nvarchar](1) NULL,
	[DT_Start] [datetime] NULL,
	[study_ID] [nvarchar](100) NULL,
	[study] [nvarchar](100) NULL,
	[txtvisa_id] [nvarchar](100) NULL,
	[txtvisa] [nvarchar](100) NULL,
	[Study_cuntry_id] [nvarchar](50) NULL,
	[Study_cuntry] [nvarchar](50) NULL,
	[chk_study2] [nvarchar](1) NULL,
	[DT_study2] [datetime] NULL,
	[txtstudy2] [nvarchar](100) NULL,
	[chk_lang] [nvarchar](1) NULL,
	[lang_ID] [nvarchar](100) NULL,
	[lang] [nvarchar](100) NULL,
	[CmbNation1_ID] [nvarchar](50) NULL,
	[CmbNation1] [nvarchar](50) NULL,
	[CmbNation2_ID] [nvarchar](50) NULL,
	[CmbNation2] [nvarchar](50) NULL,
	[CmbNation3_ID] [nvarchar](50) NULL,
	[CmbNation3] [nvarchar](50) NULL,
	[CmbReligion_id] [nvarchar](50) NULL,
	[CmbReligion] [nvarchar](100) NULL,
	[Status_son] [nvarchar](1) NULL,
	[Status_Mom] [nvarchar](1) NULL,
	[Status_donw] [nvarchar](1) NULL,
	[Status_Up] [nvarchar](1) NULL,
	[Status_Per_id] [nvarchar](100) NULL,
	[Status_Per] [nvarchar](100) NULL,
	[Status_out] [nvarchar](1) NULL,
	[lst_usr] [nvarchar](100) NULL,
	[lst_updt] [datetime] NULL,
	[Pc_nm] [nvarchar](100) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL,
	[abount] [nvarchar](500) NULL,
	[remark] [nvarchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ap_Employee_take_leave]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ap_Employee_take_leave](
	[Bill_no] [nvarchar](50) NULL,
	[DT_from] [datetime] NULL,
	[DT_to] [datetime] NULL,
	[E_ID] [nvarchar](50) NULL,
	[qty_day] [decimal](18, 0) NULL,
	[about] [nvarchar](500) NULL,
	[Remark] [nvarchar](500) NULL,
	[lst_usr] [nvarchar](100) NULL,
	[lst_updt] [datetime] NULL,
	[Pc_nm] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Employee_Tecket]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Employee_Tecket](
	[Bill_no] [nvarchar](50) NULL,
	[DT_year] [datetime] NULL,
	[E_ID] [nvarchar](50) NULL,
	[E_nm] [nvarchar](50) NULL,
	[Tecket_year] [decimal](18, 0) NULL,
	[Tecket_use] [decimal](18, 0) NULL,
	[about] [nvarchar](500) NULL,
	[Remark] [nvarchar](500) NULL,
	[lst_usr] [nvarchar](100) NULL,
	[lst_updt] [datetime] NULL,
	[Pc_nm] [nvarchar](100) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Employee_Tecket_item]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Employee_Tecket_item](
	[Bill_no] [nvarchar](50) NULL,
	[E_ID] [nvarchar](50) NULL,
	[detail] [nvarchar](500) NULL,
	[gave_to] [nvarchar](50) NULL,
	[Nm_family] [nvarchar](200) NULL,
	[Day_year] [nvarchar](50) NULL,
	[sick] [nvarchar](50) NULL,
	[QTY_Ticket] [nvarchar](50) NULL,
	[FOC] [nvarchar](50) NULL,
	[to_90] [nvarchar](50) NULL,
	[to_75] [nvarchar](50) NULL,
	[to_50] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_EN]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_EN](
	[EN_bill] [nvarchar](50) NULL,
	[EN_DT] [datetime] NULL,
	[Sections_id] [nvarchar](200) NULL,
	[Sections] [nvarchar](200) NULL,
	[Department_id] [nvarchar](50) NULL,
	[Department] [nvarchar](200) NULL,
	[year_to] [nvarchar](50) NULL,
	[year1] [nvarchar](50) NULL,
	[year2] [nvarchar](50) NULL,
	[year3] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_EN_Item]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_EN_Item](
	[EN_Bill] [nvarchar](50) NULL,
	[EN_ID] [nvarchar](50) NULL,
	[EN_nm] [nvarchar](100) NULL,
	[Toltal_all] [nvarchar](50) NULL,
	[Toltal_now] [nvarchar](50) NULL,
	[borlihan_now] [nvarchar](50) NULL,
	[visakan_now] [nvarchar](50) NULL,
	[Toltal] [nvarchar](50) NULL,
	[borlihan] [nvarchar](50) NULL,
	[visakan] [nvarchar](50) NULL,
	[EN_year1] [nvarchar](50) NULL,
	[EN_year2] [nvarchar](50) NULL,
	[EN_year3] [nvarchar](50) NULL,
	[Remark] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_EP]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_EP](
	[EP_Bill] [nvarchar](50) NULL,
	[DT_EP] [datetime] NULL,
	[Sections_id] [nvarchar](200) NULL,
	[Sections] [nvarchar](200) NULL,
	[Department_id] [nvarchar](50) NULL,
	[Department] [nvarchar](200) NULL,
	[Remark] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_EP_Item]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_EP_Item](
	[EP_Bill] [nvarchar](50) NULL,
	[EP_ID] [nvarchar](50) NULL,
	[EP_nm] [nvarchar](50) NULL,
	[EP_year] [nvarchar](50) NULL,
	[EP_Total] [decimal](18, 0) NULL,
	[EP1] [decimal](18, 0) NULL,
	[EP2] [decimal](18, 0) NULL,
	[EP3] [decimal](18, 0) NULL,
	[EP4] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ap_Image]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ap_Image](
	[Img_Id] [varchar](50) NULL,
	[ImgType] [nvarchar](50) NULL,
	[Img] [image] NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Location_Hos_Center]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Location_Hos_Center](
	[Hos_id] [nvarchar](50) NULL,
	[BK_ID] [nvarchar](50) NULL,
	[Bk_nm] [nvarchar](250) NULL,
	[sym] [nvarchar](50) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Mom_Money]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Mom_Money](
	[bill_no] [nvarchar](50) NULL,
	[DT_in] [datetime] NULL,
	[E_ID] [nvarchar](50) NULL,
	[Sections_id] [nvarchar](200) NULL,
	[Sections] [nvarchar](200) NULL,
	[Department_id] [nvarchar](50) NULL,
	[Department] [nvarchar](200) NULL,
	[Name_L] [nvarchar](200) NULL,
	[Name_E] [nvarchar](200) NULL,
	[Phone] [nvarchar](50) NULL,
	[txtmom] [decimal](18, 0) NULL,
	[txtmom_Money] [decimal](18, 0) NULL,
	[txtabount_mom] [nvarchar](500) NULL,
	[remark] [nvarchar](500) NULL,
	[Bill_cancel] [nvarchar](50) NULL,
	[DT_cancel] [datetime] NULL,
	[status] [nvarchar](1) NULL,
	[status_nm] [nvarchar](50) NULL,
	[lst_updt] [datetime] NULL,
	[lst_usr] [nvarchar](100) NULL,
	[Pc_nm] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Office]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Office](
	[off_id] [nvarchar](50) NOT NULL,
	[off_nm] [nvarchar](100) NULL,
	[off_nmE] [nvarchar](100) NULL,
	[off_StrtL] [nvarchar](50) NULL,
	[off_StrtE] [nvarchar](50) NULL,
	[off_NoL] [nvarchar](50) NULL,
	[off_NoE] [nvarchar](50) NULL,
	[off_VillageL] [nvarchar](50) NULL,
	[Off_VillageE] [nvarchar](50) NULL,
	[Off_DistL] [nvarchar](50) NULL,
	[Off_DistE] [nvarchar](50) NULL,
	[Off_ProvL] [nvarchar](50) NULL,
	[Off_ProvE] [nvarchar](50) NULL,
	[Tel] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[Logo] [image] NULL,
	[Logo_W] [float] NULL,
	[Logo_H] [float] NULL,
	[TIN] [nvarchar](50) NULL,
	[Bnk1] [nvarchar](50) NULL,
	[Bnk2] [nvarchar](50) NULL,
	[Bnk3] [nvarchar](50) NULL,
	[Acc1] [nvarchar](50) NULL,
	[Acc2] [nvarchar](50) NULL,
	[Acc3] [nvarchar](50) NULL,
	[AddressPic] [nvarchar](100) NULL,
	[Sec_tel] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[com_logo] [image] NULL,
	[ID] [nchar](10) NULL,
	[index_monney] [decimal](18, 0) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Organization]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Organization](
	[bill_no] [nvarchar](50) NULL,
	[E_ID] [nvarchar](50) NULL,
	[Name_L] [nvarchar](200) NULL,
	[chk_lut] [nvarchar](1) NULL,
	[dt_Lut] [datetime] NULL,
	[txtjob_In_lut] [nvarchar](200) NULL,
	[txtlocatoin_In_lut] [nvarchar](200) NULL,
	[chk_In_Independence] [nvarchar](1) NULL,
	[Dt_In_Independence] [datetime] NULL,
	[txt_job_In_Independence] [nvarchar](200) NULL,
	[txtlocation_In_Independence] [nvarchar](200) NULL,
	[Chk_INreform] [nvarchar](1) NULL,
	[DT_IndependenceDate] [datetime] NULL,
	[txtJob_Independence] [nvarchar](200) NULL,
	[txtlocation_Independence] [nvarchar](200) NULL,
	[chk_Phuk_sumhong] [nvarchar](1) NULL,
	[Dt_Phuk_sumhong] [datetime] NULL,
	[txtthe_committee] [nvarchar](200) NULL,
	[chk_Phuk] [nvarchar](1) NULL,
	[Dt_Phuk] [datetime] NULL,
	[txtlocation] [nvarchar](200) NULL,
	[Chk_young] [nvarchar](1) NULL,
	[DT_young] [datetime] NULL,
	[txtlocation_young] [nvarchar](200) NULL,
	[Chk_khummaban] [nvarchar](1) NULL,
	[Dt_khummaban] [datetime] NULL,
	[txtlocation_khummaban] [nvarchar](200) NULL,
	[Chk_woman] [nvarchar](1) NULL,
	[Dt_woman] [datetime] NULL,
	[txtlocationU_woman] [nvarchar](200) NULL,
	[lst_usr] [nvarchar](100) NULL,
	[lst_updt] [datetime] NULL,
	[Pc_nm] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Persion_Family]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Persion_Family](
	[bill_no] [nvarchar](50) NULL,
	[E_ID] [nvarchar](50) NULL,
	[Name_L] [nvarchar](200) NULL,
	[txtname_relation] [nvarchar](200) NULL,
	[txt_Relation_id] [nvarchar](50) NULL,
	[cmb_Relation] [nvarchar](50) NULL,
	[DT_DOB] [datetime] NULL,
	[txtB_VillID] [nvarchar](50) NULL,
	[txtA_VillID] [nvarchar](50) NULL,
	[txtJobBefore] [nvarchar](200) NULL,
	[txtsection_JobBefore] [nvarchar](200) NULL,
	[txtlocation_JobBefore] [nvarchar](200) NULL,
	[txtJobAfter] [nvarchar](200) NULL,
	[txtsection_JobAfter] [nvarchar](200) NULL,
	[txtlocation_JobAfter] [nvarchar](200) NULL,
	[txtDetil] [nvarchar](500) NULL,
	[lst_usr] [nvarchar](100) NULL,
	[lst_updt] [datetime] NULL,
	[Pc_nm] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Persion_Health]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Persion_Health](
	[bill_no] [nvarchar](50) NULL,
	[E_ID] [nvarchar](50) NULL,
	[Name_L] [nvarchar](200) NULL,
	[txt_higth] [decimal](18, 0) NULL,
	[txtBlood_ID] [nvarchar](50) NULL,
	[txtBlood_nm] [nvarchar](50) NULL,
	[txt_H1_id] [nvarchar](1) NULL,
	[txt_H1_nm] [nvarchar](50) NULL,
	[txt_H2_id] [nvarchar](1) NULL,
	[txt_H2_nm] [nvarchar](50) NULL,
	[txt_H3_id] [nvarchar](1) NULL,
	[txt_H3_nm] [nvarchar](50) NULL,
	[txt_H4_id] [nvarchar](1) NULL,
	[txt_H4_nm] [nvarchar](50) NULL,
	[DT_exhausted] [datetime] NULL,
	[txt_exhausted] [nvarchar](100) NULL,
	[DT_disease] [datetime] NULL,
	[txt_disease] [nvarchar](100) NULL,
	[chk_disabled_Type] [nvarchar](1) NULL,
	[chk_disabled1] [nvarchar](1) NULL,
	[txr_disabled1_nm] [nvarchar](50) NULL,
	[chk_disabled2] [nvarchar](1) NULL,
	[txr_disabled2_nm] [nvarchar](50) NULL,
	[chk_disabled3] [nvarchar](1) NULL,
	[txr_disabled3_nm] [nvarchar](50) NULL,
	[DT_disabled] [datetime] NULL,
	[txt_disabled] [nvarchar](500) NULL,
	[lst_usr] [nvarchar](100) NULL,
	[lst_updt] [datetime] NULL,
	[Pc_nm] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Persion_Study]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Persion_Study](
	[bill_no] [nvarchar](50) NULL,
	[E_ID] [nvarchar](50) NULL,
	[Name_L] [nvarchar](200) NULL,
	[txtsamun_id] [nvarchar](1) NULL,
	[txtsamun] [nvarchar](50) NULL,
	[txtstudy_id] [nvarchar](50) NULL,
	[cmb_study] [nvarchar](200) NULL,
	[txtvisa_id] [nvarchar](50) NULL,
	[cmb_visa] [nvarchar](200) NULL,
	[txt_Nation_id] [nvarchar](50) NULL,
	[cmb_Nation] [nvarchar](200) NULL,
	[DT_Finish] [datetime] NULL,
	[chk_lang] [nvarchar](1) NULL,
	[txtlang_id] [nvarchar](50) NULL,
	[cmb_lang] [nvarchar](200) NULL,
	[remark] [nvarchar](500) NULL,
	[lst_usr] [nvarchar](100) NULL,
	[lst_updt] [datetime] NULL,
	[Pc_nm] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Position]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Position](
	[bill_no] [nvarchar](50) NULL,
	[DT_Pos] [datetime] NULL,
	[E_ID] [nvarchar](50) NULL,
	[Name_L] [nvarchar](200) NULL,
	[chk_Job_Phuk] [nvarchar](1) NULL,
	[job_phuk_ID] [nvarchar](50) NULL,
	[job_phuk] [nvarchar](100) NULL,
	[chk_job_lut] [nvarchar](1) NULL,
	[job_lut_ID] [nvarchar](50) NULL,
	[job_lut] [nvarchar](100) NULL,
	[chk_job_lut_visakan] [nvarchar](1) NULL,
	[job_lut_visakan] [nvarchar](100) NULL,
	[duties_Id] [nvarchar](50) NULL,
	[duties] [nvarchar](100) NULL,
	[txtremark] [nvarchar](500) NULL,
	[lst_usr] [nvarchar](100) NULL,
	[lst_updt] [datetime] NULL,
	[Pc_nm] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Province]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Province](
	[PV_ID] [nvarchar](50) NULL,
	[PV_nm] [nvarchar](250) NULL,
	[Prov_Sym] [nvarchar](50) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Rate]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Rate](
	[Curr] [char](10) NULL,
	[status] [int] NULL,
	[rate_dt] [datetime] NULL,
	[LAK] [float] NULL,
	[THB] [float] NULL,
	[USD] [float] NULL,
	[EUR] [float] NULL,
	[EUR_LAK] [float] NULL,
	[USD_LAK] [float] NULL,
	[THB_LAK] [float] NULL,
	[EUR_THB] [float] NULL,
	[USD_THB] [float] NULL,
	[EUR_USD] [float] NULL,
	[User_updt] [nvarchar](50) NULL,
	[lst_updt] [datetime] NULL,
	[Pc_nm] [nvarchar](50) NULL,
	[Rec_Cnt] [decimal](18, 0) IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Rate_history]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Rate_history](
	[curr] [char](10) NOT NULL,
	[rate_dt] [datetime] NULL,
	[LAK] [float] NULL,
	[THB] [float] NULL,
	[USD] [float] NULL,
	[EUR] [float] NULL,
	[EUR_LAK] [float] NULL,
	[USD_LAK] [float] NULL,
	[THB_LAK] [float] NULL,
	[EUR_THB] [float] NULL,
	[USD_THB] [float] NULL,
	[EUR_USD] [float] NULL,
	[user_updt] [nvarchar](50) NULL,
	[lst_updt] [datetime] NULL,
	[Pc_nm] [nvarchar](50) NULL,
	[Rec_Cnt] [decimal](10, 0) IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Rate_Item]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Rate_Item](
	[cuntry] [nvarchar](50) NULL,
	[Curr] [nvarchar](100) NULL,
	[money] [decimal](18, 2) NULL,
	[Lst_Updt] [datetime] NULL,
	[Lst_Usr] [nvarchar](50) NULL,
	[pc_nm] [nvarchar](50) NULL,
	[Dt_Rate] [datetime] NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Salary]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Salary](
	[E_ID] [nvarchar](50) NULL,
	[Name_L] [nvarchar](200) NULL,
	[percen] [decimal](18, 0) NULL,
	[txtclass] [nvarchar](50) NULL,
	[txtlevel] [nvarchar](50) NULL,
	[txtV_C] [nvarchar](50) NULL,
	[txtgroup_id] [nvarchar](50) NULL,
	[cmbKip] [nvarchar](50) NULL,
	[txtsalary] [float] NULL,
	[txtTum_money] [float] NULL,
	[txt_hours_money] [float] NULL,
	[txtoil] [decimal](18, 0) NULL,
	[txtphone_money] [decimal](18, 0) NULL,
	[remark] [nvarchar](500) NULL,
	[lst_updt] [datetime] NULL,
	[lst_usr] [nvarchar](100) NULL,
	[Pc_nm] [nvarchar](100) NULL,
	[txtOil_amt] [float] NULL,
	[txtKheuan_amt] [float] NULL,
	[Sumary_salary_in] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Salary_in_Month]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Salary_in_Month](
	[PersonID] [nvarchar](50) NULL,
	[Name_L] [nvarchar](200) NULL,
	[txtcontract_type_id] [nvarchar](50) NULL,
	[AtMonth] [datetime] NULL,
	[percen] [decimal](18, 0) NULL,
	[Salary] [float] NULL,
	[SalaryCurrency] [nvarchar](5) NULL,
	[Rate] [decimal](18, 2) NULL,
	[RateDate] [datetime] NULL,
	[DayOfMonth] [float] NULL,
	[MPerDayCurrent] [float] NULL,
	[WDayOfMonth] [float] NULL,
	[total_amount] [float] NULL,
	[txtTum_money] [float] NULL,
	[Chk_Social] [nvarchar](1) NULL,
	[Employee_LAK] [decimal](18, 0) NULL,
	[Employer_LAK] [decimal](18, 0) NULL,
	[HOvertime150] [decimal](18, 0) NULL,
	[HOvertime200] [decimal](18, 0) NULL,
	[HOvertime250] [decimal](18, 0) NULL,
	[HOvertime300] [decimal](18, 0) NULL,
	[MOvertimeTotal] [decimal](18, 0) NULL,
	[txt_H_oertime] [decimal](18, 0) NULL,
	[Bonus] [decimal](18, 0) NULL,
	[cost_living_total] [decimal](18, 0) NULL,
	[tax_type] [nvarchar](50) NULL,
	[Money_Befor] [decimal](18, 0) NULL,
	[Tax_Level1] [decimal](18, 0) NULL,
	[Tax_Level2] [decimal](18, 0) NULL,
	[Tax_Level3] [decimal](18, 0) NULL,
	[Tax_Level4] [decimal](18, 0) NULL,
	[Tax_Level5] [decimal](18, 0) NULL,
	[Tax_Level6] [decimal](18, 0) NULL,
	[Tax_Level7] [decimal](18, 0) NULL,
	[tax_money] [decimal](18, 0) NULL,
	[Money_After] [decimal](18, 0) NULL,
	[Housing_After] [decimal](18, 0) NULL,
	[Money_Cut] [decimal](18, 0) NULL,
	[Net_Money] [decimal](18, 0) NULL,
	[Chk_AGL] [nvarchar](1) NULL,
	[AGL_Out] [decimal](18, 0) NULL,
	[AGL_In] [decimal](18, 0) NULL,
	[Unifron_Male] [decimal](18, 0) NULL,
	[Unifron_FeMale] [decimal](18, 0) NULL,
	[Total_Money_curr] [decimal](18, 0) NULL,
	[Total_Money_curr_Exing] [decimal](18, 0) NULL,
	[lst_updt] [datetime] NULL,
	[lst_usr] [nvarchar](100) NULL,
	[Pc_nm] [nvarchar](100) NULL,
	[Total_Other] [decimal](18, 0) NULL,
	[Sum_Addtional] [decimal](18, 0) NULL,
	[Sum_Deducation] [decimal](18, 0) NULL,
	[Total_Other_After] [decimal](18, 0) NULL,
	[Sum_Addtional_After] [decimal](18, 0) NULL,
	[Sum_Deducation_After] [decimal](18, 0) NULL,
	[Luck_Month] [int] NULL,
	[tax_level] [decimal](18, 0) NULL,
	[txtpeple] [nvarchar](50) NULL,
	[txtOil_amt] [float] NULL,
	[txtKheuan_amt] [float] NULL,
	[txtphone_money] [float] NULL,
	[txtAdd_amt] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Salary_Item]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Salary_Item](
	[PersonID] [nvarchar](50) NULL,
	[Department_ID] [nvarchar](50) NULL,
	[Code] [nvarchar](50) NULL,
	[AtMonth] [datetime] NULL,
	[Other_nm] [nvarchar](200) NULL,
	[Money_QTY] [decimal](18, 0) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Salary_Item2]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Salary_Item2](
	[PersonID] [nvarchar](50) NULL,
	[Department_ID] [nvarchar](50) NULL,
	[Code] [nvarchar](50) NULL,
	[AtMonth] [datetime] NULL,
	[Other_nm] [nvarchar](200) NULL,
	[Money_QTY] [decimal](18, 0) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Salary_Item3]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Salary_Item3](
	[PersonID] [nvarchar](50) NULL,
	[Department_ID] [nvarchar](50) NULL,
	[Code] [nvarchar](50) NULL,
	[AtMonth] [datetime] NULL,
	[Other_nm_Add_After] [nvarchar](200) NULL,
	[Money_QTY_Add_After] [decimal](18, 0) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Salary_Item4]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Salary_Item4](
	[PersonID] [nvarchar](50) NULL,
	[Department_ID] [nvarchar](50) NULL,
	[Code] [nvarchar](50) NULL,
	[AtMonth] [datetime] NULL,
	[Other_nm_Deduc_After] [nvarchar](200) NULL,
	[Money_QTY_Deduc_After] [decimal](18, 0) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Sections]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Sections](
	[Group_Sec_id] [nvarchar](50) NULL,
	[Group_Sec_nm] [nvarchar](50) NULL,
	[Sec_id] [nvarchar](50) NULL,
	[Sec_nmL] [nvarchar](50) NULL,
	[Sec_nmE] [nvarchar](50) NULL,
	[address] [nvarchar](100) NULL,
	[phone] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[Contact_PP] [nvarchar](50) NULL,
	[remark] [nvarchar](100) NULL,
	[For_Shop] [bit] NULL,
	[lst_usr] [nvarchar](50) NULL,
	[lst_updt] [datetime] NULL,
	[Pc_nm] [nvarchar](50) NULL,
	[Rec_Cnt] [decimal](18, 0) IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ap_SizeImg]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ap_SizeImg](
	[sId] [int] NULL,
	[b_x] [int] NULL,
	[b_Y] [int] NULL,
	[g_x] [int] NULL,
	[g_y] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Son_Money]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Son_Money](
	[bill_no] [nvarchar](50) NULL,
	[DT_in] [datetime] NULL,
	[E_ID] [nvarchar](50) NULL,
	[Sections_id] [nvarchar](200) NULL,
	[Sections] [nvarchar](200) NULL,
	[Department_id] [nvarchar](50) NULL,
	[Department] [nvarchar](200) NULL,
	[Name_L] [nvarchar](200) NULL,
	[Name_E] [nvarchar](200) NULL,
	[Phone] [nvarchar](50) NULL,
	[txtson] [decimal](18, 0) NULL,
	[txtson_Money] [decimal](18, 0) NULL,
	[txtabount_son] [nvarchar](500) NULL,
	[remark] [nvarchar](500) NULL,
	[Bill_cancel] [nvarchar](50) NULL,
	[DT_cancel] [datetime] NULL,
	[status] [nvarchar](1) NULL,
	[status_nm] [nvarchar](50) NULL,
	[lst_updt] [datetime] NULL,
	[lst_usr] [nvarchar](100) NULL,
	[Pc_nm] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Staffs]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Staffs](
	[Stff_Id] [nvarchar](50) NOT NULL,
	[Stff_nmL] [nvarchar](150) NOT NULL,
	[Stff_nmE] [nvarchar](150) NULL,
	[street] [nvarchar](50) NULL,
	[Village] [nvarchar](50) NULL,
	[District] [nvarchar](50) NULL,
	[Province] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Contact_pp] [nvarchar](50) NULL,
	[Lst_updt] [datetime] NULL,
	[Lst_usr] [varchar](100) NULL,
	[Pc_nm] [varchar](100) NULL,
	[Rec_Cnt] [decimal](18, 0) IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Up_Personal]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Up_Personal](
	[Bill_no] [nvarchar](50) NULL,
	[E_ID] [nvarchar](50) NULL,
	[DT_Up] [datetime] NULL,
	[Sections_id] [nvarchar](200) NULL,
	[Sections] [nvarchar](200) NULL,
	[Department_id] [nvarchar](50) NULL,
	[Department] [nvarchar](200) NULL,
	[Name_L] [nvarchar](200) NULL,
	[Name_E] [nvarchar](200) NULL,
	[Phone] [nvarchar](50) NULL,
	[Bank_no] [nvarchar](50) NULL,
	[SSO_no] [nvarchar](50) NULL,
	[percen_old] [decimal](18, 0) NULL,
	[txtclass_old] [nvarchar](50) NULL,
	[txtlevel_old] [nvarchar](50) NULL,
	[txtV_C_old] [nvarchar](50) NULL,
	[Level_Clss_Money_old] [decimal](18, 0) NULL,
	[txtclass] [nvarchar](50) NULL,
	[txtlevel] [nvarchar](50) NULL,
	[txtV_C] [nvarchar](50) NULL,
	[Level_Clss_Money] [decimal](18, 0) NULL,
	[Tumnang_Money] [decimal](18, 0) NULL,
	[year_money] [decimal](18, 0) NULL,
	[txttotal] [decimal](18, 0) NULL,
	[AGL] [decimal](18, 0) NULL,
	[Total_remaining] [decimal](18, 0) NULL,
	[Tax] [decimal](18, 0) NULL,
	[khongsep] [decimal](18, 0) NULL,
	[txtson] [decimal](18, 0) NULL,
	[txtson_Money] [decimal](18, 0) NULL,
	[txtmom] [decimal](18, 0) NULL,
	[txtMom_mony] [decimal](18, 0) NULL,
	[txtToltal_All] [decimal](18, 0) NULL,
	[txtkhor_tok_long] [nvarchar](100) NULL,
	[txtAccount_clss_level] [nvarchar](100) NULL,
	[type_up_id] [nvarchar](50) NULL,
	[type_up] [nvarchar](100) NULL,
	[percen] [decimal](18, 0) NULL,
	[remark] [nvarchar](500) NULL,
	[lst_updt] [datetime] NULL,
	[lst_usr] [nvarchar](100) NULL,
	[Pc_nm] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Users]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Users](
	[Usr_id] [nvarchar](50) NOT NULL,
	[Stff_Id] [nvarchar](50) NULL,
	[Usr_nm] [nvarchar](50) NULL,
	[permision_id] [nvarchar](50) NULL,
	[permision] [nvarchar](50) NULL,
	[Sec_id] [nvarchar](50) NULL,
	[UsrPermit] [nvarchar](50) NULL,
	[Write_bit] [bit] NOT NULL,
	[Edit_bit] [bit] NOT NULL,
	[Delete_bit] [bit] NOT NULL,
	[PWD] [nvarchar](50) NULL,
	[BColor] [real] NULL,
	[FColor] [real] NULL,
	[lst_usr] [nvarchar](50) NULL,
	[lst_updt] [datetime] NULL,
	[pc_nm] [nvarchar](50) NULL,
	[Company] [nvarchar](100) NULL,
	[Sub_Company] [nvarchar](100) NULL,
	[pc_nm1] [nvarchar](100) NULL,
	[chk] [float] NULL,
	[department] [nvarchar](250) NULL,
	[BK_ID] [nvarchar](50) NULL,
	[PV_ID] [nvarchar](50) NULL,
	[Dist_id] [nvarchar](50) NULL,
	[HSV_id] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Users_Item]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Users_Item](
	[Usr_id] [nvarchar](50) NULL,
	[Stff_Id] [nvarchar](50) NULL,
	[Usr_nm] [nvarchar](50) NULL,
	[permision_id] [nvarchar](50) NULL,
	[permision] [nvarchar](50) NULL,
	[ProV_id] [nvarchar](50) NULL,
	[ProV_nm] [nvarchar](50) NULL,
	[Dist_id] [nvarchar](50) NULL,
	[Dist_Nm] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AP_Village]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AP_Village](
	[Vl_ID] [nvarchar](50) NULL,
	[Dt_id] [nvarchar](50) NULL,
	[PV_id] [nvarchar](50) NULL,
	[Vl_nm] [nvarchar](250) NULL,
	[pv] [nvarchar](50) NULL,
	[dt] [nvarchar](50) NULL,
	[vl] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[APListEthnic]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[APListEthnic](
	[EthnicID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[EthnicCD] [decimal](18, 0) NULL,
	[EthnicNm] [nvarchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[CL_ID] [decimal](18, 0) NULL,
	[CL_No] [nvarchar](50) NULL,
	[CL_Nm] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Country_ID] [nvarchar](20) NULL,
	[Country_Name] [nvarchar](30) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Group_SLR_id] [nvarchar](50) NULL,
	[DP_ID] [nvarchar](50) NULL,
	[DP_Name] [nvarchar](200) NULL,
	[Sec_id] [nvarchar](50) NULL,
	[section_id] [nvarchar](50) NULL,
	[section_nm] [nvarchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Education]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Education](
	[E_ID] [nvarchar](50) NULL,
	[E_Nm] [nvarchar](200) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EN_list]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EN_list](
	[EN_ID] [nvarchar](50) NULL,
	[EN_NM] [nvarchar](100) NULL,
	[other_no] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EP_List]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EP_List](
	[EP_ID] [nvarchar](50) NULL,
	[EP_nm] [nvarchar](50) NULL,
	[EP_year] [nvarchar](50) NULL,
	[EP_Total] [decimal](18, 0) NULL,
	[EP1] [decimal](18, 0) NULL,
	[EP2] [decimal](18, 0) NULL,
	[EP3] [decimal](18, 0) NULL,
	[EP4] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[job]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[job](
	[job_id] [nvarchar](50) NULL,
	[job_nm] [nvarchar](200) NULL,
	[job_nm2] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Level]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Level](
	[LV_ID] [decimal](18, 0) NULL,
	[LV_Nm] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Level_class]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Level_class](
	[no] [nvarchar](50) NULL,
	[ID] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[index_type] [decimal](18, 0) NULL,
	[index_monney] [decimal](18, 0) NULL,
	[Toltle] [decimal](18, 0) NULL,
	[cc] [nvarchar](50) NULL,
	[Leve] [nvarchar](50) NULL,
	[Class] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[List_Add_After]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[List_Add_After](
	[Code] [nvarchar](50) NULL,
	[Add_Dition_AfTer] [nvarchar](100) NULL,
	[Money_QTY] [decimal](18, 0) NULL,
	[chk] [nvarchar](1) NULL,
	[Lst_Updt] [date] NULL,
	[Lst_Usr] [nvarchar](50) NULL,
	[pc_nm] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[List_Add_Befor]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[List_Add_Befor](
	[Code] [nvarchar](50) NULL,
	[Add_Dition_Befor] [nvarchar](100) NULL,
	[Money_QTY] [decimal](18, 0) NULL,
	[chk] [nvarchar](1) NULL,
	[Lst_Updt] [date] NULL,
	[Lst_Usr] [nvarchar](50) NULL,
	[pc_nm] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[List_Deduc_After]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[List_Deduc_After](
	[Code] [nvarchar](50) NULL,
	[Deduc_After] [nvarchar](100) NULL,
	[Money_QTY] [decimal](18, 0) NULL,
	[chk] [nvarchar](1) NULL,
	[Lst_Updt] [date] NULL,
	[Lst_Usr] [nvarchar](50) NULL,
	[pc_nm] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[List_Deduc_Befor]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[List_Deduc_Befor](
	[Code] [nvarchar](50) NULL,
	[Deduc_Befor] [nvarchar](100) NULL,
	[Money_QTY] [decimal](18, 0) NULL,
	[chk] [nvarchar](1) NULL,
	[Lst_Updt] [date] NULL,
	[Lst_Usr] [nvarchar](50) NULL,
	[pc_nm] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lut]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lut](
	[lut_id] [nvarchar](50) NULL,
	[Lut_nm] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nationall]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nationall](
	[NationID] [nvarchar](50) NULL,
	[NationNmL] [nvarchar](50) NULL,
	[NationNmE] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phuk]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phuk](
	[phuk_id] [nvarchar](50) NULL,
	[Phuk_nm] [nvarchar](200) NULL,
	[phuk_nm2] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Relation]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relation](
	[relation_id] [nvarchar](50) NULL,
	[relation_nm] [nvarchar](50) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Religoin]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Religoin](
	[Religoin_ID] [nvarchar](10) NOT NULL,
	[NameReligoin] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RPT_DEB]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RPT_DEB](
	[ID_OF] [nvarchar](50) NULL,
	[office_nm1] [nvarchar](100) NULL,
	[office_nm2] [nvarchar](100) NULL,
	[office_nm3] [nvarchar](100) NULL,
	[office_nm4] [nvarchar](100) NULL,
	[office_nm5] [nvarchar](100) NULL,
	[P_all] [decimal](18, 0) NULL,
	[Man] [decimal](18, 0) NULL,
	[Women] [decimal](18, 0) NULL,
	[Eak] [decimal](18, 0) NULL,
	[Tho] [decimal](18, 0) NULL,
	[Tee] [decimal](18, 0) NULL,
	[Soung] [decimal](18, 0) NULL,
	[kang] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RPT_DEM]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RPT_DEM](
	[ID_OF] [nvarchar](50) NULL,
	[office_nm1] [nvarchar](100) NULL,
	[office_nm2] [nvarchar](100) NULL,
	[office_nm3] [nvarchar](100) NULL,
	[office_nm4] [nvarchar](100) NULL,
	[office_nm5] [nvarchar](100) NULL,
	[P_all] [decimal](18, 0) NULL,
	[Man] [decimal](18, 0) NULL,
	[Women] [decimal](18, 0) NULL,
	[Eak] [decimal](18, 0) NULL,
	[Tho] [decimal](18, 0) NULL,
	[Tee] [decimal](18, 0) NULL,
	[Soung] [decimal](18, 0) NULL,
	[kang] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RPT_DEPP]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RPT_DEPP](
	[ID_OF] [nvarchar](50) NULL,
	[office_nm1] [nvarchar](100) NULL,
	[office_nm2] [nvarchar](100) NULL,
	[office_nm3] [nvarchar](100) NULL,
	[office_nm4] [nvarchar](100) NULL,
	[office_nm5] [nvarchar](100) NULL,
	[P_all] [decimal](18, 0) NULL,
	[Man] [decimal](18, 0) NULL,
	[Women] [decimal](18, 0) NULL,
	[Eak] [decimal](18, 0) NULL,
	[Tho] [decimal](18, 0) NULL,
	[Tee] [decimal](18, 0) NULL,
	[Soung] [decimal](18, 0) NULL,
	[kang] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RPT_DOI]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RPT_DOI](
	[ID_OF] [nvarchar](50) NULL,
	[office_nm1] [nvarchar](100) NULL,
	[office_nm2] [nvarchar](100) NULL,
	[office_nm3] [nvarchar](100) NULL,
	[office_nm4] [nvarchar](100) NULL,
	[office_nm5] [nvarchar](100) NULL,
	[P_all] [decimal](18, 0) NULL,
	[Man] [decimal](18, 0) NULL,
	[Women] [decimal](18, 0) NULL,
	[Eak] [decimal](18, 0) NULL,
	[Tho] [decimal](18, 0) NULL,
	[Tee] [decimal](18, 0) NULL,
	[Soung] [decimal](18, 0) NULL,
	[kang] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RPT_DoM]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RPT_DoM](
	[ID_OF] [nvarchar](50) NULL,
	[office_nm1] [nvarchar](100) NULL,
	[office_nm2] [nvarchar](100) NULL,
	[office_nm3] [nvarchar](100) NULL,
	[office_nm4] [nvarchar](100) NULL,
	[office_nm5] [nvarchar](100) NULL,
	[P_all] [decimal](18, 0) NULL,
	[Man] [decimal](18, 0) NULL,
	[Women] [decimal](18, 0) NULL,
	[Eak] [decimal](18, 0) NULL,
	[Tho] [decimal](18, 0) NULL,
	[Tee] [decimal](18, 0) NULL,
	[Soung] [decimal](18, 0) NULL,
	[kang] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RPT_DPO]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RPT_DPO](
	[ID_OF] [nvarchar](50) NULL,
	[office_nm1] [nvarchar](100) NULL,
	[office_nm2] [nvarchar](100) NULL,
	[office_nm3] [nvarchar](100) NULL,
	[office_nm4] [nvarchar](100) NULL,
	[office_nm5] [nvarchar](100) NULL,
	[P_all] [decimal](18, 0) NULL,
	[Man] [decimal](18, 0) NULL,
	[Women] [decimal](18, 0) NULL,
	[Eak] [decimal](18, 0) NULL,
	[Tho] [decimal](18, 0) NULL,
	[Tee] [decimal](18, 0) NULL,
	[Soung] [decimal](18, 0) NULL,
	[kang] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RPT_IREP]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RPT_IREP](
	[ID_OF] [nvarchar](50) NULL,
	[office_nm1] [nvarchar](100) NULL,
	[office_nm2] [nvarchar](100) NULL,
	[office_nm3] [nvarchar](100) NULL,
	[office_nm4] [nvarchar](100) NULL,
	[office_nm5] [nvarchar](100) NULL,
	[P_all] [decimal](18, 0) NULL,
	[Man] [decimal](18, 0) NULL,
	[Women] [decimal](18, 0) NULL,
	[Eak] [decimal](18, 0) NULL,
	[Tho] [decimal](18, 0) NULL,
	[Tee] [decimal](18, 0) NULL,
	[Soung] [decimal](18, 0) NULL,
	[kang] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RPT_Organization_Office]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RPT_Organization_Office](
	[ID_OF] [nvarchar](50) NULL,
	[office_nm1] [nvarchar](100) NULL,
	[office_nm2] [nvarchar](100) NULL,
	[office_nm3] [nvarchar](100) NULL,
	[office_nm4] [nvarchar](100) NULL,
	[office_nm5] [nvarchar](100) NULL,
	[P_all] [decimal](18, 0) NULL,
	[Man] [decimal](18, 0) NULL,
	[Women] [decimal](18, 0) NULL,
	[Eak] [decimal](18, 0) NULL,
	[Tho] [decimal](18, 0) NULL,
	[Tee] [decimal](18, 0) NULL,
	[Soung] [decimal](18, 0) NULL,
	[kang] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RPT_PintBarcode]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RPT_PintBarcode](
	[BK_ID] [nvarchar](50) NULL,
	[BB_ID1] [nvarchar](50) NULL,
	[BB_ID2] [nvarchar](80) NULL,
	[Img] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rrunk]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rrunk](
	[Runk_ID] [nvarchar](50) NOT NULL,
	[RunK_name] [nvarchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary_group]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary_group](
	[Group_SLR_id] [nvarchar](50) NULL,
	[Group_SLR_nm] [nvarchar](200) NULL,
	[Group_100] [decimal](18, 0) NULL,
	[Group_percen100] [decimal](18, 0) NULL,
	[Group_90] [decimal](18, 0) NULL,
	[Group_percen90] [decimal](18, 0) NULL,
	[Group_80] [decimal](18, 0) NULL,
	[Group_percen80] [decimal](18, 0) NULL,
	[Group_70] [decimal](18, 0) NULL,
	[Group_percen70] [decimal](18, 0) NULL,
	[Group_60] [float] NULL,
	[Group_percen60] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SSO]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SSO](
	[No] [nvarchar](50) NULL,
	[DT_SSO] [datetime] NULL,
	[employee] [nvarchar](50) NULL,
	[employer] [nvarchar](50) NULL,
	[Lst_Updt] [datetime] NULL,
	[Lst_Usr] [nvarchar](50) NULL,
	[pc_nm] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Study_Field]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Study_Field](
	[Field_ID] [nvarchar](10) NOT NULL,
	[Field_Name] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sumary_salary_all]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sumary_salary_all](
	[Group_Sec_id] [nvarchar](50) NULL,
	[section_id] [nvarchar](50) NULL,
	[Department_id] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sumary_salary_EX]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sumary_salary_EX](
	[DP_ID] [nvarchar](50) NULL,
	[QTY_Per] [decimal](18, 0) NULL,
	[Salary_basic] [decimal](18, 0) NULL,
	[Salary_basic_kip] [decimal](18, 0) NULL,
	[Tum_money] [decimal](18, 0) NULL,
	[normal_Time] [decimal](18, 0) NULL,
	[over_Time] [decimal](18, 0) NULL,
	[normal_Money] [decimal](18, 0) NULL,
	[over_Money] [decimal](18, 0) NULL,
	[Sum_salary] [decimal](18, 0) NULL,
	[add_money] [decimal](18, 0) NULL,
	[cut_money] [decimal](18, 0) NULL,
	[other_money] [decimal](18, 0) NULL,
	[total_money] [decimal](18, 0) NULL,
	[Employee] [decimal](18, 0) NULL,
	[Employeer] [decimal](18, 0) NULL,
	[Sum_SSO] [decimal](18, 0) NULL,
	[Summoney_in_tax] [decimal](18, 0) NULL,
	[tax] [decimal](18, 0) NULL,
	[money_after_tax] [decimal](18, 0) NULL,
	[cut_after_tax] [decimal](18, 0) NULL,
	[Net_money] [decimal](18, 0) NULL,
	[Net_money_kip] [decimal](18, 0) NULL,
	[Sections_id] [nvarchar](50) NULL,
	[type_in_id] [nvarchar](50) NULL,
	[Group_Sec_id] [nvarchar](50) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL,
	[lck] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sumary_salary_EX2]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sumary_salary_EX2](
	[DP_ID] [nvarchar](50) NULL,
	[DP_nm] [nvarchar](500) NULL,
	[QTY_Per] [decimal](18, 0) NULL,
	[Salary_basic] [decimal](18, 0) NULL,
	[Salary_basic_kip] [decimal](18, 0) NULL,
	[Tum_money] [decimal](18, 0) NULL,
	[normal_Time] [decimal](18, 0) NULL,
	[over_Time] [decimal](18, 0) NULL,
	[normal_Money] [decimal](18, 0) NULL,
	[over_Money] [decimal](18, 0) NULL,
	[Sum_salary] [decimal](18, 0) NULL,
	[add_money] [decimal](18, 0) NULL,
	[cut_money] [decimal](18, 0) NULL,
	[other_money] [decimal](18, 0) NULL,
	[total_money] [decimal](18, 0) NULL,
	[Employee] [decimal](18, 0) NULL,
	[Employeer] [decimal](18, 0) NULL,
	[Sum_SSO] [decimal](18, 0) NULL,
	[Summoney_in_tax] [decimal](18, 0) NULL,
	[tax] [decimal](18, 0) NULL,
	[money_after_tax] [decimal](18, 0) NULL,
	[cut_after_tax] [decimal](18, 0) NULL,
	[Net_money] [decimal](18, 0) NULL,
	[Net_money_kip] [decimal](18, 0) NULL,
	[Sections_id] [nvarchar](50) NULL,
	[type_in_id] [nvarchar](50) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL,
	[sec_id] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sumary_salary_in]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sumary_salary_in](
	[DP_ID] [nvarchar](50) NULL,
	[QTY_Per] [decimal](18, 0) NULL,
	[Salary_basic] [decimal](18, 0) NULL,
	[Tum_money] [decimal](18, 0) NULL,
	[normal_Time] [decimal](18, 0) NULL,
	[over_Time] [decimal](18, 0) NULL,
	[normal_Money] [decimal](18, 0) NULL,
	[over_Money] [decimal](18, 0) NULL,
	[Sum_salary] [decimal](18, 0) NULL,
	[add_money] [decimal](18, 0) NULL,
	[cut_money] [decimal](18, 0) NULL,
	[other_money] [decimal](18, 0) NULL,
	[total_money] [decimal](18, 0) NULL,
	[Employee] [decimal](18, 0) NULL,
	[Employeer] [decimal](18, 0) NULL,
	[Sum_SSO] [decimal](18, 0) NULL,
	[Summoney_in_tax] [decimal](18, 0) NULL,
	[tax] [decimal](18, 0) NULL,
	[money_after_tax] [decimal](18, 0) NULL,
	[cut_after_tax] [decimal](18, 0) NULL,
	[Net_money] [decimal](18, 0) NULL,
	[txtOil_amt] [float] NULL,
	[txtKheuan_amt] [float] NULL,
	[txtphone_money] [float] NULL,
	[txtAdd_amt] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_Donw]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Donw](
	[dn_id] [nvarchar](50) NULL,
	[dn_nm] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_In]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_In](
	[In_ID] [nvarchar](50) NULL,
	[In_nm] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_OUT]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_OUT](
	[OUT_ID] [nvarchar](50) NULL,
	[OUT_Nm] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_Up]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Up](
	[Up_id] [nvarchar](50) NULL,
	[Up_nm] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit_Tax]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit_Tax](
	[For_month] [datetime] NULL,
	[Tax1] [decimal](18, 0) NULL,
	[Tax_LAK1] [decimal](18, 0) NULL,
	[Tax2] [decimal](18, 0) NULL,
	[Tax_LAK2] [decimal](18, 0) NULL,
	[Tax3] [decimal](18, 0) NULL,
	[Tax_LAK3] [decimal](18, 0) NULL,
	[Tax4] [decimal](18, 0) NULL,
	[Tax_LAK4] [decimal](18, 0) NULL,
	[Tax5] [decimal](18, 0) NULL,
	[Tax_LAK5] [decimal](18, 0) NULL,
	[Tax6] [decimal](18, 0) NULL,
	[Tax_LAK6] [decimal](18, 0) NULL,
	[Tax7] [decimal](18, 0) NULL,
	[Tax_LAK7] [decimal](18, 0) NULL,
	[cnt] [int] IDENTITY(1,1) NOT NULL,
	[Lst_Updt] [datetime] NULL,
	[Lst_Usr] [nvarchar](50) NULL,
	[pc_nm] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnitSalary]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnitSalary](
	[RecordNo] [int] IDENTITY(1,1) NOT NULL,
	[AtMonth] [datetime] NULL,
	[LevelID] [nvarchar](10) NULL,
	[WorkYearDays] [decimal](9, 2) NULL,
	[AnnualDays] [decimal](9, 2) NULL,
	[WorkDays] [decimal](9, 2) NULL,
	[WorkHours] [decimal](9, 2) NULL,
	[PCompanySocial] [decimal](9, 2) NULL,
	[PPersonSocial] [decimal](9, 2) NULL,
	[MExceptTax] [decimal](9, 2) NULL,
	[MSocialBasic] [decimal](9, 2) NULL,
	[MCutLate] [decimal](9, 2) NULL,
	[MCutAbsent] [decimal](9, 2) NULL,
	[MCutPermission] [decimal](9, 2) NULL,
	[MCutSic] [decimal](9, 2) NULL,
	[MCutOther] [decimal](9, 2) NULL,
	[MTransport] [decimal](9, 2) NULL,
	[MPhone] [decimal](9, 2) NULL,
	[MMedical] [decimal](9, 2) NULL,
	[MLodge] [decimal](9, 2) NULL,
	[MExpenses] [decimal](9, 2) NULL,
	[MDeduction] [decimal](9, 2) NULL,
	[MServerance] [decimal](9, 2) NULL,
	[MOther] [decimal](9, 2) NULL,
	[AGLInsuranceIn] [decimal](9, 2) NULL,
	[AGLInsuranceOut] [decimal](9, 2) NULL,
	[Cost_of_living] [decimal](18, 0) NULL,
	[Lst_Updt] [date] NULL,
	[Lst_Usr] [nvarchar](50) NULL,
	[pc_nm] [nvarchar](50) NULL,
	[Money_Tax] [decimal](9, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Watter]    Script Date: 17/09/2026 5:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Watter](
	[Wat_ID] [nvarchar](50) NULL,
	[Watter] [nvarchar](100) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AP_Books] ADD  CONSTRAINT [DF_AP_Books_Dist_locat]  DEFAULT ((0)) FOR [Dist_locat]
GO
ALTER TABLE [dbo].[AP_Books] ADD  CONSTRAINT [DF_AP_Books_Age]  DEFAULT ((0)) FOR [Age]
GO
ALTER TABLE [dbo].[AP_Books] ADD  CONSTRAINT [DF_AP_Books_BabyTh]  DEFAULT ((0)) FOR [BabyTh]
GO
ALTER TABLE [dbo].[AP_Books] ADD  CONSTRAINT [DF_AP_Books_BirthM]  DEFAULT ((0)) FOR [BirthM]
GO
ALTER TABLE [dbo].[AP_Books] ADD  CONSTRAINT [DF_AP_Books_Vaccin]  DEFAULT ((1)) FOR [Vaccin_Check]
GO
ALTER TABLE [dbo].[AP_Books] ADD  CONSTRAINT [DF_AP_Books_Vaccin1]  DEFAULT ((0)) FOR [Vaccin_No]
GO
ALTER TABLE [dbo].[AP_Books] ADD  CONSTRAINT [DF_AP_Books_Chk_SSO]  DEFAULT ((0)) FOR [Chk_SSO]
GO
ALTER TABLE [dbo].[AP_Books] ADD  CONSTRAINT [DF_AP_Books_Chk_SASS]  DEFAULT ((0)) FOR [Chk_SASS]
GO
ALTER TABLE [dbo].[AP_Books] ADD  CONSTRAINT [DF_AP_Books_Chk_SSO_S]  DEFAULT ((0)) FOR [Chk_SSO_S]
GO
ALTER TABLE [dbo].[AP_Books] ADD  CONSTRAINT [DF_AP_Books_Chk_PRF]  DEFAULT ((0)) FOR [Chk_PRF]
GO
ALTER TABLE [dbo].[AP_Books] ADD  CONSTRAINT [DF_AP_Books_Chk_other]  DEFAULT ((0)) FOR [Chk_other]
GO
ALTER TABLE [dbo].[AP_Books] ADD  CONSTRAINT [DF_AP_Books_Tolet_Chk]  DEFAULT ((0)) FOR [Tolet_Chk]
GO
ALTER TABLE [dbo].[AP_Brith_Data] ADD  CONSTRAINT [DF_AP_Brith_Data_Moving_Service_id]  DEFAULT ((0)) FOR [Moving_Service_id]
GO
ALTER TABLE [dbo].[AP_Brith_Data] ADD  CONSTRAINT [DF_AP_Brith_Data_Birth_Type_id]  DEFAULT ((1)) FOR [Birth_Type_id]
GO
ALTER TABLE [dbo].[AP_Brith_Data] ADD  CONSTRAINT [DF_AP_Brith_Data_Baby_Health_id]  DEFAULT ((0)) FOR [Baby_Health_id]
GO
ALTER TABLE [dbo].[AP_Brith_Data] ADD  CONSTRAINT [DF_AP_Brith_Data_Nathong_ID]  DEFAULT (N'a') FOR [Nathong_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data] ADD  CONSTRAINT [DF_AP_Brith_Data_Position_ID]  DEFAULT (N'a') FOR [Position_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data] ADD  CONSTRAINT [DF_AP_Brith_Data_Uterus_ID]  DEFAULT (N'a') FOR [Uterus_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data] ADD  CONSTRAINT [DF_AP_Brith_Data_Have90Unit]  DEFAULT ((0)) FOR [Have90Unit]
GO
ALTER TABLE [dbo].[AP_Brith_Data] ADD  CONSTRAINT [DF_AP_Brith_Data_Mom_Death_ID]  DEFAULT ((0)) FOR [Chk_ath_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data] ADD  CONSTRAINT [DF_AP_Brith_Data_MomSymptom_ID]  DEFAULT (N'a') FOR [MomSymptom_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Moving_Service_id]  DEFAULT ((0)) FOR [Moving_Service_id]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Birth_Type_id]  DEFAULT ((1)) FOR [Birth_Type_id]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Baby_Health_id1]  DEFAULT ((1)) FOR [Baby_Health_But]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Baby_Health_But1]  DEFAULT ((1)) FOR [Baby_Health_But_Time]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Baby_Health_id]  DEFAULT (N'((a))') FOR [Baby_Health_id]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Baby_Health_Time]  DEFAULT ((0)) FOR [Baby_Health_Time]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Innormal_ID]  DEFAULT ((0)) FOR [Innormal_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Weight]  DEFAULT ((0)) FOR [Weight]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Height]  DEFAULT ((0)) FOR [Height]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_HopErk]  DEFAULT ((0)) FOR [HopErk]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_HopHov]  DEFAULT ((0)) FOR [HopHov]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Pregn_Age]  DEFAULT ((0)) FOR [Pregn_Age]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Temperature]  DEFAULT ((0)) FOR [Temperature]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Kamajone]  DEFAULT ((0)) FOR [Kamajone]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Blood_Pressure1]  DEFAULT ((0)) FOR [Blood_Pressure1]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Blood_Pressure2]  DEFAULT ((0)) FOR [Blood_Pressure2]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Symptom_ID]  DEFAULT (N'a') FOR [Symptom_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Vaccin1]  DEFAULT ((0)) FOR [Vaccin1]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Vaccin11]  DEFAULT ((0)) FOR [Vaccin2]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Baby_Eat_Milk]  DEFAULT ((0)) FOR [Baby_Eat_Milk]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Baby_death]  DEFAULT ((0)) FOR [Baby_death]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Nathong_ID]  DEFAULT (N'a') FOR [Nathong_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Position_ID]  DEFAULT (N'a') FOR [Position_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Uterus_ID]  DEFAULT (N'a') FOR [Uterus_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_fish_Watter_ID]  DEFAULT (N'a') FOR [fish_Watter_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Have90Unit]  DEFAULT ((0)) FOR [Have90Unit]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Chk_ath_ID]  DEFAULT ((0)) FOR [Chk_ath_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Mom_Death_ID]  DEFAULT ((0)) FOR [Mom_Death_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Uterus_Position]  DEFAULT ((0)) FOR [Uterus_Position]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Hopthong]  DEFAULT ((0)) FOR [Hopthong]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_Symptom_ID1]  DEFAULT (N'a') FOR [MomSymptom_ID]
GO
ALTER TABLE [dbo].[AP_Brith_Data_List] ADD  CONSTRAINT [DF_AP_Brith_Data_List_VitaminK]  DEFAULT ((0)) FOR [VitaminK]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_txtmoney_basic]  DEFAULT ((0)) FOR [txtmoney_basic]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_percen]  DEFAULT ((0)) FOR [percen]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_txt_hours_money]  DEFAULT ((0)) FOR [txt_hours_money]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Level_Clss_Money]  DEFAULT ((0)) FOR [Level_Clss_Money]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Tumnang_Money]  DEFAULT ((0)) FOR [Tumnang_Money]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Tumnang_Money1]  DEFAULT ((0)) FOR [year_money]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Tumnang_Money2]  DEFAULT ((0)) FOR [txttotal]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Tumnang_Money3]  DEFAULT ((0)) FOR [AGL]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Tumnang_Money4]  DEFAULT ((0)) FOR [Total_remaining]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Tumnang_Money5]  DEFAULT ((0)) FOR [Tax]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Tumnang_Money6]  DEFAULT ((0)) FOR [khongsep]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Tumnang_Money7]  DEFAULT ((0)) FOR [txtson]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Tumnang_Money8]  DEFAULT ((0)) FOR [txtson_Money]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Tumnang_Money9]  DEFAULT ((0)) FOR [txtmom]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Tumnang_Money10]  DEFAULT ((0)) FOR [txtMom_mony]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_txtMom_mony1]  DEFAULT ((0)) FOR [txtWomen_mony]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_txtMom_mony2]  DEFAULT ((0)) FOR [txtoil_mony]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_txtMom_mony3]  DEFAULT ((0)) FOR [txtPhone_money]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Tumnang_Money11]  DEFAULT ((0)) FOR [txtToltal_All]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_chk_lut]  DEFAULT ((0)) FOR [chk_lut]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_chk_Phuk_sumhong]  DEFAULT ((0)) FOR [chk_Phuk_sumhong]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_chk_Phuk]  DEFAULT ((0)) FOR [chk_Phuk]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_chk_Job_Phuk]  DEFAULT ((0)) FOR [chk_Job_Phuk]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_chk_job_lut]  DEFAULT ((0)) FOR [chk_job_lut]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_txthong]  DEFAULT ((0)) FOR [txthong]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_chk_job_lut_visakan]  DEFAULT ((0)) FOR [chk_job_lut_visakan]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_chk_study]  DEFAULT ((0)) FOR [chk_study]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_chk_start]  DEFAULT ((0)) FOR [chk_start]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_chk_study2]  DEFAULT ((0)) FOR [chk_study2]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_chk_lang]  DEFAULT ((0)) FOR [chk_lang]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Status_son]  DEFAULT ((0)) FOR [Status_son]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Status_son1]  DEFAULT ((0)) FOR [Status_Mom]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Status_Mom1]  DEFAULT ((0)) FOR [Status_donw]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Status_donw1]  DEFAULT ((0)) FOR [Status_Up]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_Status_Up1]  DEFAULT ((0)) FOR [Status_out]
GO
ALTER TABLE [dbo].[AP_CV] ADD  CONSTRAINT [DF_AP_CV_order_no]  DEFAULT ((0)) FOR [order_no]
GO
ALTER TABLE [dbo].[AP_E1_Item] ADD  CONSTRAINT [DF_AP_E1_Item_Total_in]  DEFAULT ((0)) FOR [Total_in]
GO
ALTER TABLE [dbo].[AP_E1_Item] ADD  CONSTRAINT [DF_Table_1_Total_in1]  DEFAULT ((0)) FOR [ek_in]
GO
ALTER TABLE [dbo].[AP_E1_Item] ADD  CONSTRAINT [DF_Table_1_ek_in1]  DEFAULT ((0)) FOR [tho_in]
GO
ALTER TABLE [dbo].[AP_E1_Item] ADD  CONSTRAINT [DF_Table_1_ek_in2]  DEFAULT ((0)) FOR [tee_in]
GO
ALTER TABLE [dbo].[AP_E1_Item] ADD  CONSTRAINT [DF_Table_1_ek_in3]  DEFAULT ((0)) FOR [soung_in]
GO
ALTER TABLE [dbo].[AP_E1_Item] ADD  CONSTRAINT [DF_Table_1_ek_in1_1]  DEFAULT ((0)) FOR [kang_in]
GO
ALTER TABLE [dbo].[AP_E1_Item] ADD  CONSTRAINT [DF_Table_1_Total_in1_1]  DEFAULT ((0)) FOR [Total_out]
GO
ALTER TABLE [dbo].[AP_E1_Item] ADD  CONSTRAINT [DF_Table_1_ek_in1_2]  DEFAULT ((0)) FOR [ek_out]
GO
ALTER TABLE [dbo].[AP_E1_Item] ADD  CONSTRAINT [DF_Table_1_tho_in11]  DEFAULT ((0)) FOR [tho_out]
GO
ALTER TABLE [dbo].[AP_E1_Item] ADD  CONSTRAINT [DF_Table_1_tee_in21]  DEFAULT ((0)) FOR [tee_out]
GO
ALTER TABLE [dbo].[AP_E1_Item] ADD  CONSTRAINT [DF_Table_1_soung_in31]  DEFAULT ((0)) FOR [soung_out]
GO
ALTER TABLE [dbo].[AP_E1_Item] ADD  CONSTRAINT [DF_Table_1_kang_in11]  DEFAULT ((0)) FOR [kang_out]
GO
ALTER TABLE [dbo].[Ap_Employee_take_leave] ADD  CONSTRAINT [DF_Table_1_sqy_day]  DEFAULT ((0)) FOR [qty_day]
GO
ALTER TABLE [dbo].[AP_Employee_Tecket] ADD  CONSTRAINT [DF_AP_Employee_Tecket_Tecket_year]  DEFAULT ((0)) FOR [Tecket_year]
GO
ALTER TABLE [dbo].[AP_Employee_Tecket] ADD  CONSTRAINT [DF_Table_1_Tecket_year1]  DEFAULT ((0)) FOR [Tecket_use]
GO
ALTER TABLE [dbo].[AP_Employee_Tecket_item] ADD  CONSTRAINT [DF_AP_Employee_Tecket_item_Day_year]  DEFAULT ((0)) FOR [Day_year]
GO
ALTER TABLE [dbo].[AP_Employee_Tecket_item] ADD  CONSTRAINT [DF_AP_Employee_Tecket_item_sick]  DEFAULT ((0)) FOR [sick]
GO
ALTER TABLE [dbo].[AP_Employee_Tecket_item] ADD  CONSTRAINT [DF_AP_Employee_Tecket_item_QTY_Ticket]  DEFAULT ((0)) FOR [QTY_Ticket]
GO
ALTER TABLE [dbo].[AP_EP_Item] ADD  CONSTRAINT [DF_AP_EP_Item_EP_Total]  DEFAULT ((0)) FOR [EP_Total]
GO
ALTER TABLE [dbo].[AP_EP_Item] ADD  CONSTRAINT [DF_AP_EP_Item_EP1]  DEFAULT ((0)) FOR [EP1]
GO
ALTER TABLE [dbo].[AP_EP_Item] ADD  CONSTRAINT [DF_Table_1_EP11]  DEFAULT ((0)) FOR [EP2]
GO
ALTER TABLE [dbo].[AP_EP_Item] ADD  CONSTRAINT [DF_Table_1_EP12]  DEFAULT ((0)) FOR [EP3]
GO
ALTER TABLE [dbo].[AP_EP_Item] ADD  CONSTRAINT [DF_Table_1_EP13]  DEFAULT ((0)) FOR [EP4]
GO
ALTER TABLE [dbo].[AP_Location_Hos_Center] ADD  CONSTRAINT [DF_AP_Location_Hos_Center_sym]  DEFAULT (N'CT') FOR [sym]
GO
ALTER TABLE [dbo].[AP_Mom_Money] ADD  CONSTRAINT [DF_AP_Mom_Money_status]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[AP_Office] ADD  CONSTRAINT [DF_AP_Office_index_monney]  DEFAULT ((0)) FOR [index_monney]
GO
ALTER TABLE [dbo].[AP_Organization] ADD  CONSTRAINT [DF_AP_Organization_chk_lut]  DEFAULT ((0)) FOR [chk_lut]
GO
ALTER TABLE [dbo].[AP_Organization] ADD  CONSTRAINT [DF_AP_Organization_chk_In_Independence]  DEFAULT ((0)) FOR [chk_In_Independence]
GO
ALTER TABLE [dbo].[AP_Organization] ADD  CONSTRAINT [DF_AP_Organization_Chk_INreform]  DEFAULT ((0)) FOR [Chk_INreform]
GO
ALTER TABLE [dbo].[AP_Organization] ADD  CONSTRAINT [DF_AP_Organization_chk_Phuk_sumhong]  DEFAULT ((0)) FOR [chk_Phuk_sumhong]
GO
ALTER TABLE [dbo].[AP_Organization] ADD  CONSTRAINT [DF_AP_Organization_chk_Phuk]  DEFAULT ((0)) FOR [chk_Phuk]
GO
ALTER TABLE [dbo].[AP_Organization] ADD  CONSTRAINT [DF_AP_Organization_Chk_young]  DEFAULT ((0)) FOR [Chk_young]
GO
ALTER TABLE [dbo].[AP_Organization] ADD  CONSTRAINT [DF_AP_Organization_Chk_young1]  DEFAULT ((0)) FOR [Chk_khummaban]
GO
ALTER TABLE [dbo].[AP_Organization] ADD  CONSTRAINT [DF_AP_Organization_Chk_khummaban1]  DEFAULT ((0)) FOR [Chk_woman]
GO
ALTER TABLE [dbo].[AP_Persion_Health] ADD  CONSTRAINT [DF_AP_Persion_Health_txt_higth]  DEFAULT ((0)) FOR [txt_higth]
GO
ALTER TABLE [dbo].[AP_Persion_Health] ADD  CONSTRAINT [DF_AP_Persion_Health_txt_H1_id]  DEFAULT ((0)) FOR [txt_H1_id]
GO
ALTER TABLE [dbo].[AP_Persion_Health] ADD  CONSTRAINT [DF_AP_Persion_Health_txt_H1_id1]  DEFAULT ((0)) FOR [txt_H2_id]
GO
ALTER TABLE [dbo].[AP_Persion_Health] ADD  CONSTRAINT [DF_AP_Persion_Health_txt_H1_id2]  DEFAULT ((0)) FOR [txt_H3_id]
GO
ALTER TABLE [dbo].[AP_Persion_Health] ADD  CONSTRAINT [DF_AP_Persion_Health_txt_H1_id3]  DEFAULT ((0)) FOR [txt_H4_id]
GO
ALTER TABLE [dbo].[AP_Persion_Health] ADD  CONSTRAINT [DF_AP_Persion_Health_chk_disabled_Type]  DEFAULT ((0)) FOR [chk_disabled_Type]
GO
ALTER TABLE [dbo].[AP_Persion_Health] ADD  CONSTRAINT [DF_AP_Persion_Health_chk_disabled1]  DEFAULT ((0)) FOR [chk_disabled1]
GO
ALTER TABLE [dbo].[AP_Persion_Health] ADD  CONSTRAINT [DF_AP_Persion_Health_chk_disabled11]  DEFAULT ((0)) FOR [chk_disabled2]
GO
ALTER TABLE [dbo].[AP_Persion_Health] ADD  CONSTRAINT [DF_AP_Persion_Health_chk_disabled12]  DEFAULT ((0)) FOR [chk_disabled3]
GO
ALTER TABLE [dbo].[AP_Persion_Study] ADD  CONSTRAINT [DF_AP_Persion_Study_txtsamun_id]  DEFAULT ((0)) FOR [txtsamun_id]
GO
ALTER TABLE [dbo].[AP_Persion_Study] ADD  CONSTRAINT [DF_AP_Persion_Study_chk_lang]  DEFAULT ((0)) FOR [chk_lang]
GO
ALTER TABLE [dbo].[AP_Position] ADD  CONSTRAINT [DF_AP_Position_chk_Job_Phuk]  DEFAULT ((0)) FOR [chk_Job_Phuk]
GO
ALTER TABLE [dbo].[AP_Position] ADD  CONSTRAINT [DF_AP_Position_chk_job_lut]  DEFAULT ((0)) FOR [chk_job_lut]
GO
ALTER TABLE [dbo].[AP_Position] ADD  CONSTRAINT [DF_AP_Position_chk_job_lut_visakan]  DEFAULT ((0)) FOR [chk_job_lut_visakan]
GO
ALTER TABLE [dbo].[AP_Rate_history] ADD  CONSTRAINT [DF_AP_Rate_history_LAK]  DEFAULT ((0)) FOR [LAK]
GO
ALTER TABLE [dbo].[AP_Rate_history] ADD  CONSTRAINT [DF_AP_Rate_history_THB]  DEFAULT ((0)) FOR [THB]
GO
ALTER TABLE [dbo].[AP_Rate_history] ADD  CONSTRAINT [DF_AP_Rate_history_USD]  DEFAULT ((0)) FOR [USD]
GO
ALTER TABLE [dbo].[AP_Rate_history] ADD  CONSTRAINT [DF_AP_Rate_history_EUR]  DEFAULT ((0)) FOR [EUR]
GO
ALTER TABLE [dbo].[AP_Rate_history] ADD  CONSTRAINT [DF_AP_Rate_history_EUR_LAK]  DEFAULT ((0)) FOR [EUR_LAK]
GO
ALTER TABLE [dbo].[AP_Rate_history] ADD  CONSTRAINT [DF_AP_Rate_history_USD_LAK]  DEFAULT ((0)) FOR [USD_LAK]
GO
ALTER TABLE [dbo].[AP_Rate_history] ADD  CONSTRAINT [DF_AP_Rate_history_THB_LAK]  DEFAULT ((0)) FOR [THB_LAK]
GO
ALTER TABLE [dbo].[AP_Rate_history] ADD  CONSTRAINT [DF_AP_Rate_history_EUR_THB]  DEFAULT ((0)) FOR [EUR_THB]
GO
ALTER TABLE [dbo].[AP_Rate_history] ADD  CONSTRAINT [DF_AP_Rate_history_USD_THB]  DEFAULT ((0)) FOR [USD_THB]
GO
ALTER TABLE [dbo].[AP_Rate_history] ADD  CONSTRAINT [DF_AP_Rate_history_EUR_USD]  DEFAULT ((0)) FOR [EUR_USD]
GO
ALTER TABLE [dbo].[AP_Salary] ADD  CONSTRAINT [DF_AP_Salary_txtTum_money]  DEFAULT ((0)) FOR [txtTum_money]
GO
ALTER TABLE [dbo].[AP_Salary] ADD  CONSTRAINT [DF_AP_Salary_QTY_year_Money]  DEFAULT ((0)) FOR [txtoil]
GO
ALTER TABLE [dbo].[AP_Salary] ADD  DEFAULT ((0)) FOR [txtOil_amt]
GO
ALTER TABLE [dbo].[AP_Salary] ADD  DEFAULT ((0)) FOR [txtKheuan_amt]
GO
ALTER TABLE [dbo].[AP_Salary] ADD  DEFAULT ((0)) FOR [Sumary_salary_in]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Salary]  DEFAULT ((0)) FOR [Salary]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_DayOfMonth]  DEFAULT ((0)) FOR [DayOfMonth]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_MPerDayCurrent]  DEFAULT ((0)) FOR [MPerDayCurrent]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_WDayOfMonth]  DEFAULT ((0)) FOR [WDayOfMonth]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_txtTum_money]  DEFAULT ((0)) FOR [txtTum_money]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Chk_Social]  DEFAULT ((0)) FOR [Chk_Social]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Employee_LAK]  DEFAULT ((0)) FOR [Employee_LAK]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Employer_LAK]  DEFAULT ((0)) FOR [Employer_LAK]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_HOvertime150]  DEFAULT ((0)) FOR [HOvertime150]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_HOvertime200]  DEFAULT ((0)) FOR [HOvertime200]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_HOvertime250]  DEFAULT ((0)) FOR [HOvertime250]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_HOvertime300]  DEFAULT ((0)) FOR [HOvertime300]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_MOvertimeTotal]  DEFAULT ((0)) FOR [MOvertimeTotal]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_txt_H_oertime]  DEFAULT ((0)) FOR [txt_H_oertime]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Bonus]  DEFAULT ((0)) FOR [Bonus]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_cost_living_total]  DEFAULT ((0)) FOR [cost_living_total]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Money_Befor]  DEFAULT ((0)) FOR [Money_Befor]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Tax_Level1]  DEFAULT ((0)) FOR [Tax_Level1]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Tax_Level2]  DEFAULT ((0)) FOR [Tax_Level2]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Tax_Level3]  DEFAULT ((0)) FOR [Tax_Level3]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Tax_Level4]  DEFAULT ((0)) FOR [Tax_Level4]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Tax_Level5]  DEFAULT ((0)) FOR [Tax_Level5]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Tax_Level6]  DEFAULT ((0)) FOR [Tax_Level6]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Tax_Level7]  DEFAULT ((0)) FOR [Tax_Level7]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_tax_money]  DEFAULT ((0)) FOR [tax_money]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Money_After]  DEFAULT ((0)) FOR [Money_After]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Housing_After]  DEFAULT ((0)) FOR [Housing_After]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Money_Cut]  DEFAULT ((0)) FOR [Money_Cut]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Net_Money]  DEFAULT ((0)) FOR [Net_Money]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Chk_AGL]  DEFAULT ((0)) FOR [Chk_AGL]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_AGL_Out]  DEFAULT ((0)) FOR [AGL_Out]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_AGL_In]  DEFAULT ((0)) FOR [AGL_In]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Unifron_Male]  DEFAULT ((0)) FOR [Unifron_Male]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Unifron_FeMale]  DEFAULT ((0)) FOR [Unifron_FeMale]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Total_Money_curr]  DEFAULT ((0)) FOR [Total_Money_curr]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Total_Money_curr_Exing]  DEFAULT ((0)) FOR [Total_Money_curr_Exing]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Total_Other]  DEFAULT ((0)) FOR [Total_Other]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Sum_Addtional]  DEFAULT ((0)) FOR [Sum_Addtional]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Sum_Deducation]  DEFAULT ((0)) FOR [Sum_Deducation]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Total_Other_After]  DEFAULT ((0)) FOR [Total_Other_After]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Sum_Addtional_After]  DEFAULT ((0)) FOR [Sum_Addtional_After]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Sum_Deducation_After]  DEFAULT ((0)) FOR [Sum_Deducation_After]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_Luck_Month]  DEFAULT ((0)) FOR [Luck_Month]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  CONSTRAINT [DF_AP_Salary_in_Month_tax_level]  DEFAULT ((0)) FOR [tax_level]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  DEFAULT ((0)) FOR [txtOil_amt]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  DEFAULT ((0)) FOR [txtKheuan_amt]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  DEFAULT ((0)) FOR [txtphone_money]
GO
ALTER TABLE [dbo].[AP_Salary_in_Month] ADD  DEFAULT ((0)) FOR [txtAdd_amt]
GO
ALTER TABLE [dbo].[AP_Son_Money] ADD  CONSTRAINT [DF_AP_Son_Money_status]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_percen]  DEFAULT ((0)) FOR [percen_old]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_Table_1_Level_Clss_Money]  DEFAULT ((0)) FOR [Level_Clss_Money_old]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_Level_Clss_Money_old1]  DEFAULT ((0)) FOR [Level_Clss_Money]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_Tumnang_Money]  DEFAULT ((0)) FOR [Tumnang_Money]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_year_money]  DEFAULT ((0)) FOR [year_money]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_txttotal]  DEFAULT ((0)) FOR [txttotal]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_AGL]  DEFAULT ((0)) FOR [AGL]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_Total_remaining]  DEFAULT ((0)) FOR [Total_remaining]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_Tax]  DEFAULT ((0)) FOR [Tax]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_khongsep]  DEFAULT ((0)) FOR [khongsep]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_txtson]  DEFAULT ((0)) FOR [txtson]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_txtson_Money]  DEFAULT ((0)) FOR [txtson_Money]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_txtmom]  DEFAULT ((0)) FOR [txtmom]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_txtMom_mony]  DEFAULT ((0)) FOR [txtMom_mony]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_txtToltal_All]  DEFAULT ((0)) FOR [txtToltal_All]
GO
ALTER TABLE [dbo].[AP_Up_Personal] ADD  CONSTRAINT [DF_AP_Up_Personal_percen_old1]  DEFAULT ((0)) FOR [percen]
GO
ALTER TABLE [dbo].[AP_Users] ADD  CONSTRAINT [DF_AP_Users_Write_bit]  DEFAULT ((1)) FOR [Write_bit]
GO
ALTER TABLE [dbo].[AP_Users] ADD  CONSTRAINT [DF_AP_Users_Edit_bit]  DEFAULT ((1)) FOR [Edit_bit]
GO
ALTER TABLE [dbo].[AP_Users] ADD  CONSTRAINT [DF_AP_Users_Delete_bit]  DEFAULT ((1)) FOR [Delete_bit]
GO
ALTER TABLE [dbo].[AP_Users] ADD  CONSTRAINT [DF_AP_Users_chk]  DEFAULT ((0)) FOR [chk]
GO
ALTER TABLE [dbo].[Class] ADD  CONSTRAINT [DF_Class_CL_ID]  DEFAULT ((0)) FOR [CL_ID]
GO
ALTER TABLE [dbo].[Education] ADD  CONSTRAINT [DF_Education_E_ID]  DEFAULT ((0)) FOR [E_ID]
GO
ALTER TABLE [dbo].[EN_list] ADD  CONSTRAINT [DF_EN_list_other_no]  DEFAULT ((0)) FOR [other_no]
GO
ALTER TABLE [dbo].[EP_List] ADD  CONSTRAINT [DF_EP_List_EP_Total]  DEFAULT ((0)) FOR [EP_Total]
GO
ALTER TABLE [dbo].[EP_List] ADD  CONSTRAINT [DF_EP_List_EP1]  DEFAULT ((0)) FOR [EP1]
GO
ALTER TABLE [dbo].[EP_List] ADD  CONSTRAINT [DF_EP_List_EP2]  DEFAULT ((0)) FOR [EP2]
GO
ALTER TABLE [dbo].[EP_List] ADD  CONSTRAINT [DF_EP_List_EP3]  DEFAULT ((0)) FOR [EP3]
GO
ALTER TABLE [dbo].[EP_List] ADD  CONSTRAINT [DF_EP_List_EP4]  DEFAULT ((0)) FOR [EP4]
GO
ALTER TABLE [dbo].[Level] ADD  CONSTRAINT [DF_Level_LV_ID]  DEFAULT ((0)) FOR [LV_ID]
GO
ALTER TABLE [dbo].[Level_class] ADD  CONSTRAINT [DF_Level_class_index_type]  DEFAULT ((0)) FOR [index_type]
GO
ALTER TABLE [dbo].[Level_class] ADD  CONSTRAINT [DF_Table_1_index_type1]  DEFAULT ((0)) FOR [index_monney]
GO
ALTER TABLE [dbo].[Level_class] ADD  CONSTRAINT [DF_Table_1_index_type1_1]  DEFAULT ((0)) FOR [Toltle]
GO
ALTER TABLE [dbo].[Level_class] ADD  CONSTRAINT [DF_Level_class_cc]  DEFAULT ((1)) FOR [cc]
GO
ALTER TABLE [dbo].[RPT_Organization_Office] ADD  CONSTRAINT [DF_RPT_Organization_Office_P_all]  DEFAULT ((0)) FOR [P_all]
GO
ALTER TABLE [dbo].[RPT_Organization_Office] ADD  CONSTRAINT [DF_RPT_Organization_Office_P_all1]  DEFAULT ((0)) FOR [Man]
GO
ALTER TABLE [dbo].[RPT_Organization_Office] ADD  CONSTRAINT [DF_RPT_Organization_Office_P_all1_1]  DEFAULT ((0)) FOR [Women]
GO
ALTER TABLE [dbo].[RPT_Organization_Office] ADD  CONSTRAINT [DF_RPT_Organization_Office_Eak]  DEFAULT ((0)) FOR [Eak]
GO
ALTER TABLE [dbo].[RPT_Organization_Office] ADD  CONSTRAINT [DF_RPT_Organization_Office_P_all1_2]  DEFAULT ((0)) FOR [Tho]
GO
ALTER TABLE [dbo].[RPT_Organization_Office] ADD  CONSTRAINT [DF_RPT_Organization_Office_P_all1_3]  DEFAULT ((0)) FOR [Tee]
GO
ALTER TABLE [dbo].[RPT_Organization_Office] ADD  CONSTRAINT [DF_RPT_Organization_Office_P_all1_4]  DEFAULT ((0)) FOR [Soung]
GO
ALTER TABLE [dbo].[RPT_Organization_Office] ADD  CONSTRAINT [DF_RPT_Organization_Office_P_all1_5]  DEFAULT ((0)) FOR [kang]
GO
ALTER TABLE [dbo].[Salary_group] ADD  CONSTRAINT [DF_Salary_group_Group_100]  DEFAULT ((0)) FOR [Group_100]
GO
ALTER TABLE [dbo].[Salary_group] ADD  CONSTRAINT [DF_Salary_group_Group_1001]  DEFAULT ((0)) FOR [Group_percen100]
GO
ALTER TABLE [dbo].[Salary_group] ADD  CONSTRAINT [DF_Salary_group_Group_1001_1]  DEFAULT ((0)) FOR [Group_90]
GO
ALTER TABLE [dbo].[Salary_group] ADD  CONSTRAINT [DF_Salary_group_Group_percen1001]  DEFAULT ((0)) FOR [Group_percen90]
GO
ALTER TABLE [dbo].[Salary_group] ADD  CONSTRAINT [DF_Salary_group_Group_1002]  DEFAULT ((0)) FOR [Group_80]
GO
ALTER TABLE [dbo].[Salary_group] ADD  CONSTRAINT [DF_Salary_group_Group_percen1002]  DEFAULT ((0)) FOR [Group_percen80]
GO
ALTER TABLE [dbo].[Salary_group] ADD  CONSTRAINT [DF_Salary_group_Group_1003]  DEFAULT ((0)) FOR [Group_70]
GO
ALTER TABLE [dbo].[Salary_group] ADD  CONSTRAINT [DF_Salary_group_Group_percen1003]  DEFAULT ((0)) FOR [Group_percen70]
GO
ALTER TABLE [dbo].[Salary_group] ADD  CONSTRAINT [DF_Salary_group_Group_60]  DEFAULT ((0)) FOR [Group_60]
GO
ALTER TABLE [dbo].[Salary_group] ADD  CONSTRAINT [DF_Salary_group_Group_percen60]  DEFAULT ((0)) FOR [Group_percen60]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_QTY_Per]  DEFAULT ((0)) FOR [QTY_Per]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_Salary_basic]  DEFAULT ((0)) FOR [Salary_basic]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_Tum_money]  DEFAULT ((0)) FOR [Tum_money]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_normal_Time]  DEFAULT ((0)) FOR [normal_Time]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_over_Time]  DEFAULT ((0)) FOR [over_Time]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_normal_Money]  DEFAULT ((0)) FOR [normal_Money]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_over_Money]  DEFAULT ((0)) FOR [over_Money]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_Sum_salary]  DEFAULT ((0)) FOR [Sum_salary]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_add_money]  DEFAULT ((0)) FOR [add_money]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_cut_money]  DEFAULT ((0)) FOR [cut_money]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_other_money]  DEFAULT ((0)) FOR [other_money]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_total_money]  DEFAULT ((0)) FOR [total_money]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_Employee]  DEFAULT ((0)) FOR [Employee]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_Employee1]  DEFAULT ((0)) FOR [Employeer]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_Sum_SSO]  DEFAULT ((0)) FOR [Sum_SSO]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_Summoney_in_tax]  DEFAULT ((0)) FOR [Summoney_in_tax]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_tax]  DEFAULT ((0)) FOR [tax]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_cut_after_tax]  DEFAULT ((0)) FOR [cut_after_tax]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  CONSTRAINT [DF_Sumary_salary_in_Net_money]  DEFAULT ((0)) FOR [Net_money]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  DEFAULT ((0)) FOR [txtOil_amt]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  DEFAULT ((0)) FOR [txtKheuan_amt]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  DEFAULT ((0)) FOR [txtphone_money]
GO
ALTER TABLE [dbo].[Sumary_salary_in] ADD  DEFAULT ((0)) FOR [txtAdd_amt]
GO
USE [master]
GO
ALTER DATABASE [AP_Personal_LA] SET  READ_WRITE
GO
