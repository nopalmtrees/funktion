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
        }

        //skapa en ny funktion som heter myfunctio.
        static void Myfunction() 
        {
            Console.WriteLine("inuti en funktion");
            Console.ReadLine();
        }


        
    }




}
