using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramadaaan
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                for (int j = 1; j <= 15-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <=(i*2)-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            for (int i = 1; i <=12; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k=1 ; k <= (30-(i*2-1)); k++)
                {
                    if (k==1||k==(30-(i*2-1)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                   
                }
                Console.Write("\n");
               
              
            }
            for (int i = 2; i <=5 ; i++)
            {
                for (int j = 13; j >=i ; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <=(i*2)+1; k++)
                {
                    Console.Write("*");
                }
               Console.WriteLine(" ");
            }
            Console.WriteLine("\tRamadan Kareem");
           
            Console.WriteLine("\t#One Million Egyptian programmers");
        }

       
    }
}
