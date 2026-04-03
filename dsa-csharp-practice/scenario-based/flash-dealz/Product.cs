class Product{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Discount { get; set; }
    public void Display(){
        Console.WriteLine($"{ProductId}\t{ProductName}\t{Discount}");
    }
}
