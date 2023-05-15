using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ex3_3
{
    class control
    {
        List<Atom> atm1 = new List<Atom>();
        int number1;
        string symbol1;
        string fullname1;
        double weight1;
        

        public bool accept()
        {
           
            
                Console.Write("Enter tomic number: ");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter symbol: ");
                symbol1 = Console.ReadLine();

                Console.Write("Enter full name: ");
                fullname1 = Console.ReadLine();

                Console.Write("Enter tomic weight: ");
                
                weight1 = Convert.ToDouble(Console.ReadLine());

            

                
                Atom at = new Atom(number1, symbol1, fullname1, weight1 );
                atm1.Add(at);
                return true;
                
                
                

           

        }

        public void Display()
        {
            foreach(Atom atom in atm1)
            {
                Console.WriteLine("Atomic Information \r\n==================");
                Console.WriteLine("atomic number : {0} ",number1);
                Console.WriteLine("symbol : {0} ", symbol1);
                Console.WriteLine("atomic number : {0} ", fullname1);
                Console.WriteLine("atomic weight : {0} ", weight1);

               
            }
        }
    }
}
