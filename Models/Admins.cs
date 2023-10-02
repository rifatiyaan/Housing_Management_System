using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HousingManagementSystemForAIUBStudents.Models
{
    public class Admins
    {
        private static SqlConnection connection = Database.GetConnection();

        public Admins()
        {

        }

        public Admins(SqlConnection conn)
        {
            Admins.connection = conn;
        }

        public Admin AuthenticateUser(string email, string password)
        {
            string query = "";
            Admin admin = null;
            Admins.connection.Open();
            try
            {
                query = String.Format("SELECT * FROM admin WHERE email='{0}' AND password='{1}'", email, password);

                SqlCommand cmd = new SqlCommand(query, Admins.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    admin = new Admin();
                    admin.Id = reader.GetInt32(reader.GetOrdinal("a_id"));
                    admin.Name = reader.GetString(reader.GetOrdinal("name"));
                    admin.Email = reader.GetString(reader.GetOrdinal("email"));
                    admin.Password = reader.GetString(reader.GetOrdinal("password"));
                }
            }
            catch (Exception ex)
            {
                Admins.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "User is not Authenticate!\n\n" + ex,
                    "Not Authenticate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Admins.connection.Close();
            return admin;
        }

        public Tenant GetTenant(string email)
        {
            return Database.Instance.Tenants.GetUser(email);
        }

        public Renter GetRenter(string email)
        {
            return Database.Instance.Renters.GetUser(email);
        }

        public bool DeleteTenant(string email)
        {
            return Database.Instance.Tenants.DeleteUser(email);
        }

        public bool DeleteRenter(string email)
        {
            return Database.Instance.Renters.DeleteUser(email);
        }
    }
}
