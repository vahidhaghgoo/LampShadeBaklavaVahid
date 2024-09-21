﻿using _0_Framework.Domain;

namespace ShopManagement.Domain.OrderAgg;

public class OrderItem : EntityBase
{
    public OrderItem(long productId, int count, double unitPrice, int discountRate, string address)
    {
        ProductId = productId;
        Count = count;
        UnitPrice = unitPrice;
        DiscountRate = discountRate;
        Address = address;
    }

    protected OrderItem()
    {

    }

    public long ProductId { get; private set; }
    public int Count { get; private set; }
    public double UnitPrice { get; private set; }
    public int DiscountRate { get; private set; }
    public long OrderId { get; }
    public string Address { get; private set; }
    public Order Order { get; }
}