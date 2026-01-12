public class PriceChart{
    public int[] Prices;
    public PriceChart(int size){
        Prices =new int [size+1];
    }
    public void AddPrice(int length,int price){
        Prices[length]=price;
    }
    public int GetPrice(int length){
        return Prices[length];
    }
}