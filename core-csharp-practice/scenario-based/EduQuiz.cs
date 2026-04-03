using System;
class EduQuiz{
  static string[] questions=new string[10];
  static string[] correctAnswers = new string[10];
  static bool answersSet = false;
  const string teacherPasskey = "I_am_a_teacher";
  static void Main(){
    int option;
    do{
      Console.WriteLine("\n================= EDUQUIZ-STUDENT QUIZ GRADER -=============");
      Console.WriteLine("1. Teacher Mode");
      Console.WriteLine("2. Student Mode");
      Console.WriteLine("3. Exit");
      Console.Write("Select option: ");
      option = Convert.ToInt32(Console.ReadLine());
      switch (option){
        case 1: 
        TeacherMenu(); 
        break;
        case 2: 
        StudentMenu(); 
        break;
        case 3: 
        Console.WriteLine("Goodbye"); 
        break;
        default: 
        Console.WriteLine("Invalid option."); 
        break;
      }
    } while (option != 3);
  }
  //Teacher Login
  static void AuthenticateTeacher(){
    Console.Write("\nEnter Teacher Passkey:");
    string key = Console.ReadLine();
    if (key == teacherPasskey){
      Console.WriteLine("Access Granted");
      TeacherMenu();
    }else{
      Console.WriteLine("Access Denied.");
    }
  }
  //Teacher menu
  static void TeacherMenu(){
    Console.WriteLine("\n---------TEACHER ----------");
    Console.WriteLine("Enter questions and correct answers");
    for (int i = 0; i < questions.Length; i++){
      Console.WriteLine($"\nEnter Question {i + 1}: ");
      questions[i]=Console.ReadLine();
      Console.Write($"Correct Answer for Q{i + 1}: ");
      correctAnswers[i] = Console.ReadLine();
    }
    answersSet = true;
    Console.WriteLine("\n Correct answers saved successfully!");
  }
  // Student mode
  static void StudentMenu(){
    if (!answersSet){
      Console.WriteLine("\n Teacher has not set answers yet.");
      return;
    }
    Console.WriteLine("\n--- STUDENT QUIZ ---");
    string[] studentAnswers = new string[10];
    for (int i = 0; i < questions.Length; i++){
      Console.WriteLine("\nQ" + (i + 1) + "\n" + questions[i]);
      Console.Write($"Your Answer for Q{i + 1}: ");
      studentAnswers[i] = Console.ReadLine();
    }
    int score = CalculateScore(correctAnswers, studentAnswers);
    double percentage = (score / 10.0) * 100;
    Console.WriteLine("\n----- RESULT -----");
    Console.WriteLine($"Score: {score}/10");
    Console.WriteLine($"Percentage: {percentage}%");
    if (percentage >= 50){
      Console.WriteLine("Status: PASS");
    }else{
      Console.WriteLine("Status: FAIL");
    }
  }
  // calculation method
  static int CalculateScore(string[] correct, string[] student){
    int score = 0;
    Console.WriteLine("\n--- FEEDBACK ---");
    for (int i = 0; i < correct.Length; i++){
    bool isCorrect = correct[i].Equals(student[i], StringComparison.OrdinalIgnoreCase);
    Console.WriteLine("\nQ" + (i + 1) + "\n" + questions[i]);
    if (isCorrect){
      Console.WriteLine($"Question {i + 1}: Correct");
      score++;
    }else{
      Console.WriteLine($"Question {i + 1}: Incorrect");
    }
  }
  return score;
  }
}
