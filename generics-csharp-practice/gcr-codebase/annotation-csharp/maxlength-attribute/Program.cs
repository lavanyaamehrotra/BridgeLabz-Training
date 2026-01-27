class Program{
    static void Main(){
        User u1 = new User("Lavanya"); // OK
        User u2 = new User("VeryLongUsername"); // Exception
    }
}
