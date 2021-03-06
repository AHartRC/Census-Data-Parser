﻿#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2015 3:35 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: Table_Names.cs
// 
// Anthony Hart ("ANTHONY") CONFIDENTIAL
// 
// Unpublished Copyright (c) 1985-2016 Anthony Hart, All Rights Reserved.
// 
// === NOTICE ===
// All information contained herein is, and remains the property of ANTHONY. The intellectual and technical concepts contained
// herein are proprietary to ANTHONY and may be covered by U.S. and Foreign Patents, patents in process, and are protected by trade secret or copyright law.
// Dissemination of this information or reproduction of this material is strictly forbidden unless prior written permission is obtained
// from ANTHONY. Access to the source code contained herein is hereby forbidden to anyone except current ANTHONY employees, managers or contractors who have executed 
// Confidentiality and Non-disclosure agreements explicitly covering such access. 
// 
// The copyright notice above does not evidence any actual or intended publication or disclosure of this source code, which includes 
// information that is confidential and/or proprietary, and is a trade secret, of ANTHONY. ANY REPRODUCTION, MODIFICATION, DISTRIBUTION, PUBLIC PERFORMANCE, 
// OR PUBLIC DISPLAY OF OR THROUGH USE OF THIS SOURCE CODE WITHOUT THE EXPRESS WRITTEN CONSENT OF ANTHONY IS STRICTLY PROHIBITED, AND IN VIOLATION OF APPLICABLE 
// LAWS AND INTERNATIONAL TREATIES. THE RECEIPT OR POSSESSION OF THIS SOURCE CODE AND/OR RELATED INFORMATION DOES NOT CONVEY OR IMPLY ANY RIGHTS 
// TO REPRODUCE, DISCLOSE OR DISTRIBUTE ITS CONTENTS, OR TO MANUFACTURE, USE, OR SELL ANYTHING THAT IT MAY DESCRIBE, IN WHOLE OR IN PART.
// 
// ANTHONY reserves the right to make public any and all contents of this file at the sole discretion of ANTHONY. In such case, licensing included with said publication(s) will supercede this notice only if made public by ANTHONY.
// 
// DISCLAIMERS (When Implemented):
// MAF/TIGER SHAPEFILES AND CENSUS DATA OBTAINED FROM THE US CENSUS BUREAU VIA FTP.
// http://www.census.gov
// ftp://ftp.census.gov
// 
// CRIME/POLICE INFORMATION OBTAINED FROM THE FEDERAL BUREAU OF INVESTIGATIONS VIA HTTP
// http://www.fbi.gov
#endregion

namespace CensusDataParser.Models.SF2
{
    #region Using Directives
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.OleDb;
    using Enumerators;
    #endregion

    public class Table_Names
    {
        [Display(Name = "CELL COUNT", ShortName = "CELL COUNT", Order = 3)]
        public string CELL_COUNT { get; set; }

        [Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
        public int? SORT_ID { get; set; }

        [Display(Name = "TABLE CODE", ShortName = "TABLE CODE", Order = 1)]
        public string TABLE_CODE { get; set; }

        [Display(Name = "TABLE NAME", ShortName = "TABLE NAME", Order = 2)]
        public string TABLE_NAME { get; set; }

        public Table_Names()
        {
            // Empty constructor to ensure JSON operability
        }

        public Table_Names(OleDbDataReader reader, CensusFileType fileType)
        {
            switch (fileType)
            {
                case CensusFileType.SummaryTwo:
                    SORT_ID = (int)reader[0];
                    TABLE_CODE = (string)reader[1];
                    TABLE_NAME = (string)reader[2];
                    CELL_COUNT = (string)reader[3];
                    break;
                case CensusFileType.Redistricting:
                case CensusFileType.AdvanceGroupQuarters:
                case CensusFileType.DemographicProfile:
                case CensusFileType.SummaryOne:
                case CensusFileType.IslandAreas_DPSF:
                case CensusFileType.AIANSummaryFile:
                case CensusFileType.SF1CongressionalDistricts113:
                case CensusFileType.IslandAreas_IASF:
                case CensusFileType.IslandAreasDetailedCrossTabulations:
                case CensusFileType.IslandAreas_PUMS:
                case CensusFileType.Stateside_PUMS:
                    throw new NotImplementedException("The Table Categories table is not included in this specific dataset.");
                default:
                    throw new ArgumentOutOfRangeException(nameof(fileType), fileType, null);
            }
        }

        #region Overrides of Object
        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString() { return $"{SORT_ID} | {TABLE_CODE} | {TABLE_NAME} | {CELL_COUNT}"; }
        #endregion
    }
}
