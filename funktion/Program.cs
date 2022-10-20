using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funktion
{
    internal class Program



    {

        // Deklarerar en global variabel
        static string carColor;
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

            //global variabel carcolor
            Console.WriteLine("Min bil har färgen {0}" + carColor);
            car();
            Console.WriteLine(("Min bil har färgen {0}" + carColor));

            // funktion summera två tal
            int summa = Add(3, 7);
            summa += Add(x);
            summa += Add();
            Console.WriteLine(summa);

              
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
            } else if (input == 2)
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
        static void car()
        {
            carColor = "Röd";
        }
        //funktion för att returnerna summa av två
        static int Add(int tal1 =0, int tal2 =0)
        {
            return tal1 + tal2; 
        }
        //
        
        
        
        
        
    }




}
