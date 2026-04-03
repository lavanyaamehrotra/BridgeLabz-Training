public class Cutting{
    //Revenue method
    public int Revenue(Rod rod ,PriceChart chart){
        return chart.GetPrice(rod.Length);
    }
}