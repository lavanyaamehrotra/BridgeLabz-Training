using System;
public class ClothingCategory : ProductCategory{
    public string Size { get; set; }
    //clothing category
    public ClothingCategory(string size): base("Clothing"){
        Size = size;
    }
    //display category
    public override void DisplayCategory(){
        Console.WriteLine($"Category: Clothing || Size: {Size}");
    }
}
