namespace CensusDataParser.Generated.Binding
{
	#region Using Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.OleDb;
	#endregion Using Directives

	public class SF1CongressionalDistricts113_SF1_00030 : BaseModel
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
		public int? PCT012K001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 6)]
		public int? PCT012K002 { get; set; }

		[Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 7)]
		public int? PCT012K003 { get; set; }

		[Display(Name = "1 year", ShortName = "1 year", Order = 8)]
		public int? PCT012K004 { get; set; }

		[Display(Name = "2 years", ShortName = "2 years", Order = 9)]
		public int? PCT012K005 { get; set; }

		[Display(Name = "3 years", ShortName = "3 years", Order = 10)]
		public int? PCT012K006 { get; set; }

		[Display(Name = "4 years", ShortName = "4 years", Order = 11)]
		public int? PCT012K007 { get; set; }

		[Display(Name = "5 years", ShortName = "5 years", Order = 12)]
		public int? PCT012K008 { get; set; }

		[Display(Name = "6 years", ShortName = "6 years", Order = 13)]
		public int? PCT012K009 { get; set; }

		[Display(Name = "7 years", ShortName = "7 years", Order = 14)]
		public int? PCT012K010 { get; set; }

		[Display(Name = "8 years", ShortName = "8 years", Order = 15)]
		public int? PCT012K011 { get; set; }

		[Display(Name = "9 years", ShortName = "9 years", Order = 16)]
		public int? PCT012K012 { get; set; }

		[Display(Name = "10 years", ShortName = "10 years", Order = 17)]
		public int? PCT012K013 { get; set; }

		[Display(Name = "11 years", ShortName = "11 years", Order = 18)]
		public int? PCT012K014 { get; set; }

		[Display(Name = "12 years", ShortName = "12 years", Order = 19)]
		public int? PCT012K015 { get; set; }

		[Display(Name = "13 years", ShortName = "13 years", Order = 20)]
		public int? PCT012K016 { get; set; }

		[Display(Name = "14 years", ShortName = "14 years", Order = 21)]
		public int? PCT012K017 { get; set; }

		[Display(Name = "15 years", ShortName = "15 years", Order = 22)]
		public int? PCT012K018 { get; set; }

		[Display(Name = "16 years", ShortName = "16 years", Order = 23)]
		public int? PCT012K019 { get; set; }

		[Display(Name = "17 years", ShortName = "17 years", Order = 24)]
		public int? PCT012K020 { get; set; }

		[Display(Name = "18 years", ShortName = "18 years", Order = 25)]
		public int? PCT012K021 { get; set; }

		[Display(Name = "19 years", ShortName = "19 years", Order = 26)]
		public int? PCT012K022 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 27)]
		public int? PCT012K023 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 28)]
		public int? PCT012K024 { get; set; }

		[Display(Name = "22 years", ShortName = "22 years", Order = 29)]
		public int? PCT012K025 { get; set; }

		[Display(Name = "23 years", ShortName = "23 years", Order = 30)]
		public int? PCT012K026 { get; set; }

		[Display(Name = "24 years", ShortName = "24 years", Order = 31)]
		public int? PCT012K027 { get; set; }

		[Display(Name = "25 years", ShortName = "25 years", Order = 32)]
		public int? PCT012K028 { get; set; }

		[Display(Name = "26 years", ShortName = "26 years", Order = 33)]
		public int? PCT012K029 { get; set; }

		[Display(Name = "27 years", ShortName = "27 years", Order = 34)]
		public int? PCT012K030 { get; set; }

		[Display(Name = "28 years", ShortName = "28 years", Order = 35)]
		public int? PCT012K031 { get; set; }

		[Display(Name = "29 years", ShortName = "29 years", Order = 36)]
		public int? PCT012K032 { get; set; }

		[Display(Name = "30 years", ShortName = "30 years", Order = 37)]
		public int? PCT012K033 { get; set; }

		[Display(Name = "31 years", ShortName = "31 years", Order = 38)]
		public int? PCT012K034 { get; set; }

		[Display(Name = "32 years", ShortName = "32 years", Order = 39)]
		public int? PCT012K035 { get; set; }

		[Display(Name = "33 years", ShortName = "33 years", Order = 40)]
		public int? PCT012K036 { get; set; }

		[Display(Name = "34 years", ShortName = "34 years", Order = 41)]
		public int? PCT012K037 { get; set; }

		[Display(Name = "35 years", ShortName = "35 years", Order = 42)]
		public int? PCT012K038 { get; set; }

		[Display(Name = "36 years", ShortName = "36 years", Order = 43)]
		public int? PCT012K039 { get; set; }

		[Display(Name = "37 years", ShortName = "37 years", Order = 44)]
		public int? PCT012K040 { get; set; }

		[Display(Name = "38 years", ShortName = "38 years", Order = 45)]
		public int? PCT012K041 { get; set; }

		[Display(Name = "39 years", ShortName = "39 years", Order = 46)]
		public int? PCT012K042 { get; set; }

		[Display(Name = "40 years", ShortName = "40 years", Order = 47)]
		public int? PCT012K043 { get; set; }

		[Display(Name = "41 years", ShortName = "41 years", Order = 48)]
		public int? PCT012K044 { get; set; }

		[Display(Name = "42 years", ShortName = "42 years", Order = 49)]
		public int? PCT012K045 { get; set; }

		[Display(Name = "43 years", ShortName = "43 years", Order = 50)]
		public int? PCT012K046 { get; set; }

		[Display(Name = "44 years", ShortName = "44 years", Order = 51)]
		public int? PCT012K047 { get; set; }

		[Display(Name = "45 years", ShortName = "45 years", Order = 52)]
		public int? PCT012K048 { get; set; }

		[Display(Name = "46 years", ShortName = "46 years", Order = 53)]
		public int? PCT012K049 { get; set; }

		[Display(Name = "47 years", ShortName = "47 years", Order = 54)]
		public int? PCT012K050 { get; set; }

		[Display(Name = "48 years", ShortName = "48 years", Order = 55)]
		public int? PCT012K051 { get; set; }

		[Display(Name = "49 years", ShortName = "49 years", Order = 56)]
		public int? PCT012K052 { get; set; }

		[Display(Name = "50 years", ShortName = "50 years", Order = 57)]
		public int? PCT012K053 { get; set; }

		[Display(Name = "51 years", ShortName = "51 years", Order = 58)]
		public int? PCT012K054 { get; set; }

		[Display(Name = "52 years", ShortName = "52 years", Order = 59)]
		public int? PCT012K055 { get; set; }

		[Display(Name = "53 years", ShortName = "53 years", Order = 60)]
		public int? PCT012K056 { get; set; }

		[Display(Name = "54 years", ShortName = "54 years", Order = 61)]
		public int? PCT012K057 { get; set; }

		[Display(Name = "55 years", ShortName = "55 years", Order = 62)]
		public int? PCT012K058 { get; set; }

		[Display(Name = "56 years", ShortName = "56 years", Order = 63)]
		public int? PCT012K059 { get; set; }

		[Display(Name = "57 years", ShortName = "57 years", Order = 64)]
		public int? PCT012K060 { get; set; }

		[Display(Name = "58 years", ShortName = "58 years", Order = 65)]
		public int? PCT012K061 { get; set; }

		[Display(Name = "59 years", ShortName = "59 years", Order = 66)]
		public int? PCT012K062 { get; set; }

		[Display(Name = "60 years", ShortName = "60 years", Order = 67)]
		public int? PCT012K063 { get; set; }

		[Display(Name = "61 years", ShortName = "61 years", Order = 68)]
		public int? PCT012K064 { get; set; }

		[Display(Name = "62 years", ShortName = "62 years", Order = 69)]
		public int? PCT012K065 { get; set; }

		[Display(Name = "63 years", ShortName = "63 years", Order = 70)]
		public int? PCT012K066 { get; set; }

		[Display(Name = "64 years", ShortName = "64 years", Order = 71)]
		public int? PCT012K067 { get; set; }

		[Display(Name = "65 years", ShortName = "65 years", Order = 72)]
		public int? PCT012K068 { get; set; }

		[Display(Name = "66 years", ShortName = "66 years", Order = 73)]
		public int? PCT012K069 { get; set; }

		[Display(Name = "67 years", ShortName = "67 years", Order = 74)]
		public int? PCT012K070 { get; set; }

		[Display(Name = "68 years", ShortName = "68 years", Order = 75)]
		public int? PCT012K071 { get; set; }

		[Display(Name = "69 years", ShortName = "69 years", Order = 76)]
		public int? PCT012K072 { get; set; }

		[Display(Name = "70 years", ShortName = "70 years", Order = 77)]
		public int? PCT012K073 { get; set; }

		[Display(Name = "71 years", ShortName = "71 years", Order = 78)]
		public int? PCT012K074 { get; set; }

		[Display(Name = "72 years", ShortName = "72 years", Order = 79)]
		public int? PCT012K075 { get; set; }

		[Display(Name = "73 years", ShortName = "73 years", Order = 80)]
		public int? PCT012K076 { get; set; }

		[Display(Name = "74 years", ShortName = "74 years", Order = 81)]
		public int? PCT012K077 { get; set; }

		[Display(Name = "75 years", ShortName = "75 years", Order = 82)]
		public int? PCT012K078 { get; set; }

		[Display(Name = "76 years", ShortName = "76 years", Order = 83)]
		public int? PCT012K079 { get; set; }

		[Display(Name = "77 years", ShortName = "77 years", Order = 84)]
		public int? PCT012K080 { get; set; }

		[Display(Name = "78 years", ShortName = "78 years", Order = 85)]
		public int? PCT012K081 { get; set; }

		[Display(Name = "79 years", ShortName = "79 years", Order = 86)]
		public int? PCT012K082 { get; set; }

		[Display(Name = "80 years", ShortName = "80 years", Order = 87)]
		public int? PCT012K083 { get; set; }

		[Display(Name = "81 years", ShortName = "81 years", Order = 88)]
		public int? PCT012K084 { get; set; }

		[Display(Name = "82 years", ShortName = "82 years", Order = 89)]
		public int? PCT012K085 { get; set; }

		[Display(Name = "83 years", ShortName = "83 years", Order = 90)]
		public int? PCT012K086 { get; set; }

		[Display(Name = "84 years", ShortName = "84 years", Order = 91)]
		public int? PCT012K087 { get; set; }

		[Display(Name = "85 years", ShortName = "85 years", Order = 92)]
		public int? PCT012K088 { get; set; }

		[Display(Name = "86 years", ShortName = "86 years", Order = 93)]
		public int? PCT012K089 { get; set; }

		[Display(Name = "87 years", ShortName = "87 years", Order = 94)]
		public int? PCT012K090 { get; set; }

		[Display(Name = "88 years", ShortName = "88 years", Order = 95)]
		public int? PCT012K091 { get; set; }

		[Display(Name = "89 years", ShortName = "89 years", Order = 96)]
		public int? PCT012K092 { get; set; }

		[Display(Name = "90 years", ShortName = "90 years", Order = 97)]
		public int? PCT012K093 { get; set; }

		[Display(Name = "91 years", ShortName = "91 years", Order = 98)]
		public int? PCT012K094 { get; set; }

		[Display(Name = "92 years", ShortName = "92 years", Order = 99)]
		public int? PCT012K095 { get; set; }

		[Display(Name = "93 years", ShortName = "93 years", Order = 100)]
		public int? PCT012K096 { get; set; }

		[Display(Name = "94 years", ShortName = "94 years", Order = 101)]
		public int? PCT012K097 { get; set; }

		[Display(Name = "95 years", ShortName = "95 years", Order = 102)]
		public int? PCT012K098 { get; set; }

		[Display(Name = "96 years", ShortName = "96 years", Order = 103)]
		public int? PCT012K099 { get; set; }

		[Display(Name = "97 years", ShortName = "97 years", Order = 104)]
		public int? PCT012K100 { get; set; }

		[Display(Name = "98 years", ShortName = "98 years", Order = 105)]
		public int? PCT012K101 { get; set; }

		[Display(Name = "99 years", ShortName = "99 years", Order = 106)]
		public int? PCT012K102 { get; set; }

		[Display(Name = "100 to 104 years", ShortName = "100 to 104 years", Order = 107)]
		public int? PCT012K103 { get; set; }

		[Display(Name = "105 to 109 years", ShortName = "105 to 109 years", Order = 108)]
		public int? PCT012K104 { get; set; }

		[Display(Name = "110 years and over", ShortName = "110 years and over", Order = 109)]
		public int? PCT012K105 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 110)]
		public int? PCT012K106 { get; set; }

		[Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 111)]
		public int? PCT012K107 { get; set; }

		[Display(Name = "1 year", ShortName = "1 year", Order = 112)]
		public int? PCT012K108 { get; set; }

		[Display(Name = "2 years", ShortName = "2 years", Order = 113)]
		public int? PCT012K109 { get; set; }

		[Display(Name = "3 years", ShortName = "3 years", Order = 114)]
		public int? PCT012K110 { get; set; }

		[Display(Name = "4 years", ShortName = "4 years", Order = 115)]
		public int? PCT012K111 { get; set; }

		[Display(Name = "5 years", ShortName = "5 years", Order = 116)]
		public int? PCT012K112 { get; set; }

		[Display(Name = "6 years", ShortName = "6 years", Order = 117)]
		public int? PCT012K113 { get; set; }

		[Display(Name = "7 years", ShortName = "7 years", Order = 118)]
		public int? PCT012K114 { get; set; }

		[Display(Name = "8 years", ShortName = "8 years", Order = 119)]
		public int? PCT012K115 { get; set; }

		[Display(Name = "9 years", ShortName = "9 years", Order = 120)]
		public int? PCT012K116 { get; set; }

		[Display(Name = "10 years", ShortName = "10 years", Order = 121)]
		public int? PCT012K117 { get; set; }

		[Display(Name = "11 years", ShortName = "11 years", Order = 122)]
		public int? PCT012K118 { get; set; }

		[Display(Name = "12 years", ShortName = "12 years", Order = 123)]
		public int? PCT012K119 { get; set; }

		[Display(Name = "13 years", ShortName = "13 years", Order = 124)]
		public int? PCT012K120 { get; set; }

		[Display(Name = "14 years", ShortName = "14 years", Order = 125)]
		public int? PCT012K121 { get; set; }

		[Display(Name = "15 years", ShortName = "15 years", Order = 126)]
		public int? PCT012K122 { get; set; }

		[Display(Name = "16 years", ShortName = "16 years", Order = 127)]
		public int? PCT012K123 { get; set; }

		[Display(Name = "17 years", ShortName = "17 years", Order = 128)]
		public int? PCT012K124 { get; set; }

		[Display(Name = "18 years", ShortName = "18 years", Order = 129)]
		public int? PCT012K125 { get; set; }

		[Display(Name = "19 years", ShortName = "19 years", Order = 130)]
		public int? PCT012K126 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 131)]
		public int? PCT012K127 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 132)]
		public int? PCT012K128 { get; set; }

		[Display(Name = "22 years", ShortName = "22 years", Order = 133)]
		public int? PCT012K129 { get; set; }

		[Display(Name = "23 years", ShortName = "23 years", Order = 134)]
		public int? PCT012K130 { get; set; }

		[Display(Name = "24 years", ShortName = "24 years", Order = 135)]
		public int? PCT012K131 { get; set; }

		[Display(Name = "25 years", ShortName = "25 years", Order = 136)]
		public int? PCT012K132 { get; set; }

		[Display(Name = "26 years", ShortName = "26 years", Order = 137)]
		public int? PCT012K133 { get; set; }

		[Display(Name = "27 years", ShortName = "27 years", Order = 138)]
		public int? PCT012K134 { get; set; }

		[Display(Name = "28 years", ShortName = "28 years", Order = 139)]
		public int? PCT012K135 { get; set; }

		[Display(Name = "29 years", ShortName = "29 years", Order = 140)]
		public int? PCT012K136 { get; set; }

		[Display(Name = "30 years", ShortName = "30 years", Order = 141)]
		public int? PCT012K137 { get; set; }

		[Display(Name = "31 years", ShortName = "31 years", Order = 142)]
		public int? PCT012K138 { get; set; }

		[Display(Name = "32 years", ShortName = "32 years", Order = 143)]
		public int? PCT012K139 { get; set; }

		[Display(Name = "33 years", ShortName = "33 years", Order = 144)]
		public int? PCT012K140 { get; set; }

		[Display(Name = "34 years", ShortName = "34 years", Order = 145)]
		public int? PCT012K141 { get; set; }

		[Display(Name = "35 years", ShortName = "35 years", Order = 146)]
		public int? PCT012K142 { get; set; }

		[Display(Name = "36 years", ShortName = "36 years", Order = 147)]
		public int? PCT012K143 { get; set; }

		[Display(Name = "37 years", ShortName = "37 years", Order = 148)]
		public int? PCT012K144 { get; set; }

		[Display(Name = "38 years", ShortName = "38 years", Order = 149)]
		public int? PCT012K145 { get; set; }

		[Display(Name = "39 years", ShortName = "39 years", Order = 150)]
		public int? PCT012K146 { get; set; }

		[Display(Name = "40 years", ShortName = "40 years", Order = 151)]
		public int? PCT012K147 { get; set; }

		[Display(Name = "41 years", ShortName = "41 years", Order = 152)]
		public int? PCT012K148 { get; set; }

		[Display(Name = "42 years", ShortName = "42 years", Order = 153)]
		public int? PCT012K149 { get; set; }

		[Display(Name = "43 years", ShortName = "43 years", Order = 154)]
		public int? PCT012K150 { get; set; }

		[Display(Name = "44 years", ShortName = "44 years", Order = 155)]
		public int? PCT012K151 { get; set; }

		[Display(Name = "45 years", ShortName = "45 years", Order = 156)]
		public int? PCT012K152 { get; set; }

		[Display(Name = "46 years", ShortName = "46 years", Order = 157)]
		public int? PCT012K153 { get; set; }

		[Display(Name = "47 years", ShortName = "47 years", Order = 158)]
		public int? PCT012K154 { get; set; }

		[Display(Name = "48 years", ShortName = "48 years", Order = 159)]
		public int? PCT012K155 { get; set; }

		[Display(Name = "49 years", ShortName = "49 years", Order = 160)]
		public int? PCT012K156 { get; set; }

		[Display(Name = "50 years", ShortName = "50 years", Order = 161)]
		public int? PCT012K157 { get; set; }

		[Display(Name = "51 years", ShortName = "51 years", Order = 162)]
		public int? PCT012K158 { get; set; }

		[Display(Name = "52 years", ShortName = "52 years", Order = 163)]
		public int? PCT012K159 { get; set; }

		[Display(Name = "53 years", ShortName = "53 years", Order = 164)]
		public int? PCT012K160 { get; set; }

		[Display(Name = "54 years", ShortName = "54 years", Order = 165)]
		public int? PCT012K161 { get; set; }

		[Display(Name = "55 years", ShortName = "55 years", Order = 166)]
		public int? PCT012K162 { get; set; }

		[Display(Name = "56 years", ShortName = "56 years", Order = 167)]
		public int? PCT012K163 { get; set; }

		[Display(Name = "57 years", ShortName = "57 years", Order = 168)]
		public int? PCT012K164 { get; set; }

		[Display(Name = "58 years", ShortName = "58 years", Order = 169)]
		public int? PCT012K165 { get; set; }

		[Display(Name = "59 years", ShortName = "59 years", Order = 170)]
		public int? PCT012K166 { get; set; }

		[Display(Name = "60 years", ShortName = "60 years", Order = 171)]
		public int? PCT012K167 { get; set; }

		[Display(Name = "61 years", ShortName = "61 years", Order = 172)]
		public int? PCT012K168 { get; set; }

		[Display(Name = "62 years", ShortName = "62 years", Order = 173)]
		public int? PCT012K169 { get; set; }

		[Display(Name = "63 years", ShortName = "63 years", Order = 174)]
		public int? PCT012K170 { get; set; }

		[Display(Name = "64 years", ShortName = "64 years", Order = 175)]
		public int? PCT012K171 { get; set; }

		[Display(Name = "65 years", ShortName = "65 years", Order = 176)]
		public int? PCT012K172 { get; set; }

		[Display(Name = "66 years", ShortName = "66 years", Order = 177)]
		public int? PCT012K173 { get; set; }

		[Display(Name = "67 years", ShortName = "67 years", Order = 178)]
		public int? PCT012K174 { get; set; }

		[Display(Name = "68 years", ShortName = "68 years", Order = 179)]
		public int? PCT012K175 { get; set; }

		[Display(Name = "69 years", ShortName = "69 years", Order = 180)]
		public int? PCT012K176 { get; set; }

		[Display(Name = "70 years", ShortName = "70 years", Order = 181)]
		public int? PCT012K177 { get; set; }

		[Display(Name = "71 years", ShortName = "71 years", Order = 182)]
		public int? PCT012K178 { get; set; }

		[Display(Name = "72 years", ShortName = "72 years", Order = 183)]
		public int? PCT012K179 { get; set; }

		[Display(Name = "73 years", ShortName = "73 years", Order = 184)]
		public int? PCT012K180 { get; set; }

		[Display(Name = "74 years", ShortName = "74 years", Order = 185)]
		public int? PCT012K181 { get; set; }

		[Display(Name = "75 years", ShortName = "75 years", Order = 186)]
		public int? PCT012K182 { get; set; }

		[Display(Name = "76 years", ShortName = "76 years", Order = 187)]
		public int? PCT012K183 { get; set; }

		[Display(Name = "77 years", ShortName = "77 years", Order = 188)]
		public int? PCT012K184 { get; set; }

		[Display(Name = "78 years", ShortName = "78 years", Order = 189)]
		public int? PCT012K185 { get; set; }

		[Display(Name = "79 years", ShortName = "79 years", Order = 190)]
		public int? PCT012K186 { get; set; }

		[Display(Name = "80 years", ShortName = "80 years", Order = 191)]
		public int? PCT012K187 { get; set; }

		[Display(Name = "81 years", ShortName = "81 years", Order = 192)]
		public int? PCT012K188 { get; set; }

		[Display(Name = "82 years", ShortName = "82 years", Order = 193)]
		public int? PCT012K189 { get; set; }

		[Display(Name = "83 years", ShortName = "83 years", Order = 194)]
		public int? PCT012K190 { get; set; }

		[Display(Name = "84 years", ShortName = "84 years", Order = 195)]
		public int? PCT012K191 { get; set; }

		[Display(Name = "85 years", ShortName = "85 years", Order = 196)]
		public int? PCT012K192 { get; set; }

		[Display(Name = "86 years", ShortName = "86 years", Order = 197)]
		public int? PCT012K193 { get; set; }

		[Display(Name = "87 years", ShortName = "87 years", Order = 198)]
		public int? PCT012K194 { get; set; }

		[Display(Name = "88 years", ShortName = "88 years", Order = 199)]
		public int? PCT012K195 { get; set; }

		[Display(Name = "89 years", ShortName = "89 years", Order = 200)]
		public int? PCT012K196 { get; set; }

		[Display(Name = "90 years", ShortName = "90 years", Order = 201)]
		public int? PCT012K197 { get; set; }

		[Display(Name = "91 years", ShortName = "91 years", Order = 202)]
		public int? PCT012K198 { get; set; }

		[Display(Name = "92 years", ShortName = "92 years", Order = 203)]
		public int? PCT012K199 { get; set; }

		[Display(Name = "93 years", ShortName = "93 years", Order = 204)]
		public int? PCT012K200 { get; set; }

		[Display(Name = "94 years", ShortName = "94 years", Order = 205)]
		public int? PCT012K201 { get; set; }

		[Display(Name = "95 years", ShortName = "95 years", Order = 206)]
		public int? PCT012K202 { get; set; }

		[Display(Name = "96 years", ShortName = "96 years", Order = 207)]
		public int? PCT012K203 { get; set; }

		[Display(Name = "97 years", ShortName = "97 years", Order = 208)]
		public int? PCT012K204 { get; set; }

		[Display(Name = "98 years", ShortName = "98 years", Order = 209)]
		public int? PCT012K205 { get; set; }

		[Display(Name = "99 years", ShortName = "99 years", Order = 210)]
		public int? PCT012K206 { get; set; }

		[Display(Name = "100 to 104 years", ShortName = "100 to 104 years", Order = 211)]
		public int? PCT012K207 { get; set; }

		[Display(Name = "105 to 109 years", ShortName = "105 to 109 years", Order = 212)]
		public int? PCT012K208 { get; set; }

		[Display(Name = "110 years and over", ShortName = "110 years and over", Order = 213)]
		public int? PCT012K209 { get; set; }
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_SF1_00030(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_SF1_00030(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_SF1_00030(OleDbDataReader reader)
		{
			if (reader[0] != DBNull.Value)
			{
				FILEID = (string)reader[0];
			}
			if (reader[1] != DBNull.Value)
			{
				STUSAB = (string)reader[1];
			}
			if (reader[2] != DBNull.Value)
			{
				CHARITER = (string)reader[2];
			}
			if (reader[3] != DBNull.Value)
			{
				CIFSN = (string)reader[3];
			}
			if (reader[4] != DBNull.Value)
			{
				LOGRECNO = (int)reader[4];
			}
			if (reader[5] != DBNull.Value)
			{
				PCT012K001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				PCT012K002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				PCT012K003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				PCT012K004 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				PCT012K005 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				PCT012K006 = (int?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				PCT012K007 = (int?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				PCT012K008 = (int?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				PCT012K009 = (int?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				PCT012K010 = (int?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				PCT012K011 = (int?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				PCT012K012 = (int?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				PCT012K013 = (int?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				PCT012K014 = (int?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				PCT012K015 = (int?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				PCT012K016 = (int?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				PCT012K017 = (int?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				PCT012K018 = (int?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				PCT012K019 = (int?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				PCT012K020 = (int?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				PCT012K021 = (int?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				PCT012K022 = (int?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				PCT012K023 = (int?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				PCT012K024 = (int?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				PCT012K025 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				PCT012K026 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				PCT012K027 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				PCT012K028 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				PCT012K029 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				PCT012K030 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				PCT012K031 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				PCT012K032 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				PCT012K033 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				PCT012K034 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				PCT012K035 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				PCT012K036 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				PCT012K037 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				PCT012K038 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				PCT012K039 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				PCT012K040 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				PCT012K041 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				PCT012K042 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				PCT012K043 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				PCT012K044 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				PCT012K045 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				PCT012K046 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				PCT012K047 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				PCT012K048 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				PCT012K049 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				PCT012K050 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				PCT012K051 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				PCT012K052 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				PCT012K053 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				PCT012K054 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				PCT012K055 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				PCT012K056 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				PCT012K057 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				PCT012K058 = (int?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				PCT012K059 = (int?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				PCT012K060 = (int?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				PCT012K061 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				PCT012K062 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				PCT012K063 = (int?)reader[67];
			}
			if (reader[68] != DBNull.Value)
			{
				PCT012K064 = (int?)reader[68];
			}
			if (reader[69] != DBNull.Value)
			{
				PCT012K065 = (int?)reader[69];
			}
			if (reader[70] != DBNull.Value)
			{
				PCT012K066 = (int?)reader[70];
			}
			if (reader[71] != DBNull.Value)
			{
				PCT012K067 = (int?)reader[71];
			}
			if (reader[72] != DBNull.Value)
			{
				PCT012K068 = (int?)reader[72];
			}
			if (reader[73] != DBNull.Value)
			{
				PCT012K069 = (int?)reader[73];
			}
			if (reader[74] != DBNull.Value)
			{
				PCT012K070 = (int?)reader[74];
			}
			if (reader[75] != DBNull.Value)
			{
				PCT012K071 = (int?)reader[75];
			}
			if (reader[76] != DBNull.Value)
			{
				PCT012K072 = (int?)reader[76];
			}
			if (reader[77] != DBNull.Value)
			{
				PCT012K073 = (int?)reader[77];
			}
			if (reader[78] != DBNull.Value)
			{
				PCT012K074 = (int?)reader[78];
			}
			if (reader[79] != DBNull.Value)
			{
				PCT012K075 = (int?)reader[79];
			}
			if (reader[80] != DBNull.Value)
			{
				PCT012K076 = (int?)reader[80];
			}
			if (reader[81] != DBNull.Value)
			{
				PCT012K077 = (int?)reader[81];
			}
			if (reader[82] != DBNull.Value)
			{
				PCT012K078 = (int?)reader[82];
			}
			if (reader[83] != DBNull.Value)
			{
				PCT012K079 = (int?)reader[83];
			}
			if (reader[84] != DBNull.Value)
			{
				PCT012K080 = (int?)reader[84];
			}
			if (reader[85] != DBNull.Value)
			{
				PCT012K081 = (int?)reader[85];
			}
			if (reader[86] != DBNull.Value)
			{
				PCT012K082 = (int?)reader[86];
			}
			if (reader[87] != DBNull.Value)
			{
				PCT012K083 = (int?)reader[87];
			}
			if (reader[88] != DBNull.Value)
			{
				PCT012K084 = (int?)reader[88];
			}
			if (reader[89] != DBNull.Value)
			{
				PCT012K085 = (int?)reader[89];
			}
			if (reader[90] != DBNull.Value)
			{
				PCT012K086 = (int?)reader[90];
			}
			if (reader[91] != DBNull.Value)
			{
				PCT012K087 = (int?)reader[91];
			}
			if (reader[92] != DBNull.Value)
			{
				PCT012K088 = (int?)reader[92];
			}
			if (reader[93] != DBNull.Value)
			{
				PCT012K089 = (int?)reader[93];
			}
			if (reader[94] != DBNull.Value)
			{
				PCT012K090 = (int?)reader[94];
			}
			if (reader[95] != DBNull.Value)
			{
				PCT012K091 = (int?)reader[95];
			}
			if (reader[96] != DBNull.Value)
			{
				PCT012K092 = (int?)reader[96];
			}
			if (reader[97] != DBNull.Value)
			{
				PCT012K093 = (int?)reader[97];
			}
			if (reader[98] != DBNull.Value)
			{
				PCT012K094 = (int?)reader[98];
			}
			if (reader[99] != DBNull.Value)
			{
				PCT012K095 = (int?)reader[99];
			}
			if (reader[100] != DBNull.Value)
			{
				PCT012K096 = (int?)reader[100];
			}
			if (reader[101] != DBNull.Value)
			{
				PCT012K097 = (int?)reader[101];
			}
			if (reader[102] != DBNull.Value)
			{
				PCT012K098 = (int?)reader[102];
			}
			if (reader[103] != DBNull.Value)
			{
				PCT012K099 = (int?)reader[103];
			}
			if (reader[104] != DBNull.Value)
			{
				PCT012K100 = (int?)reader[104];
			}
			if (reader[105] != DBNull.Value)
			{
				PCT012K101 = (int?)reader[105];
			}
			if (reader[106] != DBNull.Value)
			{
				PCT012K102 = (int?)reader[106];
			}
			if (reader[107] != DBNull.Value)
			{
				PCT012K103 = (int?)reader[107];
			}
			if (reader[108] != DBNull.Value)
			{
				PCT012K104 = (int?)reader[108];
			}
			if (reader[109] != DBNull.Value)
			{
				PCT012K105 = (int?)reader[109];
			}
			if (reader[110] != DBNull.Value)
			{
				PCT012K106 = (int?)reader[110];
			}
			if (reader[111] != DBNull.Value)
			{
				PCT012K107 = (int?)reader[111];
			}
			if (reader[112] != DBNull.Value)
			{
				PCT012K108 = (int?)reader[112];
			}
			if (reader[113] != DBNull.Value)
			{
				PCT012K109 = (int?)reader[113];
			}
			if (reader[114] != DBNull.Value)
			{
				PCT012K110 = (int?)reader[114];
			}
			if (reader[115] != DBNull.Value)
			{
				PCT012K111 = (int?)reader[115];
			}
			if (reader[116] != DBNull.Value)
			{
				PCT012K112 = (int?)reader[116];
			}
			if (reader[117] != DBNull.Value)
			{
				PCT012K113 = (int?)reader[117];
			}
			if (reader[118] != DBNull.Value)
			{
				PCT012K114 = (int?)reader[118];
			}
			if (reader[119] != DBNull.Value)
			{
				PCT012K115 = (int?)reader[119];
			}
			if (reader[120] != DBNull.Value)
			{
				PCT012K116 = (int?)reader[120];
			}
			if (reader[121] != DBNull.Value)
			{
				PCT012K117 = (int?)reader[121];
			}
			if (reader[122] != DBNull.Value)
			{
				PCT012K118 = (int?)reader[122];
			}
			if (reader[123] != DBNull.Value)
			{
				PCT012K119 = (int?)reader[123];
			}
			if (reader[124] != DBNull.Value)
			{
				PCT012K120 = (int?)reader[124];
			}
			if (reader[125] != DBNull.Value)
			{
				PCT012K121 = (int?)reader[125];
			}
			if (reader[126] != DBNull.Value)
			{
				PCT012K122 = (int?)reader[126];
			}
			if (reader[127] != DBNull.Value)
			{
				PCT012K123 = (int?)reader[127];
			}
			if (reader[128] != DBNull.Value)
			{
				PCT012K124 = (int?)reader[128];
			}
			if (reader[129] != DBNull.Value)
			{
				PCT012K125 = (int?)reader[129];
			}
			if (reader[130] != DBNull.Value)
			{
				PCT012K126 = (int?)reader[130];
			}
			if (reader[131] != DBNull.Value)
			{
				PCT012K127 = (int?)reader[131];
			}
			if (reader[132] != DBNull.Value)
			{
				PCT012K128 = (int?)reader[132];
			}
			if (reader[133] != DBNull.Value)
			{
				PCT012K129 = (int?)reader[133];
			}
			if (reader[134] != DBNull.Value)
			{
				PCT012K130 = (int?)reader[134];
			}
			if (reader[135] != DBNull.Value)
			{
				PCT012K131 = (int?)reader[135];
			}
			if (reader[136] != DBNull.Value)
			{
				PCT012K132 = (int?)reader[136];
			}
			if (reader[137] != DBNull.Value)
			{
				PCT012K133 = (int?)reader[137];
			}
			if (reader[138] != DBNull.Value)
			{
				PCT012K134 = (int?)reader[138];
			}
			if (reader[139] != DBNull.Value)
			{
				PCT012K135 = (int?)reader[139];
			}
			if (reader[140] != DBNull.Value)
			{
				PCT012K136 = (int?)reader[140];
			}
			if (reader[141] != DBNull.Value)
			{
				PCT012K137 = (int?)reader[141];
			}
			if (reader[142] != DBNull.Value)
			{
				PCT012K138 = (int?)reader[142];
			}
			if (reader[143] != DBNull.Value)
			{
				PCT012K139 = (int?)reader[143];
			}
			if (reader[144] != DBNull.Value)
			{
				PCT012K140 = (int?)reader[144];
			}
			if (reader[145] != DBNull.Value)
			{
				PCT012K141 = (int?)reader[145];
			}
			if (reader[146] != DBNull.Value)
			{
				PCT012K142 = (int?)reader[146];
			}
			if (reader[147] != DBNull.Value)
			{
				PCT012K143 = (int?)reader[147];
			}
			if (reader[148] != DBNull.Value)
			{
				PCT012K144 = (int?)reader[148];
			}
			if (reader[149] != DBNull.Value)
			{
				PCT012K145 = (int?)reader[149];
			}
			if (reader[150] != DBNull.Value)
			{
				PCT012K146 = (int?)reader[150];
			}
			if (reader[151] != DBNull.Value)
			{
				PCT012K147 = (int?)reader[151];
			}
			if (reader[152] != DBNull.Value)
			{
				PCT012K148 = (int?)reader[152];
			}
			if (reader[153] != DBNull.Value)
			{
				PCT012K149 = (int?)reader[153];
			}
			if (reader[154] != DBNull.Value)
			{
				PCT012K150 = (int?)reader[154];
			}
			if (reader[155] != DBNull.Value)
			{
				PCT012K151 = (int?)reader[155];
			}
			if (reader[156] != DBNull.Value)
			{
				PCT012K152 = (int?)reader[156];
			}
			if (reader[157] != DBNull.Value)
			{
				PCT012K153 = (int?)reader[157];
			}
			if (reader[158] != DBNull.Value)
			{
				PCT012K154 = (int?)reader[158];
			}
			if (reader[159] != DBNull.Value)
			{
				PCT012K155 = (int?)reader[159];
			}
			if (reader[160] != DBNull.Value)
			{
				PCT012K156 = (int?)reader[160];
			}
			if (reader[161] != DBNull.Value)
			{
				PCT012K157 = (int?)reader[161];
			}
			if (reader[162] != DBNull.Value)
			{
				PCT012K158 = (int?)reader[162];
			}
			if (reader[163] != DBNull.Value)
			{
				PCT012K159 = (int?)reader[163];
			}
			if (reader[164] != DBNull.Value)
			{
				PCT012K160 = (int?)reader[164];
			}
			if (reader[165] != DBNull.Value)
			{
				PCT012K161 = (int?)reader[165];
			}
			if (reader[166] != DBNull.Value)
			{
				PCT012K162 = (int?)reader[166];
			}
			if (reader[167] != DBNull.Value)
			{
				PCT012K163 = (int?)reader[167];
			}
			if (reader[168] != DBNull.Value)
			{
				PCT012K164 = (int?)reader[168];
			}
			if (reader[169] != DBNull.Value)
			{
				PCT012K165 = (int?)reader[169];
			}
			if (reader[170] != DBNull.Value)
			{
				PCT012K166 = (int?)reader[170];
			}
			if (reader[171] != DBNull.Value)
			{
				PCT012K167 = (int?)reader[171];
			}
			if (reader[172] != DBNull.Value)
			{
				PCT012K168 = (int?)reader[172];
			}
			if (reader[173] != DBNull.Value)
			{
				PCT012K169 = (int?)reader[173];
			}
			if (reader[174] != DBNull.Value)
			{
				PCT012K170 = (int?)reader[174];
			}
			if (reader[175] != DBNull.Value)
			{
				PCT012K171 = (int?)reader[175];
			}
			if (reader[176] != DBNull.Value)
			{
				PCT012K172 = (int?)reader[176];
			}
			if (reader[177] != DBNull.Value)
			{
				PCT012K173 = (int?)reader[177];
			}
			if (reader[178] != DBNull.Value)
			{
				PCT012K174 = (int?)reader[178];
			}
			if (reader[179] != DBNull.Value)
			{
				PCT012K175 = (int?)reader[179];
			}
			if (reader[180] != DBNull.Value)
			{
				PCT012K176 = (int?)reader[180];
			}
			if (reader[181] != DBNull.Value)
			{
				PCT012K177 = (int?)reader[181];
			}
			if (reader[182] != DBNull.Value)
			{
				PCT012K178 = (int?)reader[182];
			}
			if (reader[183] != DBNull.Value)
			{
				PCT012K179 = (int?)reader[183];
			}
			if (reader[184] != DBNull.Value)
			{
				PCT012K180 = (int?)reader[184];
			}
			if (reader[185] != DBNull.Value)
			{
				PCT012K181 = (int?)reader[185];
			}
			if (reader[186] != DBNull.Value)
			{
				PCT012K182 = (int?)reader[186];
			}
			if (reader[187] != DBNull.Value)
			{
				PCT012K183 = (int?)reader[187];
			}
			if (reader[188] != DBNull.Value)
			{
				PCT012K184 = (int?)reader[188];
			}
			if (reader[189] != DBNull.Value)
			{
				PCT012K185 = (int?)reader[189];
			}
			if (reader[190] != DBNull.Value)
			{
				PCT012K186 = (int?)reader[190];
			}
			if (reader[191] != DBNull.Value)
			{
				PCT012K187 = (int?)reader[191];
			}
			if (reader[192] != DBNull.Value)
			{
				PCT012K188 = (int?)reader[192];
			}
			if (reader[193] != DBNull.Value)
			{
				PCT012K189 = (int?)reader[193];
			}
			if (reader[194] != DBNull.Value)
			{
				PCT012K190 = (int?)reader[194];
			}
			if (reader[195] != DBNull.Value)
			{
				PCT012K191 = (int?)reader[195];
			}
			if (reader[196] != DBNull.Value)
			{
				PCT012K192 = (int?)reader[196];
			}
			if (reader[197] != DBNull.Value)
			{
				PCT012K193 = (int?)reader[197];
			}
			if (reader[198] != DBNull.Value)
			{
				PCT012K194 = (int?)reader[198];
			}
			if (reader[199] != DBNull.Value)
			{
				PCT012K195 = (int?)reader[199];
			}
			if (reader[200] != DBNull.Value)
			{
				PCT012K196 = (int?)reader[200];
			}
			if (reader[201] != DBNull.Value)
			{
				PCT012K197 = (int?)reader[201];
			}
			if (reader[202] != DBNull.Value)
			{
				PCT012K198 = (int?)reader[202];
			}
			if (reader[203] != DBNull.Value)
			{
				PCT012K199 = (int?)reader[203];
			}
			if (reader[204] != DBNull.Value)
			{
				PCT012K200 = (int?)reader[204];
			}
			if (reader[205] != DBNull.Value)
			{
				PCT012K201 = (int?)reader[205];
			}
			if (reader[206] != DBNull.Value)
			{
				PCT012K202 = (int?)reader[206];
			}
			if (reader[207] != DBNull.Value)
			{
				PCT012K203 = (int?)reader[207];
			}
			if (reader[208] != DBNull.Value)
			{
				PCT012K204 = (int?)reader[208];
			}
			if (reader[209] != DBNull.Value)
			{
				PCT012K205 = (int?)reader[209];
			}
			if (reader[210] != DBNull.Value)
			{
				PCT012K206 = (int?)reader[210];
			}
			if (reader[211] != DBNull.Value)
			{
				PCT012K207 = (int?)reader[211];
			}
			if (reader[212] != DBNull.Value)
			{
				PCT012K208 = (int?)reader[212];
			}
			if (reader[213] != DBNull.Value)
			{
				PCT012K209 = (int?)reader[213];
			}
		}
		#endregion Constructors
	}
}
