using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using HousingManagementSystemForAIUBStudents.Models;

namespace HousingManagementSystemForAIUBStudents.Controllers
{
    public class TenantController
    {
        public static Tenant EditProfile(Tenant tenant, string oldEmail)
        {
            // Check current user authenticate or not
            if (Database.Instance.Tenants.AuthenticateUser(oldEmail, tenant.Password) != null)
            {
                bool isUpdate = Database.Instance.Tenants.UpdateUser(tenant, oldEmail);

                if (isUpdate)
                {
                    return Database.Instance.Tenants.GetUser(tenant.Email);
                }
            }

            return null;
        }

        public static ArrayList GetAllHouse()
        {
            return Database.Instance.Houses.GetAllHouse();
        }

        public static House GetHouse(string houseId)
        {
            return Database.Instance.Houses.GetHouse(houseId);
        }

        public static bool RentHouse(string houseId, int tenantId)
        {
            return Database.Instance.Tenants.RentHouse(houseId, tenantId);
        }

        public static ArrayList GetAllRentHouse(int tenantId)
        {
            return Database.Instance.Tenants.GetAllRentHouse(tenantId);
        }
    }
}
