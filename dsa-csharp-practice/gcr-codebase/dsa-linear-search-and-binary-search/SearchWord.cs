using System;
class SearchWord{
    static void Main(){
        Console.Write("Enter number of sentences: ");
        int n = int.Parse(Console.ReadLine());
        string[] sentences = new string[n];
        Console.WriteLine("Enter the sentences:");
        for (int i = 0; i < n; i++){
            sentences[i] = Console.ReadLine();
        }
        Console.Write("\nenter the word to search");
        string word = Console.ReadLine();
        int index = -1;
        // Linear Search
        for (int i = 0; i < sentences.Length; i++){
            if (sentences[i].IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0){
                index = i;
                break;
            }
        }
        if (index != -1){
            Console.WriteLine($"\nfirst sentence containing '{word}' is at index {index}:\n{sentences[index]}");
        }else{
            Console.WriteLine($"\nno sentence contains the word'{word}'.");
        }
    }
}
