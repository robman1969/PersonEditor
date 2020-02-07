using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PersonEditor.DataAccess
{
    public class DataCommon
    {
        static string connectionString = "Data Source = yew.arvixe.com; Initial Catalog = GST_RSTEST;Uid=GST_RS;Pwd=3l3v3n!;";

        public static DataTable LoadPeople()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmdGauges = new SqlCommand("GST_RS.[GetPeople]", connection);
                cmdGauges.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();

                    //cbLine
                    SqlDataAdapter da = new SqlDataAdapter(cmdGauges);
                    da.Fill(dt);
                    da.Dispose();

                    //close the database connection
                    connection.Close();
                }
                catch (Exception ex)
                {
                    //LogEvent("LoadGauges", ex.Message);
                }

                return dt;
            }

        }
    }
}
