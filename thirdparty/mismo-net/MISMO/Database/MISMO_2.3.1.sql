if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__VALUATION__Appra__6501FCD8]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[VALUATION] DROP CONSTRAINT FK__VALUATION__Appra__6501FCD8
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__INTERVIEW__Appli__7D0E9093]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[INTERVIEWER_INFORMATION] DROP CONSTRAINT FK__INTERVIEW__Appli__7D0E9093
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__ASSET__Type__1A9EF37A]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ASSET] DROP CONSTRAINT FK__ASSET__Type__1A9EF37A
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__BUYDOWN__BaseDat__1B9317B3]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[BUYDOWN] DROP CONSTRAINT FK__BUYDOWN__BaseDat__1B9317B3
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__RESIDENCE__Borro__5D60DB10]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[RESIDENCE] DROP CONSTRAINT FK__RESIDENCE__Borro__5D60DB10
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__RESIDENCE__Borro__5C6CB6D7]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[RESIDENCE] DROP CONSTRAINT FK__RESIDENCE__Borro__5C6CB6D7
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PROPERTY__Buildi__0E391C95]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PROPERTY] DROP CONSTRAINT FK__PROPERTY__Buildi__0E391C95
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__TRANSMITT__CaseS__61316BF4]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[TRANSMITTAL_DATA] DROP CONSTRAINT FK__TRANSMITT__CaseS__61316BF4
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__DECLARATI__Citiz__2CBDA3B5]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[DECLARATION] DROP CONSTRAINT FK__DECLARATI__Citiz__2CBDA3B5
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CONSTRUCT__Const__1E6F845E]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CONSTRUCTION_REFINANCE_DATA] DROP CONSTRAINT FK__CONSTRUCT__Const__1E6F845E
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CONTACT_P__RoleT__2334397B]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CONTACT_POINT] DROP CONSTRAINT FK__CONTACT_P__RoleT__2334397B
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CONTACT_PO__Type__24285DB4]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CONTACT_POINT] DROP CONSTRAINT FK__CONTACT_PO__Type__24285DB4
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__BUYDOWN__Contrib__1C873BEC]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[BUYDOWN] DROP CONSTRAINT FK__BUYDOWN__Contrib__1C873BEC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CREDIT_SC__Credi__2704CA5F]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CREDIT_SCORE] DROP CONSTRAINT FK__CREDIT_SC__Credi__2704CA5F
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CREDIT_SC__Credi__27F8EE98]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CREDIT_SCORE] DROP CONSTRAINT FK__CREDIT_SC__Credi__27F8EE98
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CREDIT_SC__Credi__2610A626]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CREDIT_SCORE] DROP CONSTRAINT FK__CREDIT_SC__Credi__2610A626
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__REO_PROPE__Dispo__6E8B6712]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[REO_PROPERTY] DROP CONSTRAINT FK__REO_PROPE__Dispo__6E8B6712
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__DOWN_PAYME__Type__7849DB76]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[DOWN_PAYMENT] DROP CONSTRAINT FK__DOWN_PAYME__Type__7849DB76
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__EXPLANATIO__Type__6ABAD62E]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[EXPLANATION] DROP CONSTRAINT FK__EXPLANATIO__Type__6ABAD62E
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__FHA_LOAN__FHAAli__318258D2]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FHA_LOAN] DROP CONSTRAINT FK__FHA_LOAN__FHAAli__318258D2
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__AFFORDABL__FNMCo__6FB49575]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[AFFORDABLE_LENDING] DROP CONSTRAINT FK__AFFORDABL__FNMCo__6FB49575
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__FHA_VA_BO__FNMCr__3552E9B6]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FHA_VA_BORROWER] DROP CONSTRAINT FK__FHA_VA_BO__FNMCr__3552E9B6
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_FEAT__FullP__40C49C62]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_FEATURES] DROP CONSTRAINT FK__LOAN_FEAT__FullP__40C49C62
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_FEAT__GSEPr__41B8C09B]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_FEATURES] DROP CONSTRAINT FK__LOAN_FEAT__GSEPr__41B8C09B
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_FEAT__GSEPr__42ACE4D4]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_FEATURES] DROP CONSTRAINT FK__LOAN_FEAT__GSEPr__42ACE4D4
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PROPERTY__GSEPro__0F2D40CE]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PROPERTY] DROP CONSTRAINT FK__PROPERTY__GSEPro__0F2D40CE
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__REO_PROPE__GSEPr__6F7F8B4B]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[REO_PROPERTY] DROP CONSTRAINT FK__REO_PROPE__GSEPr__6F7F8B4B
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CONSTRUCT__GSERe__1F63A897]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CONSTRUCTION_REFINANCE_DATA] DROP CONSTRAINT FK__CONSTRUCT__GSERe__1F63A897
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__GOVERNMEN__Gende__39237A9A]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[GOVERNMENT_MONITORING] DROP CONSTRAINT FK__GOVERNMEN__Gende__39237A9A
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__FHA_VA_LO__Gover__36470DEF]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FHA_VA_LOAN] DROP CONSTRAINT FK__FHA_VA_LO__Gover__36470DEF
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__GOVERNMEN__HMDAE__3A179ED3]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[GOVERNMENT_MONITORING] DROP CONSTRAINT FK__GOVERNMEN__HMDAE__3A179ED3
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__GOVERNMEN__HMDAP__7A3223E8]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[GOVERNMENT_REPORTING] DROP CONSTRAINT FK__GOVERNMEN__HMDAP__7A3223E8
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__GOVERNMEN__HMDAP__7B264821]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[GOVERNMENT_REPORTING] DROP CONSTRAINT FK__GOVERNMEN__HMDAP__7B264821
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__HMDA_RACE__Type__6CA31EA0]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[HMDA_RACE] DROP CONSTRAINT FK__HMDA_RACE__Type__6CA31EA0
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PRESENT_H__Housi__57A801BA]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PRESENT_HOUSING_EXPENSE] DROP CONSTRAINT FK__PRESENT_H__Housi__57A801BA
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PROPOSED___Housi__11158940]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PROPOSED_HOUSING_EXPENSE] DROP CONSTRAINT FK__PROPOSED___Housi__11158940
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CURRENT_I__Incom__29E1370A]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CURRENT_INCOME] DROP CONSTRAINT FK__CURRENT_I__Incom__29E1370A
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__ARM__IndexType__16CE6296]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ARM] DROP CONSTRAINT FK__ARM__IndexType__16CE6296
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__BORROWER__JointA__72910220]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[BORROWER] DROP CONSTRAINT FK__BORROWER__JointA__72910220
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__ADDITIONA__LoanA__6EC0713C]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ADDITIONAL_CASE_DATA] DROP CONSTRAINT FK__ADDITIONA__LoanA__6EC0713C
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__AFFORDABL__LoanA__70A8B9AE]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[AFFORDABLE_LENDING] DROP CONSTRAINT FK__AFFORDABL__LoanA__70A8B9AE
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__ASSET__LoanAppli__19AACF41]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ASSET] DROP CONSTRAINT FK__ASSET__LoanAppli__19AACF41
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__BORROWER__LoanAp__73852659]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[BORROWER] DROP CONSTRAINT FK__BORROWER__LoanAp__73852659
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__DATA_INFO__LoanA__76619304]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[DATA_INFORMATION] DROP CONSTRAINT FK__DATA_INFO__LoanA__76619304
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__DOWN_PAYM__LoanA__7755B73D]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[DOWN_PAYMENT] DROP CONSTRAINT FK__DOWN_PAYM__LoanA__7755B73D
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__GOVERNMEN__LoanA__793DFFAF]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[GOVERNMENT_LOAN] DROP CONSTRAINT FK__GOVERNMEN__LoanA__793DFFAF
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__GOVERNMEN__LoanA__7C1A6C5A]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[GOVERNMENT_REPORTING] DROP CONSTRAINT FK__GOVERNMEN__LoanA__7C1A6C5A
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__INTERVIEW__LoanA__7E02B4CC]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[INTERVIEWER_INFORMATION] DROP CONSTRAINT FK__INTERVIEW__LoanA__7E02B4CC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LIABILITY__LoanA__3EDC53F0]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LIABILITY] DROP CONSTRAINT FK__LIABILITY__LoanA__3EDC53F0
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_PROD__LoanA__7FEAFD3E]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_PRODUCT_DATA] DROP CONSTRAINT FK__LOAN_PROD__LoanA__7FEAFD3E
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_PURP__LoanA__00DF2177]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_PURPOSE] DROP CONSTRAINT FK__LOAN_PURP__LoanA__00DF2177
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_QUAL__LoanA__04AFB25B]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_QUALIFICATION] DROP CONSTRAINT FK__LOAN_QUAL__LoanA__04AFB25B
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__MORTGAGE___LoanA__0C50D423]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MORTGAGE_TERMS] DROP CONSTRAINT FK__MORTGAGE___LoanA__0C50D423
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PROPERTY__LoanAp__10216507]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PROPERTY] DROP CONSTRAINT FK__PROPERTY__LoanAp__10216507
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PROPOSED___LoanA__1209AD79]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PROPOSED_HOUSING_EXPENSE] DROP CONSTRAINT FK__PROPOSED___LoanA__1209AD79
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__REO_PROPE__LoanA__7167D3BD]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[REO_PROPERTY] DROP CONSTRAINT FK__REO_PROPE__LoanA__7167D3BD
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__TITLE_HOL__LoanA__13F1F5EB]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[TITLE_HOLDER] DROP CONSTRAINT FK__TITLE_HOL__LoanA__13F1F5EB
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__TRANSACTI__LoanA__14E61A24]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[TRANSACTION_DETAIL] DROP CONSTRAINT FK__TRANSACTI__LoanA__14E61A24
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__TITLE_HOL__LandT__12FDD1B2]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[TITLE_HOLDER] DROP CONSTRAINT FK__TITLE_HOL__LandT__12FDD1B2
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LEGAL_DESC__Type__3CF40B7E]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LEGAL_DESCRIPTION] DROP CONSTRAINT FK__LEGAL_DESC__Type__3CF40B7E
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LIABILITY__Type__3FD07829]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LIABILITY] DROP CONSTRAINT FK__LIABILITY__Type__3FD07829
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_FEAT__LienP__43A1090D]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_FEATURES] DROP CONSTRAINT FK__LOAN_FEAT__LienP__43A1090D
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__MORTGAGE___LoanA__0B5CAFEA]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MORTGAGE_TERMS] DROP CONSTRAINT FK__MORTGAGE___LoanA__0B5CAFEA
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_FEAT__LoanC__4589517F]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_FEATURES] DROP CONSTRAINT FK__LOAN_FEAT__LoanC__4589517F
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_FEAT__LoanD__467D75B8]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_FEATURES] DROP CONSTRAINT FK__LOAN_FEAT__LoanD__467D75B8
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_FEAT__LoanR__477199F1]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_FEATURES] DROP CONSTRAINT FK__LOAN_FEAT__LoanR__477199F1
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_FEAT__MICer__4865BE2A]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_FEATURES] DROP CONSTRAINT FK__LOAN_FEAT__MICer__4865BE2A
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_FEAT__MICom__4959E263]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_FEATURES] DROP CONSTRAINT FK__LOAN_FEAT__MICom__4959E263
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__BORROWER__Marita__74794A92]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[BORROWER] DROP CONSTRAINT FK__BORROWER__Marita__74794A92
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__TRANSMITT__Curre__6225902D]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[TRANSMITTAL_DATA] DROP CONSTRAINT FK__TRANSMITT__Curre__6225902D
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__MORTGAGE_S__Type__53D770D6]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MORTGAGE_SCORE] DROP CONSTRAINT FK__MORTGAGE_S__Type__53D770D6
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__MORTGAGE___Mortg__0D44F85C]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MORTGAGE_TERMS] DROP CONSTRAINT FK__MORTGAGE___Mortg__0D44F85C
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_FEAT__NameD__4A4E069C]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_FEATURES] DROP CONSTRAINT FK__LOAN_FEAT__NameD__4A4E069C
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__FHA_LOAN__Sectio__336AA144]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FHA_LOAN] DROP CONSTRAINT FK__FHA_LOAN__Sectio__336AA144
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_FEAT__Payme__4B422AD5]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_FEATURES] DROP CONSTRAINT FK__LOAN_FEAT__Payme__4B422AD5
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__BORROWER__PrintP__756D6ECB]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[BORROWER] DROP CONSTRAINT FK__BORROWER__PrintP__756D6ECB
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__DECLARATI__Prior__2EA5EC27]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[DECLARATION] DROP CONSTRAINT FK__DECLARATI__Prior__2EA5EC27
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__DECLARATI__Prior__2DB1C7EE]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[DECLARATION] DROP CONSTRAINT FK__DECLARATI__Prior__2DB1C7EE
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_PURP__Prope__02C769E9]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_PURPOSE] DROP CONSTRAINT FK__LOAN_PURP__Prope__02C769E9
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_PURP__Prope__01D345B0]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_PURPOSE] DROP CONSTRAINT FK__LOAN_PURP__Prope__01D345B0
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__VALUATION__Metho__66EA454A]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[VALUATION] DROP CONSTRAINT FK__VALUATION__Metho__66EA454A
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PURCHASE___Sourc__59904A2C]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PURCHASE_CREDIT] DROP CONSTRAINT FK__PURCHASE___Sourc__59904A2C
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PURCHASE_C__Type__5A846E65]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PURCHASE_CREDIT] DROP CONSTRAINT FK__PURCHASE_C__Type__5A846E65
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_PURPO__Type__03BB8E22]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_PURPOSE] DROP CONSTRAINT FK__LOAN_PURPO__Type__03BB8E22
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__GOVERNMEN__RaceN__3B0BC30C]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[GOVERNMENT_MONITORING] DROP CONSTRAINT FK__GOVERNMEN__RaceN__3B0BC30C
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__TRANSMITT__RateL__640DD89F]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[TRANSMITTAL_DATA] DROP CONSTRAINT FK__TRANSMITT__RateL__640DD89F
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CONSTRUCT__Refin__214BF109]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CONSTRUCTION_REFINANCE_DATA] DROP CONSTRAINT FK__CONSTRUCT__Refin__214BF109
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_FEAT__Servi__4C364F0E]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_FEATURES] DROP CONSTRAINT FK__LOAN_FEAT__Servi__4C364F0E
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__SUMMARY__AmountT__5F492382]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[SUMMARY] DROP CONSTRAINT FK__SUMMARY__AmountT__5F492382
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__MORTGAGE___LoanA__52E34C9D]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MORTGAGE_SCORE] DROP CONSTRAINT FK__MORTGAGE___LoanA__52E34C9D
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__TRANSMITT__LoanA__6319B466]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[TRANSMITTAL_DATA] DROP CONSTRAINT FK__TRANSMITT__LoanA__6319B466
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__ALIAS__BorrowerI__15DA3E5D]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ALIAS] DROP CONSTRAINT FK__ALIAS__BorrowerI__15DA3E5D
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__ASSET__BorrowerI__18B6AB08]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ASSET] DROP CONSTRAINT FK__ASSET__BorrowerI__18B6AB08
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__BORROWER__JointA__719CDDE7]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[BORROWER] DROP CONSTRAINT FK__BORROWER__JointA__719CDDE7
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CONTACT_P__Borro__22401542]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CONTACT_POINT] DROP CONSTRAINT FK__CONTACT_P__Borro__22401542
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CREDIT_SC__Borro__251C81ED]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CREDIT_SCORE] DROP CONSTRAINT FK__CREDIT_SC__Borro__251C81ED
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CURRENT_I__Borro__28ED12D1]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CURRENT_INCOME] DROP CONSTRAINT FK__CURRENT_I__Borro__28ED12D1
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__DECLARATI__Borro__2BC97F7C]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[DECLARATION] DROP CONSTRAINT FK__DECLARATI__Borro__2BC97F7C
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__DEPENDENT__Borro__2F9A1060]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[DEPENDENT] DROP CONSTRAINT FK__DEPENDENT__Borro__2F9A1060
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__EMPLOYER__Borrow__308E3499]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[EMPLOYER] DROP CONSTRAINT FK__EMPLOYER__Borrow__308E3499
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__FHA_VA_BO__Borro__345EC57D]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FHA_VA_BORROWER] DROP CONSTRAINT FK__FHA_VA_BO__Borro__345EC57D
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__GOVERNMEN__Borro__382F5661]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[GOVERNMENT_MONITORING] DROP CONSTRAINT FK__GOVERNMEN__Borro__382F5661
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LIABILITY__Borro__3DE82FB7]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LIABILITY] DROP CONSTRAINT FK__LIABILITY__Borro__3DE82FB7
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__MAIL_TO__Borrowe__4D2A7347]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[MAIL_TO] DROP CONSTRAINT FK__MAIL_TO__Borrowe__4D2A7347
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PRESENT_H__Borro__56B3DD81]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PRESENT_HOUSING_EXPENSE] DROP CONSTRAINT FK__PRESENT_H__Borro__56B3DD81
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__REO_PROPE__Borro__6D9742D9]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[REO_PROPERTY] DROP CONSTRAINT FK__REO_PROPE__Borro__6D9742D9
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__RESIDENCE__Borro__5E54FF49]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[RESIDENCE] DROP CONSTRAINT FK__RESIDENCE__Borro__5E54FF49
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__SUMMARY__Borrowe__603D47BB]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[SUMMARY] DROP CONSTRAINT FK__SUMMARY__Borrowe__603D47BB
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__VA_BORROW__Borro__67DE6983]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[VA_BORROWER] DROP CONSTRAINT FK__VA_BORROW__Borro__67DE6983
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__DATA_VERS__LoanA__2AD55B43]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[DATA_VERSION] DROP CONSTRAINT FK__DATA_VERS__LoanA__2AD55B43
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__FHA_LOAN__LoanAp__32767D0B]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FHA_LOAN] DROP CONSTRAINT FK__FHA_LOAN__LoanAp__32767D0B
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__FHA_VA_LO__LoanA__373B3228]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[FHA_VA_LOAN] DROP CONSTRAINT FK__FHA_VA_LO__LoanA__373B3228
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__VA_LOAN__LoanApp__68D28DBC]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[VA_LOAN] DROP CONSTRAINT FK__VA_LOAN__LoanApp__68D28DBC
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__ARM__LoanApplica__17C286CF]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ARM] DROP CONSTRAINT FK__ARM__LoanApplica__17C286CF
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__BUYDOWN__LoanApp__1D7B6025]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[BUYDOWN] DROP CONSTRAINT FK__BUYDOWN__LoanApp__1D7B6025
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LOAN_FEAT__LoanA__44952D46]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LOAN_FEATURES] DROP CONSTRAINT FK__LOAN_FEAT__LoanA__44952D46
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PAYMENT_A__LoanA__55BFB948]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PAYMENT_ADJUSTMENT] DROP CONSTRAINT FK__PAYMENT_A__LoanA__55BFB948
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__RATE_ADJU__LoanA__5B78929E]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[RATE_ADJUSTMENT] DROP CONSTRAINT FK__RATE_ADJU__LoanA__5B78929E
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__CONSTRUCT__LoanA__2057CCD0]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CONSTRUCTION_REFINANCE_DATA] DROP CONSTRAINT FK__CONSTRUCT__LoanA__2057CCD0
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__LEGAL_DES__LoanA__3BFFE745]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[LEGAL_DESCRIPTION] DROP CONSTRAINT FK__LEGAL_DES__LoanA__3BFFE745
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PARSED_ST__LoanA__54CB950F]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PARSED_STREET_ADDRESS] DROP CONSTRAINT FK__PARSED_ST__LoanA__54CB950F
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__VALUATION__LoanA__65F62111]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[VALUATION] DROP CONSTRAINT FK__VALUATION__LoanA__65F62111
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__PURCHASE___LoanA__589C25F3]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PURCHASE_CREDIT] DROP CONSTRAINT FK__PURCHASE___LoanA__589C25F3
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__EXPLANATI__Borro__69C6B1F5]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[EXPLANATION] DROP CONSTRAINT FK__EXPLANATI__Borro__69C6B1F5
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__HMDA_RACE__Borro__6BAEFA67]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[HMDA_RACE] DROP CONSTRAINT FK__HMDA_RACE__Borro__6BAEFA67
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK__REO_PROPE__Liabi__7073AF84]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[REO_PROPERTY] DROP CONSTRAINT FK__REO_PROPE__Liabi__7073AF84
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateExplanation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateExplanation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateHMDARace]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateHMDARace]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateREOProperty]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateREOProperty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteExplanation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteExplanation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteHMDARace]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteHMDARace]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteREOProperty]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteREOProperty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectExplanation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectExplanation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectExplanations]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectExplanations]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectExplanationsByDeclaration]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectExplanationsByDeclaration]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectExplanationsByExplanationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectExplanationsByExplanationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHMDARace]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHMDARace]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHMDARaces]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHMDARaces]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHMDARacesByGovernmentMonitoring]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHMDARacesByGovernmentMonitoring]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHMDARacesByHMDARaceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHMDARacesByHMDARaceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectREOProperties]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectREOProperties]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectREOPropertiesByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectREOPropertiesByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectREOPropertiesByDispositionStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectREOPropertiesByDispositionStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectREOPropertiesByGSEPropertyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectREOPropertiesByGSEPropertyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectREOPropertiesByLiability]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectREOPropertiesByLiability]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectREOPropertiesByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectREOPropertiesByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectREOProperty]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectREOProperty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateExplanation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateExplanation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateHMDARace]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateHMDARace]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateREOProperty]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateREOProperty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateARM]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateARM]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateAlias]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateAlias]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateAsset]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateAsset]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateBuydown]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateBuydown]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateConstructionRefinanceData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateConstructionRefinanceData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateContactPoint]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateContactPoint]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateCreditScore]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateCreditScore]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateCurrentIncome]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateCurrentIncome]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateDataVersion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateDataVersion]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateDeclaration]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateDeclaration]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateDependent]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateDependent]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateEmployer]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateEmployer]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateFHALoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateFHALoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateFHAVABorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateFHAVABorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateFHAVALoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateFHAVALoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateGovernmentMonitoring]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateGovernmentMonitoring]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLegalDescription]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLegalDescription]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLiability]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLiability]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLoanFeatures]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLoanFeatures]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateMailTo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateMailTo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateMortgageScore]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateMortgageScore]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateParsedStreetAddress]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateParsedStreetAddress]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreatePaymentAdjustment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreatePaymentAdjustment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreatePresentHousingExpense]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreatePresentHousingExpense]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreatePurchaseCredit]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreatePurchaseCredit]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateRateAdjustment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateRateAdjustment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateResidence]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateResidence]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateSummary]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateSummary]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateTransmittalData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateTransmittalData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateVABorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateVABorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateVALoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateVALoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateValuation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateValuation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteARM]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteARM]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteAlias]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteAlias]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteAsset]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteAsset]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteBuydown]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteBuydown]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteConstructionRefinanceData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteConstructionRefinanceData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteContactPoint]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteContactPoint]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteCreditScore]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteCreditScore]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteCurrentIncome]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteCurrentIncome]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteDataVersion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteDataVersion]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteDeclaration]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteDeclaration]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteDependent]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteDependent]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteEmployer]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteEmployer]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteFHALoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteFHALoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteFHAVABorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteFHAVABorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteFHAVALoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteFHAVALoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteGovernmentMonitoring]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteGovernmentMonitoring]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLegalDescription]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLegalDescription]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLiability]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLiability]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLoanFeatures]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLoanFeatures]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteMailTo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteMailTo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteMortgageScore]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteMortgageScore]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteParsedStreetAddress]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteParsedStreetAddress]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeletePaymentAdjustment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeletePaymentAdjustment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeletePresentHousingExpense]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeletePresentHousingExpense]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeletePurchaseCredit]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeletePurchaseCredit]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteRateAdjustment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteRateAdjustment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteResidence]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteResidence]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteSummary]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteSummary]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteTransmittalData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteTransmittalData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteVABorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteVABorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteVALoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteVALoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteValuation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteValuation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectARM]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectARM]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectARMCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectARMCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectARMCollectionByInterestRateIndex]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectARMCollectionByInterestRateIndex]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectARMCollectionByLoanProductData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectARMCollectionByLoanProductData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAlias]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAlias]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAliases]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAliases]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAliasesByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAliasesByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAsset]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAsset]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAssets]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAssets]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAssetsByAssetType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAssetsByAssetType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAssetsByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAssetsByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAssetsByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAssetsByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBuydown]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBuydown]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBuydownCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBuydownCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBuydownCollectionByBaseDataType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBuydownCollectionByBaseDataType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBuydownCollectionByContributorType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBuydownCollectionByContributorType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBuydownCollectionByLoanProductData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBuydownCollectionByLoanProductData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectConstructionRefinanceData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectConstructionRefinanceData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectConstructionRefinanceDataCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectConstructionRefinanceDataCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectConstructionRefinanceDataCollectionByConstructionPurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectConstructionRefinanceDataCollectionByConstructionPurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectConstructionRefinanceDataCollectionByGSERefinancePurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectConstructionRefinanceDataCollectionByGSERefinancePurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectConstructionRefinanceDataCollectionByLoanPurpose]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectConstructionRefinanceDataCollectionByLoanPurpose]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectConstructionRefinanceDataCollectionByRefinanceImprovementsType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectConstructionRefinanceDataCollectionByRefinanceImprovementsType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectContactPoint]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectContactPoint]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectContactPointCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectContactPointCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectContactPointCollectionByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectContactPointCollectionByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectContactPointCollectionByContactPointRoleType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectContactPointCollectionByContactPointRoleType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectContactPointCollectionByContactPointType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectContactPointCollectionByContactPointType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCreditScore]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCreditScore]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCreditScores]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCreditScores]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCreditScoresByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCreditScoresByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCreditScoresByCreditRepositorySourceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCreditScoresByCreditRepositorySourceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCreditScoresByCreditScoreExclusionReasonType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCreditScoresByCreditScoreExclusionReasonType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCreditScoresByCreditScoreModelNameType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCreditScoresByCreditScoreModelNameType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCurrentIncome]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCurrentIncome]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCurrentIncomeCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCurrentIncomeCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCurrentIncomeCollectionByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCurrentIncomeCollectionByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCurrentIncomeCollectionByIncomeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCurrentIncomeCollectionByIncomeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDataVersion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDataVersion]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDataVersions]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDataVersions]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDataVersionsByDataInformation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDataVersionsByDataInformation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDeclaration]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDeclaration]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDeclarations]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDeclarations]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDeclarationsByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDeclarationsByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDeclarationsByCitizenshipResidencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDeclarationsByCitizenshipResidencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDeclarationsByPriorPropertyTitleType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDeclarationsByPriorPropertyTitleType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDeclarationsByPriorPropertyUsageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDeclarationsByPriorPropertyUsageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDependent]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDependent]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDependents]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDependents]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDependentsByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDependentsByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectEmployer]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectEmployer]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectEmployers]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectEmployers]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectEmployersByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectEmployersByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHALoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHALoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHALoans]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHALoans]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHALoansByFHAAlimonyLiabilityTreatmentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHALoansByFHAAlimonyLiabilityTreatmentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHALoansByGovernmentLoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHALoansByGovernmentLoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHALoansByNationalHousingActSectionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHALoansByNationalHousingActSectionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHAVABorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHAVABorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHAVABorrowers]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHAVABorrowers]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHAVABorrowersByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHAVABorrowersByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHAVABorrowersByFNMCreditReportScoreType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHAVABorrowersByFNMCreditReportScoreType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHAVALoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHAVALoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHAVALoans]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHAVALoans]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHAVALoansByGovernmentLoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHAVALoansByGovernmentLoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHAVALoansByGovernmentRefinanceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHAVALoansByGovernmentRefinanceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentMonitoring]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentMonitoring]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentMonitoringCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentMonitoringCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentMonitoringCollectionByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentMonitoringCollectionByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentMonitoringCollectionByGenderType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentMonitoringCollectionByGenderType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentMonitoringCollectionByHMDAEthnicityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentMonitoringCollectionByHMDAEthnicityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentMonitoringCollectionByRaceNationalOriginType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentMonitoringCollectionByRaceNationalOriginType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLegalDescription]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLegalDescription]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLegalDescriptions]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLegalDescriptions]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLegalDescriptionsByLegalType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLegalDescriptionsByLegalType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLegalDescriptionsByProperty]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLegalDescriptionsByProperty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLiabilities]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLiabilities]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLiabilitiesByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLiabilitiesByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLiabilitiesByLiabilityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLiabilitiesByLiabilityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLiabilitiesByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLiabilitiesByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLiability]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLiability]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeatures]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeatures]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollectionByFullPrepaymentPenaltyOptionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollectionByFullPrepaymentPenaltyOptionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollectionByGSEProjectClassificationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollectionByGSEProjectClassificationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollectionByGSEPropertyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollectionByGSEPropertyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollectionByLienPriorityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollectionByLienPriorityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollectionByLoanClosingStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollectionByLoanClosingStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollectionByLoanDocumentationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollectionByLoanDocumentationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollectionByLoanProductData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollectionByLoanProductData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollectionByLoanRepaymentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollectionByLoanRepaymentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollectionByMICertificationStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollectionByMICertificationStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollectionByMICompanyNameType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollectionByMICompanyNameType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollectionByNameDocumentsDrawnInType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollectionByNameDocumentsDrawnInType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollectionByPaymentFrequencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollectionByPaymentFrequencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanFeaturesCollectionByServicingTransferStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanFeaturesCollectionByServicingTransferStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMailTo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMailTo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMailToCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMailToCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMailToCollectionByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMailToCollectionByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageScore]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageScore]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageScores]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageScores]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageScoresByAdditionalCaseData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageScoresByAdditionalCaseData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageScoresByMortgageScoreType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageScoresByMortgageScoreType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectParsedStreetAddress]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectParsedStreetAddress]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectParsedStreetAddresses]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectParsedStreetAddresses]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectParsedStreetAddressesByProperty]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectParsedStreetAddressesByProperty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPaymentAdjustment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPaymentAdjustment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPaymentAdjustments]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPaymentAdjustments]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPaymentAdjustmentsByLoanProductData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPaymentAdjustmentsByLoanProductData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPresentHousingExpense]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPresentHousingExpense]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPresentHousingExpenses]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPresentHousingExpenses]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPresentHousingExpensesByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPresentHousingExpensesByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPresentHousingExpensesByHousingExpenseType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPresentHousingExpensesByHousingExpenseType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPurchaseCredit]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPurchaseCredit]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPurchaseCreditCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPurchaseCreditCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPurchaseCreditCollectionByPurchaseCreditSourceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPurchaseCreditCollectionByPurchaseCreditSourceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPurchaseCreditCollectionByPurchaseCreditType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPurchaseCreditCollectionByPurchaseCreditType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPurchaseCreditCollectionByTransactionDetail]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPurchaseCreditCollectionByTransactionDetail]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectRateAdjustment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectRateAdjustment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectRateAdjustments]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectRateAdjustments]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectRateAdjustmentsByLoanProductData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectRateAdjustmentsByLoanProductData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectResidence]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectResidence]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectResidences]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectResidences]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectResidencesByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectResidencesByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectResidencesByBorrowerResidencyBasisType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectResidencesByBorrowerResidencyBasisType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectResidencesByBorrowerResidencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectResidencesByBorrowerResidencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectSummaries]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectSummaries]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectSummariesByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectSummariesByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectSummariesBySummaryAmountType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectSummariesBySummaryAmountType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectSummary]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectSummary]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectTransmittalData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectTransmittalData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectTransmittalDataCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectTransmittalDataCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectTransmittalDataCollectionByAdditionalCaseData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectTransmittalDataCollectionByAdditionalCaseData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectTransmittalDataCollectionByCaseStateType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectTransmittalDataCollectionByCaseStateType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectTransmittalDataCollectionByMortgageHolderType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectTransmittalDataCollectionByMortgageHolderType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectTransmittalDataCollectionByRateLockType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectTransmittalDataCollectionByRateLockType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectVABorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectVABorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectVABorrowers]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectVABorrowers]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectVABorrowersByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectVABorrowersByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectVALoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectVALoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectVALoans]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectVALoans]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectVALoansByGovernmentLoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectVALoansByGovernmentLoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectValuation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectValuation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectValuations]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectValuations]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectValuationsByAppraiser]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectValuationsByAppraiser]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectValuationsByProperty]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectValuationsByProperty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectValuationsByPropertyValuationMethodType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectValuationsByPropertyValuationMethodType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateARM]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateARM]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateAlias]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateAlias]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateAsset]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateAsset]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateBuydown]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateBuydown]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateConstructionRefinanceData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateConstructionRefinanceData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateContactPoint]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateContactPoint]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateCreditScore]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateCreditScore]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateCurrentIncome]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateCurrentIncome]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateDataVersion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateDataVersion]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateDeclaration]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateDeclaration]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateDependent]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateDependent]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateEmployer]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateEmployer]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateFHALoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateFHALoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateFHAVABorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateFHAVABorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateFHAVALoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateFHAVALoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateGovernmentMonitoring]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateGovernmentMonitoring]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLegalDescription]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLegalDescription]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLiability]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLiability]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLoanFeatures]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLoanFeatures]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateMailTo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateMailTo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateMortgageScore]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateMortgageScore]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateParsedStreetAddress]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateParsedStreetAddress]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdatePaymentAdjustment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdatePaymentAdjustment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdatePresentHousingExpense]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdatePresentHousingExpense]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdatePurchaseCredit]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdatePurchaseCredit]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateRateAdjustment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateRateAdjustment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateResidence]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateResidence]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateSummary]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateSummary]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateTransmittalData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateTransmittalData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateVABorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateVABorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateVALoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateVALoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateValuation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateValuation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_BorrowersGetBySSN]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_BorrowersGetBySSN]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateAdditionalCaseData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateAdditionalCaseData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateAffordableLending]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateAffordableLending]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateDataInformation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateDataInformation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateDownPayment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateDownPayment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateGovernmentLoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateGovernmentLoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateGovernmentReporting]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateGovernmentReporting]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateInterviewerInformation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateInterviewerInformation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLoanProductData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLoanProductData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLoanPurpose]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLoanPurpose]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLoanQualification]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLoanQualification]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateMortgageTerms]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateMortgageTerms]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateProperty]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateProperty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateProposedHousingExpense]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateProposedHousingExpense]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateTitleHolder]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateTitleHolder]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateTransactionDetail]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateTransactionDetail]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteAdditionalCaseData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteAdditionalCaseData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteAffordableLending]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteAffordableLending]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteDataInformation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteDataInformation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteDownPayment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteDownPayment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteGovernmentLoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteGovernmentLoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteGovernmentReporting]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteGovernmentReporting]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteInterviewerInformation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteInterviewerInformation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLoanProductData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLoanProductData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLoanPurpose]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLoanPurpose]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLoanQualification]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLoanQualification]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteMortgageTerms]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteMortgageTerms]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteProperty]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteProperty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteProposedHousingExpense]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteProposedHousingExpense]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteTitleHolder]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteTitleHolder]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteTransactionDetail]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteTransactionDetail]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAdditionalCaseData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAdditionalCaseData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAdditionalCaseDataCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAdditionalCaseDataCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAdditionalCaseDataCollectionByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAdditionalCaseDataCollectionByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAffordableLending]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAffordableLending]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAffordableLendingCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAffordableLendingCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAffordableLendingCollectionByFNMCommunityLendingProductType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAffordableLendingCollectionByFNMCommunityLendingProductType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAffordableLendingCollectionByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAffordableLendingCollectionByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBorrowers]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBorrowers]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBorrowersByBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBorrowersByBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBorrowersByJointAssetLiabilityReportingType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBorrowersByJointAssetLiabilityReportingType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBorrowersByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBorrowersByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBorrowersByMaritalStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBorrowersByMaritalStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBorrowersByPrintPositionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBorrowersByPrintPositionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDataInformation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDataInformation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDataInformationCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDataInformationCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDataInformationCollectionByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDataInformationCollectionByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDownPayment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDownPayment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDownPayments]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDownPayments]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDownPaymentsByDownPaymentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDownPaymentsByDownPaymentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDownPaymentsByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDownPaymentsByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentLoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentLoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentLoans]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentLoans]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentLoansByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentLoansByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentReporting]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentReporting]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentReportingCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentReportingCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentReportingCollectionByHMDAPreapprovalType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentReportingCollectionByHMDAPreapprovalType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentReportingCollectionByHMDAPurposeOfLoanType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentReportingCollectionByHMDAPurposeOfLoanType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentReportingCollectionByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentReportingCollectionByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectInterviewerInformation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectInterviewerInformation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectInterviewerInformationCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectInterviewerInformationCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectInterviewerInformationCollectionByApplicationMethod]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectInterviewerInformationCollectionByApplicationMethod]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectInterviewerInformationCollectionByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectInterviewerInformationCollectionByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanProductData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanProductData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanProductDataCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanProductDataCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanProductDataCollectionByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanProductDataCollectionByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanPurpose]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanPurpose]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanPurposes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanPurposes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanPurposesByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanPurposesByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanPurposesByPropertyRightsType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanPurposesByPropertyRightsType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanPurposesByPropertyUsageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanPurposesByPropertyUsageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanPurposesByPurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanPurposesByPurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanQualification]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanQualification]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanQualifications]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanQualifications]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanQualificationsByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanQualificationsByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageTerms]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageTerms]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageTermsCollection]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageTermsCollection]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageTermsCollectionByLoanAmortizationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageTermsCollectionByLoanAmortizationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageTermsCollectionByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageTermsCollectionByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageTermsCollectionByMortgageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageTermsCollectionByMortgageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectProperties]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectProperties]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPropertiesByBuildingStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPropertiesByBuildingStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPropertiesByGSEPropertyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPropertiesByGSEPropertyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPropertiesByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPropertiesByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectProperty]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectProperty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectProposedHousingExpense]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectProposedHousingExpense]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectProposedHousingExpenses]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectProposedHousingExpenses]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectProposedHousingExpensesByHousingExpenseType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectProposedHousingExpensesByHousingExpenseType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectProposedHousingExpensesByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectProposedHousingExpensesByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectTitleHolder]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectTitleHolder]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectTitleHolders]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectTitleHolders]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectTitleHoldersByLandTrustType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectTitleHoldersByLandTrustType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectTitleHoldersByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectTitleHoldersByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectTransactionDetail]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectTransactionDetail]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectTransactionDetails]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectTransactionDetails]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectTransactionDetailsByLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectTransactionDetailsByLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateAdditionalCaseData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateAdditionalCaseData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateAffordableLending]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateAffordableLending]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateBorrower]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateBorrower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateDataInformation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateDataInformation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateDownPayment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateDownPayment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateGovernmentLoan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateGovernmentLoan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateGovernmentReporting]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateGovernmentReporting]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateInterviewerInformation]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateInterviewerInformation]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLoanProductData]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLoanProductData]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLoanPurpose]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLoanPurpose]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLoanQualification]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLoanQualification]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateMortgageTerms]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateMortgageTerms]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateProperty]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateProperty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateProposedHousingExpense]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateProposedHousingExpense]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateTitleHolder]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateTitleHolder]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateTransactionDetail]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateTransactionDetail]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateApplicationMethod]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateApplicationMethod]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateAppraiser]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateAppraiser]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateAssetType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateAssetType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateBaseDataType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateBaseDataType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateBorrowerResidencyBasisType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateBorrowerResidencyBasisType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateBorrowerResidencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateBorrowerResidencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateBuildingStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateBuildingStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateCaseStateType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateCaseStateType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateCitizenshipResidencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateCitizenshipResidencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateConstructionPurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateConstructionPurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateContactPointRoleType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateContactPointRoleType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateContactPointType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateContactPointType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateContributorType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateContributorType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateCreditRepositorySourceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateCreditRepositorySourceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateCreditScoreExclusionReasonType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateCreditScoreExclusionReasonType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateCreditScoreModelNameType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateCreditScoreModelNameType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateDispositionStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateDispositionStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateDownPaymentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateDownPaymentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateExplanationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateExplanationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateFHAAlimonyLiabilityTreatmentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateFHAAlimonyLiabilityTreatmentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateFNMCommunityLendingProductType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateFNMCommunityLendingProductType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateFNMCreditReportScoreType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateFNMCreditReportScoreType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateFullPrepaymentPenaltyOptionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateFullPrepaymentPenaltyOptionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateGSEProjectClassificationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateGSEProjectClassificationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateGSEPropertyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateGSEPropertyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateGSERefinancePurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateGSERefinancePurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateGenderType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateGenderType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateGovernmentRefinanceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateGovernmentRefinanceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateHMDAEthnicityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateHMDAEthnicityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateHMDAPreapprovalType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateHMDAPreapprovalType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateHMDAPurposeOfLoanType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateHMDAPurposeOfLoanType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateHMDARaceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateHMDARaceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateHousingExpenseType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateHousingExpenseType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateIncomeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateIncomeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateInterestRateIndex]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateInterestRateIndex]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateJointAssetLiabilityReportingType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateJointAssetLiabilityReportingType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLandTrustType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLandTrustType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLegalType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLegalType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLiabilityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLiabilityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLienPriorityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLienPriorityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLoanAmortizationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLoanAmortizationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLoanClosingStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLoanClosingStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLoanDocumentationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLoanDocumentationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateLoanRepaymentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateLoanRepaymentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateMICertificationStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateMICertificationStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateMICompanyNameType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateMICompanyNameType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateMaritalStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateMaritalStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateMortgageHolderType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateMortgageHolderType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateMortgageScoreType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateMortgageScoreType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateMortgageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateMortgageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateNameDocumentsDrawnInType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateNameDocumentsDrawnInType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateNationalHousingActSectionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateNationalHousingActSectionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreatePaymentFrequencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreatePaymentFrequencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreatePrintPositionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreatePrintPositionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreatePriorPropertyTitleType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreatePriorPropertyTitleType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreatePriorPropertyUsageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreatePriorPropertyUsageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreatePropertyRightsType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreatePropertyRightsType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreatePropertyUsageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreatePropertyUsageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreatePropertyValuationMethodType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreatePropertyValuationMethodType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreatePurchaseCreditSourceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreatePurchaseCreditSourceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreatePurchaseCreditType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreatePurchaseCreditType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreatePurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreatePurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateRaceNationalOriginType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateRaceNationalOriginType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateRateLockType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateRateLockType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateRefinanceImprovementsType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateRefinanceImprovementsType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateServicingTransferStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateServicingTransferStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_CreateSummaryAmountType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_CreateSummaryAmountType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteApplicationMethod]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteApplicationMethod]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteAppraiser]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteAppraiser]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteAssetType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteAssetType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteBaseDataType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteBaseDataType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteBorrowerResidencyBasisType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteBorrowerResidencyBasisType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteBorrowerResidencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteBorrowerResidencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteBuildingStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteBuildingStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteCaseStateType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteCaseStateType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteCitizenshipResidencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteCitizenshipResidencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteConstructionPurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteConstructionPurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteContactPointRoleType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteContactPointRoleType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteContactPointType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteContactPointType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteContributorType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteContributorType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteCreditRepositorySourceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteCreditRepositorySourceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteCreditScoreExclusionReasonType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteCreditScoreExclusionReasonType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteCreditScoreModelNameType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteCreditScoreModelNameType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteDispositionStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteDispositionStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteDownPaymentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteDownPaymentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteExplanationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteExplanationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteFHAAlimonyLiabilityTreatmentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteFHAAlimonyLiabilityTreatmentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteFNMCommunityLendingProductType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteFNMCommunityLendingProductType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteFNMCreditReportScoreType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteFNMCreditReportScoreType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteFullPrepaymentPenaltyOptionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteFullPrepaymentPenaltyOptionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteGSEProjectClassificationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteGSEProjectClassificationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteGSEPropertyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteGSEPropertyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteGSERefinancePurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteGSERefinancePurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteGenderType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteGenderType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteGovernmentRefinanceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteGovernmentRefinanceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteHMDAEthnicityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteHMDAEthnicityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteHMDAPreapprovalType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteHMDAPreapprovalType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteHMDAPurposeOfLoanType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteHMDAPurposeOfLoanType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteHMDARaceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteHMDARaceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteHousingExpenseType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteHousingExpenseType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteIncomeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteIncomeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteInterestRateIndex]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteInterestRateIndex]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteJointAssetLiabilityReportingType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteJointAssetLiabilityReportingType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLandTrustType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLandTrustType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLegalType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLegalType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLiabilityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLiabilityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLienPriorityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLienPriorityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLoanAmortizationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLoanAmortizationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLoanClosingStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLoanClosingStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLoanDocumentationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLoanDocumentationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteLoanRepaymentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteLoanRepaymentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteMICertificationStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteMICertificationStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteMICompanyNameType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteMICompanyNameType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteMaritalStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteMaritalStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteMortgageHolderType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteMortgageHolderType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteMortgageScoreType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteMortgageScoreType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteMortgageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteMortgageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteNameDocumentsDrawnInType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteNameDocumentsDrawnInType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteNationalHousingActSectionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteNationalHousingActSectionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeletePaymentFrequencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeletePaymentFrequencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeletePrintPositionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeletePrintPositionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeletePriorPropertyTitleType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeletePriorPropertyTitleType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeletePriorPropertyUsageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeletePriorPropertyUsageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeletePropertyRightsType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeletePropertyRightsType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeletePropertyUsageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeletePropertyUsageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeletePropertyValuationMethodType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeletePropertyValuationMethodType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeletePurchaseCreditSourceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeletePurchaseCreditSourceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeletePurchaseCreditType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeletePurchaseCreditType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeletePurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeletePurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteRaceNationalOriginType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteRaceNationalOriginType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteRateLockType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteRateLockType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteRefinanceImprovementsType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteRefinanceImprovementsType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteServicingTransferStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteServicingTransferStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_DeleteSummaryAmountType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_DeleteSummaryAmountType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectApplicationMethod]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectApplicationMethod]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectApplicationMethods]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectApplicationMethods]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAppraiser]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAppraiser]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAppraisers]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAppraisers]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAssetType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAssetType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectAssetTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectAssetTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBaseDataType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBaseDataType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBaseDataTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBaseDataTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBorrowerResidencyBasisType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBorrowerResidencyBasisType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBorrowerResidencyBasisTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBorrowerResidencyBasisTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBorrowerResidencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBorrowerResidencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBorrowerResidencyTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBorrowerResidencyTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBuildingStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBuildingStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectBuildingStatusTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectBuildingStatusTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCaseStateType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCaseStateType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCaseStateTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCaseStateTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCitizenshipResidencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCitizenshipResidencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCitizenshipResidencyTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCitizenshipResidencyTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectConstructionPurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectConstructionPurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectConstructionPurposeTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectConstructionPurposeTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectContactPointRoleType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectContactPointRoleType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectContactPointRoleTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectContactPointRoleTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectContactPointType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectContactPointType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectContactPointTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectContactPointTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectContributorType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectContributorType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectContributorTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectContributorTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCreditRepositorySourceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCreditRepositorySourceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCreditRepositorySourceTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCreditRepositorySourceTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCreditScoreExclusionReasonType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCreditScoreExclusionReasonType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCreditScoreExclusionReasonTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCreditScoreExclusionReasonTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCreditScoreModelNameType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCreditScoreModelNameType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectCreditScoreModelNameTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectCreditScoreModelNameTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDispositionStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDispositionStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDispositionStatusTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDispositionStatusTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDownPaymentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDownPaymentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectDownPaymentTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectDownPaymentTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectExplanationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectExplanationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectExplanationTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectExplanationTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHAAlimonyLiabilityTreatmentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHAAlimonyLiabilityTreatmentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFHAAlimonyLiabilityTreatmentTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFHAAlimonyLiabilityTreatmentTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFNMCommunityLendingProductType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFNMCommunityLendingProductType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFNMCommunityLendingProductTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFNMCommunityLendingProductTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFNMCreditReportScoreType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFNMCreditReportScoreType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFNMCreditReportScoreTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFNMCreditReportScoreTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFullPrepaymentPenaltyOptionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFullPrepaymentPenaltyOptionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectFullPrepaymentPenaltyOptionTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectFullPrepaymentPenaltyOptionTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGSEProjectClassificationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGSEProjectClassificationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGSEProjectClassificationTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGSEProjectClassificationTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGSEPropertyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGSEPropertyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGSEPropertyTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGSEPropertyTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGSERefinancePurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGSERefinancePurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGSERefinancePurposeTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGSERefinancePurposeTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGenderType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGenderType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGenderTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGenderTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentRefinanceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentRefinanceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectGovernmentRefinanceTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectGovernmentRefinanceTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHMDAEthnicityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHMDAEthnicityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHMDAEthnicityTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHMDAEthnicityTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHMDAPreapprovalType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHMDAPreapprovalType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHMDAPreapprovalTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHMDAPreapprovalTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHMDAPurposeOfLoanType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHMDAPurposeOfLoanType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHMDAPurposeOfLoanTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHMDAPurposeOfLoanTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHMDARaceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHMDARaceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHMDARaceTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHMDARaceTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHousingExpenseType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHousingExpenseType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectHousingExpenseTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectHousingExpenseTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectIncomeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectIncomeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectIncomeTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectIncomeTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectInterestRateIndex]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectInterestRateIndex]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectInterestRateIndexs]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectInterestRateIndexs]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectJointAssetLiabilityReportingType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectJointAssetLiabilityReportingType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectJointAssetLiabilityReportingTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectJointAssetLiabilityReportingTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLandTrustType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLandTrustType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLandTrustTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLandTrustTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLegalType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLegalType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLegalTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLegalTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLiabilityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLiabilityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLiabilityTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLiabilityTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLienPriorityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLienPriorityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLienPriorityTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLienPriorityTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanAmortizationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanAmortizationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanAmortizationTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanAmortizationTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanApplications]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanApplications]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanClosingStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanClosingStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanClosingStatusTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanClosingStatusTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanDocumentationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanDocumentationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanDocumentationTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanDocumentationTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanRepaymentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanRepaymentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectLoanRepaymentTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectLoanRepaymentTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMICertificationStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMICertificationStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMICertificationStatusTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMICertificationStatusTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMICompanyNameType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMICompanyNameType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMICompanyNameTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMICompanyNameTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMaritalStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMaritalStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMaritalStatusTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMaritalStatusTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageHolderType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageHolderType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageHolderTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageHolderTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageScoreType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageScoreType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageScoreTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageScoreTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectMortgageTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectMortgageTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectNameDocumentsDrawnInType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectNameDocumentsDrawnInType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectNameDocumentsDrawnInTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectNameDocumentsDrawnInTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectNationalHousingActSectionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectNationalHousingActSectionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectNationalHousingActSectionTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectNationalHousingActSectionTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPaymentFrequencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPaymentFrequencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPaymentFrequencyTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPaymentFrequencyTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPrintPositionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPrintPositionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPrintPositionTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPrintPositionTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPriorPropertyTitleType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPriorPropertyTitleType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPriorPropertyTitleTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPriorPropertyTitleTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPriorPropertyUsageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPriorPropertyUsageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPriorPropertyUsageTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPriorPropertyUsageTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPropertyRightsType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPropertyRightsType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPropertyRightsTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPropertyRightsTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPropertyUsageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPropertyUsageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPropertyUsageTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPropertyUsageTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPropertyValuationMethodType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPropertyValuationMethodType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPropertyValuationMethodTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPropertyValuationMethodTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPurchaseCreditSourceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPurchaseCreditSourceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPurchaseCreditSourceTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPurchaseCreditSourceTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPurchaseCreditType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPurchaseCreditType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPurchaseCreditTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPurchaseCreditTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectPurposeTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectPurposeTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectRaceNationalOriginType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectRaceNationalOriginType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectRaceNationalOriginTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectRaceNationalOriginTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectRateLockType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectRateLockType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectRateLockTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectRateLockTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectRefinanceImprovementsType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectRefinanceImprovementsType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectRefinanceImprovementsTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectRefinanceImprovementsTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectServicingTransferStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectServicingTransferStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectServicingTransferStatusTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectServicingTransferStatusTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectSummaryAmountType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectSummaryAmountType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_SelectSummaryAmountTypes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_SelectSummaryAmountTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateApplicationMethod]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateApplicationMethod]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateAppraiser]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateAppraiser]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateAssetType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateAssetType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateBaseDataType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateBaseDataType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateBorrowerResidencyBasisType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateBorrowerResidencyBasisType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateBorrowerResidencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateBorrowerResidencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateBuildingStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateBuildingStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateCaseStateType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateCaseStateType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateCitizenshipResidencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateCitizenshipResidencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateConstructionPurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateConstructionPurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateContactPointRoleType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateContactPointRoleType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateContactPointType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateContactPointType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateContributorType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateContributorType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateCreditRepositorySourceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateCreditRepositorySourceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateCreditScoreExclusionReasonType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateCreditScoreExclusionReasonType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateCreditScoreModelNameType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateCreditScoreModelNameType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateDispositionStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateDispositionStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateDownPaymentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateDownPaymentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateExplanationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateExplanationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateFHAAlimonyLiabilityTreatmentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateFHAAlimonyLiabilityTreatmentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateFNMCommunityLendingProductType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateFNMCommunityLendingProductType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateFNMCreditReportScoreType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateFNMCreditReportScoreType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateFullPrepaymentPenaltyOptionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateFullPrepaymentPenaltyOptionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateGSEProjectClassificationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateGSEProjectClassificationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateGSEPropertyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateGSEPropertyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateGSERefinancePurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateGSERefinancePurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateGenderType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateGenderType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateGovernmentRefinanceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateGovernmentRefinanceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateHMDAEthnicityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateHMDAEthnicityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateHMDAPreapprovalType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateHMDAPreapprovalType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateHMDAPurposeOfLoanType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateHMDAPurposeOfLoanType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateHMDARaceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateHMDARaceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateHousingExpenseType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateHousingExpenseType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateIncomeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateIncomeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateInterestRateIndex]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateInterestRateIndex]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateJointAssetLiabilityReportingType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateJointAssetLiabilityReportingType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLandTrustType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLandTrustType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLegalType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLegalType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLiabilityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLiabilityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLienPriorityType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLienPriorityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLoanAmortizationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLoanAmortizationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLoanApplication]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLoanApplication]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLoanClosingStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLoanClosingStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLoanDocumentationType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLoanDocumentationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateLoanRepaymentType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateLoanRepaymentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateMICertificationStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateMICertificationStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateMICompanyNameType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateMICompanyNameType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateMaritalStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateMaritalStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateMortgageHolderType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateMortgageHolderType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateMortgageScoreType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateMortgageScoreType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateMortgageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateMortgageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateNameDocumentsDrawnInType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateNameDocumentsDrawnInType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateNationalHousingActSectionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateNationalHousingActSectionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdatePaymentFrequencyType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdatePaymentFrequencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdatePrintPositionType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdatePrintPositionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdatePriorPropertyTitleType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdatePriorPropertyTitleType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdatePriorPropertyUsageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdatePriorPropertyUsageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdatePropertyRightsType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdatePropertyRightsType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdatePropertyUsageType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdatePropertyUsageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdatePropertyValuationMethodType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdatePropertyValuationMethodType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdatePurchaseCreditSourceType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdatePurchaseCreditSourceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdatePurchaseCreditType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdatePurchaseCreditType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdatePurposeType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdatePurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateRaceNationalOriginType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateRaceNationalOriginType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateRateLockType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateRateLockType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateRefinanceImprovementsType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateRefinanceImprovementsType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateServicingTransferStatusType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateServicingTransferStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gsp_UpdateSummaryAmountType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[gsp_UpdateSummaryAmountType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[EXPLANATION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[EXPLANATION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HMDA_RACE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HMDA_RACE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[REO_PROPERTY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[REO_PROPERTY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ALIAS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ALIAS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ARM]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ARM]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ASSET]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ASSET]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BUYDOWN]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[BUYDOWN]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CONSTRUCTION_REFINANCE_DATA]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CONSTRUCTION_REFINANCE_DATA]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CONTACT_POINT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CONTACT_POINT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CREDIT_SCORE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CREDIT_SCORE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CURRENT_INCOME]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CURRENT_INCOME]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DATA_VERSION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DATA_VERSION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DECLARATION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DECLARATION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DEPENDENT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DEPENDENT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[EMPLOYER]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[EMPLOYER]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FHA_LOAN]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FHA_LOAN]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FHA_VA_BORROWER]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FHA_VA_BORROWER]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FHA_VA_LOAN]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FHA_VA_LOAN]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GOVERNMENT_MONITORING]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[GOVERNMENT_MONITORING]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LEGAL_DESCRIPTION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LEGAL_DESCRIPTION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LIABILITY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LIABILITY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOAN_FEATURES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LOAN_FEATURES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MAIL_TO]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MAIL_TO]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MORTGAGE_SCORE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MORTGAGE_SCORE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PARSED_STREET_ADDRESS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PARSED_STREET_ADDRESS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PAYMENT_ADJUSTMENT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PAYMENT_ADJUSTMENT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PRESENT_HOUSING_EXPENSE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PRESENT_HOUSING_EXPENSE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PURCHASE_CREDIT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PURCHASE_CREDIT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RATE_ADJUSTMENT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[RATE_ADJUSTMENT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RESIDENCE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[RESIDENCE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SUMMARY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[SUMMARY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TRANSMITTAL_DATA]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TRANSMITTAL_DATA]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VALUATION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[VALUATION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VA_BORROWER]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[VA_BORROWER]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VA_LOAN]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[VA_LOAN]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ADDITIONAL_CASE_DATA]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ADDITIONAL_CASE_DATA]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AFFORDABLE_LENDING]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[AFFORDABLE_LENDING]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BORROWER]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[BORROWER]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DATA_INFORMATION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DATA_INFORMATION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DOWN_PAYMENT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DOWN_PAYMENT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GOVERNMENT_LOAN]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[GOVERNMENT_LOAN]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GOVERNMENT_REPORTING]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[GOVERNMENT_REPORTING]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[INTERVIEWER_INFORMATION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[INTERVIEWER_INFORMATION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOAN_PRODUCT_DATA]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LOAN_PRODUCT_DATA]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOAN_PURPOSE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LOAN_PURPOSE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOAN_QUALIFICATION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LOAN_QUALIFICATION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MORTGAGE_TERMS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MORTGAGE_TERMS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROPERTY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PROPERTY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PROPOSED_HOUSING_EXPENSE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PROPOSED_HOUSING_EXPENSE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TITLE_HOLDER]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TITLE_HOLDER]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TRANSACTION_DETAIL]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TRANSACTION_DETAIL]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[APPRAISER]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[APPRAISER]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ApplicationMethod]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ApplicationMethod]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AssetType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[AssetType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BaseDataType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[BaseDataType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BorrowerResidencyBasisType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[BorrowerResidencyBasisType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BorrowerResidencyType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[BorrowerResidencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BuildingStatusType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[BuildingStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CaseStateType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CaseStateType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CitizenshipResidencyType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CitizenshipResidencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ConstructionPurposeType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ConstructionPurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ContactPointRoleType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ContactPointRoleType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ContactPointType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ContactPointType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ContributorType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ContributorType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CreditRepositorySourceType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CreditRepositorySourceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CreditScoreExclusionReasonType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CreditScoreExclusionReasonType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CreditScoreModelNameType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CreditScoreModelNameType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DispositionStatusType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DispositionStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DownPaymentType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DownPaymentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ExplanationType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ExplanationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FHAAlimonyLiabilityTreatmentType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FHAAlimonyLiabilityTreatmentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FNMCommunityLendingProductType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FNMCommunityLendingProductType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FNMCreditReportScoreType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FNMCreditReportScoreType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FullPrepaymentPenaltyOptionType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FullPrepaymentPenaltyOptionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GSEProjectClassificationType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[GSEProjectClassificationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GSEPropertyType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[GSEPropertyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GSERefinancePurposeType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[GSERefinancePurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GenderType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[GenderType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GovernmentRefinanceType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[GovernmentRefinanceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HMDAEthnicityType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HMDAEthnicityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HMDAPreapprovalType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HMDAPreapprovalType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HMDAPurposeOfLoanType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HMDAPurposeOfLoanType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HMDARaceType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HMDARaceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HousingExpenseType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HousingExpenseType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[IncomeType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[IncomeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InterestRateIndex]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[InterestRateIndex]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[JointAssetLiabilityReportingType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[JointAssetLiabilityReportingType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOAN_APPLICATION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LOAN_APPLICATION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LandTrustType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LandTrustType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LegalType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LegalType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LiabilityType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LiabilityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LienPriorityType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LienPriorityType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LoanAmortizationType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LoanAmortizationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LoanClosingStatusType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LoanClosingStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LoanDocumentationType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LoanDocumentationType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LoanRepaymentType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LoanRepaymentType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MICertificationStatusType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MICertificationStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MICompanyNameType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MICompanyNameType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MaritalStatusType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MaritalStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MortgageHolderType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MortgageHolderType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MortgageScoreType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MortgageScoreType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MortgageType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MortgageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NameDocumentsDrawnInType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[NameDocumentsDrawnInType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NationalHousingActSectionType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[NationalHousingActSectionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PaymentFrequencyType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PaymentFrequencyType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PrintPositionType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PrintPositionType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PriorPropertyTitleType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PriorPropertyTitleType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PriorPropertyUsageType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PriorPropertyUsageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PropertyRightsType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PropertyRightsType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PropertyUsageType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PropertyUsageType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PropertyValuationMethodType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PropertyValuationMethodType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PurchaseCreditSourceType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PurchaseCreditSourceType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PurchaseCreditType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PurchaseCreditType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PurposeType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PurposeType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RaceNationalOriginType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[RaceNationalOriginType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RateLockType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[RateLockType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RefinanceImprovementsType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[RefinanceImprovementsType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ServicingTransferStatusType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ServicingTransferStatusType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SummaryAmountType]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[SummaryAmountType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DEF_FALSE]') and OBJECTPROPERTY(id, N'IsDefault') = 1)
drop default [dbo].[DEF_FALSE]
GO



CREATE DEFAULT DEF_FALSE
 	AS 0


GO
CREATE TABLE [dbo].[APPRAISER] (
	[Id] [int] IDENTITY (1, 1) NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CompanyName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LicenseIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LicenseState] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ApplicationMethod] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[AssetType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[BaseDataType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[BorrowerResidencyBasisType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[BorrowerResidencyType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[BuildingStatusType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CaseStateType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CitizenshipResidencyType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ConstructionPurposeType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ContactPointRoleType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ContactPointType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ContributorType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CreditRepositorySourceType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CreditScoreExclusionReasonType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CreditScoreModelNameType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DispositionStatusType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DownPaymentType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ExplanationType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FHAAlimonyLiabilityTreatmentType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FNMCommunityLendingProductType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FNMCreditReportScoreType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FullPrepaymentPenaltyOptionType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GSEProjectClassificationType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GSEPropertyType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GSERefinancePurposeType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GenderType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GovernmentRefinanceType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HMDAEthnicityType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[HMDAPreapprovalType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HMDAPurposeOfLoanType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HMDARaceType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[HousingExpenseType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[IncomeType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[InterestRateIndex] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[JointAssetLiabilityReportingType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LOAN_APPLICATION] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[MISMOVersionID] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LandTrustType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LegalType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[LiabilityType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[LienPriorityType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LoanAmortizationType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LoanClosingStatusType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LoanDocumentationType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (80) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (80) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LoanRepaymentType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MICertificationStatusType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MICompanyNameType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MaritalStatusType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MortgageHolderType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MortgageScoreType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MortgageType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[NameDocumentsDrawnInType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[NationalHousingActSectionType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[PaymentFrequencyType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PrintPositionType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PriorPropertyTitleType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PriorPropertyUsageType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PropertyRightsType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PropertyUsageType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PropertyValuationMethodType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PurchaseCreditSourceType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PurchaseCreditType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PurposeType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[RaceNationalOriginType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[RateLockType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[RefinanceImprovementsType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ServicingTransferStatusType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[SummaryAmountType] (
	[Id] [smallint] NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EnumeratedName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Description] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ADDITIONAL_CASE_DATA] (
	[LoanApplicationId] [bigint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[AFFORDABLE_LENDING] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[FNMCommunityLendingProductName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FNMCommunityLendingProductTypeOtherDescription] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FNMCommunitySecondsIndicator] [bit] NOT NULL ,
	[FNMNeighborsMortgageEligibilityIndicator] [bit] NOT NULL ,
	[FREAffordableProgramIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HUDIncomeLimitAdjustmentFactor] [numeric](18, 0) NULL ,
	[HUDLendingIncomeLimitAmount] [money] NULL ,
	[HUDMedianIncomeAmount] [money] NULL ,
	[MSAIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FNMCommunityLendingProductType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[BORROWER] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[JointAssetBorrowerID] [bigint] NULL ,
	[LoanApplicationId] [bigint] NULL ,
	[FirstName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MiddleName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LastName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[NameSuffix] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[AgeAtApplicationYears] [numeric](18, 0) NULL ,
	[BirthDate] [datetime] NULL ,
	[ApplicationSignedDate] [datetime] NULL ,
	[HomeTelephoneNumber] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[SSN] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DependentCount] [tinyint] NULL ,
	[SchoolingYears] [numeric](18, 0) NULL ,
	[CreditReportIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MaritalStatusType] [smallint] NULL ,
	[PrintPositionType] [smallint] NULL ,
	[JointAssetLiabilityReportingType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DATA_INFORMATION] (
	[LoanApplicationId] [bigint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DOWN_PAYMENT] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[LoanApplicationId] [bigint] NOT NULL ,
	[Amount] [money] NOT NULL ,
	[SourceDescription] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Type] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GOVERNMENT_LOAN] (
	[LoanApplicationId] [bigint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GOVERNMENT_REPORTING] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[HMDAPurposeOfLoanType] [smallint] NULL ,
	[HMDAPreapprovalType] [smallint] NULL ,
	[HMDA_HOEPALoanStatusIndicator] [bit] NOT NULL ,
	[HMDARateSpreadPercent] [numeric](8, 7) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[INTERVIEWER_INFORMATION] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[InterviewersEmployerStreetAddress] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[InterviewersEmployerCity] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[InterviewersEmployerState] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[InterviewersEmployerPostalCode] [varchar] (16) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[InterviewersTelephoneNumber] [varchar] (32) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ApplicationTakenMethodType] [smallint] NULL ,
	[InterviewerApplicationSignedDate] [datetime] NULL ,
	[InterviewersEmployerName] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[InterviewersName] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LOAN_PRODUCT_DATA] (
	[LoanApplicationId] [bigint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LOAN_PURPOSE] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[GSETitleMannerHeldDescription] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[OtherLoanPurposeDescription] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PropertyLeaseholdExpirationDate] [datetime] NULL ,
	[PropertyUsageType] [smallint] NULL ,
	[PropertyRightsType] [smallint] NULL ,
	[Type] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LOAN_QUALIFICATION] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[AdditionalBorrowerAssetsNotConsideredIndicator] [bit] NOT NULL ,
	[AdditionalBorrowerAssetsConsideredIndicator] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MORTGAGE_TERMS] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[AgencyCaseIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ARMTypeDescription] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BaseLoanAmount] [money] NULL ,
	[BorrowerRequestedLoanAmount] [money] NULL ,
	[LenderCaseIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LoanAmortizationTermMonths] [numeric](18, 0) NULL ,
	[OtherMortgageTypeDescription] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[OtherAmortizationTypeDescription] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[RequestedInterestRatePercent] [numeric](8, 7) NULL ,
	[LoanAmortizationType] [smallint] NULL ,
	[MortgageType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PROPERTY] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[StreetAddress] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[StreetAddress2] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[City] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[State] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[County] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PostalCode] [varchar] (16) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FinancedNumberOfUnits] [int] NULL ,
	[StructureBuiltYear] [datetime] NULL ,
	[AcquiredDate] [datetime] NULL ,
	[PlannedUnitDevelopmentIndicator] [bit] NOT NULL ,
	[AcreageNumber] [numeric](18, 0) NULL ,
	[BuildingStatusType] [smallint] NULL ,
	[GSEPropertyType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PROPOSED_HOUSING_EXPENSE] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[LoanApplicationId] [bigint] NOT NULL ,
	[PaymentAmount] [money] NOT NULL ,
	[HousingExpenseType] [smallint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TITLE_HOLDER] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[Name] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LandTrustType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TRANSACTION_DETAIL] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[AlterationsImprovementsAndRepairsAmount] [money] NULL ,
	[BorrowerPaidDiscountPointsTotalAmount] [money] NULL ,
	[EstimatedClosingCostsAmount] [money] NULL ,
	[MIAndFundingFeeFinancedAmount] [money] NULL ,
	[MIAndFundingFeeTotalAmount] [money] NULL ,
	[PrepaidItemsEstimatedAmount] [money] NULL ,
	[PurchasePriceAmount] [money] NULL ,
	[RefinanceIncludingDebtsToBePaidOffAmount] [money] NULL ,
	[SalesConcessionAmount] [money] NULL ,
	[SellerPaidClosingCostsAmount] [money] NULL ,
	[SubordinateLienAmount] [money] NULL ,
	[SubordinateLienHELOCAmount] [money] NULL ,
	[FREReserveAmount] [money] NULL ,
	[FREReservesAmount] [money] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ALIAS] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[BorrowerId] [bigint] NULL ,
	[FirstName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LastName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MiddleName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ARM] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[IndexCurrentValuePercent] [numeric](8, 7) NULL ,
	[IndexMarginPercent] [numeric](8, 7) NULL ,
	[IndexType] [smallint] NULL ,
	[QualifyingRatePercent] [numeric](8, 7) NULL ,
	[ConversionOptionIndicator] [bit] NOT NULL ,
	[PaymentAdjustmentLifetimeCapAmount] [money] NULL ,
	[PaymentAdjustmentLifetimeCapPercent] [numeric](8, 7) NULL ,
	[RateAdjustmentLifetimeCapPercent] [numeric](8, 7) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ASSET] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[BorrowerId] [bigint] NOT NULL ,
	[LoanApplicationId] [bigint] NOT NULL ,
	[AccountIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CashOrMarketValueAmount] [money] NULL ,
	[Type] [smallint] NOT NULL ,
	[VerifiedIndicator] [bit] NOT NULL ,
	[HolderName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HolderStreetAddress] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HolderCity] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HolderState] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HolderPostalCode] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[AutomobileMakeDescription] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[AutomobileModelYear] [datetime] NULL ,
	[LifeInsuranceFaceValueAmount] [money] NULL ,
	[OtherAssetTypeDescription] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[StockBondMutualFundShareCount] [numeric](18, 0) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[BUYDOWN] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[LoanApplicationId] [bigint] NOT NULL ,
	[ChangeFrequencyMonths] [numeric](18, 0) NULL ,
	[DurationMonths] [numeric](18, 0) NULL ,
	[IncreaseRatePercent] [numeric](8, 7) NULL ,
	[LenderFundingIndicator] [bit] NOT NULL ,
	[PermanentIndicator] [bit] NOT NULL ,
	[BaseDataType] [smallint] NULL ,
	[ContributorType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CONSTRUCTION_REFINANCE_DATA] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[ConstructionImprovementCostsAmount] [money] NULL ,
	[FRECashOutAmount] [money] NULL ,
	[LandEstimatedValueAmount] [money] NULL ,
	[LandOriginalCostAmount] [money] NULL ,
	[PropertyAcquiredYear] [datetime] NULL ,
	[PropertyExistingLienAmount] [money] NULL ,
	[PropertyOriginalCostAmount] [money] NULL ,
	[RefinanceImprovementCostsAmount] [money] NULL ,
	[RefinanceProposedImprovementsDescription] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[SecondaryFinancingRefinanceIndicator] [bit] NOT NULL ,
	[FNMSecondMortgageFinancingOriginalPropertyIndicator] [bit] NOT NULL ,
	[StructuralAlterationsConventionalAmount] [money] NULL ,
	[NonStructuralAlterationsConventionalAmount] [money] NULL ,
	[ConstructionPurposeType] [smallint] NULL ,
	[RefinanceImprovementsType] [smallint] NULL ,
	[GSERefinancePurposeType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CONTACT_POINT] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[BorrowerId] [bigint] NULL ,
	[TypeOtherDescription] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Value] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PreferenceIndicator] [bit] NOT NULL ,
	[RoleType] [smallint] NULL ,
	[Type] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CREDIT_SCORE] (
	[CreditScoreID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[CreditReportIdentifier] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CreditScoreDate] [datetime] NULL ,
	[CreditScoreModelNameTypeOtherDescription] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CreditScoreValue] [smallint] NULL ,
	[BorrowerId] [bigint] NOT NULL ,
	[CreditRepositorySourceType] [smallint] NULL ,
	[CreditScoreExclusionType] [smallint] NULL ,
	[CreditScoreModelNameType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CURRENT_INCOME] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[BorrowerId] [bigint] NOT NULL ,
	[IncomeType] [smallint] NOT NULL ,
	[MonthlyTotalAmount] [money] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DATA_VERSION] (
	[Id] [int] IDENTITY (1, 1) NOT NULL ,
	[Name] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Number] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[LoanApplicationId] [bigint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DECLARATION] (
	[BorrowerId] [bigint] NOT NULL ,
	[AlimonyChildSupportObligationIndicator] [bit] NOT NULL ,
	[BankruptcyIndicator] [bit] NOT NULL ,
	[BorrowedDownPaymentIndicator] [bit] NOT NULL ,
	[CoMakerEndorserOfNoteIndicator] [bit] NOT NULL ,
	[HomeownerPastThreeYearsType] [bit] NULL ,
	[IntentToOccupyType] [bit] NULL ,
	[LoanForeclosureOrJudgementIndicator] [bit] NOT NULL ,
	[OutstandingJudgementsIndicator] [bit] NOT NULL ,
	[PartyToLawsuitIndicator] [bit] NOT NULL ,
	[PresentlyDelinquentIndicator] [bit] NOT NULL ,
	[PropertyForeclosedPastSevenYearsIndicator] [bit] NOT NULL ,
	[CitizenshipResidencyType] [smallint] NULL ,
	[PriorPropertyTitleType] [smallint] NULL ,
	[PriorPropertyUsageType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DEPENDENT] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[BorrowerId] [bigint] NOT NULL ,
	[AgeYears] [numeric](18, 0) NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[EMPLOYER] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[BorrowerId] [bigint] NOT NULL ,
	[Name] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[StreetAddress] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[City] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[State] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PostalCode] [varchar] (16) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TelephoneNumber] [varchar] (32) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CurrentEmploymentMonthsOnJob] [numeric](18, 0) NULL ,
	[CurrentEmploymentTimeInLineOfWorkYears] [numeric](18, 0) NULL ,
	[CurrentEmploymentYearsOnJob] [numeric](18, 0) NULL ,
	[EmploymentBorrowerSelfEmployedIndicator] [bit] NOT NULL ,
	[EmploymentCurrentIndicator] [bit] NOT NULL ,
	[EmploymentPositionDescription] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[EmploymentPrimaryIndicator] [bit] NOT NULL ,
	[IncomeEmploymentMonthlyAmount] [money] NULL ,
	[PreviousEmploymentEndDate] [datetime] NULL ,
	[PreviousEmploymentStartDate] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FHA_LOAN] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[BorrowerFinancedFHADiscountPointsAmount] [money] NULL ,
	[FHACoverageRenewalRatePercent] [numeric](8, 7) NULL ,
	[FHA_MIPremiumRefundAmount] [money] NULL ,
	[FHAUpfrontMIPremiumPercent] [numeric](8, 7) NULL ,
	[LenderIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[SponsorIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[SectionOfActType] [smallint] NULL ,
	[FHAAlimonyLiabilityTreatmentType2] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FHA_VA_BORROWER] (
	[BorrowerId] [bigint] NOT NULL ,
	[CAIVRSIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FNMBankruptcyCount] [tinyint] NULL ,
	[FNMBorrowerCreditRating] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FNMCreditReportScoreType] [smallint] NULL ,
	[FNMForeclosureCount] [tinyint] NULL ,
	[VeteranStatusIndicator] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FHA_VA_LOAN] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[BorrowerPaidFHA_VAClosingCostsAmount] [money] NULL ,
	[BorrowerPaidFHA_VAClosingCostsPercent] [numeric](8, 7) NULL ,
	[GovernmentMortgageCreditCertificateAmount] [money] NULL ,
	[GovernmentRefinanceType] [smallint] NULL ,
	[OtherPartyPaidFHA_VAClosingCostsAmount] [money] NULL ,
	[OtherPartyPaidFHA_VAClosingCostsPercent] [numeric](8, 7) NULL ,
	[PropertyEnergyEfficientHomeIndicator] [bit] NULL ,
	[SellerPaidFHA_VAClosingCostsPercent] [numeric](8, 7) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GOVERNMENT_MONITORING] (
	[BorrowerId] [bigint] NOT NULL ,
	[GenderType] [smallint] NULL ,
	[OtherRaceNationalOriginDescription] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[RaceNationalOriginRefusalIndicator] [bit] NOT NULL ,
	[RaceNationalOriginType] [smallint] NULL ,
	[HMDAEthnicityType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LEGAL_DESCRIPTION] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[LoanApplicationId] [bigint] NOT NULL ,
	[TextDescription] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Type] [smallint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LIABILITY] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[LoanApplicationId] [bigint] NOT NULL ,
	[BorrowerId] [bigint] NOT NULL ,
	[REO_ID] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HolderStreetAddress] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HolderCity] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HolderState] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HolderPostalCode] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[AlimonyOwedToName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[AccountIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ExclusionIndicator] [bit] NOT NULL ,
	[HolderName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MonthlyPaymentAmount] [money] NULL ,
	[PayoffStatusIndicator] [bit] NOT NULL ,
	[PayoffWithCurrentAssetsIndicator] [bit] NOT NULL ,
	[RemainingTermMonths] [numeric](18, 0) NULL ,
	[Type] [smallint] NOT NULL ,
	[UnpaidBalanceAmount] [money] NULL ,
	[SubjectLoanResubordinationIndicator] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LOAN_FEATURES] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[AssumabilityIndicator] [bit] NOT NULL ,
	[BalloonIndicator] [bit] NOT NULL ,
	[BalloonLoanMaturityTermMonths] [numeric](18, 0) NULL ,
	[BuydownTemporarySubsidyIndicator] [bit] NOT NULL ,
	[CounselingConfirmationIndicator] [bit] NOT NULL ,
	[EscrowWaiverIndicator] [bit] NOT NULL ,
	[FREOfferingIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FNMProductPlanIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FNMProductPlanIndentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HELOCMaximumBalanceAmount] [money] NULL ,
	[HELOCInitialAdvanceAmount] [money] NULL ,
	[InterestOnlyTerm] [numeric](18, 0) NULL ,
	[LenderSelfInsuredIndicator] [bit] NOT NULL ,
	[LoanScheduledClosingDate] [datetime] NULL ,
	[MICoveragePercent] [numeric](8, 7) NULL ,
	[NegativeAmortizationLimitPercent] [numeric](8, 7) NULL ,
	[PrepaymentPenaltyIndicator] [bit] NOT NULL ,
	[PrepaymentPenaltyTermMonths] [numeric](18, 0) NULL ,
	[PrepaymentRestrictionIndicator] [bit] NOT NULL ,
	[ProductDescription] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ProductName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ScheduledFirstPaymentDate] [datetime] NULL ,
	[NameDocumentsDrawnInType] [smallint] NULL ,
	[GSEProjectClassificationType] [smallint] NULL ,
	[GSEPropertyType] [smallint] NULL ,
	[LienPriorityType] [smallint] NULL ,
	[LoanDocumentationType] [smallint] NULL ,
	[LoanRepaymentType] [smallint] NULL ,
	[MICertificationStatusType] [smallint] NULL ,
	[MICompanyNameType] [smallint] NULL ,
	[PaymentFrequencyType] [smallint] NULL ,
	[FullPrepaymentPenaltyOptionType] [smallint] NULL ,
	[LoanClosingStatusType] [smallint] NULL ,
	[ServicingTransferStatusType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MAIL_TO] (
	[BorrowerId] [bigint] NOT NULL ,
	[StreetAddress] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[StreetAddress2] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[City] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[State] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PostalCode] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Country] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MORTGAGE_SCORE] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[LoanApplicationId] [bigint] NOT NULL ,
	[Date] [datetime] NULL ,
	[TypeOtherDescription] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Value] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Type] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PARSED_STREET_ADDRESS] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[ApartmentOrUnit] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DirectionPrefix] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DirectionSuffix] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BuildingNumber] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[HouseNumber] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Military_APO_FPO] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PostOfficeBox] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[RuralRoute] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[StreetName] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[StreetSuffix] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PAYMENT_ADJUSTMENT] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[LoanApplicationId] [bigint] NOT NULL ,
	[FirstPaymentAdjustmentMonths] [numeric](18, 0) NULL ,
	[Amount] [money] NULL ,
	[CalculationType] [smallint] NOT NULL ,
	[DurationMonths] [numeric](18, 0) NULL ,
	[Percent] [numeric](8, 7) NULL ,
	[PeriodicCapAmount] [money] NULL ,
	[PeriodicCapPercent] [numeric](8, 7) NULL ,
	[PeriodNumber] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[SubsequentPaymentAdjustmentMonths] [numeric](18, 0) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PRESENT_HOUSING_EXPENSE] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[BorrowerId] [bigint] NOT NULL ,
	[PaymentAmount] [money] NOT NULL ,
	[HousingExpenseType] [smallint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PURCHASE_CREDIT] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[Amount] [money] NULL ,
	[SourceType] [smallint] NULL ,
	[LoanApplicationId] [bigint] NOT NULL ,
	[Type] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[RATE_ADJUSTMENT] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[LoanApplicationId] [bigint] NOT NULL ,
	[FirstRateAdjustmentMonths] [numeric](18, 0) NULL ,
	[CalculationType] [smallint] NOT NULL ,
	[DurationMonths] [numeric](18, 0) NULL ,
	[Percent] [numeric](8, 7) NULL ,
	[PeriodNumber] [numeric](18, 0) NULL ,
	[SubsequentCapPercent] [numeric](8, 7) NULL ,
	[SubsequentRateAdjustmentMonths] [numeric](18, 0) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[RESIDENCE] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[BorrowerId] [bigint] NULL ,
	[StreetAddress] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[City] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[State] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PostalCode] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Country] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BorrowerResidencyDurationMonths] [numeric](18, 0) NULL ,
	[BorrowerResidencyDurationYears] [numeric](18, 0) NULL ,
	[BorrowerResidencyBasisType] [smallint] NULL ,
	[BorrowerResidencyType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[SUMMARY] (
	[Id] [bigint] NOT NULL ,
	[BorrowerId] [bigint] NULL ,
	[Amount] [money] NULL ,
	[AmountType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TRANSMITTAL_DATA] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[ArmsLengthIndicator] [bit] NOT NULL ,
	[BelowMarketSubordinateFinancingIndicator] [bit] NOT NULL ,
	[BuydownRatePercent] [numeric](8, 7) NULL ,
	[CreditReportAuthorizationIndicator] [bit] NOT NULL ,
	[LenderBranchIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[LenderRegistrationIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PropertyAppraisedValueAmount] [money] NULL ,
	[PropertyEstimatedValueAmount] [money] NULL ,
	[InvestorLoanIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[InvestorInstitutionIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CommitmentReferenceIdentifier] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ConcurrentOriginationIndicator] [bit] NOT NULL ,
	[ConcurrentOriginationLenderIndicator] [bit] NOT NULL ,
	[RateLockPeriodDays] [smallint] NULL ,
	[RateLockRequestedExtensionDays] [smallint] NULL ,
	[CaseStateType] [smallint] NULL ,
	[RateLockType] [smallint] NULL ,
	[CurrentFirstMortgageHolderType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[VALUATION] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[LoanApplicationId] [bigint] NOT NULL ,
	[AppraiserId] [int] NULL ,
	[MethodTypeOtherDescription] [varchar] (254) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[MethodType] [smallint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[VA_BORROWER] (
	[BorrowerId] [bigint] NOT NULL ,
	[VACoBorrowerNonTaxableIncomeAmount] [money] NULL ,
	[VACoBorrowerTaxableIncomeAmount] [money] NULL ,
	[VAFederalTaxAmount] [money] NULL ,
	[VALocalTaxAmount] [money] NULL ,
	[VAPrimaryBorrowerNonTaxableIncomeAmount] [money] NULL ,
	[VAPrimaryBorrowerTaxableIncomeAmount] [money] NULL ,
	[VASocialSecurityTaxAmount] [money] NULL ,
	[VAStateTaxAmount] [money] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[VA_LOAN] (
	[LoanApplicationId] [bigint] NOT NULL ,
	[VABorrowerCoBorrowerMarriedIndicator] [bit] NOT NULL ,
	[BorrowerFundingFeePercent] [numeric](8, 7) NULL ,
	[VAEntitlementAmount] [money] NULL ,
	[VAMaintenanceExpenseMonthlyAmount] [money] NULL ,
	[VAResidualIncomeAmount] [money] NULL ,
	[VAUtilityExpenseMonthlyAmount] [money] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[EXPLANATION] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[BorrowerId] [bigint] NOT NULL ,
	[Type] [smallint] NOT NULL ,
	[Description] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HMDA_RACE] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[BorrowerId] [bigint] NOT NULL ,
	[Type] [smallint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[REO_PROPERTY] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[LoanApplicationId] [bigint] NULL ,
	[StreetAddress] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[StreetAddress2] [varchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[City] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[State] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PostalCode] [varchar] (64) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CurrentResidenceIndicator] [bit] NOT NULL ,
	[LienInstallmentAmount] [money] NULL ,
	[LienUPBAmount] [money] NULL ,
	[MaintenanceExpenseAmount] [money] NULL ,
	[MarketValueAmount] [money] NULL ,
	[RentalIncomeGrossAmount] [money] NULL ,
	[RentalIncomeNetAmount] [money] NULL ,
	[SubjectIndicator] [bit] NOT NULL ,
	[BorrowerID] [bigint] NULL ,
	[LiabilityID] [bigint] NULL ,
	[GSEPropertyType] [smallint] NULL ,
	[DispositionStatusType] [smallint] NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[APPRAISER] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ApplicationMethod] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[AssetType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[BaseDataType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[BorrowerResidencyBasisType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[BorrowerResidencyType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[BuildingStatusType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CaseStateType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CitizenshipResidencyType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ConstructionPurposeType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ContactPointRoleType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ContactPointType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ContributorType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CreditRepositorySourceType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CreditScoreExclusionReasonType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CreditScoreModelNameType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[DispositionStatusType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[DownPaymentType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ExplanationType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FHAAlimonyLiabilityTreatmentType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FNMCommunityLendingProductType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FNMCreditReportScoreType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FullPrepaymentPenaltyOptionType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[GSEProjectClassificationType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[GSEPropertyType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[GSERefinancePurposeType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[GenderType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[GovernmentRefinanceType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HMDAEthnicityType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HMDAPreapprovalType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HMDAPurposeOfLoanType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HMDARaceType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HousingExpenseType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[IncomeType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[InterestRateIndex] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[JointAssetLiabilityReportingType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LOAN_APPLICATION] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LandTrustType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LegalType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LiabilityType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LienPriorityType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LoanAmortizationType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LoanClosingStatusType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LoanDocumentationType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LoanRepaymentType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MICertificationStatusType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MICompanyNameType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MaritalStatusType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MortgageHolderType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MortgageScoreType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MortgageType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[NameDocumentsDrawnInType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[NationalHousingActSectionType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PaymentFrequencyType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PrintPositionType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PriorPropertyTitleType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PriorPropertyUsageType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PropertyRightsType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PropertyUsageType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PropertyValuationMethodType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PurchaseCreditSourceType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PurchaseCreditType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PurposeType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[RaceNationalOriginType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[RateLockType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[RefinanceImprovementsType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ServicingTransferStatusType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[SummaryAmountType] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ADDITIONAL_CASE_DATA] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[AFFORDABLE_LENDING] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[DATA_INFORMATION] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[GOVERNMENT_LOAN] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[GOVERNMENT_REPORTING] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[INTERVIEWER_INFORMATION] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LOAN_PRODUCT_DATA] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LOAN_PURPOSE] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LOAN_QUALIFICATION] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MORTGAGE_TERMS] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PROPERTY] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[TITLE_HOLDER] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[TRANSACTION_DETAIL] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ARM] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[BUYDOWN] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CONSTRUCTION_REFINANCE_DATA] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CREDIT_SCORE] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[CreditScoreID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[DATA_VERSION] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[DECLARATION] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[BorrowerId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FHA_LOAN] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FHA_VA_BORROWER] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[BorrowerId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FHA_VA_LOAN] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[GOVERNMENT_MONITORING] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[BorrowerId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LEGAL_DESCRIPTION] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LOAN_FEATURES] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MAIL_TO] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[BorrowerId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PARSED_STREET_ADDRESS] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PAYMENT_ADJUSTMENT] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PURCHASE_CREDIT] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[RATE_ADJUSTMENT] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[TRANSMITTAL_DATA] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[VALUATION] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[VA_BORROWER] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[BorrowerId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[VA_LOAN] WITH NOCHECK ADD 
	 PRIMARY KEY  CLUSTERED 
	(
		[LoanApplicationId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[BORROWER] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[DOWN_PAYMENT] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PROPOSED_HOUSING_EXPENSE] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ALIAS] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ASSET] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CONTACT_POINT] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CURRENT_INCOME] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[DEPENDENT] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[EMPLOYER] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[LIABILITY] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MORTGAGE_SCORE] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PRESENT_HOUSING_EXPENSE] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[RESIDENCE] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[SUMMARY] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[EXPLANATION] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HMDA_RACE] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[REO_PROPERTY] ADD 
	 PRIMARY KEY  NONCLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[AFFORDABLE_LENDING].[FNMCommunitySecondsIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[AFFORDABLE_LENDING].[FNMNeighborsMortgageEligibilityIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[GOVERNMENT_REPORTING].[HMDA_HOEPALoanStatusIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[LOAN_QUALIFICATION].[AdditionalBorrowerAssetsNotConsideredIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[LOAN_QUALIFICATION].[LoanApplicationId]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[PROPERTY].[PlannedUnitDevelopmentIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[ARM].[ConversionOptionIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[ASSET].[VerifiedIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[BUYDOWN].[LenderFundingIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[BUYDOWN].[PermanentIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[CONSTRUCTION_REFINANCE_DATA].[FNMSecondMortgageFinancingOriginalPropertyIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[CONSTRUCTION_REFINANCE_DATA].[SecondaryFinancingRefinanceIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[CONTACT_POINT].[PreferenceIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[DECLARATION].[AlimonyChildSupportObligationIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[DECLARATION].[BankruptcyIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[DECLARATION].[BorrowedDownPaymentIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[DECLARATION].[LoanForeclosureOrJudgementIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[DECLARATION].[OutstandingJudgementsIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[DECLARATION].[PartyToLawsuitIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[DECLARATION].[PresentlyDelinquentIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[DECLARATION].[PropertyForeclosedPastSevenYearsIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[EMPLOYER].[EmploymentBorrowerSelfEmployedIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[EMPLOYER].[EmploymentPrimaryIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[FHA_VA_BORROWER].[VeteranStatusIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[GOVERNMENT_MONITORING].[RaceNationalOriginRefusalIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[LIABILITY].[ExclusionIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[LIABILITY].[SubjectLoanResubordinationIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[LOAN_FEATURES].[AssumabilityIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[LOAN_FEATURES].[BalloonIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[LOAN_FEATURES].[CounselingConfirmationIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[LOAN_FEATURES].[EscrowWaiverIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[LOAN_FEATURES].[LenderSelfInsuredIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[LOAN_FEATURES].[PrepaymentPenaltyIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[LOAN_FEATURES].[PrepaymentRestrictionIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[SUMMARY].[Id]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[TRANSMITTAL_DATA].[ArmsLengthIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[TRANSMITTAL_DATA].[BelowMarketSubordinateFinancingIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[TRANSMITTAL_DATA].[ConcurrentOriginationIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[TRANSMITTAL_DATA].[ConcurrentOriginationLenderIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[TRANSMITTAL_DATA].[CreditReportAuthorizationIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[VA_LOAN].[VABorrowerCoBorrowerMarriedIndicator]'
GO

setuser
GO

setuser
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[REO_PROPERTY].[CurrentResidenceIndicator]'
GO

EXEC sp_bindefault N'[dbo].[DEF_FALSE]', N'[REO_PROPERTY].[SubjectIndicator]'
GO

setuser
GO

ALTER TABLE [dbo].[ADDITIONAL_CASE_DATA] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[AFFORDABLE_LENDING] ADD 
	 FOREIGN KEY 
	(
		[FNMCommunityLendingProductType]
	) REFERENCES [dbo].[FNMCommunityLendingProductType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[BORROWER] ADD 
	 FOREIGN KEY 
	(
		[JointAssetBorrowerID]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[JointAssetLiabilityReportingType]
	) REFERENCES [dbo].[JointAssetLiabilityReportingType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[MaritalStatusType]
	) REFERENCES [dbo].[MaritalStatusType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[PrintPositionType]
	) REFERENCES [dbo].[PrintPositionType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[DATA_INFORMATION] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[DOWN_PAYMENT] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[Type]
	) REFERENCES [dbo].[DownPaymentType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[GOVERNMENT_LOAN] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[GOVERNMENT_REPORTING] ADD 
	 FOREIGN KEY 
	(
		[HMDAPreapprovalType]
	) REFERENCES [dbo].[HMDAPreapprovalType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[HMDAPurposeOfLoanType]
	) REFERENCES [dbo].[HMDAPurposeOfLoanType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[INTERVIEWER_INFORMATION] ADD 
	 FOREIGN KEY 
	(
		[ApplicationTakenMethodType]
	) REFERENCES [dbo].[ApplicationMethod] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[LOAN_PRODUCT_DATA] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[LOAN_PURPOSE] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[PropertyUsageType]
	) REFERENCES [dbo].[PropertyUsageType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[PropertyRightsType]
	) REFERENCES [dbo].[PropertyRightsType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[Type]
	) REFERENCES [dbo].[PurposeType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[LOAN_QUALIFICATION] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[MORTGAGE_TERMS] ADD 
	 FOREIGN KEY 
	(
		[LoanAmortizationType]
	) REFERENCES [dbo].[LoanAmortizationType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[MortgageType]
	) REFERENCES [dbo].[MortgageType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[PROPERTY] ADD 
	 FOREIGN KEY 
	(
		[BuildingStatusType]
	) REFERENCES [dbo].[BuildingStatusType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[GSEPropertyType]
	) REFERENCES [dbo].[GSEPropertyType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[PROPOSED_HOUSING_EXPENSE] ADD 
	 FOREIGN KEY 
	(
		[HousingExpenseType]
	) REFERENCES [dbo].[HousingExpenseType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[TITLE_HOLDER] ADD 
	 FOREIGN KEY 
	(
		[LandTrustType]
	) REFERENCES [dbo].[LandTrustType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[TRANSACTION_DETAIL] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[ALIAS] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[ARM] ADD 
	 FOREIGN KEY 
	(
		[IndexType]
	) REFERENCES [dbo].[InterestRateIndex] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_PRODUCT_DATA] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[ASSET] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[Type]
	) REFERENCES [dbo].[AssetType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[BUYDOWN] ADD 
	 FOREIGN KEY 
	(
		[BaseDataType]
	) REFERENCES [dbo].[BaseDataType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[ContributorType]
	) REFERENCES [dbo].[ContributorType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_PRODUCT_DATA] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[CONSTRUCTION_REFINANCE_DATA] ADD 
	 FOREIGN KEY 
	(
		[ConstructionPurposeType]
	) REFERENCES [dbo].[ConstructionPurposeType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[GSERefinancePurposeType]
	) REFERENCES [dbo].[GSERefinancePurposeType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_PURPOSE] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[RefinanceImprovementsType]
	) REFERENCES [dbo].[RefinanceImprovementsType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[CONTACT_POINT] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[RoleType]
	) REFERENCES [dbo].[ContactPointRoleType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[Type]
	) REFERENCES [dbo].[ContactPointType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[CREDIT_SCORE] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[CreditScoreModelNameType]
	) REFERENCES [dbo].[CreditScoreModelNameType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[CreditRepositorySourceType]
	) REFERENCES [dbo].[CreditRepositorySourceType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[CreditScoreExclusionType]
	) REFERENCES [dbo].[CreditScoreExclusionReasonType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[CURRENT_INCOME] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[IncomeType]
	) REFERENCES [dbo].[IncomeType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[DATA_VERSION] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[DATA_INFORMATION] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[DECLARATION] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[CitizenshipResidencyType]
	) REFERENCES [dbo].[CitizenshipResidencyType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[PriorPropertyUsageType]
	) REFERENCES [dbo].[PriorPropertyUsageType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[PriorPropertyTitleType]
	) REFERENCES [dbo].[PriorPropertyTitleType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[DEPENDENT] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[EMPLOYER] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[FHA_LOAN] ADD 
	 FOREIGN KEY 
	(
		[FHAAlimonyLiabilityTreatmentType2]
	) REFERENCES [dbo].[FHAAlimonyLiabilityTreatmentType] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[GOVERNMENT_LOAN] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[SectionOfActType]
	) REFERENCES [dbo].[NationalHousingActSectionType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[FHA_VA_BORROWER] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[FNMCreditReportScoreType]
	) REFERENCES [dbo].[FNMCreditReportScoreType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[FHA_VA_LOAN] ADD 
	 FOREIGN KEY 
	(
		[GovernmentRefinanceType]
	) REFERENCES [dbo].[GovernmentRefinanceType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[GOVERNMENT_LOAN] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[GOVERNMENT_MONITORING] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[GenderType]
	) REFERENCES [dbo].[GenderType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[HMDAEthnicityType]
	) REFERENCES [dbo].[HMDAEthnicityType] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[RaceNationalOriginType]
	) REFERENCES [dbo].[RaceNationalOriginType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[LEGAL_DESCRIPTION] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[PROPERTY] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[Type]
	) REFERENCES [dbo].[LegalType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[LIABILITY] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[Type]
	) REFERENCES [dbo].[LiabilityType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[LOAN_FEATURES] ADD 
	 FOREIGN KEY 
	(
		[FullPrepaymentPenaltyOptionType]
	) REFERENCES [dbo].[FullPrepaymentPenaltyOptionType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[GSEProjectClassificationType]
	) REFERENCES [dbo].[GSEProjectClassificationType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[GSEPropertyType]
	) REFERENCES [dbo].[GSEPropertyType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LienPriorityType]
	) REFERENCES [dbo].[LienPriorityType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_PRODUCT_DATA] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[LoanClosingStatusType]
	) REFERENCES [dbo].[LoanClosingStatusType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanDocumentationType]
	) REFERENCES [dbo].[LoanDocumentationType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanRepaymentType]
	) REFERENCES [dbo].[LoanRepaymentType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[MICertificationStatusType]
	) REFERENCES [dbo].[MICertificationStatusType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[MICompanyNameType]
	) REFERENCES [dbo].[MICompanyNameType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[NameDocumentsDrawnInType]
	) REFERENCES [dbo].[NameDocumentsDrawnInType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[PaymentFrequencyType]
	) REFERENCES [dbo].[PaymentFrequencyType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[ServicingTransferStatusType]
	) REFERENCES [dbo].[ServicingTransferStatusType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[MAIL_TO] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[MORTGAGE_SCORE] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[ADDITIONAL_CASE_DATA] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[Type]
	) REFERENCES [dbo].[MortgageScoreType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[PARSED_STREET_ADDRESS] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[PROPERTY] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[PAYMENT_ADJUSTMENT] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_PRODUCT_DATA] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[PRESENT_HOUSING_EXPENSE] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[HousingExpenseType]
	) REFERENCES [dbo].[HousingExpenseType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[PURCHASE_CREDIT] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[TRANSACTION_DETAIL] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[SourceType]
	) REFERENCES [dbo].[PurchaseCreditSourceType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[Type]
	) REFERENCES [dbo].[PurchaseCreditType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[RATE_ADJUSTMENT] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_PRODUCT_DATA] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[RESIDENCE] ADD 
	 FOREIGN KEY 
	(
		[BorrowerResidencyType]
	) REFERENCES [dbo].[BorrowerResidencyType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[BorrowerResidencyBasisType]
	) REFERENCES [dbo].[BorrowerResidencyBasisType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[SUMMARY] ADD 
	 FOREIGN KEY 
	(
		[AmountType]
	) REFERENCES [dbo].[SummaryAmountType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[TRANSMITTAL_DATA] ADD 
	 FOREIGN KEY 
	(
		[CaseStateType]
	) REFERENCES [dbo].[CaseStateType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[CurrentFirstMortgageHolderType]
	) REFERENCES [dbo].[MortgageHolderType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[ADDITIONAL_CASE_DATA] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[RateLockType]
	) REFERENCES [dbo].[RateLockType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[VALUATION] ADD 
	 FOREIGN KEY 
	(
		[AppraiserId]
	) REFERENCES [dbo].[APPRAISER] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[PROPERTY] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[MethodType]
	) REFERENCES [dbo].[PropertyValuationMethodType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[VA_BORROWER] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[VA_LOAN] ADD 
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[GOVERNMENT_LOAN] (
		[LoanApplicationId]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[EXPLANATION] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[DECLARATION] (
		[BorrowerId]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[Type]
	) REFERENCES [dbo].[ExplanationType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[HMDA_RACE] ADD 
	 FOREIGN KEY 
	(
		[BorrowerId]
	) REFERENCES [dbo].[GOVERNMENT_MONITORING] (
		[BorrowerId]
	) ON DELETE CASCADE  ON UPDATE CASCADE ,
	 FOREIGN KEY 
	(
		[Type]
	) REFERENCES [dbo].[HMDARaceType] (
		[Id]
	)
GO

ALTER TABLE [dbo].[REO_PROPERTY] ADD 
	 FOREIGN KEY 
	(
		[BorrowerID]
	) REFERENCES [dbo].[BORROWER] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[DispositionStatusType]
	) REFERENCES [dbo].[DispositionStatusType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[GSEPropertyType]
	) REFERENCES [dbo].[GSEPropertyType] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LiabilityID]
	) REFERENCES [dbo].[LIABILITY] (
		[Id]
	),
	 FOREIGN KEY 
	(
		[LoanApplicationId]
	) REFERENCES [dbo].[LOAN_APPLICATION] (
		[Id]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: ApplicationMethod
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateApplicationMethod
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [ApplicationMethod]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: APPRAISER
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateAppraiser
(
@name VarChar(64) = null,
@companyName VarChar(64) = null,
@licenseIdentifier VarChar(64) = null,
@licenseState VarChar(64) = null
)
as


-- declare variables for use in the proc
declare @newid Int
-- assign values to variables in the proc

-- insert the new data into the table
insert into [APPRAISER]
	(
	[Name],
	[CompanyName],
	[LicenseIdentifier],
	[LicenseState]
	) values 
	(
	@name,
	@companyName,
	@licenseIdentifier,
	@licenseState
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: AssetType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateAssetType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [AssetType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: BaseDataType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateBaseDataType
(
@name VarChar(64) = null,
@enumeratedName VarChar(64) = null,
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [BaseDataType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:33 AM
System User: marlon
System Machine: SERVER
Entity Name: BorrowerResidencyBasisType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateBorrowerResidencyBasisType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [BorrowerResidencyBasisType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BorrowerResidencyType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateBorrowerResidencyType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [BorrowerResidencyType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BuildingStatusType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateBuildingStatusType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [BuildingStatusType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CaseStateType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateCaseStateType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [CaseStateType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CitizenshipResidencyType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateCitizenshipResidencyType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [CitizenshipResidencyType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: ConstructionPurposeType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateConstructionPurposeType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [ConstructionPurposeType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: ContactPointRoleType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateContactPointRoleType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [ContactPointRoleType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContactPointType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateContactPointType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [ContactPointType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContributorType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateContributorType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [ContributorType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditRepositorySourceType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateCreditRepositorySourceType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [CreditRepositorySourceType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditScoreExclusionReasonType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateCreditScoreExclusionReasonType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(128) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [CreditScoreExclusionReasonType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditScoreModelNameType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateCreditScoreModelNameType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [CreditScoreModelNameType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DispositionStatusType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateDispositionStatusType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [DispositionStatusType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: DownPaymentType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateDownPaymentType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [DownPaymentType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: ExplanationType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateExplanationType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [ExplanationType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHAAlimonyLiabilityTreatmentType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateFHAAlimonyLiabilityTreatmentType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [FHAAlimonyLiabilityTreatmentType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FNMCommunityLendingProductType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateFNMCommunityLendingProductType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [FNMCommunityLendingProductType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:44 AM
System User: marlon
System Machine: SERVER
Entity Name: FNMCreditReportScoreType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateFNMCreditReportScoreType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [FNMCreditReportScoreType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:44 AM
System User: marlon
System Machine: SERVER
Entity Name: FullPrepaymentPenaltyOptionType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateFullPrepaymentPenaltyOptionType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [FullPrepaymentPenaltyOptionType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GSEProjectClassificationType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateGSEProjectClassificationType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [GSEProjectClassificationType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GSEPropertyType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateGSEPropertyType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [GSEPropertyType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GSERefinancePurposeType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateGSERefinancePurposeType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [GSERefinancePurposeType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GenderType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateGenderType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [GenderType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GovernmentRefinanceType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateGovernmentRefinanceType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [GovernmentRefinanceType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAEthnicityType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateHMDAEthnicityType
(
@name VarChar(100),
@enumeratedName VarChar(100),
@description Text = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [HMDAEthnicityType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAPreapprovalType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateHMDAPreapprovalType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [HMDAPreapprovalType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAPurposeOfLoanType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateHMDAPurposeOfLoanType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [HMDAPurposeOfLoanType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDARaceType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateHMDARaceType
(
@name VarChar(100),
@enumeratedName VarChar(100),
@description Text = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [HMDARaceType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HousingExpenseType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateHousingExpenseType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [HousingExpenseType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: IncomeType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateIncomeType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [IncomeType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: InterestRateIndex
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateInterestRateIndex
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [InterestRateIndex]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: JointAssetLiabilityReportingType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateJointAssetLiabilityReportingType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [JointAssetLiabilityReportingType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:50 AM
System User: marlon
System Machine: SERVER
Entity Name: LandTrustType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLandTrustType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LandTrustType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LegalType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLegalType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description Text = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LegalType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LiabilityType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLiabilityType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description Text = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LiabilityType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LienPriorityType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLienPriorityType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LienPriorityType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanAmortizationType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLoanAmortizationType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LoanAmortizationType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_APPLICATION
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLoanApplication
(
@mISMOVersionID VarChar(64) = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LOAN_APPLICATION]
	(
	[MISMOVersionID]
	) values 
	(
	@mISMOVersionID
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanClosingStatusType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLoanClosingStatusType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LoanClosingStatusType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanDocumentationType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLoanDocumentationType
(
@name VarChar(80),
@enumeratedName VarChar(80),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LoanDocumentationType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanRepaymentType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLoanRepaymentType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LoanRepaymentType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MICertificationStatusType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateMICertificationStatusType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [MICertificationStatusType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MICompanyNameType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateMICompanyNameType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [MICompanyNameType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MaritalStatusType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateMaritalStatusType
(
@name VarChar(64) = null,
@enumeratedName VarChar(64) = null,
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [MaritalStatusType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageHolderType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateMortgageHolderType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [MortgageHolderType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageScoreType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateMortgageScoreType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [MortgageScoreType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateMortgageType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [MortgageType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: NameDocumentsDrawnInType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateNameDocumentsDrawnInType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [NameDocumentsDrawnInType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: NationalHousingActSectionType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateNationalHousingActSectionType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description Text = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [NationalHousingActSectionType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: PaymentFrequencyType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreatePaymentFrequencyType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PaymentFrequencyType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PrintPositionType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreatePrintPositionType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PrintPositionType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PriorPropertyTitleType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreatePriorPropertyTitleType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PriorPropertyTitleType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PriorPropertyUsageType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreatePriorPropertyUsageType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PriorPropertyUsageType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyRightsType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreatePropertyRightsType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PropertyRightsType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyUsageType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreatePropertyUsageType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PropertyUsageType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyValuationMethodType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreatePropertyValuationMethodType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PropertyValuationMethodType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurchaseCreditSourceType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreatePurchaseCreditSourceType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PurchaseCreditSourceType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurchaseCreditType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreatePurchaseCreditType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PurchaseCreditType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurposeType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreatePurposeType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PurposeType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: RaceNationalOriginType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateRaceNationalOriginType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description Text = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [RaceNationalOriginType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RateLockType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateRateLockType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [RateLockType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RefinanceImprovementsType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateRefinanceImprovementsType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [RefinanceImprovementsType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: ServicingTransferStatusType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateServicingTransferStatusType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [ServicingTransferStatusType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: SummaryAmountType
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateSummaryAmountType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [SummaryAmountType]
	(
	[Id],
	[Name],
	[EnumeratedName],
	[Description]
	) values 
	(
	@id,
	@name,
	@enumeratedName,
	@description
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: ApplicationMethod
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteApplicationMethod
(
@id SmallInt
)
as


delete from [ApplicationMethod] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: APPRAISER
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteAppraiser
(
@id Int
)
as


delete from [APPRAISER] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: AssetType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteAssetType
(
@id SmallInt
)
as


delete from [AssetType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: BaseDataType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteBaseDataType
(
@id SmallInt
)
as


delete from [BaseDataType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BorrowerResidencyBasisType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteBorrowerResidencyBasisType
(
@id SmallInt
)
as


delete from [BorrowerResidencyBasisType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BorrowerResidencyType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteBorrowerResidencyType
(
@id SmallInt
)
as


delete from [BorrowerResidencyType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BuildingStatusType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteBuildingStatusType
(
@id SmallInt
)
as


delete from [BuildingStatusType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CaseStateType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteCaseStateType
(
@id SmallInt
)
as


delete from [CaseStateType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CitizenshipResidencyType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteCitizenshipResidencyType
(
@id SmallInt
)
as


delete from [CitizenshipResidencyType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: ConstructionPurposeType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteConstructionPurposeType
(
@id SmallInt
)
as


delete from [ConstructionPurposeType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContactPointRoleType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteContactPointRoleType
(
@id SmallInt
)
as


delete from [ContactPointRoleType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContactPointType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteContactPointType
(
@id SmallInt
)
as


delete from [ContactPointType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContributorType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteContributorType
(
@id SmallInt
)
as


delete from [ContributorType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditRepositorySourceType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteCreditRepositorySourceType
(
@id SmallInt
)
as


delete from [CreditRepositorySourceType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditScoreExclusionReasonType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteCreditScoreExclusionReasonType
(
@id SmallInt
)
as


delete from [CreditScoreExclusionReasonType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditScoreModelNameType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteCreditScoreModelNameType
(
@id SmallInt
)
as


delete from [CreditScoreModelNameType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DispositionStatusType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteDispositionStatusType
(
@id SmallInt
)
as


delete from [DispositionStatusType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: DownPaymentType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteDownPaymentType
(
@id SmallInt
)
as


delete from [DownPaymentType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: ExplanationType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteExplanationType
(
@id SmallInt
)
as


delete from [ExplanationType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHAAlimonyLiabilityTreatmentType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteFHAAlimonyLiabilityTreatmentType
(
@id SmallInt
)
as


delete from [FHAAlimonyLiabilityTreatmentType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FNMCommunityLendingProductType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteFNMCommunityLendingProductType
(
@id SmallInt
)
as


delete from [FNMCommunityLendingProductType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:44 AM
System User: marlon
System Machine: SERVER
Entity Name: FNMCreditReportScoreType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteFNMCreditReportScoreType
(
@id SmallInt
)
as


delete from [FNMCreditReportScoreType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:44 AM
System User: marlon
System Machine: SERVER
Entity Name: FullPrepaymentPenaltyOptionType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteFullPrepaymentPenaltyOptionType
(
@id SmallInt
)
as


delete from [FullPrepaymentPenaltyOptionType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GSEProjectClassificationType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteGSEProjectClassificationType
(
@id SmallInt
)
as


delete from [GSEProjectClassificationType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GSEPropertyType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteGSEPropertyType
(
@id SmallInt
)
as


delete from [GSEPropertyType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: GSERefinancePurposeType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteGSERefinancePurposeType
(
@id SmallInt
)
as


delete from [GSERefinancePurposeType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GenderType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteGenderType
(
@id SmallInt
)
as


delete from [GenderType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GovernmentRefinanceType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteGovernmentRefinanceType
(
@id SmallInt
)
as


delete from [GovernmentRefinanceType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAEthnicityType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteHMDAEthnicityType
(
@id SmallInt
)
as


delete from [HMDAEthnicityType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAPreapprovalType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteHMDAPreapprovalType
(
@id SmallInt
)
as


delete from [HMDAPreapprovalType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAPurposeOfLoanType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteHMDAPurposeOfLoanType
(
@id SmallInt
)
as


delete from [HMDAPurposeOfLoanType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDARaceType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteHMDARaceType
(
@id SmallInt
)
as


delete from [HMDARaceType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HousingExpenseType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteHousingExpenseType
(
@id SmallInt
)
as


delete from [HousingExpenseType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: IncomeType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteIncomeType
(
@id SmallInt
)
as


delete from [IncomeType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: InterestRateIndex
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteInterestRateIndex
(
@id SmallInt
)
as


delete from [InterestRateIndex] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: JointAssetLiabilityReportingType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteJointAssetLiabilityReportingType
(
@id SmallInt
)
as


delete from [JointAssetLiabilityReportingType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:50 AM
System User: marlon
System Machine: SERVER
Entity Name: LandTrustType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLandTrustType
(
@id SmallInt
)
as


delete from [LandTrustType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LegalType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLegalType
(
@id SmallInt
)
as


delete from [LegalType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LiabilityType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLiabilityType
(
@id SmallInt
)
as


delete from [LiabilityType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LienPriorityType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLienPriorityType
(
@id SmallInt
)
as


delete from [LienPriorityType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanAmortizationType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLoanAmortizationType
(
@id SmallInt
)
as


delete from [LoanAmortizationType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_APPLICATION
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLoanApplication
(
@id BigInt
)
as


delete from [LOAN_APPLICATION] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanClosingStatusType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLoanClosingStatusType
(
@id SmallInt
)
as


delete from [LoanClosingStatusType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanDocumentationType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLoanDocumentationType
(
@id SmallInt
)
as


delete from [LoanDocumentationType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanRepaymentType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLoanRepaymentType
(
@id SmallInt
)
as


delete from [LoanRepaymentType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MICertificationStatusType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteMICertificationStatusType
(
@id SmallInt
)
as


delete from [MICertificationStatusType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MICompanyNameType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteMICompanyNameType
(
@id SmallInt
)
as


delete from [MICompanyNameType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MaritalStatusType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteMaritalStatusType
(
@id SmallInt
)
as


delete from [MaritalStatusType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageHolderType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteMortgageHolderType
(
@id SmallInt
)
as


delete from [MortgageHolderType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageScoreType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteMortgageScoreType
(
@id SmallInt
)
as


delete from [MortgageScoreType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteMortgageType
(
@id SmallInt
)
as


delete from [MortgageType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: NameDocumentsDrawnInType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteNameDocumentsDrawnInType
(
@id SmallInt
)
as


delete from [NameDocumentsDrawnInType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: NationalHousingActSectionType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteNationalHousingActSectionType
(
@id SmallInt
)
as


delete from [NationalHousingActSectionType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PaymentFrequencyType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeletePaymentFrequencyType
(
@id SmallInt
)
as


delete from [PaymentFrequencyType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PrintPositionType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeletePrintPositionType
(
@id SmallInt
)
as


delete from [PrintPositionType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PriorPropertyTitleType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeletePriorPropertyTitleType
(
@id SmallInt
)
as


delete from [PriorPropertyTitleType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PriorPropertyUsageType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeletePriorPropertyUsageType
(
@id SmallInt
)
as


delete from [PriorPropertyUsageType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyRightsType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeletePropertyRightsType
(
@id SmallInt
)
as


delete from [PropertyRightsType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyUsageType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeletePropertyUsageType
(
@id SmallInt
)
as


delete from [PropertyUsageType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyValuationMethodType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeletePropertyValuationMethodType
(
@id SmallInt
)
as


delete from [PropertyValuationMethodType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurchaseCreditSourceType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeletePurchaseCreditSourceType
(
@id SmallInt
)
as


delete from [PurchaseCreditSourceType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurchaseCreditType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeletePurchaseCreditType
(
@id SmallInt
)
as


delete from [PurchaseCreditType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurposeType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeletePurposeType
(
@id SmallInt
)
as


delete from [PurposeType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: RaceNationalOriginType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteRaceNationalOriginType
(
@id SmallInt
)
as


delete from [RaceNationalOriginType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RateLockType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteRateLockType
(
@id SmallInt
)
as


delete from [RateLockType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RefinanceImprovementsType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteRefinanceImprovementsType
(
@id SmallInt
)
as


delete from [RefinanceImprovementsType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: ServicingTransferStatusType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteServicingTransferStatusType
(
@id SmallInt
)
as


delete from [ServicingTransferStatusType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: SummaryAmountType
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteSummaryAmountType
(
@id SmallInt
)
as


delete from [SummaryAmountType] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: ApplicationMethod
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectApplicationMethod
(
@id SmallInt
)
as


select 
	[ApplicationMethod].[Id],
	[ApplicationMethod].[Name],
	[ApplicationMethod].[EnumeratedName],
	[ApplicationMethod].[Description]
from 
	[ApplicationMethod] 
where 
	[ApplicationMethod].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: ApplicationMethod
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectApplicationMethods
as


select 
	[ApplicationMethod].[Id],
	[ApplicationMethod].[Name],
	[ApplicationMethod].[EnumeratedName],
	[ApplicationMethod].[Description]
from 
	[ApplicationMethod] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: APPRAISER
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectAppraiser
(
@id Int
)
as


select 
	[APPRAISER].[Id],
	[APPRAISER].[Name],
	[APPRAISER].[CompanyName],
	[APPRAISER].[LicenseIdentifier],
	[APPRAISER].[LicenseState]
from 
	[APPRAISER] 
where 
	[APPRAISER].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: APPRAISER
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectAppraisers
as


select 
	[APPRAISER].[Id],
	[APPRAISER].[Name],
	[APPRAISER].[CompanyName],
	[APPRAISER].[LicenseIdentifier],
	[APPRAISER].[LicenseState]
from 
	[APPRAISER] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: AssetType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectAssetType
(
@id SmallInt
)
as


select 
	[AssetType].[Id],
	[AssetType].[Name],
	[AssetType].[EnumeratedName],
	[AssetType].[Description]
from 
	[AssetType] 
where 
	[AssetType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: AssetType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectAssetTypes
as


select 
	[AssetType].[Id],
	[AssetType].[Name],
	[AssetType].[EnumeratedName],
	[AssetType].[Description]
from 
	[AssetType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: BaseDataType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectBaseDataType
(
@id SmallInt
)
as


select 
	[BaseDataType].[Id],
	[BaseDataType].[Name],
	[BaseDataType].[EnumeratedName],
	[BaseDataType].[Description]
from 
	[BaseDataType] 
where 
	[BaseDataType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: BaseDataType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectBaseDataTypes
as


select 
	[BaseDataType].[Id],
	[BaseDataType].[Name],
	[BaseDataType].[EnumeratedName],
	[BaseDataType].[Description]
from 
	[BaseDataType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BorrowerResidencyBasisType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectBorrowerResidencyBasisType
(
@id SmallInt
)
as


select 
	[BorrowerResidencyBasisType].[Id],
	[BorrowerResidencyBasisType].[Name],
	[BorrowerResidencyBasisType].[EnumeratedName],
	[BorrowerResidencyBasisType].[Description]
from 
	[BorrowerResidencyBasisType] 
where 
	[BorrowerResidencyBasisType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BorrowerResidencyBasisType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectBorrowerResidencyBasisTypes
as


select 
	[BorrowerResidencyBasisType].[Id],
	[BorrowerResidencyBasisType].[Name],
	[BorrowerResidencyBasisType].[EnumeratedName],
	[BorrowerResidencyBasisType].[Description]
from 
	[BorrowerResidencyBasisType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BorrowerResidencyType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectBorrowerResidencyType
(
@id SmallInt
)
as


select 
	[BorrowerResidencyType].[Id],
	[BorrowerResidencyType].[Name],
	[BorrowerResidencyType].[EnumeratedName],
	[BorrowerResidencyType].[Description]
from 
	[BorrowerResidencyType] 
where 
	[BorrowerResidencyType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BorrowerResidencyType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectBorrowerResidencyTypes
as


select 
	[BorrowerResidencyType].[Id],
	[BorrowerResidencyType].[Name],
	[BorrowerResidencyType].[EnumeratedName],
	[BorrowerResidencyType].[Description]
from 
	[BorrowerResidencyType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BuildingStatusType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectBuildingStatusType
(
@id SmallInt
)
as


select 
	[BuildingStatusType].[Id],
	[BuildingStatusType].[Name],
	[BuildingStatusType].[EnumeratedName],
	[BuildingStatusType].[Description]
from 
	[BuildingStatusType] 
where 
	[BuildingStatusType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BuildingStatusType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectBuildingStatusTypes
as


select 
	[BuildingStatusType].[Id],
	[BuildingStatusType].[Name],
	[BuildingStatusType].[EnumeratedName],
	[BuildingStatusType].[Description]
from 
	[BuildingStatusType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CaseStateType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectCaseStateType
(
@id SmallInt
)
as


select 
	[CaseStateType].[Id],
	[CaseStateType].[Name],
	[CaseStateType].[EnumeratedName],
	[CaseStateType].[Description]
from 
	[CaseStateType] 
where 
	[CaseStateType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CaseStateType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectCaseStateTypes
as


select 
	[CaseStateType].[Id],
	[CaseStateType].[Name],
	[CaseStateType].[EnumeratedName],
	[CaseStateType].[Description]
from 
	[CaseStateType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CitizenshipResidencyType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectCitizenshipResidencyType
(
@id SmallInt
)
as


select 
	[CitizenshipResidencyType].[Id],
	[CitizenshipResidencyType].[Name],
	[CitizenshipResidencyType].[EnumeratedName],
	[CitizenshipResidencyType].[Description]
from 
	[CitizenshipResidencyType] 
where 
	[CitizenshipResidencyType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CitizenshipResidencyType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectCitizenshipResidencyTypes
as


select 
	[CitizenshipResidencyType].[Id],
	[CitizenshipResidencyType].[Name],
	[CitizenshipResidencyType].[EnumeratedName],
	[CitizenshipResidencyType].[Description]
from 
	[CitizenshipResidencyType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: ConstructionPurposeType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectConstructionPurposeType
(
@id SmallInt
)
as


select 
	[ConstructionPurposeType].[Id],
	[ConstructionPurposeType].[Name],
	[ConstructionPurposeType].[EnumeratedName],
	[ConstructionPurposeType].[Description]
from 
	[ConstructionPurposeType] 
where 
	[ConstructionPurposeType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: ConstructionPurposeType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectConstructionPurposeTypes
as


select 
	[ConstructionPurposeType].[Id],
	[ConstructionPurposeType].[Name],
	[ConstructionPurposeType].[EnumeratedName],
	[ConstructionPurposeType].[Description]
from 
	[ConstructionPurposeType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContactPointRoleType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectContactPointRoleType
(
@id SmallInt
)
as


select 
	[ContactPointRoleType].[Id],
	[ContactPointRoleType].[Name],
	[ContactPointRoleType].[EnumeratedName],
	[ContactPointRoleType].[Description]
from 
	[ContactPointRoleType] 
where 
	[ContactPointRoleType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContactPointRoleType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectContactPointRoleTypes
as


select 
	[ContactPointRoleType].[Id],
	[ContactPointRoleType].[Name],
	[ContactPointRoleType].[EnumeratedName],
	[ContactPointRoleType].[Description]
from 
	[ContactPointRoleType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContactPointType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectContactPointType
(
@id SmallInt
)
as


select 
	[ContactPointType].[Id],
	[ContactPointType].[Name],
	[ContactPointType].[EnumeratedName],
	[ContactPointType].[Description]
from 
	[ContactPointType] 
where 
	[ContactPointType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContactPointType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectContactPointTypes
as


select 
	[ContactPointType].[Id],
	[ContactPointType].[Name],
	[ContactPointType].[EnumeratedName],
	[ContactPointType].[Description]
from 
	[ContactPointType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContributorType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectContributorType
(
@id SmallInt
)
as


select 
	[ContributorType].[Id],
	[ContributorType].[Name],
	[ContributorType].[EnumeratedName],
	[ContributorType].[Description]
from 
	[ContributorType] 
where 
	[ContributorType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContributorType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectContributorTypes
as


select 
	[ContributorType].[Id],
	[ContributorType].[Name],
	[ContributorType].[EnumeratedName],
	[ContributorType].[Description]
from 
	[ContributorType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditRepositorySourceType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectCreditRepositorySourceType
(
@id SmallInt
)
as


select 
	[CreditRepositorySourceType].[Id],
	[CreditRepositorySourceType].[Name],
	[CreditRepositorySourceType].[EnumeratedName],
	[CreditRepositorySourceType].[Description]
from 
	[CreditRepositorySourceType] 
where 
	[CreditRepositorySourceType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditRepositorySourceType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectCreditRepositorySourceTypes
as


select 
	[CreditRepositorySourceType].[Id],
	[CreditRepositorySourceType].[Name],
	[CreditRepositorySourceType].[EnumeratedName],
	[CreditRepositorySourceType].[Description]
from 
	[CreditRepositorySourceType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditScoreExclusionReasonType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectCreditScoreExclusionReasonType
(
@id SmallInt
)
as


select 
	[CreditScoreExclusionReasonType].[Id],
	[CreditScoreExclusionReasonType].[Name],
	[CreditScoreExclusionReasonType].[EnumeratedName],
	[CreditScoreExclusionReasonType].[Description]
from 
	[CreditScoreExclusionReasonType] 
where 
	[CreditScoreExclusionReasonType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditScoreExclusionReasonType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectCreditScoreExclusionReasonTypes
as


select 
	[CreditScoreExclusionReasonType].[Id],
	[CreditScoreExclusionReasonType].[Name],
	[CreditScoreExclusionReasonType].[EnumeratedName],
	[CreditScoreExclusionReasonType].[Description]
from 
	[CreditScoreExclusionReasonType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditScoreModelNameType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectCreditScoreModelNameType
(
@id SmallInt
)
as


select 
	[CreditScoreModelNameType].[Id],
	[CreditScoreModelNameType].[Name],
	[CreditScoreModelNameType].[EnumeratedName],
	[CreditScoreModelNameType].[Description]
from 
	[CreditScoreModelNameType] 
where 
	[CreditScoreModelNameType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditScoreModelNameType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectCreditScoreModelNameTypes
as


select 
	[CreditScoreModelNameType].[Id],
	[CreditScoreModelNameType].[Name],
	[CreditScoreModelNameType].[EnumeratedName],
	[CreditScoreModelNameType].[Description]
from 
	[CreditScoreModelNameType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DispositionStatusType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectDispositionStatusType
(
@id SmallInt
)
as


select 
	[DispositionStatusType].[Id],
	[DispositionStatusType].[Name],
	[DispositionStatusType].[EnumeratedName],
	[DispositionStatusType].[Description]
from 
	[DispositionStatusType] 
where 
	[DispositionStatusType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DispositionStatusType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectDispositionStatusTypes
as


select 
	[DispositionStatusType].[Id],
	[DispositionStatusType].[Name],
	[DispositionStatusType].[EnumeratedName],
	[DispositionStatusType].[Description]
from 
	[DispositionStatusType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: DownPaymentType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectDownPaymentType
(
@id SmallInt
)
as


select 
	[DownPaymentType].[Id],
	[DownPaymentType].[Name],
	[DownPaymentType].[EnumeratedName],
	[DownPaymentType].[Description]
from 
	[DownPaymentType] 
where 
	[DownPaymentType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: DownPaymentType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectDownPaymentTypes
as


select 
	[DownPaymentType].[Id],
	[DownPaymentType].[Name],
	[DownPaymentType].[EnumeratedName],
	[DownPaymentType].[Description]
from 
	[DownPaymentType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: ExplanationType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectExplanationType
(
@id SmallInt
)
as


select 
	[ExplanationType].[Id],
	[ExplanationType].[Name],
	[ExplanationType].[EnumeratedName],
	[ExplanationType].[Description]
from 
	[ExplanationType] 
where 
	[ExplanationType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: ExplanationType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectExplanationTypes
as


select 
	[ExplanationType].[Id],
	[ExplanationType].[Name],
	[ExplanationType].[EnumeratedName],
	[ExplanationType].[Description]
from 
	[ExplanationType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHAAlimonyLiabilityTreatmentType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectFHAAlimonyLiabilityTreatmentType
(
@id SmallInt
)
as


select 
	[FHAAlimonyLiabilityTreatmentType].[Id],
	[FHAAlimonyLiabilityTreatmentType].[Name],
	[FHAAlimonyLiabilityTreatmentType].[EnumeratedName],
	[FHAAlimonyLiabilityTreatmentType].[Description]
from 
	[FHAAlimonyLiabilityTreatmentType] 
where 
	[FHAAlimonyLiabilityTreatmentType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHAAlimonyLiabilityTreatmentType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectFHAAlimonyLiabilityTreatmentTypes
as


select 
	[FHAAlimonyLiabilityTreatmentType].[Id],
	[FHAAlimonyLiabilityTreatmentType].[Name],
	[FHAAlimonyLiabilityTreatmentType].[EnumeratedName],
	[FHAAlimonyLiabilityTreatmentType].[Description]
from 
	[FHAAlimonyLiabilityTreatmentType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FNMCommunityLendingProductType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectFNMCommunityLendingProductType
(
@id SmallInt
)
as


select 
	[FNMCommunityLendingProductType].[Id],
	[FNMCommunityLendingProductType].[Name],
	[FNMCommunityLendingProductType].[EnumeratedName],
	[FNMCommunityLendingProductType].[Description]
from 
	[FNMCommunityLendingProductType] 
where 
	[FNMCommunityLendingProductType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:44 AM
System User: marlon
System Machine: SERVER
Entity Name: FNMCommunityLendingProductType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectFNMCommunityLendingProductTypes
as


select 
	[FNMCommunityLendingProductType].[Id],
	[FNMCommunityLendingProductType].[Name],
	[FNMCommunityLendingProductType].[EnumeratedName],
	[FNMCommunityLendingProductType].[Description]
from 
	[FNMCommunityLendingProductType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:44 AM
System User: marlon
System Machine: SERVER
Entity Name: FNMCreditReportScoreType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectFNMCreditReportScoreType
(
@id SmallInt
)
as


select 
	[FNMCreditReportScoreType].[Id],
	[FNMCreditReportScoreType].[Name],
	[FNMCreditReportScoreType].[EnumeratedName],
	[FNMCreditReportScoreType].[Description]
from 
	[FNMCreditReportScoreType] 
where 
	[FNMCreditReportScoreType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:44 AM
System User: marlon
System Machine: SERVER
Entity Name: FNMCreditReportScoreType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectFNMCreditReportScoreTypes
as


select 
	[FNMCreditReportScoreType].[Id],
	[FNMCreditReportScoreType].[Name],
	[FNMCreditReportScoreType].[EnumeratedName],
	[FNMCreditReportScoreType].[Description]
from 
	[FNMCreditReportScoreType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:44 AM
System User: marlon
System Machine: SERVER
Entity Name: FullPrepaymentPenaltyOptionType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectFullPrepaymentPenaltyOptionType
(
@id SmallInt
)
as


select 
	[FullPrepaymentPenaltyOptionType].[Id],
	[FullPrepaymentPenaltyOptionType].[Name],
	[FullPrepaymentPenaltyOptionType].[EnumeratedName],
	[FullPrepaymentPenaltyOptionType].[Description]
from 
	[FullPrepaymentPenaltyOptionType] 
where 
	[FullPrepaymentPenaltyOptionType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: FullPrepaymentPenaltyOptionType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectFullPrepaymentPenaltyOptionTypes
as


select 
	[FullPrepaymentPenaltyOptionType].[Id],
	[FullPrepaymentPenaltyOptionType].[Name],
	[FullPrepaymentPenaltyOptionType].[EnumeratedName],
	[FullPrepaymentPenaltyOptionType].[Description]
from 
	[FullPrepaymentPenaltyOptionType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GSEProjectClassificationType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectGSEProjectClassificationType
(
@id SmallInt
)
as


select 
	[GSEProjectClassificationType].[Id],
	[GSEProjectClassificationType].[Name],
	[GSEProjectClassificationType].[EnumeratedName],
	[GSEProjectClassificationType].[Description]
from 
	[GSEProjectClassificationType] 
where 
	[GSEProjectClassificationType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GSEProjectClassificationType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectGSEProjectClassificationTypes
as


select 
	[GSEProjectClassificationType].[Id],
	[GSEProjectClassificationType].[Name],
	[GSEProjectClassificationType].[EnumeratedName],
	[GSEProjectClassificationType].[Description]
from 
	[GSEProjectClassificationType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GSEPropertyType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectGSEPropertyType
(
@id SmallInt
)
as


select 
	[GSEPropertyType].[Id],
	[GSEPropertyType].[Name],
	[GSEPropertyType].[EnumeratedName],
	[GSEPropertyType].[Description]
from 
	[GSEPropertyType] 
where 
	[GSEPropertyType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GSEPropertyType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectGSEPropertyTypes
as


select 
	[GSEPropertyType].[Id],
	[GSEPropertyType].[Name],
	[GSEPropertyType].[EnumeratedName],
	[GSEPropertyType].[Description]
from 
	[GSEPropertyType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: GSERefinancePurposeType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectGSERefinancePurposeType
(
@id SmallInt
)
as


select 
	[GSERefinancePurposeType].[Id],
	[GSERefinancePurposeType].[Name],
	[GSERefinancePurposeType].[EnumeratedName],
	[GSERefinancePurposeType].[Description]
from 
	[GSERefinancePurposeType] 
where 
	[GSERefinancePurposeType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: GSERefinancePurposeType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectGSERefinancePurposeTypes
as


select 
	[GSERefinancePurposeType].[Id],
	[GSERefinancePurposeType].[Name],
	[GSERefinancePurposeType].[EnumeratedName],
	[GSERefinancePurposeType].[Description]
from 
	[GSERefinancePurposeType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GenderType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectGenderType
(
@id SmallInt
)
as


select 
	[GenderType].[Id],
	[GenderType].[Name],
	[GenderType].[EnumeratedName],
	[GenderType].[Description]
from 
	[GenderType] 
where 
	[GenderType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GenderType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectGenderTypes
as


select 
	[GenderType].[Id],
	[GenderType].[Name],
	[GenderType].[EnumeratedName],
	[GenderType].[Description]
from 
	[GenderType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GovernmentRefinanceType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectGovernmentRefinanceType
(
@id SmallInt
)
as


select 
	[GovernmentRefinanceType].[Id],
	[GovernmentRefinanceType].[Name],
	[GovernmentRefinanceType].[EnumeratedName],
	[GovernmentRefinanceType].[Description]
from 
	[GovernmentRefinanceType] 
where 
	[GovernmentRefinanceType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GovernmentRefinanceType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectGovernmentRefinanceTypes
as


select 
	[GovernmentRefinanceType].[Id],
	[GovernmentRefinanceType].[Name],
	[GovernmentRefinanceType].[EnumeratedName],
	[GovernmentRefinanceType].[Description]
from 
	[GovernmentRefinanceType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAEthnicityType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectHMDAEthnicityType
(
@id SmallInt
)
as


select 
	[HMDAEthnicityType].[Id],
	[HMDAEthnicityType].[Name],
	[HMDAEthnicityType].[EnumeratedName],
	[HMDAEthnicityType].[Description]
from 
	[HMDAEthnicityType] 
where 
	[HMDAEthnicityType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAEthnicityType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectHMDAEthnicityTypes
as


select 
	[HMDAEthnicityType].[Id],
	[HMDAEthnicityType].[Name],
	[HMDAEthnicityType].[EnumeratedName],
	[HMDAEthnicityType].[Description]
from 
	[HMDAEthnicityType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAPreapprovalType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectHMDAPreapprovalType
(
@id SmallInt
)
as


select 
	[HMDAPreapprovalType].[Id],
	[HMDAPreapprovalType].[Name],
	[HMDAPreapprovalType].[EnumeratedName],
	[HMDAPreapprovalType].[Description]
from 
	[HMDAPreapprovalType] 
where 
	[HMDAPreapprovalType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAPreapprovalType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectHMDAPreapprovalTypes
as


select 
	[HMDAPreapprovalType].[Id],
	[HMDAPreapprovalType].[Name],
	[HMDAPreapprovalType].[EnumeratedName],
	[HMDAPreapprovalType].[Description]
from 
	[HMDAPreapprovalType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAPurposeOfLoanType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectHMDAPurposeOfLoanType
(
@id SmallInt
)
as


select 
	[HMDAPurposeOfLoanType].[Id],
	[HMDAPurposeOfLoanType].[Name],
	[HMDAPurposeOfLoanType].[EnumeratedName],
	[HMDAPurposeOfLoanType].[Description]
from 
	[HMDAPurposeOfLoanType] 
where 
	[HMDAPurposeOfLoanType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAPurposeOfLoanType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectHMDAPurposeOfLoanTypes
as


select 
	[HMDAPurposeOfLoanType].[Id],
	[HMDAPurposeOfLoanType].[Name],
	[HMDAPurposeOfLoanType].[EnumeratedName],
	[HMDAPurposeOfLoanType].[Description]
from 
	[HMDAPurposeOfLoanType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDARaceType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectHMDARaceType
(
@id SmallInt
)
as


select 
	[HMDARaceType].[Id],
	[HMDARaceType].[Name],
	[HMDARaceType].[EnumeratedName],
	[HMDARaceType].[Description]
from 
	[HMDARaceType] 
where 
	[HMDARaceType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDARaceType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectHMDARaceTypes
as


select 
	[HMDARaceType].[Id],
	[HMDARaceType].[Name],
	[HMDARaceType].[EnumeratedName],
	[HMDARaceType].[Description]
from 
	[HMDARaceType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HousingExpenseType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectHousingExpenseType
(
@id SmallInt
)
as


select 
	[HousingExpenseType].[Id],
	[HousingExpenseType].[Name],
	[HousingExpenseType].[EnumeratedName],
	[HousingExpenseType].[Description]
from 
	[HousingExpenseType] 
where 
	[HousingExpenseType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HousingExpenseType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectHousingExpenseTypes
as


select 
	[HousingExpenseType].[Id],
	[HousingExpenseType].[Name],
	[HousingExpenseType].[EnumeratedName],
	[HousingExpenseType].[Description]
from 
	[HousingExpenseType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: IncomeType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectIncomeType
(
@id SmallInt
)
as


select 
	[IncomeType].[Id],
	[IncomeType].[Name],
	[IncomeType].[EnumeratedName],
	[IncomeType].[Description]
from 
	[IncomeType] 
where 
	[IncomeType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: IncomeType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectIncomeTypes
as


select 
	[IncomeType].[Id],
	[IncomeType].[Name],
	[IncomeType].[EnumeratedName],
	[IncomeType].[Description]
from 
	[IncomeType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: InterestRateIndex
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectInterestRateIndex
(
@id SmallInt
)
as


select 
	[InterestRateIndex].[Id],
	[InterestRateIndex].[Name],
	[InterestRateIndex].[EnumeratedName],
	[InterestRateIndex].[Description]
from 
	[InterestRateIndex] 
where 
	[InterestRateIndex].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: InterestRateIndex
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectInterestRateIndexs
as


select 
	[InterestRateIndex].[Id],
	[InterestRateIndex].[Name],
	[InterestRateIndex].[EnumeratedName],
	[InterestRateIndex].[Description]
from 
	[InterestRateIndex] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: JointAssetLiabilityReportingType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectJointAssetLiabilityReportingType
(
@id SmallInt
)
as


select 
	[JointAssetLiabilityReportingType].[Id],
	[JointAssetLiabilityReportingType].[Name],
	[JointAssetLiabilityReportingType].[EnumeratedName],
	[JointAssetLiabilityReportingType].[Description]
from 
	[JointAssetLiabilityReportingType] 
where 
	[JointAssetLiabilityReportingType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: JointAssetLiabilityReportingType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectJointAssetLiabilityReportingTypes
as


select 
	[JointAssetLiabilityReportingType].[Id],
	[JointAssetLiabilityReportingType].[Name],
	[JointAssetLiabilityReportingType].[EnumeratedName],
	[JointAssetLiabilityReportingType].[Description]
from 
	[JointAssetLiabilityReportingType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:50 AM
System User: marlon
System Machine: SERVER
Entity Name: LandTrustType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLandTrustType
(
@id SmallInt
)
as


select 
	[LandTrustType].[Id],
	[LandTrustType].[Name],
	[LandTrustType].[EnumeratedName],
	[LandTrustType].[Description]
from 
	[LandTrustType] 
where 
	[LandTrustType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:50 AM
System User: marlon
System Machine: SERVER
Entity Name: LandTrustType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLandTrustTypes
as


select 
	[LandTrustType].[Id],
	[LandTrustType].[Name],
	[LandTrustType].[EnumeratedName],
	[LandTrustType].[Description]
from 
	[LandTrustType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LegalType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLegalType
(
@id SmallInt
)
as


select 
	[LegalType].[Id],
	[LegalType].[Name],
	[LegalType].[EnumeratedName],
	[LegalType].[Description]
from 
	[LegalType] 
where 
	[LegalType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LegalType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLegalTypes
as


select 
	[LegalType].[Id],
	[LegalType].[Name],
	[LegalType].[EnumeratedName],
	[LegalType].[Description]
from 
	[LegalType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LiabilityType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLiabilityType
(
@id SmallInt
)
as


select 
	[LiabilityType].[Id],
	[LiabilityType].[Name],
	[LiabilityType].[EnumeratedName],
	[LiabilityType].[Description]
from 
	[LiabilityType] 
where 
	[LiabilityType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LiabilityType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLiabilityTypes
as


select 
	[LiabilityType].[Id],
	[LiabilityType].[Name],
	[LiabilityType].[EnumeratedName],
	[LiabilityType].[Description]
from 
	[LiabilityType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LienPriorityType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLienPriorityType
(
@id SmallInt
)
as


select 
	[LienPriorityType].[Id],
	[LienPriorityType].[Name],
	[LienPriorityType].[EnumeratedName],
	[LienPriorityType].[Description]
from 
	[LienPriorityType] 
where 
	[LienPriorityType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LienPriorityType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLienPriorityTypes
as


select 
	[LienPriorityType].[Id],
	[LienPriorityType].[Name],
	[LienPriorityType].[EnumeratedName],
	[LienPriorityType].[Description]
from 
	[LienPriorityType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanAmortizationType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLoanAmortizationType
(
@id SmallInt
)
as


select 
	[LoanAmortizationType].[Id],
	[LoanAmortizationType].[Name],
	[LoanAmortizationType].[EnumeratedName],
	[LoanAmortizationType].[Description]
from 
	[LoanAmortizationType] 
where 
	[LoanAmortizationType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanAmortizationType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLoanAmortizationTypes
as


select 
	[LoanAmortizationType].[Id],
	[LoanAmortizationType].[Name],
	[LoanAmortizationType].[EnumeratedName],
	[LoanAmortizationType].[Description]
from 
	[LoanAmortizationType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_APPLICATION
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLoanApplication
(
@id BigInt
)
as


select 
	[LOAN_APPLICATION].[Id],
	[LOAN_APPLICATION].[MISMOVersionID]
from 
	[LOAN_APPLICATION] 
where 
	[LOAN_APPLICATION].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_APPLICATION
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLoanApplications
as


select 
	[LOAN_APPLICATION].[Id],
	[LOAN_APPLICATION].[MISMOVersionID]
from 
	[LOAN_APPLICATION] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanClosingStatusType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLoanClosingStatusType
(
@id SmallInt
)
as


select 
	[LoanClosingStatusType].[Id],
	[LoanClosingStatusType].[Name],
	[LoanClosingStatusType].[EnumeratedName],
	[LoanClosingStatusType].[Description]
from 
	[LoanClosingStatusType] 
where 
	[LoanClosingStatusType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanClosingStatusType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLoanClosingStatusTypes
as


select 
	[LoanClosingStatusType].[Id],
	[LoanClosingStatusType].[Name],
	[LoanClosingStatusType].[EnumeratedName],
	[LoanClosingStatusType].[Description]
from 
	[LoanClosingStatusType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanDocumentationType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLoanDocumentationType
(
@id SmallInt
)
as


select 
	[LoanDocumentationType].[Id],
	[LoanDocumentationType].[Name],
	[LoanDocumentationType].[EnumeratedName],
	[LoanDocumentationType].[Description]
from 
	[LoanDocumentationType] 
where 
	[LoanDocumentationType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanDocumentationType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLoanDocumentationTypes
as


select 
	[LoanDocumentationType].[Id],
	[LoanDocumentationType].[Name],
	[LoanDocumentationType].[EnumeratedName],
	[LoanDocumentationType].[Description]
from 
	[LoanDocumentationType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanRepaymentType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLoanRepaymentType
(
@id SmallInt
)
as


select 
	[LoanRepaymentType].[Id],
	[LoanRepaymentType].[Name],
	[LoanRepaymentType].[EnumeratedName],
	[LoanRepaymentType].[Description]
from 
	[LoanRepaymentType] 
where 
	[LoanRepaymentType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanRepaymentType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLoanRepaymentTypes
as


select 
	[LoanRepaymentType].[Id],
	[LoanRepaymentType].[Name],
	[LoanRepaymentType].[EnumeratedName],
	[LoanRepaymentType].[Description]
from 
	[LoanRepaymentType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MICertificationStatusType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectMICertificationStatusType
(
@id SmallInt
)
as


select 
	[MICertificationStatusType].[Id],
	[MICertificationStatusType].[Name],
	[MICertificationStatusType].[EnumeratedName],
	[MICertificationStatusType].[Description]
from 
	[MICertificationStatusType] 
where 
	[MICertificationStatusType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MICertificationStatusType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectMICertificationStatusTypes
as


select 
	[MICertificationStatusType].[Id],
	[MICertificationStatusType].[Name],
	[MICertificationStatusType].[EnumeratedName],
	[MICertificationStatusType].[Description]
from 
	[MICertificationStatusType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MICompanyNameType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectMICompanyNameType
(
@id SmallInt
)
as


select 
	[MICompanyNameType].[Id],
	[MICompanyNameType].[Name],
	[MICompanyNameType].[EnumeratedName],
	[MICompanyNameType].[Description]
from 
	[MICompanyNameType] 
where 
	[MICompanyNameType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MICompanyNameType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectMICompanyNameTypes
as


select 
	[MICompanyNameType].[Id],
	[MICompanyNameType].[Name],
	[MICompanyNameType].[EnumeratedName],
	[MICompanyNameType].[Description]
from 
	[MICompanyNameType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MaritalStatusType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectMaritalStatusType
(
@id SmallInt
)
as


select 
	[MaritalStatusType].[Id],
	[MaritalStatusType].[Name],
	[MaritalStatusType].[EnumeratedName],
	[MaritalStatusType].[Description]
from 
	[MaritalStatusType] 
where 
	[MaritalStatusType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MaritalStatusType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectMaritalStatusTypes
as


select 
	[MaritalStatusType].[Id],
	[MaritalStatusType].[Name],
	[MaritalStatusType].[EnumeratedName],
	[MaritalStatusType].[Description]
from 
	[MaritalStatusType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageHolderType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectMortgageHolderType
(
@id SmallInt
)
as


select 
	[MortgageHolderType].[Id],
	[MortgageHolderType].[Name],
	[MortgageHolderType].[EnumeratedName],
	[MortgageHolderType].[Description]
from 
	[MortgageHolderType] 
where 
	[MortgageHolderType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageHolderType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectMortgageHolderTypes
as


select 
	[MortgageHolderType].[Id],
	[MortgageHolderType].[Name],
	[MortgageHolderType].[EnumeratedName],
	[MortgageHolderType].[Description]
from 
	[MortgageHolderType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageScoreType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectMortgageScoreType
(
@id SmallInt
)
as


select 
	[MortgageScoreType].[Id],
	[MortgageScoreType].[Name],
	[MortgageScoreType].[EnumeratedName],
	[MortgageScoreType].[Description]
from 
	[MortgageScoreType] 
where 
	[MortgageScoreType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageScoreType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectMortgageScoreTypes
as


select 
	[MortgageScoreType].[Id],
	[MortgageScoreType].[Name],
	[MortgageScoreType].[EnumeratedName],
	[MortgageScoreType].[Description]
from 
	[MortgageScoreType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectMortgageType
(
@id SmallInt
)
as


select 
	[MortgageType].[Id],
	[MortgageType].[Name],
	[MortgageType].[EnumeratedName],
	[MortgageType].[Description]
from 
	[MortgageType] 
where 
	[MortgageType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectMortgageTypes
as


select 
	[MortgageType].[Id],
	[MortgageType].[Name],
	[MortgageType].[EnumeratedName],
	[MortgageType].[Description]
from 
	[MortgageType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: NameDocumentsDrawnInType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectNameDocumentsDrawnInType
(
@id SmallInt
)
as


select 
	[NameDocumentsDrawnInType].[Id],
	[NameDocumentsDrawnInType].[Name],
	[NameDocumentsDrawnInType].[EnumeratedName],
	[NameDocumentsDrawnInType].[Description]
from 
	[NameDocumentsDrawnInType] 
where 
	[NameDocumentsDrawnInType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: NameDocumentsDrawnInType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectNameDocumentsDrawnInTypes
as


select 
	[NameDocumentsDrawnInType].[Id],
	[NameDocumentsDrawnInType].[Name],
	[NameDocumentsDrawnInType].[EnumeratedName],
	[NameDocumentsDrawnInType].[Description]
from 
	[NameDocumentsDrawnInType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: NationalHousingActSectionType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectNationalHousingActSectionType
(
@id SmallInt
)
as


select 
	[NationalHousingActSectionType].[Id],
	[NationalHousingActSectionType].[Name],
	[NationalHousingActSectionType].[EnumeratedName],
	[NationalHousingActSectionType].[Description]
from 
	[NationalHousingActSectionType] 
where 
	[NationalHousingActSectionType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: NationalHousingActSectionType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectNationalHousingActSectionTypes
as


select 
	[NationalHousingActSectionType].[Id],
	[NationalHousingActSectionType].[Name],
	[NationalHousingActSectionType].[EnumeratedName],
	[NationalHousingActSectionType].[Description]
from 
	[NationalHousingActSectionType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PaymentFrequencyType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectPaymentFrequencyType
(
@id SmallInt
)
as


select 
	[PaymentFrequencyType].[Id],
	[PaymentFrequencyType].[Name],
	[PaymentFrequencyType].[EnumeratedName],
	[PaymentFrequencyType].[Description]
from 
	[PaymentFrequencyType] 
where 
	[PaymentFrequencyType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PaymentFrequencyType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectPaymentFrequencyTypes
as


select 
	[PaymentFrequencyType].[Id],
	[PaymentFrequencyType].[Name],
	[PaymentFrequencyType].[EnumeratedName],
	[PaymentFrequencyType].[Description]
from 
	[PaymentFrequencyType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PrintPositionType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectPrintPositionType
(
@id SmallInt
)
as


select 
	[PrintPositionType].[Id],
	[PrintPositionType].[Name],
	[PrintPositionType].[EnumeratedName],
	[PrintPositionType].[Description]
from 
	[PrintPositionType] 
where 
	[PrintPositionType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PrintPositionType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectPrintPositionTypes
as


select 
	[PrintPositionType].[Id],
	[PrintPositionType].[Name],
	[PrintPositionType].[EnumeratedName],
	[PrintPositionType].[Description]
from 
	[PrintPositionType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PriorPropertyTitleType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectPriorPropertyTitleType
(
@id SmallInt
)
as


select 
	[PriorPropertyTitleType].[Id],
	[PriorPropertyTitleType].[Name],
	[PriorPropertyTitleType].[EnumeratedName],
	[PriorPropertyTitleType].[Description]
from 
	[PriorPropertyTitleType] 
where 
	[PriorPropertyTitleType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PriorPropertyTitleType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectPriorPropertyTitleTypes
as


select 
	[PriorPropertyTitleType].[Id],
	[PriorPropertyTitleType].[Name],
	[PriorPropertyTitleType].[EnumeratedName],
	[PriorPropertyTitleType].[Description]
from 
	[PriorPropertyTitleType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PriorPropertyUsageType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectPriorPropertyUsageType
(
@id SmallInt
)
as


select 
	[PriorPropertyUsageType].[Id],
	[PriorPropertyUsageType].[Name],
	[PriorPropertyUsageType].[EnumeratedName],
	[PriorPropertyUsageType].[Description]
from 
	[PriorPropertyUsageType] 
where 
	[PriorPropertyUsageType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PriorPropertyUsageType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectPriorPropertyUsageTypes
as


select 
	[PriorPropertyUsageType].[Id],
	[PriorPropertyUsageType].[Name],
	[PriorPropertyUsageType].[EnumeratedName],
	[PriorPropertyUsageType].[Description]
from 
	[PriorPropertyUsageType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyRightsType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectPropertyRightsType
(
@id SmallInt
)
as


select 
	[PropertyRightsType].[Id],
	[PropertyRightsType].[Name],
	[PropertyRightsType].[EnumeratedName],
	[PropertyRightsType].[Description]
from 
	[PropertyRightsType] 
where 
	[PropertyRightsType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyRightsType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectPropertyRightsTypes
as


select 
	[PropertyRightsType].[Id],
	[PropertyRightsType].[Name],
	[PropertyRightsType].[EnumeratedName],
	[PropertyRightsType].[Description]
from 
	[PropertyRightsType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyUsageType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectPropertyUsageType
(
@id SmallInt
)
as


select 
	[PropertyUsageType].[Id],
	[PropertyUsageType].[Name],
	[PropertyUsageType].[EnumeratedName],
	[PropertyUsageType].[Description]
from 
	[PropertyUsageType] 
where 
	[PropertyUsageType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyUsageType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectPropertyUsageTypes
as


select 
	[PropertyUsageType].[Id],
	[PropertyUsageType].[Name],
	[PropertyUsageType].[EnumeratedName],
	[PropertyUsageType].[Description]
from 
	[PropertyUsageType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyValuationMethodType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectPropertyValuationMethodType
(
@id SmallInt
)
as


select 
	[PropertyValuationMethodType].[Id],
	[PropertyValuationMethodType].[Name],
	[PropertyValuationMethodType].[EnumeratedName],
	[PropertyValuationMethodType].[Description]
from 
	[PropertyValuationMethodType] 
where 
	[PropertyValuationMethodType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyValuationMethodType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectPropertyValuationMethodTypes
as


select 
	[PropertyValuationMethodType].[Id],
	[PropertyValuationMethodType].[Name],
	[PropertyValuationMethodType].[EnumeratedName],
	[PropertyValuationMethodType].[Description]
from 
	[PropertyValuationMethodType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurchaseCreditSourceType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectPurchaseCreditSourceType
(
@id SmallInt
)
as


select 
	[PurchaseCreditSourceType].[Id],
	[PurchaseCreditSourceType].[Name],
	[PurchaseCreditSourceType].[EnumeratedName],
	[PurchaseCreditSourceType].[Description]
from 
	[PurchaseCreditSourceType] 
where 
	[PurchaseCreditSourceType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurchaseCreditSourceType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectPurchaseCreditSourceTypes
as


select 
	[PurchaseCreditSourceType].[Id],
	[PurchaseCreditSourceType].[Name],
	[PurchaseCreditSourceType].[EnumeratedName],
	[PurchaseCreditSourceType].[Description]
from 
	[PurchaseCreditSourceType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurchaseCreditType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectPurchaseCreditType
(
@id SmallInt
)
as


select 
	[PurchaseCreditType].[Id],
	[PurchaseCreditType].[Name],
	[PurchaseCreditType].[EnumeratedName],
	[PurchaseCreditType].[Description]
from 
	[PurchaseCreditType] 
where 
	[PurchaseCreditType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurchaseCreditType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectPurchaseCreditTypes
as


select 
	[PurchaseCreditType].[Id],
	[PurchaseCreditType].[Name],
	[PurchaseCreditType].[EnumeratedName],
	[PurchaseCreditType].[Description]
from 
	[PurchaseCreditType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurposeType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectPurposeType
(
@id SmallInt
)
as


select 
	[PurposeType].[Id],
	[PurposeType].[Name],
	[PurposeType].[EnumeratedName],
	[PurposeType].[Description]
from 
	[PurposeType] 
where 
	[PurposeType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurposeType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectPurposeTypes
as


select 
	[PurposeType].[Id],
	[PurposeType].[Name],
	[PurposeType].[EnumeratedName],
	[PurposeType].[Description]
from 
	[PurposeType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: RaceNationalOriginType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectRaceNationalOriginType
(
@id SmallInt
)
as


select 
	[RaceNationalOriginType].[Id],
	[RaceNationalOriginType].[Name],
	[RaceNationalOriginType].[EnumeratedName],
	[RaceNationalOriginType].[Description]
from 
	[RaceNationalOriginType] 
where 
	[RaceNationalOriginType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RaceNationalOriginType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectRaceNationalOriginTypes
as


select 
	[RaceNationalOriginType].[Id],
	[RaceNationalOriginType].[Name],
	[RaceNationalOriginType].[EnumeratedName],
	[RaceNationalOriginType].[Description]
from 
	[RaceNationalOriginType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RateLockType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectRateLockType
(
@id SmallInt
)
as


select 
	[RateLockType].[Id],
	[RateLockType].[Name],
	[RateLockType].[EnumeratedName],
	[RateLockType].[Description]
from 
	[RateLockType] 
where 
	[RateLockType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RateLockType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectRateLockTypes
as


select 
	[RateLockType].[Id],
	[RateLockType].[Name],
	[RateLockType].[EnumeratedName],
	[RateLockType].[Description]
from 
	[RateLockType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RefinanceImprovementsType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectRefinanceImprovementsType
(
@id SmallInt
)
as


select 
	[RefinanceImprovementsType].[Id],
	[RefinanceImprovementsType].[Name],
	[RefinanceImprovementsType].[EnumeratedName],
	[RefinanceImprovementsType].[Description]
from 
	[RefinanceImprovementsType] 
where 
	[RefinanceImprovementsType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RefinanceImprovementsType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectRefinanceImprovementsTypes
as


select 
	[RefinanceImprovementsType].[Id],
	[RefinanceImprovementsType].[Name],
	[RefinanceImprovementsType].[EnumeratedName],
	[RefinanceImprovementsType].[Description]
from 
	[RefinanceImprovementsType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: ServicingTransferStatusType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectServicingTransferStatusType
(
@id SmallInt
)
as


select 
	[ServicingTransferStatusType].[Id],
	[ServicingTransferStatusType].[Name],
	[ServicingTransferStatusType].[EnumeratedName],
	[ServicingTransferStatusType].[Description]
from 
	[ServicingTransferStatusType] 
where 
	[ServicingTransferStatusType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: ServicingTransferStatusType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectServicingTransferStatusTypes
as


select 
	[ServicingTransferStatusType].[Id],
	[ServicingTransferStatusType].[Name],
	[ServicingTransferStatusType].[EnumeratedName],
	[ServicingTransferStatusType].[Description]
from 
	[ServicingTransferStatusType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: SummaryAmountType
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectSummaryAmountType
(
@id SmallInt
)
as


select 
	[SummaryAmountType].[Id],
	[SummaryAmountType].[Name],
	[SummaryAmountType].[EnumeratedName],
	[SummaryAmountType].[Description]
from 
	[SummaryAmountType] 
where 
	[SummaryAmountType].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: SummaryAmountType
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectSummaryAmountTypes
as


select 
	[SummaryAmountType].[Id],
	[SummaryAmountType].[Name],
	[SummaryAmountType].[EnumeratedName],
	[SummaryAmountType].[Description]
from 
	[SummaryAmountType] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: ApplicationMethod
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateApplicationMethod
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [ApplicationMethod] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: APPRAISER
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateAppraiser
(
@name VarChar(64) = null,
@companyName VarChar(64) = null,
@licenseIdentifier VarChar(64) = null,
@licenseState VarChar(64) = null,
@id Int
)
as


-- persist the data via an update
update [APPRAISER] set 
	[Name] = @name,
	[CompanyName] = @companyName,
	[LicenseIdentifier] = @licenseIdentifier,
	[LicenseState] = @licenseState
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: AssetType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateAssetType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [AssetType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: BaseDataType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateBaseDataType
(
@name VarChar(64) = null,
@enumeratedName VarChar(64) = null,
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [BaseDataType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BorrowerResidencyBasisType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateBorrowerResidencyBasisType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [BorrowerResidencyBasisType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BorrowerResidencyType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateBorrowerResidencyType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [BorrowerResidencyType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BuildingStatusType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateBuildingStatusType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [BuildingStatusType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CaseStateType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateCaseStateType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [CaseStateType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CitizenshipResidencyType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateCitizenshipResidencyType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [CitizenshipResidencyType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: ConstructionPurposeType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateConstructionPurposeType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [ConstructionPurposeType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContactPointRoleType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateContactPointRoleType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [ContactPointRoleType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContactPointType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateContactPointType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [ContactPointType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: ContributorType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateContributorType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [ContributorType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditRepositorySourceType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateCreditRepositorySourceType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [CreditRepositorySourceType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditScoreExclusionReasonType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateCreditScoreExclusionReasonType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(128) = null,
@id SmallInt
)
as


-- persist the data via an update
update [CreditScoreExclusionReasonType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CreditScoreModelNameType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateCreditScoreModelNameType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [CreditScoreModelNameType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DispositionStatusType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateDispositionStatusType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [DispositionStatusType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: DownPaymentType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateDownPaymentType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [DownPaymentType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: ExplanationType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateExplanationType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [ExplanationType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHAAlimonyLiabilityTreatmentType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateFHAAlimonyLiabilityTreatmentType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [FHAAlimonyLiabilityTreatmentType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FNMCommunityLendingProductType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateFNMCommunityLendingProductType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [FNMCommunityLendingProductType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:44 AM
System User: marlon
System Machine: SERVER
Entity Name: FNMCreditReportScoreType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateFNMCreditReportScoreType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [FNMCreditReportScoreType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:44 AM
System User: marlon
System Machine: SERVER
Entity Name: FullPrepaymentPenaltyOptionType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateFullPrepaymentPenaltyOptionType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [FullPrepaymentPenaltyOptionType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GSEProjectClassificationType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateGSEProjectClassificationType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [GSEProjectClassificationType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GSEPropertyType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateGSEPropertyType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [GSEPropertyType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: GSERefinancePurposeType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateGSERefinancePurposeType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [GSERefinancePurposeType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GenderType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateGenderType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [GenderType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GovernmentRefinanceType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateGovernmentRefinanceType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [GovernmentRefinanceType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAEthnicityType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateHMDAEthnicityType
(
@name VarChar(100),
@enumeratedName VarChar(100),
@description Text = null,
@id SmallInt
)
as


-- persist the data via an update
update [HMDAEthnicityType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAPreapprovalType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateHMDAPreapprovalType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [HMDAPreapprovalType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDAPurposeOfLoanType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateHMDAPurposeOfLoanType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [HMDAPurposeOfLoanType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDARaceType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateHMDARaceType
(
@name VarChar(100),
@enumeratedName VarChar(100),
@description Text = null,
@id SmallInt
)
as


-- persist the data via an update
update [HMDARaceType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:48 AM
System User: marlon
System Machine: SERVER
Entity Name: HousingExpenseType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateHousingExpenseType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [HousingExpenseType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: IncomeType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateIncomeType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [IncomeType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: InterestRateIndex
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateInterestRateIndex
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [InterestRateIndex] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: JointAssetLiabilityReportingType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateJointAssetLiabilityReportingType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [JointAssetLiabilityReportingType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:50 AM
System User: marlon
System Machine: SERVER
Entity Name: LandTrustType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLandTrustType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [LandTrustType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LegalType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLegalType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description Text = null,
@id SmallInt
)
as


-- persist the data via an update
update [LegalType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LiabilityType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLiabilityType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description Text = null,
@id SmallInt
)
as


-- persist the data via an update
update [LiabilityType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LienPriorityType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLienPriorityType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [LienPriorityType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanAmortizationType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLoanAmortizationType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [LoanAmortizationType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_APPLICATION
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLoanApplication
(
@mISMOVersionID VarChar(64) = null,
@id BigInt
)
as


-- persist the data via an update
update [LOAN_APPLICATION] set 
	[MISMOVersionID] = @mISMOVersionID
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanClosingStatusType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLoanClosingStatusType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [LoanClosingStatusType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanDocumentationType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLoanDocumentationType
(
@name VarChar(80),
@enumeratedName VarChar(80),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [LoanDocumentationType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: LoanRepaymentType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLoanRepaymentType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [LoanRepaymentType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MICertificationStatusType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateMICertificationStatusType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [MICertificationStatusType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MICompanyNameType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateMICompanyNameType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [MICompanyNameType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MaritalStatusType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateMaritalStatusType
(
@name VarChar(64) = null,
@enumeratedName VarChar(64) = null,
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [MaritalStatusType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageHolderType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateMortgageHolderType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [MortgageHolderType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageScoreType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateMortgageScoreType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [MortgageScoreType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MortgageType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateMortgageType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [MortgageType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: NameDocumentsDrawnInType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateNameDocumentsDrawnInType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [NameDocumentsDrawnInType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: NationalHousingActSectionType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateNationalHousingActSectionType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description Text = null,
@id SmallInt
)
as


-- persist the data via an update
update [NationalHousingActSectionType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PaymentFrequencyType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdatePaymentFrequencyType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [PaymentFrequencyType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PrintPositionType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdatePrintPositionType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [PrintPositionType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PriorPropertyTitleType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdatePriorPropertyTitleType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [PriorPropertyTitleType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PriorPropertyUsageType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdatePriorPropertyUsageType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [PriorPropertyUsageType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyRightsType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdatePropertyRightsType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [PropertyRightsType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyUsageType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdatePropertyUsageType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [PropertyUsageType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PropertyValuationMethodType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdatePropertyValuationMethodType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [PropertyValuationMethodType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurchaseCreditSourceType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdatePurchaseCreditSourceType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [PurchaseCreditSourceType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurchaseCreditType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdatePurchaseCreditType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [PurchaseCreditType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PurposeType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdatePurposeType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [PurposeType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: RaceNationalOriginType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateRaceNationalOriginType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description Text = null,
@id SmallInt
)
as


-- persist the data via an update
update [RaceNationalOriginType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RateLockType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateRateLockType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [RateLockType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RefinanceImprovementsType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateRefinanceImprovementsType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [RefinanceImprovementsType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: ServicingTransferStatusType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateServicingTransferStatusType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [ServicingTransferStatusType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: SummaryAmountType
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateSummaryAmountType
(
@name VarChar(64),
@enumeratedName VarChar(64),
@description VarChar(254) = null,
@id SmallInt
)
as


-- persist the data via an update
update [SummaryAmountType] set 
	[Id] = @id,
	[Name] = @name,
	[EnumeratedName] = @enumeratedName,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:33 AM
System User: marlon
System Machine: SERVER
Entity Name: BORROWER
Entity Type: Table
Description: A GetBySSN select service stored procedure.

*/
CREATE PROCEDURE gsp_BorrowersGetBySSN
(
@sSN VarChar(64) = null
)
as


select 
	[BORROWER].[Id],
	[BORROWER].[JointAssetBorrowerID],
	[BORROWER].[LoanApplicationId],
	[BORROWER].[FirstName],
	[BORROWER].[MiddleName],
	[BORROWER].[LastName],
	[BORROWER].[NameSuffix],
	[BORROWER].[AgeAtApplicationYears],
	[BORROWER].[BirthDate],
	[BORROWER].[ApplicationSignedDate],
	[BORROWER].[HomeTelephoneNumber],
	[BORROWER].[SSN],
	[BORROWER].[DependentCount],
	[BORROWER].[SchoolingYears],
	[BORROWER].[CreditReportIdentifier],
	[BORROWER].[MaritalStatusType],
	[BORROWER].[PrintPositionType],
	[BORROWER].[JointAssetLiabilityReportingType]
from 
	[BORROWER] 
where 
	[BORROWER].[SSN] = @sSN
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:29 AM
System User: marlon
System Machine: SERVER
Entity Name: ADDITIONAL_CASE_DATA
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateAdditionalCaseData
(
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [ADDITIONAL_CASE_DATA]
	(
	[LoanApplicationId]
	) values 
	(
	@loanApplicationId
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: AFFORDABLE_LENDING
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateAffordableLending
(
@fNMCommunityLendingProductName VarChar(64) = null,
@fNMCommunityLendingProductTypeOtherDescription VarChar(64) = null,
@fNMCommunitySecondsIndicator Bit,
@fNMNeighborsMortgageEligibilityIndicator Bit,
@fREAffordableProgramIdentifier VarChar(64) = null,
@hUDIncomeLimitAdjustmentFactor Decimal(18,0) = null,
@hUDLendingIncomeLimitAmount Money = null,
@hUDMedianIncomeAmount Money = null,
@mSAIdentifier VarChar(64) = null,
@fNMCommunityLendingProductType SmallInt = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [AFFORDABLE_LENDING]
	(
	[LoanApplicationId],
	[FNMCommunityLendingProductName],
	[FNMCommunityLendingProductTypeOtherDescription],
	[FNMCommunitySecondsIndicator],
	[FNMNeighborsMortgageEligibilityIndicator],
	[FREAffordableProgramIdentifier],
	[HUDIncomeLimitAdjustmentFactor],
	[HUDLendingIncomeLimitAmount],
	[HUDMedianIncomeAmount],
	[MSAIdentifier],
	[FNMCommunityLendingProductType]
	) values 
	(
	@loanApplicationId,
	@fNMCommunityLendingProductName,
	@fNMCommunityLendingProductTypeOtherDescription,
	@fNMCommunitySecondsIndicator,
	@fNMNeighborsMortgageEligibilityIndicator,
	@fREAffordableProgramIdentifier,
	@hUDIncomeLimitAdjustmentFactor,
	@hUDLendingIncomeLimitAmount,
	@hUDMedianIncomeAmount,
	@mSAIdentifier,
	@fNMCommunityLendingProductType
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: BORROWER
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateBorrower
(
@jointAssetBorrowerID BigInt = null,
@loanApplicationId BigInt = null,
@firstName VarChar(64) = null,
@middleName VarChar(64) = null,
@lastName VarChar(64) = null,
@nameSuffix VarChar(64) = null,
@ageAtApplicationYears Decimal(18,0) = null,
@birthDate DateTime = null,
@applicationSignedDate DateTime = null,
@homeTelephoneNumber VarChar(64) = null,
@sSN VarChar(64) = null,
@dependentCount TinyInt = null,
@schoolingYears Decimal(18,0) = null,
@creditReportIdentifier VarChar(64) = null,
@maritalStatusType SmallInt = null,
@printPositionType SmallInt = null,
@jointAssetLiabilityReportingType SmallInt = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [BORROWER]
	(
	[JointAssetBorrowerID],
	[LoanApplicationId],
	[FirstName],
	[MiddleName],
	[LastName],
	[NameSuffix],
	[AgeAtApplicationYears],
	[BirthDate],
	[ApplicationSignedDate],
	[HomeTelephoneNumber],
	[SSN],
	[DependentCount],
	[SchoolingYears],
	[CreditReportIdentifier],
	[MaritalStatusType],
	[PrintPositionType],
	[JointAssetLiabilityReportingType]
	) values 
	(
	@jointAssetBorrowerID,
	@loanApplicationId,
	@firstName,
	@middleName,
	@lastName,
	@nameSuffix,
	@ageAtApplicationYears,
	@birthDate,
	@applicationSignedDate,
	@homeTelephoneNumber,
	@sSN,
	@dependentCount,
	@schoolingYears,
	@creditReportIdentifier,
	@maritalStatusType,
	@printPositionType,
	@jointAssetLiabilityReportingType
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: DATA_INFORMATION
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateDataInformation
(
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [DATA_INFORMATION]
	(
	[LoanApplicationId]
	) values 
	(
	@loanApplicationId
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DOWN_PAYMENT
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateDownPayment
(
@loanApplicationId BigInt,
@amount Money,
@sourceDescription VarChar(64) = null,
@type SmallInt = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [DOWN_PAYMENT]
	(
	[LoanApplicationId],
	[Amount],
	[SourceDescription],
	[Type]
	) values 
	(
	@loanApplicationId,
	@amount,
	@sourceDescription,
	@type
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_LOAN
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateGovernmentLoan
(
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [GOVERNMENT_LOAN]
	(
	[LoanApplicationId]
	) values 
	(
	@loanApplicationId
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_REPORTING
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateGovernmentReporting
(
@hMDAPurposeOfLoanType SmallInt = null,
@hMDAPreapprovalType SmallInt = null,
@hMDA_HOEPALoanStatusIndicator Bit,
@hMDARateSpreadPercent Decimal(8,7) = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [GOVERNMENT_REPORTING]
	(
	[LoanApplicationId],
	[HMDAPurposeOfLoanType],
	[HMDAPreapprovalType],
	[HMDA_HOEPALoanStatusIndicator],
	[HMDARateSpreadPercent]
	) values 
	(
	@loanApplicationId,
	@hMDAPurposeOfLoanType,
	@hMDAPreapprovalType,
	@hMDA_HOEPALoanStatusIndicator,
	@hMDARateSpreadPercent
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: INTERVIEWER_INFORMATION
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateInterviewerInformation
(
@interviewersEmployerStreetAddress VarChar(128) = null,
@interviewersEmployerCity VarChar(64) = null,
@interviewersEmployerState VarChar(64) = null,
@interviewersEmployerPostalCode VarChar(16) = null,
@interviewersTelephoneNumber VarChar(32) = null,
@applicationTakenMethodType SmallInt = null,
@interviewerApplicationSignedDate DateTime = null,
@interviewersEmployerName VarChar(128) = null,
@interviewersName VarChar(128) = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [INTERVIEWER_INFORMATION]
	(
	[LoanApplicationId],
	[InterviewersEmployerStreetAddress],
	[InterviewersEmployerCity],
	[InterviewersEmployerState],
	[InterviewersEmployerPostalCode],
	[InterviewersTelephoneNumber],
	[ApplicationTakenMethodType],
	[InterviewerApplicationSignedDate],
	[InterviewersEmployerName],
	[InterviewersName]
	) values 
	(
	@loanApplicationId,
	@interviewersEmployerStreetAddress,
	@interviewersEmployerCity,
	@interviewersEmployerState,
	@interviewersEmployerPostalCode,
	@interviewersTelephoneNumber,
	@applicationTakenMethodType,
	@interviewerApplicationSignedDate,
	@interviewersEmployerName,
	@interviewersName
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PRODUCT_DATA
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLoanProductData
(
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LOAN_PRODUCT_DATA]
	(
	[LoanApplicationId]
	) values 
	(
	@loanApplicationId
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PURPOSE
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLoanPurpose
(
@gSETitleMannerHeldDescription VarChar(254) = null,
@otherLoanPurposeDescription VarChar(254) = null,
@propertyLeaseholdExpirationDate DateTime = null,
@propertyUsageType SmallInt = null,
@propertyRightsType SmallInt = null,
@type SmallInt = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LOAN_PURPOSE]
	(
	[LoanApplicationId],
	[GSETitleMannerHeldDescription],
	[OtherLoanPurposeDescription],
	[PropertyLeaseholdExpirationDate],
	[PropertyUsageType],
	[PropertyRightsType],
	[Type]
	) values 
	(
	@loanApplicationId,
	@gSETitleMannerHeldDescription,
	@otherLoanPurposeDescription,
	@propertyLeaseholdExpirationDate,
	@propertyUsageType,
	@propertyRightsType,
	@type
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_QUALIFICATION
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLoanQualification
(
@additionalBorrowerAssetsNotConsideredIndicator Bit,
@additionalBorrowerAssetsConsideredIndicator Bit,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LOAN_QUALIFICATION]
	(
	[LoanApplicationId],
	[AdditionalBorrowerAssetsNotConsideredIndicator],
	[AdditionalBorrowerAssetsConsideredIndicator]
	) values 
	(
	@loanApplicationId,
	@additionalBorrowerAssetsNotConsideredIndicator,
	@additionalBorrowerAssetsConsideredIndicator
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:57 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_TERMS
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateMortgageTerms
(
@agencyCaseIdentifier VarChar(64) = null,
@aRMTypeDescription VarChar(254) = null,
@baseLoanAmount Money = null,
@borrowerRequestedLoanAmount Money = null,
@lenderCaseIdentifier VarChar(64) = null,
@loanAmortizationTermMonths Decimal(18,0) = null,
@otherMortgageTypeDescription VarChar(254) = null,
@otherAmortizationTypeDescription VarChar(254) = null,
@requestedInterestRatePercent Decimal(8,7) = null,
@loanAmortizationType SmallInt = null,
@mortgageType SmallInt = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [MORTGAGE_TERMS]
	(
	[LoanApplicationId],
	[AgencyCaseIdentifier],
	[ARMTypeDescription],
	[BaseLoanAmount],
	[BorrowerRequestedLoanAmount],
	[LenderCaseIdentifier],
	[LoanAmortizationTermMonths],
	[OtherMortgageTypeDescription],
	[OtherAmortizationTypeDescription],
	[RequestedInterestRatePercent],
	[LoanAmortizationType],
	[MortgageType]
	) values 
	(
	@loanApplicationId,
	@agencyCaseIdentifier,
	@aRMTypeDescription,
	@baseLoanAmount,
	@borrowerRequestedLoanAmount,
	@lenderCaseIdentifier,
	@loanAmortizationTermMonths,
	@otherMortgageTypeDescription,
	@otherAmortizationTypeDescription,
	@requestedInterestRatePercent,
	@loanAmortizationType,
	@mortgageType
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPERTY
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateProperty
(
@streetAddress VarChar(128) = null,
@streetAddress2 VarChar(128) = null,
@city VarChar(64) = null,
@state VarChar(64) = null,
@county VarChar(64) = null,
@postalCode VarChar(16) = null,
@financedNumberOfUnits Int = null,
@structureBuiltYear DateTime = null,
@acquiredDate DateTime = null,
@plannedUnitDevelopmentIndicator Bit,
@acreageNumber Decimal(18,0) = null,
@buildingStatusType SmallInt = null,
@gSEPropertyType SmallInt = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PROPERTY]
	(
	[LoanApplicationId],
	[StreetAddress],
	[StreetAddress2],
	[City],
	[State],
	[County],
	[PostalCode],
	[FinancedNumberOfUnits],
	[StructureBuiltYear],
	[AcquiredDate],
	[PlannedUnitDevelopmentIndicator],
	[AcreageNumber],
	[BuildingStatusType],
	[GSEPropertyType]
	) values 
	(
	@loanApplicationId,
	@streetAddress,
	@streetAddress2,
	@city,
	@state,
	@county,
	@postalCode,
	@financedNumberOfUnits,
	@structureBuiltYear,
	@acquiredDate,
	@plannedUnitDevelopmentIndicator,
	@acreageNumber,
	@buildingStatusType,
	@gSEPropertyType
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPOSED_HOUSING_EXPENSE
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateProposedHousingExpense
(
@loanApplicationId BigInt,
@paymentAmount Money,
@housingExpenseType SmallInt
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PROPOSED_HOUSING_EXPENSE]
	(
	[LoanApplicationId],
	[PaymentAmount],
	[HousingExpenseType]
	) values 
	(
	@loanApplicationId,
	@paymentAmount,
	@housingExpenseType
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: TITLE_HOLDER
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateTitleHolder
(
@loanApplicationId BigInt,
@name VarChar(128) = null,
@landTrustType SmallInt = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [TITLE_HOLDER]
	(
	[LoanApplicationId],
	[Name],
	[LandTrustType]
	) values 
	(
	@loanApplicationId,
	@name,
	@landTrustType
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:07 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSACTION_DETAIL
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateTransactionDetail
(
@alterationsImprovementsAndRepairsAmount Money = null,
@borrowerPaidDiscountPointsTotalAmount Money = null,
@estimatedClosingCostsAmount Money = null,
@mIAndFundingFeeFinancedAmount Money = null,
@mIAndFundingFeeTotalAmount Money = null,
@prepaidItemsEstimatedAmount Money = null,
@purchasePriceAmount Money = null,
@refinanceIncludingDebtsToBePaidOffAmount Money = null,
@salesConcessionAmount Money = null,
@sellerPaidClosingCostsAmount Money = null,
@subordinateLienAmount Money = null,
@subordinateLienHELOCAmount Money = null,
@fREReserveAmount Money = null,
@fREReservesAmount Money = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [TRANSACTION_DETAIL]
	(
	[LoanApplicationId],
	[AlterationsImprovementsAndRepairsAmount],
	[BorrowerPaidDiscountPointsTotalAmount],
	[EstimatedClosingCostsAmount],
	[MIAndFundingFeeFinancedAmount],
	[MIAndFundingFeeTotalAmount],
	[PrepaidItemsEstimatedAmount],
	[PurchasePriceAmount],
	[RefinanceIncludingDebtsToBePaidOffAmount],
	[SalesConcessionAmount],
	[SellerPaidClosingCostsAmount],
	[SubordinateLienAmount],
	[SubordinateLienHELOCAmount],
	[FREReserveAmount],
	[FREReservesAmount]
	) values 
	(
	@loanApplicationId,
	@alterationsImprovementsAndRepairsAmount,
	@borrowerPaidDiscountPointsTotalAmount,
	@estimatedClosingCostsAmount,
	@mIAndFundingFeeFinancedAmount,
	@mIAndFundingFeeTotalAmount,
	@prepaidItemsEstimatedAmount,
	@purchasePriceAmount,
	@refinanceIncludingDebtsToBePaidOffAmount,
	@salesConcessionAmount,
	@sellerPaidClosingCostsAmount,
	@subordinateLienAmount,
	@subordinateLienHELOCAmount,
	@fREReserveAmount,
	@fREReservesAmount
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: ADDITIONAL_CASE_DATA
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteAdditionalCaseData
(
@loanApplicationId BigInt
)
as


delete from [ADDITIONAL_CASE_DATA] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: AFFORDABLE_LENDING
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteAffordableLending
(
@loanApplicationId BigInt
)
as


delete from [AFFORDABLE_LENDING] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: BORROWER
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteBorrower
(
@id BigInt
)
as


delete from [BORROWER] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: DATA_INFORMATION
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteDataInformation
(
@loanApplicationId BigInt
)
as


delete from [DATA_INFORMATION] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DOWN_PAYMENT
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteDownPayment
(
@id BigInt
)
as


delete from [DOWN_PAYMENT] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_LOAN
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteGovernmentLoan
(
@loanApplicationId BigInt
)
as


delete from [GOVERNMENT_LOAN] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_REPORTING
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteGovernmentReporting
(
@loanApplicationId BigInt
)
as


delete from [GOVERNMENT_REPORTING] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: INTERVIEWER_INFORMATION
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteInterviewerInformation
(
@loanApplicationId BigInt
)
as


delete from [INTERVIEWER_INFORMATION] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PRODUCT_DATA
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLoanProductData
(
@loanApplicationId BigInt
)
as


delete from [LOAN_PRODUCT_DATA] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PURPOSE
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLoanPurpose
(
@loanApplicationId BigInt
)
as


delete from [LOAN_PURPOSE] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_QUALIFICATION
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLoanQualification
(
@loanApplicationId BigInt
)
as


delete from [LOAN_QUALIFICATION] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:57 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_TERMS
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteMortgageTerms
(
@loanApplicationId BigInt
)
as


delete from [MORTGAGE_TERMS] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPERTY
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteProperty
(
@loanApplicationId BigInt
)
as


delete from [PROPERTY] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPOSED_HOUSING_EXPENSE
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteProposedHousingExpense
(
@id BigInt
)
as


delete from [PROPOSED_HOUSING_EXPENSE] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: TITLE_HOLDER
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteTitleHolder
(
@id BigInt
)
as


delete from [TITLE_HOLDER] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:07 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSACTION_DETAIL
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteTransactionDetail
(
@loanApplicationId BigInt
)
as


delete from [TRANSACTION_DETAIL] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: ADDITIONAL_CASE_DATA
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectAdditionalCaseData
(
@loanApplicationId BigInt
)
as


select 
	[ADDITIONAL_CASE_DATA].[LoanApplicationId]
from 
	[ADDITIONAL_CASE_DATA] 
where 
	[ADDITIONAL_CASE_DATA].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: ADDITIONAL_CASE_DATA
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectAdditionalCaseDataCollection
as


select 
	[ADDITIONAL_CASE_DATA].[LoanApplicationId]
from 
	[ADDITIONAL_CASE_DATA] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: ADDITIONAL_CASE_DATA
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectAdditionalCaseDataCollectionByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[ADDITIONAL_CASE_DATA].[LoanApplicationId]
from 
	[ADDITIONAL_CASE_DATA] 
where 
	[ADDITIONAL_CASE_DATA].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: AFFORDABLE_LENDING
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectAffordableLending
(
@loanApplicationId BigInt
)
as


select 
	[AFFORDABLE_LENDING].[LoanApplicationId],
	[AFFORDABLE_LENDING].[FNMCommunityLendingProductName],
	[AFFORDABLE_LENDING].[FNMCommunityLendingProductTypeOtherDescription],
	[AFFORDABLE_LENDING].[FNMCommunitySecondsIndicator],
	[AFFORDABLE_LENDING].[FNMNeighborsMortgageEligibilityIndicator],
	[AFFORDABLE_LENDING].[FREAffordableProgramIdentifier],
	[AFFORDABLE_LENDING].[HUDIncomeLimitAdjustmentFactor],
	[AFFORDABLE_LENDING].[HUDLendingIncomeLimitAmount],
	[AFFORDABLE_LENDING].[HUDMedianIncomeAmount],
	[AFFORDABLE_LENDING].[MSAIdentifier],
	[AFFORDABLE_LENDING].[FNMCommunityLendingProductType]
from 
	[AFFORDABLE_LENDING] 
where 
	[AFFORDABLE_LENDING].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: AFFORDABLE_LENDING
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectAffordableLendingCollection
as


select 
	[AFFORDABLE_LENDING].[LoanApplicationId],
	[AFFORDABLE_LENDING].[FNMCommunityLendingProductName],
	[AFFORDABLE_LENDING].[FNMCommunityLendingProductTypeOtherDescription],
	[AFFORDABLE_LENDING].[FNMCommunitySecondsIndicator],
	[AFFORDABLE_LENDING].[FNMNeighborsMortgageEligibilityIndicator],
	[AFFORDABLE_LENDING].[FREAffordableProgramIdentifier],
	[AFFORDABLE_LENDING].[HUDIncomeLimitAdjustmentFactor],
	[AFFORDABLE_LENDING].[HUDLendingIncomeLimitAmount],
	[AFFORDABLE_LENDING].[HUDMedianIncomeAmount],
	[AFFORDABLE_LENDING].[MSAIdentifier],
	[AFFORDABLE_LENDING].[FNMCommunityLendingProductType]
from 
	[AFFORDABLE_LENDING] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: AFFORDABLE_LENDING
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectAffordableLendingCollectionByFNMCommunityLendingProductType
(
@fNMCommunityLendingProductType SmallInt = null
)
as


select 
	[AFFORDABLE_LENDING].[LoanApplicationId],
	[AFFORDABLE_LENDING].[FNMCommunityLendingProductName],
	[AFFORDABLE_LENDING].[FNMCommunityLendingProductTypeOtherDescription],
	[AFFORDABLE_LENDING].[FNMCommunitySecondsIndicator],
	[AFFORDABLE_LENDING].[FNMNeighborsMortgageEligibilityIndicator],
	[AFFORDABLE_LENDING].[FREAffordableProgramIdentifier],
	[AFFORDABLE_LENDING].[HUDIncomeLimitAdjustmentFactor],
	[AFFORDABLE_LENDING].[HUDLendingIncomeLimitAmount],
	[AFFORDABLE_LENDING].[HUDMedianIncomeAmount],
	[AFFORDABLE_LENDING].[MSAIdentifier],
	[AFFORDABLE_LENDING].[FNMCommunityLendingProductType]
from 
	[AFFORDABLE_LENDING] 
where 
	[AFFORDABLE_LENDING].[FNMCommunityLendingProductType] = @fNMCommunityLendingProductType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: AFFORDABLE_LENDING
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectAffordableLendingCollectionByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[AFFORDABLE_LENDING].[LoanApplicationId],
	[AFFORDABLE_LENDING].[FNMCommunityLendingProductName],
	[AFFORDABLE_LENDING].[FNMCommunityLendingProductTypeOtherDescription],
	[AFFORDABLE_LENDING].[FNMCommunitySecondsIndicator],
	[AFFORDABLE_LENDING].[FNMNeighborsMortgageEligibilityIndicator],
	[AFFORDABLE_LENDING].[FREAffordableProgramIdentifier],
	[AFFORDABLE_LENDING].[HUDIncomeLimitAdjustmentFactor],
	[AFFORDABLE_LENDING].[HUDLendingIncomeLimitAmount],
	[AFFORDABLE_LENDING].[HUDMedianIncomeAmount],
	[AFFORDABLE_LENDING].[MSAIdentifier],
	[AFFORDABLE_LENDING].[FNMCommunityLendingProductType]
from 
	[AFFORDABLE_LENDING] 
where 
	[AFFORDABLE_LENDING].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:33 AM
System User: marlon
System Machine: SERVER
Entity Name: BORROWER
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectBorrower
(
@id BigInt
)
as


select 
	[BORROWER].[Id],
	[BORROWER].[JointAssetBorrowerID],
	[BORROWER].[LoanApplicationId],
	[BORROWER].[FirstName],
	[BORROWER].[MiddleName],
	[BORROWER].[LastName],
	[BORROWER].[NameSuffix],
	[BORROWER].[AgeAtApplicationYears],
	[BORROWER].[BirthDate],
	[BORROWER].[ApplicationSignedDate],
	[BORROWER].[HomeTelephoneNumber],
	[BORROWER].[SSN],
	[BORROWER].[DependentCount],
	[BORROWER].[SchoolingYears],
	[BORROWER].[CreditReportIdentifier],
	[BORROWER].[MaritalStatusType],
	[BORROWER].[PrintPositionType],
	[BORROWER].[JointAssetLiabilityReportingType]
from 
	[BORROWER] 
where 
	[BORROWER].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:33 AM
System User: marlon
System Machine: SERVER
Entity Name: BORROWER
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectBorrowers
as


select 
	[BORROWER].[Id],
	[BORROWER].[JointAssetBorrowerID],
	[BORROWER].[LoanApplicationId],
	[BORROWER].[FirstName],
	[BORROWER].[MiddleName],
	[BORROWER].[LastName],
	[BORROWER].[NameSuffix],
	[BORROWER].[AgeAtApplicationYears],
	[BORROWER].[BirthDate],
	[BORROWER].[ApplicationSignedDate],
	[BORROWER].[HomeTelephoneNumber],
	[BORROWER].[SSN],
	[BORROWER].[DependentCount],
	[BORROWER].[SchoolingYears],
	[BORROWER].[CreditReportIdentifier],
	[BORROWER].[MaritalStatusType],
	[BORROWER].[PrintPositionType],
	[BORROWER].[JointAssetLiabilityReportingType]
from 
	[BORROWER] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:33 AM
System User: marlon
System Machine: SERVER
Entity Name: BORROWER
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectBorrowersByBorrower
(
@jointAssetBorrowerID BigInt = null
)
as


select 
	[BORROWER].[Id],
	[BORROWER].[JointAssetBorrowerID],
	[BORROWER].[LoanApplicationId],
	[BORROWER].[FirstName],
	[BORROWER].[MiddleName],
	[BORROWER].[LastName],
	[BORROWER].[NameSuffix],
	[BORROWER].[AgeAtApplicationYears],
	[BORROWER].[BirthDate],
	[BORROWER].[ApplicationSignedDate],
	[BORROWER].[HomeTelephoneNumber],
	[BORROWER].[SSN],
	[BORROWER].[DependentCount],
	[BORROWER].[SchoolingYears],
	[BORROWER].[CreditReportIdentifier],
	[BORROWER].[MaritalStatusType],
	[BORROWER].[PrintPositionType],
	[BORROWER].[JointAssetLiabilityReportingType]
from 
	[BORROWER] 
where 
	[BORROWER].[JointAssetBorrowerID] = @jointAssetBorrowerID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:33 AM
System User: marlon
System Machine: SERVER
Entity Name: BORROWER
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectBorrowersByJointAssetLiabilityReportingType
(
@jointAssetLiabilityReportingType SmallInt = null
)
as


select 
	[BORROWER].[Id],
	[BORROWER].[JointAssetBorrowerID],
	[BORROWER].[LoanApplicationId],
	[BORROWER].[FirstName],
	[BORROWER].[MiddleName],
	[BORROWER].[LastName],
	[BORROWER].[NameSuffix],
	[BORROWER].[AgeAtApplicationYears],
	[BORROWER].[BirthDate],
	[BORROWER].[ApplicationSignedDate],
	[BORROWER].[HomeTelephoneNumber],
	[BORROWER].[SSN],
	[BORROWER].[DependentCount],
	[BORROWER].[SchoolingYears],
	[BORROWER].[CreditReportIdentifier],
	[BORROWER].[MaritalStatusType],
	[BORROWER].[PrintPositionType],
	[BORROWER].[JointAssetLiabilityReportingType]
from 
	[BORROWER] 
where 
	[BORROWER].[JointAssetLiabilityReportingType] = @jointAssetLiabilityReportingType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:33 AM
System User: marlon
System Machine: SERVER
Entity Name: BORROWER
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectBorrowersByLoanApplication
(
@loanApplicationId BigInt = null
)
as


select 
	[BORROWER].[Id],
	[BORROWER].[JointAssetBorrowerID],
	[BORROWER].[LoanApplicationId],
	[BORROWER].[FirstName],
	[BORROWER].[MiddleName],
	[BORROWER].[LastName],
	[BORROWER].[NameSuffix],
	[BORROWER].[AgeAtApplicationYears],
	[BORROWER].[BirthDate],
	[BORROWER].[ApplicationSignedDate],
	[BORROWER].[HomeTelephoneNumber],
	[BORROWER].[SSN],
	[BORROWER].[DependentCount],
	[BORROWER].[SchoolingYears],
	[BORROWER].[CreditReportIdentifier],
	[BORROWER].[MaritalStatusType],
	[BORROWER].[PrintPositionType],
	[BORROWER].[JointAssetLiabilityReportingType]
from 
	[BORROWER] 
where 
	[BORROWER].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:33 AM
System User: marlon
System Machine: SERVER
Entity Name: BORROWER
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectBorrowersByMaritalStatusType
(
@maritalStatusType SmallInt = null
)
as


select 
	[BORROWER].[Id],
	[BORROWER].[JointAssetBorrowerID],
	[BORROWER].[LoanApplicationId],
	[BORROWER].[FirstName],
	[BORROWER].[MiddleName],
	[BORROWER].[LastName],
	[BORROWER].[NameSuffix],
	[BORROWER].[AgeAtApplicationYears],
	[BORROWER].[BirthDate],
	[BORROWER].[ApplicationSignedDate],
	[BORROWER].[HomeTelephoneNumber],
	[BORROWER].[SSN],
	[BORROWER].[DependentCount],
	[BORROWER].[SchoolingYears],
	[BORROWER].[CreditReportIdentifier],
	[BORROWER].[MaritalStatusType],
	[BORROWER].[PrintPositionType],
	[BORROWER].[JointAssetLiabilityReportingType]
from 
	[BORROWER] 
where 
	[BORROWER].[MaritalStatusType] = @maritalStatusType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:33 AM
System User: marlon
System Machine: SERVER
Entity Name: BORROWER
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectBorrowersByPrintPositionType
(
@printPositionType SmallInt = null
)
as


select 
	[BORROWER].[Id],
	[BORROWER].[JointAssetBorrowerID],
	[BORROWER].[LoanApplicationId],
	[BORROWER].[FirstName],
	[BORROWER].[MiddleName],
	[BORROWER].[LastName],
	[BORROWER].[NameSuffix],
	[BORROWER].[AgeAtApplicationYears],
	[BORROWER].[BirthDate],
	[BORROWER].[ApplicationSignedDate],
	[BORROWER].[HomeTelephoneNumber],
	[BORROWER].[SSN],
	[BORROWER].[DependentCount],
	[BORROWER].[SchoolingYears],
	[BORROWER].[CreditReportIdentifier],
	[BORROWER].[MaritalStatusType],
	[BORROWER].[PrintPositionType],
	[BORROWER].[JointAssetLiabilityReportingType]
from 
	[BORROWER] 
where 
	[BORROWER].[PrintPositionType] = @printPositionType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: DATA_INFORMATION
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectDataInformation
(
@loanApplicationId BigInt
)
as


select 
	[DATA_INFORMATION].[LoanApplicationId]
from 
	[DATA_INFORMATION] 
where 
	[DATA_INFORMATION].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: DATA_INFORMATION
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectDataInformationCollection
as


select 
	[DATA_INFORMATION].[LoanApplicationId]
from 
	[DATA_INFORMATION] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: DATA_INFORMATION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectDataInformationCollectionByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[DATA_INFORMATION].[LoanApplicationId]
from 
	[DATA_INFORMATION] 
where 
	[DATA_INFORMATION].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: DOWN_PAYMENT
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectDownPayment
(
@id BigInt
)
as


select 
	[DOWN_PAYMENT].[Id],
	[DOWN_PAYMENT].[LoanApplicationId],
	[DOWN_PAYMENT].[Amount],
	[DOWN_PAYMENT].[SourceDescription],
	[DOWN_PAYMENT].[Type]
from 
	[DOWN_PAYMENT] 
where 
	[DOWN_PAYMENT].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: DOWN_PAYMENT
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectDownPayments
as


select 
	[DOWN_PAYMENT].[Id],
	[DOWN_PAYMENT].[LoanApplicationId],
	[DOWN_PAYMENT].[Amount],
	[DOWN_PAYMENT].[SourceDescription],
	[DOWN_PAYMENT].[Type]
from 
	[DOWN_PAYMENT] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: DOWN_PAYMENT
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectDownPaymentsByDownPaymentType
(
@type SmallInt = null
)
as


select 
	[DOWN_PAYMENT].[Id],
	[DOWN_PAYMENT].[LoanApplicationId],
	[DOWN_PAYMENT].[Amount],
	[DOWN_PAYMENT].[SourceDescription],
	[DOWN_PAYMENT].[Type]
from 
	[DOWN_PAYMENT] 
where 
	[DOWN_PAYMENT].[Type] = @type
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: DOWN_PAYMENT
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectDownPaymentsByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[DOWN_PAYMENT].[Id],
	[DOWN_PAYMENT].[LoanApplicationId],
	[DOWN_PAYMENT].[Amount],
	[DOWN_PAYMENT].[SourceDescription],
	[DOWN_PAYMENT].[Type]
from 
	[DOWN_PAYMENT] 
where 
	[DOWN_PAYMENT].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_LOAN
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectGovernmentLoan
(
@loanApplicationId BigInt
)
as


select 
	[GOVERNMENT_LOAN].[LoanApplicationId]
from 
	[GOVERNMENT_LOAN] 
where 
	[GOVERNMENT_LOAN].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_LOAN
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectGovernmentLoans
as


select 
	[GOVERNMENT_LOAN].[LoanApplicationId]
from 
	[GOVERNMENT_LOAN] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_LOAN
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectGovernmentLoansByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[GOVERNMENT_LOAN].[LoanApplicationId]
from 
	[GOVERNMENT_LOAN] 
where 
	[GOVERNMENT_LOAN].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_REPORTING
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectGovernmentReporting
(
@loanApplicationId BigInt
)
as


select 
	[GOVERNMENT_REPORTING].[LoanApplicationId],
	[GOVERNMENT_REPORTING].[HMDAPurposeOfLoanType],
	[GOVERNMENT_REPORTING].[HMDAPreapprovalType],
	[GOVERNMENT_REPORTING].[HMDA_HOEPALoanStatusIndicator],
	[GOVERNMENT_REPORTING].[HMDARateSpreadPercent]
from 
	[GOVERNMENT_REPORTING] 
where 
	[GOVERNMENT_REPORTING].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_REPORTING
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectGovernmentReportingCollection
as


select 
	[GOVERNMENT_REPORTING].[LoanApplicationId],
	[GOVERNMENT_REPORTING].[HMDAPurposeOfLoanType],
	[GOVERNMENT_REPORTING].[HMDAPreapprovalType],
	[GOVERNMENT_REPORTING].[HMDA_HOEPALoanStatusIndicator],
	[GOVERNMENT_REPORTING].[HMDARateSpreadPercent]
from 
	[GOVERNMENT_REPORTING] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_REPORTING
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectGovernmentReportingCollectionByHMDAPreapprovalType
(
@hMDAPreapprovalType SmallInt = null
)
as


select 
	[GOVERNMENT_REPORTING].[LoanApplicationId],
	[GOVERNMENT_REPORTING].[HMDAPurposeOfLoanType],
	[GOVERNMENT_REPORTING].[HMDAPreapprovalType],
	[GOVERNMENT_REPORTING].[HMDA_HOEPALoanStatusIndicator],
	[GOVERNMENT_REPORTING].[HMDARateSpreadPercent]
from 
	[GOVERNMENT_REPORTING] 
where 
	[GOVERNMENT_REPORTING].[HMDAPreapprovalType] = @hMDAPreapprovalType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_REPORTING
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectGovernmentReportingCollectionByHMDAPurposeOfLoanType
(
@hMDAPurposeOfLoanType SmallInt = null
)
as


select 
	[GOVERNMENT_REPORTING].[LoanApplicationId],
	[GOVERNMENT_REPORTING].[HMDAPurposeOfLoanType],
	[GOVERNMENT_REPORTING].[HMDAPreapprovalType],
	[GOVERNMENT_REPORTING].[HMDA_HOEPALoanStatusIndicator],
	[GOVERNMENT_REPORTING].[HMDARateSpreadPercent]
from 
	[GOVERNMENT_REPORTING] 
where 
	[GOVERNMENT_REPORTING].[HMDAPurposeOfLoanType] = @hMDAPurposeOfLoanType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_REPORTING
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectGovernmentReportingCollectionByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[GOVERNMENT_REPORTING].[LoanApplicationId],
	[GOVERNMENT_REPORTING].[HMDAPurposeOfLoanType],
	[GOVERNMENT_REPORTING].[HMDAPreapprovalType],
	[GOVERNMENT_REPORTING].[HMDA_HOEPALoanStatusIndicator],
	[GOVERNMENT_REPORTING].[HMDARateSpreadPercent]
from 
	[GOVERNMENT_REPORTING] 
where 
	[GOVERNMENT_REPORTING].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: INTERVIEWER_INFORMATION
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectInterviewerInformation
(
@loanApplicationId BigInt
)
as


select 
	[INTERVIEWER_INFORMATION].[LoanApplicationId],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerStreetAddress],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerCity],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerState],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerPostalCode],
	[INTERVIEWER_INFORMATION].[InterviewersTelephoneNumber],
	[INTERVIEWER_INFORMATION].[ApplicationTakenMethodType],
	[INTERVIEWER_INFORMATION].[InterviewerApplicationSignedDate],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerName],
	[INTERVIEWER_INFORMATION].[InterviewersName]
from 
	[INTERVIEWER_INFORMATION] 
where 
	[INTERVIEWER_INFORMATION].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: INTERVIEWER_INFORMATION
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectInterviewerInformationCollection
as


select 
	[INTERVIEWER_INFORMATION].[LoanApplicationId],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerStreetAddress],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerCity],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerState],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerPostalCode],
	[INTERVIEWER_INFORMATION].[InterviewersTelephoneNumber],
	[INTERVIEWER_INFORMATION].[ApplicationTakenMethodType],
	[INTERVIEWER_INFORMATION].[InterviewerApplicationSignedDate],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerName],
	[INTERVIEWER_INFORMATION].[InterviewersName]
from 
	[INTERVIEWER_INFORMATION] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: INTERVIEWER_INFORMATION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectInterviewerInformationCollectionByApplicationMethod
(
@applicationTakenMethodType SmallInt = null
)
as


select 
	[INTERVIEWER_INFORMATION].[LoanApplicationId],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerStreetAddress],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerCity],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerState],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerPostalCode],
	[INTERVIEWER_INFORMATION].[InterviewersTelephoneNumber],
	[INTERVIEWER_INFORMATION].[ApplicationTakenMethodType],
	[INTERVIEWER_INFORMATION].[InterviewerApplicationSignedDate],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerName],
	[INTERVIEWER_INFORMATION].[InterviewersName]
from 
	[INTERVIEWER_INFORMATION] 
where 
	[INTERVIEWER_INFORMATION].[ApplicationTakenMethodType] = @applicationTakenMethodType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: INTERVIEWER_INFORMATION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectInterviewerInformationCollectionByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[INTERVIEWER_INFORMATION].[LoanApplicationId],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerStreetAddress],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerCity],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerState],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerPostalCode],
	[INTERVIEWER_INFORMATION].[InterviewersTelephoneNumber],
	[INTERVIEWER_INFORMATION].[ApplicationTakenMethodType],
	[INTERVIEWER_INFORMATION].[InterviewerApplicationSignedDate],
	[INTERVIEWER_INFORMATION].[InterviewersEmployerName],
	[INTERVIEWER_INFORMATION].[InterviewersName]
from 
	[INTERVIEWER_INFORMATION] 
where 
	[INTERVIEWER_INFORMATION].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PRODUCT_DATA
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLoanProductData
(
@loanApplicationId BigInt
)
as


select 
	[LOAN_PRODUCT_DATA].[LoanApplicationId]
from 
	[LOAN_PRODUCT_DATA] 
where 
	[LOAN_PRODUCT_DATA].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PRODUCT_DATA
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLoanProductDataCollection
as


select 
	[LOAN_PRODUCT_DATA].[LoanApplicationId]
from 
	[LOAN_PRODUCT_DATA] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PRODUCT_DATA
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanProductDataCollectionByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[LOAN_PRODUCT_DATA].[LoanApplicationId]
from 
	[LOAN_PRODUCT_DATA] 
where 
	[LOAN_PRODUCT_DATA].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PURPOSE
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLoanPurpose
(
@loanApplicationId BigInt
)
as


select 
	[LOAN_PURPOSE].[LoanApplicationId],
	[LOAN_PURPOSE].[GSETitleMannerHeldDescription],
	[LOAN_PURPOSE].[OtherLoanPurposeDescription],
	[LOAN_PURPOSE].[PropertyLeaseholdExpirationDate],
	[LOAN_PURPOSE].[PropertyUsageType],
	[LOAN_PURPOSE].[PropertyRightsType],
	[LOAN_PURPOSE].[Type]
from 
	[LOAN_PURPOSE] 
where 
	[LOAN_PURPOSE].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PURPOSE
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLoanPurposes
as


select 
	[LOAN_PURPOSE].[LoanApplicationId],
	[LOAN_PURPOSE].[GSETitleMannerHeldDescription],
	[LOAN_PURPOSE].[OtherLoanPurposeDescription],
	[LOAN_PURPOSE].[PropertyLeaseholdExpirationDate],
	[LOAN_PURPOSE].[PropertyUsageType],
	[LOAN_PURPOSE].[PropertyRightsType],
	[LOAN_PURPOSE].[Type]
from 
	[LOAN_PURPOSE] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PURPOSE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanPurposesByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[LOAN_PURPOSE].[LoanApplicationId],
	[LOAN_PURPOSE].[GSETitleMannerHeldDescription],
	[LOAN_PURPOSE].[OtherLoanPurposeDescription],
	[LOAN_PURPOSE].[PropertyLeaseholdExpirationDate],
	[LOAN_PURPOSE].[PropertyUsageType],
	[LOAN_PURPOSE].[PropertyRightsType],
	[LOAN_PURPOSE].[Type]
from 
	[LOAN_PURPOSE] 
where 
	[LOAN_PURPOSE].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PURPOSE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanPurposesByPropertyRightsType
(
@propertyRightsType SmallInt = null
)
as


select 
	[LOAN_PURPOSE].[LoanApplicationId],
	[LOAN_PURPOSE].[GSETitleMannerHeldDescription],
	[LOAN_PURPOSE].[OtherLoanPurposeDescription],
	[LOAN_PURPOSE].[PropertyLeaseholdExpirationDate],
	[LOAN_PURPOSE].[PropertyUsageType],
	[LOAN_PURPOSE].[PropertyRightsType],
	[LOAN_PURPOSE].[Type]
from 
	[LOAN_PURPOSE] 
where 
	[LOAN_PURPOSE].[PropertyRightsType] = @propertyRightsType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PURPOSE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanPurposesByPropertyUsageType
(
@propertyUsageType SmallInt = null
)
as


select 
	[LOAN_PURPOSE].[LoanApplicationId],
	[LOAN_PURPOSE].[GSETitleMannerHeldDescription],
	[LOAN_PURPOSE].[OtherLoanPurposeDescription],
	[LOAN_PURPOSE].[PropertyLeaseholdExpirationDate],
	[LOAN_PURPOSE].[PropertyUsageType],
	[LOAN_PURPOSE].[PropertyRightsType],
	[LOAN_PURPOSE].[Type]
from 
	[LOAN_PURPOSE] 
where 
	[LOAN_PURPOSE].[PropertyUsageType] = @propertyUsageType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PURPOSE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanPurposesByPurposeType
(
@type SmallInt = null
)
as


select 
	[LOAN_PURPOSE].[LoanApplicationId],
	[LOAN_PURPOSE].[GSETitleMannerHeldDescription],
	[LOAN_PURPOSE].[OtherLoanPurposeDescription],
	[LOAN_PURPOSE].[PropertyLeaseholdExpirationDate],
	[LOAN_PURPOSE].[PropertyUsageType],
	[LOAN_PURPOSE].[PropertyRightsType],
	[LOAN_PURPOSE].[Type]
from 
	[LOAN_PURPOSE] 
where 
	[LOAN_PURPOSE].[Type] = @type
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_QUALIFICATION
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLoanQualification
(
@loanApplicationId BigInt
)
as


select 
	[LOAN_QUALIFICATION].[LoanApplicationId],
	[LOAN_QUALIFICATION].[AdditionalBorrowerAssetsNotConsideredIndicator],
	[LOAN_QUALIFICATION].[AdditionalBorrowerAssetsConsideredIndicator]
from 
	[LOAN_QUALIFICATION] 
where 
	[LOAN_QUALIFICATION].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_QUALIFICATION
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLoanQualifications
as


select 
	[LOAN_QUALIFICATION].[LoanApplicationId],
	[LOAN_QUALIFICATION].[AdditionalBorrowerAssetsNotConsideredIndicator],
	[LOAN_QUALIFICATION].[AdditionalBorrowerAssetsConsideredIndicator]
from 
	[LOAN_QUALIFICATION] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_QUALIFICATION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanQualificationsByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[LOAN_QUALIFICATION].[LoanApplicationId],
	[LOAN_QUALIFICATION].[AdditionalBorrowerAssetsNotConsideredIndicator],
	[LOAN_QUALIFICATION].[AdditionalBorrowerAssetsConsideredIndicator]
from 
	[LOAN_QUALIFICATION] 
where 
	[LOAN_QUALIFICATION].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:57 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_TERMS
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectMortgageTerms
(
@loanApplicationId BigInt
)
as


select 
	[MORTGAGE_TERMS].[LoanApplicationId],
	[MORTGAGE_TERMS].[AgencyCaseIdentifier],
	[MORTGAGE_TERMS].[ARMTypeDescription],
	[MORTGAGE_TERMS].[BaseLoanAmount],
	[MORTGAGE_TERMS].[BorrowerRequestedLoanAmount],
	[MORTGAGE_TERMS].[LenderCaseIdentifier],
	[MORTGAGE_TERMS].[LoanAmortizationTermMonths],
	[MORTGAGE_TERMS].[OtherMortgageTypeDescription],
	[MORTGAGE_TERMS].[OtherAmortizationTypeDescription],
	[MORTGAGE_TERMS].[RequestedInterestRatePercent],
	[MORTGAGE_TERMS].[LoanAmortizationType],
	[MORTGAGE_TERMS].[MortgageType]
from 
	[MORTGAGE_TERMS] 
where 
	[MORTGAGE_TERMS].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:57 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_TERMS
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectMortgageTermsCollection
as


select 
	[MORTGAGE_TERMS].[LoanApplicationId],
	[MORTGAGE_TERMS].[AgencyCaseIdentifier],
	[MORTGAGE_TERMS].[ARMTypeDescription],
	[MORTGAGE_TERMS].[BaseLoanAmount],
	[MORTGAGE_TERMS].[BorrowerRequestedLoanAmount],
	[MORTGAGE_TERMS].[LenderCaseIdentifier],
	[MORTGAGE_TERMS].[LoanAmortizationTermMonths],
	[MORTGAGE_TERMS].[OtherMortgageTypeDescription],
	[MORTGAGE_TERMS].[OtherAmortizationTypeDescription],
	[MORTGAGE_TERMS].[RequestedInterestRatePercent],
	[MORTGAGE_TERMS].[LoanAmortizationType],
	[MORTGAGE_TERMS].[MortgageType]
from 
	[MORTGAGE_TERMS] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:57 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_TERMS
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectMortgageTermsCollectionByLoanAmortizationType
(
@loanAmortizationType SmallInt = null
)
as


select 
	[MORTGAGE_TERMS].[LoanApplicationId],
	[MORTGAGE_TERMS].[AgencyCaseIdentifier],
	[MORTGAGE_TERMS].[ARMTypeDescription],
	[MORTGAGE_TERMS].[BaseLoanAmount],
	[MORTGAGE_TERMS].[BorrowerRequestedLoanAmount],
	[MORTGAGE_TERMS].[LenderCaseIdentifier],
	[MORTGAGE_TERMS].[LoanAmortizationTermMonths],
	[MORTGAGE_TERMS].[OtherMortgageTypeDescription],
	[MORTGAGE_TERMS].[OtherAmortizationTypeDescription],
	[MORTGAGE_TERMS].[RequestedInterestRatePercent],
	[MORTGAGE_TERMS].[LoanAmortizationType],
	[MORTGAGE_TERMS].[MortgageType]
from 
	[MORTGAGE_TERMS] 
where 
	[MORTGAGE_TERMS].[LoanAmortizationType] = @loanAmortizationType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_TERMS
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectMortgageTermsCollectionByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[MORTGAGE_TERMS].[LoanApplicationId],
	[MORTGAGE_TERMS].[AgencyCaseIdentifier],
	[MORTGAGE_TERMS].[ARMTypeDescription],
	[MORTGAGE_TERMS].[BaseLoanAmount],
	[MORTGAGE_TERMS].[BorrowerRequestedLoanAmount],
	[MORTGAGE_TERMS].[LenderCaseIdentifier],
	[MORTGAGE_TERMS].[LoanAmortizationTermMonths],
	[MORTGAGE_TERMS].[OtherMortgageTypeDescription],
	[MORTGAGE_TERMS].[OtherAmortizationTypeDescription],
	[MORTGAGE_TERMS].[RequestedInterestRatePercent],
	[MORTGAGE_TERMS].[LoanAmortizationType],
	[MORTGAGE_TERMS].[MortgageType]
from 
	[MORTGAGE_TERMS] 
where 
	[MORTGAGE_TERMS].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:58 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_TERMS
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectMortgageTermsCollectionByMortgageType
(
@mortgageType SmallInt = null
)
as


select 
	[MORTGAGE_TERMS].[LoanApplicationId],
	[MORTGAGE_TERMS].[AgencyCaseIdentifier],
	[MORTGAGE_TERMS].[ARMTypeDescription],
	[MORTGAGE_TERMS].[BaseLoanAmount],
	[MORTGAGE_TERMS].[BorrowerRequestedLoanAmount],
	[MORTGAGE_TERMS].[LenderCaseIdentifier],
	[MORTGAGE_TERMS].[LoanAmortizationTermMonths],
	[MORTGAGE_TERMS].[OtherMortgageTypeDescription],
	[MORTGAGE_TERMS].[OtherAmortizationTypeDescription],
	[MORTGAGE_TERMS].[RequestedInterestRatePercent],
	[MORTGAGE_TERMS].[LoanAmortizationType],
	[MORTGAGE_TERMS].[MortgageType]
from 
	[MORTGAGE_TERMS] 
where 
	[MORTGAGE_TERMS].[MortgageType] = @mortgageType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPERTY
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectProperties
as


select 
	[PROPERTY].[LoanApplicationId],
	[PROPERTY].[StreetAddress],
	[PROPERTY].[StreetAddress2],
	[PROPERTY].[City],
	[PROPERTY].[State],
	[PROPERTY].[County],
	[PROPERTY].[PostalCode],
	[PROPERTY].[FinancedNumberOfUnits],
	[PROPERTY].[StructureBuiltYear],
	[PROPERTY].[AcquiredDate],
	[PROPERTY].[PlannedUnitDevelopmentIndicator],
	[PROPERTY].[AcreageNumber],
	[PROPERTY].[BuildingStatusType],
	[PROPERTY].[GSEPropertyType]
from 
	[PROPERTY] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPERTY
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectPropertiesByBuildingStatusType
(
@buildingStatusType SmallInt = null
)
as


select 
	[PROPERTY].[LoanApplicationId],
	[PROPERTY].[StreetAddress],
	[PROPERTY].[StreetAddress2],
	[PROPERTY].[City],
	[PROPERTY].[State],
	[PROPERTY].[County],
	[PROPERTY].[PostalCode],
	[PROPERTY].[FinancedNumberOfUnits],
	[PROPERTY].[StructureBuiltYear],
	[PROPERTY].[AcquiredDate],
	[PROPERTY].[PlannedUnitDevelopmentIndicator],
	[PROPERTY].[AcreageNumber],
	[PROPERTY].[BuildingStatusType],
	[PROPERTY].[GSEPropertyType]
from 
	[PROPERTY] 
where 
	[PROPERTY].[BuildingStatusType] = @buildingStatusType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPERTY
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectPropertiesByGSEPropertyType
(
@gSEPropertyType SmallInt = null
)
as


select 
	[PROPERTY].[LoanApplicationId],
	[PROPERTY].[StreetAddress],
	[PROPERTY].[StreetAddress2],
	[PROPERTY].[City],
	[PROPERTY].[State],
	[PROPERTY].[County],
	[PROPERTY].[PostalCode],
	[PROPERTY].[FinancedNumberOfUnits],
	[PROPERTY].[StructureBuiltYear],
	[PROPERTY].[AcquiredDate],
	[PROPERTY].[PlannedUnitDevelopmentIndicator],
	[PROPERTY].[AcreageNumber],
	[PROPERTY].[BuildingStatusType],
	[PROPERTY].[GSEPropertyType]
from 
	[PROPERTY] 
where 
	[PROPERTY].[GSEPropertyType] = @gSEPropertyType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPERTY
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectPropertiesByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[PROPERTY].[LoanApplicationId],
	[PROPERTY].[StreetAddress],
	[PROPERTY].[StreetAddress2],
	[PROPERTY].[City],
	[PROPERTY].[State],
	[PROPERTY].[County],
	[PROPERTY].[PostalCode],
	[PROPERTY].[FinancedNumberOfUnits],
	[PROPERTY].[StructureBuiltYear],
	[PROPERTY].[AcquiredDate],
	[PROPERTY].[PlannedUnitDevelopmentIndicator],
	[PROPERTY].[AcreageNumber],
	[PROPERTY].[BuildingStatusType],
	[PROPERTY].[GSEPropertyType]
from 
	[PROPERTY] 
where 
	[PROPERTY].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPERTY
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectProperty
(
@loanApplicationId BigInt
)
as


select 
	[PROPERTY].[LoanApplicationId],
	[PROPERTY].[StreetAddress],
	[PROPERTY].[StreetAddress2],
	[PROPERTY].[City],
	[PROPERTY].[State],
	[PROPERTY].[County],
	[PROPERTY].[PostalCode],
	[PROPERTY].[FinancedNumberOfUnits],
	[PROPERTY].[StructureBuiltYear],
	[PROPERTY].[AcquiredDate],
	[PROPERTY].[PlannedUnitDevelopmentIndicator],
	[PROPERTY].[AcreageNumber],
	[PROPERTY].[BuildingStatusType],
	[PROPERTY].[GSEPropertyType]
from 
	[PROPERTY] 
where 
	[PROPERTY].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPOSED_HOUSING_EXPENSE
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectProposedHousingExpense
(
@id BigInt
)
as


select 
	[PROPOSED_HOUSING_EXPENSE].[Id],
	[PROPOSED_HOUSING_EXPENSE].[LoanApplicationId],
	[PROPOSED_HOUSING_EXPENSE].[PaymentAmount],
	[PROPOSED_HOUSING_EXPENSE].[HousingExpenseType]
from 
	[PROPOSED_HOUSING_EXPENSE] 
where 
	[PROPOSED_HOUSING_EXPENSE].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPOSED_HOUSING_EXPENSE
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectProposedHousingExpenses
as


select 
	[PROPOSED_HOUSING_EXPENSE].[Id],
	[PROPOSED_HOUSING_EXPENSE].[LoanApplicationId],
	[PROPOSED_HOUSING_EXPENSE].[PaymentAmount],
	[PROPOSED_HOUSING_EXPENSE].[HousingExpenseType]
from 
	[PROPOSED_HOUSING_EXPENSE] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPOSED_HOUSING_EXPENSE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectProposedHousingExpensesByHousingExpenseType
(
@housingExpenseType SmallInt
)
as


select 
	[PROPOSED_HOUSING_EXPENSE].[Id],
	[PROPOSED_HOUSING_EXPENSE].[LoanApplicationId],
	[PROPOSED_HOUSING_EXPENSE].[PaymentAmount],
	[PROPOSED_HOUSING_EXPENSE].[HousingExpenseType]
from 
	[PROPOSED_HOUSING_EXPENSE] 
where 
	[PROPOSED_HOUSING_EXPENSE].[HousingExpenseType] = @housingExpenseType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPOSED_HOUSING_EXPENSE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectProposedHousingExpensesByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[PROPOSED_HOUSING_EXPENSE].[Id],
	[PROPOSED_HOUSING_EXPENSE].[LoanApplicationId],
	[PROPOSED_HOUSING_EXPENSE].[PaymentAmount],
	[PROPOSED_HOUSING_EXPENSE].[HousingExpenseType]
from 
	[PROPOSED_HOUSING_EXPENSE] 
where 
	[PROPOSED_HOUSING_EXPENSE].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:07 AM
System User: marlon
System Machine: SERVER
Entity Name: TITLE_HOLDER
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectTitleHolder
(
@id BigInt
)
as


select 
	[TITLE_HOLDER].[LoanApplicationId],
	[TITLE_HOLDER].[Id],
	[TITLE_HOLDER].[Name],
	[TITLE_HOLDER].[LandTrustType]
from 
	[TITLE_HOLDER] 
where 
	[TITLE_HOLDER].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:07 AM
System User: marlon
System Machine: SERVER
Entity Name: TITLE_HOLDER
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectTitleHolders
as


select 
	[TITLE_HOLDER].[LoanApplicationId],
	[TITLE_HOLDER].[Id],
	[TITLE_HOLDER].[Name],
	[TITLE_HOLDER].[LandTrustType]
from 
	[TITLE_HOLDER] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:07 AM
System User: marlon
System Machine: SERVER
Entity Name: TITLE_HOLDER
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectTitleHoldersByLandTrustType
(
@landTrustType SmallInt = null
)
as


select 
	[TITLE_HOLDER].[LoanApplicationId],
	[TITLE_HOLDER].[Id],
	[TITLE_HOLDER].[Name],
	[TITLE_HOLDER].[LandTrustType]
from 
	[TITLE_HOLDER] 
where 
	[TITLE_HOLDER].[LandTrustType] = @landTrustType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:07 AM
System User: marlon
System Machine: SERVER
Entity Name: TITLE_HOLDER
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectTitleHoldersByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[TITLE_HOLDER].[LoanApplicationId],
	[TITLE_HOLDER].[Id],
	[TITLE_HOLDER].[Name],
	[TITLE_HOLDER].[LandTrustType]
from 
	[TITLE_HOLDER] 
where 
	[TITLE_HOLDER].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:07 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSACTION_DETAIL
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectTransactionDetail
(
@loanApplicationId BigInt
)
as


select 
	[TRANSACTION_DETAIL].[LoanApplicationId],
	[TRANSACTION_DETAIL].[AlterationsImprovementsAndRepairsAmount],
	[TRANSACTION_DETAIL].[BorrowerPaidDiscountPointsTotalAmount],
	[TRANSACTION_DETAIL].[EstimatedClosingCostsAmount],
	[TRANSACTION_DETAIL].[MIAndFundingFeeFinancedAmount],
	[TRANSACTION_DETAIL].[MIAndFundingFeeTotalAmount],
	[TRANSACTION_DETAIL].[PrepaidItemsEstimatedAmount],
	[TRANSACTION_DETAIL].[PurchasePriceAmount],
	[TRANSACTION_DETAIL].[RefinanceIncludingDebtsToBePaidOffAmount],
	[TRANSACTION_DETAIL].[SalesConcessionAmount],
	[TRANSACTION_DETAIL].[SellerPaidClosingCostsAmount],
	[TRANSACTION_DETAIL].[SubordinateLienAmount],
	[TRANSACTION_DETAIL].[SubordinateLienHELOCAmount],
	[TRANSACTION_DETAIL].[FREReserveAmount],
	[TRANSACTION_DETAIL].[FREReservesAmount]
from 
	[TRANSACTION_DETAIL] 
where 
	[TRANSACTION_DETAIL].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:07 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSACTION_DETAIL
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectTransactionDetails
as


select 
	[TRANSACTION_DETAIL].[LoanApplicationId],
	[TRANSACTION_DETAIL].[AlterationsImprovementsAndRepairsAmount],
	[TRANSACTION_DETAIL].[BorrowerPaidDiscountPointsTotalAmount],
	[TRANSACTION_DETAIL].[EstimatedClosingCostsAmount],
	[TRANSACTION_DETAIL].[MIAndFundingFeeFinancedAmount],
	[TRANSACTION_DETAIL].[MIAndFundingFeeTotalAmount],
	[TRANSACTION_DETAIL].[PrepaidItemsEstimatedAmount],
	[TRANSACTION_DETAIL].[PurchasePriceAmount],
	[TRANSACTION_DETAIL].[RefinanceIncludingDebtsToBePaidOffAmount],
	[TRANSACTION_DETAIL].[SalesConcessionAmount],
	[TRANSACTION_DETAIL].[SellerPaidClosingCostsAmount],
	[TRANSACTION_DETAIL].[SubordinateLienAmount],
	[TRANSACTION_DETAIL].[SubordinateLienHELOCAmount],
	[TRANSACTION_DETAIL].[FREReserveAmount],
	[TRANSACTION_DETAIL].[FREReservesAmount]
from 
	[TRANSACTION_DETAIL] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSACTION_DETAIL
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectTransactionDetailsByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[TRANSACTION_DETAIL].[LoanApplicationId],
	[TRANSACTION_DETAIL].[AlterationsImprovementsAndRepairsAmount],
	[TRANSACTION_DETAIL].[BorrowerPaidDiscountPointsTotalAmount],
	[TRANSACTION_DETAIL].[EstimatedClosingCostsAmount],
	[TRANSACTION_DETAIL].[MIAndFundingFeeFinancedAmount],
	[TRANSACTION_DETAIL].[MIAndFundingFeeTotalAmount],
	[TRANSACTION_DETAIL].[PrepaidItemsEstimatedAmount],
	[TRANSACTION_DETAIL].[PurchasePriceAmount],
	[TRANSACTION_DETAIL].[RefinanceIncludingDebtsToBePaidOffAmount],
	[TRANSACTION_DETAIL].[SalesConcessionAmount],
	[TRANSACTION_DETAIL].[SellerPaidClosingCostsAmount],
	[TRANSACTION_DETAIL].[SubordinateLienAmount],
	[TRANSACTION_DETAIL].[SubordinateLienHELOCAmount],
	[TRANSACTION_DETAIL].[FREReserveAmount],
	[TRANSACTION_DETAIL].[FREReservesAmount]
from 
	[TRANSACTION_DETAIL] 
where 
	[TRANSACTION_DETAIL].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: ADDITIONAL_CASE_DATA
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateAdditionalCaseData
(
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [ADDITIONAL_CASE_DATA] set 
	[LoanApplicationId] = @loanApplicationId
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: AFFORDABLE_LENDING
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateAffordableLending
(
@fNMCommunityLendingProductName VarChar(64) = null,
@fNMCommunityLendingProductTypeOtherDescription VarChar(64) = null,
@fNMCommunitySecondsIndicator Bit,
@fNMNeighborsMortgageEligibilityIndicator Bit,
@fREAffordableProgramIdentifier VarChar(64) = null,
@hUDIncomeLimitAdjustmentFactor Decimal(18,0) = null,
@hUDLendingIncomeLimitAmount Money = null,
@hUDMedianIncomeAmount Money = null,
@mSAIdentifier VarChar(64) = null,
@fNMCommunityLendingProductType SmallInt = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [AFFORDABLE_LENDING] set 
	[LoanApplicationId] = @loanApplicationId,
	[FNMCommunityLendingProductName] = @fNMCommunityLendingProductName,
	[FNMCommunityLendingProductTypeOtherDescription] = @fNMCommunityLendingProductTypeOtherDescription,
	[FNMCommunitySecondsIndicator] = @fNMCommunitySecondsIndicator,
	[FNMNeighborsMortgageEligibilityIndicator] = @fNMNeighborsMortgageEligibilityIndicator,
	[FREAffordableProgramIdentifier] = @fREAffordableProgramIdentifier,
	[HUDIncomeLimitAdjustmentFactor] = @hUDIncomeLimitAdjustmentFactor,
	[HUDLendingIncomeLimitAmount] = @hUDLendingIncomeLimitAmount,
	[HUDMedianIncomeAmount] = @hUDMedianIncomeAmount,
	[MSAIdentifier] = @mSAIdentifier,
	[FNMCommunityLendingProductType] = @fNMCommunityLendingProductType
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:33 AM
System User: marlon
System Machine: SERVER
Entity Name: BORROWER
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateBorrower
(
@jointAssetBorrowerID BigInt = null,
@loanApplicationId BigInt = null,
@firstName VarChar(64) = null,
@middleName VarChar(64) = null,
@lastName VarChar(64) = null,
@nameSuffix VarChar(64) = null,
@ageAtApplicationYears Decimal(18,0) = null,
@birthDate DateTime = null,
@applicationSignedDate DateTime = null,
@homeTelephoneNumber VarChar(64) = null,
@sSN VarChar(64) = null,
@dependentCount TinyInt = null,
@schoolingYears Decimal(18,0) = null,
@creditReportIdentifier VarChar(64) = null,
@maritalStatusType SmallInt = null,
@printPositionType SmallInt = null,
@jointAssetLiabilityReportingType SmallInt = null,
@id BigInt
)
as


-- persist the data via an update
update [BORROWER] set 
	[JointAssetBorrowerID] = @jointAssetBorrowerID,
	[LoanApplicationId] = @loanApplicationId,
	[FirstName] = @firstName,
	[MiddleName] = @middleName,
	[LastName] = @lastName,
	[NameSuffix] = @nameSuffix,
	[AgeAtApplicationYears] = @ageAtApplicationYears,
	[BirthDate] = @birthDate,
	[ApplicationSignedDate] = @applicationSignedDate,
	[HomeTelephoneNumber] = @homeTelephoneNumber,
	[SSN] = @sSN,
	[DependentCount] = @dependentCount,
	[SchoolingYears] = @schoolingYears,
	[CreditReportIdentifier] = @creditReportIdentifier,
	[MaritalStatusType] = @maritalStatusType,
	[PrintPositionType] = @printPositionType,
	[JointAssetLiabilityReportingType] = @jointAssetLiabilityReportingType
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: DATA_INFORMATION
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateDataInformation
(
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [DATA_INFORMATION] set 
	[LoanApplicationId] = @loanApplicationId
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: DOWN_PAYMENT
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateDownPayment
(
@loanApplicationId BigInt,
@amount Money,
@sourceDescription VarChar(64) = null,
@type SmallInt = null,
@id BigInt
)
as


-- persist the data via an update
update [DOWN_PAYMENT] set 
	[LoanApplicationId] = @loanApplicationId,
	[Amount] = @amount,
	[SourceDescription] = @sourceDescription,
	[Type] = @type
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_LOAN
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateGovernmentLoan
(
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [GOVERNMENT_LOAN] set 
	[LoanApplicationId] = @loanApplicationId
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:46 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_REPORTING
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateGovernmentReporting
(
@hMDAPurposeOfLoanType SmallInt = null,
@hMDAPreapprovalType SmallInt = null,
@hMDA_HOEPALoanStatusIndicator Bit,
@hMDARateSpreadPercent Decimal(8,7) = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [GOVERNMENT_REPORTING] set 
	[LoanApplicationId] = @loanApplicationId,
	[HMDAPurposeOfLoanType] = @hMDAPurposeOfLoanType,
	[HMDAPreapprovalType] = @hMDAPreapprovalType,
	[HMDA_HOEPALoanStatusIndicator] = @hMDA_HOEPALoanStatusIndicator,
	[HMDARateSpreadPercent] = @hMDARateSpreadPercent
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:49 AM
System User: marlon
System Machine: SERVER
Entity Name: INTERVIEWER_INFORMATION
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateInterviewerInformation
(
@interviewersEmployerStreetAddress VarChar(128) = null,
@interviewersEmployerCity VarChar(64) = null,
@interviewersEmployerState VarChar(64) = null,
@interviewersEmployerPostalCode VarChar(16) = null,
@interviewersTelephoneNumber VarChar(32) = null,
@applicationTakenMethodType SmallInt = null,
@interviewerApplicationSignedDate DateTime = null,
@interviewersEmployerName VarChar(128) = null,
@interviewersName VarChar(128) = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [INTERVIEWER_INFORMATION] set 
	[LoanApplicationId] = @loanApplicationId,
	[InterviewersEmployerStreetAddress] = @interviewersEmployerStreetAddress,
	[InterviewersEmployerCity] = @interviewersEmployerCity,
	[InterviewersEmployerState] = @interviewersEmployerState,
	[InterviewersEmployerPostalCode] = @interviewersEmployerPostalCode,
	[InterviewersTelephoneNumber] = @interviewersTelephoneNumber,
	[ApplicationTakenMethodType] = @applicationTakenMethodType,
	[InterviewerApplicationSignedDate] = @interviewerApplicationSignedDate,
	[InterviewersEmployerName] = @interviewersEmployerName,
	[InterviewersName] = @interviewersName
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PRODUCT_DATA
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLoanProductData
(
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [LOAN_PRODUCT_DATA] set 
	[LoanApplicationId] = @loanApplicationId
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_PURPOSE
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLoanPurpose
(
@gSETitleMannerHeldDescription VarChar(254) = null,
@otherLoanPurposeDescription VarChar(254) = null,
@propertyLeaseholdExpirationDate DateTime = null,
@propertyUsageType SmallInt = null,
@propertyRightsType SmallInt = null,
@type SmallInt = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [LOAN_PURPOSE] set 
	[LoanApplicationId] = @loanApplicationId,
	[GSETitleMannerHeldDescription] = @gSETitleMannerHeldDescription,
	[OtherLoanPurposeDescription] = @otherLoanPurposeDescription,
	[PropertyLeaseholdExpirationDate] = @propertyLeaseholdExpirationDate,
	[PropertyUsageType] = @propertyUsageType,
	[PropertyRightsType] = @propertyRightsType,
	[Type] = @type
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:54 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_QUALIFICATION
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLoanQualification
(
@additionalBorrowerAssetsNotConsideredIndicator Bit,
@additionalBorrowerAssetsConsideredIndicator Bit,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [LOAN_QUALIFICATION] set 
	[LoanApplicationId] = @loanApplicationId,
	[AdditionalBorrowerAssetsNotConsideredIndicator] = @additionalBorrowerAssetsNotConsideredIndicator,
	[AdditionalBorrowerAssetsConsideredIndicator] = @additionalBorrowerAssetsConsideredIndicator
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:57 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_TERMS
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateMortgageTerms
(
@agencyCaseIdentifier VarChar(64) = null,
@aRMTypeDescription VarChar(254) = null,
@baseLoanAmount Money = null,
@borrowerRequestedLoanAmount Money = null,
@lenderCaseIdentifier VarChar(64) = null,
@loanAmortizationTermMonths Decimal(18,0) = null,
@otherMortgageTypeDescription VarChar(254) = null,
@otherAmortizationTypeDescription VarChar(254) = null,
@requestedInterestRatePercent Decimal(8,7) = null,
@loanAmortizationType SmallInt = null,
@mortgageType SmallInt = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [MORTGAGE_TERMS] set 
	[LoanApplicationId] = @loanApplicationId,
	[AgencyCaseIdentifier] = @agencyCaseIdentifier,
	[ARMTypeDescription] = @aRMTypeDescription,
	[BaseLoanAmount] = @baseLoanAmount,
	[BorrowerRequestedLoanAmount] = @borrowerRequestedLoanAmount,
	[LenderCaseIdentifier] = @lenderCaseIdentifier,
	[LoanAmortizationTermMonths] = @loanAmortizationTermMonths,
	[OtherMortgageTypeDescription] = @otherMortgageTypeDescription,
	[OtherAmortizationTypeDescription] = @otherAmortizationTypeDescription,
	[RequestedInterestRatePercent] = @requestedInterestRatePercent,
	[LoanAmortizationType] = @loanAmortizationType,
	[MortgageType] = @mortgageType
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:01 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPERTY
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateProperty
(
@streetAddress VarChar(128) = null,
@streetAddress2 VarChar(128) = null,
@city VarChar(64) = null,
@state VarChar(64) = null,
@county VarChar(64) = null,
@postalCode VarChar(16) = null,
@financedNumberOfUnits Int = null,
@structureBuiltYear DateTime = null,
@acquiredDate DateTime = null,
@plannedUnitDevelopmentIndicator Bit,
@acreageNumber Decimal(18,0) = null,
@buildingStatusType SmallInt = null,
@gSEPropertyType SmallInt = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [PROPERTY] set 
	[LoanApplicationId] = @loanApplicationId,
	[StreetAddress] = @streetAddress,
	[StreetAddress2] = @streetAddress2,
	[City] = @city,
	[State] = @state,
	[County] = @county,
	[PostalCode] = @postalCode,
	[FinancedNumberOfUnits] = @financedNumberOfUnits,
	[StructureBuiltYear] = @structureBuiltYear,
	[AcquiredDate] = @acquiredDate,
	[PlannedUnitDevelopmentIndicator] = @plannedUnitDevelopmentIndicator,
	[AcreageNumber] = @acreageNumber,
	[BuildingStatusType] = @buildingStatusType,
	[GSEPropertyType] = @gSEPropertyType
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PROPOSED_HOUSING_EXPENSE
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateProposedHousingExpense
(
@loanApplicationId BigInt,
@paymentAmount Money,
@housingExpenseType SmallInt,
@id BigInt
)
as


-- persist the data via an update
update [PROPOSED_HOUSING_EXPENSE] set 
	[LoanApplicationId] = @loanApplicationId,
	[PaymentAmount] = @paymentAmount,
	[HousingExpenseType] = @housingExpenseType
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:07 AM
System User: marlon
System Machine: SERVER
Entity Name: TITLE_HOLDER
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateTitleHolder
(
@loanApplicationId BigInt,
@name VarChar(128) = null,
@landTrustType SmallInt = null,
@id BigInt
)
as


-- persist the data via an update
update [TITLE_HOLDER] set 
	[LoanApplicationId] = @loanApplicationId,
	[Name] = @name,
	[LandTrustType] = @landTrustType
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:07 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSACTION_DETAIL
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateTransactionDetail
(
@alterationsImprovementsAndRepairsAmount Money = null,
@borrowerPaidDiscountPointsTotalAmount Money = null,
@estimatedClosingCostsAmount Money = null,
@mIAndFundingFeeFinancedAmount Money = null,
@mIAndFundingFeeTotalAmount Money = null,
@prepaidItemsEstimatedAmount Money = null,
@purchasePriceAmount Money = null,
@refinanceIncludingDebtsToBePaidOffAmount Money = null,
@salesConcessionAmount Money = null,
@sellerPaidClosingCostsAmount Money = null,
@subordinateLienAmount Money = null,
@subordinateLienHELOCAmount Money = null,
@fREReserveAmount Money = null,
@fREReservesAmount Money = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [TRANSACTION_DETAIL] set 
	[LoanApplicationId] = @loanApplicationId,
	[AlterationsImprovementsAndRepairsAmount] = @alterationsImprovementsAndRepairsAmount,
	[BorrowerPaidDiscountPointsTotalAmount] = @borrowerPaidDiscountPointsTotalAmount,
	[EstimatedClosingCostsAmount] = @estimatedClosingCostsAmount,
	[MIAndFundingFeeFinancedAmount] = @mIAndFundingFeeFinancedAmount,
	[MIAndFundingFeeTotalAmount] = @mIAndFundingFeeTotalAmount,
	[PrepaidItemsEstimatedAmount] = @prepaidItemsEstimatedAmount,
	[PurchasePriceAmount] = @purchasePriceAmount,
	[RefinanceIncludingDebtsToBePaidOffAmount] = @refinanceIncludingDebtsToBePaidOffAmount,
	[SalesConcessionAmount] = @salesConcessionAmount,
	[SellerPaidClosingCostsAmount] = @sellerPaidClosingCostsAmount,
	[SubordinateLienAmount] = @subordinateLienAmount,
	[SubordinateLienHELOCAmount] = @subordinateLienHELOCAmount,
	[FREReserveAmount] = @fREReserveAmount,
	[FREReservesAmount] = @fREReservesAmount
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: ARM
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateARM
(
@indexCurrentValuePercent Decimal(8,7) = null,
@indexMarginPercent Decimal(8,7) = null,
@indexType SmallInt = null,
@qualifyingRatePercent Decimal(8,7) = null,
@conversionOptionIndicator Bit,
@paymentAdjustmentLifetimeCapAmount Money = null,
@paymentAdjustmentLifetimeCapPercent Decimal(8,7) = null,
@rateAdjustmentLifetimeCapPercent Decimal(8,7) = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [ARM]
	(
	[LoanApplicationId],
	[IndexCurrentValuePercent],
	[IndexMarginPercent],
	[IndexType],
	[QualifyingRatePercent],
	[ConversionOptionIndicator],
	[PaymentAdjustmentLifetimeCapAmount],
	[PaymentAdjustmentLifetimeCapPercent],
	[RateAdjustmentLifetimeCapPercent]
	) values 
	(
	@loanApplicationId,
	@indexCurrentValuePercent,
	@indexMarginPercent,
	@indexType,
	@qualifyingRatePercent,
	@conversionOptionIndicator,
	@paymentAdjustmentLifetimeCapAmount,
	@paymentAdjustmentLifetimeCapPercent,
	@rateAdjustmentLifetimeCapPercent
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: ALIAS
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateAlias
(
@borrowerId BigInt = null,
@firstName VarChar(64) = null,
@lastName VarChar(64) = null,
@middleName VarChar(64) = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [ALIAS]
	(
	[BorrowerId],
	[FirstName],
	[LastName],
	[MiddleName]
	) values 
	(
	@borrowerId,
	@firstName,
	@lastName,
	@middleName
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: ASSET
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateAsset
(
@borrowerId BigInt,
@loanApplicationId BigInt,
@accountIdentifier VarChar(64) = null,
@cashOrMarketValueAmount Money = null,
@type SmallInt,
@verifiedIndicator Bit,
@holderName VarChar(64) = null,
@holderStreetAddress VarChar(64) = null,
@holderCity VarChar(64) = null,
@holderState VarChar(64) = null,
@holderPostalCode VarChar(64) = null,
@automobileMakeDescription VarChar(64) = null,
@automobileModelYear DateTime = null,
@lifeInsuranceFaceValueAmount Money = null,
@otherAssetTypeDescription VarChar(64) = null,
@stockBondMutualFundShareCount Decimal(18,0) = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [ASSET]
	(
	[BorrowerId],
	[LoanApplicationId],
	[AccountIdentifier],
	[CashOrMarketValueAmount],
	[Type],
	[VerifiedIndicator],
	[HolderName],
	[HolderStreetAddress],
	[HolderCity],
	[HolderState],
	[HolderPostalCode],
	[AutomobileMakeDescription],
	[AutomobileModelYear],
	[LifeInsuranceFaceValueAmount],
	[OtherAssetTypeDescription],
	[StockBondMutualFundShareCount]
	) values 
	(
	@borrowerId,
	@loanApplicationId,
	@accountIdentifier,
	@cashOrMarketValueAmount,
	@type,
	@verifiedIndicator,
	@holderName,
	@holderStreetAddress,
	@holderCity,
	@holderState,
	@holderPostalCode,
	@automobileMakeDescription,
	@automobileModelYear,
	@lifeInsuranceFaceValueAmount,
	@otherAssetTypeDescription,
	@stockBondMutualFundShareCount
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BUYDOWN
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateBuydown
(
@loanApplicationId BigInt,
@changeFrequencyMonths Decimal(18,0) = null,
@durationMonths Decimal(18,0) = null,
@increaseRatePercent Decimal(8,7) = null,
@lenderFundingIndicator Bit,
@permanentIndicator Bit,
@baseDataType SmallInt = null,
@contributorType SmallInt = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [BUYDOWN]
	(
	[LoanApplicationId],
	[ChangeFrequencyMonths],
	[DurationMonths],
	[IncreaseRatePercent],
	[LenderFundingIndicator],
	[PermanentIndicator],
	[BaseDataType],
	[ContributorType]
	) values 
	(
	@loanApplicationId,
	@changeFrequencyMonths,
	@durationMonths,
	@increaseRatePercent,
	@lenderFundingIndicator,
	@permanentIndicator,
	@baseDataType,
	@contributorType
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CONSTRUCTION_REFINANCE_DATA
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateConstructionRefinanceData
(
@constructionImprovementCostsAmount Money = null,
@fRECashOutAmount Money = null,
@landEstimatedValueAmount Money = null,
@landOriginalCostAmount Money = null,
@propertyAcquiredYear DateTime = null,
@propertyExistingLienAmount Money = null,
@propertyOriginalCostAmount Money = null,
@refinanceImprovementCostsAmount Money = null,
@refinanceProposedImprovementsDescription VarChar(254) = null,
@secondaryFinancingRefinanceIndicator Bit,
@fNMSecondMortgageFinancingOriginalPropertyIndicator Bit,
@structuralAlterationsConventionalAmount Money = null,
@nonStructuralAlterationsConventionalAmount Money = null,
@constructionPurposeType SmallInt = null,
@refinanceImprovementsType SmallInt = null,
@gSERefinancePurposeType SmallInt = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [CONSTRUCTION_REFINANCE_DATA]
	(
	[LoanApplicationId],
	[ConstructionImprovementCostsAmount],
	[FRECashOutAmount],
	[LandEstimatedValueAmount],
	[LandOriginalCostAmount],
	[PropertyAcquiredYear],
	[PropertyExistingLienAmount],
	[PropertyOriginalCostAmount],
	[RefinanceImprovementCostsAmount],
	[RefinanceProposedImprovementsDescription],
	[SecondaryFinancingRefinanceIndicator],
	[FNMSecondMortgageFinancingOriginalPropertyIndicator],
	[StructuralAlterationsConventionalAmount],
	[NonStructuralAlterationsConventionalAmount],
	[ConstructionPurposeType],
	[RefinanceImprovementsType],
	[GSERefinancePurposeType]
	) values 
	(
	@loanApplicationId,
	@constructionImprovementCostsAmount,
	@fRECashOutAmount,
	@landEstimatedValueAmount,
	@landOriginalCostAmount,
	@propertyAcquiredYear,
	@propertyExistingLienAmount,
	@propertyOriginalCostAmount,
	@refinanceImprovementCostsAmount,
	@refinanceProposedImprovementsDescription,
	@secondaryFinancingRefinanceIndicator,
	@fNMSecondMortgageFinancingOriginalPropertyIndicator,
	@structuralAlterationsConventionalAmount,
	@nonStructuralAlterationsConventionalAmount,
	@constructionPurposeType,
	@refinanceImprovementsType,
	@gSERefinancePurposeType
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: CONTACT_POINT
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateContactPoint
(
@borrowerId BigInt = null,
@typeOtherDescription VarChar(254) = null,
@value VarChar(64) = null,
@preferenceIndicator Bit,
@roleType SmallInt = null,
@type SmallInt = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [CONTACT_POINT]
	(
	[BorrowerId],
	[TypeOtherDescription],
	[Value],
	[PreferenceIndicator],
	[RoleType],
	[Type]
	) values 
	(
	@borrowerId,
	@typeOtherDescription,
	@value,
	@preferenceIndicator,
	@roleType,
	@type
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: CREDIT_SCORE
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateCreditScore
(
@creditReportIdentifier VarChar(20) = null,
@creditScoreDate DateTime = null,
@creditScoreModelNameTypeOtherDescription VarChar(20) = null,
@creditScoreValue SmallInt = null,
@borrowerId BigInt,
@creditRepositorySourceType SmallInt = null,
@creditScoreExclusionType SmallInt = null,
@creditScoreModelNameType SmallInt = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [CREDIT_SCORE]
	(
	[CreditReportIdentifier],
	[CreditScoreDate],
	[CreditScoreModelNameTypeOtherDescription],
	[CreditScoreValue],
	[BorrowerId],
	[CreditRepositorySourceType],
	[CreditScoreExclusionType],
	[CreditScoreModelNameType]
	) values 
	(
	@creditReportIdentifier,
	@creditScoreDate,
	@creditScoreModelNameTypeOtherDescription,
	@creditScoreValue,
	@borrowerId,
	@creditRepositorySourceType,
	@creditScoreExclusionType,
	@creditScoreModelNameType
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: CURRENT_INCOME
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateCurrentIncome
(
@borrowerId BigInt,
@incomeType SmallInt,
@monthlyTotalAmount Money
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [CURRENT_INCOME]
	(
	[BorrowerId],
	[IncomeType],
	[MonthlyTotalAmount]
	) values 
	(
	@borrowerId,
	@incomeType,
	@monthlyTotalAmount
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: DATA_VERSION
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateDataVersion
(
@name VarChar(64),
@number VarChar(64),
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
declare @newid Int
-- assign values to variables in the proc

-- insert the new data into the table
insert into [DATA_VERSION]
	(
	[Name],
	[Number],
	[LoanApplicationId]
	) values 
	(
	@name,
	@number,
	@loanApplicationId
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DECLARATION
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateDeclaration
(
@alimonyChildSupportObligationIndicator Bit,
@bankruptcyIndicator Bit,
@borrowedDownPaymentIndicator Bit,
@coMakerEndorserOfNoteIndicator Bit,
@homeownerPastThreeYearsType Bit = null,
@intentToOccupyType Bit = null,
@loanForeclosureOrJudgementIndicator Bit,
@outstandingJudgementsIndicator Bit,
@partyToLawsuitIndicator Bit,
@presentlyDelinquentIndicator Bit,
@propertyForeclosedPastSevenYearsIndicator Bit,
@citizenshipResidencyType SmallInt = null,
@priorPropertyTitleType SmallInt = null,
@priorPropertyUsageType SmallInt = null,
@borrowerId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [DECLARATION]
	(
	[BorrowerId],
	[AlimonyChildSupportObligationIndicator],
	[BankruptcyIndicator],
	[BorrowedDownPaymentIndicator],
	[CoMakerEndorserOfNoteIndicator],
	[HomeownerPastThreeYearsType],
	[IntentToOccupyType],
	[LoanForeclosureOrJudgementIndicator],
	[OutstandingJudgementsIndicator],
	[PartyToLawsuitIndicator],
	[PresentlyDelinquentIndicator],
	[PropertyForeclosedPastSevenYearsIndicator],
	[CitizenshipResidencyType],
	[PriorPropertyTitleType],
	[PriorPropertyUsageType]
	) values 
	(
	@borrowerId,
	@alimonyChildSupportObligationIndicator,
	@bankruptcyIndicator,
	@borrowedDownPaymentIndicator,
	@coMakerEndorserOfNoteIndicator,
	@homeownerPastThreeYearsType,
	@intentToOccupyType,
	@loanForeclosureOrJudgementIndicator,
	@outstandingJudgementsIndicator,
	@partyToLawsuitIndicator,
	@presentlyDelinquentIndicator,
	@propertyForeclosedPastSevenYearsIndicator,
	@citizenshipResidencyType,
	@priorPropertyTitleType,
	@priorPropertyUsageType
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DEPENDENT
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateDependent
(
@borrowerId BigInt,
@ageYears Decimal(18,0)
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [DEPENDENT]
	(
	[BorrowerId],
	[AgeYears]
	) values 
	(
	@borrowerId,
	@ageYears
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: EMPLOYER
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateEmployer
(
@borrowerId BigInt,
@name VarChar(128) = null,
@streetAddress VarChar(128) = null,
@city VarChar(64) = null,
@state VarChar(64) = null,
@postalCode VarChar(16) = null,
@telephoneNumber VarChar(32) = null,
@currentEmploymentMonthsOnJob Decimal(18,0) = null,
@currentEmploymentTimeInLineOfWorkYears Decimal(18,0) = null,
@currentEmploymentYearsOnJob Decimal(18,0) = null,
@employmentBorrowerSelfEmployedIndicator Bit,
@employmentCurrentIndicator Bit,
@employmentPositionDescription VarChar(254) = null,
@employmentPrimaryIndicator Bit,
@incomeEmploymentMonthlyAmount Money = null,
@previousEmploymentEndDate DateTime = null,
@previousEmploymentStartDate DateTime = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [EMPLOYER]
	(
	[BorrowerId],
	[Name],
	[StreetAddress],
	[City],
	[State],
	[PostalCode],
	[TelephoneNumber],
	[CurrentEmploymentMonthsOnJob],
	[CurrentEmploymentTimeInLineOfWorkYears],
	[CurrentEmploymentYearsOnJob],
	[EmploymentBorrowerSelfEmployedIndicator],
	[EmploymentCurrentIndicator],
	[EmploymentPositionDescription],
	[EmploymentPrimaryIndicator],
	[IncomeEmploymentMonthlyAmount],
	[PreviousEmploymentEndDate],
	[PreviousEmploymentStartDate]
	) values 
	(
	@borrowerId,
	@name,
	@streetAddress,
	@city,
	@state,
	@postalCode,
	@telephoneNumber,
	@currentEmploymentMonthsOnJob,
	@currentEmploymentTimeInLineOfWorkYears,
	@currentEmploymentYearsOnJob,
	@employmentBorrowerSelfEmployedIndicator,
	@employmentCurrentIndicator,
	@employmentPositionDescription,
	@employmentPrimaryIndicator,
	@incomeEmploymentMonthlyAmount,
	@previousEmploymentEndDate,
	@previousEmploymentStartDate
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_LOAN
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateFHALoan
(
@borrowerFinancedFHADiscountPointsAmount Money = null,
@fHACoverageRenewalRatePercent Decimal(8,7) = null,
@fHA_MIPremiumRefundAmount Money = null,
@fHAUpfrontMIPremiumPercent Decimal(8,7) = null,
@lenderIdentifier VarChar(64) = null,
@sponsorIdentifier VarChar(64) = null,
@sectionOfActType SmallInt = null,
@fHAAlimonyLiabilityTreatmentType2 SmallInt = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [FHA_LOAN]
	(
	[LoanApplicationId],
	[BorrowerFinancedFHADiscountPointsAmount],
	[FHACoverageRenewalRatePercent],
	[FHA_MIPremiumRefundAmount],
	[FHAUpfrontMIPremiumPercent],
	[LenderIdentifier],
	[SponsorIdentifier],
	[SectionOfActType],
	[FHAAlimonyLiabilityTreatmentType2]
	) values 
	(
	@loanApplicationId,
	@borrowerFinancedFHADiscountPointsAmount,
	@fHACoverageRenewalRatePercent,
	@fHA_MIPremiumRefundAmount,
	@fHAUpfrontMIPremiumPercent,
	@lenderIdentifier,
	@sponsorIdentifier,
	@sectionOfActType,
	@fHAAlimonyLiabilityTreatmentType2
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_BORROWER
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateFHAVABorrower
(
@cAIVRSIdentifier VarChar(64) = null,
@fNMBankruptcyCount TinyInt = null,
@fNMBorrowerCreditRating VarChar(64) = null,
@fNMCreditReportScoreType SmallInt = null,
@fNMForeclosureCount TinyInt = null,
@veteranStatusIndicator Bit,
@borrowerId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [FHA_VA_BORROWER]
	(
	[BorrowerId],
	[CAIVRSIdentifier],
	[FNMBankruptcyCount],
	[FNMBorrowerCreditRating],
	[FNMCreditReportScoreType],
	[FNMForeclosureCount],
	[VeteranStatusIndicator]
	) values 
	(
	@borrowerId,
	@cAIVRSIdentifier,
	@fNMBankruptcyCount,
	@fNMBorrowerCreditRating,
	@fNMCreditReportScoreType,
	@fNMForeclosureCount,
	@veteranStatusIndicator
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_LOAN
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateFHAVALoan
(
@borrowerPaidFHA_VAClosingCostsAmount Money = null,
@borrowerPaidFHA_VAClosingCostsPercent Decimal(8,7) = null,
@governmentMortgageCreditCertificateAmount Money = null,
@governmentRefinanceType SmallInt = null,
@otherPartyPaidFHA_VAClosingCostsAmount Money = null,
@otherPartyPaidFHA_VAClosingCostsPercent Decimal(8,7) = null,
@propertyEnergyEfficientHomeIndicator Bit = null,
@sellerPaidFHA_VAClosingCostsPercent Decimal(8,7) = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [FHA_VA_LOAN]
	(
	[LoanApplicationId],
	[BorrowerPaidFHA_VAClosingCostsAmount],
	[BorrowerPaidFHA_VAClosingCostsPercent],
	[GovernmentMortgageCreditCertificateAmount],
	[GovernmentRefinanceType],
	[OtherPartyPaidFHA_VAClosingCostsAmount],
	[OtherPartyPaidFHA_VAClosingCostsPercent],
	[PropertyEnergyEfficientHomeIndicator],
	[SellerPaidFHA_VAClosingCostsPercent]
	) values 
	(
	@loanApplicationId,
	@borrowerPaidFHA_VAClosingCostsAmount,
	@borrowerPaidFHA_VAClosingCostsPercent,
	@governmentMortgageCreditCertificateAmount,
	@governmentRefinanceType,
	@otherPartyPaidFHA_VAClosingCostsAmount,
	@otherPartyPaidFHA_VAClosingCostsPercent,
	@propertyEnergyEfficientHomeIndicator,
	@sellerPaidFHA_VAClosingCostsPercent
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_MONITORING
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateGovernmentMonitoring
(
@genderType SmallInt = null,
@otherRaceNationalOriginDescription VarChar(64) = null,
@raceNationalOriginRefusalIndicator Bit,
@raceNationalOriginType SmallInt = null,
@hMDAEthnicityType SmallInt = null,
@borrowerId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [GOVERNMENT_MONITORING]
	(
	[BorrowerId],
	[GenderType],
	[OtherRaceNationalOriginDescription],
	[RaceNationalOriginRefusalIndicator],
	[RaceNationalOriginType],
	[HMDAEthnicityType]
	) values 
	(
	@borrowerId,
	@genderType,
	@otherRaceNationalOriginDescription,
	@raceNationalOriginRefusalIndicator,
	@raceNationalOriginType,
	@hMDAEthnicityType
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:50 AM
System User: marlon
System Machine: SERVER
Entity Name: LEGAL_DESCRIPTION
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLegalDescription
(
@loanApplicationId BigInt,
@textDescription VarChar(254) = null,
@type SmallInt
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LEGAL_DESCRIPTION]
	(
	[LoanApplicationId],
	[TextDescription],
	[Type]
	) values 
	(
	@loanApplicationId,
	@textDescription,
	@type
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LIABILITY
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLiability
(
@loanApplicationId BigInt,
@borrowerId BigInt,
@rEO_ID VarChar(64) = null,
@holderStreetAddress VarChar(64) = null,
@holderCity VarChar(64) = null,
@holderState VarChar(64) = null,
@holderPostalCode VarChar(64) = null,
@alimonyOwedToName VarChar(64) = null,
@accountIdentifier VarChar(64) = null,
@exclusionIndicator Bit,
@holderName VarChar(64) = null,
@monthlyPaymentAmount Money = null,
@payoffStatusIndicator Bit,
@payoffWithCurrentAssetsIndicator Bit,
@remainingTermMonths Decimal(18,0) = null,
@type SmallInt,
@unpaidBalanceAmount Money = null,
@subjectLoanResubordinationIndicator Bit
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LIABILITY]
	(
	[LoanApplicationId],
	[BorrowerId],
	[REO_ID],
	[HolderStreetAddress],
	[HolderCity],
	[HolderState],
	[HolderPostalCode],
	[AlimonyOwedToName],
	[AccountIdentifier],
	[ExclusionIndicator],
	[HolderName],
	[MonthlyPaymentAmount],
	[PayoffStatusIndicator],
	[PayoffWithCurrentAssetsIndicator],
	[RemainingTermMonths],
	[Type],
	[UnpaidBalanceAmount],
	[SubjectLoanResubordinationIndicator]
	) values 
	(
	@loanApplicationId,
	@borrowerId,
	@rEO_ID,
	@holderStreetAddress,
	@holderCity,
	@holderState,
	@holderPostalCode,
	@alimonyOwedToName,
	@accountIdentifier,
	@exclusionIndicator,
	@holderName,
	@monthlyPaymentAmount,
	@payoffStatusIndicator,
	@payoffWithCurrentAssetsIndicator,
	@remainingTermMonths,
	@type,
	@unpaidBalanceAmount,
	@subjectLoanResubordinationIndicator
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateLoanFeatures
(
@assumabilityIndicator Bit,
@balloonIndicator Bit,
@balloonLoanMaturityTermMonths Decimal(18,0) = null,
@buydownTemporarySubsidyIndicator Bit,
@counselingConfirmationIndicator Bit,
@escrowWaiverIndicator Bit,
@fREOfferingIdentifier VarChar(64) = null,
@fNMProductPlanIdentifier VarChar(64) = null,
@fNMProductPlanIndentifier VarChar(64) = null,
@hELOCMaximumBalanceAmount Money = null,
@hELOCInitialAdvanceAmount Money = null,
@interestOnlyTerm Decimal(18,0) = null,
@lenderSelfInsuredIndicator Bit,
@loanScheduledClosingDate DateTime = null,
@mICoveragePercent Decimal(8,7) = null,
@negativeAmortizationLimitPercent Decimal(8,7) = null,
@prepaymentPenaltyIndicator Bit,
@prepaymentPenaltyTermMonths Decimal(18,0) = null,
@prepaymentRestrictionIndicator Bit,
@productDescription VarChar(64) = null,
@productName VarChar(64) = null,
@scheduledFirstPaymentDate DateTime = null,
@nameDocumentsDrawnInType SmallInt = null,
@gSEProjectClassificationType SmallInt = null,
@gSEPropertyType SmallInt = null,
@lienPriorityType SmallInt = null,
@loanDocumentationType SmallInt = null,
@loanRepaymentType SmallInt = null,
@mICertificationStatusType SmallInt = null,
@mICompanyNameType SmallInt = null,
@paymentFrequencyType SmallInt = null,
@fullPrepaymentPenaltyOptionType SmallInt = null,
@loanClosingStatusType SmallInt = null,
@servicingTransferStatusType SmallInt = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [LOAN_FEATURES]
	(
	[LoanApplicationId],
	[AssumabilityIndicator],
	[BalloonIndicator],
	[BalloonLoanMaturityTermMonths],
	[BuydownTemporarySubsidyIndicator],
	[CounselingConfirmationIndicator],
	[EscrowWaiverIndicator],
	[FREOfferingIdentifier],
	[FNMProductPlanIdentifier],
	[FNMProductPlanIndentifier],
	[HELOCMaximumBalanceAmount],
	[HELOCInitialAdvanceAmount],
	[InterestOnlyTerm],
	[LenderSelfInsuredIndicator],
	[LoanScheduledClosingDate],
	[MICoveragePercent],
	[NegativeAmortizationLimitPercent],
	[PrepaymentPenaltyIndicator],
	[PrepaymentPenaltyTermMonths],
	[PrepaymentRestrictionIndicator],
	[ProductDescription],
	[ProductName],
	[ScheduledFirstPaymentDate],
	[NameDocumentsDrawnInType],
	[GSEProjectClassificationType],
	[GSEPropertyType],
	[LienPriorityType],
	[LoanDocumentationType],
	[LoanRepaymentType],
	[MICertificationStatusType],
	[MICompanyNameType],
	[PaymentFrequencyType],
	[FullPrepaymentPenaltyOptionType],
	[LoanClosingStatusType],
	[ServicingTransferStatusType]
	) values 
	(
	@loanApplicationId,
	@assumabilityIndicator,
	@balloonIndicator,
	@balloonLoanMaturityTermMonths,
	@buydownTemporarySubsidyIndicator,
	@counselingConfirmationIndicator,
	@escrowWaiverIndicator,
	@fREOfferingIdentifier,
	@fNMProductPlanIdentifier,
	@fNMProductPlanIndentifier,
	@hELOCMaximumBalanceAmount,
	@hELOCInitialAdvanceAmount,
	@interestOnlyTerm,
	@lenderSelfInsuredIndicator,
	@loanScheduledClosingDate,
	@mICoveragePercent,
	@negativeAmortizationLimitPercent,
	@prepaymentPenaltyIndicator,
	@prepaymentPenaltyTermMonths,
	@prepaymentRestrictionIndicator,
	@productDescription,
	@productName,
	@scheduledFirstPaymentDate,
	@nameDocumentsDrawnInType,
	@gSEProjectClassificationType,
	@gSEPropertyType,
	@lienPriorityType,
	@loanDocumentationType,
	@loanRepaymentType,
	@mICertificationStatusType,
	@mICompanyNameType,
	@paymentFrequencyType,
	@fullPrepaymentPenaltyOptionType,
	@loanClosingStatusType,
	@servicingTransferStatusType
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: MAIL_TO
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateMailTo
(
@streetAddress VarChar(128) = null,
@streetAddress2 VarChar(128) = null,
@city VarChar(64) = null,
@state VarChar(64) = null,
@postalCode VarChar(10) = null,
@country VarChar(64) = null,
@borrowerId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [MAIL_TO]
	(
	[BorrowerId],
	[StreetAddress],
	[StreetAddress2],
	[City],
	[State],
	[PostalCode],
	[Country]
	) values 
	(
	@borrowerId,
	@streetAddress,
	@streetAddress2,
	@city,
	@state,
	@postalCode,
	@country
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_SCORE
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateMortgageScore
(
@loanApplicationId BigInt,
@date DateTime = null,
@typeOtherDescription VarChar(254) = null,
@value VarChar(64),
@type SmallInt = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [MORTGAGE_SCORE]
	(
	[LoanApplicationId],
	[Date],
	[TypeOtherDescription],
	[Value],
	[Type]
	) values 
	(
	@loanApplicationId,
	@date,
	@typeOtherDescription,
	@value,
	@type
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: PARSED_STREET_ADDRESS
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateParsedStreetAddress
(
@apartmentOrUnit VarChar(64) = null,
@directionPrefix VarChar(64) = null,
@directionSuffix VarChar(64) = null,
@buildingNumber VarChar(64) = null,
@houseNumber VarChar(64) = null,
@military_APO_FPO VarChar(64) = null,
@postOfficeBox VarChar(64) = null,
@ruralRoute VarChar(64) = null,
@streetName VarChar(64) = null,
@streetSuffix VarChar(64) = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PARSED_STREET_ADDRESS]
	(
	[LoanApplicationId],
	[ApartmentOrUnit],
	[DirectionPrefix],
	[DirectionSuffix],
	[BuildingNumber],
	[HouseNumber],
	[Military_APO_FPO],
	[PostOfficeBox],
	[RuralRoute],
	[StreetName],
	[StreetSuffix]
	) values 
	(
	@loanApplicationId,
	@apartmentOrUnit,
	@directionPrefix,
	@directionSuffix,
	@buildingNumber,
	@houseNumber,
	@military_APO_FPO,
	@postOfficeBox,
	@ruralRoute,
	@streetName,
	@streetSuffix
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: PAYMENT_ADJUSTMENT
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreatePaymentAdjustment
(
@loanApplicationId BigInt,
@firstPaymentAdjustmentMonths Decimal(18,0) = null,
@amount Money = null,
@calculationType SmallInt,
@durationMonths Decimal(18,0) = null,
@percent Decimal(8,7) = null,
@periodicCapAmount Money = null,
@periodicCapPercent Decimal(8,7) = null,
@periodNumber VarChar(64) = null,
@subsequentPaymentAdjustmentMonths Decimal(18,0) = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PAYMENT_ADJUSTMENT]
	(
	[LoanApplicationId],
	[FirstPaymentAdjustmentMonths],
	[Amount],
	[CalculationType],
	[DurationMonths],
	[Percent],
	[PeriodicCapAmount],
	[PeriodicCapPercent],
	[PeriodNumber],
	[SubsequentPaymentAdjustmentMonths]
	) values 
	(
	@loanApplicationId,
	@firstPaymentAdjustmentMonths,
	@amount,
	@calculationType,
	@durationMonths,
	@percent,
	@periodicCapAmount,
	@periodicCapPercent,
	@periodNumber,
	@subsequentPaymentAdjustmentMonths
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PRESENT_HOUSING_EXPENSE
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreatePresentHousingExpense
(
@borrowerId BigInt,
@paymentAmount Money,
@housingExpenseType SmallInt
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PRESENT_HOUSING_EXPENSE]
	(
	[BorrowerId],
	[PaymentAmount],
	[HousingExpenseType]
	) values 
	(
	@borrowerId,
	@paymentAmount,
	@housingExpenseType
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PURCHASE_CREDIT
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreatePurchaseCredit
(
@amount Money = null,
@sourceType SmallInt = null,
@loanApplicationId BigInt,
@type SmallInt = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [PURCHASE_CREDIT]
	(
	[Amount],
	[SourceType],
	[LoanApplicationId],
	[Type]
	) values 
	(
	@amount,
	@sourceType,
	@loanApplicationId,
	@type
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RATE_ADJUSTMENT
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateRateAdjustment
(
@loanApplicationId BigInt,
@firstRateAdjustmentMonths Decimal(18,0) = null,
@calculationType SmallInt,
@durationMonths Decimal(18,0) = null,
@percent Decimal(8,7) = null,
@periodNumber Decimal(18,0) = null,
@subsequentCapPercent Decimal(8,7) = null,
@subsequentRateAdjustmentMonths Decimal(18,0) = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [RATE_ADJUSTMENT]
	(
	[LoanApplicationId],
	[FirstRateAdjustmentMonths],
	[CalculationType],
	[DurationMonths],
	[Percent],
	[PeriodNumber],
	[SubsequentCapPercent],
	[SubsequentRateAdjustmentMonths]
	) values 
	(
	@loanApplicationId,
	@firstRateAdjustmentMonths,
	@calculationType,
	@durationMonths,
	@percent,
	@periodNumber,
	@subsequentCapPercent,
	@subsequentRateAdjustmentMonths
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:05 AM
System User: marlon
System Machine: SERVER
Entity Name: RESIDENCE
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateResidence
(
@borrowerId BigInt = null,
@streetAddress VarChar(128) = null,
@city VarChar(64) = null,
@state VarChar(64) = null,
@postalCode VarChar(64) = null,
@country VarChar(64) = null,
@borrowerResidencyDurationMonths Decimal(18,0) = null,
@borrowerResidencyDurationYears Decimal(18,0) = null,
@borrowerResidencyBasisType SmallInt = null,
@borrowerResidencyType SmallInt = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [RESIDENCE]
	(
	[BorrowerId],
	[StreetAddress],
	[City],
	[State],
	[PostalCode],
	[Country],
	[BorrowerResidencyDurationMonths],
	[BorrowerResidencyDurationYears],
	[BorrowerResidencyBasisType],
	[BorrowerResidencyType]
	) values 
	(
	@borrowerId,
	@streetAddress,
	@city,
	@state,
	@postalCode,
	@country,
	@borrowerResidencyDurationMonths,
	@borrowerResidencyDurationYears,
	@borrowerResidencyBasisType,
	@borrowerResidencyType
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: SUMMARY
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateSummary
(
@borrowerId BigInt = null,
@amount Money = null,
@amountType SmallInt = null,
@id BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [SUMMARY]
	(
	[Id],
	[BorrowerId],
	[Amount],
	[AmountType]
	) values 
	(
	@id,
	@borrowerId,
	@amount,
	@amountType
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSMITTAL_DATA
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateTransmittalData
(
@armsLengthIndicator Bit,
@belowMarketSubordinateFinancingIndicator Bit,
@buydownRatePercent Decimal(8,7) = null,
@creditReportAuthorizationIndicator Bit,
@lenderBranchIdentifier VarChar(64) = null,
@lenderRegistrationIdentifier VarChar(64) = null,
@propertyAppraisedValueAmount Money = null,
@propertyEstimatedValueAmount Money = null,
@investorLoanIdentifier VarChar(64) = null,
@investorInstitutionIdentifier VarChar(64) = null,
@commitmentReferenceIdentifier VarChar(64) = null,
@concurrentOriginationIndicator Bit,
@concurrentOriginationLenderIndicator Bit,
@rateLockPeriodDays SmallInt = null,
@rateLockRequestedExtensionDays SmallInt = null,
@caseStateType SmallInt = null,
@rateLockType SmallInt = null,
@currentFirstMortgageHolderType SmallInt = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [TRANSMITTAL_DATA]
	(
	[LoanApplicationId],
	[ArmsLengthIndicator],
	[BelowMarketSubordinateFinancingIndicator],
	[BuydownRatePercent],
	[CreditReportAuthorizationIndicator],
	[LenderBranchIdentifier],
	[LenderRegistrationIdentifier],
	[PropertyAppraisedValueAmount],
	[PropertyEstimatedValueAmount],
	[InvestorLoanIdentifier],
	[InvestorInstitutionIdentifier],
	[CommitmentReferenceIdentifier],
	[ConcurrentOriginationIndicator],
	[ConcurrentOriginationLenderIndicator],
	[RateLockPeriodDays],
	[RateLockRequestedExtensionDays],
	[CaseStateType],
	[RateLockType],
	[CurrentFirstMortgageHolderType]
	) values 
	(
	@loanApplicationId,
	@armsLengthIndicator,
	@belowMarketSubordinateFinancingIndicator,
	@buydownRatePercent,
	@creditReportAuthorizationIndicator,
	@lenderBranchIdentifier,
	@lenderRegistrationIdentifier,
	@propertyAppraisedValueAmount,
	@propertyEstimatedValueAmount,
	@investorLoanIdentifier,
	@investorInstitutionIdentifier,
	@commitmentReferenceIdentifier,
	@concurrentOriginationIndicator,
	@concurrentOriginationLenderIndicator,
	@rateLockPeriodDays,
	@rateLockRequestedExtensionDays,
	@caseStateType,
	@rateLockType,
	@currentFirstMortgageHolderType
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: VA_BORROWER
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateVABorrower
(
@vACoBorrowerNonTaxableIncomeAmount Money = null,
@vACoBorrowerTaxableIncomeAmount Money = null,
@vAFederalTaxAmount Money = null,
@vALocalTaxAmount Money = null,
@vAPrimaryBorrowerNonTaxableIncomeAmount Money = null,
@vAPrimaryBorrowerTaxableIncomeAmount Money = null,
@vASocialSecurityTaxAmount Money = null,
@vAStateTaxAmount Money = null,
@borrowerId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [VA_BORROWER]
	(
	[BorrowerId],
	[VACoBorrowerNonTaxableIncomeAmount],
	[VACoBorrowerTaxableIncomeAmount],
	[VAFederalTaxAmount],
	[VALocalTaxAmount],
	[VAPrimaryBorrowerNonTaxableIncomeAmount],
	[VAPrimaryBorrowerTaxableIncomeAmount],
	[VASocialSecurityTaxAmount],
	[VAStateTaxAmount]
	) values 
	(
	@borrowerId,
	@vACoBorrowerNonTaxableIncomeAmount,
	@vACoBorrowerTaxableIncomeAmount,
	@vAFederalTaxAmount,
	@vALocalTaxAmount,
	@vAPrimaryBorrowerNonTaxableIncomeAmount,
	@vAPrimaryBorrowerTaxableIncomeAmount,
	@vASocialSecurityTaxAmount,
	@vAStateTaxAmount
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: VA_LOAN
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateVALoan
(
@vABorrowerCoBorrowerMarriedIndicator Bit,
@borrowerFundingFeePercent Decimal(8,7) = null,
@vAEntitlementAmount Money = null,
@vAMaintenanceExpenseMonthlyAmount Money = null,
@vAResidualIncomeAmount Money = null,
@vAUtilityExpenseMonthlyAmount Money = null,
@loanApplicationId BigInt
)
as


-- declare variables for use in the proc
-- assign values to variables in the proc

-- insert the new data into the table
insert into [VA_LOAN]
	(
	[LoanApplicationId],
	[VABorrowerCoBorrowerMarriedIndicator],
	[BorrowerFundingFeePercent],
	[VAEntitlementAmount],
	[VAMaintenanceExpenseMonthlyAmount],
	[VAResidualIncomeAmount],
	[VAUtilityExpenseMonthlyAmount]
	) values 
	(
	@loanApplicationId,
	@vABorrowerCoBorrowerMarriedIndicator,
	@borrowerFundingFeePercent,
	@vAEntitlementAmount,
	@vAMaintenanceExpenseMonthlyAmount,
	@vAResidualIncomeAmount,
	@vAUtilityExpenseMonthlyAmount
	)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:09 AM
System User: marlon
System Machine: SERVER
Entity Name: VALUATION
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateValuation
(
@loanApplicationId BigInt,
@appraiserId Int = null,
@methodTypeOtherDescription VarChar(254) = null,
@methodType SmallInt = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [VALUATION]
	(
	[LoanApplicationId],
	[AppraiserId],
	[MethodTypeOtherDescription],
	[MethodType]
	) values 
	(
	@loanApplicationId,
	@appraiserId,
	@methodTypeOtherDescription,
	@methodType
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: ARM
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteARM
(
@loanApplicationId BigInt
)
as


delete from [ARM] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: ALIAS
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteAlias
(
@id BigInt
)
as


delete from [ALIAS] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: ASSET
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteAsset
(
@id BigInt
)
as


delete from [ASSET] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BUYDOWN
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteBuydown
(
@id BigInt
)
as


delete from [BUYDOWN] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CONSTRUCTION_REFINANCE_DATA
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteConstructionRefinanceData
(
@loanApplicationId BigInt
)
as


delete from [CONSTRUCTION_REFINANCE_DATA] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: CONTACT_POINT
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteContactPoint
(
@id BigInt
)
as


delete from [CONTACT_POINT] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: CREDIT_SCORE
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteCreditScore
(
@creditScoreID BigInt
)
as


delete from [CREDIT_SCORE] where 
	[CreditScoreID] = @creditScoreID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: CURRENT_INCOME
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteCurrentIncome
(
@id BigInt
)
as


delete from [CURRENT_INCOME] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: DATA_VERSION
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteDataVersion
(
@id Int
)
as


delete from [DATA_VERSION] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DECLARATION
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteDeclaration
(
@borrowerId BigInt
)
as


delete from [DECLARATION] where 
	[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DEPENDENT
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteDependent
(
@id BigInt
)
as


delete from [DEPENDENT] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: EMPLOYER
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteEmployer
(
@id BigInt
)
as


delete from [EMPLOYER] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_LOAN
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteFHALoan
(
@loanApplicationId BigInt
)
as


delete from [FHA_LOAN] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_BORROWER
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteFHAVABorrower
(
@borrowerId BigInt
)
as


delete from [FHA_VA_BORROWER] where 
	[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_LOAN
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteFHAVALoan
(
@loanApplicationId BigInt
)
as


delete from [FHA_VA_LOAN] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_MONITORING
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteGovernmentMonitoring
(
@borrowerId BigInt
)
as


delete from [GOVERNMENT_MONITORING] where 
	[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:50 AM
System User: marlon
System Machine: SERVER
Entity Name: LEGAL_DESCRIPTION
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLegalDescription
(
@id BigInt
)
as


delete from [LEGAL_DESCRIPTION] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LIABILITY
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLiability
(
@id BigInt
)
as


delete from [LIABILITY] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteLoanFeatures
(
@loanApplicationId BigInt
)
as


delete from [LOAN_FEATURES] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: MAIL_TO
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteMailTo
(
@borrowerId BigInt
)
as


delete from [MAIL_TO] where 
	[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_SCORE
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteMortgageScore
(
@id BigInt
)
as


delete from [MORTGAGE_SCORE] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: PARSED_STREET_ADDRESS
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteParsedStreetAddress
(
@loanApplicationId BigInt
)
as


delete from [PARSED_STREET_ADDRESS] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: PAYMENT_ADJUSTMENT
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeletePaymentAdjustment
(
@id BigInt
)
as


delete from [PAYMENT_ADJUSTMENT] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PRESENT_HOUSING_EXPENSE
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeletePresentHousingExpense
(
@id BigInt
)
as


delete from [PRESENT_HOUSING_EXPENSE] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PURCHASE_CREDIT
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeletePurchaseCredit
(
@id BigInt
)
as


delete from [PURCHASE_CREDIT] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RATE_ADJUSTMENT
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteRateAdjustment
(
@id BigInt
)
as


delete from [RATE_ADJUSTMENT] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:05 AM
System User: marlon
System Machine: SERVER
Entity Name: RESIDENCE
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteResidence
(
@id BigInt
)
as


delete from [RESIDENCE] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: SUMMARY
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteSummary
(
@id BigInt
)
as


delete from [SUMMARY] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSMITTAL_DATA
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteTransmittalData
(
@loanApplicationId BigInt
)
as


delete from [TRANSMITTAL_DATA] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: VA_BORROWER
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteVABorrower
(
@borrowerId BigInt
)
as


delete from [VA_BORROWER] where 
	[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: VA_LOAN
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteVALoan
(
@loanApplicationId BigInt
)
as


delete from [VA_LOAN] where 
	[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:09 AM
System User: marlon
System Machine: SERVER
Entity Name: VALUATION
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteValuation
(
@id BigInt
)
as


delete from [VALUATION] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: ARM
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectARM
(
@loanApplicationId BigInt
)
as


select 
	[ARM].[LoanApplicationId],
	[ARM].[IndexCurrentValuePercent],
	[ARM].[IndexMarginPercent],
	[ARM].[IndexType],
	[ARM].[QualifyingRatePercent],
	[ARM].[ConversionOptionIndicator],
	[ARM].[PaymentAdjustmentLifetimeCapAmount],
	[ARM].[PaymentAdjustmentLifetimeCapPercent],
	[ARM].[RateAdjustmentLifetimeCapPercent]
from 
	[ARM] 
where 
	[ARM].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: ARM
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectARMCollection
as


select 
	[ARM].[LoanApplicationId],
	[ARM].[IndexCurrentValuePercent],
	[ARM].[IndexMarginPercent],
	[ARM].[IndexType],
	[ARM].[QualifyingRatePercent],
	[ARM].[ConversionOptionIndicator],
	[ARM].[PaymentAdjustmentLifetimeCapAmount],
	[ARM].[PaymentAdjustmentLifetimeCapPercent],
	[ARM].[RateAdjustmentLifetimeCapPercent]
from 
	[ARM] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: ARM
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectARMCollectionByInterestRateIndex
(
@indexType SmallInt = null
)
as


select 
	[ARM].[LoanApplicationId],
	[ARM].[IndexCurrentValuePercent],
	[ARM].[IndexMarginPercent],
	[ARM].[IndexType],
	[ARM].[QualifyingRatePercent],
	[ARM].[ConversionOptionIndicator],
	[ARM].[PaymentAdjustmentLifetimeCapAmount],
	[ARM].[PaymentAdjustmentLifetimeCapPercent],
	[ARM].[RateAdjustmentLifetimeCapPercent]
from 
	[ARM] 
where 
	[ARM].[IndexType] = @indexType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: ARM
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectARMCollectionByLoanProductData
(
@loanApplicationId BigInt
)
as


select 
	[ARM].[LoanApplicationId],
	[ARM].[IndexCurrentValuePercent],
	[ARM].[IndexMarginPercent],
	[ARM].[IndexType],
	[ARM].[QualifyingRatePercent],
	[ARM].[ConversionOptionIndicator],
	[ARM].[PaymentAdjustmentLifetimeCapAmount],
	[ARM].[PaymentAdjustmentLifetimeCapPercent],
	[ARM].[RateAdjustmentLifetimeCapPercent]
from 
	[ARM] 
where 
	[ARM].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: ALIAS
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectAlias
(
@id BigInt
)
as


select 
	[ALIAS].[Id],
	[ALIAS].[BorrowerId],
	[ALIAS].[FirstName],
	[ALIAS].[LastName],
	[ALIAS].[MiddleName]
from 
	[ALIAS] 
where 
	[ALIAS].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: ALIAS
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectAliases
as


select 
	[ALIAS].[Id],
	[ALIAS].[BorrowerId],
	[ALIAS].[FirstName],
	[ALIAS].[LastName],
	[ALIAS].[MiddleName]
from 
	[ALIAS] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: ALIAS
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectAliasesByBorrower
(
@borrowerId BigInt = null
)
as


select 
	[ALIAS].[Id],
	[ALIAS].[BorrowerId],
	[ALIAS].[FirstName],
	[ALIAS].[LastName],
	[ALIAS].[MiddleName]
from 
	[ALIAS] 
where 
	[ALIAS].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: ASSET
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectAsset
(
@id BigInt
)
as


select 
	[ASSET].[Id],
	[ASSET].[BorrowerId],
	[ASSET].[LoanApplicationId],
	[ASSET].[AccountIdentifier],
	[ASSET].[CashOrMarketValueAmount],
	[ASSET].[Type],
	[ASSET].[VerifiedIndicator],
	[ASSET].[HolderName],
	[ASSET].[HolderStreetAddress],
	[ASSET].[HolderCity],
	[ASSET].[HolderState],
	[ASSET].[HolderPostalCode],
	[ASSET].[AutomobileMakeDescription],
	[ASSET].[AutomobileModelYear],
	[ASSET].[LifeInsuranceFaceValueAmount],
	[ASSET].[OtherAssetTypeDescription],
	[ASSET].[StockBondMutualFundShareCount]
from 
	[ASSET] 
where 
	[ASSET].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: ASSET
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectAssets
as


select 
	[ASSET].[Id],
	[ASSET].[BorrowerId],
	[ASSET].[LoanApplicationId],
	[ASSET].[AccountIdentifier],
	[ASSET].[CashOrMarketValueAmount],
	[ASSET].[Type],
	[ASSET].[VerifiedIndicator],
	[ASSET].[HolderName],
	[ASSET].[HolderStreetAddress],
	[ASSET].[HolderCity],
	[ASSET].[HolderState],
	[ASSET].[HolderPostalCode],
	[ASSET].[AutomobileMakeDescription],
	[ASSET].[AutomobileModelYear],
	[ASSET].[LifeInsuranceFaceValueAmount],
	[ASSET].[OtherAssetTypeDescription],
	[ASSET].[StockBondMutualFundShareCount]
from 
	[ASSET] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: ASSET
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectAssetsByAssetType
(
@type SmallInt
)
as


select 
	[ASSET].[Id],
	[ASSET].[BorrowerId],
	[ASSET].[LoanApplicationId],
	[ASSET].[AccountIdentifier],
	[ASSET].[CashOrMarketValueAmount],
	[ASSET].[Type],
	[ASSET].[VerifiedIndicator],
	[ASSET].[HolderName],
	[ASSET].[HolderStreetAddress],
	[ASSET].[HolderCity],
	[ASSET].[HolderState],
	[ASSET].[HolderPostalCode],
	[ASSET].[AutomobileMakeDescription],
	[ASSET].[AutomobileModelYear],
	[ASSET].[LifeInsuranceFaceValueAmount],
	[ASSET].[OtherAssetTypeDescription],
	[ASSET].[StockBondMutualFundShareCount]
from 
	[ASSET] 
where 
	[ASSET].[Type] = @type
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: ASSET
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectAssetsByBorrower
(
@borrowerId BigInt
)
as


select 
	[ASSET].[Id],
	[ASSET].[BorrowerId],
	[ASSET].[LoanApplicationId],
	[ASSET].[AccountIdentifier],
	[ASSET].[CashOrMarketValueAmount],
	[ASSET].[Type],
	[ASSET].[VerifiedIndicator],
	[ASSET].[HolderName],
	[ASSET].[HolderStreetAddress],
	[ASSET].[HolderCity],
	[ASSET].[HolderState],
	[ASSET].[HolderPostalCode],
	[ASSET].[AutomobileMakeDescription],
	[ASSET].[AutomobileModelYear],
	[ASSET].[LifeInsuranceFaceValueAmount],
	[ASSET].[OtherAssetTypeDescription],
	[ASSET].[StockBondMutualFundShareCount]
from 
	[ASSET] 
where 
	[ASSET].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: ASSET
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectAssetsByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[ASSET].[Id],
	[ASSET].[BorrowerId],
	[ASSET].[LoanApplicationId],
	[ASSET].[AccountIdentifier],
	[ASSET].[CashOrMarketValueAmount],
	[ASSET].[Type],
	[ASSET].[VerifiedIndicator],
	[ASSET].[HolderName],
	[ASSET].[HolderStreetAddress],
	[ASSET].[HolderCity],
	[ASSET].[HolderState],
	[ASSET].[HolderPostalCode],
	[ASSET].[AutomobileMakeDescription],
	[ASSET].[AutomobileModelYear],
	[ASSET].[LifeInsuranceFaceValueAmount],
	[ASSET].[OtherAssetTypeDescription],
	[ASSET].[StockBondMutualFundShareCount]
from 
	[ASSET] 
where 
	[ASSET].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BUYDOWN
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectBuydown
(
@id BigInt
)
as


select 
	[BUYDOWN].[Id],
	[BUYDOWN].[LoanApplicationId],
	[BUYDOWN].[ChangeFrequencyMonths],
	[BUYDOWN].[DurationMonths],
	[BUYDOWN].[IncreaseRatePercent],
	[BUYDOWN].[LenderFundingIndicator],
	[BUYDOWN].[PermanentIndicator],
	[BUYDOWN].[BaseDataType],
	[BUYDOWN].[ContributorType]
from 
	[BUYDOWN] 
where 
	[BUYDOWN].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BUYDOWN
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectBuydownCollection
as


select 
	[BUYDOWN].[Id],
	[BUYDOWN].[LoanApplicationId],
	[BUYDOWN].[ChangeFrequencyMonths],
	[BUYDOWN].[DurationMonths],
	[BUYDOWN].[IncreaseRatePercent],
	[BUYDOWN].[LenderFundingIndicator],
	[BUYDOWN].[PermanentIndicator],
	[BUYDOWN].[BaseDataType],
	[BUYDOWN].[ContributorType]
from 
	[BUYDOWN] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BUYDOWN
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectBuydownCollectionByBaseDataType
(
@baseDataType SmallInt = null
)
as


select 
	[BUYDOWN].[Id],
	[BUYDOWN].[LoanApplicationId],
	[BUYDOWN].[ChangeFrequencyMonths],
	[BUYDOWN].[DurationMonths],
	[BUYDOWN].[IncreaseRatePercent],
	[BUYDOWN].[LenderFundingIndicator],
	[BUYDOWN].[PermanentIndicator],
	[BUYDOWN].[BaseDataType],
	[BUYDOWN].[ContributorType]
from 
	[BUYDOWN] 
where 
	[BUYDOWN].[BaseDataType] = @baseDataType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: BUYDOWN
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectBuydownCollectionByContributorType
(
@contributorType SmallInt = null
)
as


select 
	[BUYDOWN].[Id],
	[BUYDOWN].[LoanApplicationId],
	[BUYDOWN].[ChangeFrequencyMonths],
	[BUYDOWN].[DurationMonths],
	[BUYDOWN].[IncreaseRatePercent],
	[BUYDOWN].[LenderFundingIndicator],
	[BUYDOWN].[PermanentIndicator],
	[BUYDOWN].[BaseDataType],
	[BUYDOWN].[ContributorType]
from 
	[BUYDOWN] 
where 
	[BUYDOWN].[ContributorType] = @contributorType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: BUYDOWN
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectBuydownCollectionByLoanProductData
(
@loanApplicationId BigInt
)
as


select 
	[BUYDOWN].[Id],
	[BUYDOWN].[LoanApplicationId],
	[BUYDOWN].[ChangeFrequencyMonths],
	[BUYDOWN].[DurationMonths],
	[BUYDOWN].[IncreaseRatePercent],
	[BUYDOWN].[LenderFundingIndicator],
	[BUYDOWN].[PermanentIndicator],
	[BUYDOWN].[BaseDataType],
	[BUYDOWN].[ContributorType]
from 
	[BUYDOWN] 
where 
	[BUYDOWN].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CONSTRUCTION_REFINANCE_DATA
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectConstructionRefinanceData
(
@loanApplicationId BigInt
)
as


select 
	[CONSTRUCTION_REFINANCE_DATA].[LoanApplicationId],
	[CONSTRUCTION_REFINANCE_DATA].[ConstructionImprovementCostsAmount],
	[CONSTRUCTION_REFINANCE_DATA].[FRECashOutAmount],
	[CONSTRUCTION_REFINANCE_DATA].[LandEstimatedValueAmount],
	[CONSTRUCTION_REFINANCE_DATA].[LandOriginalCostAmount],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyAcquiredYear],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyExistingLienAmount],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyOriginalCostAmount],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceImprovementCostsAmount],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceProposedImprovementsDescription],
	[CONSTRUCTION_REFINANCE_DATA].[SecondaryFinancingRefinanceIndicator],
	[CONSTRUCTION_REFINANCE_DATA].[FNMSecondMortgageFinancingOriginalPropertyIndicator],
	[CONSTRUCTION_REFINANCE_DATA].[StructuralAlterationsConventionalAmount],
	[CONSTRUCTION_REFINANCE_DATA].[NonStructuralAlterationsConventionalAmount],
	[CONSTRUCTION_REFINANCE_DATA].[ConstructionPurposeType],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceImprovementsType],
	[CONSTRUCTION_REFINANCE_DATA].[GSERefinancePurposeType]
from 
	[CONSTRUCTION_REFINANCE_DATA] 
where 
	[CONSTRUCTION_REFINANCE_DATA].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CONSTRUCTION_REFINANCE_DATA
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectConstructionRefinanceDataCollection
as


select 
	[CONSTRUCTION_REFINANCE_DATA].[LoanApplicationId],
	[CONSTRUCTION_REFINANCE_DATA].[ConstructionImprovementCostsAmount],
	[CONSTRUCTION_REFINANCE_DATA].[FRECashOutAmount],
	[CONSTRUCTION_REFINANCE_DATA].[LandEstimatedValueAmount],
	[CONSTRUCTION_REFINANCE_DATA].[LandOriginalCostAmount],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyAcquiredYear],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyExistingLienAmount],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyOriginalCostAmount],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceImprovementCostsAmount],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceProposedImprovementsDescription],
	[CONSTRUCTION_REFINANCE_DATA].[SecondaryFinancingRefinanceIndicator],
	[CONSTRUCTION_REFINANCE_DATA].[FNMSecondMortgageFinancingOriginalPropertyIndicator],
	[CONSTRUCTION_REFINANCE_DATA].[StructuralAlterationsConventionalAmount],
	[CONSTRUCTION_REFINANCE_DATA].[NonStructuralAlterationsConventionalAmount],
	[CONSTRUCTION_REFINANCE_DATA].[ConstructionPurposeType],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceImprovementsType],
	[CONSTRUCTION_REFINANCE_DATA].[GSERefinancePurposeType]
from 
	[CONSTRUCTION_REFINANCE_DATA] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CONSTRUCTION_REFINANCE_DATA
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectConstructionRefinanceDataCollectionByConstructionPurposeType
(
@constructionPurposeType SmallInt = null
)
as


select 
	[CONSTRUCTION_REFINANCE_DATA].[LoanApplicationId],
	[CONSTRUCTION_REFINANCE_DATA].[ConstructionImprovementCostsAmount],
	[CONSTRUCTION_REFINANCE_DATA].[FRECashOutAmount],
	[CONSTRUCTION_REFINANCE_DATA].[LandEstimatedValueAmount],
	[CONSTRUCTION_REFINANCE_DATA].[LandOriginalCostAmount],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyAcquiredYear],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyExistingLienAmount],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyOriginalCostAmount],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceImprovementCostsAmount],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceProposedImprovementsDescription],
	[CONSTRUCTION_REFINANCE_DATA].[SecondaryFinancingRefinanceIndicator],
	[CONSTRUCTION_REFINANCE_DATA].[FNMSecondMortgageFinancingOriginalPropertyIndicator],
	[CONSTRUCTION_REFINANCE_DATA].[StructuralAlterationsConventionalAmount],
	[CONSTRUCTION_REFINANCE_DATA].[NonStructuralAlterationsConventionalAmount],
	[CONSTRUCTION_REFINANCE_DATA].[ConstructionPurposeType],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceImprovementsType],
	[CONSTRUCTION_REFINANCE_DATA].[GSERefinancePurposeType]
from 
	[CONSTRUCTION_REFINANCE_DATA] 
where 
	[CONSTRUCTION_REFINANCE_DATA].[ConstructionPurposeType] = @constructionPurposeType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CONSTRUCTION_REFINANCE_DATA
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectConstructionRefinanceDataCollectionByGSERefinancePurposeType
(
@gSERefinancePurposeType SmallInt = null
)
as


select 
	[CONSTRUCTION_REFINANCE_DATA].[LoanApplicationId],
	[CONSTRUCTION_REFINANCE_DATA].[ConstructionImprovementCostsAmount],
	[CONSTRUCTION_REFINANCE_DATA].[FRECashOutAmount],
	[CONSTRUCTION_REFINANCE_DATA].[LandEstimatedValueAmount],
	[CONSTRUCTION_REFINANCE_DATA].[LandOriginalCostAmount],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyAcquiredYear],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyExistingLienAmount],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyOriginalCostAmount],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceImprovementCostsAmount],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceProposedImprovementsDescription],
	[CONSTRUCTION_REFINANCE_DATA].[SecondaryFinancingRefinanceIndicator],
	[CONSTRUCTION_REFINANCE_DATA].[FNMSecondMortgageFinancingOriginalPropertyIndicator],
	[CONSTRUCTION_REFINANCE_DATA].[StructuralAlterationsConventionalAmount],
	[CONSTRUCTION_REFINANCE_DATA].[NonStructuralAlterationsConventionalAmount],
	[CONSTRUCTION_REFINANCE_DATA].[ConstructionPurposeType],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceImprovementsType],
	[CONSTRUCTION_REFINANCE_DATA].[GSERefinancePurposeType]
from 
	[CONSTRUCTION_REFINANCE_DATA] 
where 
	[CONSTRUCTION_REFINANCE_DATA].[GSERefinancePurposeType] = @gSERefinancePurposeType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CONSTRUCTION_REFINANCE_DATA
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectConstructionRefinanceDataCollectionByLoanPurpose
(
@loanApplicationId BigInt
)
as


select 
	[CONSTRUCTION_REFINANCE_DATA].[LoanApplicationId],
	[CONSTRUCTION_REFINANCE_DATA].[ConstructionImprovementCostsAmount],
	[CONSTRUCTION_REFINANCE_DATA].[FRECashOutAmount],
	[CONSTRUCTION_REFINANCE_DATA].[LandEstimatedValueAmount],
	[CONSTRUCTION_REFINANCE_DATA].[LandOriginalCostAmount],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyAcquiredYear],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyExistingLienAmount],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyOriginalCostAmount],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceImprovementCostsAmount],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceProposedImprovementsDescription],
	[CONSTRUCTION_REFINANCE_DATA].[SecondaryFinancingRefinanceIndicator],
	[CONSTRUCTION_REFINANCE_DATA].[FNMSecondMortgageFinancingOriginalPropertyIndicator],
	[CONSTRUCTION_REFINANCE_DATA].[StructuralAlterationsConventionalAmount],
	[CONSTRUCTION_REFINANCE_DATA].[NonStructuralAlterationsConventionalAmount],
	[CONSTRUCTION_REFINANCE_DATA].[ConstructionPurposeType],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceImprovementsType],
	[CONSTRUCTION_REFINANCE_DATA].[GSERefinancePurposeType]
from 
	[CONSTRUCTION_REFINANCE_DATA] 
where 
	[CONSTRUCTION_REFINANCE_DATA].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: CONSTRUCTION_REFINANCE_DATA
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectConstructionRefinanceDataCollectionByRefinanceImprovementsType
(
@refinanceImprovementsType SmallInt = null
)
as


select 
	[CONSTRUCTION_REFINANCE_DATA].[LoanApplicationId],
	[CONSTRUCTION_REFINANCE_DATA].[ConstructionImprovementCostsAmount],
	[CONSTRUCTION_REFINANCE_DATA].[FRECashOutAmount],
	[CONSTRUCTION_REFINANCE_DATA].[LandEstimatedValueAmount],
	[CONSTRUCTION_REFINANCE_DATA].[LandOriginalCostAmount],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyAcquiredYear],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyExistingLienAmount],
	[CONSTRUCTION_REFINANCE_DATA].[PropertyOriginalCostAmount],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceImprovementCostsAmount],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceProposedImprovementsDescription],
	[CONSTRUCTION_REFINANCE_DATA].[SecondaryFinancingRefinanceIndicator],
	[CONSTRUCTION_REFINANCE_DATA].[FNMSecondMortgageFinancingOriginalPropertyIndicator],
	[CONSTRUCTION_REFINANCE_DATA].[StructuralAlterationsConventionalAmount],
	[CONSTRUCTION_REFINANCE_DATA].[NonStructuralAlterationsConventionalAmount],
	[CONSTRUCTION_REFINANCE_DATA].[ConstructionPurposeType],
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceImprovementsType],
	[CONSTRUCTION_REFINANCE_DATA].[GSERefinancePurposeType]
from 
	[CONSTRUCTION_REFINANCE_DATA] 
where 
	[CONSTRUCTION_REFINANCE_DATA].[RefinanceImprovementsType] = @refinanceImprovementsType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: CONTACT_POINT
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectContactPoint
(
@id BigInt
)
as


select 
	[CONTACT_POINT].[Id],
	[CONTACT_POINT].[BorrowerId],
	[CONTACT_POINT].[TypeOtherDescription],
	[CONTACT_POINT].[Value],
	[CONTACT_POINT].[PreferenceIndicator],
	[CONTACT_POINT].[RoleType],
	[CONTACT_POINT].[Type]
from 
	[CONTACT_POINT] 
where 
	[CONTACT_POINT].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: CONTACT_POINT
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectContactPointCollection
as


select 
	[CONTACT_POINT].[Id],
	[CONTACT_POINT].[BorrowerId],
	[CONTACT_POINT].[TypeOtherDescription],
	[CONTACT_POINT].[Value],
	[CONTACT_POINT].[PreferenceIndicator],
	[CONTACT_POINT].[RoleType],
	[CONTACT_POINT].[Type]
from 
	[CONTACT_POINT] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: CONTACT_POINT
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectContactPointCollectionByBorrower
(
@borrowerId BigInt = null
)
as


select 
	[CONTACT_POINT].[Id],
	[CONTACT_POINT].[BorrowerId],
	[CONTACT_POINT].[TypeOtherDescription],
	[CONTACT_POINT].[Value],
	[CONTACT_POINT].[PreferenceIndicator],
	[CONTACT_POINT].[RoleType],
	[CONTACT_POINT].[Type]
from 
	[CONTACT_POINT] 
where 
	[CONTACT_POINT].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: CONTACT_POINT
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectContactPointCollectionByContactPointRoleType
(
@roleType SmallInt = null
)
as


select 
	[CONTACT_POINT].[Id],
	[CONTACT_POINT].[BorrowerId],
	[CONTACT_POINT].[TypeOtherDescription],
	[CONTACT_POINT].[Value],
	[CONTACT_POINT].[PreferenceIndicator],
	[CONTACT_POINT].[RoleType],
	[CONTACT_POINT].[Type]
from 
	[CONTACT_POINT] 
where 
	[CONTACT_POINT].[RoleType] = @roleType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: CONTACT_POINT
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectContactPointCollectionByContactPointType
(
@type SmallInt = null
)
as


select 
	[CONTACT_POINT].[Id],
	[CONTACT_POINT].[BorrowerId],
	[CONTACT_POINT].[TypeOtherDescription],
	[CONTACT_POINT].[Value],
	[CONTACT_POINT].[PreferenceIndicator],
	[CONTACT_POINT].[RoleType],
	[CONTACT_POINT].[Type]
from 
	[CONTACT_POINT] 
where 
	[CONTACT_POINT].[Type] = @type
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: CREDIT_SCORE
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectCreditScore
(
@creditScoreID BigInt
)
as


select 
	[CREDIT_SCORE].[CreditScoreID],
	[CREDIT_SCORE].[CreditReportIdentifier],
	[CREDIT_SCORE].[CreditScoreDate],
	[CREDIT_SCORE].[CreditScoreModelNameTypeOtherDescription],
	[CREDIT_SCORE].[CreditScoreValue],
	[CREDIT_SCORE].[BorrowerId],
	[CREDIT_SCORE].[CreditRepositorySourceType],
	[CREDIT_SCORE].[CreditScoreExclusionType],
	[CREDIT_SCORE].[CreditScoreModelNameType]
from 
	[CREDIT_SCORE] 
where 
	[CREDIT_SCORE].[CreditScoreID] = @creditScoreID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: CREDIT_SCORE
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectCreditScores
as


select 
	[CREDIT_SCORE].[CreditScoreID],
	[CREDIT_SCORE].[CreditReportIdentifier],
	[CREDIT_SCORE].[CreditScoreDate],
	[CREDIT_SCORE].[CreditScoreModelNameTypeOtherDescription],
	[CREDIT_SCORE].[CreditScoreValue],
	[CREDIT_SCORE].[BorrowerId],
	[CREDIT_SCORE].[CreditRepositorySourceType],
	[CREDIT_SCORE].[CreditScoreExclusionType],
	[CREDIT_SCORE].[CreditScoreModelNameType]
from 
	[CREDIT_SCORE] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: CREDIT_SCORE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectCreditScoresByBorrower
(
@borrowerId BigInt
)
as


select 
	[CREDIT_SCORE].[CreditScoreID],
	[CREDIT_SCORE].[CreditReportIdentifier],
	[CREDIT_SCORE].[CreditScoreDate],
	[CREDIT_SCORE].[CreditScoreModelNameTypeOtherDescription],
	[CREDIT_SCORE].[CreditScoreValue],
	[CREDIT_SCORE].[BorrowerId],
	[CREDIT_SCORE].[CreditRepositorySourceType],
	[CREDIT_SCORE].[CreditScoreExclusionType],
	[CREDIT_SCORE].[CreditScoreModelNameType]
from 
	[CREDIT_SCORE] 
where 
	[CREDIT_SCORE].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: CREDIT_SCORE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectCreditScoresByCreditRepositorySourceType
(
@creditRepositorySourceType SmallInt = null
)
as


select 
	[CREDIT_SCORE].[CreditScoreID],
	[CREDIT_SCORE].[CreditReportIdentifier],
	[CREDIT_SCORE].[CreditScoreDate],
	[CREDIT_SCORE].[CreditScoreModelNameTypeOtherDescription],
	[CREDIT_SCORE].[CreditScoreValue],
	[CREDIT_SCORE].[BorrowerId],
	[CREDIT_SCORE].[CreditRepositorySourceType],
	[CREDIT_SCORE].[CreditScoreExclusionType],
	[CREDIT_SCORE].[CreditScoreModelNameType]
from 
	[CREDIT_SCORE] 
where 
	[CREDIT_SCORE].[CreditRepositorySourceType] = @creditRepositorySourceType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:38 AM
System User: marlon
System Machine: SERVER
Entity Name: CREDIT_SCORE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectCreditScoresByCreditScoreExclusionReasonType
(
@creditScoreExclusionType SmallInt = null
)
as


select 
	[CREDIT_SCORE].[CreditScoreID],
	[CREDIT_SCORE].[CreditReportIdentifier],
	[CREDIT_SCORE].[CreditScoreDate],
	[CREDIT_SCORE].[CreditScoreModelNameTypeOtherDescription],
	[CREDIT_SCORE].[CreditScoreValue],
	[CREDIT_SCORE].[BorrowerId],
	[CREDIT_SCORE].[CreditRepositorySourceType],
	[CREDIT_SCORE].[CreditScoreExclusionType],
	[CREDIT_SCORE].[CreditScoreModelNameType]
from 
	[CREDIT_SCORE] 
where 
	[CREDIT_SCORE].[CreditScoreExclusionType] = @creditScoreExclusionType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: CREDIT_SCORE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectCreditScoresByCreditScoreModelNameType
(
@creditScoreModelNameType SmallInt = null
)
as


select 
	[CREDIT_SCORE].[CreditScoreID],
	[CREDIT_SCORE].[CreditReportIdentifier],
	[CREDIT_SCORE].[CreditScoreDate],
	[CREDIT_SCORE].[CreditScoreModelNameTypeOtherDescription],
	[CREDIT_SCORE].[CreditScoreValue],
	[CREDIT_SCORE].[BorrowerId],
	[CREDIT_SCORE].[CreditRepositorySourceType],
	[CREDIT_SCORE].[CreditScoreExclusionType],
	[CREDIT_SCORE].[CreditScoreModelNameType]
from 
	[CREDIT_SCORE] 
where 
	[CREDIT_SCORE].[CreditScoreModelNameType] = @creditScoreModelNameType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: CURRENT_INCOME
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectCurrentIncome
(
@id BigInt
)
as


select 
	[CURRENT_INCOME].[Id],
	[CURRENT_INCOME].[BorrowerId],
	[CURRENT_INCOME].[IncomeType],
	[CURRENT_INCOME].[MonthlyTotalAmount]
from 
	[CURRENT_INCOME] 
where 
	[CURRENT_INCOME].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: CURRENT_INCOME
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectCurrentIncomeCollection
as


select 
	[CURRENT_INCOME].[Id],
	[CURRENT_INCOME].[BorrowerId],
	[CURRENT_INCOME].[IncomeType],
	[CURRENT_INCOME].[MonthlyTotalAmount]
from 
	[CURRENT_INCOME] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: CURRENT_INCOME
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectCurrentIncomeCollectionByBorrower
(
@borrowerId BigInt
)
as


select 
	[CURRENT_INCOME].[Id],
	[CURRENT_INCOME].[BorrowerId],
	[CURRENT_INCOME].[IncomeType],
	[CURRENT_INCOME].[MonthlyTotalAmount]
from 
	[CURRENT_INCOME] 
where 
	[CURRENT_INCOME].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: CURRENT_INCOME
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectCurrentIncomeCollectionByIncomeType
(
@incomeType SmallInt
)
as


select 
	[CURRENT_INCOME].[Id],
	[CURRENT_INCOME].[BorrowerId],
	[CURRENT_INCOME].[IncomeType],
	[CURRENT_INCOME].[MonthlyTotalAmount]
from 
	[CURRENT_INCOME] 
where 
	[CURRENT_INCOME].[IncomeType] = @incomeType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: DATA_VERSION
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectDataVersion
(
@id Int
)
as


select 
	[DATA_VERSION].[Id],
	[DATA_VERSION].[Name],
	[DATA_VERSION].[Number],
	[DATA_VERSION].[LoanApplicationId]
from 
	[DATA_VERSION] 
where 
	[DATA_VERSION].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: DATA_VERSION
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectDataVersions
as


select 
	[DATA_VERSION].[Id],
	[DATA_VERSION].[Name],
	[DATA_VERSION].[Number],
	[DATA_VERSION].[LoanApplicationId]
from 
	[DATA_VERSION] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: DATA_VERSION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectDataVersionsByDataInformation
(
@loanApplicationId BigInt
)
as


select 
	[DATA_VERSION].[Id],
	[DATA_VERSION].[Name],
	[DATA_VERSION].[Number],
	[DATA_VERSION].[LoanApplicationId]
from 
	[DATA_VERSION] 
where 
	[DATA_VERSION].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DECLARATION
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectDeclaration
(
@borrowerId BigInt
)
as


select 
	[DECLARATION].[BorrowerId],
	[DECLARATION].[AlimonyChildSupportObligationIndicator],
	[DECLARATION].[BankruptcyIndicator],
	[DECLARATION].[BorrowedDownPaymentIndicator],
	[DECLARATION].[CoMakerEndorserOfNoteIndicator],
	[DECLARATION].[HomeownerPastThreeYearsType],
	[DECLARATION].[IntentToOccupyType],
	[DECLARATION].[LoanForeclosureOrJudgementIndicator],
	[DECLARATION].[OutstandingJudgementsIndicator],
	[DECLARATION].[PartyToLawsuitIndicator],
	[DECLARATION].[PresentlyDelinquentIndicator],
	[DECLARATION].[PropertyForeclosedPastSevenYearsIndicator],
	[DECLARATION].[CitizenshipResidencyType],
	[DECLARATION].[PriorPropertyTitleType],
	[DECLARATION].[PriorPropertyUsageType]
from 
	[DECLARATION] 
where 
	[DECLARATION].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DECLARATION
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectDeclarations
as


select 
	[DECLARATION].[BorrowerId],
	[DECLARATION].[AlimonyChildSupportObligationIndicator],
	[DECLARATION].[BankruptcyIndicator],
	[DECLARATION].[BorrowedDownPaymentIndicator],
	[DECLARATION].[CoMakerEndorserOfNoteIndicator],
	[DECLARATION].[HomeownerPastThreeYearsType],
	[DECLARATION].[IntentToOccupyType],
	[DECLARATION].[LoanForeclosureOrJudgementIndicator],
	[DECLARATION].[OutstandingJudgementsIndicator],
	[DECLARATION].[PartyToLawsuitIndicator],
	[DECLARATION].[PresentlyDelinquentIndicator],
	[DECLARATION].[PropertyForeclosedPastSevenYearsIndicator],
	[DECLARATION].[CitizenshipResidencyType],
	[DECLARATION].[PriorPropertyTitleType],
	[DECLARATION].[PriorPropertyUsageType]
from 
	[DECLARATION] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DECLARATION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectDeclarationsByBorrower
(
@borrowerId BigInt
)
as


select 
	[DECLARATION].[BorrowerId],
	[DECLARATION].[AlimonyChildSupportObligationIndicator],
	[DECLARATION].[BankruptcyIndicator],
	[DECLARATION].[BorrowedDownPaymentIndicator],
	[DECLARATION].[CoMakerEndorserOfNoteIndicator],
	[DECLARATION].[HomeownerPastThreeYearsType],
	[DECLARATION].[IntentToOccupyType],
	[DECLARATION].[LoanForeclosureOrJudgementIndicator],
	[DECLARATION].[OutstandingJudgementsIndicator],
	[DECLARATION].[PartyToLawsuitIndicator],
	[DECLARATION].[PresentlyDelinquentIndicator],
	[DECLARATION].[PropertyForeclosedPastSevenYearsIndicator],
	[DECLARATION].[CitizenshipResidencyType],
	[DECLARATION].[PriorPropertyTitleType],
	[DECLARATION].[PriorPropertyUsageType]
from 
	[DECLARATION] 
where 
	[DECLARATION].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DECLARATION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectDeclarationsByCitizenshipResidencyType
(
@citizenshipResidencyType SmallInt = null
)
as


select 
	[DECLARATION].[BorrowerId],
	[DECLARATION].[AlimonyChildSupportObligationIndicator],
	[DECLARATION].[BankruptcyIndicator],
	[DECLARATION].[BorrowedDownPaymentIndicator],
	[DECLARATION].[CoMakerEndorserOfNoteIndicator],
	[DECLARATION].[HomeownerPastThreeYearsType],
	[DECLARATION].[IntentToOccupyType],
	[DECLARATION].[LoanForeclosureOrJudgementIndicator],
	[DECLARATION].[OutstandingJudgementsIndicator],
	[DECLARATION].[PartyToLawsuitIndicator],
	[DECLARATION].[PresentlyDelinquentIndicator],
	[DECLARATION].[PropertyForeclosedPastSevenYearsIndicator],
	[DECLARATION].[CitizenshipResidencyType],
	[DECLARATION].[PriorPropertyTitleType],
	[DECLARATION].[PriorPropertyUsageType]
from 
	[DECLARATION] 
where 
	[DECLARATION].[CitizenshipResidencyType] = @citizenshipResidencyType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DECLARATION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectDeclarationsByPriorPropertyTitleType
(
@priorPropertyTitleType SmallInt = null
)
as


select 
	[DECLARATION].[BorrowerId],
	[DECLARATION].[AlimonyChildSupportObligationIndicator],
	[DECLARATION].[BankruptcyIndicator],
	[DECLARATION].[BorrowedDownPaymentIndicator],
	[DECLARATION].[CoMakerEndorserOfNoteIndicator],
	[DECLARATION].[HomeownerPastThreeYearsType],
	[DECLARATION].[IntentToOccupyType],
	[DECLARATION].[LoanForeclosureOrJudgementIndicator],
	[DECLARATION].[OutstandingJudgementsIndicator],
	[DECLARATION].[PartyToLawsuitIndicator],
	[DECLARATION].[PresentlyDelinquentIndicator],
	[DECLARATION].[PropertyForeclosedPastSevenYearsIndicator],
	[DECLARATION].[CitizenshipResidencyType],
	[DECLARATION].[PriorPropertyTitleType],
	[DECLARATION].[PriorPropertyUsageType]
from 
	[DECLARATION] 
where 
	[DECLARATION].[PriorPropertyTitleType] = @priorPropertyTitleType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DECLARATION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectDeclarationsByPriorPropertyUsageType
(
@priorPropertyUsageType SmallInt = null
)
as


select 
	[DECLARATION].[BorrowerId],
	[DECLARATION].[AlimonyChildSupportObligationIndicator],
	[DECLARATION].[BankruptcyIndicator],
	[DECLARATION].[BorrowedDownPaymentIndicator],
	[DECLARATION].[CoMakerEndorserOfNoteIndicator],
	[DECLARATION].[HomeownerPastThreeYearsType],
	[DECLARATION].[IntentToOccupyType],
	[DECLARATION].[LoanForeclosureOrJudgementIndicator],
	[DECLARATION].[OutstandingJudgementsIndicator],
	[DECLARATION].[PartyToLawsuitIndicator],
	[DECLARATION].[PresentlyDelinquentIndicator],
	[DECLARATION].[PropertyForeclosedPastSevenYearsIndicator],
	[DECLARATION].[CitizenshipResidencyType],
	[DECLARATION].[PriorPropertyTitleType],
	[DECLARATION].[PriorPropertyUsageType]
from 
	[DECLARATION] 
where 
	[DECLARATION].[PriorPropertyUsageType] = @priorPropertyUsageType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DEPENDENT
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectDependent
(
@id BigInt
)
as


select 
	[DEPENDENT].[Id],
	[DEPENDENT].[BorrowerId],
	[DEPENDENT].[AgeYears]
from 
	[DEPENDENT] 
where 
	[DEPENDENT].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DEPENDENT
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectDependents
as


select 
	[DEPENDENT].[Id],
	[DEPENDENT].[BorrowerId],
	[DEPENDENT].[AgeYears]
from 
	[DEPENDENT] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DEPENDENT
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectDependentsByBorrower
(
@borrowerId BigInt
)
as


select 
	[DEPENDENT].[Id],
	[DEPENDENT].[BorrowerId],
	[DEPENDENT].[AgeYears]
from 
	[DEPENDENT] 
where 
	[DEPENDENT].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: EMPLOYER
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectEmployer
(
@id BigInt
)
as


select 
	[EMPLOYER].[Id],
	[EMPLOYER].[BorrowerId],
	[EMPLOYER].[Name],
	[EMPLOYER].[StreetAddress],
	[EMPLOYER].[City],
	[EMPLOYER].[State],
	[EMPLOYER].[PostalCode],
	[EMPLOYER].[TelephoneNumber],
	[EMPLOYER].[CurrentEmploymentMonthsOnJob],
	[EMPLOYER].[CurrentEmploymentTimeInLineOfWorkYears],
	[EMPLOYER].[CurrentEmploymentYearsOnJob],
	[EMPLOYER].[EmploymentBorrowerSelfEmployedIndicator],
	[EMPLOYER].[EmploymentCurrentIndicator],
	[EMPLOYER].[EmploymentPositionDescription],
	[EMPLOYER].[EmploymentPrimaryIndicator],
	[EMPLOYER].[IncomeEmploymentMonthlyAmount],
	[EMPLOYER].[PreviousEmploymentEndDate],
	[EMPLOYER].[PreviousEmploymentStartDate]
from 
	[EMPLOYER] 
where 
	[EMPLOYER].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: EMPLOYER
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectEmployers
as


select 
	[EMPLOYER].[Id],
	[EMPLOYER].[BorrowerId],
	[EMPLOYER].[Name],
	[EMPLOYER].[StreetAddress],
	[EMPLOYER].[City],
	[EMPLOYER].[State],
	[EMPLOYER].[PostalCode],
	[EMPLOYER].[TelephoneNumber],
	[EMPLOYER].[CurrentEmploymentMonthsOnJob],
	[EMPLOYER].[CurrentEmploymentTimeInLineOfWorkYears],
	[EMPLOYER].[CurrentEmploymentYearsOnJob],
	[EMPLOYER].[EmploymentBorrowerSelfEmployedIndicator],
	[EMPLOYER].[EmploymentCurrentIndicator],
	[EMPLOYER].[EmploymentPositionDescription],
	[EMPLOYER].[EmploymentPrimaryIndicator],
	[EMPLOYER].[IncomeEmploymentMonthlyAmount],
	[EMPLOYER].[PreviousEmploymentEndDate],
	[EMPLOYER].[PreviousEmploymentStartDate]
from 
	[EMPLOYER] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: EMPLOYER
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectEmployersByBorrower
(
@borrowerId BigInt
)
as


select 
	[EMPLOYER].[Id],
	[EMPLOYER].[BorrowerId],
	[EMPLOYER].[Name],
	[EMPLOYER].[StreetAddress],
	[EMPLOYER].[City],
	[EMPLOYER].[State],
	[EMPLOYER].[PostalCode],
	[EMPLOYER].[TelephoneNumber],
	[EMPLOYER].[CurrentEmploymentMonthsOnJob],
	[EMPLOYER].[CurrentEmploymentTimeInLineOfWorkYears],
	[EMPLOYER].[CurrentEmploymentYearsOnJob],
	[EMPLOYER].[EmploymentBorrowerSelfEmployedIndicator],
	[EMPLOYER].[EmploymentCurrentIndicator],
	[EMPLOYER].[EmploymentPositionDescription],
	[EMPLOYER].[EmploymentPrimaryIndicator],
	[EMPLOYER].[IncomeEmploymentMonthlyAmount],
	[EMPLOYER].[PreviousEmploymentEndDate],
	[EMPLOYER].[PreviousEmploymentStartDate]
from 
	[EMPLOYER] 
where 
	[EMPLOYER].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_LOAN
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectFHALoan
(
@loanApplicationId BigInt
)
as


select 
	[FHA_LOAN].[LoanApplicationId],
	[FHA_LOAN].[BorrowerFinancedFHADiscountPointsAmount],
	[FHA_LOAN].[FHACoverageRenewalRatePercent],
	[FHA_LOAN].[FHA_MIPremiumRefundAmount],
	[FHA_LOAN].[FHAUpfrontMIPremiumPercent],
	[FHA_LOAN].[LenderIdentifier],
	[FHA_LOAN].[SponsorIdentifier],
	[FHA_LOAN].[SectionOfActType],
	[FHA_LOAN].[FHAAlimonyLiabilityTreatmentType2]
from 
	[FHA_LOAN] 
where 
	[FHA_LOAN].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_LOAN
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectFHALoans
as


select 
	[FHA_LOAN].[LoanApplicationId],
	[FHA_LOAN].[BorrowerFinancedFHADiscountPointsAmount],
	[FHA_LOAN].[FHACoverageRenewalRatePercent],
	[FHA_LOAN].[FHA_MIPremiumRefundAmount],
	[FHA_LOAN].[FHAUpfrontMIPremiumPercent],
	[FHA_LOAN].[LenderIdentifier],
	[FHA_LOAN].[SponsorIdentifier],
	[FHA_LOAN].[SectionOfActType],
	[FHA_LOAN].[FHAAlimonyLiabilityTreatmentType2]
from 
	[FHA_LOAN] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_LOAN
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectFHALoansByFHAAlimonyLiabilityTreatmentType
(
@fHAAlimonyLiabilityTreatmentType2 SmallInt = null
)
as


select 
	[FHA_LOAN].[LoanApplicationId],
	[FHA_LOAN].[BorrowerFinancedFHADiscountPointsAmount],
	[FHA_LOAN].[FHACoverageRenewalRatePercent],
	[FHA_LOAN].[FHA_MIPremiumRefundAmount],
	[FHA_LOAN].[FHAUpfrontMIPremiumPercent],
	[FHA_LOAN].[LenderIdentifier],
	[FHA_LOAN].[SponsorIdentifier],
	[FHA_LOAN].[SectionOfActType],
	[FHA_LOAN].[FHAAlimonyLiabilityTreatmentType2]
from 
	[FHA_LOAN] 
where 
	[FHA_LOAN].[FHAAlimonyLiabilityTreatmentType2] = @fHAAlimonyLiabilityTreatmentType2
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_LOAN
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectFHALoansByGovernmentLoan
(
@loanApplicationId BigInt
)
as


select 
	[FHA_LOAN].[LoanApplicationId],
	[FHA_LOAN].[BorrowerFinancedFHADiscountPointsAmount],
	[FHA_LOAN].[FHACoverageRenewalRatePercent],
	[FHA_LOAN].[FHA_MIPremiumRefundAmount],
	[FHA_LOAN].[FHAUpfrontMIPremiumPercent],
	[FHA_LOAN].[LenderIdentifier],
	[FHA_LOAN].[SponsorIdentifier],
	[FHA_LOAN].[SectionOfActType],
	[FHA_LOAN].[FHAAlimonyLiabilityTreatmentType2]
from 
	[FHA_LOAN] 
where 
	[FHA_LOAN].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_LOAN
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectFHALoansByNationalHousingActSectionType
(
@sectionOfActType SmallInt = null
)
as


select 
	[FHA_LOAN].[LoanApplicationId],
	[FHA_LOAN].[BorrowerFinancedFHADiscountPointsAmount],
	[FHA_LOAN].[FHACoverageRenewalRatePercent],
	[FHA_LOAN].[FHA_MIPremiumRefundAmount],
	[FHA_LOAN].[FHAUpfrontMIPremiumPercent],
	[FHA_LOAN].[LenderIdentifier],
	[FHA_LOAN].[SponsorIdentifier],
	[FHA_LOAN].[SectionOfActType],
	[FHA_LOAN].[FHAAlimonyLiabilityTreatmentType2]
from 
	[FHA_LOAN] 
where 
	[FHA_LOAN].[SectionOfActType] = @sectionOfActType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_BORROWER
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectFHAVABorrower
(
@borrowerId BigInt
)
as


select 
	[FHA_VA_BORROWER].[BorrowerId],
	[FHA_VA_BORROWER].[CAIVRSIdentifier],
	[FHA_VA_BORROWER].[FNMBankruptcyCount],
	[FHA_VA_BORROWER].[FNMBorrowerCreditRating],
	[FHA_VA_BORROWER].[FNMCreditReportScoreType],
	[FHA_VA_BORROWER].[FNMForeclosureCount],
	[FHA_VA_BORROWER].[VeteranStatusIndicator]
from 
	[FHA_VA_BORROWER] 
where 
	[FHA_VA_BORROWER].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_BORROWER
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectFHAVABorrowers
as


select 
	[FHA_VA_BORROWER].[BorrowerId],
	[FHA_VA_BORROWER].[CAIVRSIdentifier],
	[FHA_VA_BORROWER].[FNMBankruptcyCount],
	[FHA_VA_BORROWER].[FNMBorrowerCreditRating],
	[FHA_VA_BORROWER].[FNMCreditReportScoreType],
	[FHA_VA_BORROWER].[FNMForeclosureCount],
	[FHA_VA_BORROWER].[VeteranStatusIndicator]
from 
	[FHA_VA_BORROWER] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_BORROWER
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectFHAVABorrowersByBorrower
(
@borrowerId BigInt
)
as


select 
	[FHA_VA_BORROWER].[BorrowerId],
	[FHA_VA_BORROWER].[CAIVRSIdentifier],
	[FHA_VA_BORROWER].[FNMBankruptcyCount],
	[FHA_VA_BORROWER].[FNMBorrowerCreditRating],
	[FHA_VA_BORROWER].[FNMCreditReportScoreType],
	[FHA_VA_BORROWER].[FNMForeclosureCount],
	[FHA_VA_BORROWER].[VeteranStatusIndicator]
from 
	[FHA_VA_BORROWER] 
where 
	[FHA_VA_BORROWER].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_BORROWER
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectFHAVABorrowersByFNMCreditReportScoreType
(
@fNMCreditReportScoreType SmallInt = null
)
as


select 
	[FHA_VA_BORROWER].[BorrowerId],
	[FHA_VA_BORROWER].[CAIVRSIdentifier],
	[FHA_VA_BORROWER].[FNMBankruptcyCount],
	[FHA_VA_BORROWER].[FNMBorrowerCreditRating],
	[FHA_VA_BORROWER].[FNMCreditReportScoreType],
	[FHA_VA_BORROWER].[FNMForeclosureCount],
	[FHA_VA_BORROWER].[VeteranStatusIndicator]
from 
	[FHA_VA_BORROWER] 
where 
	[FHA_VA_BORROWER].[FNMCreditReportScoreType] = @fNMCreditReportScoreType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_LOAN
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectFHAVALoan
(
@loanApplicationId BigInt
)
as


select 
	[FHA_VA_LOAN].[LoanApplicationId],
	[FHA_VA_LOAN].[BorrowerPaidFHA_VAClosingCostsAmount],
	[FHA_VA_LOAN].[BorrowerPaidFHA_VAClosingCostsPercent],
	[FHA_VA_LOAN].[GovernmentMortgageCreditCertificateAmount],
	[FHA_VA_LOAN].[GovernmentRefinanceType],
	[FHA_VA_LOAN].[OtherPartyPaidFHA_VAClosingCostsAmount],
	[FHA_VA_LOAN].[OtherPartyPaidFHA_VAClosingCostsPercent],
	[FHA_VA_LOAN].[PropertyEnergyEfficientHomeIndicator],
	[FHA_VA_LOAN].[SellerPaidFHA_VAClosingCostsPercent]
from 
	[FHA_VA_LOAN] 
where 
	[FHA_VA_LOAN].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_LOAN
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectFHAVALoans
as


select 
	[FHA_VA_LOAN].[LoanApplicationId],
	[FHA_VA_LOAN].[BorrowerPaidFHA_VAClosingCostsAmount],
	[FHA_VA_LOAN].[BorrowerPaidFHA_VAClosingCostsPercent],
	[FHA_VA_LOAN].[GovernmentMortgageCreditCertificateAmount],
	[FHA_VA_LOAN].[GovernmentRefinanceType],
	[FHA_VA_LOAN].[OtherPartyPaidFHA_VAClosingCostsAmount],
	[FHA_VA_LOAN].[OtherPartyPaidFHA_VAClosingCostsPercent],
	[FHA_VA_LOAN].[PropertyEnergyEfficientHomeIndicator],
	[FHA_VA_LOAN].[SellerPaidFHA_VAClosingCostsPercent]
from 
	[FHA_VA_LOAN] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_LOAN
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectFHAVALoansByGovernmentLoan
(
@loanApplicationId BigInt
)
as


select 
	[FHA_VA_LOAN].[LoanApplicationId],
	[FHA_VA_LOAN].[BorrowerPaidFHA_VAClosingCostsAmount],
	[FHA_VA_LOAN].[BorrowerPaidFHA_VAClosingCostsPercent],
	[FHA_VA_LOAN].[GovernmentMortgageCreditCertificateAmount],
	[FHA_VA_LOAN].[GovernmentRefinanceType],
	[FHA_VA_LOAN].[OtherPartyPaidFHA_VAClosingCostsAmount],
	[FHA_VA_LOAN].[OtherPartyPaidFHA_VAClosingCostsPercent],
	[FHA_VA_LOAN].[PropertyEnergyEfficientHomeIndicator],
	[FHA_VA_LOAN].[SellerPaidFHA_VAClosingCostsPercent]
from 
	[FHA_VA_LOAN] 
where 
	[FHA_VA_LOAN].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_LOAN
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectFHAVALoansByGovernmentRefinanceType
(
@governmentRefinanceType SmallInt = null
)
as


select 
	[FHA_VA_LOAN].[LoanApplicationId],
	[FHA_VA_LOAN].[BorrowerPaidFHA_VAClosingCostsAmount],
	[FHA_VA_LOAN].[BorrowerPaidFHA_VAClosingCostsPercent],
	[FHA_VA_LOAN].[GovernmentMortgageCreditCertificateAmount],
	[FHA_VA_LOAN].[GovernmentRefinanceType],
	[FHA_VA_LOAN].[OtherPartyPaidFHA_VAClosingCostsAmount],
	[FHA_VA_LOAN].[OtherPartyPaidFHA_VAClosingCostsPercent],
	[FHA_VA_LOAN].[PropertyEnergyEfficientHomeIndicator],
	[FHA_VA_LOAN].[SellerPaidFHA_VAClosingCostsPercent]
from 
	[FHA_VA_LOAN] 
where 
	[FHA_VA_LOAN].[GovernmentRefinanceType] = @governmentRefinanceType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_MONITORING
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectGovernmentMonitoring
(
@borrowerId BigInt
)
as


select 
	[GOVERNMENT_MONITORING].[BorrowerId],
	[GOVERNMENT_MONITORING].[GenderType],
	[GOVERNMENT_MONITORING].[OtherRaceNationalOriginDescription],
	[GOVERNMENT_MONITORING].[RaceNationalOriginRefusalIndicator],
	[GOVERNMENT_MONITORING].[RaceNationalOriginType],
	[GOVERNMENT_MONITORING].[HMDAEthnicityType]
from 
	[GOVERNMENT_MONITORING] 
where 
	[GOVERNMENT_MONITORING].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_MONITORING
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectGovernmentMonitoringCollection
as


select 
	[GOVERNMENT_MONITORING].[BorrowerId],
	[GOVERNMENT_MONITORING].[GenderType],
	[GOVERNMENT_MONITORING].[OtherRaceNationalOriginDescription],
	[GOVERNMENT_MONITORING].[RaceNationalOriginRefusalIndicator],
	[GOVERNMENT_MONITORING].[RaceNationalOriginType],
	[GOVERNMENT_MONITORING].[HMDAEthnicityType]
from 
	[GOVERNMENT_MONITORING] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_MONITORING
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectGovernmentMonitoringCollectionByBorrower
(
@borrowerId BigInt
)
as


select 
	[GOVERNMENT_MONITORING].[BorrowerId],
	[GOVERNMENT_MONITORING].[GenderType],
	[GOVERNMENT_MONITORING].[OtherRaceNationalOriginDescription],
	[GOVERNMENT_MONITORING].[RaceNationalOriginRefusalIndicator],
	[GOVERNMENT_MONITORING].[RaceNationalOriginType],
	[GOVERNMENT_MONITORING].[HMDAEthnicityType]
from 
	[GOVERNMENT_MONITORING] 
where 
	[GOVERNMENT_MONITORING].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_MONITORING
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectGovernmentMonitoringCollectionByGenderType
(
@genderType SmallInt = null
)
as


select 
	[GOVERNMENT_MONITORING].[BorrowerId],
	[GOVERNMENT_MONITORING].[GenderType],
	[GOVERNMENT_MONITORING].[OtherRaceNationalOriginDescription],
	[GOVERNMENT_MONITORING].[RaceNationalOriginRefusalIndicator],
	[GOVERNMENT_MONITORING].[RaceNationalOriginType],
	[GOVERNMENT_MONITORING].[HMDAEthnicityType]
from 
	[GOVERNMENT_MONITORING] 
where 
	[GOVERNMENT_MONITORING].[GenderType] = @genderType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_MONITORING
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectGovernmentMonitoringCollectionByHMDAEthnicityType
(
@hMDAEthnicityType SmallInt = null
)
as


select 
	[GOVERNMENT_MONITORING].[BorrowerId],
	[GOVERNMENT_MONITORING].[GenderType],
	[GOVERNMENT_MONITORING].[OtherRaceNationalOriginDescription],
	[GOVERNMENT_MONITORING].[RaceNationalOriginRefusalIndicator],
	[GOVERNMENT_MONITORING].[RaceNationalOriginType],
	[GOVERNMENT_MONITORING].[HMDAEthnicityType]
from 
	[GOVERNMENT_MONITORING] 
where 
	[GOVERNMENT_MONITORING].[HMDAEthnicityType] = @hMDAEthnicityType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_MONITORING
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectGovernmentMonitoringCollectionByRaceNationalOriginType
(
@raceNationalOriginType SmallInt = null
)
as


select 
	[GOVERNMENT_MONITORING].[BorrowerId],
	[GOVERNMENT_MONITORING].[GenderType],
	[GOVERNMENT_MONITORING].[OtherRaceNationalOriginDescription],
	[GOVERNMENT_MONITORING].[RaceNationalOriginRefusalIndicator],
	[GOVERNMENT_MONITORING].[RaceNationalOriginType],
	[GOVERNMENT_MONITORING].[HMDAEthnicityType]
from 
	[GOVERNMENT_MONITORING] 
where 
	[GOVERNMENT_MONITORING].[RaceNationalOriginType] = @raceNationalOriginType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:50 AM
System User: marlon
System Machine: SERVER
Entity Name: LEGAL_DESCRIPTION
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLegalDescription
(
@id BigInt
)
as


select 
	[LEGAL_DESCRIPTION].[Id],
	[LEGAL_DESCRIPTION].[LoanApplicationId],
	[LEGAL_DESCRIPTION].[TextDescription],
	[LEGAL_DESCRIPTION].[Type]
from 
	[LEGAL_DESCRIPTION] 
where 
	[LEGAL_DESCRIPTION].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:50 AM
System User: marlon
System Machine: SERVER
Entity Name: LEGAL_DESCRIPTION
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLegalDescriptions
as


select 
	[LEGAL_DESCRIPTION].[Id],
	[LEGAL_DESCRIPTION].[LoanApplicationId],
	[LEGAL_DESCRIPTION].[TextDescription],
	[LEGAL_DESCRIPTION].[Type]
from 
	[LEGAL_DESCRIPTION] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:50 AM
System User: marlon
System Machine: SERVER
Entity Name: LEGAL_DESCRIPTION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLegalDescriptionsByLegalType
(
@type SmallInt
)
as


select 
	[LEGAL_DESCRIPTION].[Id],
	[LEGAL_DESCRIPTION].[LoanApplicationId],
	[LEGAL_DESCRIPTION].[TextDescription],
	[LEGAL_DESCRIPTION].[Type]
from 
	[LEGAL_DESCRIPTION] 
where 
	[LEGAL_DESCRIPTION].[Type] = @type
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:50 AM
System User: marlon
System Machine: SERVER
Entity Name: LEGAL_DESCRIPTION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLegalDescriptionsByProperty
(
@loanApplicationId BigInt
)
as


select 
	[LEGAL_DESCRIPTION].[Id],
	[LEGAL_DESCRIPTION].[LoanApplicationId],
	[LEGAL_DESCRIPTION].[TextDescription],
	[LEGAL_DESCRIPTION].[Type]
from 
	[LEGAL_DESCRIPTION] 
where 
	[LEGAL_DESCRIPTION].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LIABILITY
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLiabilities
as


select 
	[LIABILITY].[Id],
	[LIABILITY].[LoanApplicationId],
	[LIABILITY].[BorrowerId],
	[LIABILITY].[REO_ID],
	[LIABILITY].[HolderStreetAddress],
	[LIABILITY].[HolderCity],
	[LIABILITY].[HolderState],
	[LIABILITY].[HolderPostalCode],
	[LIABILITY].[AlimonyOwedToName],
	[LIABILITY].[AccountIdentifier],
	[LIABILITY].[ExclusionIndicator],
	[LIABILITY].[HolderName],
	[LIABILITY].[MonthlyPaymentAmount],
	[LIABILITY].[PayoffStatusIndicator],
	[LIABILITY].[PayoffWithCurrentAssetsIndicator],
	[LIABILITY].[RemainingTermMonths],
	[LIABILITY].[Type],
	[LIABILITY].[UnpaidBalanceAmount],
	[LIABILITY].[SubjectLoanResubordinationIndicator]
from 
	[LIABILITY] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LIABILITY
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLiabilitiesByBorrower
(
@borrowerId BigInt
)
as


select 
	[LIABILITY].[Id],
	[LIABILITY].[LoanApplicationId],
	[LIABILITY].[BorrowerId],
	[LIABILITY].[REO_ID],
	[LIABILITY].[HolderStreetAddress],
	[LIABILITY].[HolderCity],
	[LIABILITY].[HolderState],
	[LIABILITY].[HolderPostalCode],
	[LIABILITY].[AlimonyOwedToName],
	[LIABILITY].[AccountIdentifier],
	[LIABILITY].[ExclusionIndicator],
	[LIABILITY].[HolderName],
	[LIABILITY].[MonthlyPaymentAmount],
	[LIABILITY].[PayoffStatusIndicator],
	[LIABILITY].[PayoffWithCurrentAssetsIndicator],
	[LIABILITY].[RemainingTermMonths],
	[LIABILITY].[Type],
	[LIABILITY].[UnpaidBalanceAmount],
	[LIABILITY].[SubjectLoanResubordinationIndicator]
from 
	[LIABILITY] 
where 
	[LIABILITY].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LIABILITY
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLiabilitiesByLiabilityType
(
@type SmallInt
)
as


select 
	[LIABILITY].[Id],
	[LIABILITY].[LoanApplicationId],
	[LIABILITY].[BorrowerId],
	[LIABILITY].[REO_ID],
	[LIABILITY].[HolderStreetAddress],
	[LIABILITY].[HolderCity],
	[LIABILITY].[HolderState],
	[LIABILITY].[HolderPostalCode],
	[LIABILITY].[AlimonyOwedToName],
	[LIABILITY].[AccountIdentifier],
	[LIABILITY].[ExclusionIndicator],
	[LIABILITY].[HolderName],
	[LIABILITY].[MonthlyPaymentAmount],
	[LIABILITY].[PayoffStatusIndicator],
	[LIABILITY].[PayoffWithCurrentAssetsIndicator],
	[LIABILITY].[RemainingTermMonths],
	[LIABILITY].[Type],
	[LIABILITY].[UnpaidBalanceAmount],
	[LIABILITY].[SubjectLoanResubordinationIndicator]
from 
	[LIABILITY] 
where 
	[LIABILITY].[Type] = @type
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LIABILITY
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLiabilitiesByLoanApplication
(
@loanApplicationId BigInt
)
as


select 
	[LIABILITY].[Id],
	[LIABILITY].[LoanApplicationId],
	[LIABILITY].[BorrowerId],
	[LIABILITY].[REO_ID],
	[LIABILITY].[HolderStreetAddress],
	[LIABILITY].[HolderCity],
	[LIABILITY].[HolderState],
	[LIABILITY].[HolderPostalCode],
	[LIABILITY].[AlimonyOwedToName],
	[LIABILITY].[AccountIdentifier],
	[LIABILITY].[ExclusionIndicator],
	[LIABILITY].[HolderName],
	[LIABILITY].[MonthlyPaymentAmount],
	[LIABILITY].[PayoffStatusIndicator],
	[LIABILITY].[PayoffWithCurrentAssetsIndicator],
	[LIABILITY].[RemainingTermMonths],
	[LIABILITY].[Type],
	[LIABILITY].[UnpaidBalanceAmount],
	[LIABILITY].[SubjectLoanResubordinationIndicator]
from 
	[LIABILITY] 
where 
	[LIABILITY].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LIABILITY
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLiability
(
@id BigInt
)
as


select 
	[LIABILITY].[Id],
	[LIABILITY].[LoanApplicationId],
	[LIABILITY].[BorrowerId],
	[LIABILITY].[REO_ID],
	[LIABILITY].[HolderStreetAddress],
	[LIABILITY].[HolderCity],
	[LIABILITY].[HolderState],
	[LIABILITY].[HolderPostalCode],
	[LIABILITY].[AlimonyOwedToName],
	[LIABILITY].[AccountIdentifier],
	[LIABILITY].[ExclusionIndicator],
	[LIABILITY].[HolderName],
	[LIABILITY].[MonthlyPaymentAmount],
	[LIABILITY].[PayoffStatusIndicator],
	[LIABILITY].[PayoffWithCurrentAssetsIndicator],
	[LIABILITY].[RemainingTermMonths],
	[LIABILITY].[Type],
	[LIABILITY].[UnpaidBalanceAmount],
	[LIABILITY].[SubjectLoanResubordinationIndicator]
from 
	[LIABILITY] 
where 
	[LIABILITY].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectLoanFeatures
(
@loanApplicationId BigInt
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollection
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollectionByFullPrepaymentPenaltyOptionType
(
@fullPrepaymentPenaltyOptionType SmallInt = null
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType] = @fullPrepaymentPenaltyOptionType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollectionByGSEProjectClassificationType
(
@gSEProjectClassificationType SmallInt = null
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[GSEProjectClassificationType] = @gSEProjectClassificationType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollectionByGSEPropertyType
(
@gSEPropertyType SmallInt = null
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[GSEPropertyType] = @gSEPropertyType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollectionByLienPriorityType
(
@lienPriorityType SmallInt = null
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[LienPriorityType] = @lienPriorityType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollectionByLoanClosingStatusType
(
@loanClosingStatusType SmallInt = null
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[LoanClosingStatusType] = @loanClosingStatusType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollectionByLoanDocumentationType
(
@loanDocumentationType SmallInt = null
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[LoanDocumentationType] = @loanDocumentationType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollectionByLoanProductData
(
@loanApplicationId BigInt
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollectionByLoanRepaymentType
(
@loanRepaymentType SmallInt = null
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[LoanRepaymentType] = @loanRepaymentType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollectionByMICertificationStatusType
(
@mICertificationStatusType SmallInt = null
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[MICertificationStatusType] = @mICertificationStatusType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollectionByMICompanyNameType
(
@mICompanyNameType SmallInt = null
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[MICompanyNameType] = @mICompanyNameType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollectionByNameDocumentsDrawnInType
(
@nameDocumentsDrawnInType SmallInt = null
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[NameDocumentsDrawnInType] = @nameDocumentsDrawnInType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollectionByPaymentFrequencyType
(
@paymentFrequencyType SmallInt = null
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[PaymentFrequencyType] = @paymentFrequencyType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:53 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectLoanFeaturesCollectionByServicingTransferStatusType
(
@servicingTransferStatusType SmallInt = null
)
as


select 
	[LOAN_FEATURES].[LoanApplicationId],
	[LOAN_FEATURES].[AssumabilityIndicator],
	[LOAN_FEATURES].[BalloonIndicator],
	[LOAN_FEATURES].[BalloonLoanMaturityTermMonths],
	[LOAN_FEATURES].[BuydownTemporarySubsidyIndicator],
	[LOAN_FEATURES].[CounselingConfirmationIndicator],
	[LOAN_FEATURES].[EscrowWaiverIndicator],
	[LOAN_FEATURES].[FREOfferingIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIdentifier],
	[LOAN_FEATURES].[FNMProductPlanIndentifier],
	[LOAN_FEATURES].[HELOCMaximumBalanceAmount],
	[LOAN_FEATURES].[HELOCInitialAdvanceAmount],
	[LOAN_FEATURES].[InterestOnlyTerm],
	[LOAN_FEATURES].[LenderSelfInsuredIndicator],
	[LOAN_FEATURES].[LoanScheduledClosingDate],
	[LOAN_FEATURES].[MICoveragePercent],
	[LOAN_FEATURES].[NegativeAmortizationLimitPercent],
	[LOAN_FEATURES].[PrepaymentPenaltyIndicator],
	[LOAN_FEATURES].[PrepaymentPenaltyTermMonths],
	[LOAN_FEATURES].[PrepaymentRestrictionIndicator],
	[LOAN_FEATURES].[ProductDescription],
	[LOAN_FEATURES].[ProductName],
	[LOAN_FEATURES].[ScheduledFirstPaymentDate],
	[LOAN_FEATURES].[NameDocumentsDrawnInType],
	[LOAN_FEATURES].[GSEProjectClassificationType],
	[LOAN_FEATURES].[GSEPropertyType],
	[LOAN_FEATURES].[LienPriorityType],
	[LOAN_FEATURES].[LoanDocumentationType],
	[LOAN_FEATURES].[LoanRepaymentType],
	[LOAN_FEATURES].[MICertificationStatusType],
	[LOAN_FEATURES].[MICompanyNameType],
	[LOAN_FEATURES].[PaymentFrequencyType],
	[LOAN_FEATURES].[FullPrepaymentPenaltyOptionType],
	[LOAN_FEATURES].[LoanClosingStatusType],
	[LOAN_FEATURES].[ServicingTransferStatusType]
from 
	[LOAN_FEATURES] 
where 
	[LOAN_FEATURES].[ServicingTransferStatusType] = @servicingTransferStatusType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MAIL_TO
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectMailTo
(
@borrowerId BigInt
)
as


select 
	[MAIL_TO].[BorrowerId],
	[MAIL_TO].[StreetAddress],
	[MAIL_TO].[StreetAddress2],
	[MAIL_TO].[City],
	[MAIL_TO].[State],
	[MAIL_TO].[PostalCode],
	[MAIL_TO].[Country]
from 
	[MAIL_TO] 
where 
	[MAIL_TO].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MAIL_TO
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectMailToCollection
as


select 
	[MAIL_TO].[BorrowerId],
	[MAIL_TO].[StreetAddress],
	[MAIL_TO].[StreetAddress2],
	[MAIL_TO].[City],
	[MAIL_TO].[State],
	[MAIL_TO].[PostalCode],
	[MAIL_TO].[Country]
from 
	[MAIL_TO] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:56 AM
System User: marlon
System Machine: SERVER
Entity Name: MAIL_TO
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectMailToCollectionByBorrower
(
@borrowerId BigInt
)
as


select 
	[MAIL_TO].[BorrowerId],
	[MAIL_TO].[StreetAddress],
	[MAIL_TO].[StreetAddress2],
	[MAIL_TO].[City],
	[MAIL_TO].[State],
	[MAIL_TO].[PostalCode],
	[MAIL_TO].[Country]
from 
	[MAIL_TO] 
where 
	[MAIL_TO].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:57 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_SCORE
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectMortgageScore
(
@id BigInt
)
as


select 
	[MORTGAGE_SCORE].[Id],
	[MORTGAGE_SCORE].[LoanApplicationId],
	[MORTGAGE_SCORE].[Date],
	[MORTGAGE_SCORE].[TypeOtherDescription],
	[MORTGAGE_SCORE].[Value],
	[MORTGAGE_SCORE].[Type]
from 
	[MORTGAGE_SCORE] 
where 
	[MORTGAGE_SCORE].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:57 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_SCORE
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectMortgageScores
as


select 
	[MORTGAGE_SCORE].[Id],
	[MORTGAGE_SCORE].[LoanApplicationId],
	[MORTGAGE_SCORE].[Date],
	[MORTGAGE_SCORE].[TypeOtherDescription],
	[MORTGAGE_SCORE].[Value],
	[MORTGAGE_SCORE].[Type]
from 
	[MORTGAGE_SCORE] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:57 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_SCORE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectMortgageScoresByAdditionalCaseData
(
@loanApplicationId BigInt
)
as


select 
	[MORTGAGE_SCORE].[Id],
	[MORTGAGE_SCORE].[LoanApplicationId],
	[MORTGAGE_SCORE].[Date],
	[MORTGAGE_SCORE].[TypeOtherDescription],
	[MORTGAGE_SCORE].[Value],
	[MORTGAGE_SCORE].[Type]
from 
	[MORTGAGE_SCORE] 
where 
	[MORTGAGE_SCORE].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:57 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_SCORE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectMortgageScoresByMortgageScoreType
(
@type SmallInt = null
)
as


select 
	[MORTGAGE_SCORE].[Id],
	[MORTGAGE_SCORE].[LoanApplicationId],
	[MORTGAGE_SCORE].[Date],
	[MORTGAGE_SCORE].[TypeOtherDescription],
	[MORTGAGE_SCORE].[Value],
	[MORTGAGE_SCORE].[Type]
from 
	[MORTGAGE_SCORE] 
where 
	[MORTGAGE_SCORE].[Type] = @type
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: PARSED_STREET_ADDRESS
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectParsedStreetAddress
(
@loanApplicationId BigInt
)
as


select 
	[PARSED_STREET_ADDRESS].[LoanApplicationId],
	[PARSED_STREET_ADDRESS].[ApartmentOrUnit],
	[PARSED_STREET_ADDRESS].[DirectionPrefix],
	[PARSED_STREET_ADDRESS].[DirectionSuffix],
	[PARSED_STREET_ADDRESS].[BuildingNumber],
	[PARSED_STREET_ADDRESS].[HouseNumber],
	[PARSED_STREET_ADDRESS].[Military_APO_FPO],
	[PARSED_STREET_ADDRESS].[PostOfficeBox],
	[PARSED_STREET_ADDRESS].[RuralRoute],
	[PARSED_STREET_ADDRESS].[StreetName],
	[PARSED_STREET_ADDRESS].[StreetSuffix]
from 
	[PARSED_STREET_ADDRESS] 
where 
	[PARSED_STREET_ADDRESS].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: PARSED_STREET_ADDRESS
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectParsedStreetAddresses
as


select 
	[PARSED_STREET_ADDRESS].[LoanApplicationId],
	[PARSED_STREET_ADDRESS].[ApartmentOrUnit],
	[PARSED_STREET_ADDRESS].[DirectionPrefix],
	[PARSED_STREET_ADDRESS].[DirectionSuffix],
	[PARSED_STREET_ADDRESS].[BuildingNumber],
	[PARSED_STREET_ADDRESS].[HouseNumber],
	[PARSED_STREET_ADDRESS].[Military_APO_FPO],
	[PARSED_STREET_ADDRESS].[PostOfficeBox],
	[PARSED_STREET_ADDRESS].[RuralRoute],
	[PARSED_STREET_ADDRESS].[StreetName],
	[PARSED_STREET_ADDRESS].[StreetSuffix]
from 
	[PARSED_STREET_ADDRESS] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: PARSED_STREET_ADDRESS
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectParsedStreetAddressesByProperty
(
@loanApplicationId BigInt
)
as


select 
	[PARSED_STREET_ADDRESS].[LoanApplicationId],
	[PARSED_STREET_ADDRESS].[ApartmentOrUnit],
	[PARSED_STREET_ADDRESS].[DirectionPrefix],
	[PARSED_STREET_ADDRESS].[DirectionSuffix],
	[PARSED_STREET_ADDRESS].[BuildingNumber],
	[PARSED_STREET_ADDRESS].[HouseNumber],
	[PARSED_STREET_ADDRESS].[Military_APO_FPO],
	[PARSED_STREET_ADDRESS].[PostOfficeBox],
	[PARSED_STREET_ADDRESS].[RuralRoute],
	[PARSED_STREET_ADDRESS].[StreetName],
	[PARSED_STREET_ADDRESS].[StreetSuffix]
from 
	[PARSED_STREET_ADDRESS] 
where 
	[PARSED_STREET_ADDRESS].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: PAYMENT_ADJUSTMENT
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectPaymentAdjustment
(
@id BigInt
)
as


select 
	[PAYMENT_ADJUSTMENT].[Id],
	[PAYMENT_ADJUSTMENT].[LoanApplicationId],
	[PAYMENT_ADJUSTMENT].[FirstPaymentAdjustmentMonths],
	[PAYMENT_ADJUSTMENT].[Amount],
	[PAYMENT_ADJUSTMENT].[CalculationType],
	[PAYMENT_ADJUSTMENT].[DurationMonths],
	[PAYMENT_ADJUSTMENT].[Percent],
	[PAYMENT_ADJUSTMENT].[PeriodicCapAmount],
	[PAYMENT_ADJUSTMENT].[PeriodicCapPercent],
	[PAYMENT_ADJUSTMENT].[PeriodNumber],
	[PAYMENT_ADJUSTMENT].[SubsequentPaymentAdjustmentMonths]
from 
	[PAYMENT_ADJUSTMENT] 
where 
	[PAYMENT_ADJUSTMENT].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: PAYMENT_ADJUSTMENT
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectPaymentAdjustments
as


select 
	[PAYMENT_ADJUSTMENT].[Id],
	[PAYMENT_ADJUSTMENT].[LoanApplicationId],
	[PAYMENT_ADJUSTMENT].[FirstPaymentAdjustmentMonths],
	[PAYMENT_ADJUSTMENT].[Amount],
	[PAYMENT_ADJUSTMENT].[CalculationType],
	[PAYMENT_ADJUSTMENT].[DurationMonths],
	[PAYMENT_ADJUSTMENT].[Percent],
	[PAYMENT_ADJUSTMENT].[PeriodicCapAmount],
	[PAYMENT_ADJUSTMENT].[PeriodicCapPercent],
	[PAYMENT_ADJUSTMENT].[PeriodNumber],
	[PAYMENT_ADJUSTMENT].[SubsequentPaymentAdjustmentMonths]
from 
	[PAYMENT_ADJUSTMENT] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: PAYMENT_ADJUSTMENT
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectPaymentAdjustmentsByLoanProductData
(
@loanApplicationId BigInt
)
as


select 
	[PAYMENT_ADJUSTMENT].[Id],
	[PAYMENT_ADJUSTMENT].[LoanApplicationId],
	[PAYMENT_ADJUSTMENT].[FirstPaymentAdjustmentMonths],
	[PAYMENT_ADJUSTMENT].[Amount],
	[PAYMENT_ADJUSTMENT].[CalculationType],
	[PAYMENT_ADJUSTMENT].[DurationMonths],
	[PAYMENT_ADJUSTMENT].[Percent],
	[PAYMENT_ADJUSTMENT].[PeriodicCapAmount],
	[PAYMENT_ADJUSTMENT].[PeriodicCapPercent],
	[PAYMENT_ADJUSTMENT].[PeriodNumber],
	[PAYMENT_ADJUSTMENT].[SubsequentPaymentAdjustmentMonths]
from 
	[PAYMENT_ADJUSTMENT] 
where 
	[PAYMENT_ADJUSTMENT].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PRESENT_HOUSING_EXPENSE
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectPresentHousingExpense
(
@id BigInt
)
as


select 
	[PRESENT_HOUSING_EXPENSE].[Id],
	[PRESENT_HOUSING_EXPENSE].[BorrowerId],
	[PRESENT_HOUSING_EXPENSE].[PaymentAmount],
	[PRESENT_HOUSING_EXPENSE].[HousingExpenseType]
from 
	[PRESENT_HOUSING_EXPENSE] 
where 
	[PRESENT_HOUSING_EXPENSE].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PRESENT_HOUSING_EXPENSE
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectPresentHousingExpenses
as


select 
	[PRESENT_HOUSING_EXPENSE].[Id],
	[PRESENT_HOUSING_EXPENSE].[BorrowerId],
	[PRESENT_HOUSING_EXPENSE].[PaymentAmount],
	[PRESENT_HOUSING_EXPENSE].[HousingExpenseType]
from 
	[PRESENT_HOUSING_EXPENSE] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PRESENT_HOUSING_EXPENSE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectPresentHousingExpensesByBorrower
(
@borrowerId BigInt
)
as


select 
	[PRESENT_HOUSING_EXPENSE].[Id],
	[PRESENT_HOUSING_EXPENSE].[BorrowerId],
	[PRESENT_HOUSING_EXPENSE].[PaymentAmount],
	[PRESENT_HOUSING_EXPENSE].[HousingExpenseType]
from 
	[PRESENT_HOUSING_EXPENSE] 
where 
	[PRESENT_HOUSING_EXPENSE].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PRESENT_HOUSING_EXPENSE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectPresentHousingExpensesByHousingExpenseType
(
@housingExpenseType SmallInt
)
as


select 
	[PRESENT_HOUSING_EXPENSE].[Id],
	[PRESENT_HOUSING_EXPENSE].[BorrowerId],
	[PRESENT_HOUSING_EXPENSE].[PaymentAmount],
	[PRESENT_HOUSING_EXPENSE].[HousingExpenseType]
from 
	[PRESENT_HOUSING_EXPENSE] 
where 
	[PRESENT_HOUSING_EXPENSE].[HousingExpenseType] = @housingExpenseType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PURCHASE_CREDIT
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectPurchaseCredit
(
@id BigInt
)
as


select 
	[PURCHASE_CREDIT].[Id],
	[PURCHASE_CREDIT].[Amount],
	[PURCHASE_CREDIT].[SourceType],
	[PURCHASE_CREDIT].[LoanApplicationId],
	[PURCHASE_CREDIT].[Type]
from 
	[PURCHASE_CREDIT] 
where 
	[PURCHASE_CREDIT].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PURCHASE_CREDIT
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectPurchaseCreditCollection
as


select 
	[PURCHASE_CREDIT].[Id],
	[PURCHASE_CREDIT].[Amount],
	[PURCHASE_CREDIT].[SourceType],
	[PURCHASE_CREDIT].[LoanApplicationId],
	[PURCHASE_CREDIT].[Type]
from 
	[PURCHASE_CREDIT] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PURCHASE_CREDIT
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectPurchaseCreditCollectionByPurchaseCreditSourceType
(
@sourceType SmallInt = null
)
as


select 
	[PURCHASE_CREDIT].[Id],
	[PURCHASE_CREDIT].[Amount],
	[PURCHASE_CREDIT].[SourceType],
	[PURCHASE_CREDIT].[LoanApplicationId],
	[PURCHASE_CREDIT].[Type]
from 
	[PURCHASE_CREDIT] 
where 
	[PURCHASE_CREDIT].[SourceType] = @sourceType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PURCHASE_CREDIT
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectPurchaseCreditCollectionByPurchaseCreditType
(
@type SmallInt = null
)
as


select 
	[PURCHASE_CREDIT].[Id],
	[PURCHASE_CREDIT].[Amount],
	[PURCHASE_CREDIT].[SourceType],
	[PURCHASE_CREDIT].[LoanApplicationId],
	[PURCHASE_CREDIT].[Type]
from 
	[PURCHASE_CREDIT] 
where 
	[PURCHASE_CREDIT].[Type] = @type
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:03 AM
System User: marlon
System Machine: SERVER
Entity Name: PURCHASE_CREDIT
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectPurchaseCreditCollectionByTransactionDetail
(
@loanApplicationId BigInt
)
as


select 
	[PURCHASE_CREDIT].[Id],
	[PURCHASE_CREDIT].[Amount],
	[PURCHASE_CREDIT].[SourceType],
	[PURCHASE_CREDIT].[LoanApplicationId],
	[PURCHASE_CREDIT].[Type]
from 
	[PURCHASE_CREDIT] 
where 
	[PURCHASE_CREDIT].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RATE_ADJUSTMENT
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectRateAdjustment
(
@id BigInt
)
as


select 
	[RATE_ADJUSTMENT].[Id],
	[RATE_ADJUSTMENT].[LoanApplicationId],
	[RATE_ADJUSTMENT].[FirstRateAdjustmentMonths],
	[RATE_ADJUSTMENT].[CalculationType],
	[RATE_ADJUSTMENT].[DurationMonths],
	[RATE_ADJUSTMENT].[Percent],
	[RATE_ADJUSTMENT].[PeriodNumber],
	[RATE_ADJUSTMENT].[SubsequentCapPercent],
	[RATE_ADJUSTMENT].[SubsequentRateAdjustmentMonths]
from 
	[RATE_ADJUSTMENT] 
where 
	[RATE_ADJUSTMENT].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RATE_ADJUSTMENT
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectRateAdjustments
as


select 
	[RATE_ADJUSTMENT].[Id],
	[RATE_ADJUSTMENT].[LoanApplicationId],
	[RATE_ADJUSTMENT].[FirstRateAdjustmentMonths],
	[RATE_ADJUSTMENT].[CalculationType],
	[RATE_ADJUSTMENT].[DurationMonths],
	[RATE_ADJUSTMENT].[Percent],
	[RATE_ADJUSTMENT].[PeriodNumber],
	[RATE_ADJUSTMENT].[SubsequentCapPercent],
	[RATE_ADJUSTMENT].[SubsequentRateAdjustmentMonths]
from 
	[RATE_ADJUSTMENT] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RATE_ADJUSTMENT
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectRateAdjustmentsByLoanProductData
(
@loanApplicationId BigInt
)
as


select 
	[RATE_ADJUSTMENT].[Id],
	[RATE_ADJUSTMENT].[LoanApplicationId],
	[RATE_ADJUSTMENT].[FirstRateAdjustmentMonths],
	[RATE_ADJUSTMENT].[CalculationType],
	[RATE_ADJUSTMENT].[DurationMonths],
	[RATE_ADJUSTMENT].[Percent],
	[RATE_ADJUSTMENT].[PeriodNumber],
	[RATE_ADJUSTMENT].[SubsequentCapPercent],
	[RATE_ADJUSTMENT].[SubsequentRateAdjustmentMonths]
from 
	[RATE_ADJUSTMENT] 
where 
	[RATE_ADJUSTMENT].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: RESIDENCE
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectResidence
(
@id BigInt
)
as


select 
	[RESIDENCE].[Id],
	[RESIDENCE].[BorrowerId],
	[RESIDENCE].[StreetAddress],
	[RESIDENCE].[City],
	[RESIDENCE].[State],
	[RESIDENCE].[PostalCode],
	[RESIDENCE].[Country],
	[RESIDENCE].[BorrowerResidencyDurationMonths],
	[RESIDENCE].[BorrowerResidencyDurationYears],
	[RESIDENCE].[BorrowerResidencyBasisType],
	[RESIDENCE].[BorrowerResidencyType]
from 
	[RESIDENCE] 
where 
	[RESIDENCE].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: RESIDENCE
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectResidences
as


select 
	[RESIDENCE].[Id],
	[RESIDENCE].[BorrowerId],
	[RESIDENCE].[StreetAddress],
	[RESIDENCE].[City],
	[RESIDENCE].[State],
	[RESIDENCE].[PostalCode],
	[RESIDENCE].[Country],
	[RESIDENCE].[BorrowerResidencyDurationMonths],
	[RESIDENCE].[BorrowerResidencyDurationYears],
	[RESIDENCE].[BorrowerResidencyBasisType],
	[RESIDENCE].[BorrowerResidencyType]
from 
	[RESIDENCE] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: RESIDENCE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectResidencesByBorrower
(
@borrowerId BigInt = null
)
as


select 
	[RESIDENCE].[Id],
	[RESIDENCE].[BorrowerId],
	[RESIDENCE].[StreetAddress],
	[RESIDENCE].[City],
	[RESIDENCE].[State],
	[RESIDENCE].[PostalCode],
	[RESIDENCE].[Country],
	[RESIDENCE].[BorrowerResidencyDurationMonths],
	[RESIDENCE].[BorrowerResidencyDurationYears],
	[RESIDENCE].[BorrowerResidencyBasisType],
	[RESIDENCE].[BorrowerResidencyType]
from 
	[RESIDENCE] 
where 
	[RESIDENCE].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: RESIDENCE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectResidencesByBorrowerResidencyBasisType
(
@borrowerResidencyBasisType SmallInt = null
)
as


select 
	[RESIDENCE].[Id],
	[RESIDENCE].[BorrowerId],
	[RESIDENCE].[StreetAddress],
	[RESIDENCE].[City],
	[RESIDENCE].[State],
	[RESIDENCE].[PostalCode],
	[RESIDENCE].[Country],
	[RESIDENCE].[BorrowerResidencyDurationMonths],
	[RESIDENCE].[BorrowerResidencyDurationYears],
	[RESIDENCE].[BorrowerResidencyBasisType],
	[RESIDENCE].[BorrowerResidencyType]
from 
	[RESIDENCE] 
where 
	[RESIDENCE].[BorrowerResidencyBasisType] = @borrowerResidencyBasisType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: RESIDENCE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectResidencesByBorrowerResidencyType
(
@borrowerResidencyType SmallInt = null
)
as


select 
	[RESIDENCE].[Id],
	[RESIDENCE].[BorrowerId],
	[RESIDENCE].[StreetAddress],
	[RESIDENCE].[City],
	[RESIDENCE].[State],
	[RESIDENCE].[PostalCode],
	[RESIDENCE].[Country],
	[RESIDENCE].[BorrowerResidencyDurationMonths],
	[RESIDENCE].[BorrowerResidencyDurationYears],
	[RESIDENCE].[BorrowerResidencyBasisType],
	[RESIDENCE].[BorrowerResidencyType]
from 
	[RESIDENCE] 
where 
	[RESIDENCE].[BorrowerResidencyType] = @borrowerResidencyType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: SUMMARY
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectSummaries
as


select 
	[SUMMARY].[Id],
	[SUMMARY].[BorrowerId],
	[SUMMARY].[Amount],
	[SUMMARY].[AmountType]
from 
	[SUMMARY] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: SUMMARY
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectSummariesByBorrower
(
@borrowerId BigInt = null
)
as


select 
	[SUMMARY].[Id],
	[SUMMARY].[BorrowerId],
	[SUMMARY].[Amount],
	[SUMMARY].[AmountType]
from 
	[SUMMARY] 
where 
	[SUMMARY].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: SUMMARY
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectSummariesBySummaryAmountType
(
@amountType SmallInt = null
)
as


select 
	[SUMMARY].[Id],
	[SUMMARY].[BorrowerId],
	[SUMMARY].[Amount],
	[SUMMARY].[AmountType]
from 
	[SUMMARY] 
where 
	[SUMMARY].[AmountType] = @amountType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: SUMMARY
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectSummary
(
@id BigInt
)
as


select 
	[SUMMARY].[Id],
	[SUMMARY].[BorrowerId],
	[SUMMARY].[Amount],
	[SUMMARY].[AmountType]
from 
	[SUMMARY] 
where 
	[SUMMARY].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSMITTAL_DATA
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectTransmittalData
(
@loanApplicationId BigInt
)
as


select 
	[TRANSMITTAL_DATA].[LoanApplicationId],
	[TRANSMITTAL_DATA].[ArmsLengthIndicator],
	[TRANSMITTAL_DATA].[BelowMarketSubordinateFinancingIndicator],
	[TRANSMITTAL_DATA].[BuydownRatePercent],
	[TRANSMITTAL_DATA].[CreditReportAuthorizationIndicator],
	[TRANSMITTAL_DATA].[LenderBranchIdentifier],
	[TRANSMITTAL_DATA].[LenderRegistrationIdentifier],
	[TRANSMITTAL_DATA].[PropertyAppraisedValueAmount],
	[TRANSMITTAL_DATA].[PropertyEstimatedValueAmount],
	[TRANSMITTAL_DATA].[InvestorLoanIdentifier],
	[TRANSMITTAL_DATA].[InvestorInstitutionIdentifier],
	[TRANSMITTAL_DATA].[CommitmentReferenceIdentifier],
	[TRANSMITTAL_DATA].[ConcurrentOriginationIndicator],
	[TRANSMITTAL_DATA].[ConcurrentOriginationLenderIndicator],
	[TRANSMITTAL_DATA].[RateLockPeriodDays],
	[TRANSMITTAL_DATA].[RateLockRequestedExtensionDays],
	[TRANSMITTAL_DATA].[CaseStateType],
	[TRANSMITTAL_DATA].[RateLockType],
	[TRANSMITTAL_DATA].[CurrentFirstMortgageHolderType]
from 
	[TRANSMITTAL_DATA] 
where 
	[TRANSMITTAL_DATA].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSMITTAL_DATA
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectTransmittalDataCollection
as


select 
	[TRANSMITTAL_DATA].[LoanApplicationId],
	[TRANSMITTAL_DATA].[ArmsLengthIndicator],
	[TRANSMITTAL_DATA].[BelowMarketSubordinateFinancingIndicator],
	[TRANSMITTAL_DATA].[BuydownRatePercent],
	[TRANSMITTAL_DATA].[CreditReportAuthorizationIndicator],
	[TRANSMITTAL_DATA].[LenderBranchIdentifier],
	[TRANSMITTAL_DATA].[LenderRegistrationIdentifier],
	[TRANSMITTAL_DATA].[PropertyAppraisedValueAmount],
	[TRANSMITTAL_DATA].[PropertyEstimatedValueAmount],
	[TRANSMITTAL_DATA].[InvestorLoanIdentifier],
	[TRANSMITTAL_DATA].[InvestorInstitutionIdentifier],
	[TRANSMITTAL_DATA].[CommitmentReferenceIdentifier],
	[TRANSMITTAL_DATA].[ConcurrentOriginationIndicator],
	[TRANSMITTAL_DATA].[ConcurrentOriginationLenderIndicator],
	[TRANSMITTAL_DATA].[RateLockPeriodDays],
	[TRANSMITTAL_DATA].[RateLockRequestedExtensionDays],
	[TRANSMITTAL_DATA].[CaseStateType],
	[TRANSMITTAL_DATA].[RateLockType],
	[TRANSMITTAL_DATA].[CurrentFirstMortgageHolderType]
from 
	[TRANSMITTAL_DATA] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSMITTAL_DATA
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectTransmittalDataCollectionByAdditionalCaseData
(
@loanApplicationId BigInt
)
as


select 
	[TRANSMITTAL_DATA].[LoanApplicationId],
	[TRANSMITTAL_DATA].[ArmsLengthIndicator],
	[TRANSMITTAL_DATA].[BelowMarketSubordinateFinancingIndicator],
	[TRANSMITTAL_DATA].[BuydownRatePercent],
	[TRANSMITTAL_DATA].[CreditReportAuthorizationIndicator],
	[TRANSMITTAL_DATA].[LenderBranchIdentifier],
	[TRANSMITTAL_DATA].[LenderRegistrationIdentifier],
	[TRANSMITTAL_DATA].[PropertyAppraisedValueAmount],
	[TRANSMITTAL_DATA].[PropertyEstimatedValueAmount],
	[TRANSMITTAL_DATA].[InvestorLoanIdentifier],
	[TRANSMITTAL_DATA].[InvestorInstitutionIdentifier],
	[TRANSMITTAL_DATA].[CommitmentReferenceIdentifier],
	[TRANSMITTAL_DATA].[ConcurrentOriginationIndicator],
	[TRANSMITTAL_DATA].[ConcurrentOriginationLenderIndicator],
	[TRANSMITTAL_DATA].[RateLockPeriodDays],
	[TRANSMITTAL_DATA].[RateLockRequestedExtensionDays],
	[TRANSMITTAL_DATA].[CaseStateType],
	[TRANSMITTAL_DATA].[RateLockType],
	[TRANSMITTAL_DATA].[CurrentFirstMortgageHolderType]
from 
	[TRANSMITTAL_DATA] 
where 
	[TRANSMITTAL_DATA].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSMITTAL_DATA
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectTransmittalDataCollectionByCaseStateType
(
@caseStateType SmallInt = null
)
as


select 
	[TRANSMITTAL_DATA].[LoanApplicationId],
	[TRANSMITTAL_DATA].[ArmsLengthIndicator],
	[TRANSMITTAL_DATA].[BelowMarketSubordinateFinancingIndicator],
	[TRANSMITTAL_DATA].[BuydownRatePercent],
	[TRANSMITTAL_DATA].[CreditReportAuthorizationIndicator],
	[TRANSMITTAL_DATA].[LenderBranchIdentifier],
	[TRANSMITTAL_DATA].[LenderRegistrationIdentifier],
	[TRANSMITTAL_DATA].[PropertyAppraisedValueAmount],
	[TRANSMITTAL_DATA].[PropertyEstimatedValueAmount],
	[TRANSMITTAL_DATA].[InvestorLoanIdentifier],
	[TRANSMITTAL_DATA].[InvestorInstitutionIdentifier],
	[TRANSMITTAL_DATA].[CommitmentReferenceIdentifier],
	[TRANSMITTAL_DATA].[ConcurrentOriginationIndicator],
	[TRANSMITTAL_DATA].[ConcurrentOriginationLenderIndicator],
	[TRANSMITTAL_DATA].[RateLockPeriodDays],
	[TRANSMITTAL_DATA].[RateLockRequestedExtensionDays],
	[TRANSMITTAL_DATA].[CaseStateType],
	[TRANSMITTAL_DATA].[RateLockType],
	[TRANSMITTAL_DATA].[CurrentFirstMortgageHolderType]
from 
	[TRANSMITTAL_DATA] 
where 
	[TRANSMITTAL_DATA].[CaseStateType] = @caseStateType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSMITTAL_DATA
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectTransmittalDataCollectionByMortgageHolderType
(
@currentFirstMortgageHolderType SmallInt = null
)
as


select 
	[TRANSMITTAL_DATA].[LoanApplicationId],
	[TRANSMITTAL_DATA].[ArmsLengthIndicator],
	[TRANSMITTAL_DATA].[BelowMarketSubordinateFinancingIndicator],
	[TRANSMITTAL_DATA].[BuydownRatePercent],
	[TRANSMITTAL_DATA].[CreditReportAuthorizationIndicator],
	[TRANSMITTAL_DATA].[LenderBranchIdentifier],
	[TRANSMITTAL_DATA].[LenderRegistrationIdentifier],
	[TRANSMITTAL_DATA].[PropertyAppraisedValueAmount],
	[TRANSMITTAL_DATA].[PropertyEstimatedValueAmount],
	[TRANSMITTAL_DATA].[InvestorLoanIdentifier],
	[TRANSMITTAL_DATA].[InvestorInstitutionIdentifier],
	[TRANSMITTAL_DATA].[CommitmentReferenceIdentifier],
	[TRANSMITTAL_DATA].[ConcurrentOriginationIndicator],
	[TRANSMITTAL_DATA].[ConcurrentOriginationLenderIndicator],
	[TRANSMITTAL_DATA].[RateLockPeriodDays],
	[TRANSMITTAL_DATA].[RateLockRequestedExtensionDays],
	[TRANSMITTAL_DATA].[CaseStateType],
	[TRANSMITTAL_DATA].[RateLockType],
	[TRANSMITTAL_DATA].[CurrentFirstMortgageHolderType]
from 
	[TRANSMITTAL_DATA] 
where 
	[TRANSMITTAL_DATA].[CurrentFirstMortgageHolderType] = @currentFirstMortgageHolderType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSMITTAL_DATA
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectTransmittalDataCollectionByRateLockType
(
@rateLockType SmallInt = null
)
as


select 
	[TRANSMITTAL_DATA].[LoanApplicationId],
	[TRANSMITTAL_DATA].[ArmsLengthIndicator],
	[TRANSMITTAL_DATA].[BelowMarketSubordinateFinancingIndicator],
	[TRANSMITTAL_DATA].[BuydownRatePercent],
	[TRANSMITTAL_DATA].[CreditReportAuthorizationIndicator],
	[TRANSMITTAL_DATA].[LenderBranchIdentifier],
	[TRANSMITTAL_DATA].[LenderRegistrationIdentifier],
	[TRANSMITTAL_DATA].[PropertyAppraisedValueAmount],
	[TRANSMITTAL_DATA].[PropertyEstimatedValueAmount],
	[TRANSMITTAL_DATA].[InvestorLoanIdentifier],
	[TRANSMITTAL_DATA].[InvestorInstitutionIdentifier],
	[TRANSMITTAL_DATA].[CommitmentReferenceIdentifier],
	[TRANSMITTAL_DATA].[ConcurrentOriginationIndicator],
	[TRANSMITTAL_DATA].[ConcurrentOriginationLenderIndicator],
	[TRANSMITTAL_DATA].[RateLockPeriodDays],
	[TRANSMITTAL_DATA].[RateLockRequestedExtensionDays],
	[TRANSMITTAL_DATA].[CaseStateType],
	[TRANSMITTAL_DATA].[RateLockType],
	[TRANSMITTAL_DATA].[CurrentFirstMortgageHolderType]
from 
	[TRANSMITTAL_DATA] 
where 
	[TRANSMITTAL_DATA].[RateLockType] = @rateLockType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: VA_BORROWER
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectVABorrower
(
@borrowerId BigInt
)
as


select 
	[VA_BORROWER].[BorrowerId],
	[VA_BORROWER].[VACoBorrowerNonTaxableIncomeAmount],
	[VA_BORROWER].[VACoBorrowerTaxableIncomeAmount],
	[VA_BORROWER].[VAFederalTaxAmount],
	[VA_BORROWER].[VALocalTaxAmount],
	[VA_BORROWER].[VAPrimaryBorrowerNonTaxableIncomeAmount],
	[VA_BORROWER].[VAPrimaryBorrowerTaxableIncomeAmount],
	[VA_BORROWER].[VASocialSecurityTaxAmount],
	[VA_BORROWER].[VAStateTaxAmount]
from 
	[VA_BORROWER] 
where 
	[VA_BORROWER].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: VA_BORROWER
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectVABorrowers
as


select 
	[VA_BORROWER].[BorrowerId],
	[VA_BORROWER].[VACoBorrowerNonTaxableIncomeAmount],
	[VA_BORROWER].[VACoBorrowerTaxableIncomeAmount],
	[VA_BORROWER].[VAFederalTaxAmount],
	[VA_BORROWER].[VALocalTaxAmount],
	[VA_BORROWER].[VAPrimaryBorrowerNonTaxableIncomeAmount],
	[VA_BORROWER].[VAPrimaryBorrowerTaxableIncomeAmount],
	[VA_BORROWER].[VASocialSecurityTaxAmount],
	[VA_BORROWER].[VAStateTaxAmount]
from 
	[VA_BORROWER] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: VA_BORROWER
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectVABorrowersByBorrower
(
@borrowerId BigInt
)
as


select 
	[VA_BORROWER].[BorrowerId],
	[VA_BORROWER].[VACoBorrowerNonTaxableIncomeAmount],
	[VA_BORROWER].[VACoBorrowerTaxableIncomeAmount],
	[VA_BORROWER].[VAFederalTaxAmount],
	[VA_BORROWER].[VALocalTaxAmount],
	[VA_BORROWER].[VAPrimaryBorrowerNonTaxableIncomeAmount],
	[VA_BORROWER].[VAPrimaryBorrowerTaxableIncomeAmount],
	[VA_BORROWER].[VASocialSecurityTaxAmount],
	[VA_BORROWER].[VAStateTaxAmount]
from 
	[VA_BORROWER] 
where 
	[VA_BORROWER].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: VA_LOAN
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectVALoan
(
@loanApplicationId BigInt
)
as


select 
	[VA_LOAN].[LoanApplicationId],
	[VA_LOAN].[VABorrowerCoBorrowerMarriedIndicator],
	[VA_LOAN].[BorrowerFundingFeePercent],
	[VA_LOAN].[VAEntitlementAmount],
	[VA_LOAN].[VAMaintenanceExpenseMonthlyAmount],
	[VA_LOAN].[VAResidualIncomeAmount],
	[VA_LOAN].[VAUtilityExpenseMonthlyAmount]
from 
	[VA_LOAN] 
where 
	[VA_LOAN].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: VA_LOAN
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectVALoans
as


select 
	[VA_LOAN].[LoanApplicationId],
	[VA_LOAN].[VABorrowerCoBorrowerMarriedIndicator],
	[VA_LOAN].[BorrowerFundingFeePercent],
	[VA_LOAN].[VAEntitlementAmount],
	[VA_LOAN].[VAMaintenanceExpenseMonthlyAmount],
	[VA_LOAN].[VAResidualIncomeAmount],
	[VA_LOAN].[VAUtilityExpenseMonthlyAmount]
from 
	[VA_LOAN] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: VA_LOAN
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectVALoansByGovernmentLoan
(
@loanApplicationId BigInt
)
as


select 
	[VA_LOAN].[LoanApplicationId],
	[VA_LOAN].[VABorrowerCoBorrowerMarriedIndicator],
	[VA_LOAN].[BorrowerFundingFeePercent],
	[VA_LOAN].[VAEntitlementAmount],
	[VA_LOAN].[VAMaintenanceExpenseMonthlyAmount],
	[VA_LOAN].[VAResidualIncomeAmount],
	[VA_LOAN].[VAUtilityExpenseMonthlyAmount]
from 
	[VA_LOAN] 
where 
	[VA_LOAN].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:09 AM
System User: marlon
System Machine: SERVER
Entity Name: VALUATION
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectValuation
(
@id BigInt
)
as


select 
	[VALUATION].[Id],
	[VALUATION].[LoanApplicationId],
	[VALUATION].[AppraiserId],
	[VALUATION].[MethodTypeOtherDescription],
	[VALUATION].[MethodType]
from 
	[VALUATION] 
where 
	[VALUATION].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:09 AM
System User: marlon
System Machine: SERVER
Entity Name: VALUATION
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectValuations
as


select 
	[VALUATION].[Id],
	[VALUATION].[LoanApplicationId],
	[VALUATION].[AppraiserId],
	[VALUATION].[MethodTypeOtherDescription],
	[VALUATION].[MethodType]
from 
	[VALUATION] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:09 AM
System User: marlon
System Machine: SERVER
Entity Name: VALUATION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectValuationsByAppraiser
(
@appraiserId Int = null
)
as


select 
	[VALUATION].[Id],
	[VALUATION].[LoanApplicationId],
	[VALUATION].[AppraiserId],
	[VALUATION].[MethodTypeOtherDescription],
	[VALUATION].[MethodType]
from 
	[VALUATION] 
where 
	[VALUATION].[AppraiserId] = @appraiserId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:09 AM
System User: marlon
System Machine: SERVER
Entity Name: VALUATION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectValuationsByProperty
(
@loanApplicationId BigInt
)
as


select 
	[VALUATION].[Id],
	[VALUATION].[LoanApplicationId],
	[VALUATION].[AppraiserId],
	[VALUATION].[MethodTypeOtherDescription],
	[VALUATION].[MethodType]
from 
	[VALUATION] 
where 
	[VALUATION].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:09 AM
System User: marlon
System Machine: SERVER
Entity Name: VALUATION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectValuationsByPropertyValuationMethodType
(
@methodType SmallInt = null
)
as


select 
	[VALUATION].[Id],
	[VALUATION].[LoanApplicationId],
	[VALUATION].[AppraiserId],
	[VALUATION].[MethodTypeOtherDescription],
	[VALUATION].[MethodType]
from 
	[VALUATION] 
where 
	[VALUATION].[MethodType] = @methodType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:31 AM
System User: marlon
System Machine: SERVER
Entity Name: ARM
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateARM
(
@indexCurrentValuePercent Decimal(8,7) = null,
@indexMarginPercent Decimal(8,7) = null,
@indexType SmallInt = null,
@qualifyingRatePercent Decimal(8,7) = null,
@conversionOptionIndicator Bit,
@paymentAdjustmentLifetimeCapAmount Money = null,
@paymentAdjustmentLifetimeCapPercent Decimal(8,7) = null,
@rateAdjustmentLifetimeCapPercent Decimal(8,7) = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [ARM] set 
	[LoanApplicationId] = @loanApplicationId,
	[IndexCurrentValuePercent] = @indexCurrentValuePercent,
	[IndexMarginPercent] = @indexMarginPercent,
	[IndexType] = @indexType,
	[QualifyingRatePercent] = @qualifyingRatePercent,
	[ConversionOptionIndicator] = @conversionOptionIndicator,
	[PaymentAdjustmentLifetimeCapAmount] = @paymentAdjustmentLifetimeCapAmount,
	[PaymentAdjustmentLifetimeCapPercent] = @paymentAdjustmentLifetimeCapPercent,
	[RateAdjustmentLifetimeCapPercent] = @rateAdjustmentLifetimeCapPercent
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:30 AM
System User: marlon
System Machine: SERVER
Entity Name: ALIAS
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateAlias
(
@borrowerId BigInt = null,
@firstName VarChar(64) = null,
@lastName VarChar(64) = null,
@middleName VarChar(64) = null,
@id BigInt
)
as


-- persist the data via an update
update [ALIAS] set 
	[BorrowerId] = @borrowerId,
	[FirstName] = @firstName,
	[LastName] = @lastName,
	[MiddleName] = @middleName
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:32 AM
System User: marlon
System Machine: SERVER
Entity Name: ASSET
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateAsset
(
@borrowerId BigInt,
@loanApplicationId BigInt,
@accountIdentifier VarChar(64) = null,
@cashOrMarketValueAmount Money = null,
@type SmallInt,
@verifiedIndicator Bit,
@holderName VarChar(64) = null,
@holderStreetAddress VarChar(64) = null,
@holderCity VarChar(64) = null,
@holderState VarChar(64) = null,
@holderPostalCode VarChar(64) = null,
@automobileMakeDescription VarChar(64) = null,
@automobileModelYear DateTime = null,
@lifeInsuranceFaceValueAmount Money = null,
@otherAssetTypeDescription VarChar(64) = null,
@stockBondMutualFundShareCount Decimal(18,0) = null,
@id BigInt
)
as


-- persist the data via an update
update [ASSET] set 
	[BorrowerId] = @borrowerId,
	[LoanApplicationId] = @loanApplicationId,
	[AccountIdentifier] = @accountIdentifier,
	[CashOrMarketValueAmount] = @cashOrMarketValueAmount,
	[Type] = @type,
	[VerifiedIndicator] = @verifiedIndicator,
	[HolderName] = @holderName,
	[HolderStreetAddress] = @holderStreetAddress,
	[HolderCity] = @holderCity,
	[HolderState] = @holderState,
	[HolderPostalCode] = @holderPostalCode,
	[AutomobileMakeDescription] = @automobileMakeDescription,
	[AutomobileModelYear] = @automobileModelYear,
	[LifeInsuranceFaceValueAmount] = @lifeInsuranceFaceValueAmount,
	[OtherAssetTypeDescription] = @otherAssetTypeDescription,
	[StockBondMutualFundShareCount] = @stockBondMutualFundShareCount
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:34 AM
System User: marlon
System Machine: SERVER
Entity Name: BUYDOWN
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateBuydown
(
@loanApplicationId BigInt,
@changeFrequencyMonths Decimal(18,0) = null,
@durationMonths Decimal(18,0) = null,
@increaseRatePercent Decimal(8,7) = null,
@lenderFundingIndicator Bit,
@permanentIndicator Bit,
@baseDataType SmallInt = null,
@contributorType SmallInt = null,
@id BigInt
)
as


-- persist the data via an update
update [BUYDOWN] set 
	[LoanApplicationId] = @loanApplicationId,
	[ChangeFrequencyMonths] = @changeFrequencyMonths,
	[DurationMonths] = @durationMonths,
	[IncreaseRatePercent] = @increaseRatePercent,
	[LenderFundingIndicator] = @lenderFundingIndicator,
	[PermanentIndicator] = @permanentIndicator,
	[BaseDataType] = @baseDataType,
	[ContributorType] = @contributorType
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:35 AM
System User: marlon
System Machine: SERVER
Entity Name: CONSTRUCTION_REFINANCE_DATA
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateConstructionRefinanceData
(
@constructionImprovementCostsAmount Money = null,
@fRECashOutAmount Money = null,
@landEstimatedValueAmount Money = null,
@landOriginalCostAmount Money = null,
@propertyAcquiredYear DateTime = null,
@propertyExistingLienAmount Money = null,
@propertyOriginalCostAmount Money = null,
@refinanceImprovementCostsAmount Money = null,
@refinanceProposedImprovementsDescription VarChar(254) = null,
@secondaryFinancingRefinanceIndicator Bit,
@fNMSecondMortgageFinancingOriginalPropertyIndicator Bit,
@structuralAlterationsConventionalAmount Money = null,
@nonStructuralAlterationsConventionalAmount Money = null,
@constructionPurposeType SmallInt = null,
@refinanceImprovementsType SmallInt = null,
@gSERefinancePurposeType SmallInt = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [CONSTRUCTION_REFINANCE_DATA] set 
	[LoanApplicationId] = @loanApplicationId,
	[ConstructionImprovementCostsAmount] = @constructionImprovementCostsAmount,
	[FRECashOutAmount] = @fRECashOutAmount,
	[LandEstimatedValueAmount] = @landEstimatedValueAmount,
	[LandOriginalCostAmount] = @landOriginalCostAmount,
	[PropertyAcquiredYear] = @propertyAcquiredYear,
	[PropertyExistingLienAmount] = @propertyExistingLienAmount,
	[PropertyOriginalCostAmount] = @propertyOriginalCostAmount,
	[RefinanceImprovementCostsAmount] = @refinanceImprovementCostsAmount,
	[RefinanceProposedImprovementsDescription] = @refinanceProposedImprovementsDescription,
	[SecondaryFinancingRefinanceIndicator] = @secondaryFinancingRefinanceIndicator,
	[FNMSecondMortgageFinancingOriginalPropertyIndicator] = @fNMSecondMortgageFinancingOriginalPropertyIndicator,
	[StructuralAlterationsConventionalAmount] = @structuralAlterationsConventionalAmount,
	[NonStructuralAlterationsConventionalAmount] = @nonStructuralAlterationsConventionalAmount,
	[ConstructionPurposeType] = @constructionPurposeType,
	[RefinanceImprovementsType] = @refinanceImprovementsType,
	[GSERefinancePurposeType] = @gSERefinancePurposeType
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:36 AM
System User: marlon
System Machine: SERVER
Entity Name: CONTACT_POINT
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateContactPoint
(
@borrowerId BigInt = null,
@typeOtherDescription VarChar(254) = null,
@value VarChar(64) = null,
@preferenceIndicator Bit,
@roleType SmallInt = null,
@type SmallInt = null,
@id BigInt
)
as


-- persist the data via an update
update [CONTACT_POINT] set 
	[BorrowerId] = @borrowerId,
	[TypeOtherDescription] = @typeOtherDescription,
	[Value] = @value,
	[PreferenceIndicator] = @preferenceIndicator,
	[RoleType] = @roleType,
	[Type] = @type
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:37 AM
System User: marlon
System Machine: SERVER
Entity Name: CREDIT_SCORE
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateCreditScore
(
@creditReportIdentifier VarChar(20) = null,
@creditScoreDate DateTime = null,
@creditScoreModelNameTypeOtherDescription VarChar(20) = null,
@creditScoreValue SmallInt = null,
@borrowerId BigInt,
@creditRepositorySourceType SmallInt = null,
@creditScoreExclusionType SmallInt = null,
@creditScoreModelNameType SmallInt = null,
@creditScoreID BigInt
)
as


-- persist the data via an update
update [CREDIT_SCORE] set 
	[CreditReportIdentifier] = @creditReportIdentifier,
	[CreditScoreDate] = @creditScoreDate,
	[CreditScoreModelNameTypeOtherDescription] = @creditScoreModelNameTypeOtherDescription,
	[CreditScoreValue] = @creditScoreValue,
	[BorrowerId] = @borrowerId,
	[CreditRepositorySourceType] = @creditRepositorySourceType,
	[CreditScoreExclusionType] = @creditScoreExclusionType,
	[CreditScoreModelNameType] = @creditScoreModelNameType
where
	[CreditScoreID] = @creditScoreID


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: CURRENT_INCOME
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateCurrentIncome
(
@borrowerId BigInt,
@incomeType SmallInt,
@monthlyTotalAmount Money,
@id BigInt
)
as


-- persist the data via an update
update [CURRENT_INCOME] set 
	[BorrowerId] = @borrowerId,
	[IncomeType] = @incomeType,
	[MonthlyTotalAmount] = @monthlyTotalAmount
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:39 AM
System User: marlon
System Machine: SERVER
Entity Name: DATA_VERSION
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateDataVersion
(
@name VarChar(64),
@number VarChar(64),
@loanApplicationId BigInt,
@id Int
)
as


-- persist the data via an update
update [DATA_VERSION] set 
	[Name] = @name,
	[Number] = @number,
	[LoanApplicationId] = @loanApplicationId
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DECLARATION
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateDeclaration
(
@alimonyChildSupportObligationIndicator Bit,
@bankruptcyIndicator Bit,
@borrowedDownPaymentIndicator Bit,
@coMakerEndorserOfNoteIndicator Bit,
@homeownerPastThreeYearsType Bit = null,
@intentToOccupyType Bit = null,
@loanForeclosureOrJudgementIndicator Bit,
@outstandingJudgementsIndicator Bit,
@partyToLawsuitIndicator Bit,
@presentlyDelinquentIndicator Bit,
@propertyForeclosedPastSevenYearsIndicator Bit,
@citizenshipResidencyType SmallInt = null,
@priorPropertyTitleType SmallInt = null,
@priorPropertyUsageType SmallInt = null,
@borrowerId BigInt
)
as


-- persist the data via an update
update [DECLARATION] set 
	[BorrowerId] = @borrowerId,
	[AlimonyChildSupportObligationIndicator] = @alimonyChildSupportObligationIndicator,
	[BankruptcyIndicator] = @bankruptcyIndicator,
	[BorrowedDownPaymentIndicator] = @borrowedDownPaymentIndicator,
	[CoMakerEndorserOfNoteIndicator] = @coMakerEndorserOfNoteIndicator,
	[HomeownerPastThreeYearsType] = @homeownerPastThreeYearsType,
	[IntentToOccupyType] = @intentToOccupyType,
	[LoanForeclosureOrJudgementIndicator] = @loanForeclosureOrJudgementIndicator,
	[OutstandingJudgementsIndicator] = @outstandingJudgementsIndicator,
	[PartyToLawsuitIndicator] = @partyToLawsuitIndicator,
	[PresentlyDelinquentIndicator] = @presentlyDelinquentIndicator,
	[PropertyForeclosedPastSevenYearsIndicator] = @propertyForeclosedPastSevenYearsIndicator,
	[CitizenshipResidencyType] = @citizenshipResidencyType,
	[PriorPropertyTitleType] = @priorPropertyTitleType,
	[PriorPropertyUsageType] = @priorPropertyUsageType
where
	[BorrowerId] = @borrowerId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:40 AM
System User: marlon
System Machine: SERVER
Entity Name: DEPENDENT
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateDependent
(
@borrowerId BigInt,
@ageYears Decimal(18,0),
@id BigInt
)
as


-- persist the data via an update
update [DEPENDENT] set 
	[BorrowerId] = @borrowerId,
	[AgeYears] = @ageYears
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:41 AM
System User: marlon
System Machine: SERVER
Entity Name: EMPLOYER
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateEmployer
(
@borrowerId BigInt,
@name VarChar(128) = null,
@streetAddress VarChar(128) = null,
@city VarChar(64) = null,
@state VarChar(64) = null,
@postalCode VarChar(16) = null,
@telephoneNumber VarChar(32) = null,
@currentEmploymentMonthsOnJob Decimal(18,0) = null,
@currentEmploymentTimeInLineOfWorkYears Decimal(18,0) = null,
@currentEmploymentYearsOnJob Decimal(18,0) = null,
@employmentBorrowerSelfEmployedIndicator Bit,
@employmentCurrentIndicator Bit,
@employmentPositionDescription VarChar(254) = null,
@employmentPrimaryIndicator Bit,
@incomeEmploymentMonthlyAmount Money = null,
@previousEmploymentEndDate DateTime = null,
@previousEmploymentStartDate DateTime = null,
@id BigInt
)
as


-- persist the data via an update
update [EMPLOYER] set 
	[BorrowerId] = @borrowerId,
	[Name] = @name,
	[StreetAddress] = @streetAddress,
	[City] = @city,
	[State] = @state,
	[PostalCode] = @postalCode,
	[TelephoneNumber] = @telephoneNumber,
	[CurrentEmploymentMonthsOnJob] = @currentEmploymentMonthsOnJob,
	[CurrentEmploymentTimeInLineOfWorkYears] = @currentEmploymentTimeInLineOfWorkYears,
	[CurrentEmploymentYearsOnJob] = @currentEmploymentYearsOnJob,
	[EmploymentBorrowerSelfEmployedIndicator] = @employmentBorrowerSelfEmployedIndicator,
	[EmploymentCurrentIndicator] = @employmentCurrentIndicator,
	[EmploymentPositionDescription] = @employmentPositionDescription,
	[EmploymentPrimaryIndicator] = @employmentPrimaryIndicator,
	[IncomeEmploymentMonthlyAmount] = @incomeEmploymentMonthlyAmount,
	[PreviousEmploymentEndDate] = @previousEmploymentEndDate,
	[PreviousEmploymentStartDate] = @previousEmploymentStartDate
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_LOAN
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateFHALoan
(
@borrowerFinancedFHADiscountPointsAmount Money = null,
@fHACoverageRenewalRatePercent Decimal(8,7) = null,
@fHA_MIPremiumRefundAmount Money = null,
@fHAUpfrontMIPremiumPercent Decimal(8,7) = null,
@lenderIdentifier VarChar(64) = null,
@sponsorIdentifier VarChar(64) = null,
@sectionOfActType SmallInt = null,
@fHAAlimonyLiabilityTreatmentType2 SmallInt = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [FHA_LOAN] set 
	[LoanApplicationId] = @loanApplicationId,
	[BorrowerFinancedFHADiscountPointsAmount] = @borrowerFinancedFHADiscountPointsAmount,
	[FHACoverageRenewalRatePercent] = @fHACoverageRenewalRatePercent,
	[FHA_MIPremiumRefundAmount] = @fHA_MIPremiumRefundAmount,
	[FHAUpfrontMIPremiumPercent] = @fHAUpfrontMIPremiumPercent,
	[LenderIdentifier] = @lenderIdentifier,
	[SponsorIdentifier] = @sponsorIdentifier,
	[SectionOfActType] = @sectionOfActType,
	[FHAAlimonyLiabilityTreatmentType2] = @fHAAlimonyLiabilityTreatmentType2
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_BORROWER
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateFHAVABorrower
(
@cAIVRSIdentifier VarChar(64) = null,
@fNMBankruptcyCount TinyInt = null,
@fNMBorrowerCreditRating VarChar(64) = null,
@fNMCreditReportScoreType SmallInt = null,
@fNMForeclosureCount TinyInt = null,
@veteranStatusIndicator Bit,
@borrowerId BigInt
)
as


-- persist the data via an update
update [FHA_VA_BORROWER] set 
	[BorrowerId] = @borrowerId,
	[CAIVRSIdentifier] = @cAIVRSIdentifier,
	[FNMBankruptcyCount] = @fNMBankruptcyCount,
	[FNMBorrowerCreditRating] = @fNMBorrowerCreditRating,
	[FNMCreditReportScoreType] = @fNMCreditReportScoreType,
	[FNMForeclosureCount] = @fNMForeclosureCount,
	[VeteranStatusIndicator] = @veteranStatusIndicator
where
	[BorrowerId] = @borrowerId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:43 AM
System User: marlon
System Machine: SERVER
Entity Name: FHA_VA_LOAN
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateFHAVALoan
(
@borrowerPaidFHA_VAClosingCostsAmount Money = null,
@borrowerPaidFHA_VAClosingCostsPercent Decimal(8,7) = null,
@governmentMortgageCreditCertificateAmount Money = null,
@governmentRefinanceType SmallInt = null,
@otherPartyPaidFHA_VAClosingCostsAmount Money = null,
@otherPartyPaidFHA_VAClosingCostsPercent Decimal(8,7) = null,
@propertyEnergyEfficientHomeIndicator Bit = null,
@sellerPaidFHA_VAClosingCostsPercent Decimal(8,7) = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [FHA_VA_LOAN] set 
	[LoanApplicationId] = @loanApplicationId,
	[BorrowerPaidFHA_VAClosingCostsAmount] = @borrowerPaidFHA_VAClosingCostsAmount,
	[BorrowerPaidFHA_VAClosingCostsPercent] = @borrowerPaidFHA_VAClosingCostsPercent,
	[GovernmentMortgageCreditCertificateAmount] = @governmentMortgageCreditCertificateAmount,
	[GovernmentRefinanceType] = @governmentRefinanceType,
	[OtherPartyPaidFHA_VAClosingCostsAmount] = @otherPartyPaidFHA_VAClosingCostsAmount,
	[OtherPartyPaidFHA_VAClosingCostsPercent] = @otherPartyPaidFHA_VAClosingCostsPercent,
	[PropertyEnergyEfficientHomeIndicator] = @propertyEnergyEfficientHomeIndicator,
	[SellerPaidFHA_VAClosingCostsPercent] = @sellerPaidFHA_VAClosingCostsPercent
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:45 AM
System User: marlon
System Machine: SERVER
Entity Name: GOVERNMENT_MONITORING
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateGovernmentMonitoring
(
@genderType SmallInt = null,
@otherRaceNationalOriginDescription VarChar(64) = null,
@raceNationalOriginRefusalIndicator Bit,
@raceNationalOriginType SmallInt = null,
@hMDAEthnicityType SmallInt = null,
@borrowerId BigInt
)
as


-- persist the data via an update
update [GOVERNMENT_MONITORING] set 
	[BorrowerId] = @borrowerId,
	[GenderType] = @genderType,
	[OtherRaceNationalOriginDescription] = @otherRaceNationalOriginDescription,
	[RaceNationalOriginRefusalIndicator] = @raceNationalOriginRefusalIndicator,
	[RaceNationalOriginType] = @raceNationalOriginType,
	[HMDAEthnicityType] = @hMDAEthnicityType
where
	[BorrowerId] = @borrowerId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:50 AM
System User: marlon
System Machine: SERVER
Entity Name: LEGAL_DESCRIPTION
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLegalDescription
(
@loanApplicationId BigInt,
@textDescription VarChar(254) = null,
@type SmallInt,
@id BigInt
)
as


-- persist the data via an update
update [LEGAL_DESCRIPTION] set 
	[LoanApplicationId] = @loanApplicationId,
	[TextDescription] = @textDescription,
	[Type] = @type
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:51 AM
System User: marlon
System Machine: SERVER
Entity Name: LIABILITY
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLiability
(
@loanApplicationId BigInt,
@borrowerId BigInt,
@rEO_ID VarChar(64) = null,
@holderStreetAddress VarChar(64) = null,
@holderCity VarChar(64) = null,
@holderState VarChar(64) = null,
@holderPostalCode VarChar(64) = null,
@alimonyOwedToName VarChar(64) = null,
@accountIdentifier VarChar(64) = null,
@exclusionIndicator Bit,
@holderName VarChar(64) = null,
@monthlyPaymentAmount Money = null,
@payoffStatusIndicator Bit,
@payoffWithCurrentAssetsIndicator Bit,
@remainingTermMonths Decimal(18,0) = null,
@type SmallInt,
@unpaidBalanceAmount Money = null,
@subjectLoanResubordinationIndicator Bit,
@id BigInt
)
as


-- persist the data via an update
update [LIABILITY] set 
	[LoanApplicationId] = @loanApplicationId,
	[BorrowerId] = @borrowerId,
	[REO_ID] = @rEO_ID,
	[HolderStreetAddress] = @holderStreetAddress,
	[HolderCity] = @holderCity,
	[HolderState] = @holderState,
	[HolderPostalCode] = @holderPostalCode,
	[AlimonyOwedToName] = @alimonyOwedToName,
	[AccountIdentifier] = @accountIdentifier,
	[ExclusionIndicator] = @exclusionIndicator,
	[HolderName] = @holderName,
	[MonthlyPaymentAmount] = @monthlyPaymentAmount,
	[PayoffStatusIndicator] = @payoffStatusIndicator,
	[PayoffWithCurrentAssetsIndicator] = @payoffWithCurrentAssetsIndicator,
	[RemainingTermMonths] = @remainingTermMonths,
	[Type] = @type,
	[UnpaidBalanceAmount] = @unpaidBalanceAmount,
	[SubjectLoanResubordinationIndicator] = @subjectLoanResubordinationIndicator
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:52 AM
System User: marlon
System Machine: SERVER
Entity Name: LOAN_FEATURES
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateLoanFeatures
(
@assumabilityIndicator Bit,
@balloonIndicator Bit,
@balloonLoanMaturityTermMonths Decimal(18,0) = null,
@buydownTemporarySubsidyIndicator Bit,
@counselingConfirmationIndicator Bit,
@escrowWaiverIndicator Bit,
@fREOfferingIdentifier VarChar(64) = null,
@fNMProductPlanIdentifier VarChar(64) = null,
@fNMProductPlanIndentifier VarChar(64) = null,
@hELOCMaximumBalanceAmount Money = null,
@hELOCInitialAdvanceAmount Money = null,
@interestOnlyTerm Decimal(18,0) = null,
@lenderSelfInsuredIndicator Bit,
@loanScheduledClosingDate DateTime = null,
@mICoveragePercent Decimal(8,7) = null,
@negativeAmortizationLimitPercent Decimal(8,7) = null,
@prepaymentPenaltyIndicator Bit,
@prepaymentPenaltyTermMonths Decimal(18,0) = null,
@prepaymentRestrictionIndicator Bit,
@productDescription VarChar(64) = null,
@productName VarChar(64) = null,
@scheduledFirstPaymentDate DateTime = null,
@nameDocumentsDrawnInType SmallInt = null,
@gSEProjectClassificationType SmallInt = null,
@gSEPropertyType SmallInt = null,
@lienPriorityType SmallInt = null,
@loanDocumentationType SmallInt = null,
@loanRepaymentType SmallInt = null,
@mICertificationStatusType SmallInt = null,
@mICompanyNameType SmallInt = null,
@paymentFrequencyType SmallInt = null,
@fullPrepaymentPenaltyOptionType SmallInt = null,
@loanClosingStatusType SmallInt = null,
@servicingTransferStatusType SmallInt = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [LOAN_FEATURES] set 
	[LoanApplicationId] = @loanApplicationId,
	[AssumabilityIndicator] = @assumabilityIndicator,
	[BalloonIndicator] = @balloonIndicator,
	[BalloonLoanMaturityTermMonths] = @balloonLoanMaturityTermMonths,
	[BuydownTemporarySubsidyIndicator] = @buydownTemporarySubsidyIndicator,
	[CounselingConfirmationIndicator] = @counselingConfirmationIndicator,
	[EscrowWaiverIndicator] = @escrowWaiverIndicator,
	[FREOfferingIdentifier] = @fREOfferingIdentifier,
	[FNMProductPlanIdentifier] = @fNMProductPlanIdentifier,
	[FNMProductPlanIndentifier] = @fNMProductPlanIndentifier,
	[HELOCMaximumBalanceAmount] = @hELOCMaximumBalanceAmount,
	[HELOCInitialAdvanceAmount] = @hELOCInitialAdvanceAmount,
	[InterestOnlyTerm] = @interestOnlyTerm,
	[LenderSelfInsuredIndicator] = @lenderSelfInsuredIndicator,
	[LoanScheduledClosingDate] = @loanScheduledClosingDate,
	[MICoveragePercent] = @mICoveragePercent,
	[NegativeAmortizationLimitPercent] = @negativeAmortizationLimitPercent,
	[PrepaymentPenaltyIndicator] = @prepaymentPenaltyIndicator,
	[PrepaymentPenaltyTermMonths] = @prepaymentPenaltyTermMonths,
	[PrepaymentRestrictionIndicator] = @prepaymentRestrictionIndicator,
	[ProductDescription] = @productDescription,
	[ProductName] = @productName,
	[ScheduledFirstPaymentDate] = @scheduledFirstPaymentDate,
	[NameDocumentsDrawnInType] = @nameDocumentsDrawnInType,
	[GSEProjectClassificationType] = @gSEProjectClassificationType,
	[GSEPropertyType] = @gSEPropertyType,
	[LienPriorityType] = @lienPriorityType,
	[LoanDocumentationType] = @loanDocumentationType,
	[LoanRepaymentType] = @loanRepaymentType,
	[MICertificationStatusType] = @mICertificationStatusType,
	[MICompanyNameType] = @mICompanyNameType,
	[PaymentFrequencyType] = @paymentFrequencyType,
	[FullPrepaymentPenaltyOptionType] = @fullPrepaymentPenaltyOptionType,
	[LoanClosingStatusType] = @loanClosingStatusType,
	[ServicingTransferStatusType] = @servicingTransferStatusType
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:55 AM
System User: marlon
System Machine: SERVER
Entity Name: MAIL_TO
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateMailTo
(
@streetAddress VarChar(128) = null,
@streetAddress2 VarChar(128) = null,
@city VarChar(64) = null,
@state VarChar(64) = null,
@postalCode VarChar(10) = null,
@country VarChar(64) = null,
@borrowerId BigInt
)
as


-- persist the data via an update
update [MAIL_TO] set 
	[BorrowerId] = @borrowerId,
	[StreetAddress] = @streetAddress,
	[StreetAddress2] = @streetAddress2,
	[City] = @city,
	[State] = @state,
	[PostalCode] = @postalCode,
	[Country] = @country
where
	[BorrowerId] = @borrowerId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:57 AM
System User: marlon
System Machine: SERVER
Entity Name: MORTGAGE_SCORE
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateMortgageScore
(
@loanApplicationId BigInt,
@date DateTime = null,
@typeOtherDescription VarChar(254) = null,
@value VarChar(64),
@type SmallInt = null,
@id BigInt
)
as


-- persist the data via an update
update [MORTGAGE_SCORE] set 
	[LoanApplicationId] = @loanApplicationId,
	[Date] = @date,
	[TypeOtherDescription] = @typeOtherDescription,
	[Value] = @value,
	[Type] = @type
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: PARSED_STREET_ADDRESS
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateParsedStreetAddress
(
@apartmentOrUnit VarChar(64) = null,
@directionPrefix VarChar(64) = null,
@directionSuffix VarChar(64) = null,
@buildingNumber VarChar(64) = null,
@houseNumber VarChar(64) = null,
@military_APO_FPO VarChar(64) = null,
@postOfficeBox VarChar(64) = null,
@ruralRoute VarChar(64) = null,
@streetName VarChar(64) = null,
@streetSuffix VarChar(64) = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [PARSED_STREET_ADDRESS] set 
	[LoanApplicationId] = @loanApplicationId,
	[ApartmentOrUnit] = @apartmentOrUnit,
	[DirectionPrefix] = @directionPrefix,
	[DirectionSuffix] = @directionSuffix,
	[BuildingNumber] = @buildingNumber,
	[HouseNumber] = @houseNumber,
	[Military_APO_FPO] = @military_APO_FPO,
	[PostOfficeBox] = @postOfficeBox,
	[RuralRoute] = @ruralRoute,
	[StreetName] = @streetName,
	[StreetSuffix] = @streetSuffix
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:59 AM
System User: marlon
System Machine: SERVER
Entity Name: PAYMENT_ADJUSTMENT
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdatePaymentAdjustment
(
@loanApplicationId BigInt,
@firstPaymentAdjustmentMonths Decimal(18,0) = null,
@amount Money = null,
@calculationType SmallInt,
@durationMonths Decimal(18,0) = null,
@percent Decimal(8,7) = null,
@periodicCapAmount Money = null,
@periodicCapPercent Decimal(8,7) = null,
@periodNumber VarChar(64) = null,
@subsequentPaymentAdjustmentMonths Decimal(18,0) = null,
@id BigInt
)
as


-- persist the data via an update
update [PAYMENT_ADJUSTMENT] set 
	[LoanApplicationId] = @loanApplicationId,
	[FirstPaymentAdjustmentMonths] = @firstPaymentAdjustmentMonths,
	[Amount] = @amount,
	[CalculationType] = @calculationType,
	[DurationMonths] = @durationMonths,
	[Percent] = @percent,
	[PeriodicCapAmount] = @periodicCapAmount,
	[PeriodicCapPercent] = @periodicCapPercent,
	[PeriodNumber] = @periodNumber,
	[SubsequentPaymentAdjustmentMonths] = @subsequentPaymentAdjustmentMonths
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:00 AM
System User: marlon
System Machine: SERVER
Entity Name: PRESENT_HOUSING_EXPENSE
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdatePresentHousingExpense
(
@borrowerId BigInt,
@paymentAmount Money,
@housingExpenseType SmallInt,
@id BigInt
)
as


-- persist the data via an update
update [PRESENT_HOUSING_EXPENSE] set 
	[BorrowerId] = @borrowerId,
	[PaymentAmount] = @paymentAmount,
	[HousingExpenseType] = @housingExpenseType
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:02 AM
System User: marlon
System Machine: SERVER
Entity Name: PURCHASE_CREDIT
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdatePurchaseCredit
(
@amount Money = null,
@sourceType SmallInt = null,
@loanApplicationId BigInt,
@type SmallInt = null,
@id BigInt
)
as


-- persist the data via an update
update [PURCHASE_CREDIT] set 
	[Amount] = @amount,
	[SourceType] = @sourceType,
	[LoanApplicationId] = @loanApplicationId,
	[Type] = @type
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: RATE_ADJUSTMENT
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateRateAdjustment
(
@loanApplicationId BigInt,
@firstRateAdjustmentMonths Decimal(18,0) = null,
@calculationType SmallInt,
@durationMonths Decimal(18,0) = null,
@percent Decimal(8,7) = null,
@periodNumber Decimal(18,0) = null,
@subsequentCapPercent Decimal(8,7) = null,
@subsequentRateAdjustmentMonths Decimal(18,0) = null,
@id BigInt
)
as


-- persist the data via an update
update [RATE_ADJUSTMENT] set 
	[LoanApplicationId] = @loanApplicationId,
	[FirstRateAdjustmentMonths] = @firstRateAdjustmentMonths,
	[CalculationType] = @calculationType,
	[DurationMonths] = @durationMonths,
	[Percent] = @percent,
	[PeriodNumber] = @periodNumber,
	[SubsequentCapPercent] = @subsequentCapPercent,
	[SubsequentRateAdjustmentMonths] = @subsequentRateAdjustmentMonths
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:05 AM
System User: marlon
System Machine: SERVER
Entity Name: RESIDENCE
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateResidence
(
@borrowerId BigInt = null,
@streetAddress VarChar(128) = null,
@city VarChar(64) = null,
@state VarChar(64) = null,
@postalCode VarChar(64) = null,
@country VarChar(64) = null,
@borrowerResidencyDurationMonths Decimal(18,0) = null,
@borrowerResidencyDurationYears Decimal(18,0) = null,
@borrowerResidencyBasisType SmallInt = null,
@borrowerResidencyType SmallInt = null,
@id BigInt
)
as


-- persist the data via an update
update [RESIDENCE] set 
	[BorrowerId] = @borrowerId,
	[StreetAddress] = @streetAddress,
	[City] = @city,
	[State] = @state,
	[PostalCode] = @postalCode,
	[Country] = @country,
	[BorrowerResidencyDurationMonths] = @borrowerResidencyDurationMonths,
	[BorrowerResidencyDurationYears] = @borrowerResidencyDurationYears,
	[BorrowerResidencyBasisType] = @borrowerResidencyBasisType,
	[BorrowerResidencyType] = @borrowerResidencyType
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:06 AM
System User: marlon
System Machine: SERVER
Entity Name: SUMMARY
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateSummary
(
@borrowerId BigInt = null,
@amount Money = null,
@amountType SmallInt = null,
@id BigInt
)
as


-- persist the data via an update
update [SUMMARY] set 
	[Id] = @id,
	[BorrowerId] = @borrowerId,
	[Amount] = @amount,
	[AmountType] = @amountType
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: TRANSMITTAL_DATA
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateTransmittalData
(
@armsLengthIndicator Bit,
@belowMarketSubordinateFinancingIndicator Bit,
@buydownRatePercent Decimal(8,7) = null,
@creditReportAuthorizationIndicator Bit,
@lenderBranchIdentifier VarChar(64) = null,
@lenderRegistrationIdentifier VarChar(64) = null,
@propertyAppraisedValueAmount Money = null,
@propertyEstimatedValueAmount Money = null,
@investorLoanIdentifier VarChar(64) = null,
@investorInstitutionIdentifier VarChar(64) = null,
@commitmentReferenceIdentifier VarChar(64) = null,
@concurrentOriginationIndicator Bit,
@concurrentOriginationLenderIndicator Bit,
@rateLockPeriodDays SmallInt = null,
@rateLockRequestedExtensionDays SmallInt = null,
@caseStateType SmallInt = null,
@rateLockType SmallInt = null,
@currentFirstMortgageHolderType SmallInt = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [TRANSMITTAL_DATA] set 
	[LoanApplicationId] = @loanApplicationId,
	[ArmsLengthIndicator] = @armsLengthIndicator,
	[BelowMarketSubordinateFinancingIndicator] = @belowMarketSubordinateFinancingIndicator,
	[BuydownRatePercent] = @buydownRatePercent,
	[CreditReportAuthorizationIndicator] = @creditReportAuthorizationIndicator,
	[LenderBranchIdentifier] = @lenderBranchIdentifier,
	[LenderRegistrationIdentifier] = @lenderRegistrationIdentifier,
	[PropertyAppraisedValueAmount] = @propertyAppraisedValueAmount,
	[PropertyEstimatedValueAmount] = @propertyEstimatedValueAmount,
	[InvestorLoanIdentifier] = @investorLoanIdentifier,
	[InvestorInstitutionIdentifier] = @investorInstitutionIdentifier,
	[CommitmentReferenceIdentifier] = @commitmentReferenceIdentifier,
	[ConcurrentOriginationIndicator] = @concurrentOriginationIndicator,
	[ConcurrentOriginationLenderIndicator] = @concurrentOriginationLenderIndicator,
	[RateLockPeriodDays] = @rateLockPeriodDays,
	[RateLockRequestedExtensionDays] = @rateLockRequestedExtensionDays,
	[CaseStateType] = @caseStateType,
	[RateLockType] = @rateLockType,
	[CurrentFirstMortgageHolderType] = @currentFirstMortgageHolderType
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: VA_BORROWER
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateVABorrower
(
@vACoBorrowerNonTaxableIncomeAmount Money = null,
@vACoBorrowerTaxableIncomeAmount Money = null,
@vAFederalTaxAmount Money = null,
@vALocalTaxAmount Money = null,
@vAPrimaryBorrowerNonTaxableIncomeAmount Money = null,
@vAPrimaryBorrowerTaxableIncomeAmount Money = null,
@vASocialSecurityTaxAmount Money = null,
@vAStateTaxAmount Money = null,
@borrowerId BigInt
)
as


-- persist the data via an update
update [VA_BORROWER] set 
	[BorrowerId] = @borrowerId,
	[VACoBorrowerNonTaxableIncomeAmount] = @vACoBorrowerNonTaxableIncomeAmount,
	[VACoBorrowerTaxableIncomeAmount] = @vACoBorrowerTaxableIncomeAmount,
	[VAFederalTaxAmount] = @vAFederalTaxAmount,
	[VALocalTaxAmount] = @vALocalTaxAmount,
	[VAPrimaryBorrowerNonTaxableIncomeAmount] = @vAPrimaryBorrowerNonTaxableIncomeAmount,
	[VAPrimaryBorrowerTaxableIncomeAmount] = @vAPrimaryBorrowerTaxableIncomeAmount,
	[VASocialSecurityTaxAmount] = @vASocialSecurityTaxAmount,
	[VAStateTaxAmount] = @vAStateTaxAmount
where
	[BorrowerId] = @borrowerId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:08 AM
System User: marlon
System Machine: SERVER
Entity Name: VA_LOAN
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateVALoan
(
@vABorrowerCoBorrowerMarriedIndicator Bit,
@borrowerFundingFeePercent Decimal(8,7) = null,
@vAEntitlementAmount Money = null,
@vAMaintenanceExpenseMonthlyAmount Money = null,
@vAResidualIncomeAmount Money = null,
@vAUtilityExpenseMonthlyAmount Money = null,
@loanApplicationId BigInt
)
as


-- persist the data via an update
update [VA_LOAN] set 
	[LoanApplicationId] = @loanApplicationId,
	[VABorrowerCoBorrowerMarriedIndicator] = @vABorrowerCoBorrowerMarriedIndicator,
	[BorrowerFundingFeePercent] = @borrowerFundingFeePercent,
	[VAEntitlementAmount] = @vAEntitlementAmount,
	[VAMaintenanceExpenseMonthlyAmount] = @vAMaintenanceExpenseMonthlyAmount,
	[VAResidualIncomeAmount] = @vAResidualIncomeAmount,
	[VAUtilityExpenseMonthlyAmount] = @vAUtilityExpenseMonthlyAmount
where
	[LoanApplicationId] = @loanApplicationId


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:09 AM
System User: marlon
System Machine: SERVER
Entity Name: VALUATION
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateValuation
(
@loanApplicationId BigInt,
@appraiserId Int = null,
@methodTypeOtherDescription VarChar(254) = null,
@methodType SmallInt = null,
@id BigInt
)
as


-- persist the data via an update
update [VALUATION] set 
	[LoanApplicationId] = @loanApplicationId,
	[AppraiserId] = @appraiserId,
	[MethodTypeOtherDescription] = @methodTypeOtherDescription,
	[MethodType] = @methodType
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: EXPLANATION
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateExplanation
(
@borrowerId BigInt,
@type SmallInt,
@description VarChar(64) = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [EXPLANATION]
	(
	[BorrowerId],
	[Type],
	[Description]
	) values 
	(
	@borrowerId,
	@type,
	@description
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDA_RACE
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateHMDARace
(
@borrowerId BigInt,
@type SmallInt
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [HMDA_RACE]
	(
	[BorrowerId],
	[Type]
	) values 
	(
	@borrowerId,
	@type
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:04 AM
System User: marlon
System Machine: SERVER
Entity Name: REO_PROPERTY
Entity Type: Table
Description: A create stored procedure

*/
CREATE PROCEDURE gsp_CreateREOProperty
(
@loanApplicationId BigInt = null,
@streetAddress VarChar(128) = null,
@streetAddress2 VarChar(128) = null,
@city VarChar(64) = null,
@state VarChar(64) = null,
@postalCode VarChar(64) = null,
@currentResidenceIndicator Bit,
@lienInstallmentAmount Money = null,
@lienUPBAmount Money = null,
@maintenanceExpenseAmount Money = null,
@marketValueAmount Money = null,
@rentalIncomeGrossAmount Money = null,
@rentalIncomeNetAmount Money = null,
@subjectIndicator Bit,
@borrowerID BigInt = null,
@liabilityID BigInt = null,
@gSEPropertyType SmallInt = null,
@dispositionStatusType SmallInt = null
)
as


-- declare variables for use in the proc
declare @newid BigInt
-- assign values to variables in the proc

-- insert the new data into the table
insert into [REO_PROPERTY]
	(
	[LoanApplicationId],
	[StreetAddress],
	[StreetAddress2],
	[City],
	[State],
	[PostalCode],
	[CurrentResidenceIndicator],
	[LienInstallmentAmount],
	[LienUPBAmount],
	[MaintenanceExpenseAmount],
	[MarketValueAmount],
	[RentalIncomeGrossAmount],
	[RentalIncomeNetAmount],
	[SubjectIndicator],
	[BorrowerID],
	[LiabilityID],
	[GSEPropertyType],
	[DispositionStatusType]
	) values 
	(
	@loanApplicationId,
	@streetAddress,
	@streetAddress2,
	@city,
	@state,
	@postalCode,
	@currentResidenceIndicator,
	@lienInstallmentAmount,
	@lienUPBAmount,
	@maintenanceExpenseAmount,
	@marketValueAmount,
	@rentalIncomeGrossAmount,
	@rentalIncomeNetAmount,
	@subjectIndicator,
	@borrowerID,
	@liabilityID,
	@gSEPropertyType,
	@dispositionStatusType
	)

-- retrieve the identity from current scope
set @newid = SCOPE_IDENTITY()

-- return the new identity as a result set
select @newid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: EXPLANATION
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteExplanation
(
@id BigInt
)
as


delete from [EXPLANATION] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDA_RACE
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteHMDARace
(
@id BigInt
)
as


delete from [HMDA_RACE] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:05 AM
System User: marlon
System Machine: SERVER
Entity Name: REO_PROPERTY
Entity Type: Table
Description: A delete stored procedure.

*/
CREATE PROCEDURE gsp_DeleteREOProperty
(
@id BigInt
)
as


delete from [REO_PROPERTY] where 
	[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: EXPLANATION
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectExplanation
(
@id BigInt
)
as


select 
	[EXPLANATION].[Id],
	[EXPLANATION].[BorrowerId],
	[EXPLANATION].[Type],
	[EXPLANATION].[Description]
from 
	[EXPLANATION] 
where 
	[EXPLANATION].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: EXPLANATION
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectExplanations
as


select 
	[EXPLANATION].[Id],
	[EXPLANATION].[BorrowerId],
	[EXPLANATION].[Type],
	[EXPLANATION].[Description]
from 
	[EXPLANATION] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: EXPLANATION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectExplanationsByDeclaration
(
@borrowerId BigInt
)
as


select 
	[EXPLANATION].[Id],
	[EXPLANATION].[BorrowerId],
	[EXPLANATION].[Type],
	[EXPLANATION].[Description]
from 
	[EXPLANATION] 
where 
	[EXPLANATION].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: EXPLANATION
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectExplanationsByExplanationType
(
@type SmallInt
)
as


select 
	[EXPLANATION].[Id],
	[EXPLANATION].[BorrowerId],
	[EXPLANATION].[Type],
	[EXPLANATION].[Description]
from 
	[EXPLANATION] 
where 
	[EXPLANATION].[Type] = @type
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDA_RACE
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectHMDARace
(
@id BigInt
)
as


select 
	[HMDA_RACE].[Id],
	[HMDA_RACE].[BorrowerId],
	[HMDA_RACE].[Type]
from 
	[HMDA_RACE] 
where 
	[HMDA_RACE].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDA_RACE
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectHMDARaces
as


select 
	[HMDA_RACE].[Id],
	[HMDA_RACE].[BorrowerId],
	[HMDA_RACE].[Type]
from 
	[HMDA_RACE] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDA_RACE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectHMDARacesByGovernmentMonitoring
(
@borrowerId BigInt
)
as


select 
	[HMDA_RACE].[Id],
	[HMDA_RACE].[BorrowerId],
	[HMDA_RACE].[Type]
from 
	[HMDA_RACE] 
where 
	[HMDA_RACE].[BorrowerId] = @borrowerId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDA_RACE
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectHMDARacesByHMDARaceType
(
@type SmallInt
)
as


select 
	[HMDA_RACE].[Id],
	[HMDA_RACE].[BorrowerId],
	[HMDA_RACE].[Type]
from 
	[HMDA_RACE] 
where 
	[HMDA_RACE].[Type] = @type
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:05 AM
System User: marlon
System Machine: SERVER
Entity Name: REO_PROPERTY
Entity Type: Table
Description: A select all stored procedure (select all items).

*/
CREATE PROCEDURE gsp_SelectREOProperties
as


select 
	[REO_PROPERTY].[Id],
	[REO_PROPERTY].[LoanApplicationId],
	[REO_PROPERTY].[StreetAddress],
	[REO_PROPERTY].[StreetAddress2],
	[REO_PROPERTY].[City],
	[REO_PROPERTY].[State],
	[REO_PROPERTY].[PostalCode],
	[REO_PROPERTY].[CurrentResidenceIndicator],
	[REO_PROPERTY].[LienInstallmentAmount],
	[REO_PROPERTY].[LienUPBAmount],
	[REO_PROPERTY].[MaintenanceExpenseAmount],
	[REO_PROPERTY].[MarketValueAmount],
	[REO_PROPERTY].[RentalIncomeGrossAmount],
	[REO_PROPERTY].[RentalIncomeNetAmount],
	[REO_PROPERTY].[SubjectIndicator],
	[REO_PROPERTY].[BorrowerID],
	[REO_PROPERTY].[LiabilityID],
	[REO_PROPERTY].[GSEPropertyType],
	[REO_PROPERTY].[DispositionStatusType]
from 
	[REO_PROPERTY] 
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:05 AM
System User: marlon
System Machine: SERVER
Entity Name: REO_PROPERTY
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectREOPropertiesByBorrower
(
@borrowerID BigInt = null
)
as


select 
	[REO_PROPERTY].[Id],
	[REO_PROPERTY].[LoanApplicationId],
	[REO_PROPERTY].[StreetAddress],
	[REO_PROPERTY].[StreetAddress2],
	[REO_PROPERTY].[City],
	[REO_PROPERTY].[State],
	[REO_PROPERTY].[PostalCode],
	[REO_PROPERTY].[CurrentResidenceIndicator],
	[REO_PROPERTY].[LienInstallmentAmount],
	[REO_PROPERTY].[LienUPBAmount],
	[REO_PROPERTY].[MaintenanceExpenseAmount],
	[REO_PROPERTY].[MarketValueAmount],
	[REO_PROPERTY].[RentalIncomeGrossAmount],
	[REO_PROPERTY].[RentalIncomeNetAmount],
	[REO_PROPERTY].[SubjectIndicator],
	[REO_PROPERTY].[BorrowerID],
	[REO_PROPERTY].[LiabilityID],
	[REO_PROPERTY].[GSEPropertyType],
	[REO_PROPERTY].[DispositionStatusType]
from 
	[REO_PROPERTY] 
where 
	[REO_PROPERTY].[BorrowerID] = @borrowerID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:05 AM
System User: marlon
System Machine: SERVER
Entity Name: REO_PROPERTY
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectREOPropertiesByDispositionStatusType
(
@dispositionStatusType SmallInt = null
)
as


select 
	[REO_PROPERTY].[Id],
	[REO_PROPERTY].[LoanApplicationId],
	[REO_PROPERTY].[StreetAddress],
	[REO_PROPERTY].[StreetAddress2],
	[REO_PROPERTY].[City],
	[REO_PROPERTY].[State],
	[REO_PROPERTY].[PostalCode],
	[REO_PROPERTY].[CurrentResidenceIndicator],
	[REO_PROPERTY].[LienInstallmentAmount],
	[REO_PROPERTY].[LienUPBAmount],
	[REO_PROPERTY].[MaintenanceExpenseAmount],
	[REO_PROPERTY].[MarketValueAmount],
	[REO_PROPERTY].[RentalIncomeGrossAmount],
	[REO_PROPERTY].[RentalIncomeNetAmount],
	[REO_PROPERTY].[SubjectIndicator],
	[REO_PROPERTY].[BorrowerID],
	[REO_PROPERTY].[LiabilityID],
	[REO_PROPERTY].[GSEPropertyType],
	[REO_PROPERTY].[DispositionStatusType]
from 
	[REO_PROPERTY] 
where 
	[REO_PROPERTY].[DispositionStatusType] = @dispositionStatusType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:05 AM
System User: marlon
System Machine: SERVER
Entity Name: REO_PROPERTY
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectREOPropertiesByGSEPropertyType
(
@gSEPropertyType SmallInt = null
)
as


select 
	[REO_PROPERTY].[Id],
	[REO_PROPERTY].[LoanApplicationId],
	[REO_PROPERTY].[StreetAddress],
	[REO_PROPERTY].[StreetAddress2],
	[REO_PROPERTY].[City],
	[REO_PROPERTY].[State],
	[REO_PROPERTY].[PostalCode],
	[REO_PROPERTY].[CurrentResidenceIndicator],
	[REO_PROPERTY].[LienInstallmentAmount],
	[REO_PROPERTY].[LienUPBAmount],
	[REO_PROPERTY].[MaintenanceExpenseAmount],
	[REO_PROPERTY].[MarketValueAmount],
	[REO_PROPERTY].[RentalIncomeGrossAmount],
	[REO_PROPERTY].[RentalIncomeNetAmount],
	[REO_PROPERTY].[SubjectIndicator],
	[REO_PROPERTY].[BorrowerID],
	[REO_PROPERTY].[LiabilityID],
	[REO_PROPERTY].[GSEPropertyType],
	[REO_PROPERTY].[DispositionStatusType]
from 
	[REO_PROPERTY] 
where 
	[REO_PROPERTY].[GSEPropertyType] = @gSEPropertyType
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:05 AM
System User: marlon
System Machine: SERVER
Entity Name: REO_PROPERTY
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectREOPropertiesByLiability
(
@liabilityID BigInt = null
)
as


select 
	[REO_PROPERTY].[Id],
	[REO_PROPERTY].[LoanApplicationId],
	[REO_PROPERTY].[StreetAddress],
	[REO_PROPERTY].[StreetAddress2],
	[REO_PROPERTY].[City],
	[REO_PROPERTY].[State],
	[REO_PROPERTY].[PostalCode],
	[REO_PROPERTY].[CurrentResidenceIndicator],
	[REO_PROPERTY].[LienInstallmentAmount],
	[REO_PROPERTY].[LienUPBAmount],
	[REO_PROPERTY].[MaintenanceExpenseAmount],
	[REO_PROPERTY].[MarketValueAmount],
	[REO_PROPERTY].[RentalIncomeGrossAmount],
	[REO_PROPERTY].[RentalIncomeNetAmount],
	[REO_PROPERTY].[SubjectIndicator],
	[REO_PROPERTY].[BorrowerID],
	[REO_PROPERTY].[LiabilityID],
	[REO_PROPERTY].[GSEPropertyType],
	[REO_PROPERTY].[DispositionStatusType]
from 
	[REO_PROPERTY] 
where 
	[REO_PROPERTY].[LiabilityID] = @liabilityID
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:05 AM
System User: marlon
System Machine: SERVER
Entity Name: REO_PROPERTY
Entity Type: Table
Description: A select stored procedure by relational criteria.

*/
CREATE PROCEDURE gsp_SelectREOPropertiesByLoanApplication
(
@loanApplicationId BigInt = null
)
as


select 
	[REO_PROPERTY].[Id],
	[REO_PROPERTY].[LoanApplicationId],
	[REO_PROPERTY].[StreetAddress],
	[REO_PROPERTY].[StreetAddress2],
	[REO_PROPERTY].[City],
	[REO_PROPERTY].[State],
	[REO_PROPERTY].[PostalCode],
	[REO_PROPERTY].[CurrentResidenceIndicator],
	[REO_PROPERTY].[LienInstallmentAmount],
	[REO_PROPERTY].[LienUPBAmount],
	[REO_PROPERTY].[MaintenanceExpenseAmount],
	[REO_PROPERTY].[MarketValueAmount],
	[REO_PROPERTY].[RentalIncomeGrossAmount],
	[REO_PROPERTY].[RentalIncomeNetAmount],
	[REO_PROPERTY].[SubjectIndicator],
	[REO_PROPERTY].[BorrowerID],
	[REO_PROPERTY].[LiabilityID],
	[REO_PROPERTY].[GSEPropertyType],
	[REO_PROPERTY].[DispositionStatusType]
from 
	[REO_PROPERTY] 
where 
	[REO_PROPERTY].[LoanApplicationId] = @loanApplicationId
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:05 AM
System User: marlon
System Machine: SERVER
Entity Name: REO_PROPERTY
Entity Type: Table
Description: A single item select stored procedure.

*/
CREATE PROCEDURE gsp_SelectREOProperty
(
@id BigInt
)
as


select 
	[REO_PROPERTY].[Id],
	[REO_PROPERTY].[LoanApplicationId],
	[REO_PROPERTY].[StreetAddress],
	[REO_PROPERTY].[StreetAddress2],
	[REO_PROPERTY].[City],
	[REO_PROPERTY].[State],
	[REO_PROPERTY].[PostalCode],
	[REO_PROPERTY].[CurrentResidenceIndicator],
	[REO_PROPERTY].[LienInstallmentAmount],
	[REO_PROPERTY].[LienUPBAmount],
	[REO_PROPERTY].[MaintenanceExpenseAmount],
	[REO_PROPERTY].[MarketValueAmount],
	[REO_PROPERTY].[RentalIncomeGrossAmount],
	[REO_PROPERTY].[RentalIncomeNetAmount],
	[REO_PROPERTY].[SubjectIndicator],
	[REO_PROPERTY].[BorrowerID],
	[REO_PROPERTY].[LiabilityID],
	[REO_PROPERTY].[GSEPropertyType],
	[REO_PROPERTY].[DispositionStatusType]
from 
	[REO_PROPERTY] 
where 
	[REO_PROPERTY].[Id] = @id
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:42 AM
System User: marlon
System Machine: SERVER
Entity Name: EXPLANATION
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateExplanation
(
@borrowerId BigInt,
@type SmallInt,
@description VarChar(64) = null,
@id BigInt
)
as


-- persist the data via an update
update [EXPLANATION] set 
	[BorrowerId] = @borrowerId,
	[Type] = @type,
	[Description] = @description
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:34:47 AM
System User: marlon
System Machine: SERVER
Entity Name: HMDA_RACE
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateHMDARace
(
@borrowerId BigInt,
@type SmallInt,
@id BigInt
)
as


-- persist the data via an update
update [HMDA_RACE] set 
	[BorrowerId] = @borrowerId,
	[Type] = @type
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/*

Auto-Generated: true
Date Generated: 9/28/2004 12:35:05 AM
System User: marlon
System Machine: SERVER
Entity Name: REO_PROPERTY
Entity Type: Table
Description: A single item update stored procedure.

*/
CREATE PROCEDURE gsp_UpdateREOProperty
(
@loanApplicationId BigInt = null,
@streetAddress VarChar(128) = null,
@streetAddress2 VarChar(128) = null,
@city VarChar(64) = null,
@state VarChar(64) = null,
@postalCode VarChar(64) = null,
@currentResidenceIndicator Bit,
@lienInstallmentAmount Money = null,
@lienUPBAmount Money = null,
@maintenanceExpenseAmount Money = null,
@marketValueAmount Money = null,
@rentalIncomeGrossAmount Money = null,
@rentalIncomeNetAmount Money = null,
@subjectIndicator Bit,
@borrowerID BigInt = null,
@liabilityID BigInt = null,
@gSEPropertyType SmallInt = null,
@dispositionStatusType SmallInt = null,
@id BigInt
)
as


-- persist the data via an update
update [REO_PROPERTY] set 
	[LoanApplicationId] = @loanApplicationId,
	[StreetAddress] = @streetAddress,
	[StreetAddress2] = @streetAddress2,
	[City] = @city,
	[State] = @state,
	[PostalCode] = @postalCode,
	[CurrentResidenceIndicator] = @currentResidenceIndicator,
	[LienInstallmentAmount] = @lienInstallmentAmount,
	[LienUPBAmount] = @lienUPBAmount,
	[MaintenanceExpenseAmount] = @maintenanceExpenseAmount,
	[MarketValueAmount] = @marketValueAmount,
	[RentalIncomeGrossAmount] = @rentalIncomeGrossAmount,
	[RentalIncomeNetAmount] = @rentalIncomeNetAmount,
	[SubjectIndicator] = @subjectIndicator,
	[BorrowerID] = @borrowerID,
	[LiabilityID] = @liabilityID,
	[GSEPropertyType] = @gSEPropertyType,
	[DispositionStatusType] = @dispositionStatusType
where
	[Id] = @id


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

