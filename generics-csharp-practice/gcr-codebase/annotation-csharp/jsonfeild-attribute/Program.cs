class Program{
    static void Main(){
        User user = new User();
        Console.WriteLine(JsonSerializer.ToJson(user));
    }
}
