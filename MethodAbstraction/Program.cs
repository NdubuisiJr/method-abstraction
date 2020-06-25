using System;

namespace MethodAbstraction {
    class Program {
        static void Main(string[] args) {
            double[,] A = new double[4, 4];
            double[,] B = new double[4, 2];

            for (int i = 0; i < A.GetLength(0); i++) {
                for (int j = 0; j < A.GetLength(1); j++) {
                    A[i, j] = i + j;
                }
            }

            for (int i = 0; i < B.GetLength(0); i++) {
                for (int j = 0; j < B.GetLength(1); j++) {
                    B[i, j] = i + 1 + j + 2;
                }
            }

            DisplayArray(A, "A");
            DisplayArray(B, "B");

            var C = MatrixMultiplication(A, B);

            DisplayArray(C, "C");

            Console.ReadLine();
        }

        private static void DisplayArray(double[,] array, string name) {
            if (array == null)
                return;

            Console.WriteLine($"\n{name}");
            Console.WriteLine("---------------------");

            for (int i = 0; i < array.GetLength(0); i++) {
                for (int j = 0; j < array.GetLength(1); j++) {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static double[,] MatrixMultiplication(double[,] A, double[,] B) {
            int n1 = A.GetLength(1);
            int n2 = B.GetLength(0);
            if (n1 != n2) {
                Console.WriteLine("The column count of the first array must equal the row count of the second array");
                return null;
            }

            double[,] C = new double[A.GetLength(0), B.GetLength(1)];

            for (int i = 0; i < A.GetLength(0); i++) {
                for (int j = 0; j < B.GetLength(1); j++) {
                    for (int z = 0; z < n1; z++) {
                        C[i, j] += A[i, z] * B[z, j];
                    }
                }
            }

            return C;
        }
    }
}
