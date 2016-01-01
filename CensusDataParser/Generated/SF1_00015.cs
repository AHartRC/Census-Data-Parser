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

    [Table("SF1_00015")]
    public partial class SF1_00015 : BaseModel
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
        [Column("PCT0010001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total tribes tallied (300, A01-M38, M41-R98, S01-Z99):", ShortName = "Total tribes tallied (300, A01-M38, M41-R98, S01-Z99):", Order = 5)]
        public System.Nullable<System.Int32> PCT0010001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian tribes, specified (A01-M38, T01-Z99):", ShortName = "American Indian tribes, specified (A01-M38, T01-Z99):", Order = 6)]
        public System.Nullable<System.Int32> PCT0010002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Apache (A09-A23)", ShortName = "Apache (A09-A23)", Order = 7)]
        public System.Nullable<System.Int32> PCT0010003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Arapaho (A24-A33)", ShortName = "Arapaho (A24-A33)", Order = 8)]
        public System.Nullable<System.Int32> PCT0010004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Blackfeet (A45-A50)", ShortName = "Blackfeet (A45-A50)", Order = 9)]
        public System.Nullable<System.Int32> PCT0010005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Canadian and French American Indian (T01-V23)", ShortName = "Canadian and French American Indian (T01-V23)", Order = 10)]
        public System.Nullable<System.Int32> PCT0010006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Central American Indian (V24-V83)", ShortName = "Central American Indian (V24-V83)", Order = 11)]
        public System.Nullable<System.Int32> PCT0010007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cherokee (B21-B39)", ShortName = "Cherokee (B21-B39)", Order = 12)]
        public System.Nullable<System.Int32> PCT0010008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cheyenne (B40-B45)", ShortName = "Cheyenne (B40-B45)", Order = 13)]
        public System.Nullable<System.Int32> PCT0010009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chickasaw (B53-B56)", ShortName = "Chickasaw (B53-B56)", Order = 14)]
        public System.Nullable<System.Int32> PCT0010010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chippewa (B67-B99)", ShortName = "Chippewa (B67-B99)", Order = 15)]
        public System.Nullable<System.Int32> PCT0010011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Choctaw (C08-C16)", ShortName = "Choctaw (C08-C16)", Order = 16)]
        public System.Nullable<System.Int32> PCT0010012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Colville (C35-C38)", ShortName = "Colville (C35-C38)", Order = 17)]
        public System.Nullable<System.Int32> PCT0010013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Comanche (C39-C43)", ShortName = "Comanche (C39-C43)", Order = 18)]
        public System.Nullable<System.Int32> PCT0010014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cree (C59-C63)", ShortName = "Cree (C59-C63)", Order = 19)]
        public System.Nullable<System.Int32> PCT0010015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Creek (C64-C80)", ShortName = "Creek (C64-C80)", Order = 20)]
        public System.Nullable<System.Int32> PCT0010016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Crow (C83-C86)", ShortName = "Crow (C83-C86)", Order = 21)]
        public System.Nullable<System.Int32> PCT0010017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Delaware (C93-D04)", ShortName = "Delaware (C93-D04)", Order = 22)]
        public System.Nullable<System.Int32> PCT0010018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hopi (D74-D75)", ShortName = "Hopi (D74-D75)", Order = 23)]
        public System.Nullable<System.Int32> PCT0010019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Houma (D78-D86)", ShortName = "Houma (D78-D86)", Order = 24)]
        public System.Nullable<System.Int32> PCT0010020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Iroquois (D93-E09)", ShortName = "Iroquois (D93-E09)", Order = 25)]
        public System.Nullable<System.Int32> PCT0010021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Kiowa (E30-E36)", ShortName = "Kiowa (E30-E36)", Order = 26)]
        public System.Nullable<System.Int32> PCT0010022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Lumbee (E78-E83)", ShortName = "Lumbee (E78-E83)", Order = 27)]
        public System.Nullable<System.Int32> PCT0010023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Menominee (F11-F14)", ShortName = "Menominee (F11-F14)", Order = 28)]
        public System.Nullable<System.Int32> PCT0010024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mexican American Indian (V84-W66)", ShortName = "Mexican American Indian (V84-W66)", Order = 29)]
        public System.Nullable<System.Int32> PCT0010025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Navajo  (F62-F70)", ShortName = "Navajo  (F62-F70)", Order = 30)]
        public System.Nullable<System.Int32> PCT0010026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Osage (G04-G09)", ShortName = "Osage (G04-G09)", Order = 31)]
        public System.Nullable<System.Int32> PCT0010027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Ottawa (G14-G22)", ShortName = "Ottawa (G14-G22)", Order = 32)]
        public System.Nullable<System.Int32> PCT0010028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Paiute (G23-G49)", ShortName = "Paiute (G23-G49)", Order = 33)]
        public System.Nullable<System.Int32> PCT0010029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Pima (G84-G91)", ShortName = "Pima (G84-G91)", Order = 34)]
        public System.Nullable<System.Int32> PCT0010030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Potawatomi (H21-H33)", ShortName = "Potawatomi (H21-H33)", Order = 35)]
        public System.Nullable<System.Int32> PCT0010031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Pueblo (H38-H65)", ShortName = "Pueblo (H38-H65)", Order = 36)]
        public System.Nullable<System.Int32> PCT0010032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Puget Sound Salish (H70-H92)", ShortName = "Puget Sound Salish (H70-H92)", Order = 37)]
        public System.Nullable<System.Int32> PCT0010033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Seminole (J47-J57)", ShortName = "Seminole (J47-J57)", Order = 38)]
        public System.Nullable<System.Int32> PCT0010034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Shoshone (J81-J92)", ShortName = "Shoshone (J81-J92)", Order = 39)]
        public System.Nullable<System.Int32> PCT0010035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Sioux (K16-K53)", ShortName = "Sioux (K16-K53)", Order = 40)]
        public System.Nullable<System.Int32> PCT0010036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "South American Indian (W67-X24)", ShortName = "South American Indian (W67-X24)", Order = 41)]
        public System.Nullable<System.Int32> PCT0010037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spanish American Indian (X25-Z99)", ShortName = "Spanish American Indian (X25-Z99)", Order = 42)]
        public System.Nullable<System.Int32> PCT0010038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tohono O�Odham (K78-K86)", ShortName = "Tohono O�Odham (K78-K86)", Order = 43)]
        public System.Nullable<System.Int32> PCT0010039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010040", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Ute (L06-L14)", ShortName = "Ute (L06-L14)", Order = 44)]
        public System.Nullable<System.Int32> PCT0010040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010041", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yakama (L79-L84)", ShortName = "Yakama (L79-L84)", Order = 45)]
        public System.Nullable<System.Int32> PCT0010041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010042", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yaqui (L91-L99)", ShortName = "Yaqui (L91-L99)", Order = 46)]
        public System.Nullable<System.Int32> PCT0010042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010043", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yuman (M22-M33)", ShortName = "Yuman (M22-M33)", Order = 47)]
        public System.Nullable<System.Int32> PCT0010043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010044", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "All other American Indian tribes (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", ShortName = "All other American Indian tribes (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", Order = 48)]
        public System.Nullable<System.Int32> PCT0010044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010045", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian tribes, not specified (M41-M43)", ShortName = "American Indian tribes, not specified (M41-M43)", Order = 49)]
        public System.Nullable<System.Int32> PCT0010045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010046", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaska Native tribes, specified (M52-R98, S01-S99):", ShortName = "Alaska Native tribes, specified (M52-R98, S01-S99):", Order = 50)]
        public System.Nullable<System.Int32> PCT0010046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010047", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaskan Athabascan (M52-N27)", ShortName = "Alaskan Athabascan (M52-N27)", Order = 51)]
        public System.Nullable<System.Int32> PCT0010047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010048", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Aleut (R11-R98, S01-S99)", ShortName = "Aleut (R11-R98, S01-S99)", Order = 52)]
        public System.Nullable<System.Int32> PCT0010048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010049", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Inupiat (N67-P29, P33-P37)", ShortName = "Inupiat (N67-P29, P33-P37)", Order = 53)]
        public System.Nullable<System.Int32> PCT0010049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010050", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tlingit-Haida (N28-N55, N59-N66)", ShortName = "Tlingit-Haida (N28-N55, N59-N66)", Order = 54)]
        public System.Nullable<System.Int32> PCT0010050 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010051", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tsimshian (N56-N58)", ShortName = "Tsimshian (N56-N58)", Order = 55)]
        public System.Nullable<System.Int32> PCT0010051 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010052", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yup'ik (P30-P32, P38-R10)", ShortName = "Yup'ik (P30-P32, P38-R10)", Order = 56)]
        public System.Nullable<System.Int32> PCT0010052 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010053", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaska Native tribes, not specified (M44-M51)", ShortName = "Alaska Native tribes, not specified (M44-M51)", Order = 57)]
        public System.Nullable<System.Int32> PCT0010053 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0010054", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian or Alaska Native tribes, not specified (300)", ShortName = "American Indian or Alaska Native tribes, not specified (300)", Order = 58)]
        public System.Nullable<System.Int32> PCT0010054 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020001", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total tribes tallied (300, A01-Z99) & (300, A01-Z99):", ShortName = "Total tribes tallied (300, A01-Z99) & (300, A01-Z99):", Order = 59)]
        public System.Nullable<System.Int32> PCT0020001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020002", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian tribes, specified (A01-M38, T01-Z99) & (300, A01-Z99):", ShortName = "American Indian tribes, specified (A01-M38, T01-Z99) & (300, A01-Z99):", Order = 60)]
        public System.Nullable<System.Int32> PCT0020002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020003", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Apache (A09-A23) & (300, A01-Z99)", ShortName = "Apache (A09-A23) & (300, A01-Z99)", Order = 61)]
        public System.Nullable<System.Int32> PCT0020003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020004", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Arapaho (A24-A33) & (300, A01-Z99)", ShortName = "Arapaho (A24-A33) & (300, A01-Z99)", Order = 62)]
        public System.Nullable<System.Int32> PCT0020004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020005", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Blackfeet (A45-A50) & (300, A01-Z99)", ShortName = "Blackfeet (A45-A50) & (300, A01-Z99)", Order = 63)]
        public System.Nullable<System.Int32> PCT0020005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020006", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Canadian and French American Indian (T01-V23) & (300, A01-Z99)", ShortName = "Canadian and French American Indian (T01-V23) & (300, A01-Z99)", Order = 64)]
        public System.Nullable<System.Int32> PCT0020006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020007", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Central American Indian (V24-V83) & (300, A01-Z99)", ShortName = "Central American Indian (V24-V83) & (300, A01-Z99)", Order = 65)]
        public System.Nullable<System.Int32> PCT0020007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020008", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cherokee (B21-B39) & (300, A01-Z99)", ShortName = "Cherokee (B21-B39) & (300, A01-Z99)", Order = 66)]
        public System.Nullable<System.Int32> PCT0020008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020009", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cheyenne (B40-B45) & (300, A01-Z99)", ShortName = "Cheyenne (B40-B45) & (300, A01-Z99)", Order = 67)]
        public System.Nullable<System.Int32> PCT0020009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020010", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chickasaw (B53-B56) & (300, A01-Z99)", ShortName = "Chickasaw (B53-B56) & (300, A01-Z99)", Order = 68)]
        public System.Nullable<System.Int32> PCT0020010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020011", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chippewa (B67-B99) & (300, A01-Z99)", ShortName = "Chippewa (B67-B99) & (300, A01-Z99)", Order = 69)]
        public System.Nullable<System.Int32> PCT0020011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020012", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Choctaw (C08-C16) & (300, A01-Z99)", ShortName = "Choctaw (C08-C16) & (300, A01-Z99)", Order = 70)]
        public System.Nullable<System.Int32> PCT0020012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020013", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Colville (C35-C38) & (300, A01-Z99)", ShortName = "Colville (C35-C38) & (300, A01-Z99)", Order = 71)]
        public System.Nullable<System.Int32> PCT0020013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020014", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Comanche (C39-C43) & (300, A01-Z99)", ShortName = "Comanche (C39-C43) & (300, A01-Z99)", Order = 72)]
        public System.Nullable<System.Int32> PCT0020014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020015", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cree (C59-C63) & (300, A01-Z99)", ShortName = "Cree (C59-C63) & (300, A01-Z99)", Order = 73)]
        public System.Nullable<System.Int32> PCT0020015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020016", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Creek (C64-C80) & (300, A01-Z99)", ShortName = "Creek (C64-C80) & (300, A01-Z99)", Order = 74)]
        public System.Nullable<System.Int32> PCT0020016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020017", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Crow (C83-C86) & (300, A01-Z99)", ShortName = "Crow (C83-C86) & (300, A01-Z99)", Order = 75)]
        public System.Nullable<System.Int32> PCT0020017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020018", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Delaware (C93-D04) & (300, A01-Z99)", ShortName = "Delaware (C93-D04) & (300, A01-Z99)", Order = 76)]
        public System.Nullable<System.Int32> PCT0020018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020019", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hopi (D74-D75) & (300, A01-Z99)", ShortName = "Hopi (D74-D75) & (300, A01-Z99)", Order = 77)]
        public System.Nullable<System.Int32> PCT0020019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020020", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Houma (D78-D86) & (300, A01-Z99)", ShortName = "Houma (D78-D86) & (300, A01-Z99)", Order = 78)]
        public System.Nullable<System.Int32> PCT0020020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020021", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Iroquois (D93-E09) & (300, A01-Z99)", ShortName = "Iroquois (D93-E09) & (300, A01-Z99)", Order = 79)]
        public System.Nullable<System.Int32> PCT0020021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020022", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Kiowa (E30-E36) & (300, A01-Z99)", ShortName = "Kiowa (E30-E36) & (300, A01-Z99)", Order = 80)]
        public System.Nullable<System.Int32> PCT0020022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020023", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Lumbee (E78-E83) & (300, A01-Z99)", ShortName = "Lumbee (E78-E83) & (300, A01-Z99)", Order = 81)]
        public System.Nullable<System.Int32> PCT0020023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020024", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Menominee (F11-F14) & (300, A01-Z99)", ShortName = "Menominee (F11-F14) & (300, A01-Z99)", Order = 82)]
        public System.Nullable<System.Int32> PCT0020024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020025", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mexican American Indian (V84-W66) & (300, A01-Z99)", ShortName = "Mexican American Indian (V84-W66) & (300, A01-Z99)", Order = 83)]
        public System.Nullable<System.Int32> PCT0020025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020026", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Navajo  (F62-F70) & (300, A01-Z99)", ShortName = "Navajo  (F62-F70) & (300, A01-Z99)", Order = 84)]
        public System.Nullable<System.Int32> PCT0020026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020027", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Osage (G04-G09) & (300, A01-Z99)", ShortName = "Osage (G04-G09) & (300, A01-Z99)", Order = 85)]
        public System.Nullable<System.Int32> PCT0020027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020028", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Ottawa (G14-G22) & (300, A01-Z99)", ShortName = "Ottawa (G14-G22) & (300, A01-Z99)", Order = 86)]
        public System.Nullable<System.Int32> PCT0020028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020029", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Paiute (G23-G49) & (300, A01-Z99)", ShortName = "Paiute (G23-G49) & (300, A01-Z99)", Order = 87)]
        public System.Nullable<System.Int32> PCT0020029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020030", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Pima (G84-G91) & (300, A01-Z99)", ShortName = "Pima (G84-G91) & (300, A01-Z99)", Order = 88)]
        public System.Nullable<System.Int32> PCT0020030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020031", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Potawatomi (H21-H33) & (300, A01-Z99)", ShortName = "Potawatomi (H21-H33) & (300, A01-Z99)", Order = 89)]
        public System.Nullable<System.Int32> PCT0020031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020032", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Pueblo (H38-H65) & (300, A01-Z99)", ShortName = "Pueblo (H38-H65) & (300, A01-Z99)", Order = 90)]
        public System.Nullable<System.Int32> PCT0020032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020033", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Puget Sound Salish (H70-H92) & (300, A01-Z99)", ShortName = "Puget Sound Salish (H70-H92) & (300, A01-Z99)", Order = 91)]
        public System.Nullable<System.Int32> PCT0020033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020034", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Seminole (J47-J57) & (300, A01-Z99)", ShortName = "Seminole (J47-J57) & (300, A01-Z99)", Order = 92)]
        public System.Nullable<System.Int32> PCT0020034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020035", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Shoshone  (J81-J92) & (300, A01-Z99)", ShortName = "Shoshone  (J81-J92) & (300, A01-Z99)", Order = 93)]
        public System.Nullable<System.Int32> PCT0020035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020036", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Sioux (K16-K53) & (300, A01-Z99)", ShortName = "Sioux (K16-K53) & (300, A01-Z99)", Order = 94)]
        public System.Nullable<System.Int32> PCT0020036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020037", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "South American Indian (W67-X24) & (300, A01-Z99)", ShortName = "South American Indian (W67-X24) & (300, A01-Z99)", Order = 95)]
        public System.Nullable<System.Int32> PCT0020037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020038", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spanish American Indian (X25-Z99) & (300, A01-Z99)", ShortName = "Spanish American Indian (X25-Z99) & (300, A01-Z99)", Order = 96)]
        public System.Nullable<System.Int32> PCT0020038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020039", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tohono O�Odham (K78-K86) & (300, A01-Z99)", ShortName = "Tohono O�Odham (K78-K86) & (300, A01-Z99)", Order = 97)]
        public System.Nullable<System.Int32> PCT0020039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020040", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Ute (L06-L14) & (300, A01-Z99)", ShortName = "Ute (L06-L14) & (300, A01-Z99)", Order = 98)]
        public System.Nullable<System.Int32> PCT0020040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020041", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yakama (L79-L84) & (300, A01-Z99)", ShortName = "Yakama (L79-L84) & (300, A01-Z99)", Order = 99)]
        public System.Nullable<System.Int32> PCT0020041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020042", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yaqui (L91-L99) & (300, A01-Z99)", ShortName = "Yaqui (L91-L99) & (300, A01-Z99)", Order = 100)]
        public System.Nullable<System.Int32> PCT0020042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020043", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yuman (M22-M33) & (300, A01-Z99)", ShortName = "Yuman (M22-M33) & (300, A01-Z99)", Order = 101)]
        public System.Nullable<System.Int32> PCT0020043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020044", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "All other American Indian tribes  (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", ShortName = "All other American Indian tribes  (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", Order = 102)]
        public System.Nullable<System.Int32> PCT0020044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020045", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian tribes, not specified (M41-M43) & (300, A01-Z99)", ShortName = "American Indian tribes, not specified (M41-M43) & (300, A01-Z99)", Order = 103)]
        public System.Nullable<System.Int32> PCT0020045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020046", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaska Native tribes, specified (M52-R98, S01-S99) & (300, A01-Z99):", ShortName = "Alaska Native tribes, specified (M52-R98, S01-S99) & (300, A01-Z99):", Order = 104)]
        public System.Nullable<System.Int32> PCT0020046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020047", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaskan Athabascan (M52-N27) & (300, A01-Z99)", ShortName = "Alaskan Athabascan (M52-N27) & (300, A01-Z99)", Order = 105)]
        public System.Nullable<System.Int32> PCT0020047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020048", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Aleut (R11-R98, S01-S99) & (300, A01-Z99)", ShortName = "Aleut (R11-R98, S01-S99) & (300, A01-Z99)", Order = 106)]
        public System.Nullable<System.Int32> PCT0020048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020049", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Inupiat (N67-P29, P33-P37) & (300, A01-Z99)", ShortName = "Inupiat (N67-P29, P33-P37) & (300, A01-Z99)", Order = 107)]
        public System.Nullable<System.Int32> PCT0020049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020050", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tlingit-Haida (N28-N55, N59-N66) & (300, A01-Z99)", ShortName = "Tlingit-Haida (N28-N55, N59-N66) & (300, A01-Z99)", Order = 108)]
        public System.Nullable<System.Int32> PCT0020050 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020051", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tsimshian (N56-N58) & (300, A01-Z99)", ShortName = "Tsimshian (N56-N58) & (300, A01-Z99)", Order = 109)]
        public System.Nullable<System.Int32> PCT0020051 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020052", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yup'ik (P30-P32, P38-R10) & (300, A01-Z99)", ShortName = "Yup'ik (P30-P32, P38-R10) & (300, A01-Z99)", Order = 110)]
        public System.Nullable<System.Int32> PCT0020052 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020053", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaska Native tribes, not specified (M44-M51) & (300, A01-Z99)", ShortName = "Alaska Native tribes, not specified (M44-M51) & (300, A01-Z99)", Order = 111)]
        public System.Nullable<System.Int32> PCT0020053 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020054", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian or Alaska Native tribes, not specified (300)", ShortName = "American Indian or Alaska Native tribes, not specified (300)", Order = 112)]
        public System.Nullable<System.Int32> PCT0020054 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030001", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total tribes tallied (300, A01-Z99) & (100-299) or (300, A01-Z99)  or (400-999):", ShortName = "Total tribes tallied (300, A01-Z99) & (100-299) or (300, A01-Z99)  or (400-999):", Order = 113)]
        public System.Nullable<System.Int32> PCT0030001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030002", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian tribes, specified (A01-M38, T01-Z99) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "American Indian tribes, specified (A01-M38, T01-Z99) & (100-299) or (300, A01-Z99) or (400-999):", Order = 114)]
        public System.Nullable<System.Int32> PCT0030002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030003", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Apache (A09-A23) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Apache (A09-A23) & (100-299) or (300, A01-Z99) or (400-999)", Order = 115)]
        public System.Nullable<System.Int32> PCT0030003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030004", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Arapaho (A24-A33) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Arapaho (A24-A33) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 116)]
        public System.Nullable<System.Int32> PCT0030004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030005", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Blackfeet (A45-A50) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Blackfeet (A45-A50) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 117)]
        public System.Nullable<System.Int32> PCT0030005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030006", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Canadian and French American Indian (T01-V23) &  (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Canadian and French American Indian (T01-V23) &  (100-299) or (300, A01-Z99) or (400-999)", Order = 118)]
        public System.Nullable<System.Int32> PCT0030006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030007", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Central American Indian (V24-V83) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Central American Indian (V24-V83) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 119)]
        public System.Nullable<System.Int32> PCT0030007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030008", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cherokee (B21-B39) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Cherokee (B21-B39) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 120)]
        public System.Nullable<System.Int32> PCT0030008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030009", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cheyenne (B40-B45) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Cheyenne (B40-B45) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 121)]
        public System.Nullable<System.Int32> PCT0030009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030010", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chickasaw (B53-B56) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Chickasaw (B53-B56) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 122)]
        public System.Nullable<System.Int32> PCT0030010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030011", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chippewa (B67-B99) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Chippewa (B67-B99) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 123)]
        public System.Nullable<System.Int32> PCT0030011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030012", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Choctaw (C08-C16) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Choctaw (C08-C16) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 124)]
        public System.Nullable<System.Int32> PCT0030012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030013", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Colville (C35-C38) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Colville (C35-C38) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 125)]
        public System.Nullable<System.Int32> PCT0030013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030014", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Comanche (C39-C43) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Comanche (C39-C43) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 126)]
        public System.Nullable<System.Int32> PCT0030014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030015", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cree (C59-C63) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Cree (C59-C63) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 127)]
        public System.Nullable<System.Int32> PCT0030015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030016", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Creek (C64-C80) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Creek (C64-C80) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 128)]
        public System.Nullable<System.Int32> PCT0030016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030017", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Crow (C83-C86) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Crow (C83-C86) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 129)]
        public System.Nullable<System.Int32> PCT0030017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030018", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Delaware (C93-D04) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Delaware (C93-D04) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 130)]
        public System.Nullable<System.Int32> PCT0030018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030019", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hopi (D74-D75) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Hopi (D74-D75) & (100-299) or (300, A01-Z99) or (400-999)", Order = 131)]
        public System.Nullable<System.Int32> PCT0030019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030020", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Houma (D78-D86) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Houma (D78-D86) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 132)]
        public System.Nullable<System.Int32> PCT0030020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030021", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Iroquois (D93-E09) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Iroquois (D93-E09) & (100-299) or (300, A01-Z99) or (400-999)", Order = 133)]
        public System.Nullable<System.Int32> PCT0030021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030022", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Kiowa (E30-E36) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Kiowa (E30-E36) & (100-299) or (300, A01-Z99) or (400-999)", Order = 134)]
        public System.Nullable<System.Int32> PCT0030022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030023", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Lumbee (E78-E83) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Lumbee (E78-E83) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 135)]
        public System.Nullable<System.Int32> PCT0030023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030024", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Menominee (F11-F14) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Menominee (F11-F14) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 136)]
        public System.Nullable<System.Int32> PCT0030024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030025", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mexican American Indian (V84-W66) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Mexican American Indian (V84-W66) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 137)]
        public System.Nullable<System.Int32> PCT0030025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030026", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Navajo  (F62-F70) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Navajo  (F62-F70) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 138)]
        public System.Nullable<System.Int32> PCT0030026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030027", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Osage (G04-G09) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Osage (G04-G09) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 139)]
        public System.Nullable<System.Int32> PCT0030027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030028", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Ottawa (G14-G22) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Ottawa (G14-G22) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 140)]
        public System.Nullable<System.Int32> PCT0030028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030029", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Paiute (G23-G49) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Paiute (G23-G49) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 141)]
        public System.Nullable<System.Int32> PCT0030029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030030", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Pima (G84-G91) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Pima (G84-G91) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 142)]
        public System.Nullable<System.Int32> PCT0030030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030031", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Potawatomi (H21-H33) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Potawatomi (H21-H33) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 143)]
        public System.Nullable<System.Int32> PCT0030031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030032", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Pueblo (H38-H65) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Pueblo (H38-H65) & (100-299) or (300, A01-Z99) or (400-999)", Order = 144)]
        public System.Nullable<System.Int32> PCT0030032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030033", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Puget Sound Salish (H70-H92) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Puget Sound Salish (H70-H92) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 145)]
        public System.Nullable<System.Int32> PCT0030033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030034", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Seminole (J47-J57) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Seminole (J47-J57) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 146)]
        public System.Nullable<System.Int32> PCT0030034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030035", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Shoshone (J81-J92) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Shoshone (J81-J92) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 147)]
        public System.Nullable<System.Int32> PCT0030035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030036", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Sioux (K16-K53) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Sioux (K16-K53) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 148)]
        public System.Nullable<System.Int32> PCT0030036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030037", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "South American Indian (W67-X24) & (100-299) or (300, A01-Z99)  or (400-999)", ShortName = "South American Indian (W67-X24) & (100-299) or (300, A01-Z99)  or (400-999)", Order = 149)]
        public System.Nullable<System.Int32> PCT0030037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030038", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spanish American Indian (X25-Z99) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Spanish American Indian (X25-Z99) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 150)]
        public System.Nullable<System.Int32> PCT0030038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030039", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tohono O�Odham (K78-K86) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Tohono O�Odham (K78-K86) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 151)]
        public System.Nullable<System.Int32> PCT0030039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030040", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Ute (L06-L14) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Ute (L06-L14) & (100-299) or (300, A01-Z99) or (400-999)", Order = 152)]
        public System.Nullable<System.Int32> PCT0030040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030041", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yakama (L79-L84) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Yakama (L79-L84) & (100-299) or (300, A01-Z99) or (400-999)", Order = 153)]
        public System.Nullable<System.Int32> PCT0030041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030042", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yaqui (L91-L99) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Yaqui (L91-L99) & (100-299) or (300, A01-Z99) or (400-999)", Order = 154)]
        public System.Nullable<System.Int32> PCT0030042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030043", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yuman (M22-M33) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Yuman (M22-M33) & (100-299) or (300, A01-Z99) or (400-999)", Order = 155)]
        public System.Nullable<System.Int32> PCT0030043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030044", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "All other American Indian tribes (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", ShortName = "All other American Indian tribes (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", Order = 156)]
        public System.Nullable<System.Int32> PCT0030044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030045", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian tribes, not specified (M40-M43) & (100-299)  or (300, A01-Z99) or (400-999)", ShortName = "American Indian tribes, not specified (M40-M43) & (100-299)  or (300, A01-Z99) or (400-999)", Order = 157)]
        public System.Nullable<System.Int32> PCT0030045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030046", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaska Native tribes, specified (M52-R98, S01-S99) & (100-299)  or (300, A01-Z99) or (400-999):", ShortName = "Alaska Native tribes, specified (M52-R98, S01-S99) & (100-299)  or (300, A01-Z99) or (400-999):", Order = 158)]
        public System.Nullable<System.Int32> PCT0030046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030047", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaskan Athabascan (M52-N27) & (100-299) or (300, A01-Z99)  or (400-999)", ShortName = "Alaskan Athabascan (M52-N27) & (100-299) or (300, A01-Z99)  or (400-999)", Order = 159)]
        public System.Nullable<System.Int32> PCT0030047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030048", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Aleut (R11-R98, S01-S99) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Aleut (R11-R98, S01-S99) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 160)]
        public System.Nullable<System.Int32> PCT0030048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030049", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Inupiat (N67-P29, P33-P37) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Inupiat (N67-P29, P33-P37) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 161)]
        public System.Nullable<System.Int32> PCT0030049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030050", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tlingit-Haida (N28-N55, N59-N66) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Tlingit-Haida (N28-N55, N59-N66) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 162)]
        public System.Nullable<System.Int32> PCT0030050 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030051", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tsimshian (N56-N58) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Tsimshian (N56-N58) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 163)]
        public System.Nullable<System.Int32> PCT0030051 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030052", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yup'ik (P30-P32, P38-R10) & (100-299) or (300, A01-Z99)  or (400-999)", ShortName = "Yup'ik (P30-P32, P38-R10) & (100-299) or (300, A01-Z99)  or (400-999)", Order = 164)]
        public System.Nullable<System.Int32> PCT0030052 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030053", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaska Native tribes, not specified (M44-M51, R99) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Alaska Native tribes, not specified (M44-M51, R99) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 165)]
        public System.Nullable<System.Int32> PCT0030053 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030054", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian or Alaska Native tribes, not specified (M39),  (300) & (100-299) or (400-999)", ShortName = "American Indian or Alaska Native tribes, not specified (M39),  (300) & (100-299) or (400-999)", Order = 166)]
        public System.Nullable<System.Int32> PCT0030054 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0040001", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 167)]
        public System.Nullable<System.Int32> PCT0040001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0040002", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian alone (People who reported a specific American Indian tribe only) (A01-M38, T01-Z99)", ShortName = "American Indian alone (People who reported a specific American Indian tribe only) (A01-M38, T01-Z99)", Order = 168)]
        public System.Nullable<System.Int32> PCT0040002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0040003", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaska Native alone (People who reported a specific Alaska Native tribe only) (M52-R98)", ShortName = "Alaska Native alone (People who reported a specific Alaska Native tribe only) (M52-R98)", Order = 169)]
        public System.Nullable<System.Int32> PCT0040003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0040004", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone (People who reported both a specific American Indian tribe(s) and a specific Alaska Native tribe(s) and no other race) (A01-M38, T01-Z99) &  (M52-R98)", ShortName = "American Indian and Alaska Native alone (People who reported both a specific American Indian tribe(s) and a specific Alaska Native tribe(s) and no other race) (A01-M38, T01-Z99) &  (M52-R98)", Order = 170)]
        public System.Nullable<System.Int32> PCT0040004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0040005", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian in combination with one or more other races  (People who reported a specific American Indian tribe and reported one or more other races) (A01-M38, T01-Z99) & (100-299) or (400-999)", ShortName = "American Indian in combination with one or more other races  (People who reported a specific American Indian tribe and reported one or more other races) (A01-M38, T01-Z99) & (100-299) or (400-999)", Order = 171)]
        public System.Nullable<System.Int32> PCT0040005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0040006", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaska Native in combination with one or more other races (People who reported a specific Alaska Native tribe and reported one or more other races) (M52-R98) & (100-299) or (400-999)", ShortName = "Alaska Native in combination with one or more other races (People who reported a specific Alaska Native tribe and reported one or more other races) (M52-R98) & (100-299) or (400-999)", Order = 172)]
        public System.Nullable<System.Int32> PCT0040006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0040007", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native in combination with one or more other races(People who reported both a specific American Indian tribe and a specific Alaska Native tribe and reported 1 or more other races)(A01-M38,T01-Z99)&(M52-R98)&(100-299)or(400-999)", ShortName = "American Indian and Alaska Native in combination with one or more other races(People who reported both a specific American Indian tribe and a specific Alaska Native tribe and reported 1 or more other races)(A01-M38,T01-Z99)&(M52-R98)&(100-299)or(400-999)", Order = 173)]
        public System.Nullable<System.Int32> PCT0040007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0040008", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian or Alaska Native alone (People who marked the American Indian or Alaska Native checkbox only or did not report a specific tribe) (300-399) or (M39-M51, R99)", ShortName = "American Indian or Alaska Native alone (People who marked the American Indian or Alaska Native checkbox only or did not report a specific tribe) (300-399) or (M39-M51, R99)", Order = 174)]
        public System.Nullable<System.Int32> PCT0040008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0040009", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native in combination with 1 or more other races(People who marked the American Indian or Alaska Native checkbox or didn�t provide a specific tribe,and reported 1 or more other races)(300-399)or(M39-M51,R99)&(100-299)or(400-999)", ShortName = "American Indian and Alaska Native in combination with 1 or more other races(People who marked the American Indian or Alaska Native checkbox or didn�t provide a specific tribe,and reported 1 or more other races)(300-399)or(M39-M51,R99)&(100-299)or(400-999)", Order = 175)]
        public System.Nullable<System.Int32> PCT0040009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050001", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (400-479, 481-499):", ShortName = "Total (400-479, 481-499):", Order = 176)]
        public System.Nullable<System.Int32> PCT0050001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050002", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian Indian (400-401)", ShortName = "Asian Indian (400-401)", Order = 177)]
        public System.Nullable<System.Int32> PCT0050002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050003", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bangladeshi (402)", ShortName = "Bangladeshi (402)", Order = 178)]
        public System.Nullable<System.Int32> PCT0050003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050004", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bhutanese (403)", ShortName = "Bhutanese (403)", Order = 179)]
        public System.Nullable<System.Int32> PCT0050004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050005", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Burmese (404)", ShortName = "Burmese (404)", Order = 180)]
        public System.Nullable<System.Int32> PCT0050005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050006", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cambodian (405-409)", ShortName = "Cambodian (405-409)", Order = 181)]
        public System.Nullable<System.Int32> PCT0050006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050007", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chinese (except Taiwanese) (410-411)", ShortName = "Chinese (except Taiwanese) (410-411)", Order = 182)]
        public System.Nullable<System.Int32> PCT0050007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050008", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Filipino (420-421)", ShortName = "Filipino (420-421)", Order = 183)]
        public System.Nullable<System.Int32> PCT0050008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050009", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hmong (422)", ShortName = "Hmong (422)", Order = 184)]
        public System.Nullable<System.Int32> PCT0050009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050010", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Indonesian (423-429)", ShortName = "Indonesian (423-429)", Order = 185)]
        public System.Nullable<System.Int32> PCT0050010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050011", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Japanese (430-439)", ShortName = "Japanese (430-439)", Order = 186)]
        public System.Nullable<System.Int32> PCT0050011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050012", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Korean (440-441)", ShortName = "Korean (440-441)", Order = 187)]
        public System.Nullable<System.Int32> PCT0050012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050013", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Laotian (442)", ShortName = "Laotian (442)", Order = 188)]
        public System.Nullable<System.Int32> PCT0050013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050014", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Malaysian (443)", ShortName = "Malaysian (443)", Order = 189)]
        public System.Nullable<System.Int32> PCT0050014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050015", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nepalese (472)", ShortName = "Nepalese (472)", Order = 190)]
        public System.Nullable<System.Int32> PCT0050015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050016", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Pakistani (445)", ShortName = "Pakistani (445)", Order = 191)]
        public System.Nullable<System.Int32> PCT0050016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050017", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Sri Lankan (446)", ShortName = "Sri Lankan (446)", Order = 192)]
        public System.Nullable<System.Int32> PCT0050017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050018", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Taiwanese (412-419)", ShortName = "Taiwanese (412-419)", Order = 193)]
        public System.Nullable<System.Int32> PCT0050018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050019", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Thai (447-449)", ShortName = "Thai (447-449)", Order = 194)]
        public System.Nullable<System.Int32> PCT0050019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050020", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Vietnamese (450-459)", ShortName = "Vietnamese (450-459)", Order = 195)]
        public System.Nullable<System.Int32> PCT0050020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050021", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Asian, specified (444, 465, 470-471, 473-479)", ShortName = "Other Asian, specified (444, 465, 470-471, 473-479)", Order = 196)]
        public System.Nullable<System.Int32> PCT0050021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050022", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Asian, not specified (460-464, 466-469, 481-499)", ShortName = "Other Asian, not specified (460-464, 466-469, 481-499)", Order = 197)]
        public System.Nullable<System.Int32> PCT0050022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060001", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total Asian categories tallied (400-499) & (400-499):", ShortName = "Total Asian categories tallied (400-499) & (400-499):", Order = 198)]
        public System.Nullable<System.Int32> PCT0060001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060002", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian Indian (400-401) & (400-499)", ShortName = "Asian Indian (400-401) & (400-499)", Order = 199)]
        public System.Nullable<System.Int32> PCT0060002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060003", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bangladeshi (402) & (400-499)", ShortName = "Bangladeshi (402) & (400-499)", Order = 200)]
        public System.Nullable<System.Int32> PCT0060003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060004", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bhutanese (403) & (400-499)", ShortName = "Bhutanese (403) & (400-499)", Order = 201)]
        public System.Nullable<System.Int32> PCT0060004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060005", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Burmese (404) & (400-499)", ShortName = "Burmese (404) & (400-499)", Order = 202)]
        public System.Nullable<System.Int32> PCT0060005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060006", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cambodian (405-409) & (400-499)", ShortName = "Cambodian (405-409) & (400-499)", Order = 203)]
        public System.Nullable<System.Int32> PCT0060006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060007", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chinese (except Taiwanese) (410-411) & (400-499)", ShortName = "Chinese (except Taiwanese) (410-411) & (400-499)", Order = 204)]
        public System.Nullable<System.Int32> PCT0060007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060008", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Filipino (420-421) & (400-499)", ShortName = "Filipino (420-421) & (400-499)", Order = 205)]
        public System.Nullable<System.Int32> PCT0060008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060009", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hmong (422) & (400-499)", ShortName = "Hmong (422) & (400-499)", Order = 206)]
        public System.Nullable<System.Int32> PCT0060009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060010", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Indonesian (423-429) & (400-499)", ShortName = "Indonesian (423-429) & (400-499)", Order = 207)]
        public System.Nullable<System.Int32> PCT0060010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060011", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Japanese (430-439) & (400-499)", ShortName = "Japanese (430-439) & (400-499)", Order = 208)]
        public System.Nullable<System.Int32> PCT0060011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060012", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Korean (440-441) & (400-499)", ShortName = "Korean (440-441) & (400-499)", Order = 209)]
        public System.Nullable<System.Int32> PCT0060012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060013", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Laotian (442) & (400-499)", ShortName = "Laotian (442) & (400-499)", Order = 210)]
        public System.Nullable<System.Int32> PCT0060013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060014", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Malaysian (443) & (400-499)", ShortName = "Malaysian (443) & (400-499)", Order = 211)]
        public System.Nullable<System.Int32> PCT0060014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060015", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nepalese (472) & (400-499)", ShortName = "Nepalese (472) & (400-499)", Order = 212)]
        public System.Nullable<System.Int32> PCT0060015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060016", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Pakistani (445) & (400-499)", ShortName = "Pakistani (445) & (400-499)", Order = 213)]
        public System.Nullable<System.Int32> PCT0060016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060017", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Sri Lankan (446) & (400-499)", ShortName = "Sri Lankan (446) & (400-499)", Order = 214)]
        public System.Nullable<System.Int32> PCT0060017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060018", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Taiwanese (412-419) & (400-499)", ShortName = "Taiwanese (412-419) & (400-499)", Order = 215)]
        public System.Nullable<System.Int32> PCT0060018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060019", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Thai (447-449) & (400-499)", ShortName = "Thai (447-449) & (400-499)", Order = 216)]
        public System.Nullable<System.Int32> PCT0060019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060020", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Vietnamese (450-459) & (400-499)", ShortName = "Vietnamese (450-459) & (400-499)", Order = 217)]
        public System.Nullable<System.Int32> PCT0060020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060021", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Asian, specified (444, 465, 470-471, 473-479) & (400-499)", ShortName = "Other Asian, specified (444, 465, 470-471, 473-479) & (400-499)", Order = 218)]
        public System.Nullable<System.Int32> PCT0060021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060022", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Asian, not specified (460-464, 466-469, 480-499) & (400-499)", ShortName = "Other Asian, not specified (460-464, 466-469, 480-499) & (400-499)", Order = 219)]
        public System.Nullable<System.Int32> PCT0060022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070001", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total Asian categories tallied (400-499) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Total Asian categories tallied (400-499) & (100-299) or (300, A01-Z99) or (400-999):", Order = 220)]
        public System.Nullable<System.Int32> PCT0070001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070002", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian Indian (400-401) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Asian Indian (400-401) & (100-299) or (300, A01-Z99) or (400-999)", Order = 221)]
        public System.Nullable<System.Int32> PCT0070002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070003", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bangladeshi (402) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Bangladeshi (402) & (100-299) or (300, A01-Z99) or (400-999)", Order = 222)]
        public System.Nullable<System.Int32> PCT0070003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070004", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bhutanese (403) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Bhutanese (403) & (100-299) or (300, A01-Z99) or (400-999)", Order = 223)]
        public System.Nullable<System.Int32> PCT0070004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070005", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Burmese (404) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Burmese (404) & (100-299) or (300, A01-Z99) or (400-999)", Order = 224)]
        public System.Nullable<System.Int32> PCT0070005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070006", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cambodian (405-409) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Cambodian (405-409) & (100-299) or (300, A01-Z99) or (400-999)", Order = 225)]
        public System.Nullable<System.Int32> PCT0070006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070007", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chinese (except Taiwanese) (410-411) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Chinese (except Taiwanese) (410-411) & (100-299) or (300, A01-Z99) or (400-999)", Order = 226)]
        public System.Nullable<System.Int32> PCT0070007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070008", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Filipino (420-421) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Filipino (420-421) & (100-299) or (300, A01-Z99) or (400-999)", Order = 227)]
        public System.Nullable<System.Int32> PCT0070008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070009", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hmong (422) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Hmong (422) & (100-299) or (300, A01-Z99) or (400-999)", Order = 228)]
        public System.Nullable<System.Int32> PCT0070009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070010", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Indonesian (423-429) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Indonesian (423-429) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 229)]
        public System.Nullable<System.Int32> PCT0070010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070011", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Japanese (430-439) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Japanese (430-439) & (100-299) or (300, A01-Z99) or (400-999)", Order = 230)]
        public System.Nullable<System.Int32> PCT0070011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070012", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Korean (440-441) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Korean (440-441) & (100-299) or (300, A01-Z99) or (400-999)", Order = 231)]
        public System.Nullable<System.Int32> PCT0070012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070013", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Laotian (442) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Laotian (442) & (100-299) or (300, A01-Z99) or (400-999)", Order = 232)]
        public System.Nullable<System.Int32> PCT0070013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070014", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Malaysian (443) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Malaysian (443) & (100-299) or (300, A01-Z99) or (400-999)", Order = 233)]
        public System.Nullable<System.Int32> PCT0070014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070015", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nepalese (472) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Nepalese (472) & (100-299) or (300, A01-Z99) or (400-999)", Order = 234)]
        public System.Nullable<System.Int32> PCT0070015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070016", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Pakistani (445) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Pakistani (445) & (100-299) or (300, A01-Z99) or (400-999)", Order = 235)]
        public System.Nullable<System.Int32> PCT0070016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070017", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Sri Lankan (446) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Sri Lankan (446) & (100-299) or (300, A01-Z99) or (400-999)", Order = 236)]
        public System.Nullable<System.Int32> PCT0070017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070018", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Taiwanese (412-419) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Taiwanese (412-419) & (100-299) or (300, A01-Z99) or (400-999)", Order = 237)]
        public System.Nullable<System.Int32> PCT0070018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070019", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Thai (447-449) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Thai (447-449) & (100-299) or (300, A01-Z99) or (400-999)", Order = 238)]
        public System.Nullable<System.Int32> PCT0070019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070020", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Vietnamese (450-459) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Vietnamese (450-459) & (100-299) or (300, A01-Z99) or (400-999)", Order = 239)]
        public System.Nullable<System.Int32> PCT0070020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070021", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Asian, specified (444, 465, 470-471, 473-479) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Asian, specified (444, 465, 470-471, 473-479) & (100-299) or (300, A01-Z99) or (400-999)", Order = 240)]
        public System.Nullable<System.Int32> PCT0070021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070022", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Asian, not specified (460-464, 466-469, 480-499) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Asian, not specified (460-464, 466-469, 480-499) & (100-299) or (300, A01-Z99) or (400-999)", Order = 241)]
        public System.Nullable<System.Int32> PCT0070022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080001", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (500-549, 551-599):", ShortName = "Total (500-549, 551-599):", Order = 242)]
        public System.Nullable<System.Int32> PCT0080001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080002", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Polynesian (500-519):", ShortName = "Polynesian (500-519):", Order = 243)]
        public System.Nullable<System.Int32> PCT0080002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080003", Order = 244)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian (500-503)", ShortName = "Native Hawaiian (500-503)", Order = 244)]
        public System.Nullable<System.Int32> PCT0080003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080004", Order = 245)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Samoan (510-511)", ShortName = "Samoan (510-511)", Order = 245)]
        public System.Nullable<System.Int32> PCT0080004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080005", Order = 246)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tongan (513)", ShortName = "Tongan (513)", Order = 246)]
        public System.Nullable<System.Int32> PCT0080005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080006", Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Polynesian (504-509, 512, 514-519)", ShortName = "Other Polynesian (504-509, 512, 514-519)", Order = 247)]
        public System.Nullable<System.Int32> PCT0080006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080007", Order = 248)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Micronesian (520-529, 531-541):", ShortName = "Micronesian (520-529, 531-541):", Order = 248)]
        public System.Nullable<System.Int32> PCT0080007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080008", Order = 249)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Guamanian or Chamorro (520-522)", ShortName = "Guamanian or Chamorro (520-522)", Order = 249)]
        public System.Nullable<System.Int32> PCT0080008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080009", Order = 250)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Marshallese (532)", ShortName = "Marshallese (532)", Order = 250)]
        public System.Nullable<System.Int32> PCT0080009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080010", Order = 251)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Micronesian (523-529, 531, 533-541)", ShortName = "Other Micronesian (523-529, 531, 533-541)", Order = 251)]
        public System.Nullable<System.Int32> PCT0080010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080011", Order = 252)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Melanesian (542-546):", ShortName = "Melanesian (542-546):", Order = 252)]
        public System.Nullable<System.Int32> PCT0080011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080012", Order = 253)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Fijian (542)", ShortName = "Fijian (542)", Order = 253)]
        public System.Nullable<System.Int32> PCT0080012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080013", Order = 254)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Melanesian (543-546)", ShortName = "Other Melanesian (543-546)", Order = 254)]
        public System.Nullable<System.Int32> PCT0080013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080014", Order = 255)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Pacific Islander, not specified (530, 547-549, 551-599)", ShortName = "Other Pacific Islander, not specified (530, 547-549, 551-599)", Order = 255)]
        public System.Nullable<System.Int32> PCT0080014 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00015(string csvLine) : base(csvLine) {}

        public SF1_00015(string[] values) : base(values) {}

        public SF1_00015(OleDbDataReader reader, CensusFileType fileType)
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
                PCT0010001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                PCT0010002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                PCT0010003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                PCT0010004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                PCT0010005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                PCT0010006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                PCT0010007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                PCT0010008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                PCT0010009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                PCT0010010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                PCT0010011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                PCT0010012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                PCT0010013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                PCT0010014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                PCT0010015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                PCT0010016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                PCT0010017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                PCT0010018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                PCT0010019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                PCT0010020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                PCT0010021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                PCT0010022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                PCT0010023 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                PCT0010024 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                PCT0010025 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                PCT0010026 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                PCT0010027 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                PCT0010028 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                PCT0010029 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                PCT0010030 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                PCT0010031 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                PCT0010032 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                PCT0010033 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                PCT0010034 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                PCT0010035 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                PCT0010036 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                PCT0010037 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                PCT0010038 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                PCT0010039 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                PCT0010040 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                PCT0010041 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                PCT0010042 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                PCT0010043 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                PCT0010044 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                PCT0010045 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                PCT0010046 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                PCT0010047 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                PCT0010048 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                PCT0010049 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                PCT0010050 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                PCT0010051 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                PCT0010052 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                PCT0010053 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                PCT0010054 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                PCT0020001 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                PCT0020002 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                PCT0020003 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                PCT0020004 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                PCT0020005 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                PCT0020006 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                PCT0020007 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                PCT0020008 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                PCT0020009 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                PCT0020010 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                PCT0020011 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                PCT0020012 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                PCT0020013 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                PCT0020014 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                PCT0020015 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                PCT0020016 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                PCT0020017 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                PCT0020018 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                PCT0020019 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                PCT0020020 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                PCT0020021 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                PCT0020022 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                PCT0020023 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                PCT0020024 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                PCT0020025 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                PCT0020026 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                PCT0020027 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                PCT0020028 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                PCT0020029 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                PCT0020030 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                PCT0020031 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                PCT0020032 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                PCT0020033 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                PCT0020034 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                PCT0020035 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                PCT0020036 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                PCT0020037 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                PCT0020038 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                PCT0020039 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                PCT0020040 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                PCT0020041 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                PCT0020042 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                PCT0020043 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                PCT0020044 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                PCT0020045 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                PCT0020046 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                PCT0020047 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                PCT0020048 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                PCT0020049 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                PCT0020050 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                PCT0020051 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                PCT0020052 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                PCT0020053 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                PCT0020054 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                PCT0030001 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                PCT0030002 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                PCT0030003 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                PCT0030004 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                PCT0030005 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                PCT0030006 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                PCT0030007 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                PCT0030008 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                PCT0030009 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                PCT0030010 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                PCT0030011 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                PCT0030012 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                PCT0030013 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                PCT0030014 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                PCT0030015 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                PCT0030016 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                PCT0030017 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                PCT0030018 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                PCT0030019 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                PCT0030020 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                PCT0030021 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                PCT0030022 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                PCT0030023 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                PCT0030024 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                PCT0030025 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                PCT0030026 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                PCT0030027 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                PCT0030028 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                PCT0030029 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                PCT0030030 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                PCT0030031 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                PCT0030032 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                PCT0030033 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                PCT0030034 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                PCT0030035 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                PCT0030036 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                PCT0030037 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                PCT0030038 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                PCT0030039 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                PCT0030040 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                PCT0030041 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                PCT0030042 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                PCT0030043 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                PCT0030044 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                PCT0030045 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                PCT0030046 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                PCT0030047 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                PCT0030048 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                PCT0030049 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                PCT0030050 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                PCT0030051 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                PCT0030052 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                PCT0030053 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                PCT0030054 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                PCT0040001 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                PCT0040002 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                PCT0040003 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                PCT0040004 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                PCT0040005 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                PCT0040006 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                PCT0040007 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                PCT0040008 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                PCT0040009 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                PCT0050001 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                PCT0050002 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                PCT0050003 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                PCT0050004 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                PCT0050005 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                PCT0050006 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                PCT0050007 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                PCT0050008 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                PCT0050009 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                PCT0050010 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                PCT0050011 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                PCT0050012 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                PCT0050013 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                PCT0050014 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                PCT0050015 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                PCT0050016 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                PCT0050017 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                PCT0050018 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                PCT0050019 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                PCT0050020 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                PCT0050021 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                PCT0050022 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                PCT0060001 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                PCT0060002 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                PCT0060003 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                PCT0060004 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                PCT0060005 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                PCT0060006 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                PCT0060007 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                PCT0060008 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                PCT0060009 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                PCT0060010 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                PCT0060011 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                PCT0060012 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                PCT0060013 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                PCT0060014 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                PCT0060015 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                PCT0060016 = (System.Nullable<System.Int32>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                PCT0060017 = (System.Nullable<System.Int32>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                PCT0060018 = (System.Nullable<System.Int32>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                PCT0060019 = (System.Nullable<System.Int32>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                PCT0060020 = (System.Nullable<System.Int32>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                PCT0060021 = (System.Nullable<System.Int32>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                PCT0060022 = (System.Nullable<System.Int32>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                PCT0070001 = (System.Nullable<System.Int32>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                PCT0070002 = (System.Nullable<System.Int32>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                PCT0070003 = (System.Nullable<System.Int32>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                PCT0070004 = (System.Nullable<System.Int32>)reader[223];
            }
            if(reader[224] != DBNull.Value)
            {
                PCT0070005 = (System.Nullable<System.Int32>)reader[224];
            }
            if(reader[225] != DBNull.Value)
            {
                PCT0070006 = (System.Nullable<System.Int32>)reader[225];
            }
            if(reader[226] != DBNull.Value)
            {
                PCT0070007 = (System.Nullable<System.Int32>)reader[226];
            }
            if(reader[227] != DBNull.Value)
            {
                PCT0070008 = (System.Nullable<System.Int32>)reader[227];
            }
            if(reader[228] != DBNull.Value)
            {
                PCT0070009 = (System.Nullable<System.Int32>)reader[228];
            }
            if(reader[229] != DBNull.Value)
            {
                PCT0070010 = (System.Nullable<System.Int32>)reader[229];
            }
            if(reader[230] != DBNull.Value)
            {
                PCT0070011 = (System.Nullable<System.Int32>)reader[230];
            }
            if(reader[231] != DBNull.Value)
            {
                PCT0070012 = (System.Nullable<System.Int32>)reader[231];
            }
            if(reader[232] != DBNull.Value)
            {
                PCT0070013 = (System.Nullable<System.Int32>)reader[232];
            }
            if(reader[233] != DBNull.Value)
            {
                PCT0070014 = (System.Nullable<System.Int32>)reader[233];
            }
            if(reader[234] != DBNull.Value)
            {
                PCT0070015 = (System.Nullable<System.Int32>)reader[234];
            }
            if(reader[235] != DBNull.Value)
            {
                PCT0070016 = (System.Nullable<System.Int32>)reader[235];
            }
            if(reader[236] != DBNull.Value)
            {
                PCT0070017 = (System.Nullable<System.Int32>)reader[236];
            }
            if(reader[237] != DBNull.Value)
            {
                PCT0070018 = (System.Nullable<System.Int32>)reader[237];
            }
            if(reader[238] != DBNull.Value)
            {
                PCT0070019 = (System.Nullable<System.Int32>)reader[238];
            }
            if(reader[239] != DBNull.Value)
            {
                PCT0070020 = (System.Nullable<System.Int32>)reader[239];
            }
            if(reader[240] != DBNull.Value)
            {
                PCT0070021 = (System.Nullable<System.Int32>)reader[240];
            }
            if(reader[241] != DBNull.Value)
            {
                PCT0070022 = (System.Nullable<System.Int32>)reader[241];
            }
            if(reader[242] != DBNull.Value)
            {
                PCT0080001 = (System.Nullable<System.Int32>)reader[242];
            }
            if(reader[243] != DBNull.Value)
            {
                PCT0080002 = (System.Nullable<System.Int32>)reader[243];
            }
            if(reader[244] != DBNull.Value)
            {
                PCT0080003 = (System.Nullable<System.Int32>)reader[244];
            }
            if(reader[245] != DBNull.Value)
            {
                PCT0080004 = (System.Nullable<System.Int32>)reader[245];
            }
            if(reader[246] != DBNull.Value)
            {
                PCT0080005 = (System.Nullable<System.Int32>)reader[246];
            }
            if(reader[247] != DBNull.Value)
            {
                PCT0080006 = (System.Nullable<System.Int32>)reader[247];
            }
            if(reader[248] != DBNull.Value)
            {
                PCT0080007 = (System.Nullable<System.Int32>)reader[248];
            }
            if(reader[249] != DBNull.Value)
            {
                PCT0080008 = (System.Nullable<System.Int32>)reader[249];
            }
            if(reader[250] != DBNull.Value)
            {
                PCT0080009 = (System.Nullable<System.Int32>)reader[250];
            }
            if(reader[251] != DBNull.Value)
            {
                PCT0080010 = (System.Nullable<System.Int32>)reader[251];
            }
            if(reader[252] != DBNull.Value)
            {
                PCT0080011 = (System.Nullable<System.Int32>)reader[252];
            }
            if(reader[253] != DBNull.Value)
            {
                PCT0080012 = (System.Nullable<System.Int32>)reader[253];
            }
            if(reader[254] != DBNull.Value)
            {
                PCT0080013 = (System.Nullable<System.Int32>)reader[254];
            }
            if(reader[255] != DBNull.Value)
            {
                PCT0080014 = (System.Nullable<System.Int32>)reader[255];
            }
        }
        #endregion Constructors
    }
}