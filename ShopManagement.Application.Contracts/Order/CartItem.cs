﻿namespace ShopManagement.Application.Contracts.Order;

public class CartItem
{
    public CartItem()
    {
        TotalItemPrice = UnitPrice * Count;
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public double UnitPrice { get; set; }
    public string Picture { get; set; }
    public int Count { get; set; }
    public double TotalItemPrice { get; set; }
    public bool IsInStock { get; set; }
    public int DiscountRate { get; set; }
    public double DiscountAmount { get; set; }
    public double ItemPayAmount { get; set; }
    public string Address { get; set; }

    public void CalculateTotalItemPrice()
    {
        TotalItemPrice = UnitPrice * Count;
    }
}