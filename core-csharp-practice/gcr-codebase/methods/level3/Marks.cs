//Create a program to take input marks of students in 3 subjects physics, chemistry, and maths. Compute the total, average, and the percentage score
using System;
class Marks{
    public static int[,] GeneratePCM(int student){
        Random rand = new Random();
        int[,] pcm = new int[student, 3];

        for (int i = 0; i < student; i++){
            for (int j = 0; j < 3; j++){
                pcm[i, j] = rand.Next(10, 100);
            }
        }
        return pcm;
    }
    // total, average, percentage
    public static double[,] CalculateResults(int[,] pcm){
        int students = pcm.GetLength(0);
        double[,] result = new double[students, 3];

        for (int i = 0; i < students; i++){
            double total = pcm[i, 0] + pcm[i, 1] + pcm[i, 2];
            result[i, 0] = total;
            result[i, 1] = Math.Round(total / 3, 2);
            result[i, 2] = Math.Round((total / 300) * 100, 2);
        }
        return result;
    }

    // Grade calculation
    public static char GetGrade(double percentage){
        if (percentage >= 80){
            return 'A';
        }
        else if (percentage >= 70){
            return 'B';
        }
        else if (percentage >= 60){
            return 'C';
        }
        else if (percentage >= 50){
            return 'D';
        }
        else if (percentage >= 40){
            return 'E';
        }
        else{
            return 'R';
        }
    }

    // Display
    static void Display(int[,] pcm, double[,] result){
        Console.WriteLine("Phy\tChem\tMath\tTotal\tAvg\t%\tGrade");

        for (int i = 0; i < pcm.GetLength(0); i++){
            char grade = GetGrade(result[i, 2]);
            Console.WriteLine(pcm[i, 0] + "\t" +pcm[i, 1] + "\t" +pcm[i, 2] + "\t" +result[i, 0] + "\t" +result[i, 1] + "\t" +result[i, 2] + "\t" + grade);
        }
    }

    public static void Main(){
        int students = int.Parse(Console.ReadLine());
        int[,] pcm = GeneratePCM(students);
        double[,] result = CalculateResults(pcm);
        Display(pcm, result);
    }
}
