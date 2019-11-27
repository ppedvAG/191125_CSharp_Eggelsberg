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
            try
            {



                // try + TAB + TAB
                try
                {
                    Console.WriteLine("Bitte geben Sie eine Zahl ein:");
                    int zahl = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Deine Eingabe war: " + zahl);

                    // Fehler selber auslösen
                    // throw new InvalidOperationException("FEHLER HAHAHHAHA");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bitte geben Sie nur ganze Zahlen ein !");
                    throw new DivideByZeroException();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Deine Zahl war zu groß oder zu klein");
                }
                finally
                {
                    Console.WriteLine("Codeblock, der IMMER ausgeführt wird");
                }

                //catch (Exception ex)
                //{
                //    //Console.WriteLine("FEHLER !!!!!!11111ELF!!!");
                //    Console.WriteLine(ex.Message);
                //    // throw; // <--- Fehler ausgeben
                //}

            }
            catch (Exception)
            {
                Console.WriteLine("wir kommen aus der DivideByZero-Exception ;) ");
            }


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
