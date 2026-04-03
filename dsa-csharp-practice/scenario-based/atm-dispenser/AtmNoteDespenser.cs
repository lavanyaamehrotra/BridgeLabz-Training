using System;
class AtmNoteDispenser{
  // Method to dispense cash 
  public void DispenseCash(int amount, int[] notes){
    Console.WriteLine("Dispensing amount: Rs" + amount);
    int remainingAmount = amount;
    // Array to store count of each note
    int[] noteCount = new int[notes.Length];
    for (int i = 0; i < notes.Length; i++){
      if (remainingAmount >= notes[i]){
        noteCount[i] = remainingAmount / notes[i];
        remainingAmount = remainingAmount % notes[i];
      }
    }
    // If exact change is not possible
    if (remainingAmount != 0){
      Console.WriteLine("Exact amount cannot be dispensed");
    }
    // Display result
    for (int i = 0; i < notes.Length; i++){
      if (noteCount[i] > 0){
        Console.WriteLine("Rs" + notes[i] + " x " + noteCount[i]);
      }
    }
  }
}
