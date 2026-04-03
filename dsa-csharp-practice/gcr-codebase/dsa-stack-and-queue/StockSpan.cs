using System;
class StockSpan{
  static void SpanCalculate(int[] price, int n, int[] span){
    Stack<int> st = new Stack<int>();
    st.Push(0);
    span[0] = 1;
    for (int i = 1; i < n; i++){
      // Pop indices with smaller or equal prices
        while (st.Count > 0 && price[st.Peek()] <= price[i]){
          st.Pop();
        }
        // Calculate span
        span[i] = (st.Count == 0) ? (i + 1) : (i - st.Peek());
        // Push current index
        st.Push(i);
    }
  }
  static void Main(){
    int[] price = { 100, 80, 60, 70, 60, 75, 85 };
    int n = price.Length;
    int[] span = new int[n];
    SpanCalculate(price, n, span);
    Console.WriteLine("Stock Prices:");
    for (int i = 0; i < n; i++){
      Console.Write(price[i] + " ");
    }
    Console.WriteLine("\nStock Span:");
      for (int i = 0; i < n; i++){
        Console.Write(span[i] + " ");
      }
  }
}
