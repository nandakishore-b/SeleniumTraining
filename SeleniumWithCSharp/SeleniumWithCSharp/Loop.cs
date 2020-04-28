using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp
{
    class Loop
    {
        static void Main(string[]args)
        {
            //for loop

            for(int i=1; i<=100; i++)

            {
                if(i ==16)

                {
                   // break;
                    continue;
                }
                    
                    
                Console.Write(i+ " ");


            }



        }
    }
}
