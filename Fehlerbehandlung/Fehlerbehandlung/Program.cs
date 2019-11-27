using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fehlerbehandlung
{
    class Program
    {
        static void Main(string[] args)
        {

            // try + TAB + TAB
            try
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein:");
                int zahl = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Deine Eingabe war: " + zahl);
            }
            catch(FormatException)
            {
                Console.WriteLine("Bitte geben Sie nur ganze Zahlen ein !");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Deine Zahl war zu groß oder zu klein");
            }
            //catch (Exception ex)
            //{
            //    //Console.WriteLine("FEHLER !!!!!!11111ELF!!!");
            //    Console.WriteLine(ex.Message);
            //    // throw; // <--- Fehler ausgeben
            //}


            

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
