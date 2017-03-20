using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_DiagonalMatrix
{

    public class Program
    {
        public static void Main()
        {
            int[,] matA = new int[10, 10];
            bool IsDiag = false;

            Console.WriteLine("\nFor Diagonal Matrix Same no. of row and column required.");
            Console.Write("\nEnter the no. of row. ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the no. of col. ");
            int col = Convert.ToInt32(Console.ReadLine());

            // enter the element of the matrix    
            Console.WriteLine("\nEnter the element");
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    Console.Write("Matrix A[{0},{1}]:", i, j);
                    matA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            // Print the matrix    

            Console.WriteLine("\nMatrix A: ");
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    Console.Write("{0} ", matA[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // Check weather the matrix is diagonal or not    

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if ((i != j) && (matA[i, j] == 0))
                    {
                        IsDiag = true;
                    }
                }
                Console.WriteLine();
            }

            if (IsDiag == true)
            {
                Console.WriteLine("Diagonal matrix");
            }
            else
            {
                Console.WriteLine("Not a Diagonal matrix");
            }
        }
    }

}
