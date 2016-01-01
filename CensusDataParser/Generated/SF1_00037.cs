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

    [Table("SF1_00037")]
    public partial class SF1_00037 : BaseModel
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
        [Column("PCT019C001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> PCT019C001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019C002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 6)]
        public System.Nullable<System.Int32> PCT019C002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019C003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 7)]
        public System.Nullable<System.Int32> PCT019C003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019C004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 8)]
        public System.Nullable<System.Int32> PCT019C004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019C005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 9)]
        public System.Nullable<System.Int32> PCT019C005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019C006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 10)]
        public System.Nullable<System.Int32> PCT019C006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019C007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 11)]
        public System.Nullable<System.Int32> PCT019C007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019C008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 12)]
        public System.Nullable<System.Int32> PCT019C008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019C009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 13)]
        public System.Nullable<System.Int32> PCT019C009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019C010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 14)]
        public System.Nullable<System.Int32> PCT019C010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019C011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 15)]
        public System.Nullable<System.Int32> PCT019C011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019D001", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 16)]
        public System.Nullable<System.Int32> PCT019D001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019D002", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 17)]
        public System.Nullable<System.Int32> PCT019D002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019D003", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 18)]
        public System.Nullable<System.Int32> PCT019D003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019D004", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 19)]
        public System.Nullable<System.Int32> PCT019D004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019D005", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 20)]
        public System.Nullable<System.Int32> PCT019D005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019D006", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 21)]
        public System.Nullable<System.Int32> PCT019D006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019D007", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 22)]
        public System.Nullable<System.Int32> PCT019D007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019D008", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 23)]
        public System.Nullable<System.Int32> PCT019D008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019D009", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 24)]
        public System.Nullable<System.Int32> PCT019D009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019D010", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 25)]
        public System.Nullable<System.Int32> PCT019D010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019D011", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 26)]
        public System.Nullable<System.Int32> PCT019D011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019E001", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 27)]
        public System.Nullable<System.Int32> PCT019E001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019E002", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 28)]
        public System.Nullable<System.Int32> PCT019E002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019E003", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 29)]
        public System.Nullable<System.Int32> PCT019E003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019E004", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 30)]
        public System.Nullable<System.Int32> PCT019E004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019E005", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 31)]
        public System.Nullable<System.Int32> PCT019E005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019E006", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 32)]
        public System.Nullable<System.Int32> PCT019E006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019E007", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 33)]
        public System.Nullable<System.Int32> PCT019E007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019E008", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 34)]
        public System.Nullable<System.Int32> PCT019E008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019E009", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 35)]
        public System.Nullable<System.Int32> PCT019E009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019E010", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 36)]
        public System.Nullable<System.Int32> PCT019E010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019E011", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 37)]
        public System.Nullable<System.Int32> PCT019E011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019F001", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 38)]
        public System.Nullable<System.Int32> PCT019F001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019F002", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 39)]
        public System.Nullable<System.Int32> PCT019F002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019F003", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 40)]
        public System.Nullable<System.Int32> PCT019F003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019F004", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 41)]
        public System.Nullable<System.Int32> PCT019F004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019F005", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 42)]
        public System.Nullable<System.Int32> PCT019F005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019F006", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 43)]
        public System.Nullable<System.Int32> PCT019F006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019F007", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 44)]
        public System.Nullable<System.Int32> PCT019F007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019F008", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 45)]
        public System.Nullable<System.Int32> PCT019F008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019F009", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 46)]
        public System.Nullable<System.Int32> PCT019F009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019F010", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 47)]
        public System.Nullable<System.Int32> PCT019F010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019F011", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 48)]
        public System.Nullable<System.Int32> PCT019F011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019G001", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 49)]
        public System.Nullable<System.Int32> PCT019G001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019G002", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 50)]
        public System.Nullable<System.Int32> PCT019G002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019G003", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 51)]
        public System.Nullable<System.Int32> PCT019G003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019G004", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 52)]
        public System.Nullable<System.Int32> PCT019G004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019G005", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 53)]
        public System.Nullable<System.Int32> PCT019G005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019G006", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 54)]
        public System.Nullable<System.Int32> PCT019G006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019G007", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 55)]
        public System.Nullable<System.Int32> PCT019G007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019G008", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 56)]
        public System.Nullable<System.Int32> PCT019G008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019G009", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 57)]
        public System.Nullable<System.Int32> PCT019G009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019G010", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 58)]
        public System.Nullable<System.Int32> PCT019G010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019G011", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 59)]
        public System.Nullable<System.Int32> PCT019G011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019H001", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 60)]
        public System.Nullable<System.Int32> PCT019H001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019H002", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 61)]
        public System.Nullable<System.Int32> PCT019H002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019H003", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 62)]
        public System.Nullable<System.Int32> PCT019H003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019H004", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 63)]
        public System.Nullable<System.Int32> PCT019H004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019H005", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 64)]
        public System.Nullable<System.Int32> PCT019H005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019H006", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 65)]
        public System.Nullable<System.Int32> PCT019H006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019H007", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 66)]
        public System.Nullable<System.Int32> PCT019H007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019H008", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 67)]
        public System.Nullable<System.Int32> PCT019H008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019H009", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 68)]
        public System.Nullable<System.Int32> PCT019H009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019H010", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 69)]
        public System.Nullable<System.Int32> PCT019H010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019H011", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 70)]
        public System.Nullable<System.Int32> PCT019H011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019I001", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 71)]
        public System.Nullable<System.Int32> PCT019I001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019I002", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 72)]
        public System.Nullable<System.Int32> PCT019I002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019I003", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 73)]
        public System.Nullable<System.Int32> PCT019I003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019I004", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 74)]
        public System.Nullable<System.Int32> PCT019I004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019I005", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 75)]
        public System.Nullable<System.Int32> PCT019I005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019I006", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 76)]
        public System.Nullable<System.Int32> PCT019I006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019I007", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 77)]
        public System.Nullable<System.Int32> PCT019I007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019I008", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 78)]
        public System.Nullable<System.Int32> PCT019I008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019I009", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 79)]
        public System.Nullable<System.Int32> PCT019I009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019I010", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 80)]
        public System.Nullable<System.Int32> PCT019I010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT019I011", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 81)]
        public System.Nullable<System.Int32> PCT019I011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A001", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 82)]
        public System.Nullable<System.Int32> PCT020A001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A002", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 83)]
        public System.Nullable<System.Int32> PCT020A002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A003", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 84)]
        public System.Nullable<System.Int32> PCT020A003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A004", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 85)]
        public System.Nullable<System.Int32> PCT020A004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A005", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 86)]
        public System.Nullable<System.Int32> PCT020A005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A006", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 87)]
        public System.Nullable<System.Int32> PCT020A006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A007", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 88)]
        public System.Nullable<System.Int32> PCT020A007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A008", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 89)]
        public System.Nullable<System.Int32> PCT020A008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A009", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 90)]
        public System.Nullable<System.Int32> PCT020A009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A010", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 91)]
        public System.Nullable<System.Int32> PCT020A010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A011", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 92)]
        public System.Nullable<System.Int32> PCT020A011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A012", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 93)]
        public System.Nullable<System.Int32> PCT020A012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A013", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 94)]
        public System.Nullable<System.Int32> PCT020A013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A014", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 95)]
        public System.Nullable<System.Int32> PCT020A014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A015", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 96)]
        public System.Nullable<System.Int32> PCT020A015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A016", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 97)]
        public System.Nullable<System.Int32> PCT020A016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A017", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 98)]
        public System.Nullable<System.Int32> PCT020A017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A018", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 99)]
        public System.Nullable<System.Int32> PCT020A018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A019", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 100)]
        public System.Nullable<System.Int32> PCT020A019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A020", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 101)]
        public System.Nullable<System.Int32> PCT020A020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A021", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 102)]
        public System.Nullable<System.Int32> PCT020A021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A022", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 103)]
        public System.Nullable<System.Int32> PCT020A022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A023", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 104)]
        public System.Nullable<System.Int32> PCT020A023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A024", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 105)]
        public System.Nullable<System.Int32> PCT020A024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A025", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 106)]
        public System.Nullable<System.Int32> PCT020A025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A026", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 107)]
        public System.Nullable<System.Int32> PCT020A026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A027", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 108)]
        public System.Nullable<System.Int32> PCT020A027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A028", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 109)]
        public System.Nullable<System.Int32> PCT020A028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A029", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 110)]
        public System.Nullable<System.Int32> PCT020A029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A030", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 111)]
        public System.Nullable<System.Int32> PCT020A030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A031", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 112)]
        public System.Nullable<System.Int32> PCT020A031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020A032", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 113)]
        public System.Nullable<System.Int32> PCT020A032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B001", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 114)]
        public System.Nullable<System.Int32> PCT020B001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B002", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 115)]
        public System.Nullable<System.Int32> PCT020B002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B003", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 116)]
        public System.Nullable<System.Int32> PCT020B003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B004", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 117)]
        public System.Nullable<System.Int32> PCT020B004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B005", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 118)]
        public System.Nullable<System.Int32> PCT020B005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B006", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 119)]
        public System.Nullable<System.Int32> PCT020B006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B007", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 120)]
        public System.Nullable<System.Int32> PCT020B007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B008", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 121)]
        public System.Nullable<System.Int32> PCT020B008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B009", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 122)]
        public System.Nullable<System.Int32> PCT020B009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B010", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 123)]
        public System.Nullable<System.Int32> PCT020B010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B011", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 124)]
        public System.Nullable<System.Int32> PCT020B011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B012", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 125)]
        public System.Nullable<System.Int32> PCT020B012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B013", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 126)]
        public System.Nullable<System.Int32> PCT020B013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B014", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 127)]
        public System.Nullable<System.Int32> PCT020B014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B015", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 128)]
        public System.Nullable<System.Int32> PCT020B015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B016", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 129)]
        public System.Nullable<System.Int32> PCT020B016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B017", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 130)]
        public System.Nullable<System.Int32> PCT020B017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B018", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 131)]
        public System.Nullable<System.Int32> PCT020B018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B019", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 132)]
        public System.Nullable<System.Int32> PCT020B019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B020", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 133)]
        public System.Nullable<System.Int32> PCT020B020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B021", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 134)]
        public System.Nullable<System.Int32> PCT020B021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B022", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 135)]
        public System.Nullable<System.Int32> PCT020B022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B023", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 136)]
        public System.Nullable<System.Int32> PCT020B023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B024", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 137)]
        public System.Nullable<System.Int32> PCT020B024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B025", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 138)]
        public System.Nullable<System.Int32> PCT020B025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B026", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 139)]
        public System.Nullable<System.Int32> PCT020B026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B027", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 140)]
        public System.Nullable<System.Int32> PCT020B027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B028", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 141)]
        public System.Nullable<System.Int32> PCT020B028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B029", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 142)]
        public System.Nullable<System.Int32> PCT020B029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B030", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 143)]
        public System.Nullable<System.Int32> PCT020B030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B031", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 144)]
        public System.Nullable<System.Int32> PCT020B031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020B032", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 145)]
        public System.Nullable<System.Int32> PCT020B032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C001", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 146)]
        public System.Nullable<System.Int32> PCT020C001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C002", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 147)]
        public System.Nullable<System.Int32> PCT020C002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C003", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 148)]
        public System.Nullable<System.Int32> PCT020C003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C004", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 149)]
        public System.Nullable<System.Int32> PCT020C004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C005", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 150)]
        public System.Nullable<System.Int32> PCT020C005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C006", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 151)]
        public System.Nullable<System.Int32> PCT020C006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C007", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 152)]
        public System.Nullable<System.Int32> PCT020C007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C008", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 153)]
        public System.Nullable<System.Int32> PCT020C008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C009", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 154)]
        public System.Nullable<System.Int32> PCT020C009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C010", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 155)]
        public System.Nullable<System.Int32> PCT020C010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C011", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 156)]
        public System.Nullable<System.Int32> PCT020C011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C012", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 157)]
        public System.Nullable<System.Int32> PCT020C012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C013", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 158)]
        public System.Nullable<System.Int32> PCT020C013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C014", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 159)]
        public System.Nullable<System.Int32> PCT020C014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C015", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 160)]
        public System.Nullable<System.Int32> PCT020C015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C016", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 161)]
        public System.Nullable<System.Int32> PCT020C016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C017", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 162)]
        public System.Nullable<System.Int32> PCT020C017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C018", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 163)]
        public System.Nullable<System.Int32> PCT020C018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C019", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 164)]
        public System.Nullable<System.Int32> PCT020C019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C020", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 165)]
        public System.Nullable<System.Int32> PCT020C020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C021", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 166)]
        public System.Nullable<System.Int32> PCT020C021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C022", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 167)]
        public System.Nullable<System.Int32> PCT020C022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C023", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 168)]
        public System.Nullable<System.Int32> PCT020C023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C024", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 169)]
        public System.Nullable<System.Int32> PCT020C024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C025", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 170)]
        public System.Nullable<System.Int32> PCT020C025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C026", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 171)]
        public System.Nullable<System.Int32> PCT020C026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C027", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 172)]
        public System.Nullable<System.Int32> PCT020C027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C028", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 173)]
        public System.Nullable<System.Int32> PCT020C028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C029", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 174)]
        public System.Nullable<System.Int32> PCT020C029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C030", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 175)]
        public System.Nullable<System.Int32> PCT020C030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C031", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 176)]
        public System.Nullable<System.Int32> PCT020C031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020C032", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 177)]
        public System.Nullable<System.Int32> PCT020C032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D001", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 178)]
        public System.Nullable<System.Int32> PCT020D001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D002", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 179)]
        public System.Nullable<System.Int32> PCT020D002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D003", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 180)]
        public System.Nullable<System.Int32> PCT020D003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D004", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 181)]
        public System.Nullable<System.Int32> PCT020D004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D005", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 182)]
        public System.Nullable<System.Int32> PCT020D005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D006", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 183)]
        public System.Nullable<System.Int32> PCT020D006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D007", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 184)]
        public System.Nullable<System.Int32> PCT020D007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D008", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 185)]
        public System.Nullable<System.Int32> PCT020D008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D009", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 186)]
        public System.Nullable<System.Int32> PCT020D009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D010", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 187)]
        public System.Nullable<System.Int32> PCT020D010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D011", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 188)]
        public System.Nullable<System.Int32> PCT020D011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D012", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 189)]
        public System.Nullable<System.Int32> PCT020D012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D013", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 190)]
        public System.Nullable<System.Int32> PCT020D013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D014", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 191)]
        public System.Nullable<System.Int32> PCT020D014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D015", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 192)]
        public System.Nullable<System.Int32> PCT020D015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D016", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 193)]
        public System.Nullable<System.Int32> PCT020D016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D017", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 194)]
        public System.Nullable<System.Int32> PCT020D017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D018", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 195)]
        public System.Nullable<System.Int32> PCT020D018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D019", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 196)]
        public System.Nullable<System.Int32> PCT020D019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D020", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 197)]
        public System.Nullable<System.Int32> PCT020D020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D021", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 198)]
        public System.Nullable<System.Int32> PCT020D021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D022", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 199)]
        public System.Nullable<System.Int32> PCT020D022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D023", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 200)]
        public System.Nullable<System.Int32> PCT020D023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D024", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 201)]
        public System.Nullable<System.Int32> PCT020D024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D025", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 202)]
        public System.Nullable<System.Int32> PCT020D025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D026", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 203)]
        public System.Nullable<System.Int32> PCT020D026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D027", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 204)]
        public System.Nullable<System.Int32> PCT020D027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D028", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 205)]
        public System.Nullable<System.Int32> PCT020D028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D029", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 206)]
        public System.Nullable<System.Int32> PCT020D029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D030", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 207)]
        public System.Nullable<System.Int32> PCT020D030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D031", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 208)]
        public System.Nullable<System.Int32> PCT020D031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020D032", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 209)]
        public System.Nullable<System.Int32> PCT020D032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E001", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 210)]
        public System.Nullable<System.Int32> PCT020E001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E002", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 211)]
        public System.Nullable<System.Int32> PCT020E002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E003", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 212)]
        public System.Nullable<System.Int32> PCT020E003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E004", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 213)]
        public System.Nullable<System.Int32> PCT020E004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E005", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 214)]
        public System.Nullable<System.Int32> PCT020E005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E006", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 215)]
        public System.Nullable<System.Int32> PCT020E006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E007", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 216)]
        public System.Nullable<System.Int32> PCT020E007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E008", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 217)]
        public System.Nullable<System.Int32> PCT020E008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E009", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 218)]
        public System.Nullable<System.Int32> PCT020E009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E010", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 219)]
        public System.Nullable<System.Int32> PCT020E010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E011", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 220)]
        public System.Nullable<System.Int32> PCT020E011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E012", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 221)]
        public System.Nullable<System.Int32> PCT020E012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E013", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 222)]
        public System.Nullable<System.Int32> PCT020E013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E014", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 223)]
        public System.Nullable<System.Int32> PCT020E014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E015", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 224)]
        public System.Nullable<System.Int32> PCT020E015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E016", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 225)]
        public System.Nullable<System.Int32> PCT020E016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E017", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 226)]
        public System.Nullable<System.Int32> PCT020E017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E018", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 227)]
        public System.Nullable<System.Int32> PCT020E018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E019", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 228)]
        public System.Nullable<System.Int32> PCT020E019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E020", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 229)]
        public System.Nullable<System.Int32> PCT020E020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E021", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 230)]
        public System.Nullable<System.Int32> PCT020E021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E022", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 231)]
        public System.Nullable<System.Int32> PCT020E022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E023", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 232)]
        public System.Nullable<System.Int32> PCT020E023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E024", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 233)]
        public System.Nullable<System.Int32> PCT020E024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E025", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 234)]
        public System.Nullable<System.Int32> PCT020E025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E026", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 235)]
        public System.Nullable<System.Int32> PCT020E026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E027", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 236)]
        public System.Nullable<System.Int32> PCT020E027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E028", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 237)]
        public System.Nullable<System.Int32> PCT020E028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E029", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 238)]
        public System.Nullable<System.Int32> PCT020E029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E030", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 239)]
        public System.Nullable<System.Int32> PCT020E030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E031", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 240)]
        public System.Nullable<System.Int32> PCT020E031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT020E032", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 241)]
        public System.Nullable<System.Int32> PCT020E032 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00037(string csvLine) : base(csvLine) {}

        public SF1_00037(string[] values) : base(values) {}

        public SF1_00037(OleDbDataReader reader, CensusFileType fileType)
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
                PCT019C001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                PCT019C002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                PCT019C003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                PCT019C004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                PCT019C005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                PCT019C006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                PCT019C007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                PCT019C008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                PCT019C009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                PCT019C010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                PCT019C011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                PCT019D001 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                PCT019D002 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                PCT019D003 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                PCT019D004 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                PCT019D005 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                PCT019D006 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                PCT019D007 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                PCT019D008 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                PCT019D009 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                PCT019D010 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                PCT019D011 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                PCT019E001 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                PCT019E002 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                PCT019E003 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                PCT019E004 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                PCT019E005 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                PCT019E006 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                PCT019E007 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                PCT019E008 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                PCT019E009 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                PCT019E010 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                PCT019E011 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                PCT019F001 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                PCT019F002 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                PCT019F003 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                PCT019F004 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                PCT019F005 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                PCT019F006 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                PCT019F007 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                PCT019F008 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                PCT019F009 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                PCT019F010 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                PCT019F011 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                PCT019G001 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                PCT019G002 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                PCT019G003 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                PCT019G004 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                PCT019G005 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                PCT019G006 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                PCT019G007 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                PCT019G008 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                PCT019G009 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                PCT019G010 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                PCT019G011 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                PCT019H001 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                PCT019H002 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                PCT019H003 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                PCT019H004 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                PCT019H005 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                PCT019H006 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                PCT019H007 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                PCT019H008 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                PCT019H009 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                PCT019H010 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                PCT019H011 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                PCT019I001 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                PCT019I002 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                PCT019I003 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                PCT019I004 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                PCT019I005 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                PCT019I006 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                PCT019I007 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                PCT019I008 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                PCT019I009 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                PCT019I010 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                PCT019I011 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                PCT020A001 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                PCT020A002 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                PCT020A003 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                PCT020A004 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                PCT020A005 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                PCT020A006 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                PCT020A007 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                PCT020A008 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                PCT020A009 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                PCT020A010 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                PCT020A011 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                PCT020A012 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                PCT020A013 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                PCT020A014 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                PCT020A015 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                PCT020A016 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                PCT020A017 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                PCT020A018 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                PCT020A019 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                PCT020A020 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                PCT020A021 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                PCT020A022 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                PCT020A023 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                PCT020A024 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                PCT020A025 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                PCT020A026 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                PCT020A027 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                PCT020A028 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                PCT020A029 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                PCT020A030 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                PCT020A031 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                PCT020A032 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                PCT020B001 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                PCT020B002 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                PCT020B003 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                PCT020B004 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                PCT020B005 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                PCT020B006 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                PCT020B007 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                PCT020B008 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                PCT020B009 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                PCT020B010 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                PCT020B011 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                PCT020B012 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                PCT020B013 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                PCT020B014 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                PCT020B015 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                PCT020B016 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                PCT020B017 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                PCT020B018 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                PCT020B019 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                PCT020B020 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                PCT020B021 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                PCT020B022 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                PCT020B023 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                PCT020B024 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                PCT020B025 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                PCT020B026 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                PCT020B027 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                PCT020B028 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                PCT020B029 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                PCT020B030 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                PCT020B031 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                PCT020B032 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                PCT020C001 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                PCT020C002 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                PCT020C003 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                PCT020C004 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                PCT020C005 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                PCT020C006 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                PCT020C007 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                PCT020C008 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                PCT020C009 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                PCT020C010 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                PCT020C011 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                PCT020C012 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                PCT020C013 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                PCT020C014 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                PCT020C015 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                PCT020C016 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                PCT020C017 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                PCT020C018 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                PCT020C019 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                PCT020C020 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                PCT020C021 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                PCT020C022 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                PCT020C023 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                PCT020C024 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                PCT020C025 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                PCT020C026 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                PCT020C027 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                PCT020C028 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                PCT020C029 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                PCT020C030 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                PCT020C031 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                PCT020C032 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                PCT020D001 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                PCT020D002 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                PCT020D003 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                PCT020D004 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                PCT020D005 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                PCT020D006 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                PCT020D007 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                PCT020D008 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                PCT020D009 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                PCT020D010 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                PCT020D011 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                PCT020D012 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                PCT020D013 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                PCT020D014 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                PCT020D015 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                PCT020D016 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                PCT020D017 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                PCT020D018 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                PCT020D019 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                PCT020D020 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                PCT020D021 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                PCT020D022 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                PCT020D023 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                PCT020D024 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                PCT020D025 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                PCT020D026 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                PCT020D027 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                PCT020D028 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                PCT020D029 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                PCT020D030 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                PCT020D031 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                PCT020D032 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                PCT020E001 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                PCT020E002 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                PCT020E003 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                PCT020E004 = (System.Nullable<System.Int32>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                PCT020E005 = (System.Nullable<System.Int32>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                PCT020E006 = (System.Nullable<System.Int32>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                PCT020E007 = (System.Nullable<System.Int32>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                PCT020E008 = (System.Nullable<System.Int32>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                PCT020E009 = (System.Nullable<System.Int32>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                PCT020E010 = (System.Nullable<System.Int32>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                PCT020E011 = (System.Nullable<System.Int32>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                PCT020E012 = (System.Nullable<System.Int32>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                PCT020E013 = (System.Nullable<System.Int32>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                PCT020E014 = (System.Nullable<System.Int32>)reader[223];
            }
            if(reader[224] != DBNull.Value)
            {
                PCT020E015 = (System.Nullable<System.Int32>)reader[224];
            }
            if(reader[225] != DBNull.Value)
            {
                PCT020E016 = (System.Nullable<System.Int32>)reader[225];
            }
            if(reader[226] != DBNull.Value)
            {
                PCT020E017 = (System.Nullable<System.Int32>)reader[226];
            }
            if(reader[227] != DBNull.Value)
            {
                PCT020E018 = (System.Nullable<System.Int32>)reader[227];
            }
            if(reader[228] != DBNull.Value)
            {
                PCT020E019 = (System.Nullable<System.Int32>)reader[228];
            }
            if(reader[229] != DBNull.Value)
            {
                PCT020E020 = (System.Nullable<System.Int32>)reader[229];
            }
            if(reader[230] != DBNull.Value)
            {
                PCT020E021 = (System.Nullable<System.Int32>)reader[230];
            }
            if(reader[231] != DBNull.Value)
            {
                PCT020E022 = (System.Nullable<System.Int32>)reader[231];
            }
            if(reader[232] != DBNull.Value)
            {
                PCT020E023 = (System.Nullable<System.Int32>)reader[232];
            }
            if(reader[233] != DBNull.Value)
            {
                PCT020E024 = (System.Nullable<System.Int32>)reader[233];
            }
            if(reader[234] != DBNull.Value)
            {
                PCT020E025 = (System.Nullable<System.Int32>)reader[234];
            }
            if(reader[235] != DBNull.Value)
            {
                PCT020E026 = (System.Nullable<System.Int32>)reader[235];
            }
            if(reader[236] != DBNull.Value)
            {
                PCT020E027 = (System.Nullable<System.Int32>)reader[236];
            }
            if(reader[237] != DBNull.Value)
            {
                PCT020E028 = (System.Nullable<System.Int32>)reader[237];
            }
            if(reader[238] != DBNull.Value)
            {
                PCT020E029 = (System.Nullable<System.Int32>)reader[238];
            }
            if(reader[239] != DBNull.Value)
            {
                PCT020E030 = (System.Nullable<System.Int32>)reader[239];
            }
            if(reader[240] != DBNull.Value)
            {
                PCT020E031 = (System.Nullable<System.Int32>)reader[240];
            }
            if(reader[241] != DBNull.Value)
            {
                PCT020E032 = (System.Nullable<System.Int32>)reader[241];
            }
        }
        #endregion Constructors
    }
}