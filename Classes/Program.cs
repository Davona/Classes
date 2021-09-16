using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCreator 
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayManager arrayManager = new ArrayManager();
            int[] array = arrayManager.Create(5, 10, 99);
            int minvalue = arrayManager.GetMin(array);
            int maxvalue = arrayManager.GetMax(array);
            array = arrayManager.SwapMinMax(array, minvalue, maxvalue);
            arrayManager.Print(array);
            MatrixManager matrixManager = new MatrixManager();
            int[,] matrix = matrixManager.Create(3, 3, 5, 189);
            int[] diagonal = matrixManager.GetDiagonal(matrix);
            int diagonalmin = arrayManager.GetMin(diagonal);
            int diagonalmax = arrayManager.GetMax(diagonal);
            diagonal = arrayManager.SwapMinMax(diagonal, diagonalmin, diagonalmax);
            matrixManager.Print(matrix, diagonal);
            matrixManager.Print(matrix);
        }
    }
    public class ArrayManager
    {
        Random rand;
        public ArrayManager()
        {
            rand = new Random();
        }
        public int[] Create(int lenght, int min, int max)
        {
            int[] arr = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                arr[i] = rand.Next(min, max);
            }
            return arr;
        }
        public int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public int[] SwapMinMax(int[] arr, int min, int max)
        {
            int minind = 0;
            int maxind = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == min)
                {
                    minind = i;
                }
                if (arr[i] == max)
                {
                    maxind = i; ;
                }
            }
            arr[minind] = max;
            arr[maxind] = min;
            return arr;
        }
    }
    public class MatrixManager
    {
        Random rand;
        public MatrixManager()
        {
            rand = new Random();
        }
        public int[,] Create(int firstlength, int secondelenght, int min, int max)
        {
            int[,] matrix = new int[firstlength, secondelenght];
            for (int i = 0; i < firstlength; i++)
            {
                for (int j = 0; j < secondelenght; j++)
                {
                    matrix[i, j] = rand.Next(min, max);
                }
            }
            return matrix;
        }
        public int[] GetDiagonal(int[,] matrix)
        {
            int[] arr = new int[(int)Math.Sqrt(matrix.Length)];
            //int[] arr = new int[matrix.GetLongLength(0)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = matrix[i, i];
            }
            return arr;
        }
        public void Print(int[,] matrixsquare)
        {
            for (int i = 0; i < matrixsquare.GetLength(0); i++)
            {
                for (int j = 0; j < matrixsquare.GetLength(1); j++)
                {
                    Console.Write($"{ matrixsquare[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        public void Print(int[,] matrix, int[] arr)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = arr[i];
                    }
                    Console.WriteLine(matrix[i, j]);
                }
            }
        }
    }
}
