namespace CensusDataParser.Generated.Binding
{
	#region Using Directives
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity;
	using System.Data.Entity.ModelConfiguration;
	using System.Data.OleDb;
	using Enumerators;
	using Generated.Binding;
	using Generated.Mapping;
	using Models;
	#endregion Using Directives

	public class SummaryTwo_SF2_Segment_05 : BaseModel
	{
		#region Properties
		[Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
		public string FILEID { get; set; }

		[Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
		public string STUSAB { get; set; }

		[Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
		public string CHARITER { get; set; }

		[Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
		public string CIFSN { get; set; }

		[Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
		public int LOGRECNO { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 5)]
		public int? PCT0190001 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 6)]
		public int? PCT0190002 { get; set; }

		[Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 7)]
		public int? PCT0190003 { get; set; }

		[Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 8)]
		public int? PCT0190004 { get; set; }

		[Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 9)]
		public int? PCT0190005 { get; set; }

		[Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 10)]
		public int? PCT0190006 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 11)]
		public int? PCT0190007 { get; set; }

		[Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 12)]
		public int? PCT0190008 { get; set; }

		[Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 13)]
		public int? PCT0190009 { get; set; }

		[Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 14)]
		public int? PCT0190010 { get; set; }

		[Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 15)]
		public int? PCT0190011 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 16)]
		public int? PCT0190012 { get; set; }

		[Display(Name = "Unmarried-partner households:", ShortName = "Unmarried-partner households:", Order = 17)]
		public int? PCT0190013 { get; set; }

		[Display(Name = "Male householder and male partner:", ShortName = "Male householder and male partner:", Order = 18)]
		public int? PCT0190014 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 19)]
		public int? PCT0190015 { get; set; }

		[Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 20)]
		public int? PCT0190016 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 21)]
		public int? PCT0190017 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 22)]
		public int? PCT0190018 { get; set; }

		[Display(Name = "Male householder and female partner:", ShortName = "Male householder and female partner:", Order = 23)]
		public int? PCT0190019 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 24)]
		public int? PCT0190020 { get; set; }

		[Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 25)]
		public int? PCT0190021 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 26)]
		public int? PCT0190022 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 27)]
		public int? PCT0190023 { get; set; }

		[Display(Name = "Female householder and female partner:", ShortName = "Female householder and female partner:", Order = 28)]
		public int? PCT0190024 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 29)]
		public int? PCT0190025 { get; set; }

		[Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 30)]
		public int? PCT0190026 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 31)]
		public int? PCT0190027 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 32)]
		public int? PCT0190028 { get; set; }

		[Display(Name = "Female householder and male partner:", ShortName = "Female householder and male partner:", Order = 33)]
		public int? PCT0190029 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 34)]
		public int? PCT0190030 { get; set; }

		[Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 35)]
		public int? PCT0190031 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 36)]
		public int? PCT0190032 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 37)]
		public int? PCT0190033 { get; set; }

		[Display(Name = "All other households", ShortName = "All other households", Order = 38)]
		public int? PCT0190034 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 39)]
		public int? PCT0200001 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 40)]
		public int? PCT0200002 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 41)]
		public int? PCT0200003 { get; set; }

		[Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 42)]
		public int? PCT0200004 { get; set; }

		[Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 43)]
		public int? PCT0200005 { get; set; }

		[Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 44)]
		public int? PCT0200006 { get; set; }

		[Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 45)]
		public int? PCT0200007 { get; set; }

		[Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 46)]
		public int? PCT0200008 { get; set; }

		[Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 47)]
		public int? PCT0200009 { get; set; }

		[Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 48)]
		public int? PCT0200010 { get; set; }

		[Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 49)]
		public int? PCT0200011 { get; set; }

		[Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 50)]
		public int? PCT0200012 { get; set; }

		[Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 51)]
		public int? PCT0200013 { get; set; }

		[Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 52)]
		public int? PCT0200014 { get; set; }

		[Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 53)]
		public int? PCT0200015 { get; set; }

		[Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 54)]
		public int? PCT0200016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 55)]
		public int? PCT0210001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 56)]
		public int? PCT0210002 { get; set; }

		[Display(Name = "Under 18 years:", ShortName = "Under 18 years:", Order = 57)]
		public int? PCT0210003 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301,  401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301,  401-405):", Order = 58)]
		public int? PCT0210004 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 59)]
		public int? PCT0210005 { get; set; }

		[Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 60)]
		public int? PCT0210006 { get; set; }

		[Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 61)]
		public int? PCT0210007 { get; set; }

		[Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 62)]
		public int? PCT0210008 { get; set; }

		[Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 63)]
		public int? PCT0210009 { get; set; }

		[Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 64)]
		public int? PCT0210010 { get; set; }

		[Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 65)]
		public int? PCT0210011 { get; set; }

		[Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 66)]
		public int? PCT0210012 { get; set; }

		[Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 67)]
		public int? PCT0210013 { get; set; }

		[Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 68)]
		public int? PCT0210014 { get; set; }

		[Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 69)]
		public int? PCT0210015 { get; set; }

		[Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 70)]
		public int? PCT0210016 { get; set; }

		[Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 71)]
		public int? PCT0210017 { get; set; }

		[Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 72)]
		public int? PCT0210018 { get; set; }

		[Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 73)]
		public int? PCT0210019 { get; set; }

		[Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 74)]
		public int? PCT0210020 { get; set; }

		[Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 75)]
		public int? PCT0210021 { get; set; }

		[Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 76)]
		public int? PCT0210022 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 77)]
		public int? PCT0210023 { get; set; }

		[Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 78)]
		public int? PCT0210024 { get; set; }

		[Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 79)]
		public int? PCT0210025 { get; set; }

		[Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 80)]
		public int? PCT0210026 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 81)]
		public int? PCT0220001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 82)]
		public int? PCT0220002 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 83)]
		public int? PCT0220003 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 84)]
		public int? PCT0220004 { get; set; }

		[Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 85)]
		public int? PCT0220005 { get; set; }

		[Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 86)]
		public int? PCT0220006 { get; set; }

		[Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 87)]
		public int? PCT0220007 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 88)]
		public int? PCT0220008 { get; set; }

		[Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 89)]
		public int? PCT0220009 { get; set; }

		[Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 90)]
		public int? PCT0220010 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 91)]
		public int? PCT0220011 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 92)]
		public int? PCT0220012 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 93)]
		public int? PCT0220013 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 94)]
		public int? PCT0220014 { get; set; }

		[Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 95)]
		public int? PCT0220015 { get; set; }

		[Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 96)]
		public int? PCT0220016 { get; set; }

		[Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 97)]
		public int? PCT0220017 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 98)]
		public int? PCT0220018 { get; set; }

		[Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 99)]
		public int? PCT0220019 { get; set; }

		[Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 100)]
		public int? PCT0220020 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 101)]
		public int? PCT0220021 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 102)]
		public int? PCT0220022 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 103)]
		public int? PCT0220023 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 104)]
		public int? PCT0220024 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 105)]
		public int? PCT0220025 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 106)]
		public int? PCT0220026 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 107)]
		public int? PCT0220027 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 108)]
		public int? PCT0220028 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 109)]
		public int? PCT0230001 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 110)]
		public int? PCT0230002 { get; set; }

		[Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 111)]
		public int? PCT0230003 { get; set; }

		[Display(Name = "In other family:", ShortName = "In other family:", Order = 112)]
		public int? PCT0230004 { get; set; }

		[Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 113)]
		public int? PCT0230005 { get; set; }

		[Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 114)]
		public int? PCT0230006 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 115)]
		public int? PCT0230007 { get; set; }

		[Display(Name = "In households with a male householder:", ShortName = "In households with a male householder:", Order = 116)]
		public int? PCT0230008 { get; set; }

		[Display(Name = "In 1-person household", ShortName = "In 1-person household", Order = 117)]
		public int? PCT0230009 { get; set; }

		[Display(Name = "In 2-or-more-person household", ShortName = "In 2-or-more-person household", Order = 118)]
		public int? PCT0230010 { get; set; }

		[Display(Name = "In households with a female householder:", ShortName = "In households with a female householder:", Order = 119)]
		public int? PCT0230011 { get; set; }

		[Display(Name = "In 1-person household", ShortName = "In 1-person household", Order = 120)]
		public int? PCT0230012 { get; set; }

		[Display(Name = "In 2-or-more-person household", ShortName = "In 2-or-more-person household", Order = 121)]
		public int? PCT0230013 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 122)]
		public int? PCT0240001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 123)]
		public int? PCT0240002 { get; set; }

		[Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 124)]
		public int? PCT0240003 { get; set; }

		[Display(Name = "Related child:", ShortName = "Related child:", Order = 125)]
		public int? PCT0240004 { get; set; }

		[Display(Name = "Own child:", ShortName = "Own child:", Order = 126)]
		public int? PCT0240005 { get; set; }

		[Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 127)]
		public int? PCT0240006 { get; set; }

		[Display(Name = "In other family:", ShortName = "In other family:", Order = 128)]
		public int? PCT0240007 { get; set; }

		[Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 129)]
		public int? PCT0240008 { get; set; }

		[Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 130)]
		public int? PCT0240009 { get; set; }

		[Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 131)]
		public int? PCT0240010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 132)]
		public int? PCT0240011 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 133)]
		public int? PCT0240012 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 134)]
		public int? PCT0240013 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 135)]
		public int? PCT0240014 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 136)]
		public int? PCT0240015 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 137)]
		public int? PCT0240016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 138)]
		public int? PCT0250001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 139)]
		public int? PCT0250002 { get; set; }

		[Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 140)]
		public int? PCT0250003 { get; set; }

		[Display(Name = "Related child:", ShortName = "Related child:", Order = 141)]
		public int? PCT0250004 { get; set; }

		[Display(Name = "Own child:", ShortName = "Own child:", Order = 142)]
		public int? PCT0250005 { get; set; }

		[Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 143)]
		public int? PCT0250006 { get; set; }

		[Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 144)]
		public int? PCT0250007 { get; set; }

		[Display(Name = "5 years", ShortName = "5 years", Order = 145)]
		public int? PCT0250008 { get; set; }

		[Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 146)]
		public int? PCT0250009 { get; set; }

		[Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 147)]
		public int? PCT0250010 { get; set; }

		[Display(Name = "14 years", ShortName = "14 years", Order = 148)]
		public int? PCT0250011 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 149)]
		public int? PCT0250012 { get; set; }

		[Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 150)]
		public int? PCT0250013 { get; set; }

		[Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 151)]
		public int? PCT0250014 { get; set; }

		[Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 152)]
		public int? PCT0250015 { get; set; }

		[Display(Name = "5 years", ShortName = "5 years", Order = 153)]
		public int? PCT0250016 { get; set; }

		[Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 154)]
		public int? PCT0250017 { get; set; }

		[Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 155)]
		public int? PCT0250018 { get; set; }

		[Display(Name = "14 years", ShortName = "14 years", Order = 156)]
		public int? PCT0250019 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 157)]
		public int? PCT0250020 { get; set; }

		[Display(Name = "Nonrelatives:", ShortName = "Nonrelatives:", Order = 158)]
		public int? PCT0250021 { get; set; }

		[Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 159)]
		public int? PCT0250022 { get; set; }

		[Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 160)]
		public int? PCT0250023 { get; set; }

		[Display(Name = "5 years", ShortName = "5 years", Order = 161)]
		public int? PCT0250024 { get; set; }

		[Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 162)]
		public int? PCT0250025 { get; set; }

		[Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 163)]
		public int? PCT0250026 { get; set; }

		[Display(Name = "14 years", ShortName = "14 years", Order = 164)]
		public int? PCT0250027 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 165)]
		public int? PCT0250028 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 166)]
		public int? PCT0250029 { get; set; }

		[Display(Name = "Institutionalized population:", ShortName = "Institutionalized population:", Order = 167)]
		public int? PCT0250030 { get; set; }

		[Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 168)]
		public int? PCT0250031 { get; set; }

		[Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 169)]
		public int? PCT0250032 { get; set; }

		[Display(Name = "5 years", ShortName = "5 years", Order = 170)]
		public int? PCT0250033 { get; set; }

		[Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 171)]
		public int? PCT0250034 { get; set; }

		[Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 172)]
		public int? PCT0250035 { get; set; }

		[Display(Name = "14 years", ShortName = "14 years", Order = 173)]
		public int? PCT0250036 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 174)]
		public int? PCT0250037 { get; set; }

		[Display(Name = "Noninstitutionalized population:", ShortName = "Noninstitutionalized population:", Order = 175)]
		public int? PCT0250038 { get; set; }

		[Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 176)]
		public int? PCT0250039 { get; set; }

		[Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 177)]
		public int? PCT0250040 { get; set; }

		[Display(Name = "5 years", ShortName = "5 years", Order = 178)]
		public int? PCT0250041 { get; set; }

		[Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 179)]
		public int? PCT0250042 { get; set; }

		[Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 180)]
		public int? PCT0250043 { get; set; }

		[Display(Name = "14 years", ShortName = "14 years", Order = 181)]
		public int? PCT0250044 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 182)]
		public int? PCT0250045 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 183)]
		public int? PCT0260001 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 184)]
		public int? PCT0260002 { get; set; }

		[Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 185)]
		public int? PCT0260003 { get; set; }

		[Display(Name = "In other family:", ShortName = "In other family:", Order = 186)]
		public int? PCT0260004 { get; set; }

		[Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 187)]
		public int? PCT0260005 { get; set; }

		[Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 188)]
		public int? PCT0260006 { get; set; }

		[Display(Name = "In nonfamily households", ShortName = "In nonfamily households", Order = 189)]
		public int? PCT0260007 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 190)]
		public int? PCT0270001 { get; set; }

		[Display(Name = "Unmarried partner of householder present:", ShortName = "Unmarried partner of householder present:", Order = 191)]
		public int? PCT0270002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 192)]
		public int? PCT0270003 { get; set; }

		[Display(Name = "In male householder and male partner households", ShortName = "In male householder and male partner households", Order = 193)]
		public int? PCT0270004 { get; set; }

		[Display(Name = "In male householder and female partner households", ShortName = "In male householder and female partner households", Order = 194)]
		public int? PCT0270005 { get; set; }

		[Display(Name = "In female householder and female partner households", ShortName = "In female householder and female partner households", Order = 195)]
		public int? PCT0270006 { get; set; }

		[Display(Name = "In female householder and male partner households", ShortName = "In female householder and male partner households", Order = 196)]
		public int? PCT0270007 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 197)]
		public int? PCT0270008 { get; set; }

		[Display(Name = "In male householder and male partner households", ShortName = "In male householder and male partner households", Order = 198)]
		public int? PCT0270009 { get; set; }

		[Display(Name = "In male householder and female partner households", ShortName = "In male householder and female partner households", Order = 199)]
		public int? PCT0270010 { get; set; }

		[Display(Name = "In female householder and female partner households", ShortName = "In female householder and female partner households", Order = 200)]
		public int? PCT0270011 { get; set; }

		[Display(Name = "In female householder and male partner households", ShortName = "In female householder and male partner households", Order = 201)]
		public int? PCT0270012 { get; set; }

		[Display(Name = "No unmarried partner of householder present:", ShortName = "No unmarried partner of householder present:", Order = 202)]
		public int? PCT0270013 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 203)]
		public int? PCT0270014 { get; set; }

		[Display(Name = "In husband-wife family households", ShortName = "In husband-wife family households", Order = 204)]
		public int? PCT0270015 { get; set; }

		[Display(Name = "In male householder, no wife present, family households", ShortName = "In male householder, no wife present, family households", Order = 205)]
		public int? PCT0270016 { get; set; }

		[Display(Name = "In female householder, no husband present, family households", ShortName = "In female householder, no husband present, family households", Order = 206)]
		public int? PCT0270017 { get; set; }

		[Display(Name = "In nonfamily households", ShortName = "In nonfamily households", Order = 207)]
		public int? PCT0270018 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 208)]
		public int? PCT0280001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 209)]
		public int? PCT0280002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 210)]
		public int? PCT0280003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 211)]
		public int? PCT0280004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 212)]
		public int? PCT0280005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 213)]
		public int? PCT0280006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 214)]
		public int? PCT0280007 { get; set; }

		[Display(Name = "Child", ShortName = "Child", Order = 215)]
		public int? PCT0280008 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 216)]
		public int? PCT0280009 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 217)]
		public int? PCT0280010 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 218)]
		public int? PCT0280011 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 219)]
		public int? PCT0280012 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 220)]
		public int? PCT0280013 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 221)]
		public int? PCT0280014 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 222)]
		public int? PCT0280015 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 223)]
		public int? PCT0280016 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 224)]
		public int? PCT0280017 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 225)]
		public int? PCT0280018 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 226)]
		public int? PCT0280019 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 227)]
		public int? PCT0280020 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 228)]
		public int? PCT0280021 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 229)]
		public int? PCT0280022 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 230)]
		public int? PCT0280023 { get; set; }

		[Display(Name = "Total", ShortName = "Total", Order = 231)]
		public int? PCT0290001 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 232)]
		public int? PCT0300001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 233)]
		public int? PCT0300002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 234)]
		public int? PCT0300003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 235)]
		public decimal? PCT0310001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 236)]
		public decimal? PCT0310002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 237)]
		public decimal? PCT0310003 { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryTwo_SF2_Segment_05() { }

		public SummaryTwo_SF2_Segment_05(string csvLine) : base(csvLine) { }

		public SummaryTwo_SF2_Segment_05(string[] values) : base(values) { }

		public SummaryTwo_SF2_Segment_05(OleDbDataReader reader)
		{
			if(reader[0] != DBNull.Value)
			{
				FILEID = (string)reader[0];
			}
			if(reader[1] != DBNull.Value)
			{
				STUSAB = (string)reader[1];
			}
			if(reader[2] != DBNull.Value)
			{
				CHARITER = (string)reader[2];
			}
			if(reader[3] != DBNull.Value)
			{
				CIFSN = (string)reader[3];
			}
			if(reader[4] != DBNull.Value)
			{
				LOGRECNO = (int)reader[4];
			}
			if(reader[5] != DBNull.Value)
			{
				PCT0190001 = (int?)reader[5];
			}
			if(reader[6] != DBNull.Value)
			{
				PCT0190002 = (int?)reader[6];
			}
			if(reader[7] != DBNull.Value)
			{
				PCT0190003 = (int?)reader[7];
			}
			if(reader[8] != DBNull.Value)
			{
				PCT0190004 = (int?)reader[8];
			}
			if(reader[9] != DBNull.Value)
			{
				PCT0190005 = (int?)reader[9];
			}
			if(reader[10] != DBNull.Value)
			{
				PCT0190006 = (int?)reader[10];
			}
			if(reader[11] != DBNull.Value)
			{
				PCT0190007 = (int?)reader[11];
			}
			if(reader[12] != DBNull.Value)
			{
				PCT0190008 = (int?)reader[12];
			}
			if(reader[13] != DBNull.Value)
			{
				PCT0190009 = (int?)reader[13];
			}
			if(reader[14] != DBNull.Value)
			{
				PCT0190010 = (int?)reader[14];
			}
			if(reader[15] != DBNull.Value)
			{
				PCT0190011 = (int?)reader[15];
			}
			if(reader[16] != DBNull.Value)
			{
				PCT0190012 = (int?)reader[16];
			}
			if(reader[17] != DBNull.Value)
			{
				PCT0190013 = (int?)reader[17];
			}
			if(reader[18] != DBNull.Value)
			{
				PCT0190014 = (int?)reader[18];
			}
			if(reader[19] != DBNull.Value)
			{
				PCT0190015 = (int?)reader[19];
			}
			if(reader[20] != DBNull.Value)
			{
				PCT0190016 = (int?)reader[20];
			}
			if(reader[21] != DBNull.Value)
			{
				PCT0190017 = (int?)reader[21];
			}
			if(reader[22] != DBNull.Value)
			{
				PCT0190018 = (int?)reader[22];
			}
			if(reader[23] != DBNull.Value)
			{
				PCT0190019 = (int?)reader[23];
			}
			if(reader[24] != DBNull.Value)
			{
				PCT0190020 = (int?)reader[24];
			}
			if(reader[25] != DBNull.Value)
			{
				PCT0190021 = (int?)reader[25];
			}
			if(reader[26] != DBNull.Value)
			{
				PCT0190022 = (int?)reader[26];
			}
			if(reader[27] != DBNull.Value)
			{
				PCT0190023 = (int?)reader[27];
			}
			if(reader[28] != DBNull.Value)
			{
				PCT0190024 = (int?)reader[28];
			}
			if(reader[29] != DBNull.Value)
			{
				PCT0190025 = (int?)reader[29];
			}
			if(reader[30] != DBNull.Value)
			{
				PCT0190026 = (int?)reader[30];
			}
			if(reader[31] != DBNull.Value)
			{
				PCT0190027 = (int?)reader[31];
			}
			if(reader[32] != DBNull.Value)
			{
				PCT0190028 = (int?)reader[32];
			}
			if(reader[33] != DBNull.Value)
			{
				PCT0190029 = (int?)reader[33];
			}
			if(reader[34] != DBNull.Value)
			{
				PCT0190030 = (int?)reader[34];
			}
			if(reader[35] != DBNull.Value)
			{
				PCT0190031 = (int?)reader[35];
			}
			if(reader[36] != DBNull.Value)
			{
				PCT0190032 = (int?)reader[36];
			}
			if(reader[37] != DBNull.Value)
			{
				PCT0190033 = (int?)reader[37];
			}
			if(reader[38] != DBNull.Value)
			{
				PCT0190034 = (int?)reader[38];
			}
			if(reader[39] != DBNull.Value)
			{
				PCT0200001 = (int?)reader[39];
			}
			if(reader[40] != DBNull.Value)
			{
				PCT0200002 = (int?)reader[40];
			}
			if(reader[41] != DBNull.Value)
			{
				PCT0200003 = (int?)reader[41];
			}
			if(reader[42] != DBNull.Value)
			{
				PCT0200004 = (int?)reader[42];
			}
			if(reader[43] != DBNull.Value)
			{
				PCT0200005 = (int?)reader[43];
			}
			if(reader[44] != DBNull.Value)
			{
				PCT0200006 = (int?)reader[44];
			}
			if(reader[45] != DBNull.Value)
			{
				PCT0200007 = (int?)reader[45];
			}
			if(reader[46] != DBNull.Value)
			{
				PCT0200008 = (int?)reader[46];
			}
			if(reader[47] != DBNull.Value)
			{
				PCT0200009 = (int?)reader[47];
			}
			if(reader[48] != DBNull.Value)
			{
				PCT0200010 = (int?)reader[48];
			}
			if(reader[49] != DBNull.Value)
			{
				PCT0200011 = (int?)reader[49];
			}
			if(reader[50] != DBNull.Value)
			{
				PCT0200012 = (int?)reader[50];
			}
			if(reader[51] != DBNull.Value)
			{
				PCT0200013 = (int?)reader[51];
			}
			if(reader[52] != DBNull.Value)
			{
				PCT0200014 = (int?)reader[52];
			}
			if(reader[53] != DBNull.Value)
			{
				PCT0200015 = (int?)reader[53];
			}
			if(reader[54] != DBNull.Value)
			{
				PCT0200016 = (int?)reader[54];
			}
			if(reader[55] != DBNull.Value)
			{
				PCT0210001 = (int?)reader[55];
			}
			if(reader[56] != DBNull.Value)
			{
				PCT0210002 = (int?)reader[56];
			}
			if(reader[57] != DBNull.Value)
			{
				PCT0210003 = (int?)reader[57];
			}
			if(reader[58] != DBNull.Value)
			{
				PCT0210004 = (int?)reader[58];
			}
			if(reader[59] != DBNull.Value)
			{
				PCT0210005 = (int?)reader[59];
			}
			if(reader[60] != DBNull.Value)
			{
				PCT0210006 = (int?)reader[60];
			}
			if(reader[61] != DBNull.Value)
			{
				PCT0210007 = (int?)reader[61];
			}
			if(reader[62] != DBNull.Value)
			{
				PCT0210008 = (int?)reader[62];
			}
			if(reader[63] != DBNull.Value)
			{
				PCT0210009 = (int?)reader[63];
			}
			if(reader[64] != DBNull.Value)
			{
				PCT0210010 = (int?)reader[64];
			}
			if(reader[65] != DBNull.Value)
			{
				PCT0210011 = (int?)reader[65];
			}
			if(reader[66] != DBNull.Value)
			{
				PCT0210012 = (int?)reader[66];
			}
			if(reader[67] != DBNull.Value)
			{
				PCT0210013 = (int?)reader[67];
			}
			if(reader[68] != DBNull.Value)
			{
				PCT0210014 = (int?)reader[68];
			}
			if(reader[69] != DBNull.Value)
			{
				PCT0210015 = (int?)reader[69];
			}
			if(reader[70] != DBNull.Value)
			{
				PCT0210016 = (int?)reader[70];
			}
			if(reader[71] != DBNull.Value)
			{
				PCT0210017 = (int?)reader[71];
			}
			if(reader[72] != DBNull.Value)
			{
				PCT0210018 = (int?)reader[72];
			}
			if(reader[73] != DBNull.Value)
			{
				PCT0210019 = (int?)reader[73];
			}
			if(reader[74] != DBNull.Value)
			{
				PCT0210020 = (int?)reader[74];
			}
			if(reader[75] != DBNull.Value)
			{
				PCT0210021 = (int?)reader[75];
			}
			if(reader[76] != DBNull.Value)
			{
				PCT0210022 = (int?)reader[76];
			}
			if(reader[77] != DBNull.Value)
			{
				PCT0210023 = (int?)reader[77];
			}
			if(reader[78] != DBNull.Value)
			{
				PCT0210024 = (int?)reader[78];
			}
			if(reader[79] != DBNull.Value)
			{
				PCT0210025 = (int?)reader[79];
			}
			if(reader[80] != DBNull.Value)
			{
				PCT0210026 = (int?)reader[80];
			}
			if(reader[81] != DBNull.Value)
			{
				PCT0220001 = (int?)reader[81];
			}
			if(reader[82] != DBNull.Value)
			{
				PCT0220002 = (int?)reader[82];
			}
			if(reader[83] != DBNull.Value)
			{
				PCT0220003 = (int?)reader[83];
			}
			if(reader[84] != DBNull.Value)
			{
				PCT0220004 = (int?)reader[84];
			}
			if(reader[85] != DBNull.Value)
			{
				PCT0220005 = (int?)reader[85];
			}
			if(reader[86] != DBNull.Value)
			{
				PCT0220006 = (int?)reader[86];
			}
			if(reader[87] != DBNull.Value)
			{
				PCT0220007 = (int?)reader[87];
			}
			if(reader[88] != DBNull.Value)
			{
				PCT0220008 = (int?)reader[88];
			}
			if(reader[89] != DBNull.Value)
			{
				PCT0220009 = (int?)reader[89];
			}
			if(reader[90] != DBNull.Value)
			{
				PCT0220010 = (int?)reader[90];
			}
			if(reader[91] != DBNull.Value)
			{
				PCT0220011 = (int?)reader[91];
			}
			if(reader[92] != DBNull.Value)
			{
				PCT0220012 = (int?)reader[92];
			}
			if(reader[93] != DBNull.Value)
			{
				PCT0220013 = (int?)reader[93];
			}
			if(reader[94] != DBNull.Value)
			{
				PCT0220014 = (int?)reader[94];
			}
			if(reader[95] != DBNull.Value)
			{
				PCT0220015 = (int?)reader[95];
			}
			if(reader[96] != DBNull.Value)
			{
				PCT0220016 = (int?)reader[96];
			}
			if(reader[97] != DBNull.Value)
			{
				PCT0220017 = (int?)reader[97];
			}
			if(reader[98] != DBNull.Value)
			{
				PCT0220018 = (int?)reader[98];
			}
			if(reader[99] != DBNull.Value)
			{
				PCT0220019 = (int?)reader[99];
			}
			if(reader[100] != DBNull.Value)
			{
				PCT0220020 = (int?)reader[100];
			}
			if(reader[101] != DBNull.Value)
			{
				PCT0220021 = (int?)reader[101];
			}
			if(reader[102] != DBNull.Value)
			{
				PCT0220022 = (int?)reader[102];
			}
			if(reader[103] != DBNull.Value)
			{
				PCT0220023 = (int?)reader[103];
			}
			if(reader[104] != DBNull.Value)
			{
				PCT0220024 = (int?)reader[104];
			}
			if(reader[105] != DBNull.Value)
			{
				PCT0220025 = (int?)reader[105];
			}
			if(reader[106] != DBNull.Value)
			{
				PCT0220026 = (int?)reader[106];
			}
			if(reader[107] != DBNull.Value)
			{
				PCT0220027 = (int?)reader[107];
			}
			if(reader[108] != DBNull.Value)
			{
				PCT0220028 = (int?)reader[108];
			}
			if(reader[109] != DBNull.Value)
			{
				PCT0230001 = (int?)reader[109];
			}
			if(reader[110] != DBNull.Value)
			{
				PCT0230002 = (int?)reader[110];
			}
			if(reader[111] != DBNull.Value)
			{
				PCT0230003 = (int?)reader[111];
			}
			if(reader[112] != DBNull.Value)
			{
				PCT0230004 = (int?)reader[112];
			}
			if(reader[113] != DBNull.Value)
			{
				PCT0230005 = (int?)reader[113];
			}
			if(reader[114] != DBNull.Value)
			{
				PCT0230006 = (int?)reader[114];
			}
			if(reader[115] != DBNull.Value)
			{
				PCT0230007 = (int?)reader[115];
			}
			if(reader[116] != DBNull.Value)
			{
				PCT0230008 = (int?)reader[116];
			}
			if(reader[117] != DBNull.Value)
			{
				PCT0230009 = (int?)reader[117];
			}
			if(reader[118] != DBNull.Value)
			{
				PCT0230010 = (int?)reader[118];
			}
			if(reader[119] != DBNull.Value)
			{
				PCT0230011 = (int?)reader[119];
			}
			if(reader[120] != DBNull.Value)
			{
				PCT0230012 = (int?)reader[120];
			}
			if(reader[121] != DBNull.Value)
			{
				PCT0230013 = (int?)reader[121];
			}
			if(reader[122] != DBNull.Value)
			{
				PCT0240001 = (int?)reader[122];
			}
			if(reader[123] != DBNull.Value)
			{
				PCT0240002 = (int?)reader[123];
			}
			if(reader[124] != DBNull.Value)
			{
				PCT0240003 = (int?)reader[124];
			}
			if(reader[125] != DBNull.Value)
			{
				PCT0240004 = (int?)reader[125];
			}
			if(reader[126] != DBNull.Value)
			{
				PCT0240005 = (int?)reader[126];
			}
			if(reader[127] != DBNull.Value)
			{
				PCT0240006 = (int?)reader[127];
			}
			if(reader[128] != DBNull.Value)
			{
				PCT0240007 = (int?)reader[128];
			}
			if(reader[129] != DBNull.Value)
			{
				PCT0240008 = (int?)reader[129];
			}
			if(reader[130] != DBNull.Value)
			{
				PCT0240009 = (int?)reader[130];
			}
			if(reader[131] != DBNull.Value)
			{
				PCT0240010 = (int?)reader[131];
			}
			if(reader[132] != DBNull.Value)
			{
				PCT0240011 = (int?)reader[132];
			}
			if(reader[133] != DBNull.Value)
			{
				PCT0240012 = (int?)reader[133];
			}
			if(reader[134] != DBNull.Value)
			{
				PCT0240013 = (int?)reader[134];
			}
			if(reader[135] != DBNull.Value)
			{
				PCT0240014 = (int?)reader[135];
			}
			if(reader[136] != DBNull.Value)
			{
				PCT0240015 = (int?)reader[136];
			}
			if(reader[137] != DBNull.Value)
			{
				PCT0240016 = (int?)reader[137];
			}
			if(reader[138] != DBNull.Value)
			{
				PCT0250001 = (int?)reader[138];
			}
			if(reader[139] != DBNull.Value)
			{
				PCT0250002 = (int?)reader[139];
			}
			if(reader[140] != DBNull.Value)
			{
				PCT0250003 = (int?)reader[140];
			}
			if(reader[141] != DBNull.Value)
			{
				PCT0250004 = (int?)reader[141];
			}
			if(reader[142] != DBNull.Value)
			{
				PCT0250005 = (int?)reader[142];
			}
			if(reader[143] != DBNull.Value)
			{
				PCT0250006 = (int?)reader[143];
			}
			if(reader[144] != DBNull.Value)
			{
				PCT0250007 = (int?)reader[144];
			}
			if(reader[145] != DBNull.Value)
			{
				PCT0250008 = (int?)reader[145];
			}
			if(reader[146] != DBNull.Value)
			{
				PCT0250009 = (int?)reader[146];
			}
			if(reader[147] != DBNull.Value)
			{
				PCT0250010 = (int?)reader[147];
			}
			if(reader[148] != DBNull.Value)
			{
				PCT0250011 = (int?)reader[148];
			}
			if(reader[149] != DBNull.Value)
			{
				PCT0250012 = (int?)reader[149];
			}
			if(reader[150] != DBNull.Value)
			{
				PCT0250013 = (int?)reader[150];
			}
			if(reader[151] != DBNull.Value)
			{
				PCT0250014 = (int?)reader[151];
			}
			if(reader[152] != DBNull.Value)
			{
				PCT0250015 = (int?)reader[152];
			}
			if(reader[153] != DBNull.Value)
			{
				PCT0250016 = (int?)reader[153];
			}
			if(reader[154] != DBNull.Value)
			{
				PCT0250017 = (int?)reader[154];
			}
			if(reader[155] != DBNull.Value)
			{
				PCT0250018 = (int?)reader[155];
			}
			if(reader[156] != DBNull.Value)
			{
				PCT0250019 = (int?)reader[156];
			}
			if(reader[157] != DBNull.Value)
			{
				PCT0250020 = (int?)reader[157];
			}
			if(reader[158] != DBNull.Value)
			{
				PCT0250021 = (int?)reader[158];
			}
			if(reader[159] != DBNull.Value)
			{
				PCT0250022 = (int?)reader[159];
			}
			if(reader[160] != DBNull.Value)
			{
				PCT0250023 = (int?)reader[160];
			}
			if(reader[161] != DBNull.Value)
			{
				PCT0250024 = (int?)reader[161];
			}
			if(reader[162] != DBNull.Value)
			{
				PCT0250025 = (int?)reader[162];
			}
			if(reader[163] != DBNull.Value)
			{
				PCT0250026 = (int?)reader[163];
			}
			if(reader[164] != DBNull.Value)
			{
				PCT0250027 = (int?)reader[164];
			}
			if(reader[165] != DBNull.Value)
			{
				PCT0250028 = (int?)reader[165];
			}
			if(reader[166] != DBNull.Value)
			{
				PCT0250029 = (int?)reader[166];
			}
			if(reader[167] != DBNull.Value)
			{
				PCT0250030 = (int?)reader[167];
			}
			if(reader[168] != DBNull.Value)
			{
				PCT0250031 = (int?)reader[168];
			}
			if(reader[169] != DBNull.Value)
			{
				PCT0250032 = (int?)reader[169];
			}
			if(reader[170] != DBNull.Value)
			{
				PCT0250033 = (int?)reader[170];
			}
			if(reader[171] != DBNull.Value)
			{
				PCT0250034 = (int?)reader[171];
			}
			if(reader[172] != DBNull.Value)
			{
				PCT0250035 = (int?)reader[172];
			}
			if(reader[173] != DBNull.Value)
			{
				PCT0250036 = (int?)reader[173];
			}
			if(reader[174] != DBNull.Value)
			{
				PCT0250037 = (int?)reader[174];
			}
			if(reader[175] != DBNull.Value)
			{
				PCT0250038 = (int?)reader[175];
			}
			if(reader[176] != DBNull.Value)
			{
				PCT0250039 = (int?)reader[176];
			}
			if(reader[177] != DBNull.Value)
			{
				PCT0250040 = (int?)reader[177];
			}
			if(reader[178] != DBNull.Value)
			{
				PCT0250041 = (int?)reader[178];
			}
			if(reader[179] != DBNull.Value)
			{
				PCT0250042 = (int?)reader[179];
			}
			if(reader[180] != DBNull.Value)
			{
				PCT0250043 = (int?)reader[180];
			}
			if(reader[181] != DBNull.Value)
			{
				PCT0250044 = (int?)reader[181];
			}
			if(reader[182] != DBNull.Value)
			{
				PCT0250045 = (int?)reader[182];
			}
			if(reader[183] != DBNull.Value)
			{
				PCT0260001 = (int?)reader[183];
			}
			if(reader[184] != DBNull.Value)
			{
				PCT0260002 = (int?)reader[184];
			}
			if(reader[185] != DBNull.Value)
			{
				PCT0260003 = (int?)reader[185];
			}
			if(reader[186] != DBNull.Value)
			{
				PCT0260004 = (int?)reader[186];
			}
			if(reader[187] != DBNull.Value)
			{
				PCT0260005 = (int?)reader[187];
			}
			if(reader[188] != DBNull.Value)
			{
				PCT0260006 = (int?)reader[188];
			}
			if(reader[189] != DBNull.Value)
			{
				PCT0260007 = (int?)reader[189];
			}
			if(reader[190] != DBNull.Value)
			{
				PCT0270001 = (int?)reader[190];
			}
			if(reader[191] != DBNull.Value)
			{
				PCT0270002 = (int?)reader[191];
			}
			if(reader[192] != DBNull.Value)
			{
				PCT0270003 = (int?)reader[192];
			}
			if(reader[193] != DBNull.Value)
			{
				PCT0270004 = (int?)reader[193];
			}
			if(reader[194] != DBNull.Value)
			{
				PCT0270005 = (int?)reader[194];
			}
			if(reader[195] != DBNull.Value)
			{
				PCT0270006 = (int?)reader[195];
			}
			if(reader[196] != DBNull.Value)
			{
				PCT0270007 = (int?)reader[196];
			}
			if(reader[197] != DBNull.Value)
			{
				PCT0270008 = (int?)reader[197];
			}
			if(reader[198] != DBNull.Value)
			{
				PCT0270009 = (int?)reader[198];
			}
			if(reader[199] != DBNull.Value)
			{
				PCT0270010 = (int?)reader[199];
			}
			if(reader[200] != DBNull.Value)
			{
				PCT0270011 = (int?)reader[200];
			}
			if(reader[201] != DBNull.Value)
			{
				PCT0270012 = (int?)reader[201];
			}
			if(reader[202] != DBNull.Value)
			{
				PCT0270013 = (int?)reader[202];
			}
			if(reader[203] != DBNull.Value)
			{
				PCT0270014 = (int?)reader[203];
			}
			if(reader[204] != DBNull.Value)
			{
				PCT0270015 = (int?)reader[204];
			}
			if(reader[205] != DBNull.Value)
			{
				PCT0270016 = (int?)reader[205];
			}
			if(reader[206] != DBNull.Value)
			{
				PCT0270017 = (int?)reader[206];
			}
			if(reader[207] != DBNull.Value)
			{
				PCT0270018 = (int?)reader[207];
			}
			if(reader[208] != DBNull.Value)
			{
				PCT0280001 = (int?)reader[208];
			}
			if(reader[209] != DBNull.Value)
			{
				PCT0280002 = (int?)reader[209];
			}
			if(reader[210] != DBNull.Value)
			{
				PCT0280003 = (int?)reader[210];
			}
			if(reader[211] != DBNull.Value)
			{
				PCT0280004 = (int?)reader[211];
			}
			if(reader[212] != DBNull.Value)
			{
				PCT0280005 = (int?)reader[212];
			}
			if(reader[213] != DBNull.Value)
			{
				PCT0280006 = (int?)reader[213];
			}
			if(reader[214] != DBNull.Value)
			{
				PCT0280007 = (int?)reader[214];
			}
			if(reader[215] != DBNull.Value)
			{
				PCT0280008 = (int?)reader[215];
			}
			if(reader[216] != DBNull.Value)
			{
				PCT0280009 = (int?)reader[216];
			}
			if(reader[217] != DBNull.Value)
			{
				PCT0280010 = (int?)reader[217];
			}
			if(reader[218] != DBNull.Value)
			{
				PCT0280011 = (int?)reader[218];
			}
			if(reader[219] != DBNull.Value)
			{
				PCT0280012 = (int?)reader[219];
			}
			if(reader[220] != DBNull.Value)
			{
				PCT0280013 = (int?)reader[220];
			}
			if(reader[221] != DBNull.Value)
			{
				PCT0280014 = (int?)reader[221];
			}
			if(reader[222] != DBNull.Value)
			{
				PCT0280015 = (int?)reader[222];
			}
			if(reader[223] != DBNull.Value)
			{
				PCT0280016 = (int?)reader[223];
			}
			if(reader[224] != DBNull.Value)
			{
				PCT0280017 = (int?)reader[224];
			}
			if(reader[225] != DBNull.Value)
			{
				PCT0280018 = (int?)reader[225];
			}
			if(reader[226] != DBNull.Value)
			{
				PCT0280019 = (int?)reader[226];
			}
			if(reader[227] != DBNull.Value)
			{
				PCT0280020 = (int?)reader[227];
			}
			if(reader[228] != DBNull.Value)
			{
				PCT0280021 = (int?)reader[228];
			}
			if(reader[229] != DBNull.Value)
			{
				PCT0280022 = (int?)reader[229];
			}
			if(reader[230] != DBNull.Value)
			{
				PCT0280023 = (int?)reader[230];
			}
			if(reader[231] != DBNull.Value)
			{
				PCT0290001 = (int?)reader[231];
			}
			if(reader[232] != DBNull.Value)
			{
				PCT0300001 = (int?)reader[232];
			}
			if(reader[233] != DBNull.Value)
			{
				PCT0300002 = (int?)reader[233];
			}
			if(reader[234] != DBNull.Value)
			{
				PCT0300003 = (int?)reader[234];
			}
			if(reader[235] != DBNull.Value)
			{
				PCT0310001 = (decimal?)reader[235];
			}
			if(reader[236] != DBNull.Value)
			{
				PCT0310002 = (decimal?)reader[236];
			}
			if(reader[237] != DBNull.Value)
			{
				PCT0310003 = (decimal?)reader[237];
			}
		}
		#endregion Constructors
	}
}
