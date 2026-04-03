using System;
using System.Collections.Generic;
using System.Linq;
class LexicalTwist{
    static bool IsValidWord(string word){
        // More than one word check (space present)
        return !word.Contains(" ");
    }
    static bool IsVowel(char c){
        return "AEIOU".Contains(c);
    }
    static void Main(){
        Console.WriteLine("Enter the first word");
        string first = Console.ReadLine();
        if (!IsValidWord(first)){
            Console.WriteLine(first + " is an invalid word");
            return;
        }
        Console.WriteLine("Enter the second word");
        string second = Console.ReadLine();
        if (!IsValidWord(second)){
            Console.WriteLine(second + " is an invalid word");
            return;
        }
        // Check if second word is reverse of first (case-insensitive)
        string reversedFirst = new string(first.Reverse().ToArray());
        if (string.Equals(reversedFirst, second, StringComparison.OrdinalIgnoreCase)){
            // Step 1 & 2: Reverse + lowercase
            string transformed = reversedFirst.ToLower();
            // Step 3: Replace vowels with '@'
            char[] result = transformed.ToCharArray();
            for (int i = 0; i < result.Length; i++){
                if ("aeiou".Contains(result[i])){
                    result[i] = '@';
                }
            }
            Console.WriteLine(new string(result));
        }
        else{
            // Combine and convert to uppercase
            string combined = (first + second).ToUpper();
            int vowelCount = 0, consonantCount = 0;
            foreach (char c in combined){
                if (IsVowel(c)){
                    vowelCount++;
                }else{
                    consonantCount++;
                }
            }
            if (vowelCount > consonantCount){
                // First 2 unique vowels
                HashSet<char> seen = new HashSet<char>();
                string output = "";
                foreach (char c in combined){
                    if (IsVowel(c) && seen.Add(c)){
                        output += c;
                        if (output.Length == 2){
                            break;
                        }
                    }
                }
                Console.WriteLine(output);
            }
            else if (consonantCount > vowelCount){
                // First 2 unique consonants
                HashSet<char> seen = new HashSet<char>();
                string output = "";
                foreach (char c in combined){
                    if (!IsVowel(c) && seen.Add(c)){
                        output += c;
                        if (output.Length == 2){
                            break;
                        }
                    }
                }
                Console.WriteLine(output);
            }
            else{
                Console.WriteLine("Vowels and consonants are equal");
            }
        }
    }
}
