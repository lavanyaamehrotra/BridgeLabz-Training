using System;
class Program{
    static void Main(string[] args){
        ParcelLinkedList parcelList = new ParcelLinkedList();
        parcelList.InitializeStages();
        ParcelMenu.ShowMenu(parcelList);
    }
}

