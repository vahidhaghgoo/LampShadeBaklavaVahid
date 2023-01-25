using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Application.Contract.Inventory;

namespace _01_LampshadeQuery.Contracts.Inventory
{
    public interface IInventoryQuery
    {
        StockStatus CheckStock(IsInStock command);
    }
}
