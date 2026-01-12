using System;
public class CutSuggestion{
    //cut suggestion 
    public void SuggestCuts(int len, PriceChart chart){
        Console.WriteLine("\nSuggested cut combinations:");
        Suggest(len, chart, "");
    }
    //suggest
    private void Suggest(int len, PriceChart chart, string path){
        if (len == 0){
            Console.WriteLine(path);
            return;
        }
        for (int i = 1; i <= len; i++){
            Suggest(len - i, chart, path + i);
        }
    }
}
