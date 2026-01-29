using System;
using System.Collections.Generic;
public class Program{
    public static void Main(){
        EngagementService service=new EngagementService();
        while (true){
            Console.WriteLine("\n1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            Console.WriteLine("\nEnter your choice:");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice){
                //register
                case 1:
                CreatorStats creator=new CreatorStats();
                Console.WriteLine("Enter Creator Name:");
                creator.CreatorName=Console.ReadLine();
                creator.WeeklyLikes=new double[4];
                Console.WriteLine("Enter weekly likes");
                for(int i = 0; i < 4; i++){
                    creator.WeeklyLikes[i]=double.Parse(Console.ReadLine());
                }
                service.RegisterCreator(creator);
                Console.WriteLine("Creator registered successfully");
                break;
                //show top posts
                case 2:
                Console.WriteLine("Enter like Threshold");
                double threshold=double.Parse(Console.ReadLine());
                Dictionary<string, int> result =service.GetTopPostCounts(CreatorStats.EngagementBoard,threshold);
                    if (result.Count == 0){
                        Console.WriteLine("No top performing post this week");
                    }
                    else{
                        foreach(var item in result){
                            Console.WriteLine(item.Key+" - "+item.Value);
                        }
                    }
                    break;
                case 3:
                double avg=service.CalculateAverageLikes();
                Console.WriteLine("Overall avg weekly likes:" +avg);
                break;
                //exit
                case 4:
                Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                return;
            }

        }
    }
}