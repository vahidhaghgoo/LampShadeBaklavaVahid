using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace DiscountManagement.Configuration.Permissions;

public class DiscountPermissionExposer : IPermissionExposer
{
    public Dictionary<string, List<PermissionDto>> Expose()
    {
        return new Dictionary<string, List<PermissionDto>>
        {
            {
                "ColleagueDiscounts", new List<PermissionDto>
                {
                    new(DiscountPermissions.ListColleagueDiscounts, "ListInventory"),
                    new(DiscountPermissions.SearchColleagueDiscounts, "SearchInventory"),
                    new(DiscountPermissions.CreateColleagueDiscounts, "CreateInventory"),
                    new(DiscountPermissions.EditColleagueDiscounts, "EditInventory"),
                    new(DiscountPermissions.RestoreColleagueDiscounts, "Increase"),
                    new(DiscountPermissions.RemoveColleagueDiscounts, "Reduce")
                }
            },
            {
                "CustomerDiscounts", new List<PermissionDto>
                {
                    new(DiscountPermissions.ListCustomerDiscounts, "ListCustomerDiscounts"),
                    new(DiscountPermissions.SearchCustomerDiscounts, "SearchCustomerDiscounts"),
                    new(DiscountPermissions.CreateCustomerDiscounts, "CreateCustomerDiscounts"),
                    new(DiscountPermissions.EditCustomerDiscounts, "EditCustomerDiscounts"),
                    new(DiscountPermissions.RestoreCustomerDiscounts, "RestoreCustomerDiscounts"),
                    new(DiscountPermissions.RemoveCustomerDiscounts, "RemoveCustomerDiscounts")
                }
            }
        };
    }
}