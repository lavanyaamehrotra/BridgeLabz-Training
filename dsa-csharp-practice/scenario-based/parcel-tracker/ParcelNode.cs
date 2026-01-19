class ParcelNode{
    public string StageName;
    public ParcelNode Next;
    public ParcelNode(string stageName){
        StageName = stageName;
        Next = null;
    }
}
