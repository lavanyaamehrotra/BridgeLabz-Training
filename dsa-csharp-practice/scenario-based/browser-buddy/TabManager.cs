using System.Collections.Generic;
//opening , closing and restoring tabs
class TabManager{
    // stack stores recently closed tabs
    private Stack<BrowserTab> closedTabs = new Stack<BrowserTab>();
    //currently active tab
    public BrowserTab CurrentTab { get; private set; }
    // Open a new tab with a homepage
    public void Open(string homepage){
        CurrentTab = new BrowserTab(homepage);
        Console.WriteLine("New tab opened: " + homepage);
    }
    //close the current tab
    public void Close(){
        if (CurrentTab != null){
            closedTabs.Push(CurrentTab);
            Console.WriteLine("tab closed");
            CurrentTab = null;
        }
    }
    //restore the most recently closed tab
    public void RestoreTab(){
        if (closedTabs.Count > 0){
            CurrentTab = closedTabs.Pop();
            Console.WriteLine("tab restored");
        }
    }
}
