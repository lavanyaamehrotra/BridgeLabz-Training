using System;
class SentenceFormatter{
  static string FormatParagraphText(string inputText){
    if (inputText == null || inputText.Length == 0)
      return "";
    char[] formattedCharacters = new char[inputText.Length * 2];
    int indexOfFormatted = 0;
    bool NextCapital = true;
    bool spaceLeft = false;
    for (int currentPos = 0; currentPos < inputText.Length; currentPos++){
      char currentChar = inputText[currentPos];
      // Ignore leading spaces
        if (indexOfFormatted == 0 && currentChar == ' ')
          continue;
          // Handle multiple spaces
          if (currentChar == ' '){
            if (spaceLeft){
              formattedCharacters[indexOfFormatted++] = ' ';
              spaceLeft = false;
            }
            continue;
          }
          // Capitalize first character of each sentence
          if (NextCapital && currentChar >= 'a' && currentChar <= 'z'){
            currentChar = (char)(currentChar - 32);
            NextCapital = false;
          }
          formattedCharacters[indexOfFormatted++] = currentChar;
          spaceLeft = true;
          // sentence-ending punctuation
          if (currentChar == '.' || currentChar == '?' || currentChar == '!'){
            NextCapital = true;
            // Insert space after punctuation if not end of text
            if (currentPos < inputText.Length - 1){
              formattedCharacters[indexOfFormatted++] = ' ';
              spaceLeft = false;
            }
          }
      }
      // Remove trailing space manually (no Trim used)
      if (indexOfFormatted > 0 && formattedCharacters[indexOfFormatted - 1] == ' ')
        indexOfFormatted--;
      return new string(formattedCharacters, 0, indexOfFormatted);
    }
     // ---------- PARAGRAPH ANALYSIS ----------
  static void AnalyzeParagraphText(string paragraphText, string targetWord, string replacementWord){
    if (paragraphText == null || paragraphText.Length == 0){
      Console.WriteLine("Word Count: 0");
      Console.WriteLine("Longest Word: None");
      return;
    }
    int totalWordCount = 0;
    int longestWordLength = 0;
    string longestWord = "";
    char[] currentWordCharacters = new char[paragraphText.Length];
    int currentWordIndex = 0;
    char[] updatedParagraphCharacters = new char[paragraphText.Length * 2];
    int updatedParagraphIndex = 0;
    for (int position = 0; position <= paragraphText.Length; position++){
      char currentChar = (position == paragraphText.Length) ? ' ' : paragraphText[position];
      if (currentChar != ' '){
        currentWordCharacters[currentWordIndex++] = currentChar;
      }else if (currentWordIndex > 0){
        totalWordCount++;
        // Determine longest word
          if (currentWordIndex > longestWordLength){
            longestWordLength = currentWordIndex;
            longestWord = new string(currentWordCharacters, 0, currentWordIndex);
          }
          // Replace target word (case-insensitive)
          bool isMatch = CompareWordsIgnoringCase(currentWordCharacters,currentWordIndex,targetWord);
          if (isMatch){
            for (int i = 0; i < replacementWord.Length; i++)
                updatedParagraphCharacters[updatedParagraphIndex++] = replacementWord[i];
          }else{
            for (int i = 0; i < currentWordIndex; i++)
              updatedParagraphCharacters[updatedParagraphIndex++] = currentWordCharacters[i];
            }
            updatedParagraphCharacters[updatedParagraphIndex++] = ' ';
            currentWordIndex = 0;
      }
    }
    // Remove trailing space manually
    if (updatedParagraphIndex > 0 && updatedParagraphCharacters[updatedParagraphIndex - 1] == ' '){
      updatedParagraphIndex--;
    }
    Console.WriteLine("Word Count: " + totalWordCount);
    Console.WriteLine("Longest Word: " + longestWord);
    Console.WriteLine("Updated Paragraph: " +
    new string(updatedParagraphCharacters, 0, updatedParagraphIndex));
  }

    // ---------- CASE-INSENSITIVE WORD COMPARISON ----------
  static bool CompareWordsIgnoringCase(char[] wordCharacters, int wordLength, string targetWord){
    if (wordLength != targetWord.Length)
      return false;
    for (int index = 0; index < wordLength; index++){
      char firstCharacter = wordCharacters[index];
      char secondCharacter = targetWord[index];
      if (firstCharacter >= 'A' && firstCharacter <= 'Z')
        firstCharacter = (char)(firstCharacter + 32);
      if (secondCharacter >= 'A' && secondCharacter <= 'Z')
        secondCharacter = (char)(secondCharacter + 32);
      if (firstCharacter != secondCharacter)
        return false;
    }
    return true;
  }

    // ---------- MAIN MENU ----------
  static void Main(string[] args){
    int userChoice;
    do{
      Console.WriteLine("\n===== TEXT UTILITY MENU =====");
      Console.WriteLine("1. Sentence Formatter");
      Console.WriteLine("2. Paragraph Analyzer");
      Console.WriteLine("3. Exit");
      Console.Write("Enter your choice: ");
      userChoice = Convert.ToInt32(Console.ReadLine());
      switch (userChoice){
        case 1:
        Console.WriteLine("\nEnter paragraph:");
        string userInputText = Console.ReadLine();
        string formattedText = FormatParagraphText(userInputText);
        Console.WriteLine("\nFormatted Paragraph:");
        Console.WriteLine(formattedText);
        break;
        case 2:
        Console.WriteLine("\nEnter paragraph:");
        string paragraphInput = Console.ReadLine();
        Console.WriteLine("Enter word to replace:");
        string wordToReplace = Console.ReadLine();
        Console.WriteLine("Enter replacement word:");
        string replacementWord = Console.ReadLine();
        AnalyzeParagraphText(paragraphInput, wordToReplace, replacementWord);
        break;
        case 3:
        Console.WriteLine("Exiting program");
        break;
        default:
        Console.WriteLine("Invalid choice");
        break;
      }
    } while (userChoice != 3);
  }
}
