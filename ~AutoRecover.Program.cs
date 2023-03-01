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
    }
}
