// Represents one webpage in the browsing history
class HistoryNode{
    // Webpage address
    public string Url;  
    // Previous page        
    public HistoryNode Prev;
    // Next page    
    public HistoryNode Next;  
    //Constructor  
    public HistoryNode(string url){
        Url = url;
        Prev = null;
        Next = null;
    }
}
