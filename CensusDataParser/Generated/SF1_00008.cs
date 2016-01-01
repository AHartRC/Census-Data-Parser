namespace CensusDataParser.Generated.CensusDataParser.Generated.SummaryOne
{
    #region Using Directives
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.OleDb;
    using Enumerators;
    #endregion Using Directives

    [Table("SF1_00008")]
    public partial class SF1_00008 : BaseModel
    {
        #region Properties
        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("FILEID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public System.String FILEID { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("STUSAB", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public System.String STUSAB { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("CHARITER", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public System.String CHARITER { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("CIFSN", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public System.String CIFSN { get; set; }

        [ReadOnly(false)]
        [Column("LOGRECNO", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public System.Nullable<System.Int32> LOGRECNO { get; set; }

        [ReadOnly(false)]
        [Column("P012F001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> P012F001 { get; set; }

        [ReadOnly(false)]
        [Column("P012F002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public System.Nullable<System.Int32> P012F002 { get; set; }

        [ReadOnly(false)]
        [Column("P012F003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 7)]
        public System.Nullable<System.Int32> P012F003 { get; set; }

        [ReadOnly(false)]
        [Column("P012F004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 8)]
        public System.Nullable<System.Int32> P012F004 { get; set; }

        [ReadOnly(false)]
        [Column("P012F005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 9)]
        public System.Nullable<System.Int32> P012F005 { get; set; }

        [ReadOnly(false)]
        [Column("P012F006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 10)]
        public System.Nullable<System.Int32> P012F006 { get; set; }

        [ReadOnly(false)]
        [Column("P012F007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 11)]
        public System.Nullable<System.Int32> P012F007 { get; set; }

        [ReadOnly(false)]
        [Column("P012F008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 12)]
        public System.Nullable<System.Int32> P012F008 { get; set; }

        [ReadOnly(false)]
        [Column("P012F009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 13)]
        public System.Nullable<System.Int32> P012F009 { get; set; }

        [ReadOnly(false)]
        [Column("P012F010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 14)]
        public System.Nullable<System.Int32> P012F010 { get; set; }

        [ReadOnly(false)]
        [Column("P012F011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 15)]
        public System.Nullable<System.Int32> P012F011 { get; set; }

        [ReadOnly(false)]
        [Column("P012F012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 16)]
        public System.Nullable<System.Int32> P012F012 { get; set; }

        [ReadOnly(false)]
        [Column("P012F013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 17)]
        public System.Nullable<System.Int32> P012F013 { get; set; }

        [ReadOnly(false)]
        [Column("P012F014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 18)]
        public System.Nullable<System.Int32> P012F014 { get; set; }

        [ReadOnly(false)]
        [Column("P012F015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 19)]
        public System.Nullable<System.Int32> P012F015 { get; set; }

        [ReadOnly(false)]
        [Column("P012F016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 20)]
        public System.Nullable<System.Int32> P012F016 { get; set; }

        [ReadOnly(false)]
        [Column("P012F017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 21)]
        public System.Nullable<System.Int32> P012F017 { get; set; }

        [ReadOnly(false)]
        [Column("P012F018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 22)]
        public System.Nullable<System.Int32> P012F018 { get; set; }

        [ReadOnly(false)]
        [Column("P012F019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 23)]
        public System.Nullable<System.Int32> P012F019 { get; set; }

        [ReadOnly(false)]
        [Column("P012F020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 24)]
        public System.Nullable<System.Int32> P012F020 { get; set; }

        [ReadOnly(false)]
        [Column("P012F021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 25)]
        public System.Nullable<System.Int32> P012F021 { get; set; }

        [ReadOnly(false)]
        [Column("P012F022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 26)]
        public System.Nullable<System.Int32> P012F022 { get; set; }

        [ReadOnly(false)]
        [Column("P012F023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 27)]
        public System.Nullable<System.Int32> P012F023 { get; set; }

        [ReadOnly(false)]
        [Column("P012F024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 28)]
        public System.Nullable<System.Int32> P012F024 { get; set; }

        [ReadOnly(false)]
        [Column("P012F025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 29)]
        public System.Nullable<System.Int32> P012F025 { get; set; }

        [ReadOnly(false)]
        [Column("P012F026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 30)]
        public System.Nullable<System.Int32> P012F026 { get; set; }

        [ReadOnly(false)]
        [Column("P012F027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 31)]
        public System.Nullable<System.Int32> P012F027 { get; set; }

        [ReadOnly(false)]
        [Column("P012F028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 32)]
        public System.Nullable<System.Int32> P012F028 { get; set; }

        [ReadOnly(false)]
        [Column("P012F029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 33)]
        public System.Nullable<System.Int32> P012F029 { get; set; }

        [ReadOnly(false)]
        [Column("P012F030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 34)]
        public System.Nullable<System.Int32> P012F030 { get; set; }

        [ReadOnly(false)]
        [Column("P012F031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 35)]
        public System.Nullable<System.Int32> P012F031 { get; set; }

        [ReadOnly(false)]
        [Column("P012F032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 36)]
        public System.Nullable<System.Int32> P012F032 { get; set; }

        [ReadOnly(false)]
        [Column("P012F033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 37)]
        public System.Nullable<System.Int32> P012F033 { get; set; }

        [ReadOnly(false)]
        [Column("P012F034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 38)]
        public System.Nullable<System.Int32> P012F034 { get; set; }

        [ReadOnly(false)]
        [Column("P012F035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 39)]
        public System.Nullable<System.Int32> P012F035 { get; set; }

        [ReadOnly(false)]
        [Column("P012F036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 40)]
        public System.Nullable<System.Int32> P012F036 { get; set; }

        [ReadOnly(false)]
        [Column("P012F037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 41)]
        public System.Nullable<System.Int32> P012F037 { get; set; }

        [ReadOnly(false)]
        [Column("P012F038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 42)]
        public System.Nullable<System.Int32> P012F038 { get; set; }

        [ReadOnly(false)]
        [Column("P012F039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 43)]
        public System.Nullable<System.Int32> P012F039 { get; set; }

        [ReadOnly(false)]
        [Column("P012F040", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 44)]
        public System.Nullable<System.Int32> P012F040 { get; set; }

        [ReadOnly(false)]
        [Column("P012F041", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 45)]
        public System.Nullable<System.Int32> P012F041 { get; set; }

        [ReadOnly(false)]
        [Column("P012F042", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 46)]
        public System.Nullable<System.Int32> P012F042 { get; set; }

        [ReadOnly(false)]
        [Column("P012F043", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 47)]
        public System.Nullable<System.Int32> P012F043 { get; set; }

        [ReadOnly(false)]
        [Column("P012F044", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 48)]
        public System.Nullable<System.Int32> P012F044 { get; set; }

        [ReadOnly(false)]
        [Column("P012F045", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 49)]
        public System.Nullable<System.Int32> P012F045 { get; set; }

        [ReadOnly(false)]
        [Column("P012F046", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 50)]
        public System.Nullable<System.Int32> P012F046 { get; set; }

        [ReadOnly(false)]
        [Column("P012F047", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 51)]
        public System.Nullable<System.Int32> P012F047 { get; set; }

        [ReadOnly(false)]
        [Column("P012F048", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 52)]
        public System.Nullable<System.Int32> P012F048 { get; set; }

        [ReadOnly(false)]
        [Column("P012F049", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 53)]
        public System.Nullable<System.Int32> P012F049 { get; set; }

        [ReadOnly(false)]
        [Column("P012G001", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 54)]
        public System.Nullable<System.Int32> P012G001 { get; set; }

        [ReadOnly(false)]
        [Column("P012G002", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 55)]
        public System.Nullable<System.Int32> P012G002 { get; set; }

        [ReadOnly(false)]
        [Column("P012G003", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 56)]
        public System.Nullable<System.Int32> P012G003 { get; set; }

        [ReadOnly(false)]
        [Column("P012G004", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 57)]
        public System.Nullable<System.Int32> P012G004 { get; set; }

        [ReadOnly(false)]
        [Column("P012G005", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 58)]
        public System.Nullable<System.Int32> P012G005 { get; set; }

        [ReadOnly(false)]
        [Column("P012G006", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 59)]
        public System.Nullable<System.Int32> P012G006 { get; set; }

        [ReadOnly(false)]
        [Column("P012G007", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 60)]
        public System.Nullable<System.Int32> P012G007 { get; set; }

        [ReadOnly(false)]
        [Column("P012G008", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 61)]
        public System.Nullable<System.Int32> P012G008 { get; set; }

        [ReadOnly(false)]
        [Column("P012G009", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 62)]
        public System.Nullable<System.Int32> P012G009 { get; set; }

        [ReadOnly(false)]
        [Column("P012G010", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 63)]
        public System.Nullable<System.Int32> P012G010 { get; set; }

        [ReadOnly(false)]
        [Column("P012G011", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 64)]
        public System.Nullable<System.Int32> P012G011 { get; set; }

        [ReadOnly(false)]
        [Column("P012G012", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 65)]
        public System.Nullable<System.Int32> P012G012 { get; set; }

        [ReadOnly(false)]
        [Column("P012G013", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 66)]
        public System.Nullable<System.Int32> P012G013 { get; set; }

        [ReadOnly(false)]
        [Column("P012G014", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 67)]
        public System.Nullable<System.Int32> P012G014 { get; set; }

        [ReadOnly(false)]
        [Column("P012G015", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 68)]
        public System.Nullable<System.Int32> P012G015 { get; set; }

        [ReadOnly(false)]
        [Column("P012G016", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 69)]
        public System.Nullable<System.Int32> P012G016 { get; set; }

        [ReadOnly(false)]
        [Column("P012G017", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 70)]
        public System.Nullable<System.Int32> P012G017 { get; set; }

        [ReadOnly(false)]
        [Column("P012G018", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 71)]
        public System.Nullable<System.Int32> P012G018 { get; set; }

        [ReadOnly(false)]
        [Column("P012G019", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 72)]
        public System.Nullable<System.Int32> P012G019 { get; set; }

        [ReadOnly(false)]
        [Column("P012G020", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 73)]
        public System.Nullable<System.Int32> P012G020 { get; set; }

        [ReadOnly(false)]
        [Column("P012G021", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 74)]
        public System.Nullable<System.Int32> P012G021 { get; set; }

        [ReadOnly(false)]
        [Column("P012G022", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 75)]
        public System.Nullable<System.Int32> P012G022 { get; set; }

        [ReadOnly(false)]
        [Column("P012G023", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 76)]
        public System.Nullable<System.Int32> P012G023 { get; set; }

        [ReadOnly(false)]
        [Column("P012G024", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 77)]
        public System.Nullable<System.Int32> P012G024 { get; set; }

        [ReadOnly(false)]
        [Column("P012G025", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 78)]
        public System.Nullable<System.Int32> P012G025 { get; set; }

        [ReadOnly(false)]
        [Column("P012G026", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 79)]
        public System.Nullable<System.Int32> P012G026 { get; set; }

        [ReadOnly(false)]
        [Column("P012G027", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 80)]
        public System.Nullable<System.Int32> P012G027 { get; set; }

        [ReadOnly(false)]
        [Column("P012G028", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 81)]
        public System.Nullable<System.Int32> P012G028 { get; set; }

        [ReadOnly(false)]
        [Column("P012G029", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 82)]
        public System.Nullable<System.Int32> P012G029 { get; set; }

        [ReadOnly(false)]
        [Column("P012G030", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 83)]
        public System.Nullable<System.Int32> P012G030 { get; set; }

        [ReadOnly(false)]
        [Column("P012G031", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 84)]
        public System.Nullable<System.Int32> P012G031 { get; set; }

        [ReadOnly(false)]
        [Column("P012G032", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 85)]
        public System.Nullable<System.Int32> P012G032 { get; set; }

        [ReadOnly(false)]
        [Column("P012G033", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 86)]
        public System.Nullable<System.Int32> P012G033 { get; set; }

        [ReadOnly(false)]
        [Column("P012G034", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 87)]
        public System.Nullable<System.Int32> P012G034 { get; set; }

        [ReadOnly(false)]
        [Column("P012G035", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 88)]
        public System.Nullable<System.Int32> P012G035 { get; set; }

        [ReadOnly(false)]
        [Column("P012G036", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 89)]
        public System.Nullable<System.Int32> P012G036 { get; set; }

        [ReadOnly(false)]
        [Column("P012G037", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 90)]
        public System.Nullable<System.Int32> P012G037 { get; set; }

        [ReadOnly(false)]
        [Column("P012G038", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 91)]
        public System.Nullable<System.Int32> P012G038 { get; set; }

        [ReadOnly(false)]
        [Column("P012G039", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 92)]
        public System.Nullable<System.Int32> P012G039 { get; set; }

        [ReadOnly(false)]
        [Column("P012G040", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 93)]
        public System.Nullable<System.Int32> P012G040 { get; set; }

        [ReadOnly(false)]
        [Column("P012G041", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 94)]
        public System.Nullable<System.Int32> P012G041 { get; set; }

        [ReadOnly(false)]
        [Column("P012G042", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 95)]
        public System.Nullable<System.Int32> P012G042 { get; set; }

        [ReadOnly(false)]
        [Column("P012G043", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 96)]
        public System.Nullable<System.Int32> P012G043 { get; set; }

        [ReadOnly(false)]
        [Column("P012G044", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 97)]
        public System.Nullable<System.Int32> P012G044 { get; set; }

        [ReadOnly(false)]
        [Column("P012G045", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 98)]
        public System.Nullable<System.Int32> P012G045 { get; set; }

        [ReadOnly(false)]
        [Column("P012G046", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 99)]
        public System.Nullable<System.Int32> P012G046 { get; set; }

        [ReadOnly(false)]
        [Column("P012G047", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 100)]
        public System.Nullable<System.Int32> P012G047 { get; set; }

        [ReadOnly(false)]
        [Column("P012G048", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 101)]
        public System.Nullable<System.Int32> P012G048 { get; set; }

        [ReadOnly(false)]
        [Column("P012G049", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 102)]
        public System.Nullable<System.Int32> P012G049 { get; set; }

        [ReadOnly(false)]
        [Column("P012H001", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 103)]
        public System.Nullable<System.Int32> P012H001 { get; set; }

        [ReadOnly(false)]
        [Column("P012H002", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 104)]
        public System.Nullable<System.Int32> P012H002 { get; set; }

        [ReadOnly(false)]
        [Column("P012H003", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 105)]
        public System.Nullable<System.Int32> P012H003 { get; set; }

        [ReadOnly(false)]
        [Column("P012H004", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 106)]
        public System.Nullable<System.Int32> P012H004 { get; set; }

        [ReadOnly(false)]
        [Column("P012H005", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 107)]
        public System.Nullable<System.Int32> P012H005 { get; set; }

        [ReadOnly(false)]
        [Column("P012H006", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 108)]
        public System.Nullable<System.Int32> P012H006 { get; set; }

        [ReadOnly(false)]
        [Column("P012H007", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 109)]
        public System.Nullable<System.Int32> P012H007 { get; set; }

        [ReadOnly(false)]
        [Column("P012H008", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 110)]
        public System.Nullable<System.Int32> P012H008 { get; set; }

        [ReadOnly(false)]
        [Column("P012H009", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 111)]
        public System.Nullable<System.Int32> P012H009 { get; set; }

        [ReadOnly(false)]
        [Column("P012H010", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 112)]
        public System.Nullable<System.Int32> P012H010 { get; set; }

        [ReadOnly(false)]
        [Column("P012H011", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 113)]
        public System.Nullable<System.Int32> P012H011 { get; set; }

        [ReadOnly(false)]
        [Column("P012H012", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 114)]
        public System.Nullable<System.Int32> P012H012 { get; set; }

        [ReadOnly(false)]
        [Column("P012H013", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 115)]
        public System.Nullable<System.Int32> P012H013 { get; set; }

        [ReadOnly(false)]
        [Column("P012H014", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 116)]
        public System.Nullable<System.Int32> P012H014 { get; set; }

        [ReadOnly(false)]
        [Column("P012H015", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 117)]
        public System.Nullable<System.Int32> P012H015 { get; set; }

        [ReadOnly(false)]
        [Column("P012H016", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 118)]
        public System.Nullable<System.Int32> P012H016 { get; set; }

        [ReadOnly(false)]
        [Column("P012H017", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 119)]
        public System.Nullable<System.Int32> P012H017 { get; set; }

        [ReadOnly(false)]
        [Column("P012H018", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 120)]
        public System.Nullable<System.Int32> P012H018 { get; set; }

        [ReadOnly(false)]
        [Column("P012H019", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 121)]
        public System.Nullable<System.Int32> P012H019 { get; set; }

        [ReadOnly(false)]
        [Column("P012H020", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 122)]
        public System.Nullable<System.Int32> P012H020 { get; set; }

        [ReadOnly(false)]
        [Column("P012H021", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 123)]
        public System.Nullable<System.Int32> P012H021 { get; set; }

        [ReadOnly(false)]
        [Column("P012H022", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 124)]
        public System.Nullable<System.Int32> P012H022 { get; set; }

        [ReadOnly(false)]
        [Column("P012H023", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 125)]
        public System.Nullable<System.Int32> P012H023 { get; set; }

        [ReadOnly(false)]
        [Column("P012H024", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 126)]
        public System.Nullable<System.Int32> P012H024 { get; set; }

        [ReadOnly(false)]
        [Column("P012H025", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 127)]
        public System.Nullable<System.Int32> P012H025 { get; set; }

        [ReadOnly(false)]
        [Column("P012H026", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 128)]
        public System.Nullable<System.Int32> P012H026 { get; set; }

        [ReadOnly(false)]
        [Column("P012H027", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 129)]
        public System.Nullable<System.Int32> P012H027 { get; set; }

        [ReadOnly(false)]
        [Column("P012H028", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 130)]
        public System.Nullable<System.Int32> P012H028 { get; set; }

        [ReadOnly(false)]
        [Column("P012H029", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 131)]
        public System.Nullable<System.Int32> P012H029 { get; set; }

        [ReadOnly(false)]
        [Column("P012H030", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 132)]
        public System.Nullable<System.Int32> P012H030 { get; set; }

        [ReadOnly(false)]
        [Column("P012H031", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 133)]
        public System.Nullable<System.Int32> P012H031 { get; set; }

        [ReadOnly(false)]
        [Column("P012H032", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 134)]
        public System.Nullable<System.Int32> P012H032 { get; set; }

        [ReadOnly(false)]
        [Column("P012H033", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 135)]
        public System.Nullable<System.Int32> P012H033 { get; set; }

        [ReadOnly(false)]
        [Column("P012H034", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 136)]
        public System.Nullable<System.Int32> P012H034 { get; set; }

        [ReadOnly(false)]
        [Column("P012H035", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 137)]
        public System.Nullable<System.Int32> P012H035 { get; set; }

        [ReadOnly(false)]
        [Column("P012H036", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 138)]
        public System.Nullable<System.Int32> P012H036 { get; set; }

        [ReadOnly(false)]
        [Column("P012H037", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 139)]
        public System.Nullable<System.Int32> P012H037 { get; set; }

        [ReadOnly(false)]
        [Column("P012H038", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 140)]
        public System.Nullable<System.Int32> P012H038 { get; set; }

        [ReadOnly(false)]
        [Column("P012H039", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 141)]
        public System.Nullable<System.Int32> P012H039 { get; set; }

        [ReadOnly(false)]
        [Column("P012H040", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 142)]
        public System.Nullable<System.Int32> P012H040 { get; set; }

        [ReadOnly(false)]
        [Column("P012H041", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 143)]
        public System.Nullable<System.Int32> P012H041 { get; set; }

        [ReadOnly(false)]
        [Column("P012H042", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 144)]
        public System.Nullable<System.Int32> P012H042 { get; set; }

        [ReadOnly(false)]
        [Column("P012H043", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 145)]
        public System.Nullable<System.Int32> P012H043 { get; set; }

        [ReadOnly(false)]
        [Column("P012H044", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 146)]
        public System.Nullable<System.Int32> P012H044 { get; set; }

        [ReadOnly(false)]
        [Column("P012H045", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 147)]
        public System.Nullable<System.Int32> P012H045 { get; set; }

        [ReadOnly(false)]
        [Column("P012H046", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 148)]
        public System.Nullable<System.Int32> P012H046 { get; set; }

        [ReadOnly(false)]
        [Column("P012H047", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 149)]
        public System.Nullable<System.Int32> P012H047 { get; set; }

        [ReadOnly(false)]
        [Column("P012H048", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 150)]
        public System.Nullable<System.Int32> P012H048 { get; set; }

        [ReadOnly(false)]
        [Column("P012H049", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 151)]
        public System.Nullable<System.Int32> P012H049 { get; set; }

        [ReadOnly(false)]
        [Column("P012I001", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 152)]
        public System.Nullable<System.Int32> P012I001 { get; set; }

        [ReadOnly(false)]
        [Column("P012I002", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 153)]
        public System.Nullable<System.Int32> P012I002 { get; set; }

        [ReadOnly(false)]
        [Column("P012I003", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 154)]
        public System.Nullable<System.Int32> P012I003 { get; set; }

        [ReadOnly(false)]
        [Column("P012I004", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 155)]
        public System.Nullable<System.Int32> P012I004 { get; set; }

        [ReadOnly(false)]
        [Column("P012I005", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 156)]
        public System.Nullable<System.Int32> P012I005 { get; set; }

        [ReadOnly(false)]
        [Column("P012I006", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 157)]
        public System.Nullable<System.Int32> P012I006 { get; set; }

        [ReadOnly(false)]
        [Column("P012I007", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 158)]
        public System.Nullable<System.Int32> P012I007 { get; set; }

        [ReadOnly(false)]
        [Column("P012I008", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 159)]
        public System.Nullable<System.Int32> P012I008 { get; set; }

        [ReadOnly(false)]
        [Column("P012I009", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 160)]
        public System.Nullable<System.Int32> P012I009 { get; set; }

        [ReadOnly(false)]
        [Column("P012I010", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 161)]
        public System.Nullable<System.Int32> P012I010 { get; set; }

        [ReadOnly(false)]
        [Column("P012I011", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 162)]
        public System.Nullable<System.Int32> P012I011 { get; set; }

        [ReadOnly(false)]
        [Column("P012I012", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 163)]
        public System.Nullable<System.Int32> P012I012 { get; set; }

        [ReadOnly(false)]
        [Column("P012I013", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 164)]
        public System.Nullable<System.Int32> P012I013 { get; set; }

        [ReadOnly(false)]
        [Column("P012I014", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 165)]
        public System.Nullable<System.Int32> P012I014 { get; set; }

        [ReadOnly(false)]
        [Column("P012I015", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 166)]
        public System.Nullable<System.Int32> P012I015 { get; set; }

        [ReadOnly(false)]
        [Column("P012I016", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 167)]
        public System.Nullable<System.Int32> P012I016 { get; set; }

        [ReadOnly(false)]
        [Column("P012I017", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 168)]
        public System.Nullable<System.Int32> P012I017 { get; set; }

        [ReadOnly(false)]
        [Column("P012I018", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 169)]
        public System.Nullable<System.Int32> P012I018 { get; set; }

        [ReadOnly(false)]
        [Column("P012I019", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 170)]
        public System.Nullable<System.Int32> P012I019 { get; set; }

        [ReadOnly(false)]
        [Column("P012I020", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 171)]
        public System.Nullable<System.Int32> P012I020 { get; set; }

        [ReadOnly(false)]
        [Column("P012I021", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 172)]
        public System.Nullable<System.Int32> P012I021 { get; set; }

        [ReadOnly(false)]
        [Column("P012I022", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 173)]
        public System.Nullable<System.Int32> P012I022 { get; set; }

        [ReadOnly(false)]
        [Column("P012I023", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 174)]
        public System.Nullable<System.Int32> P012I023 { get; set; }

        [ReadOnly(false)]
        [Column("P012I024", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 175)]
        public System.Nullable<System.Int32> P012I024 { get; set; }

        [ReadOnly(false)]
        [Column("P012I025", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 176)]
        public System.Nullable<System.Int32> P012I025 { get; set; }

        [ReadOnly(false)]
        [Column("P012I026", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 177)]
        public System.Nullable<System.Int32> P012I026 { get; set; }

        [ReadOnly(false)]
        [Column("P012I027", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 178)]
        public System.Nullable<System.Int32> P012I027 { get; set; }

        [ReadOnly(false)]
        [Column("P012I028", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 179)]
        public System.Nullable<System.Int32> P012I028 { get; set; }

        [ReadOnly(false)]
        [Column("P012I029", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 180)]
        public System.Nullable<System.Int32> P012I029 { get; set; }

        [ReadOnly(false)]
        [Column("P012I030", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 181)]
        public System.Nullable<System.Int32> P012I030 { get; set; }

        [ReadOnly(false)]
        [Column("P012I031", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 182)]
        public System.Nullable<System.Int32> P012I031 { get; set; }

        [ReadOnly(false)]
        [Column("P012I032", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 183)]
        public System.Nullable<System.Int32> P012I032 { get; set; }

        [ReadOnly(false)]
        [Column("P012I033", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 184)]
        public System.Nullable<System.Int32> P012I033 { get; set; }

        [ReadOnly(false)]
        [Column("P012I034", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 185)]
        public System.Nullable<System.Int32> P012I034 { get; set; }

        [ReadOnly(false)]
        [Column("P012I035", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 186)]
        public System.Nullable<System.Int32> P012I035 { get; set; }

        [ReadOnly(false)]
        [Column("P012I036", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 187)]
        public System.Nullable<System.Int32> P012I036 { get; set; }

        [ReadOnly(false)]
        [Column("P012I037", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 188)]
        public System.Nullable<System.Int32> P012I037 { get; set; }

        [ReadOnly(false)]
        [Column("P012I038", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 189)]
        public System.Nullable<System.Int32> P012I038 { get; set; }

        [ReadOnly(false)]
        [Column("P012I039", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 190)]
        public System.Nullable<System.Int32> P012I039 { get; set; }

        [ReadOnly(false)]
        [Column("P012I040", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 191)]
        public System.Nullable<System.Int32> P012I040 { get; set; }

        [ReadOnly(false)]
        [Column("P012I041", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 192)]
        public System.Nullable<System.Int32> P012I041 { get; set; }

        [ReadOnly(false)]
        [Column("P012I042", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 193)]
        public System.Nullable<System.Int32> P012I042 { get; set; }

        [ReadOnly(false)]
        [Column("P012I043", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 194)]
        public System.Nullable<System.Int32> P012I043 { get; set; }

        [ReadOnly(false)]
        [Column("P012I044", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 195)]
        public System.Nullable<System.Int32> P012I044 { get; set; }

        [ReadOnly(false)]
        [Column("P012I045", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 196)]
        public System.Nullable<System.Int32> P012I045 { get; set; }

        [ReadOnly(false)]
        [Column("P012I046", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 197)]
        public System.Nullable<System.Int32> P012I046 { get; set; }

        [ReadOnly(false)]
        [Column("P012I047", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 198)]
        public System.Nullable<System.Int32> P012I047 { get; set; }

        [ReadOnly(false)]
        [Column("P012I048", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 199)]
        public System.Nullable<System.Int32> P012I048 { get; set; }

        [ReadOnly(false)]
        [Column("P012I049", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 200)]
        public System.Nullable<System.Int32> P012I049 { get; set; }

        [ReadOnly(false)]
        [Column("P013A001", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Both sexes", ShortName = "Both sexes", Order = 201)]
        public System.Nullable<System.Double> P013A001 { get; set; }

        [ReadOnly(false)]
        [Column("P013A002", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 202)]
        public System.Nullable<System.Double> P013A002 { get; set; }

        [ReadOnly(false)]
        [Column("P013A003", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 203)]
        public System.Nullable<System.Double> P013A003 { get; set; }

        [ReadOnly(false)]
        [Column("P013B001", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Both sexes", ShortName = "Both sexes", Order = 204)]
        public System.Nullable<System.Double> P013B001 { get; set; }

        [ReadOnly(false)]
        [Column("P013B002", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 205)]
        public System.Nullable<System.Double> P013B002 { get; set; }

        [ReadOnly(false)]
        [Column("P013B003", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 206)]
        public System.Nullable<System.Double> P013B003 { get; set; }

        [ReadOnly(false)]
        [Column("P013C001", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Both sexes", ShortName = "Both sexes", Order = 207)]
        public System.Nullable<System.Double> P013C001 { get; set; }

        [ReadOnly(false)]
        [Column("P013C002", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 208)]
        public System.Nullable<System.Double> P013C002 { get; set; }

        [ReadOnly(false)]
        [Column("P013C003", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 209)]
        public System.Nullable<System.Double> P013C003 { get; set; }

        [ReadOnly(false)]
        [Column("P013D001", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Both sexes", ShortName = "Both sexes", Order = 210)]
        public System.Nullable<System.Double> P013D001 { get; set; }

        [ReadOnly(false)]
        [Column("P013D002", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 211)]
        public System.Nullable<System.Double> P013D002 { get; set; }

        [ReadOnly(false)]
        [Column("P013D003", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 212)]
        public System.Nullable<System.Double> P013D003 { get; set; }

        [ReadOnly(false)]
        [Column("P013E001", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Both sexes", ShortName = "Both sexes", Order = 213)]
        public System.Nullable<System.Double> P013E001 { get; set; }

        [ReadOnly(false)]
        [Column("P013E002", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 214)]
        public System.Nullable<System.Double> P013E002 { get; set; }

        [ReadOnly(false)]
        [Column("P013E003", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 215)]
        public System.Nullable<System.Double> P013E003 { get; set; }

        [ReadOnly(false)]
        [Column("P013F001", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Both sexes", ShortName = "Both sexes", Order = 216)]
        public System.Nullable<System.Double> P013F001 { get; set; }

        [ReadOnly(false)]
        [Column("P013F002", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 217)]
        public System.Nullable<System.Double> P013F002 { get; set; }

        [ReadOnly(false)]
        [Column("P013F003", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 218)]
        public System.Nullable<System.Double> P013F003 { get; set; }

        [ReadOnly(false)]
        [Column("P013G001", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Both sexes", ShortName = "Both sexes", Order = 219)]
        public System.Nullable<System.Double> P013G001 { get; set; }

        [ReadOnly(false)]
        [Column("P013G002", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 220)]
        public System.Nullable<System.Double> P013G002 { get; set; }

        [ReadOnly(false)]
        [Column("P013G003", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 221)]
        public System.Nullable<System.Double> P013G003 { get; set; }

        [ReadOnly(false)]
        [Column("P013H001", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Both sexes", ShortName = "Both sexes", Order = 222)]
        public System.Nullable<System.Double> P013H001 { get; set; }

        [ReadOnly(false)]
        [Column("P013H002", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 223)]
        public System.Nullable<System.Double> P013H002 { get; set; }

        [ReadOnly(false)]
        [Column("P013H003", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 224)]
        public System.Nullable<System.Double> P013H003 { get; set; }

        [ReadOnly(false)]
        [Column("P013I001", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Both sexes", ShortName = "Both sexes", Order = 225)]
        public System.Nullable<System.Double> P013I001 { get; set; }

        [ReadOnly(false)]
        [Column("P013I002", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 226)]
        public System.Nullable<System.Double> P013I002 { get; set; }

        [ReadOnly(false)]
        [Column("P013I003", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 227)]
        public System.Nullable<System.Double> P013I003 { get; set; }

        [ReadOnly(false)]
        [Column("P016A001", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 228)]
        public System.Nullable<System.Int32> P016A001 { get; set; }

        [ReadOnly(false)]
        [Column("P016A002", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 229)]
        public System.Nullable<System.Int32> P016A002 { get; set; }

        [ReadOnly(false)]
        [Column("P016A003", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 230)]
        public System.Nullable<System.Int32> P016A003 { get; set; }

        [ReadOnly(false)]
        [Column("P016B001", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 231)]
        public System.Nullable<System.Int32> P016B001 { get; set; }

        [ReadOnly(false)]
        [Column("P016B002", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 232)]
        public System.Nullable<System.Int32> P016B002 { get; set; }

        [ReadOnly(false)]
        [Column("P016B003", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 233)]
        public System.Nullable<System.Int32> P016B003 { get; set; }

        [ReadOnly(false)]
        [Column("P016C001", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 234)]
        public System.Nullable<System.Int32> P016C001 { get; set; }

        [ReadOnly(false)]
        [Column("P016C002", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 235)]
        public System.Nullable<System.Int32> P016C002 { get; set; }

        [ReadOnly(false)]
        [Column("P016C003", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 236)]
        public System.Nullable<System.Int32> P016C003 { get; set; }

        [ReadOnly(false)]
        [Column("P016D001", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 237)]
        public System.Nullable<System.Int32> P016D001 { get; set; }

        [ReadOnly(false)]
        [Column("P016D002", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 238)]
        public System.Nullable<System.Int32> P016D002 { get; set; }

        [ReadOnly(false)]
        [Column("P016D003", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 239)]
        public System.Nullable<System.Int32> P016D003 { get; set; }

        [ReadOnly(false)]
        [Column("P016E001", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 240)]
        public System.Nullable<System.Int32> P016E001 { get; set; }

        [ReadOnly(false)]
        [Column("P016E002", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 241)]
        public System.Nullable<System.Int32> P016E002 { get; set; }

        [ReadOnly(false)]
        [Column("P016E003", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 242)]
        public System.Nullable<System.Int32> P016E003 { get; set; }

        [ReadOnly(false)]
        [Column("P016F001", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 243)]
        public System.Nullable<System.Int32> P016F001 { get; set; }

        [ReadOnly(false)]
        [Column("P016F002", Order = 244)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 244)]
        public System.Nullable<System.Int32> P016F002 { get; set; }

        [ReadOnly(false)]
        [Column("P016F003", Order = 245)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 245)]
        public System.Nullable<System.Int32> P016F003 { get; set; }

        [ReadOnly(false)]
        [Column("P016G001", Order = 246)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 246)]
        public System.Nullable<System.Int32> P016G001 { get; set; }

        [ReadOnly(false)]
        [Column("P016G002", Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 247)]
        public System.Nullable<System.Int32> P016G002 { get; set; }

        [ReadOnly(false)]
        [Column("P016G003", Order = 248)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 248)]
        public System.Nullable<System.Int32> P016G003 { get; set; }

        [ReadOnly(false)]
        [Column("P016H001", Order = 249)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 249)]
        public System.Nullable<System.Int32> P016H001 { get; set; }

        [ReadOnly(false)]
        [Column("P016H002", Order = 250)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 250)]
        public System.Nullable<System.Int32> P016H002 { get; set; }

        [ReadOnly(false)]
        [Column("P016H003", Order = 251)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 251)]
        public System.Nullable<System.Int32> P016H003 { get; set; }

        [ReadOnly(false)]
        [Column("P016I001", Order = 252)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 252)]
        public System.Nullable<System.Int32> P016I001 { get; set; }

        [ReadOnly(false)]
        [Column("P016I002", Order = 253)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 253)]
        public System.Nullable<System.Int32> P016I002 { get; set; }

        [ReadOnly(false)]
        [Column("P016I003", Order = 254)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 254)]
        public System.Nullable<System.Int32> P016I003 { get; set; }

        [ReadOnly(false)]
        [Column("P017A001", Order = 255)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 255)]
        public System.Nullable<System.Double> P017A001 { get; set; }

        [ReadOnly(false)]
        [Column("P017A002", Order = 256)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 256)]
        public System.Nullable<System.Double> P017A002 { get; set; }

        [ReadOnly(false)]
        [Column("P017A003", Order = 257)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 257)]
        public System.Nullable<System.Double> P017A003 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00008(string csvLine) : base(csvLine) {}

        public SF1_00008(string[] values) : base(values) {}

        public SF1_00008(OleDbDataReader reader, CensusFileType fileType)
        {
            if(reader[0] != DBNull.Value)
            {
                FILEID = (System.String)reader[0];
            }
            if(reader[1] != DBNull.Value)
            {
                STUSAB = (System.String)reader[1];
            }
            if(reader[2] != DBNull.Value)
            {
                CHARITER = (System.String)reader[2];
            }
            if(reader[3] != DBNull.Value)
            {
                CIFSN = (System.String)reader[3];
            }
            if(reader[4] != DBNull.Value)
            {
                LOGRECNO = (System.Nullable<System.Int32>)reader[4];
            }
            if(reader[5] != DBNull.Value)
            {
                P012F001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                P012F002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                P012F003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                P012F004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                P012F005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                P012F006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                P012F007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                P012F008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                P012F009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                P012F010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                P012F011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                P012F012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                P012F013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                P012F014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                P012F015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                P012F016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                P012F017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                P012F018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                P012F019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                P012F020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                P012F021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                P012F022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                P012F023 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                P012F024 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                P012F025 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                P012F026 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                P012F027 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                P012F028 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                P012F029 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                P012F030 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                P012F031 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                P012F032 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                P012F033 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                P012F034 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                P012F035 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                P012F036 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                P012F037 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                P012F038 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                P012F039 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                P012F040 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                P012F041 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                P012F042 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                P012F043 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                P012F044 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                P012F045 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                P012F046 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                P012F047 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                P012F048 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                P012F049 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                P012G001 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                P012G002 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                P012G003 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                P012G004 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                P012G005 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                P012G006 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                P012G007 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                P012G008 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                P012G009 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                P012G010 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                P012G011 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                P012G012 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                P012G013 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                P012G014 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                P012G015 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                P012G016 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                P012G017 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                P012G018 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                P012G019 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                P012G020 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                P012G021 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                P012G022 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                P012G023 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                P012G024 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                P012G025 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                P012G026 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                P012G027 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                P012G028 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                P012G029 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                P012G030 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                P012G031 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                P012G032 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                P012G033 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                P012G034 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                P012G035 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                P012G036 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                P012G037 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                P012G038 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                P012G039 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                P012G040 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                P012G041 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                P012G042 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                P012G043 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                P012G044 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                P012G045 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                P012G046 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                P012G047 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                P012G048 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                P012G049 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                P012H001 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                P012H002 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                P012H003 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                P012H004 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                P012H005 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                P012H006 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                P012H007 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                P012H008 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                P012H009 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                P012H010 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                P012H011 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                P012H012 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                P012H013 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                P012H014 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                P012H015 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                P012H016 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                P012H017 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                P012H018 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                P012H019 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                P012H020 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                P012H021 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                P012H022 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                P012H023 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                P012H024 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                P012H025 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                P012H026 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                P012H027 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                P012H028 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                P012H029 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                P012H030 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                P012H031 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                P012H032 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                P012H033 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                P012H034 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                P012H035 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                P012H036 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                P012H037 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                P012H038 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                P012H039 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                P012H040 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                P012H041 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                P012H042 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                P012H043 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                P012H044 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                P012H045 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                P012H046 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                P012H047 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                P012H048 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                P012H049 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                P012I001 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                P012I002 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                P012I003 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                P012I004 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                P012I005 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                P012I006 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                P012I007 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                P012I008 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                P012I009 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                P012I010 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                P012I011 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                P012I012 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                P012I013 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                P012I014 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                P012I015 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                P012I016 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                P012I017 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                P012I018 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                P012I019 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                P012I020 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                P012I021 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                P012I022 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                P012I023 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                P012I024 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                P012I025 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                P012I026 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                P012I027 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                P012I028 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                P012I029 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                P012I030 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                P012I031 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                P012I032 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                P012I033 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                P012I034 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                P012I035 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                P012I036 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                P012I037 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                P012I038 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                P012I039 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                P012I040 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                P012I041 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                P012I042 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                P012I043 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                P012I044 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                P012I045 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                P012I046 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                P012I047 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                P012I048 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                P012I049 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                P013A001 = (System.Nullable<System.Double>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                P013A002 = (System.Nullable<System.Double>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                P013A003 = (System.Nullable<System.Double>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                P013B001 = (System.Nullable<System.Double>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                P013B002 = (System.Nullable<System.Double>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                P013B003 = (System.Nullable<System.Double>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                P013C001 = (System.Nullable<System.Double>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                P013C002 = (System.Nullable<System.Double>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                P013C003 = (System.Nullable<System.Double>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                P013D001 = (System.Nullable<System.Double>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                P013D002 = (System.Nullable<System.Double>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                P013D003 = (System.Nullable<System.Double>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                P013E001 = (System.Nullable<System.Double>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                P013E002 = (System.Nullable<System.Double>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                P013E003 = (System.Nullable<System.Double>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                P013F001 = (System.Nullable<System.Double>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                P013F002 = (System.Nullable<System.Double>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                P013F003 = (System.Nullable<System.Double>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                P013G001 = (System.Nullable<System.Double>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                P013G002 = (System.Nullable<System.Double>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                P013G003 = (System.Nullable<System.Double>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                P013H001 = (System.Nullable<System.Double>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                P013H002 = (System.Nullable<System.Double>)reader[223];
            }
            if(reader[224] != DBNull.Value)
            {
                P013H003 = (System.Nullable<System.Double>)reader[224];
            }
            if(reader[225] != DBNull.Value)
            {
                P013I001 = (System.Nullable<System.Double>)reader[225];
            }
            if(reader[226] != DBNull.Value)
            {
                P013I002 = (System.Nullable<System.Double>)reader[226];
            }
            if(reader[227] != DBNull.Value)
            {
                P013I003 = (System.Nullable<System.Double>)reader[227];
            }
            if(reader[228] != DBNull.Value)
            {
                P016A001 = (System.Nullable<System.Int32>)reader[228];
            }
            if(reader[229] != DBNull.Value)
            {
                P016A002 = (System.Nullable<System.Int32>)reader[229];
            }
            if(reader[230] != DBNull.Value)
            {
                P016A003 = (System.Nullable<System.Int32>)reader[230];
            }
            if(reader[231] != DBNull.Value)
            {
                P016B001 = (System.Nullable<System.Int32>)reader[231];
            }
            if(reader[232] != DBNull.Value)
            {
                P016B002 = (System.Nullable<System.Int32>)reader[232];
            }
            if(reader[233] != DBNull.Value)
            {
                P016B003 = (System.Nullable<System.Int32>)reader[233];
            }
            if(reader[234] != DBNull.Value)
            {
                P016C001 = (System.Nullable<System.Int32>)reader[234];
            }
            if(reader[235] != DBNull.Value)
            {
                P016C002 = (System.Nullable<System.Int32>)reader[235];
            }
            if(reader[236] != DBNull.Value)
            {
                P016C003 = (System.Nullable<System.Int32>)reader[236];
            }
            if(reader[237] != DBNull.Value)
            {
                P016D001 = (System.Nullable<System.Int32>)reader[237];
            }
            if(reader[238] != DBNull.Value)
            {
                P016D002 = (System.Nullable<System.Int32>)reader[238];
            }
            if(reader[239] != DBNull.Value)
            {
                P016D003 = (System.Nullable<System.Int32>)reader[239];
            }
            if(reader[240] != DBNull.Value)
            {
                P016E001 = (System.Nullable<System.Int32>)reader[240];
            }
            if(reader[241] != DBNull.Value)
            {
                P016E002 = (System.Nullable<System.Int32>)reader[241];
            }
            if(reader[242] != DBNull.Value)
            {
                P016E003 = (System.Nullable<System.Int32>)reader[242];
            }
            if(reader[243] != DBNull.Value)
            {
                P016F001 = (System.Nullable<System.Int32>)reader[243];
            }
            if(reader[244] != DBNull.Value)
            {
                P016F002 = (System.Nullable<System.Int32>)reader[244];
            }
            if(reader[245] != DBNull.Value)
            {
                P016F003 = (System.Nullable<System.Int32>)reader[245];
            }
            if(reader[246] != DBNull.Value)
            {
                P016G001 = (System.Nullable<System.Int32>)reader[246];
            }
            if(reader[247] != DBNull.Value)
            {
                P016G002 = (System.Nullable<System.Int32>)reader[247];
            }
            if(reader[248] != DBNull.Value)
            {
                P016G003 = (System.Nullable<System.Int32>)reader[248];
            }
            if(reader[249] != DBNull.Value)
            {
                P016H001 = (System.Nullable<System.Int32>)reader[249];
            }
            if(reader[250] != DBNull.Value)
            {
                P016H002 = (System.Nullable<System.Int32>)reader[250];
            }
            if(reader[251] != DBNull.Value)
            {
                P016H003 = (System.Nullable<System.Int32>)reader[251];
            }
            if(reader[252] != DBNull.Value)
            {
                P016I001 = (System.Nullable<System.Int32>)reader[252];
            }
            if(reader[253] != DBNull.Value)
            {
                P016I002 = (System.Nullable<System.Int32>)reader[253];
            }
            if(reader[254] != DBNull.Value)
            {
                P016I003 = (System.Nullable<System.Int32>)reader[254];
            }
            if(reader[255] != DBNull.Value)
            {
                P017A001 = (System.Nullable<System.Double>)reader[255];
            }
            if(reader[256] != DBNull.Value)
            {
                P017A002 = (System.Nullable<System.Double>)reader[256];
            }
            if(reader[257] != DBNull.Value)
            {
                P017A003 = (System.Nullable<System.Double>)reader[257];
            }
        }
        #endregion Constructors
    }
}