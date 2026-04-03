// Number Guessing Game:
// Write a program where the user thinks of a number between 1 and 100, and the computer
// tries to guess the number by generating random guesses.
// ● The user provides reply by indicating whether the guess is high, low, or correct.
// ● The program should be modular, with different functions for generating guesses,
// receiving user reply, and determining the next guess.

using System;
class NumberGuessing{
  static void Main(){
    Console.WriteLine("Choose a number between 1 and 100");
    Console.WriteLine("Type 'h' for higher, 'l' for lower , 'c' for correct.");
    GuessTheNumber();
  }
  static void GuessTheNumber(){
    int minimum = 1;
    int maximum = 100;
    bool guessed = false;
    while (!guessed){
      int guess = generateguess(minimum, maximum);
      Console.WriteLine($"My guess is: {guess}");
      char reply = getreply();
      if (reply == 'c'){
        Console.WriteLine("I found the number");
        guessed = true;
      }else if (reply == 'h'){
        // Guess was too high
        maximum = guess - 1;
      }else if (reply == 'l'){
        // Guess was too low
        minimum = guess + 1;
      }else{
        Console.WriteLine("Invalid input");
      }
      if (minimum > maximum){
        Console.WriteLine("u were incorrect");
        break;
      }
    }
  }
  // Generate a random guess between minimum and maximum
  static int generateguess(int minimum, int maximum){
    Random rand = new Random();
    return rand.Next(minimum, maximum + 1);
  }
  // Get user reply on the guess
  static char getreply(){
    Console.Write("high,low or correct ");
    return Console.ReadLine().ToLower()[0];
  }
}
