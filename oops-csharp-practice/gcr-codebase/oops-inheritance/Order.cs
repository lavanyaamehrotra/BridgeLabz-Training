using System;

// Base Class — Order
class Order{
  public int OrderId;
  public string OrderDate;
  public Order(int orderId, string orderDate){
    OrderId = orderId;
    OrderDate = orderDate;
  }
  public virtual string GetOrderStatus(){
    return "Order Placed";
  }
}

// Subclass — ShippedOrder
class ShippedOrder : Order{
  public string TrackingNumber;
  public ShippedOrder(int orderId, string orderDate, string trackingNumber): base(orderId, orderDate){
    TrackingNumber = trackingNumber;
  }
  public override string GetOrderStatus(){
    return "Order Shipped";
  }
}

// Subclass — DeliveredOrder (Multilevel)
class DeliveredOrder : ShippedOrder{
  public string DeliveryDate;
  public DeliveredOrder(int orderId, string orderDate,string trackingNumber, string deliveryDate): base(orderId, orderDate, trackingNumber){
    DeliveryDate = deliveryDate;
  }
  public override string GetOrderStatus(){
    return "Order Delivered";
  }
}

// Main Class
class OrderSystem{
  static void Main(string[] args){
    DeliveredOrder order = new DeliveredOrder(1002,"10-April-2026","TRK987","14-May-2026");
    Console.WriteLine($"Order ID: {order.OrderId}");
    Console.WriteLine($"Order Date: {order.OrderDate}");
    Console.WriteLine($"Tracking Number: {order.TrackingNumber}");
    Console.WriteLine($"Delivery Date: {order.DeliveryDate}");
    Console.WriteLine($"Status: {order.GetOrderStatus()}");
  }
}
