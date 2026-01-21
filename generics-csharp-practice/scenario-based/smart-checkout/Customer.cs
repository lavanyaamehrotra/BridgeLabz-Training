using System.Collections.Generic;
public class Customer{
    public string Name { get; set; }
    public Dictionary<string, int> Cart { get; set; }
    public Customer(string name){
        Name = name;
        Cart = new Dictionary<string, int>();
    }
    //add item
    public void AddItem(string item, int qty){
        if (Cart.ContainsKey(item)){
            Cart[item] += qty;
        }else{
            Cart[item] = qty;
        }
    }
}
