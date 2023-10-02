using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using HousingManagementSystemForAIUBStudents.Models;

namespace HousingManagementSystemForAIUBStudents.Controllers
{
    public class RenterController
    {
        public static Renter EditProfile(Renter renter, string oldEmail)
        {
            // Check current user authenticate or not
            if (Database.Instance.Renters.AuthenticateUser(oldEmail, renter.Password) != null)
            {
                bool isUpdate = Database.Instance.Renters.UpdateUser(renter, oldEmail);

                if (isUpdate)
                {
                    return Database.Instance.Renters.GetUser(renter.Email);
                }
            }

            return null;
        }

        public static House GetHouse(string houseId)
        {
            return Database.Instance.Houses.GetHouse(houseId);
        }
        public static ArrayList GetAllHouse()
        {
            return Database.Instance.Houses.GetAllHouse();
        }

        public static bool AddHouse(House house, string renterId)
        {
            return Database.Instance.Houses.AddHouse(house, renterId);
        }

        public static bool DeleteHouse(string houseId)
        {
            return Database.Instance.Houses.DeleteHouse(houseId);
        }
    }
}
