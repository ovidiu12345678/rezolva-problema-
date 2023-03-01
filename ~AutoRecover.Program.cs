using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmica_Csharp
{
    class Program
    {
         Console.WriteLine("Introduceti dimensiunile  mattricei !");
            Console.WriteLine("Matrice linii : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Matrice coloane : ");
            int m = int.Parse(Console.ReadLine());


            Console.WriteLine("Introduceti elementele primei matrice ! ");
            int[,] matrice1 = CitesteMatrice(n, m);

            Console.WriteLine("Introduceti elementele celei de-a doua matrice !");
            int[,] matrice2 = CitesteMatrice(n, m);


            AfisareMatrice(matrice1);
            AfisareMatrice(matrice2);
        
         Console.WriteLine("Rezultatul final a-l matricei generate este : ");

            int[,] diferenta = CalculeazaDiferentaMatrie(matrice1, matrice2, n, m);

            AfisareMatrice(diferenta);

            Console.ReadKey();
        }


        static int[,] CitesteMatrice(int n, int m)
        {
            int[,] matrix = new int[n, m];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.WriteLine("Introduceti elementul !");

                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return matrix;
        }

        static void AfisareMatrice(int[,] matrice)
        {
            Console.WriteLine("Acesta este  matricea  generate ! ");

            foreach(int element in matrice)
            {
                Console.WriteLine(element);
            }

        }
       
        // Calculeaz diferenta dintre cele doua matrice generan ca rezultat o noua matrice cu n linii de elemente m coloane de elemente
        static int[,] CalculeazaDiferentaMatrie(int[,] matrix1, int[,] matrix2, int linii, int coloane)
        {
            

            if(matrix1.Length != matrix2.Length || matrix1.Rank != matrix2.Rank || matrix1.GetLength(0) != matrix2.GetLength(0))
            {
                return null;
            }

            int[,] result = new int[linii, coloane];

            for(int i = 0; i < linii; i++)
            {
                for(int j = 0; j < coloane; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }
    }
}
