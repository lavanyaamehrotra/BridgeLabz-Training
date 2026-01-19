using System;
class ParcelMenu{
    public static void ShowMenu(ParcelLinkedList list){
        int choice = 0;
        do{
        Console.WriteLine("\n=====Parcel Tracker Menu =====");
        Console.WriteLine("1. Track Parcel");
        Console.WriteLine("2. Add Checkpoint");
        Console.WriteLine("3. Simulate Lost Parcel");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
        while (!int.TryParse(Console.ReadLine(), out choice)){
            Console.Write("Invalid input. Enter a number: ");
        }
        switch (choice){
            case 1:
            list.TrackParcel();
            break;
            case 2:
            Console.Write("Enter existing stage: ");
            string existingStage = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(existingStage)){
                Console.WriteLine("stage cannot be empty.");
                break;
            }
            Console.Write("Enter new checkpoint: ");
            string newCheckpoint = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newCheckpoint)){
                Console.WriteLine("checkpoint cannot be empty.");
                break;
            }
            list.AddAfter(startingstage, newCheckpoint);
            break;
            case 3:
            list.LoseParcel();
            break;
            case 4:
            Console.WriteLine("Exiting Parcel Tracker.");
            break;
            default:
            Console.WriteLine("Invalid menu option.");
            break;
        }
    } while (choice != 4);
}
}
