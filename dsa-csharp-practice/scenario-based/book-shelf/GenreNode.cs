// Node for HashMap chaining
class GenreNode{
    public string Genre;              
    public BookLinkedList Books;      
    public GenreNode? Next;
    public GenreNode(string genre){
        Genre = genre;
        Books = new BookLinkedList();
        Next = null;
    }
}
