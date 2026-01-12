public class RecursiveCutting{
    public int MaxRevenue(Rod rod, PriceChart chart){
        return Cut(rod.Length,chart);
    }
    public int Cut(int len,PriceChart chart){
        if (len == 0){
            return 0;
        }
        int max=0;
        for(int i = 1; i <= len; i++){
            int current=chart.GetPrice(i)+Cut(len-i,chart);
            if (current > max){
                max=current;
            }
            return max;
        }
    }
}