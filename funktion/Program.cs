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
            int x = 2;
            OneOrTwo(1);
            OneOrTwo(2);
            OneOrTwo(x);

            //anropar funk seygej och sparar returvärde i variabel
            string meddelande = SayHey("Tobbe");
            Console.WriteLine(meddelande);

            Console.WriteLine(SayHey("Ebbot"));
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
               
            }
            
        }
        //skapar funktion som returnerar hälsning
        static string SayHey(string name)
        {
            string message = "Hejsan " + name;
            return message;
            
        }
        
        
        
        
    }




}
