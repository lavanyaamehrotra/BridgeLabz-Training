using System;
class Program{
  static void Main(){
    AtmNoteDispenser atm = new AtmNoteDispenser();
    int amount = 880;
    //Scenario A: All notes available
    Console.WriteLine("Scenario A: All Notes Available");
    int[] notesScenarioA = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
    atm.DispenseCash(amount, notesScenarioA);
    //Scenario B: Rs 500 note removed
    Console.WriteLine("Scenario B: Rs 500 Note removed");
    int[] notesScenarioB = { 200, 100, 50, 20, 10, 5, 2, 1 };
    atm.DispenseCash(amount, notesScenarioB);
    //Scenario C: Exact change not possible
    Console.WriteLine("Scenario C: Exact Change Not Possible");
    int[] notesScenarioC = { 200, 100, 50 };
    atm.DispenseCash(amount, notesScenarioC);
  }
}
