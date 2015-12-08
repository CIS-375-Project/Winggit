using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Winggit.Controls
{
    static class DBFunctions
    {
        /// <summary>
        /// Pass in a static SQL Query and get back a DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        internal static DataSet GetDataSet(string sql)
        {
            using (DataSet oDataSet = new DataSet())
            {
                using (SqlConnection oConnection = new SqlConnection(@"server=winggit.ddns.net\winggit_sql;database=winggit;uid=winggit_app;pwd=C@iro$88"))
                {
                    using (SqlCommand oCommand = new SqlCommand(sql, oConnection))
                    {
                        using (SqlDataAdapter oSqlDataAdaptor = new SqlDataAdapter(oCommand))
                        {
                            oSqlDataAdaptor.Fill(oDataSet);
                        }
                    }
                }
                return oDataSet;
            }
        }

        /// <summary>
        /// Pass in dynamic SQL Query with Parameter List
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
                        foreach(DictionaryEntry element in oParmList)
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
    }
}
