using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprogramm
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            string poem = "";
            while (x < 1)
            {
             x=x+1;
                if (x < 1)
                {
                 poem = poem + " ";
                }
             poem = poem + "n";
                     if(x > 0){
                      poem = poem + "oise ";
                      x = x + 2;
                     }
                        if (x == 1)
                         {
                          poem = poem + " ";
                         }
                                  if (x < 1)
                                  {
                                   poem = poem + "oise ";
                                  }
             x = x -2;
            
            }
            Console.WriteLine(poem);
            Console.ReadKey();
        }
    }
}
