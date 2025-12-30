using System;
class LibraryManagementSystem{
  //Enter the titles ,authors,available of the book
  static string[] titles ={ "Engineering Mathematics","Digital Logic Design","Computer Networks","Operating System Concepts","Database System Concepts"};
  static string[] authors = { "B.S. Grewal","M. Morris Mano","Andrew S. Tanenbaum","Abraham Silberschatz","Abraham Silberschatz"};
  static bool[] available = {true,true,true,true,true};
 const string passkey = "lavi";
  //Main function
  static void Main(){
    Console.WriteLine("Welcome to Library Management System!");
    Console.Write("Enter admin passkey [press Enter to continue as User]: ");
    string key = Console.ReadLine();
    bool isAdmin = false;
    if (key == passkey){
      isAdmin = true;    
    }
    if (key == ""){
      UserMenu();
      return;
    }
    if (!isAdmin){
      Console.WriteLine("Invalid passkey. Access denied.");
      return;
    }
    AdminMenu();
  }
  static string statusText(bool available){
    return available?"Availiable":"Checked out";
  }
  //Method to display all books
  static void DisplayBooks(){
    Console.WriteLine("------------BOOK MENU----------");
    //Loop to print all the details of the book 
    for(int i = 0; i < titles.Length; i++){
      Console.WriteLine((i+1)+". "+titles[i]+" | " + authors[i] + " | Status: " + statusText(available[i]));

    }
  }
  static void AdminMenu() {
  int option;
  do{
    Console.WriteLine("\n------ Admin Menu ------");
    Console.WriteLine("1. Display All Books");
    Console.WriteLine("2. Search Book by Title");
    Console.WriteLine("3. Check Out Book");
    Console.WriteLine("4. Return Book");
    Console.WriteLine("5. Add New Book");
    Console.WriteLine("6. Remove Book");
    Console.WriteLine("7. Exit");
    Console.Write("Enter your option: ");
    option = Convert.ToInt32(Console.ReadLine());
    switch(option){
      case 1: 
      DisplayBooks(); 
      break;
      case 2: 
      SearchBook(); 
      break;
      case 3: 
      CheckOutBook(); 
      break;
      case 4: 
      ReturnBook();
      break;
      case 5: 
      AddBook(); 
      break;
      case 6: 
      RemoveBook(); 
      break;
      case 7: 
      Console.WriteLine("Exiting Admin Menu."); 
      break;
      default: 
      Console.WriteLine("Invalid option."); 
      break;
    }
  } while(option != 7);
}
  static void UserMenu(){
    int option;
    do{
      Console.WriteLine("\n------ User Menu ------");
      Console.WriteLine("1. Display All Books");
      Console.WriteLine("2. Search Book by Title");
      Console.WriteLine("3. Check Out Book");
      Console.WriteLine("4. Return Book");
      Console.WriteLine("5. Exit");
      Console.Write("Enter your option: ");
      option = Convert.ToInt32(Console.ReadLine());
      switch (option){
        case 1: 
        DisplayBooks(); 
        break;
        case 2: 
        SearchBook(); 
        break;
        case 3: 
        CheckOutBook(); 
        break;
        case 4: 
        ReturnBook(); 
        break;
        case 5: 
        Console.WriteLine("Thanku"); 
        break;
        default: 
        Console.WriteLine("Invalid option."); 
        break;
      }
    } while (option != 5);
  }
  //Method to search books
  static void SearchBook(){
    Console.WriteLine("Enter the book name to search");
    //convert it to lower 
    string find=Console.ReadLine().ToLower();
    bool found=false;
    Console.WriteLine("\n--------Search Results are---------");
    //loop to find out whether the book is there or not
    for(int i = 0; i < titles.Length; i++){
      if (titles[i].ToLower().Contains(find)){
        Console.WriteLine((i+1) + " ." + titles[i]+ " | " + authors[i]+ " | Status " + statusText(available[i]));
        found=true;
      }
    }
    if (!found){
      Console.WriteLine("No book found ");
    }
  }
  //Method to check out book
  static void CheckOutBook(){
    DisplayBooks();
    Console.WriteLine("\n Enter the book number to checkout");
    // take the input till -1 as indexing is from 0
    int number=Convert.ToInt32(Console.ReadLine())-1;
    //if book is availiable then check out the book
    if(number>0 && number < titles.Length){
      if (available[number]){
        available[number]=false;
        Console.WriteLine("Book \"" + titles[number] + "\" checked out successfully");
      }
      else{
        Console.WriteLine("Book is checked out already");
      }
    }
    else{
      Console.WriteLine("Invalid numebr");
    }
  }
  //Method to return Book
  static void ReturnBook(){
    DisplayBooks();
    Console.WriteLine("\n Enter the book number to return");
    int number=Convert.ToInt32(Console.ReadLine())-1;
    //if book is checked out then make it availiable
    if(number>0 && number < titles.Length){
      if(!available[number]){
        available[number]=true;
        Console.WriteLine("Book \"" +titles[number]+ "\" returned successfully");
      }
      else{
        Console.WriteLine("Book is not checked out");
      }
    }
    else{
      Console.WriteLine("Invalid number");
    }
  }
  //Method to add book
  static void AddBook(){
  Console.Write("Enter book title: ");
  string newTitle = Console.ReadLine();
  Console.Write("Enter author: ");
  string newAuthor = Console.ReadLine();
  // Create new arrays with +1 size
  string[] newTitles = new string[titles.Length + 1];
  string[] newAuthors = new string[authors.Length + 1];
  bool[] newAvailable = new bool[available.Length + 1];
  // Copy old arrays
  for (int i = 0; i < titles.Length; i++){
    newTitles[i] = titles[i];
    newAuthors[i] = authors[i];
    newAvailable[i] = available[i];
  }
  // Add new book at the end
  newTitles[newTitles.Length - 1] = newTitle;
  newAuthors[newAuthors.Length - 1] = newAuthor;
  newAvailable[newAvailable.Length - 1] = true;
  // Replace old arrays
  titles = newTitles;
  authors = newAuthors;
  available = newAvailable;
  Console.WriteLine("Book added successfully");
}
//Method to remove the book
static void RemoveBook(){
  DisplayBooks();
  Console.Write("Enter book number to remove: ");
  int number = Convert.ToInt32(Console.ReadLine()) - 1;
  if (number < 0 || number >= titles.Length){
    Console.WriteLine("Invalid book number");
    return;
  }
  string[] newTitles = new string[titles.Length - 1];
  string[] newAuthors = new string[authors.Length - 1];
  bool[] newAvailable = new bool[available.Length - 1];
  int j = 0;
  for (int i = 0; i < titles.Length; i++){
    if (i == number) continue; // skip the removed book
    newTitles[j] = titles[i];
    newAuthors[j] = authors[i];
    newAvailable[j] = available[i];
    j++;
  }
  titles = newTitles;
  authors = newAuthors;
  available = newAvailable;
  Console.WriteLine("Book removed successfully");
  }
}
