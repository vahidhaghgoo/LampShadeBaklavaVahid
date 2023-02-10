using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;

namespace DiscountManagement.Configuration.Permissions
{
    public class DiscountPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "ColleagueDiscounts", new List<PermissionDto>
                    {
                        new PermissionDto(DiscountPermissions.ListColleagueDiscounts, "ListInventory"),
                        new PermissionDto(DiscountPermissions.SearchColleagueDiscounts, "SearchInventory"),
                        new PermissionDto(DiscountPermissions.CreateColleagueDiscounts, "CreateInventory"),
                        new PermissionDto(DiscountPermissions.EditColleagueDiscounts, "EditInventory"),
                        new PermissionDto(DiscountPermissions.RestoreColleagueDiscounts, "Increase"),
                        new PermissionDto(DiscountPermissions.RemoveColleagueDiscounts, "Reduce"),
                    }
                },
                {
                    "CustomerDiscounts", new List<PermissionDto>
                    {
                        new PermissionDto(DiscountPermissions.ListCustomerDiscounts, "ListCustomerDiscounts"),
                        new PermissionDto(DiscountPermissions.SearchCustomerDiscounts, "SearchCustomerDiscounts"),
                        new PermissionDto(DiscountPermissions.CreateCustomerDiscounts, "CreateCustomerDiscounts"),
                        new PermissionDto(DiscountPermissions.EditCustomerDiscounts, "EditCustomerDiscounts"),
                        new PermissionDto(DiscountPermissions.RestoreCustomerDiscounts, "RestoreCustomerDiscounts"),
                        new PermissionDto(DiscountPermissions.RemoveCustomerDiscounts, "RemoveCustomerDiscounts"),
                    }
                }
            };
        }
    }
}
