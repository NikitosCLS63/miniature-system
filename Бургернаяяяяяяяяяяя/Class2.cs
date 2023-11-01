using burgernaSUBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вопросик
{
    internal class main
    {

        static void Main(string[] args)
        {
            string pokupka = "";
            int cena = 0;
            int posicion = 3;


            do
            {
                Console.Clear();
                Menu.Menu1(posicion, cena, pokupka);

            } while (true);
        }
    }
}



