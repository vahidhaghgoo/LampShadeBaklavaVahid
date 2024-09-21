﻿using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Application.Contracts.Product;

namespace ShopManagement.Domain.ProductAgg;

public interface IProductRepository : IRepository<long, Product>
{
    List<ProductViewModel> GetProducts();
    EditProduct GetDetails(long id);
    Product GetProductWithCategory(long id);

    List<ProductViewModel> Search(ProductSearchModel searchModel);
}