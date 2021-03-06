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

	public class SummaryOne_SF1_00010 : BaseModel
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
		public int? P029A001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 6)]
		public int? P029A002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 7)]
		public int? P029A003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 8)]
		public int? P029A004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 9)]
		public int? P029A005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 10)]
		public int? P029A006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 11)]
		public int? P029A007 { get; set; }

		[Display(Name = "Biological child", ShortName = "Biological child", Order = 12)]
		public int? P029A008 { get; set; }

		[Display(Name = "Adopted child", ShortName = "Adopted child", Order = 13)]
		public int? P029A009 { get; set; }

		[Display(Name = "Stepchild", ShortName = "Stepchild", Order = 14)]
		public int? P029A010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 15)]
		public int? P029A011 { get; set; }

		[Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 16)]
		public int? P029A012 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 17)]
		public int? P029A013 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 18)]
		public int? P029A014 { get; set; }

		[Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 19)]
		public int? P029A015 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 20)]
		public int? P029A016 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 21)]
		public int? P029A017 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 22)]
		public int? P029A018 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 23)]
		public int? P029A019 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 24)]
		public int? P029A020 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 25)]
		public int? P029A021 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 26)]
		public int? P029A022 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 27)]
		public int? P029A023 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 28)]
		public int? P029A024 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 29)]
		public int? P029A025 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 30)]
		public int? P029A026 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 31)]
		public int? P029A027 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 32)]
		public int? P029A028 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 33)]
		public int? P029B001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 34)]
		public int? P029B002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 35)]
		public int? P029B003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 36)]
		public int? P029B004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 37)]
		public int? P029B005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 38)]
		public int? P029B006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 39)]
		public int? P029B007 { get; set; }

		[Display(Name = "Biological child", ShortName = "Biological child", Order = 40)]
		public int? P029B008 { get; set; }

		[Display(Name = "Adopted child", ShortName = "Adopted child", Order = 41)]
		public int? P029B009 { get; set; }

		[Display(Name = "Stepchild", ShortName = "Stepchild", Order = 42)]
		public int? P029B010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 43)]
		public int? P029B011 { get; set; }

		[Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 44)]
		public int? P029B012 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 45)]
		public int? P029B013 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 46)]
		public int? P029B014 { get; set; }

		[Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 47)]
		public int? P029B015 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 48)]
		public int? P029B016 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 49)]
		public int? P029B017 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 50)]
		public int? P029B018 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 51)]
		public int? P029B019 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 52)]
		public int? P029B020 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 53)]
		public int? P029B021 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 54)]
		public int? P029B022 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 55)]
		public int? P029B023 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 56)]
		public int? P029B024 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 57)]
		public int? P029B025 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 58)]
		public int? P029B026 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 59)]
		public int? P029B027 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 60)]
		public int? P029B028 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 61)]
		public int? P029C001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 62)]
		public int? P029C002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 63)]
		public int? P029C003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 64)]
		public int? P029C004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 65)]
		public int? P029C005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 66)]
		public int? P029C006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 67)]
		public int? P029C007 { get; set; }

		[Display(Name = "Biological child", ShortName = "Biological child", Order = 68)]
		public int? P029C008 { get; set; }

		[Display(Name = "Adopted child", ShortName = "Adopted child", Order = 69)]
		public int? P029C009 { get; set; }

		[Display(Name = "Stepchild", ShortName = "Stepchild", Order = 70)]
		public int? P029C010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 71)]
		public int? P029C011 { get; set; }

		[Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 72)]
		public int? P029C012 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 73)]
		public int? P029C013 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 74)]
		public int? P029C014 { get; set; }

		[Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 75)]
		public int? P029C015 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 76)]
		public int? P029C016 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 77)]
		public int? P029C017 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 78)]
		public int? P029C018 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 79)]
		public int? P029C019 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 80)]
		public int? P029C020 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 81)]
		public int? P029C021 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 82)]
		public int? P029C022 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 83)]
		public int? P029C023 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 84)]
		public int? P029C024 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 85)]
		public int? P029C025 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 86)]
		public int? P029C026 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 87)]
		public int? P029C027 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 88)]
		public int? P029C028 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 89)]
		public int? P029D001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 90)]
		public int? P029D002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 91)]
		public int? P029D003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 92)]
		public int? P029D004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 93)]
		public int? P029D005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 94)]
		public int? P029D006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 95)]
		public int? P029D007 { get; set; }

		[Display(Name = "Biological child", ShortName = "Biological child", Order = 96)]
		public int? P029D008 { get; set; }

		[Display(Name = "Adopted child", ShortName = "Adopted child", Order = 97)]
		public int? P029D009 { get; set; }

		[Display(Name = "Stepchild", ShortName = "Stepchild", Order = 98)]
		public int? P029D010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 99)]
		public int? P029D011 { get; set; }

		[Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 100)]
		public int? P029D012 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 101)]
		public int? P029D013 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 102)]
		public int? P029D014 { get; set; }

		[Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 103)]
		public int? P029D015 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 104)]
		public int? P029D016 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 105)]
		public int? P029D017 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 106)]
		public int? P029D018 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 107)]
		public int? P029D019 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 108)]
		public int? P029D020 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 109)]
		public int? P029D021 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 110)]
		public int? P029D022 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 111)]
		public int? P029D023 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 112)]
		public int? P029D024 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 113)]
		public int? P029D025 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 114)]
		public int? P029D026 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 115)]
		public int? P029D027 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 116)]
		public int? P029D028 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 117)]
		public int? P029E001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 118)]
		public int? P029E002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 119)]
		public int? P029E003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 120)]
		public int? P029E004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 121)]
		public int? P029E005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 122)]
		public int? P029E006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 123)]
		public int? P029E007 { get; set; }

		[Display(Name = "Biological child", ShortName = "Biological child", Order = 124)]
		public int? P029E008 { get; set; }

		[Display(Name = "Adopted child", ShortName = "Adopted child", Order = 125)]
		public int? P029E009 { get; set; }

		[Display(Name = "Stepchild", ShortName = "Stepchild", Order = 126)]
		public int? P029E010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 127)]
		public int? P029E011 { get; set; }

		[Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 128)]
		public int? P029E012 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 129)]
		public int? P029E013 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 130)]
		public int? P029E014 { get; set; }

		[Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 131)]
		public int? P029E015 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 132)]
		public int? P029E016 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 133)]
		public int? P029E017 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 134)]
		public int? P029E018 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 135)]
		public int? P029E019 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 136)]
		public int? P029E020 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 137)]
		public int? P029E021 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 138)]
		public int? P029E022 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 139)]
		public int? P029E023 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 140)]
		public int? P029E024 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 141)]
		public int? P029E025 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 142)]
		public int? P029E026 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 143)]
		public int? P029E027 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 144)]
		public int? P029E028 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 145)]
		public int? P029F001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 146)]
		public int? P029F002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 147)]
		public int? P029F003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 148)]
		public int? P029F004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 149)]
		public int? P029F005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 150)]
		public int? P029F006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 151)]
		public int? P029F007 { get; set; }

		[Display(Name = "Biological child", ShortName = "Biological child", Order = 152)]
		public int? P029F008 { get; set; }

		[Display(Name = "Adopted child", ShortName = "Adopted child", Order = 153)]
		public int? P029F009 { get; set; }

		[Display(Name = "Stepchild", ShortName = "Stepchild", Order = 154)]
		public int? P029F010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 155)]
		public int? P029F011 { get; set; }

		[Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 156)]
		public int? P029F012 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 157)]
		public int? P029F013 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 158)]
		public int? P029F014 { get; set; }

		[Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 159)]
		public int? P029F015 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 160)]
		public int? P029F016 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 161)]
		public int? P029F017 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 162)]
		public int? P029F018 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 163)]
		public int? P029F019 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 164)]
		public int? P029F020 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 165)]
		public int? P029F021 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 166)]
		public int? P029F022 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 167)]
		public int? P029F023 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 168)]
		public int? P029F024 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 169)]
		public int? P029F025 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 170)]
		public int? P029F026 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 171)]
		public int? P029F027 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 172)]
		public int? P029F028 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 173)]
		public int? P029G001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 174)]
		public int? P029G002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 175)]
		public int? P029G003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 176)]
		public int? P029G004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 177)]
		public int? P029G005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 178)]
		public int? P029G006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 179)]
		public int? P029G007 { get; set; }

		[Display(Name = "Biological child", ShortName = "Biological child", Order = 180)]
		public int? P029G008 { get; set; }

		[Display(Name = "Adopted child", ShortName = "Adopted child", Order = 181)]
		public int? P029G009 { get; set; }

		[Display(Name = "Stepchild", ShortName = "Stepchild", Order = 182)]
		public int? P029G010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 183)]
		public int? P029G011 { get; set; }

		[Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 184)]
		public int? P029G012 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 185)]
		public int? P029G013 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 186)]
		public int? P029G014 { get; set; }

		[Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 187)]
		public int? P029G015 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 188)]
		public int? P029G016 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 189)]
		public int? P029G017 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 190)]
		public int? P029G018 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 191)]
		public int? P029G019 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 192)]
		public int? P029G020 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 193)]
		public int? P029G021 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 194)]
		public int? P029G022 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 195)]
		public int? P029G023 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 196)]
		public int? P029G024 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 197)]
		public int? P029G025 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 198)]
		public int? P029G026 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 199)]
		public int? P029G027 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 200)]
		public int? P029G028 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 201)]
		public int? P029H001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 202)]
		public int? P029H002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 203)]
		public int? P029H003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 204)]
		public int? P029H004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 205)]
		public int? P029H005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 206)]
		public int? P029H006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 207)]
		public int? P029H007 { get; set; }

		[Display(Name = "Biological child", ShortName = "Biological child", Order = 208)]
		public int? P029H008 { get; set; }

		[Display(Name = "Adopted child", ShortName = "Adopted child", Order = 209)]
		public int? P029H009 { get; set; }

		[Display(Name = "Stepchild", ShortName = "Stepchild", Order = 210)]
		public int? P029H010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 211)]
		public int? P029H011 { get; set; }

		[Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 212)]
		public int? P029H012 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 213)]
		public int? P029H013 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 214)]
		public int? P029H014 { get; set; }

		[Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 215)]
		public int? P029H015 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 216)]
		public int? P029H016 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 217)]
		public int? P029H017 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 218)]
		public int? P029H018 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 219)]
		public int? P029H019 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 220)]
		public int? P029H020 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 221)]
		public int? P029H021 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 222)]
		public int? P029H022 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 223)]
		public int? P029H023 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 224)]
		public int? P029H024 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 225)]
		public int? P029H025 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 226)]
		public int? P029H026 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 227)]
		public int? P029H027 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 228)]
		public int? P029H028 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 229)]
		public int? P029I001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 230)]
		public int? P029I002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 231)]
		public int? P029I003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 232)]
		public int? P029I004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 233)]
		public int? P029I005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 234)]
		public int? P029I006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 235)]
		public int? P029I007 { get; set; }

		[Display(Name = "Biological child", ShortName = "Biological child", Order = 236)]
		public int? P029I008 { get; set; }

		[Display(Name = "Adopted child", ShortName = "Adopted child", Order = 237)]
		public int? P029I009 { get; set; }

		[Display(Name = "Stepchild", ShortName = "Stepchild", Order = 238)]
		public int? P029I010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 239)]
		public int? P029I011 { get; set; }

		[Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 240)]
		public int? P029I012 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 241)]
		public int? P029I013 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 242)]
		public int? P029I014 { get; set; }

		[Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 243)]
		public int? P029I015 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 244)]
		public int? P029I016 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 245)]
		public int? P029I017 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 246)]
		public int? P029I018 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 247)]
		public int? P029I019 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 248)]
		public int? P029I020 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 249)]
		public int? P029I021 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 250)]
		public int? P029I022 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 251)]
		public int? P029I023 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 252)]
		public int? P029I024 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 253)]
		public int? P029I025 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 254)]
		public int? P029I026 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 255)]
		public int? P029I027 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 256)]
		public int? P029I028 { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryOne_SF1_00010() { }

		public SummaryOne_SF1_00010(string csvLine) : base(csvLine) { }

		public SummaryOne_SF1_00010(string[] values) : base(values) { }

		public SummaryOne_SF1_00010(OleDbDataReader reader)
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
				P029A001 = (int?)reader[5];
			}
			if(reader[6] != DBNull.Value)
			{
				P029A002 = (int?)reader[6];
			}
			if(reader[7] != DBNull.Value)
			{
				P029A003 = (int?)reader[7];
			}
			if(reader[8] != DBNull.Value)
			{
				P029A004 = (int?)reader[8];
			}
			if(reader[9] != DBNull.Value)
			{
				P029A005 = (int?)reader[9];
			}
			if(reader[10] != DBNull.Value)
			{
				P029A006 = (int?)reader[10];
			}
			if(reader[11] != DBNull.Value)
			{
				P029A007 = (int?)reader[11];
			}
			if(reader[12] != DBNull.Value)
			{
				P029A008 = (int?)reader[12];
			}
			if(reader[13] != DBNull.Value)
			{
				P029A009 = (int?)reader[13];
			}
			if(reader[14] != DBNull.Value)
			{
				P029A010 = (int?)reader[14];
			}
			if(reader[15] != DBNull.Value)
			{
				P029A011 = (int?)reader[15];
			}
			if(reader[16] != DBNull.Value)
			{
				P029A012 = (int?)reader[16];
			}
			if(reader[17] != DBNull.Value)
			{
				P029A013 = (int?)reader[17];
			}
			if(reader[18] != DBNull.Value)
			{
				P029A014 = (int?)reader[18];
			}
			if(reader[19] != DBNull.Value)
			{
				P029A015 = (int?)reader[19];
			}
			if(reader[20] != DBNull.Value)
			{
				P029A016 = (int?)reader[20];
			}
			if(reader[21] != DBNull.Value)
			{
				P029A017 = (int?)reader[21];
			}
			if(reader[22] != DBNull.Value)
			{
				P029A018 = (int?)reader[22];
			}
			if(reader[23] != DBNull.Value)
			{
				P029A019 = (int?)reader[23];
			}
			if(reader[24] != DBNull.Value)
			{
				P029A020 = (int?)reader[24];
			}
			if(reader[25] != DBNull.Value)
			{
				P029A021 = (int?)reader[25];
			}
			if(reader[26] != DBNull.Value)
			{
				P029A022 = (int?)reader[26];
			}
			if(reader[27] != DBNull.Value)
			{
				P029A023 = (int?)reader[27];
			}
			if(reader[28] != DBNull.Value)
			{
				P029A024 = (int?)reader[28];
			}
			if(reader[29] != DBNull.Value)
			{
				P029A025 = (int?)reader[29];
			}
			if(reader[30] != DBNull.Value)
			{
				P029A026 = (int?)reader[30];
			}
			if(reader[31] != DBNull.Value)
			{
				P029A027 = (int?)reader[31];
			}
			if(reader[32] != DBNull.Value)
			{
				P029A028 = (int?)reader[32];
			}
			if(reader[33] != DBNull.Value)
			{
				P029B001 = (int?)reader[33];
			}
			if(reader[34] != DBNull.Value)
			{
				P029B002 = (int?)reader[34];
			}
			if(reader[35] != DBNull.Value)
			{
				P029B003 = (int?)reader[35];
			}
			if(reader[36] != DBNull.Value)
			{
				P029B004 = (int?)reader[36];
			}
			if(reader[37] != DBNull.Value)
			{
				P029B005 = (int?)reader[37];
			}
			if(reader[38] != DBNull.Value)
			{
				P029B006 = (int?)reader[38];
			}
			if(reader[39] != DBNull.Value)
			{
				P029B007 = (int?)reader[39];
			}
			if(reader[40] != DBNull.Value)
			{
				P029B008 = (int?)reader[40];
			}
			if(reader[41] != DBNull.Value)
			{
				P029B009 = (int?)reader[41];
			}
			if(reader[42] != DBNull.Value)
			{
				P029B010 = (int?)reader[42];
			}
			if(reader[43] != DBNull.Value)
			{
				P029B011 = (int?)reader[43];
			}
			if(reader[44] != DBNull.Value)
			{
				P029B012 = (int?)reader[44];
			}
			if(reader[45] != DBNull.Value)
			{
				P029B013 = (int?)reader[45];
			}
			if(reader[46] != DBNull.Value)
			{
				P029B014 = (int?)reader[46];
			}
			if(reader[47] != DBNull.Value)
			{
				P029B015 = (int?)reader[47];
			}
			if(reader[48] != DBNull.Value)
			{
				P029B016 = (int?)reader[48];
			}
			if(reader[49] != DBNull.Value)
			{
				P029B017 = (int?)reader[49];
			}
			if(reader[50] != DBNull.Value)
			{
				P029B018 = (int?)reader[50];
			}
			if(reader[51] != DBNull.Value)
			{
				P029B019 = (int?)reader[51];
			}
			if(reader[52] != DBNull.Value)
			{
				P029B020 = (int?)reader[52];
			}
			if(reader[53] != DBNull.Value)
			{
				P029B021 = (int?)reader[53];
			}
			if(reader[54] != DBNull.Value)
			{
				P029B022 = (int?)reader[54];
			}
			if(reader[55] != DBNull.Value)
			{
				P029B023 = (int?)reader[55];
			}
			if(reader[56] != DBNull.Value)
			{
				P029B024 = (int?)reader[56];
			}
			if(reader[57] != DBNull.Value)
			{
				P029B025 = (int?)reader[57];
			}
			if(reader[58] != DBNull.Value)
			{
				P029B026 = (int?)reader[58];
			}
			if(reader[59] != DBNull.Value)
			{
				P029B027 = (int?)reader[59];
			}
			if(reader[60] != DBNull.Value)
			{
				P029B028 = (int?)reader[60];
			}
			if(reader[61] != DBNull.Value)
			{
				P029C001 = (int?)reader[61];
			}
			if(reader[62] != DBNull.Value)
			{
				P029C002 = (int?)reader[62];
			}
			if(reader[63] != DBNull.Value)
			{
				P029C003 = (int?)reader[63];
			}
			if(reader[64] != DBNull.Value)
			{
				P029C004 = (int?)reader[64];
			}
			if(reader[65] != DBNull.Value)
			{
				P029C005 = (int?)reader[65];
			}
			if(reader[66] != DBNull.Value)
			{
				P029C006 = (int?)reader[66];
			}
			if(reader[67] != DBNull.Value)
			{
				P029C007 = (int?)reader[67];
			}
			if(reader[68] != DBNull.Value)
			{
				P029C008 = (int?)reader[68];
			}
			if(reader[69] != DBNull.Value)
			{
				P029C009 = (int?)reader[69];
			}
			if(reader[70] != DBNull.Value)
			{
				P029C010 = (int?)reader[70];
			}
			if(reader[71] != DBNull.Value)
			{
				P029C011 = (int?)reader[71];
			}
			if(reader[72] != DBNull.Value)
			{
				P029C012 = (int?)reader[72];
			}
			if(reader[73] != DBNull.Value)
			{
				P029C013 = (int?)reader[73];
			}
			if(reader[74] != DBNull.Value)
			{
				P029C014 = (int?)reader[74];
			}
			if(reader[75] != DBNull.Value)
			{
				P029C015 = (int?)reader[75];
			}
			if(reader[76] != DBNull.Value)
			{
				P029C016 = (int?)reader[76];
			}
			if(reader[77] != DBNull.Value)
			{
				P029C017 = (int?)reader[77];
			}
			if(reader[78] != DBNull.Value)
			{
				P029C018 = (int?)reader[78];
			}
			if(reader[79] != DBNull.Value)
			{
				P029C019 = (int?)reader[79];
			}
			if(reader[80] != DBNull.Value)
			{
				P029C020 = (int?)reader[80];
			}
			if(reader[81] != DBNull.Value)
			{
				P029C021 = (int?)reader[81];
			}
			if(reader[82] != DBNull.Value)
			{
				P029C022 = (int?)reader[82];
			}
			if(reader[83] != DBNull.Value)
			{
				P029C023 = (int?)reader[83];
			}
			if(reader[84] != DBNull.Value)
			{
				P029C024 = (int?)reader[84];
			}
			if(reader[85] != DBNull.Value)
			{
				P029C025 = (int?)reader[85];
			}
			if(reader[86] != DBNull.Value)
			{
				P029C026 = (int?)reader[86];
			}
			if(reader[87] != DBNull.Value)
			{
				P029C027 = (int?)reader[87];
			}
			if(reader[88] != DBNull.Value)
			{
				P029C028 = (int?)reader[88];
			}
			if(reader[89] != DBNull.Value)
			{
				P029D001 = (int?)reader[89];
			}
			if(reader[90] != DBNull.Value)
			{
				P029D002 = (int?)reader[90];
			}
			if(reader[91] != DBNull.Value)
			{
				P029D003 = (int?)reader[91];
			}
			if(reader[92] != DBNull.Value)
			{
				P029D004 = (int?)reader[92];
			}
			if(reader[93] != DBNull.Value)
			{
				P029D005 = (int?)reader[93];
			}
			if(reader[94] != DBNull.Value)
			{
				P029D006 = (int?)reader[94];
			}
			if(reader[95] != DBNull.Value)
			{
				P029D007 = (int?)reader[95];
			}
			if(reader[96] != DBNull.Value)
			{
				P029D008 = (int?)reader[96];
			}
			if(reader[97] != DBNull.Value)
			{
				P029D009 = (int?)reader[97];
			}
			if(reader[98] != DBNull.Value)
			{
				P029D010 = (int?)reader[98];
			}
			if(reader[99] != DBNull.Value)
			{
				P029D011 = (int?)reader[99];
			}
			if(reader[100] != DBNull.Value)
			{
				P029D012 = (int?)reader[100];
			}
			if(reader[101] != DBNull.Value)
			{
				P029D013 = (int?)reader[101];
			}
			if(reader[102] != DBNull.Value)
			{
				P029D014 = (int?)reader[102];
			}
			if(reader[103] != DBNull.Value)
			{
				P029D015 = (int?)reader[103];
			}
			if(reader[104] != DBNull.Value)
			{
				P029D016 = (int?)reader[104];
			}
			if(reader[105] != DBNull.Value)
			{
				P029D017 = (int?)reader[105];
			}
			if(reader[106] != DBNull.Value)
			{
				P029D018 = (int?)reader[106];
			}
			if(reader[107] != DBNull.Value)
			{
				P029D019 = (int?)reader[107];
			}
			if(reader[108] != DBNull.Value)
			{
				P029D020 = (int?)reader[108];
			}
			if(reader[109] != DBNull.Value)
			{
				P029D021 = (int?)reader[109];
			}
			if(reader[110] != DBNull.Value)
			{
				P029D022 = (int?)reader[110];
			}
			if(reader[111] != DBNull.Value)
			{
				P029D023 = (int?)reader[111];
			}
			if(reader[112] != DBNull.Value)
			{
				P029D024 = (int?)reader[112];
			}
			if(reader[113] != DBNull.Value)
			{
				P029D025 = (int?)reader[113];
			}
			if(reader[114] != DBNull.Value)
			{
				P029D026 = (int?)reader[114];
			}
			if(reader[115] != DBNull.Value)
			{
				P029D027 = (int?)reader[115];
			}
			if(reader[116] != DBNull.Value)
			{
				P029D028 = (int?)reader[116];
			}
			if(reader[117] != DBNull.Value)
			{
				P029E001 = (int?)reader[117];
			}
			if(reader[118] != DBNull.Value)
			{
				P029E002 = (int?)reader[118];
			}
			if(reader[119] != DBNull.Value)
			{
				P029E003 = (int?)reader[119];
			}
			if(reader[120] != DBNull.Value)
			{
				P029E004 = (int?)reader[120];
			}
			if(reader[121] != DBNull.Value)
			{
				P029E005 = (int?)reader[121];
			}
			if(reader[122] != DBNull.Value)
			{
				P029E006 = (int?)reader[122];
			}
			if(reader[123] != DBNull.Value)
			{
				P029E007 = (int?)reader[123];
			}
			if(reader[124] != DBNull.Value)
			{
				P029E008 = (int?)reader[124];
			}
			if(reader[125] != DBNull.Value)
			{
				P029E009 = (int?)reader[125];
			}
			if(reader[126] != DBNull.Value)
			{
				P029E010 = (int?)reader[126];
			}
			if(reader[127] != DBNull.Value)
			{
				P029E011 = (int?)reader[127];
			}
			if(reader[128] != DBNull.Value)
			{
				P029E012 = (int?)reader[128];
			}
			if(reader[129] != DBNull.Value)
			{
				P029E013 = (int?)reader[129];
			}
			if(reader[130] != DBNull.Value)
			{
				P029E014 = (int?)reader[130];
			}
			if(reader[131] != DBNull.Value)
			{
				P029E015 = (int?)reader[131];
			}
			if(reader[132] != DBNull.Value)
			{
				P029E016 = (int?)reader[132];
			}
			if(reader[133] != DBNull.Value)
			{
				P029E017 = (int?)reader[133];
			}
			if(reader[134] != DBNull.Value)
			{
				P029E018 = (int?)reader[134];
			}
			if(reader[135] != DBNull.Value)
			{
				P029E019 = (int?)reader[135];
			}
			if(reader[136] != DBNull.Value)
			{
				P029E020 = (int?)reader[136];
			}
			if(reader[137] != DBNull.Value)
			{
				P029E021 = (int?)reader[137];
			}
			if(reader[138] != DBNull.Value)
			{
				P029E022 = (int?)reader[138];
			}
			if(reader[139] != DBNull.Value)
			{
				P029E023 = (int?)reader[139];
			}
			if(reader[140] != DBNull.Value)
			{
				P029E024 = (int?)reader[140];
			}
			if(reader[141] != DBNull.Value)
			{
				P029E025 = (int?)reader[141];
			}
			if(reader[142] != DBNull.Value)
			{
				P029E026 = (int?)reader[142];
			}
			if(reader[143] != DBNull.Value)
			{
				P029E027 = (int?)reader[143];
			}
			if(reader[144] != DBNull.Value)
			{
				P029E028 = (int?)reader[144];
			}
			if(reader[145] != DBNull.Value)
			{
				P029F001 = (int?)reader[145];
			}
			if(reader[146] != DBNull.Value)
			{
				P029F002 = (int?)reader[146];
			}
			if(reader[147] != DBNull.Value)
			{
				P029F003 = (int?)reader[147];
			}
			if(reader[148] != DBNull.Value)
			{
				P029F004 = (int?)reader[148];
			}
			if(reader[149] != DBNull.Value)
			{
				P029F005 = (int?)reader[149];
			}
			if(reader[150] != DBNull.Value)
			{
				P029F006 = (int?)reader[150];
			}
			if(reader[151] != DBNull.Value)
			{
				P029F007 = (int?)reader[151];
			}
			if(reader[152] != DBNull.Value)
			{
				P029F008 = (int?)reader[152];
			}
			if(reader[153] != DBNull.Value)
			{
				P029F009 = (int?)reader[153];
			}
			if(reader[154] != DBNull.Value)
			{
				P029F010 = (int?)reader[154];
			}
			if(reader[155] != DBNull.Value)
			{
				P029F011 = (int?)reader[155];
			}
			if(reader[156] != DBNull.Value)
			{
				P029F012 = (int?)reader[156];
			}
			if(reader[157] != DBNull.Value)
			{
				P029F013 = (int?)reader[157];
			}
			if(reader[158] != DBNull.Value)
			{
				P029F014 = (int?)reader[158];
			}
			if(reader[159] != DBNull.Value)
			{
				P029F015 = (int?)reader[159];
			}
			if(reader[160] != DBNull.Value)
			{
				P029F016 = (int?)reader[160];
			}
			if(reader[161] != DBNull.Value)
			{
				P029F017 = (int?)reader[161];
			}
			if(reader[162] != DBNull.Value)
			{
				P029F018 = (int?)reader[162];
			}
			if(reader[163] != DBNull.Value)
			{
				P029F019 = (int?)reader[163];
			}
			if(reader[164] != DBNull.Value)
			{
				P029F020 = (int?)reader[164];
			}
			if(reader[165] != DBNull.Value)
			{
				P029F021 = (int?)reader[165];
			}
			if(reader[166] != DBNull.Value)
			{
				P029F022 = (int?)reader[166];
			}
			if(reader[167] != DBNull.Value)
			{
				P029F023 = (int?)reader[167];
			}
			if(reader[168] != DBNull.Value)
			{
				P029F024 = (int?)reader[168];
			}
			if(reader[169] != DBNull.Value)
			{
				P029F025 = (int?)reader[169];
			}
			if(reader[170] != DBNull.Value)
			{
				P029F026 = (int?)reader[170];
			}
			if(reader[171] != DBNull.Value)
			{
				P029F027 = (int?)reader[171];
			}
			if(reader[172] != DBNull.Value)
			{
				P029F028 = (int?)reader[172];
			}
			if(reader[173] != DBNull.Value)
			{
				P029G001 = (int?)reader[173];
			}
			if(reader[174] != DBNull.Value)
			{
				P029G002 = (int?)reader[174];
			}
			if(reader[175] != DBNull.Value)
			{
				P029G003 = (int?)reader[175];
			}
			if(reader[176] != DBNull.Value)
			{
				P029G004 = (int?)reader[176];
			}
			if(reader[177] != DBNull.Value)
			{
				P029G005 = (int?)reader[177];
			}
			if(reader[178] != DBNull.Value)
			{
				P029G006 = (int?)reader[178];
			}
			if(reader[179] != DBNull.Value)
			{
				P029G007 = (int?)reader[179];
			}
			if(reader[180] != DBNull.Value)
			{
				P029G008 = (int?)reader[180];
			}
			if(reader[181] != DBNull.Value)
			{
				P029G009 = (int?)reader[181];
			}
			if(reader[182] != DBNull.Value)
			{
				P029G010 = (int?)reader[182];
			}
			if(reader[183] != DBNull.Value)
			{
				P029G011 = (int?)reader[183];
			}
			if(reader[184] != DBNull.Value)
			{
				P029G012 = (int?)reader[184];
			}
			if(reader[185] != DBNull.Value)
			{
				P029G013 = (int?)reader[185];
			}
			if(reader[186] != DBNull.Value)
			{
				P029G014 = (int?)reader[186];
			}
			if(reader[187] != DBNull.Value)
			{
				P029G015 = (int?)reader[187];
			}
			if(reader[188] != DBNull.Value)
			{
				P029G016 = (int?)reader[188];
			}
			if(reader[189] != DBNull.Value)
			{
				P029G017 = (int?)reader[189];
			}
			if(reader[190] != DBNull.Value)
			{
				P029G018 = (int?)reader[190];
			}
			if(reader[191] != DBNull.Value)
			{
				P029G019 = (int?)reader[191];
			}
			if(reader[192] != DBNull.Value)
			{
				P029G020 = (int?)reader[192];
			}
			if(reader[193] != DBNull.Value)
			{
				P029G021 = (int?)reader[193];
			}
			if(reader[194] != DBNull.Value)
			{
				P029G022 = (int?)reader[194];
			}
			if(reader[195] != DBNull.Value)
			{
				P029G023 = (int?)reader[195];
			}
			if(reader[196] != DBNull.Value)
			{
				P029G024 = (int?)reader[196];
			}
			if(reader[197] != DBNull.Value)
			{
				P029G025 = (int?)reader[197];
			}
			if(reader[198] != DBNull.Value)
			{
				P029G026 = (int?)reader[198];
			}
			if(reader[199] != DBNull.Value)
			{
				P029G027 = (int?)reader[199];
			}
			if(reader[200] != DBNull.Value)
			{
				P029G028 = (int?)reader[200];
			}
			if(reader[201] != DBNull.Value)
			{
				P029H001 = (int?)reader[201];
			}
			if(reader[202] != DBNull.Value)
			{
				P029H002 = (int?)reader[202];
			}
			if(reader[203] != DBNull.Value)
			{
				P029H003 = (int?)reader[203];
			}
			if(reader[204] != DBNull.Value)
			{
				P029H004 = (int?)reader[204];
			}
			if(reader[205] != DBNull.Value)
			{
				P029H005 = (int?)reader[205];
			}
			if(reader[206] != DBNull.Value)
			{
				P029H006 = (int?)reader[206];
			}
			if(reader[207] != DBNull.Value)
			{
				P029H007 = (int?)reader[207];
			}
			if(reader[208] != DBNull.Value)
			{
				P029H008 = (int?)reader[208];
			}
			if(reader[209] != DBNull.Value)
			{
				P029H009 = (int?)reader[209];
			}
			if(reader[210] != DBNull.Value)
			{
				P029H010 = (int?)reader[210];
			}
			if(reader[211] != DBNull.Value)
			{
				P029H011 = (int?)reader[211];
			}
			if(reader[212] != DBNull.Value)
			{
				P029H012 = (int?)reader[212];
			}
			if(reader[213] != DBNull.Value)
			{
				P029H013 = (int?)reader[213];
			}
			if(reader[214] != DBNull.Value)
			{
				P029H014 = (int?)reader[214];
			}
			if(reader[215] != DBNull.Value)
			{
				P029H015 = (int?)reader[215];
			}
			if(reader[216] != DBNull.Value)
			{
				P029H016 = (int?)reader[216];
			}
			if(reader[217] != DBNull.Value)
			{
				P029H017 = (int?)reader[217];
			}
			if(reader[218] != DBNull.Value)
			{
				P029H018 = (int?)reader[218];
			}
			if(reader[219] != DBNull.Value)
			{
				P029H019 = (int?)reader[219];
			}
			if(reader[220] != DBNull.Value)
			{
				P029H020 = (int?)reader[220];
			}
			if(reader[221] != DBNull.Value)
			{
				P029H021 = (int?)reader[221];
			}
			if(reader[222] != DBNull.Value)
			{
				P029H022 = (int?)reader[222];
			}
			if(reader[223] != DBNull.Value)
			{
				P029H023 = (int?)reader[223];
			}
			if(reader[224] != DBNull.Value)
			{
				P029H024 = (int?)reader[224];
			}
			if(reader[225] != DBNull.Value)
			{
				P029H025 = (int?)reader[225];
			}
			if(reader[226] != DBNull.Value)
			{
				P029H026 = (int?)reader[226];
			}
			if(reader[227] != DBNull.Value)
			{
				P029H027 = (int?)reader[227];
			}
			if(reader[228] != DBNull.Value)
			{
				P029H028 = (int?)reader[228];
			}
			if(reader[229] != DBNull.Value)
			{
				P029I001 = (int?)reader[229];
			}
			if(reader[230] != DBNull.Value)
			{
				P029I002 = (int?)reader[230];
			}
			if(reader[231] != DBNull.Value)
			{
				P029I003 = (int?)reader[231];
			}
			if(reader[232] != DBNull.Value)
			{
				P029I004 = (int?)reader[232];
			}
			if(reader[233] != DBNull.Value)
			{
				P029I005 = (int?)reader[233];
			}
			if(reader[234] != DBNull.Value)
			{
				P029I006 = (int?)reader[234];
			}
			if(reader[235] != DBNull.Value)
			{
				P029I007 = (int?)reader[235];
			}
			if(reader[236] != DBNull.Value)
			{
				P029I008 = (int?)reader[236];
			}
			if(reader[237] != DBNull.Value)
			{
				P029I009 = (int?)reader[237];
			}
			if(reader[238] != DBNull.Value)
			{
				P029I010 = (int?)reader[238];
			}
			if(reader[239] != DBNull.Value)
			{
				P029I011 = (int?)reader[239];
			}
			if(reader[240] != DBNull.Value)
			{
				P029I012 = (int?)reader[240];
			}
			if(reader[241] != DBNull.Value)
			{
				P029I013 = (int?)reader[241];
			}
			if(reader[242] != DBNull.Value)
			{
				P029I014 = (int?)reader[242];
			}
			if(reader[243] != DBNull.Value)
			{
				P029I015 = (int?)reader[243];
			}
			if(reader[244] != DBNull.Value)
			{
				P029I016 = (int?)reader[244];
			}
			if(reader[245] != DBNull.Value)
			{
				P029I017 = (int?)reader[245];
			}
			if(reader[246] != DBNull.Value)
			{
				P029I018 = (int?)reader[246];
			}
			if(reader[247] != DBNull.Value)
			{
				P029I019 = (int?)reader[247];
			}
			if(reader[248] != DBNull.Value)
			{
				P029I020 = (int?)reader[248];
			}
			if(reader[249] != DBNull.Value)
			{
				P029I021 = (int?)reader[249];
			}
			if(reader[250] != DBNull.Value)
			{
				P029I022 = (int?)reader[250];
			}
			if(reader[251] != DBNull.Value)
			{
				P029I023 = (int?)reader[251];
			}
			if(reader[252] != DBNull.Value)
			{
				P029I024 = (int?)reader[252];
			}
			if(reader[253] != DBNull.Value)
			{
				P029I025 = (int?)reader[253];
			}
			if(reader[254] != DBNull.Value)
			{
				P029I026 = (int?)reader[254];
			}
			if(reader[255] != DBNull.Value)
			{
				P029I027 = (int?)reader[255];
			}
			if(reader[256] != DBNull.Value)
			{
				P029I028 = (int?)reader[256];
			}
		}
		#endregion Constructors
	}
}
