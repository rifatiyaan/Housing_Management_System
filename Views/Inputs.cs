using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagementSystemForAIUBStudents.Views
{
    enum Inputs
    {
        AdminSearchUserEmail,
        AdminSarchUserButton,

        AdminDeleteUserEmail,
        AdminDeleteUserButton,

        IndexLoginEmail,
        IndexLoginPassword,
        IndexLoginButton,

        IndexRegName,
        IndexRegEmail,
        IndexRegPhone,
        IndexRegPassword,
        IndexRegConfirmPassword,
        IndexRegButton,

        TenantEditName,
        TenantEditEmail,
        TenantEditPhone,
        TenantEditButton,

        TenantViewHouseId,
        TenantSearchButton,

        TenantRentHouseId,
        TenantRentButton,

        RenterEditName,
        RenterEditEmail,
        RenterEditPhone,
        RenterEditButton,

        RenterViewHouseId,
        RenterSearchHouseButton,

        RenterAddHouseName,
        RenterAddHouseNumber,
        RenterAddHouseSector,
        RenterAddHousePrize,
        RenterAddHouseButton,

        RenterDeleteHouseId,
        RenterDeleteHouseButton,
    }
}
