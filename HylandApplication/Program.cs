using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HylandApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 21 == 0)
            //    {
            //        Console.WriteLine("OnBase");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("On");
            //    }
            //    else if (i % 7 == 0)
            //    {
            //        Console.WriteLine("Base");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            int countNum = 0;

            for (int i = 2; i <= 300; i++)
            {
                for (int j = 2; j <= 300; j++)
                {
                    if (i % j == 0)
                    {
                        countNum++;
                     
                    }
                }
                if (countNum == 1)
                {
                    Console.WriteLine(i);
                }
                countNum = 0;
            }


            //Console.WriteLine("Please type a word");
            //string input = Console.ReadLine();
            //string reverse = new string(input.ToCharArray().Reverse().ToArray());
            //Console.WriteLine(reverse);

        }
    }
}
