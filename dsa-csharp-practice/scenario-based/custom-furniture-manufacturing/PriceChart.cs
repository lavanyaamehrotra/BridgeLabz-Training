public class PriceChart{
    public int[] Prices;
    public PriceChart(int size){
        Prices = new int[size + 1];
    }
    //function for add price
    public void AddPrice(int len, int price){
        Prices[len] = price;
    }
    //function for get price
    public int GetPrice(int len){
        return Prices[len];
    }
}
