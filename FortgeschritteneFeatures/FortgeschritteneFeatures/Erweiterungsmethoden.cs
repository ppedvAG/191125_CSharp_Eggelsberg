using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortgeschritteneFeatures
{
    // 1) static class
    static class Erweiterungsmethoden
    {
        // 2) Parameter: this - schlüsselwort
        public static int Verdoppeln(this int input)
        {
            return input * 2;
        }

        public static string Umdrehen(this string input)
        {
            // .....
        }
    }
}
