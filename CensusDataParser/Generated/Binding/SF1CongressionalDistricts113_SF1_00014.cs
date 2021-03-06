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

	public class SF1CongressionalDistricts113_SF1_00014 : BaseModel
	{
		#region Properties
		[Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
		public string FILEID { get; set; }

		[Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
		public string STUSAB { get; set; }

		[Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
		public int CHARITER { get; set; }

		[Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
		public int CIFSN { get; set; }

		[Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
		public int LOGRECNO { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 5)]
		public int? P039I001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 6)]
		public int? P039I002 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 7)]
		public int? P039I003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 8)]
		public int? P039I004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 9)]
		public int? P039I005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 10)]
		public int? P039I006 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 11)]
		public int? P039I007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 12)]
		public int? P039I008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 13)]
		public int? P039I009 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 14)]
		public int? P039I010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 15)]
		public int? P039I011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 16)]
		public int? P039I012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 17)]
		public int? P039I013 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 18)]
		public int? P039I014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 19)]
		public int? P039I015 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 20)]
		public int? P039I016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 21)]
		public int? P039I017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 22)]
		public int? P039I018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 23)]
		public int? P039I019 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 24)]
		public int? P039I020 { get; set; }
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_SF1_00014() { }

		public SF1CongressionalDistricts113_SF1_00014(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_SF1_00014(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_SF1_00014(OleDbDataReader reader)
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
				CHARITER = (int)reader[2];
			}
			if(reader[3] != DBNull.Value)
			{
				CIFSN = (int)reader[3];
			}
			if(reader[4] != DBNull.Value)
			{
				LOGRECNO = (int)reader[4];
			}
			if(reader[5] != DBNull.Value)
			{
				P039I001 = (int?)reader[5];
			}
			if(reader[6] != DBNull.Value)
			{
				P039I002 = (int?)reader[6];
			}
			if(reader[7] != DBNull.Value)
			{
				P039I003 = (int?)reader[7];
			}
			if(reader[8] != DBNull.Value)
			{
				P039I004 = (int?)reader[8];
			}
			if(reader[9] != DBNull.Value)
			{
				P039I005 = (int?)reader[9];
			}
			if(reader[10] != DBNull.Value)
			{
				P039I006 = (int?)reader[10];
			}
			if(reader[11] != DBNull.Value)
			{
				P039I007 = (int?)reader[11];
			}
			if(reader[12] != DBNull.Value)
			{
				P039I008 = (int?)reader[12];
			}
			if(reader[13] != DBNull.Value)
			{
				P039I009 = (int?)reader[13];
			}
			if(reader[14] != DBNull.Value)
			{
				P039I010 = (int?)reader[14];
			}
			if(reader[15] != DBNull.Value)
			{
				P039I011 = (int?)reader[15];
			}
			if(reader[16] != DBNull.Value)
			{
				P039I012 = (int?)reader[16];
			}
			if(reader[17] != DBNull.Value)
			{
				P039I013 = (int?)reader[17];
			}
			if(reader[18] != DBNull.Value)
			{
				P039I014 = (int?)reader[18];
			}
			if(reader[19] != DBNull.Value)
			{
				P039I015 = (int?)reader[19];
			}
			if(reader[20] != DBNull.Value)
			{
				P039I016 = (int?)reader[20];
			}
			if(reader[21] != DBNull.Value)
			{
				P039I017 = (int?)reader[21];
			}
			if(reader[22] != DBNull.Value)
			{
				P039I018 = (int?)reader[22];
			}
			if(reader[23] != DBNull.Value)
			{
				P039I019 = (int?)reader[23];
			}
			if(reader[24] != DBNull.Value)
			{
				P039I020 = (int?)reader[24];
			}
		}
		#endregion Constructors
	}
}
