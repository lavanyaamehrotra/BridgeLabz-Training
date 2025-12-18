using System;
namespace ProgrammingElements{
    class PalindromeNo{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            int rv = 0;
            int duplicate = n;
            while (n > 0){
                int ld = n % 10;
                rv = rv * 10 + ld;
                n = n / 10;
            }
            // matching if the original and the reverse numbers are same
            if (rv == duplicate){
                Console.WriteLine("YES");
            }
            else{
                Console.WriteLine("NO");
            }
        }
    }
}
