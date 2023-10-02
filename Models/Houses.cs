using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HousingManagementSystemForAIUBStudents.Models
{
    public class Houses
    {
        private static SqlConnection connection = Database.GetConnection();
        public Houses()
        {

        }

        public ArrayList GetAllHouse()
        {
            string query = "";
            ArrayList houses = new ArrayList();

            Houses.connection.Open();

            try
            {
                query = "SELECT * FROM house";
                SqlCommand cmd = new SqlCommand(query, Houses.connection);
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

                    houses.Add(house);
                }

            }
            catch (Exception ex)
            {
                Houses.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "There is and error to getting house!\n\n" + ex,
                    "Error | Getting House information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Houses.connection.Close();
            return houses;
        }

        public House GetHouse(string houseId)
        {
            string query = "";
            House house = null;

            Houses.connection.Open();

            try
            {
                query = String.Format("SELECT * FROM house WHERE h_id='{0}'", houseId);
                SqlCommand cmd = new SqlCommand(query, Houses.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    house = new House();

                    house.Id = reader.GetInt32(reader.GetOrdinal("h_id"));
                    house.Name = reader.GetString(reader.GetOrdinal("name"));
                    house.Number = reader.GetInt32(reader.GetOrdinal("number"));
                    house.Sector = reader.GetInt32(reader.GetOrdinal("sector"));
                    house.Price = reader.GetString(reader.GetOrdinal("price"));
                    house.Status = reader.GetInt32(reader.GetOrdinal("status"));
                }

            }
            catch (Exception ex)
            {
                Houses.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "There is and error to getting house!\n\n" + ex,
                    "Error | Getting House information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Houses.connection.Close();
            return house;
        }

        public bool AddHouse(House house, string renterId)
        {
            string query = "";
            int result = 0;

            Houses.connection.Open();

            try
            {
                query = String.Format("INSERT INTO house VALUES ('{0}','{1}','{2}', '{3}', '0', '{4}', NULL)", house.Name, house.Number, house.Sector, house.Price, renterId);
                SqlCommand cmd = new SqlCommand(query, Houses.connection);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Houses.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "House Added Unsuccessfull!\n\n" + ex,
                    "ERROR | House not added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Houses.connection.Close();
            if (result > 0) return true;

            return false;
        }

        public bool DeleteHouse(string houseId)
        {
            string query = "";
            int r = 0;

            Houses.connection.Open();

            try
            {
                query = String.Format("DELETE FROM house WHERE h_id='{0}'", houseId);
                SqlCommand cmd = new SqlCommand(query, Houses.connection);
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Houses.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "House Delete Unsuccessfull!\n\n" + ex,
                    "ERROR | House not Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Houses.connection.Close();
            if (r > 0) return true;

            return false;
        }
    }
}
