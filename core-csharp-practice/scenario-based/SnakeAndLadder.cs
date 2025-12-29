using System;
class SnakeAndLadder{
  //to store the positions of the players 
  int[] positions = new int[4];
  //To know how many players arre playing
  int playerCount;
  //names for each player
  string[] names = new string[4];
  //random value generator for the dice
  Random random = new Random();
// Ladders
  int[] ladderStart = { 2, 7, 19, 27, 35 };
  int[] ladderEnd   = { 23, 16, 46, 55, 78 };
  // Snakes
  int[] snakeStart  = { 29, 41, 63, 87, 99 };
  int[] snakeEnd    = { 5, 20, 45, 59, 70 };
  int[] board = new int[101];
  //menu driven code for entering the choice what player want to do
  public void Start(){
    int choice = 0;
    while (choice != 2){
      Console.WriteLine("\n------------Welcome to the SNAKE & LADDER game designed by Lavanya-----------------");
      Console.WriteLine("1.Start Game");
      Console.WriteLine("2.Exit");
      Console.Write("Enter choice:");
      choice = Convert.ToInt32(Console.ReadLine());
      //if case 1 then do all the setup
      switch (choice){
        case 1:
        SetupPlayers();
        InitializeBoard();
        MovePlayer();
        break;
        // if case 2 exit
        case 2:
        Console.WriteLine("Thank you for playing the game have a nice day");
        break;
        // if sometging other then print
        default:
        Console.WriteLine("invalid choice");
        break;
      }
    }
  }
  //function to set up the players their positions their names and count how many players
  void SetupPlayers(){
    Console.Write("\nEnter number of players: ");
    playerCount = Convert.ToInt32(Console.ReadLine());
    if (playerCount < 2 || playerCount > 4){
      Console.WriteLine("Invalid plz choose btw two to four");
      playerCount = 2;
    }
    for (int i = 0; i < playerCount; i++)
      positions[i] = 0;
    for (int i = 0; i < playerCount; i++){
      Console.Write($"Enter Player {i + 1} Name: ");
      names[i] = Console.ReadLine();
      if (names[i] == "" || names[i] == null){
        names[i] = "Player" + (i + 1);
      }
    }
  }
  // intialize the board for the player for snakes and ladders
  void InitializeBoard(){
    // Initialize board: each position maps to itself
    for (int i = 0; i <= 100; i++){
      board[i] = i;
    }
      //ladders
      for (int i = 0; i < ladderStart.Length; i++){
          board[ladderStart[i]] = ladderEnd[i];
      }
      //snakes
      for (int i = 0; i < snakeStart.Length; i++){
        board[snakeStart[i]] = snakeEnd[i];
      }
    }
    //this function calculates the player moves
  void MovePlayer(){
    bool win = false;
    Console.WriteLine("\nGame Started -ALL THE BEST");
    while (!win){
      for (int i = 0; i < playerCount; i++){
        Console.WriteLine($"\n{names[i]}'s turn — press ENTER to roll");
        Console.ReadLine();
        int dice = random.Next(1, 7);
        Console.WriteLine($"{names[i]} rolled: {dice}");
        int oldPos = positions[i];
        int newPos = oldPos + dice;
        if (newPos > 100){
          Console.WriteLine("your turn is  skipped");
            continue;
        }
        positions[i] = board[newPos];
        if (positions[i] > newPos)
          Console.WriteLine("Ladder Up!");
        else if (positions[i] < newPos)
          Console.WriteLine("Snake Down!");
        Console.WriteLine($"Position: {oldPos} -> {positions[i]}");
        if (positions[i] == 100){
          Console.WriteLine($"\n{names[i]} WINS!");
          win = true;
          break;
        }
      }
    }
  }
  //main function
  static void Main(){
    SnakeAndLadder game = new SnakeAndLadder();
    game.Start();
  }
}
