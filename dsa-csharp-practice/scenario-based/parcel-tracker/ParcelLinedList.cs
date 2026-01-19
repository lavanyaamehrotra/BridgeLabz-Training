using System;
class ParcelLinkedList{
    private ParcelNode head;
    public ParcelLinkedList(){
        head = null;
    }
    public void InitializeStages(){
            AddLast("Packed");
            AddLast("Shipped");
            AddLast("In Transit");
            AddLast("Delivered");
        }

    // Add stage at end
    private void AddLast(string stage){
        ParcelNode newNode = new ParcelNode(stage);
        if (head == null){
            head = newNode;
            return;
        }
        ParcelNode temp = head;
        while (temp.Next != null){
            temp = temp.Next;
        }
        temp.Next = newNode;
    }
    // Add intermediate checkpoint
    public void AddAfter(string startingstage, string newStage){
        if (head == null){
            Console.WriteLine("chain missing.");
            return;
        }
        ParcelNode temp = head;
        while (temp != null && temp.StageName != startingstage){
            temp = temp.Next;
        }
        if (temp == null){
            Console.WriteLine("stage not found.");
            return;
        }
        ParcelNode newNode = new ParcelNode(newStage);
        newNode.Next = temp.Next;
        temp.Next = newNode;
        Console.WriteLine("checkpoint added successfully.");
    }
    // Track parcel
    public void TrackParcel(){
        if (head == null){
            Console.WriteLine("⚠ Parcel lost (null pointer).");
            return;
        }
        ParcelNode temp = head;
        Console.WriteLine("parcel Tracking Path:");
        while (temp != null){
            Console.Write(temp.StageName);
            if (temp.Next != null){
                Console.Write("=>");
            }
            temp = temp.Next;
            }
            Console.WriteLine();
        }
    public void LoseParcel(){
        head = null;
        Console.WriteLine("Parcel lost Delivery chain broken.");
    }
}
