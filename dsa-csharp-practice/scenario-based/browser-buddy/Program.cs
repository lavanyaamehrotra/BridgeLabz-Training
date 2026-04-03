using System;
class Program{
    static void Main(){
        TabManager manager = new TabManager();
        //opens a new tab
        manager.Open("google.com");
        //browse some websites
        manager.CurrentTab.VisitPage("github.com");
        manager.CurrentTab.VisitPage("leetcode.com");
        //navigate back and forward
        Console.WriteLine("Back:" + manager.CurrentTab.GoBack());
        Console.WriteLine("Forward:" + manager.CurrentTab.GoForward());
        //close and restore tab
        manager.Close();
        manager.RestoreTab();
        // Show current page after restore
        Console.WriteLine("Current Page: " + manager.CurrentTab.GetCurrentPage());
    }
}
