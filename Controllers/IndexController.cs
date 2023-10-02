using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HousingManagementSystemForAIUBStudents.Models;
using HousingManagementSystemForAIUBStudents.Views.Dashboard;

namespace HousingManagementSystemForAIUBStudents.Controllers
{
    class IndexController
    {
        // LoginTab
        public static Admin AuthenticateUser(Admin admin, Form form)
        {
            Admin user = Database.Instance.Admins.AuthenticateUser(admin.Email, admin.Password);
            if (user != null)
            {
                form.Hide();
                new AdminForm(user).Show();
                return user;
            }
            return null;
        }
        public static Tenant AuthenticateUser(Tenant tenant, Form form)
        {
            Tenant user = Database.Instance.Tenants.AuthenticateUser(tenant.Email, tenant.Password);
            if (user != null)
            {
                form.Hide();
                new TenantForm(user).Show();
                return user;
            }
            return null;
        }
        public static Renter AuthenticateUser(Renter renter, Form form)
        {
            Renter user = Database.Instance.Renters.AuthenticateUser(renter.Email, renter.Password);
            if (user != null)
            {
                form.Hide();
                new RenterForm(user).Show();
                return user;
            }
            return null;
        }

        // RegistrationTab
        public static bool Registration(Tenant tenant)
        {
            return Database.Instance.Tenants.Create(tenant);
        }

        public static bool Registration(Renter renter)
        {
            return Database.Instance.Renters.Create(renter);
        }
    }
}
