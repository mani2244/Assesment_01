using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[,] nrr = new int[3, 3];

            for (int i = 0; i < nrr.GetLength(0); i++)
            {
                for (int j = 0; j < nrr.GetLength(0); j++)
                {
                    Console.WriteLine($"Enter The Value of nrr[{i}][{j}]");
                    nrr[i,j]=int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < nrr.GetLength(0); i++)
            {
                for (int j = 0; j < nrr.GetLength(0); j++)
                {
                    Console.Write(nrr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
            

    }
}
