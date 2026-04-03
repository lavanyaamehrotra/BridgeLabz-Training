//   Write a program to perform matrix manipulation operations like addition, subtraction, multiplication, and transpose. Also finding the determinant and inverse of a matrix. The program should take random matrices as input and display the result of the operations

using System;
class MatrixManipualtion{
    public static double[,] CreateMatrix(int rows, int cols){
        Random rand = new Random();
        double[,] m = new double[rows, cols];

        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
                m[i, j] = rand.Next(1, 10);
            }
        }
        return m;
    }
    //Add
    public static double[,] Add(double[,] a, double[,] b){
        int r = a.GetLength(0), c = a.GetLength(1);
        double[,] res = new double[r, c];

        for (int i = 0; i < r; i++){
            for (int j = 0; j < c; j++){
                res[i, j] = a[i, j] + b[i, j];
            }
        }

        return res;
    }
    //Subtract 
    public static double[,] Subtract(double[,] a, double[,] b){
        int r = a.GetLength(0), c = a.GetLength(1);
        double[,] res = new double[r, c];

        for (int i = 0; i < r; i++){
            for (int j = 0; j < c; j++){
                res[i, j] = a[i, j] - b[i, j];
            }
        }

        return res;
    }
    // Multiply
    public static double[,] Multiply(double[,] a, double[,] b) {
        int r1 = a.GetLength(0), c1 = a.GetLength(1);
        int c2 = b.GetLength(1);
        double[,] res = new double[r1, c2];

        for (int i = 0; i < r1; i++){
            for (int j = 0; j < c2; j++){
                for (int k = 0; k < c1; k++){
                    res[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        return res;
    }

    // Transpose
    public static double[,] Transpose(double[,] m){
        int r = m.GetLength(0), c = m.GetLength(1);
        double[,] t = new double[c, r];

        for (int i = 0; i < r; i++){
            for (int j = 0; j < c; j++){
                t[j, i] = m[i, j];
            }
        }

        return t;
    }
    // Determinant
    public static double Determinant2x2(double[,] m){
        return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
    }

    //  Determinant 3x3
    public static double Determinant3x3(double[,] m){
        return m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1])- m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0])+ m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
    }

    //  Inverse 2x2
    public static double[,] Inverse2x2(double[,] m){
        double det = Determinant2x2(m);
        double[,] inv = new double[2, 2];

        inv[0, 0] = m[1, 1] / det;
        inv[0, 1] = -m[0, 1] / det;
        inv[1, 0] = -m[1, 0] / det;
        inv[1, 1] = m[0, 0] / det;

        return inv;
    }

    //  Display
    public static void Display(double[,] m){
        for (int i = 0; i < m.GetLength(0); i++){
            for (int j = 0; j < m.GetLength(1); j++){
                Console.Write(m[i, j] + "\t");
            }
            Console.WriteLine();

        }
    }

    public static void Main(){
        double[,] A = CreateMatrix(2, 2);
        double[,] B = CreateMatrix(2, 2);
        Console.WriteLine("Matrix:");
        Display(A);
        Console.WriteLine("Matrix:");
        Display(B);
        Console.WriteLine("Addition:");
        Display(Add(A, B));
        Console.WriteLine("Subtraction:");
        Display(Subtract(A, B));
        Console.WriteLine("Multiplication:");
        Display(Multiply(A, B));
        Console.WriteLine("Transpose of A:");
        Display(Transpose(A));
        Console.WriteLine("Determinant of A: " + Determinant2x2(A));
        Console.WriteLine("Inverse of A:");
        Display(Inverse2x2(A));
    }
}
