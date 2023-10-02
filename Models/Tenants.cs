using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace HousingManagementSystemForAIUBStudents.Models
{
    public class Tenants
    {
        private static SqlConnection connection = Database.GetConnection();

        public Tenants()
        {

        }

        public Tenants(SqlConnection conn)
        {
            Tenants.connection = conn;
        }

        public Tenant AuthenticateUser(string email, string password)
        {
            string query = "";
            Tenant tenant = null;
            Tenants.connection.Open();
            try
            {
                query = String.Format("SELECT * FROM tenant WHERE email='{0}' AND password='{1}'", email, password);

                SqlCommand cmd = new SqlCommand(query, Tenants.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tenant = new Tenant();
                    tenant.Id = reader.GetInt32(reader.GetOrdinal("t_id"));
                    tenant.Name = reader.GetString(reader.GetOrdinal("name"));
                    tenant.Email = reader.GetString(reader.GetOrdinal("email"));
                    tenant.Phone = reader.GetString(reader.GetOrdinal("phone"));
                    tenant.Password = reader.GetString(reader.GetOrdinal("password"));
                }
            }
            catch (Exception ex)
            {
                Tenants.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "User is not Authenticate!\n\n" + ex,
                    "Not Authenticate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Tenants.connection.Close();
            return tenant;
        }

        public bool Create(Tenant tenant)
        {
            string query = "";
            int result = 0;

            Tenants.connection.Open();

            try
            {
                query = String.Format("INSERT INTO tenant VALUES ('{0}','{1}','{2}', '{3}')", tenant.Name, tenant.Email, tenant.Phone, tenant.Password);
                SqlCommand cmd = new SqlCommand(query, Tenants.connection);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Tenants.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "Student Added Unsuccessfull!\n\n" + ex,
                    "ERROR | Student not added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Tenants.connection.Close();
            if (result > 0) return true;

            return false;
        }

        public Tenant GetUser(string email)
        {
            string query = "";
            Tenant tenant = null;

            Tenants.connection.Open();

            try
            {
                query = String.Format("SELECT * FROM tenant WHERE email='{0}'", email);
                SqlCommand cmd = new SqlCommand(query, Tenants.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tenant = new Tenant();
                    tenant.Id = reader.GetInt32(reader.GetOrdinal("t_id"));
                    tenant.Name = reader.GetString(reader.GetOrdinal("name"));
                    tenant.Email = reader.GetString(reader.GetOrdinal("email"));
                    tenant.Phone = reader.GetString(reader.GetOrdinal("phone"));
                    tenant.Password = reader.GetString(reader.GetOrdinal("password"));
                }
            }
            catch (Exception ex)
            {
                Tenants.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "Getting Student Unsuccessfull!\n\n" + ex,
                    "ERROR | Student not Getting",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Tenants.connection.Close();

            return tenant;
        }

        public bool UpdateUser(Tenant tenant, string oldEmail)
        {
            string query = "";
            int r = 0;

            Tenants.connection.Open();

            try
            {
                query = String.Format("UPDATE tenant SET name='{1}', email='{2}', phone='{3}' WHERE email='{0}'", oldEmail, tenant.Name, tenant.Email, tenant.Phone);
                SqlCommand cmd = new SqlCommand(query, Tenants.connection);
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Tenants.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "Student Edit Unsuccessfull!\n\n" + ex,
                    "ERROR | Student not Edited",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Tenants.connection.Close();

            if (r > 0) return true;
            return false;
        }

        public bool DeleteUser(string email)
        {
            string query = "";
            int r = 0;

            Tenants.connection.Open();

            try
            {
                query = String.Format("DELETE FROM tenant WHERE email='{0}'", email);
                SqlCommand cmd = new SqlCommand(query, Tenants.connection);
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Tenants.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "Student Delete Unsuccessfull!\n\n" + ex,
                    "ERROR | Student not Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Tenants.connection.Close();
            if (r > 0) return true;

            return false;
        }

        public bool RentHouse(string houseId, int tenantId)
        {
            string query = "";
            int r = 0;

            Tenants.connection.Open();

            try
            {
                query = String.Format("UPDATE house SET status='0', t_id='{1}' WHERE h_id='{0}'", houseId, tenantId);
                SqlCommand cmd = new SqlCommand(query, Tenants.connection);
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Tenants.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "House Rent Unsuccessfull!\n\n" + ex,
                    "ERROR | House not Rent",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Tenants.connection.Close();

            if (r > 0) return true;
            return false;
        }

        public ArrayList GetAllRentHouse(int tenantId)
        {
            string query = "";
            ArrayList renthouses = new ArrayList();

            Tenants.connection.Open();

            try
            {
                query = String.Format("SELECT * FROM house WHERE t_id={0}", tenantId);
                SqlCommand cmd = new SqlCommand(query, Tenants.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    House house = new House();

                    house.Id = reader.GetInt32(reader.GetOrdinal("h_id"));
                    house.Name = reader.GetString(reader.GetOrdinal("name"));
                    house.Number = reader.GetInt32(reader.GetOrdinal("number"));
                    house.Sector = reader.GetInt32(reader.GetOrdinal("sector"));
                    house.Price = reader.GetString(reader.GetOrdinal("price"));
                    house.Status = reader.GetInt32(reader.GetOrdinal("status"));

                    renthouses.Add(house);
                }

            }
            catch (Exception ex)
            {
                Tenants.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "There is and error to getting house!\n\n" + ex,
                    "Error | Getting House information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Tenants.connection.Close();
            return renthouses;
        }
    }
}
