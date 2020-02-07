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
                    //LogEvent("LoadPeople", ex.Message);
                }

                return dt;
            }

        }

        public static DataTable LoadPeopleType()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //cbLine
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PersonType", connection);
                    da.Fill(dt);
                    DataRow top = dt.NewRow();
                    top[0] = 0;
                    top[1] = "-Select-";
                    dt.Rows.InsertAt(top, 0);
                    da.Dispose();

                    //close the database connection
                    connection.Close();
                }
                catch (Exception ex)
                {
                    //LogEvent("LoadPeopleType", ex.Message);
                }

                return dt;
            }
        }

        public static void PeopleAddEdit(System.Windows.Forms.DataGridViewRow dgvr)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand pcmd = new SqlCommand("PersonAddEdit", connection);
                pcmd.CommandType = CommandType.StoredProcedure;
                if (dgvr.Cells["txtPersonId"].Value == DBNull.Value)
                    pcmd.Parameters.AddWithValue("@PersonId", 0);
                else
                    pcmd.Parameters.AddWithValue("@PersonId", System.Convert.ToInt32(dgvr.Cells["txtPersonId"].Value));
                pcmd.Parameters.AddWithValue("@PersonTypeId", dgvr.Cells["cbPersonType"].Value == null ? 0 : System.Convert.ToInt32(dgvr.Cells["cbPersonType"].Value));
                pcmd.Parameters.AddWithValue("@FirstName", dgvr.Cells["txtFirstName"].Value == null ? "" : dgvr.Cells["txtFirstName"].Value.ToString());
                pcmd.Parameters.AddWithValue("@LastName", dgvr.Cells["txtLastName"].Value == null ? "" : dgvr.Cells["txtLastName"].Value.ToString());
                pcmd.Parameters.AddWithValue("@Phone", dgvr.Cells["txtPhone"].Value == null ? "" : dgvr.Cells["txtPhone"].Value.ToString());
                pcmd.Parameters.AddWithValue("@Email", dgvr.Cells["txtEmail"].Value == null ? "" : dgvr.Cells["txtEmail"].Value.ToString());
                pcmd.ExecuteNonQuery();
            }
        }

        public static void PeopleDelete(System.Windows.Forms.DataGridViewRow dgvr)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand pcmd = new SqlCommand("PersonDeleteById", connection);
                pcmd.CommandType = CommandType.StoredProcedure;
                pcmd.Parameters.AddWithValue("@PersonId", System.Convert.ToInt32(dgvr.Cells["txtPersonId"].Value));
                pcmd.ExecuteNonQuery();
            }
        }
    }

}
