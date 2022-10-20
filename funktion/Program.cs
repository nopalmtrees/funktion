using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funktion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helle world");
            //anropa Myfunction
            Myfunction();
            Myfunction();

            //Anropa Oneortwo med parametervärde
            OneOrTwo(1);
            OneOrTwo(2);
        }

        //skapa en ny funktion som heter myfunctio.
        static void Myfunction() 
        {
            Console.WriteLine("inuti en funktion");
            
        }

        //skapa funktonen oneortwo som tar in parametervärde
        static void OneOrTwo(int input)
        {
            if (input == 1)
            {
                Console.WriteLine("input är 1");
            }else if (input == 2)
            {
                Console.WriteLine("input är 2");
                Console.ReadLine();
            } 

        }
        
    }




}
