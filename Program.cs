using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars_Design
{
    class Program
    {
        static void Main(string[] args)
         {
                //Call Methods
                stars(5);
            }
        
            //method
            public static void stars(int n)
            {
                for (int i = 5; i <= 5; i++)
                {
                    Console.WriteLine(new String('*', i));
                    Console.WriteLine(new String('*', i));
                    Console.WriteLine(new String('*', i));
                    Console.WriteLine(new String('*', i));
                    Console.WriteLine(new String('*', i));
                }

                Console.WriteLine();
            }
        }
    }
