using System;
// Menu class
public class MovieMenu{
    IMovieService service = new MovieUtility();
    public void Start(){
        while (true){
            Console.WriteLine("1.Add Movie");
            Console.WriteLine("2.Search Movie");
            Console.WriteLine("3.Display Movies");
            Console.WriteLine("4.Report");
            Console.WriteLine("5.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1){
                Console.Write("Title: ");
                string t = Console.ReadLine();
                Console.Write("Time: ");
                string time = Console.ReadLine();
                service.AddMovie(t, time);
            }
            else if (choice == 2){
                Console.Write("Keyword: ");
                service.SearchMovie(Console.ReadLine());
            }
            else if (choice == 3){
                service.DisplayAllMovies();
            }
            else if (choice == 4)
            {
                Movie[] arr = service.ConvertToArray();
                foreach (var m in arr)
                    Console.WriteLine(m);
            }
            else
                break;
        }
    }
}
