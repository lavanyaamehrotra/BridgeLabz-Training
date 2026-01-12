public class Cutting{
    public int Revenue(Rod rod ,PriceChart chart){
        return chart.GetPrice(rod.Length);
    }
}