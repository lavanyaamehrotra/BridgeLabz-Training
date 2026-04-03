using System;
public static class DiscountService{
    //apply discount
    public static void ApplyDiscount<T>(T product, double percentage)where T : class{
        dynamic p = product;
        double discountAmount = p.Price * (percentage / 100);
        p.Price -= discountAmount;
        Console.WriteLine($"Discount Applied: {percentage}%");
        Console.WriteLine($"New Price: ₹{p.Price}");
    }
}
