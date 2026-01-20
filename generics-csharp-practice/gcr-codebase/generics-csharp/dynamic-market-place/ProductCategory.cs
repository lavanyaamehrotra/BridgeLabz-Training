using System;
public abstract class ProductCategory{
    public string CategoryName { get; set; }
    protected ProductCategory(string name){
        CategoryName = name;
    }
    //display category
    public virtual void DisplayCategory(){
        Console.WriteLine("Category: " + CategoryName);
    }
}
