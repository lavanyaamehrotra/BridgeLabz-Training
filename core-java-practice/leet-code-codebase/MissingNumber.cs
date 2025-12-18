using System;
namespace leet-code-codebase{
    class MissingNo{
        public static int MissingNumber(int[] a, int N){
            // Outer loop that runs from 1 to N
            for (int i = 1; i <= N; i++){
                // flag variable to check if element exists
                int flag = 0;
                // searching the element using linear search
                for (int j = 0; j < N - 1; j++){
                    if (a[j] == i){
                        flag = 1;
                        break;
                    }
                }
                // if element is missing
                if (flag == 0)
                    return i;
            }
            return -1;
        }
        static void Main(string[] args){
            int N = 5;
            int[] a = { 1, 2, 4, 5 };
            int ans = MissingNumber(a, N);
            Console.WriteLine("The missing number is: " + ans);
        }
    }
}
