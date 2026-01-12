using System;
public class WasteAwareCutting{
    //function to calculate the maximum revenue with waste
    public int MaximumRevenueWithWaste(WoodRod rod, PriceChart chart, int maxWaste){
        return CutWaste(rod.Length, chart, maxWaste);
    }
    //function for cutt waste
    private int CutWaste(int len, PriceChart chart, int wasteLeft){
        if (len == 0 || wasteLeft < 0){
            return 0;
        }
        int max = 0;
        for (int i = 1; i <= len; i++){
            int waste = len - i;
            if (waste <= wasteLeft){
                int current = chart.GetPrice(i) + CutWaste(len - i, chart, wasteLeft - waste);
                if (current > max){
                    max = current;
                }
            }
        }
        return max;
    }
}
