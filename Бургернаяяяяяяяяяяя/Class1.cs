using burgernaSUBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rivrv
{
    internal class arrow1111
{
    public static int Arrow(int posicion, int min, int max, int cena, string pokupka)
    {
        ConsoleKeyInfo key;
        do
        {
            Console.SetCursorPosition(0, posicion);
            Console.WriteLine("->");
            key = Console.ReadKey();
            Console.SetCursorPosition(0, posicion);
            Console.WriteLine("  ");
            if (key.Key == ConsoleKey.UpArrow)
            {
                posicion--;
                if (posicion == min - 1)
                    posicion = max;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                posicion++;
                if (posicion == max + 1)
                    posicion = min;
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Menu.Menu1(posicion, cena, pokupka);
            }

        } while (key.Key != ConsoleKey.Enter);
        return posicion;
    }
}
}





