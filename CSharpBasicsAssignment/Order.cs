using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsAssignment;

public struct Point
{
    public int X;
    public int Y;
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public static void RunValueVsReferenceDemo()
    {
        // The difference occurred because struct is a value type, that create copy of the data when copying, passing it in method, ...
        Point p1 = new Point(1, 2);
        Point p2 = p1;
        p2.X = 99;
        Console.WriteLine($"P1: {p1.X}, P2:{p2.X}");
    }
}
public class Order
{
    // Enter 9 fields to Calculate Total Price only from method
    public Order(int orderId, string customerName, int quantity, decimal unitPrice,
                 bool isPaid, double discountPercent, string shippingCity, char priority, long itemCode)
    {
        OrderId = orderId;
        CustomerName = customerName;
        Quantity = quantity;
        UnitPrice = unitPrice;
        IsPaid = isPaid;
        DiscountPercent = discountPercent;
        ShippingCity = shippingCity;
        Priority = priority;
        ItemCode = itemCode;
    
        // Calculate Total Price
        CalculatePrice(Quantity, UnitPrice, DiscountPercent);
    }
    
    public int OrderId;
    public string CustomerName;
    public int Quantity;
    public decimal UnitPrice;
    public decimal TotalPrice;
    public bool IsPaid;
    public double DiscountPercent;
    public string ShippingCity;
    public char Priority;
    public long ItemCode;
    
    public void CalculatePrice(int Quantity, decimal UnitPrice, double DiscountPercent)
    {
        TotalPrice = (Quantity * UnitPrice * (decimal)(1 - DiscountPercent / 100));
    }
    
    public void PrintSummary()
    {
        Console.WriteLine($"Order Data: Minimul Order Id: {OrderId}, Price: {TotalPrice}, Pay Statu: {IsPaid}.");
    }
}


/* Heap & Stack --- value type & reference type
 ِAll Primitive data storing in stack, All reference data store inside heap
 If I create variable and make it equal old object from the same class type, no other object has being created because reference types carries reference of the object place in memory not data actually
*/