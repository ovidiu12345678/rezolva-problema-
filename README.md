# rezolva-problema-

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmica_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number of items ! ");
            int numbers = int.Parse(Console.ReadLine());

            int[] vecor = ReadVectorOfNumbersElements(numbers);

            Console.WriteLine("The elements of the vector are ! ");

            foreach(int numbersElements in vecor)
            {
                Console.WriteLine(numbers);
            }

            Console.ReadKey();
        }

        static int[] ReadVectorOfNumbersElements(int numbers)
        {
            int[] result = new int[numbers];

            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Insert the elements ! ");
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
    }
}
