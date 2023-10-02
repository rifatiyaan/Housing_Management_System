using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousingManagementSystemForAIUBStudents.Models;

namespace HousingManagementSystemForAIUBStudents.Controllers
{
    public class AdminController
    {
        public static dynamic SearchUser(string email, string type)
        {
            dynamic user = null;

            if (type.Equals("Student"))
            {
                user = Database.Instance.Admins.GetTenant(email);
            }
            else if (type.Equals("Renter"))
            {
                user = Database.Instance.Admins.GetRenter(email);
            }

            return user;
        }

        public static bool DeleteUser(string email, string type)
        {
            if (type.Equals("Student"))
            {
                return Database.Instance.Admins.DeleteTenant(email);
            }
            else if (type.Equals("Renter"))
            {
                return Database.Instance.Admins.DeleteRenter(email);
            }

            return false;
        }
    }
}
