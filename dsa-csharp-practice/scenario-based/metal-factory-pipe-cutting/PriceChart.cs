public class PriceChart{
    public int[] Prices;
    //function foor price chart
    public PriceChart(int size){
        Prices =new int [size+1];
    }
    //function to add the price
    public void AddPrice(int length,int price){
        Prices[length]=price;
    }
    //function to get the price
    public int GetPrice(int length){
        return Prices[length];
    }
}