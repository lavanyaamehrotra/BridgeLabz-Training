//  Split Text into Words and Display Word Lengths
// Hint => 
// Write a method to split text into words without using string.Split(). Use char comparison for spaces.
// Write another method to calculate string length without string.Length.
// Return a 2D array where each row contains the word and its length.
using System;
class TextIntoWords{
  static void Main(string[] args){
    string input = "My Name is Lavanya Mehrotra";
    Console.WriteLine("Word\tLength");
    SplitAndDisplay(input);
  }
  // Method to split text and display word lengths
  static void SplitAndDisplay(string str){
    string word = "";
    for (int i = 0; i < str.Length; i++){
      char c = str[i];
      if (c != ' '){
        word += c; // build current word
      }
      else if (word != ""){
        Console.WriteLine(word + "\t" + GetLength(word));
        word = ""; 
      }
    }
    // Print the last word
    if (word != ""){
      Console.WriteLine(word + "\t" + GetLength(word));
    }
  }

    // Method to calculate string length 
  static int GetLength(string str){
    int count = 0;
    foreach (char c in str){
      count++;
    }
    return count;
  }
}
