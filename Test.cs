using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_3
{
     class Test
    {
        public static void Main(string[] args)
        {
           control at = new control();
            int x, y;
           

            do
            {
                Console.WriteLine("1. Add \n2.Display");
                Console.WriteLine("Enter Chuc Nang: ");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                   
                    case 1:
                        {
                            at.accept();
                            break;
                        }
                    case 2:
                        {
                            at.Display();
                            break;
                        }

                }
                Console.WriteLine("Enter (1) Continue: ");
                y = Convert.ToInt32(Console.ReadLine());
            } while (y <= 1 );

    {

            }
        }
        
    }
}
