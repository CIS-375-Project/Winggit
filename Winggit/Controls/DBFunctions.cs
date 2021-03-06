﻿using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Winggit.Controls
{
    internal static class DBFunctions
    {
        /// <summary>
        /// Pass in parameterized SQL Query with Parameter List
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="oParmList"></param>
        /// <returns></returns>
        internal static DataSet GetDataSet(string sql, Hashtable oParmList)
        {
            using (DataSet oDataSet = new DataSet())
            {
                using (SqlConnection oConnection = new SqlConnection(@"server=winggit.ddns.net\winggit_sql;database=winggit;uid=winggit_app;pwd=C@iro$88"))
                {
                    using (SqlCommand oCommand = new SqlCommand(sql, oConnection))
                    {
                        foreach (DictionaryEntry element in oParmList)
                        {
                            string sKey = element.Key.ToString();
                            oCommand.Parameters.AddWithValue(sKey, element.Value);
                        }

                        using (SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter(oCommand))
                        {
                            oSqlDataAdapter.Fill(oDataSet);
                        }
                    }
                }
                return oDataSet;
            }
        }

        /// <summary>
        /// Run a query where no result is expected
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="oParmList"></param>
        internal static void RunQuery(string sql, Hashtable oParmList)
        {
            using (SqlConnection oConnection = new SqlConnection(@"server=winggit.ddns.net\winggit_sql;database=winggit;uid=winggit_app;pwd=C@iro$88"))
            {
                using (SqlCommand oCommand = new SqlCommand(sql, oConnection))
                {
                    oConnection.Open();
                    foreach (DictionaryEntry element in oParmList)
                    {
                        string sKey = element.Key.ToString();
                        oCommand.Parameters.AddWithValue(sKey, element.Value);
                    }
                    oCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
