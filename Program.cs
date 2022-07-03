using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for loop
            int i;
           for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter number in 1,2,3");
                int name = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    Console.WriteLine("Hii Maruthi ");
                }
                else if (i == 2)
                {
                    Console.WriteLine("How Are YOU");
                }
                else if (i == 3)
                {
                    Console.WriteLine("okay thank u ,bye");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

            }
           //foreach loop

            int[] Numbers = new int[3];
            Numbers[0] = 10;
            Numbers[1] = 20;
            Numbers[2] = 30;

            foreach (int k in Numbers)
            {
                Console.WriteLine(k);
            }
             Console.WriteLine("Continue statement :");
            for(int j = 0; j <= 5; j++)
            {
                if (j % 2 == 1)
                    continue;
                Console.WriteLine(j);
            }
            Console.WriteLine("break statement :");
            for (int k = 0; k < 5; k++)
            {
                if (k == 3)
                    break;
                Console.WriteLine(k);
            }
        }
    }
}
