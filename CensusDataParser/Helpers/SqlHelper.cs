﻿#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 9:00 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SqlHelper.cs
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

namespace CensusDataParser.Helpers
{
    #region Using Directives
    using System;
    using System.Data;
    using System.Data.SqlClient;
    #endregion

    public class SqlHelper
    {
		public static void TruncateTable(string tableName)
		{
			int rowsAffected = 0;
			string sql = $"TRUNCATE TABLE {tableName}";

			using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
			{
				using (SqlCommand cmd = conn.CreateCommand())
				{
					Console.Write($"Truncating records from {tableName}. . . Please wait!");
					cmd.CommandText = sql;
					cmd.CommandType = CommandType.Text;
					cmd.CommandTimeout = 600;

					if (cmd.Connection.State != ConnectionState.Open)
					{
						cmd.Connection.Open();
					}

					rowsAffected = cmd.ExecuteNonQuery();

					cmd.Connection.Close();
				}
			}
			Console.WriteLine($"\r{rowsAffected} records truncated from the {tableName} table");
		}

        public static int BulkCSVInsert(string tableName, string filePath, string fieldTerminator = ",", string rowTerminator = "\n")
        {
            //string fileString = File.ReadAllText(filePath);
            int rowsAffected = 0;

            string sql = $"BULK INSERT {tableName} FROM '{filePath}' WITH (FIELDTERMINATOR = '{fieldTerminator}', ROWTERMINATOR = '{rowTerminator}')";

            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    Console.Write("Bulk inserting CSV records. . . Please wait!");
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 600;

                    if (cmd.Connection.State != ConnectionState.Open)
                    {
                        cmd.Connection.Open();
                    }

                    rowsAffected = cmd.ExecuteNonQuery();

                    cmd.Connection.Close();
                }
            }
            Console.WriteLine($"\r{rowsAffected} CSV records inserted into the {tableName} table from {filePath}");

            return rowsAffected;
        }
    }
}
