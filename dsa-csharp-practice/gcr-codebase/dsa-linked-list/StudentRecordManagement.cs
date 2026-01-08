using System;
class StudentRecordManagement{
  class Node{
  public int RollNo;
  public string Name;
  public int Age;
  public string Grade;
  public Node Next;
  }
  static Node head = null;
  // Add at Beginning
  static void AddBeginning(int roll, string name, int age, string grade){
    Node newNode = new Node();
    newNode.RollNo = roll;
    newNode.Name = name;
    newNode.Age = age;
    newNode.Grade = grade;
    newNode.Next = head;
    head = newNode;
    Console.WriteLine("Student added at beginning");
  }
  // Add at End
  static void AddEnd(int roll, string name, int age, string grade){
    Node newNode = new Node();
    newNode.RollNo = roll;
    newNode.Name = name;
    newNode.Age = age;
    newNode.Grade = grade;
    newNode.Next = null;
    if (head == null){
      head = newNode;
      Console.WriteLine("Student added at end");
      return;
    }
    Node temp = head;
    while (temp.Next != null){
      temp = temp.Next;
    }
    temp.Next = newNode;
    Console.WriteLine("Student added at end");
  }
  // Add at  Position
  static void AddPosition(int position, int roll, string name, int age, string grade){
    if (position == 1){
      AddBeginning(roll, name, age, grade);
      return;
    }
    Node newNode = new Node();
    newNode.RollNo = roll;
    newNode.Name = name;
    newNode.Age = age;
    newNode.Grade = grade;
    Node temp = head;
    for (int i = 1; i < position - 1 && temp != null; i++){
      temp = temp.Next;
    }
    if (temp == null){
      Console.WriteLine("Invalid position.");
      return;
    }
    newNode.Next = temp.Next;
    temp.Next = newNode;
    Console.WriteLine("Student added at position " + position);
  }
  // Delete by Roll Number
  static void DeleteByRollNo(int roll){
    if (head == null){
      Console.WriteLine("List is empty");
      return;
    }
    if (head.RollNo == roll){
      head = head.Next;
      Console.WriteLine("Student record deleted");
      return;
    }
    Node temp = head;
    while (temp.Next != null && temp.Next.RollNo != roll){
      temp = temp.Next;
    }
    if (temp.Next == null){
      Console.WriteLine("Student not found");
    }else{
      temp.Next = temp.Next.Next;
      Console.WriteLine("Student record deleted");
    }
  }
  // Search by Roll Number
  static void SearchByRollNo(int roll){
    Node temp = head;
    while (temp != null){
      if (temp.RollNo == roll){
        Console.WriteLine("\nStudent Found:");
        Console.WriteLine("Roll No: " + temp.RollNo);
        Console.WriteLine("Name:" + temp.Name);
        Console.WriteLine("Age:" + temp.Age);
        Console.WriteLine("Grade:" + temp.Grade);
        return;
      }
      temp = temp.Next;
    }
    Console.WriteLine("Student not found.");
  }
  // Update Grade
  static void UpdateGrade(int roll, string newGrade){
    Node temp = head;
    while (temp != null){
      if (temp.RollNo == roll){
        temp.Grade = newGrade;
        Console.WriteLine("Grade updated");
        return;
      }
      temp = temp.Next;
    }
    Console.WriteLine("not found.");
  }
  // Display All Records
  static void DisplayAll(){
    if (head == null){
      Console.WriteLine("No student records");
      return;
    }
    Node temp = head;
    Console.WriteLine("\nStudent Records:");
    while (temp != null){
      Console.WriteLine("Roll No: " + temp.RollNo +", Name: " + temp.Name +", Age: " + temp.Age +", Grade: " + temp.Grade);
      temp = temp.Next;
    }
  }
  static void Main(){
    int option;
    do{
      Console.WriteLine("\n----Student Record Management----");
      Console.WriteLine("1. Add at Beginning");
      Console.WriteLine("2. Add at End");
      Console.WriteLine("3. Add at Position");
      Console.WriteLine("4. Delete by Roll Number");
      Console.WriteLine("5. Search by Roll Number");
      Console.WriteLine("6. Update Grade");
      Console.WriteLine("7. Display All");
      Console.WriteLine("8. Exit");
      Console.Write("Enter your option: ");
      option = int.Parse(Console.ReadLine());
      switch (option){
        case 1:
          AddStudent(1);
          break;
        case 2:
          AddStudent(2);
          break;
        case 3:
          Console.Write("Enter position: ");
          int pos = int.Parse(Console.ReadLine());
          AddStudent(3, pos);
          break;
        case 4:
          Console.Write("Enter Roll Number to delete: ");
          DeleteByRollNo(int.Parse(Console.ReadLine()));
          break;
        case 5:
          Console.Write("Enter Roll Number to search: ");
          SearchByRollNo(int.Parse(Console.ReadLine()));
          break;
        case 6:
          Console.Write("Enter Roll Number: ");
          int roll = int.Parse(Console.ReadLine());
          Console.Write("Enter new Grade: ");
          string grade = Console.ReadLine();
          UpdateGrade(roll, grade);
          break;
        case 7:
          DisplayAll();
          break;
        case 8:
          Console.WriteLine("thanku for using");
          break;
        default:
          Console.WriteLine("Invalid option.");
          break;
      }
    } while (option != 8);
  }
  //ADD STUDENT
  static void AddStudent(int type, int position = 0){
    Console.Write("Enter Roll Number: ");
    int roll = int.Parse(Console.ReadLine());
    Console.Write("Enter Name: ");
    string name = Console.ReadLine();
    Console.Write("Enter Age: ");
    int age = int.Parse(Console.ReadLine());
    Console.Write("Enter Grade: ");
    string grade = Console.ReadLine();
    if (type == 1){
      AddBeginning(roll, name, age, grade);
    }else if (type == 2){
      AddEnd(roll, name, age, grade);
    }else{
      AddPosition(position, roll, name, age, grade);
    }
  }
}
