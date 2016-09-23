using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forOvningar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Övning1

            for (int i = 0; i <=100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

     övning2:
    
            for (int i = 20; i >=1; i= i-1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

    
     övning3:
            for (int i = 0; i <=50; i=i+2)
            {
                Console.WriteLine(i);

            }
            Console.ReadLine();
            
    övning4

            Console.WriteLine("mata in start");
            string in1 = Console.ReadLine();
            int start = int.Parse(in1);

            

            Console.WriteLine("mata in stopp");
            string in2 = Console.ReadLine();
            int stopp = int.Parse(in2);

            Console.WriteLine("mata in steg");
            string in3 = Console.ReadLine();
            int steg = int.Parse(in3);

            for (start = start; start <= stopp; start = start +steg)
            {
                Console.WriteLine(start + "  ");
            }
            Console.ReadLine();*/
            {

                Console.WriteLine("mata in heltal");
                int in1 =int.Parse(Console.ReadLine());
               
                int summa = 0;

                for (int i = 0; i <= in1; i++)
                {
                    summa = summa + i;
                
                }
                Console.WriteLine("summan av alla tal från 1 till " + in1 + " blir " +summa);
                Console.ReadLine();

            }
            {

            }






        }
    }
}
