// Custom HashMap implementation
class CustomHashMap{
    private GenreNode[] table = new GenreNode[10];
    // Hash function for genre
    private int Hash(string genre){
        int sum = 0;
        foreach (char c in genre)
            sum += c;
        return sum % table.Length;
    }
    // Get existing genre or create new
    public BookLinkedList GetOrCreate(string genre){
        int index = Hash(genre);
        // If genre not present
        if (table[index] == null){
            table[index] = new GenreNode(genre);
            return table[index].Books;
        }
        // Handle collisions using chaining
        GenreNode temp = table[index]!;
        while (temp != null){
            if (temp.Genre == genre){
                return temp.Books;
            }
            if (temp.Next == null){
                break;
            }
            temp = temp.Next;
        }
        temp.Next = new GenreNode(genre);
        return temp.Next.Books;
    }
    // Display all genres and their books
    public void DisplayAll(){
        for (int i = 0; i < table.Length; i++){
            GenreNode temp = table[i];
            while (temp != null){
                Console.WriteLine("\nGenre: " + temp.Genre);
                temp.Books.Display();
                temp = temp.Next;
            }
        }
    }
}
