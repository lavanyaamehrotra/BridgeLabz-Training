using System;
class MatrixSearch{
    static void Main(){
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine()); 
        Console.Write("Enter number of columns: ");
        int coloumns = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, coloumns];
        Console.WriteLine("Enter matrix elements row-wise:");
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < coloumns; j++){
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.Write("\nEnter target value: ");
        int target = int.Parse(Console.ReadLine());
        bool found = false;
        int foundRow = -1, foundcoloumn = -1;
        // Binary search on each row
        for (int i = 0; i < rows; i++){
            int left = 0;
            int right = coloumns - 1;
            while (left <= right){
                int mid = (left + right) / 2;
                if (matrix[i, mid] == target){
                    found = true;
                    foundRow = i;
                    foundcoloumn = mid;
                    break;
                }
                else if (matrix[i, mid] < target){
                    left = mid + 1;
                }else{
                    right = mid - 1;
                }
            }
            if (found){
                break;
            }
        }
        if (found){
            Console.WriteLine($"\ntarget {target} found at position ({foundRow}, {foundcoloumn})");
        }else{
            Console.WriteLine("\ntarget not found in the matrix.");
        }
    }
}
