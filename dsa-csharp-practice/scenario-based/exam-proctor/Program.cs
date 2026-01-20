using System;
class Program{
    static void Main(){
        ExamSession session = new ExamSession();
        CustomDictionary answers = new CustomDictionary(10);
        Evaluator evaluator = new Evaluator();
        int choice;
        do{
            Console.WriteLine("\n--- ExamProctor Menu ---");
            Console.WriteLine("1. Visit Question");
            Console.WriteLine("2. Answer Question");
            Console.WriteLine("3. Go Back");
            Console.WriteLine("4. Submit Exam");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    Console.Write("Enter Question ID: ");
                    int qid = Convert.ToInt32(Console.ReadLine());
                    session.VisitQuestion(qid);
                    Console.WriteLine("Question visited.");
                    break;
                case 2:
                    Console.Write("Enter Question ID: ");
                    int aid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Answer: ");
                    string ans = Console.ReadLine();
                    answers.Add(aid, ans);
                    Console.WriteLine("Answer saved.");
                    break;
                case 3:
                    if (session.HasHistory())
                        Console.WriteLine("Last visited question: " + session.GoBack());
                    else
                        Console.WriteLine("No history available.");
                    break;
                case 4:
                    int score = evaluator.CalculateScore(answers);
                    Console.WriteLine("Exam Submitted.");
                    Console.WriteLine("Final Score: " + score);
                    break;
                case 5:
                    Console.WriteLine("Thank u for using exam proctor website");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}
