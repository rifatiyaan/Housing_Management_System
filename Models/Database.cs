using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HousingManagementSystemForAIUBStudents.Models
{
    public sealed class Database
    {
        private static string serverName = @"NOBIR\SQLEXPRESS";
        //private static string serverName = @"DESKTOP-AHJQ59S\SQLEXPRESS";
        //private static string serverName = @"SHAHRAIRSOJIBPC\SQLEXPRESS";
        //private static string serverName = @"SAJJAD\SQLEXPRESS";

        private static string databaseName = @"hmsaiubs";
        private static string connectionString = String.Format(@"Server={0};Database={1};Integrated Security=true;", serverName, databaseName);
        private static Database instance = null;
        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            } 
        }
        private Database()
        {
            this.Admins = new Admins();
            this.Tenants = new Tenants();
            this.Renters = new Renters();
            this.Houses = new Houses();
        }

        public Admins Admins { get; set; }
        public Tenants Tenants { get; set; }
        public Renters Renters { get; set; }
        public Houses Houses { get; set; }
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
