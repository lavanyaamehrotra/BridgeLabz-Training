class BrowserTab{
    //Points to the current page
    private HistoryNode currentPage;
    //it starts with a homepage
    public BrowserTab(string homepage){
        currentPage = new HistoryNode(homepage);
    }
    //visit a new webpage
    public void VisitPage(string url){
        //create a new history node
        HistoryNode newPage = new HistoryNode(url);
        currentPage.Next = newPage;
        newPage.Prev = currentPage;
        //move pointer to new page
        currentPage = newPage;
    }
    //Go back to previous page
    public string GoBack(){
        if (currentPage.Prev != null){
            currentPage = currentPage.Prev;
        }
        return currentPage.Url;
    }
    // Go forward to next page
    public string GoForward(){
        if (currentPage.Next != null){
            currentPage = currentPage.Next;
        }
        return currentPage.Url;
    }
    // Get the current page url
    public string GetCurrentPage(){
        return currentPage.Url;
    }
}
