using System.Data;
using System.Data.SqlClient;

namespace Winggit.Controls
{
    static class DBFunctions
    {
        internal static DataSet GetDataset(string sql)
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
    }
}
