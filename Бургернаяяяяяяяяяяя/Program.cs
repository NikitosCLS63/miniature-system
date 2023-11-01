using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rivrv;



namespace burgernaSUBO
{
    internal class Menu
    {

        public static void Menu1(int posicion, int cena, string pokupka)
        {
            Console.WriteLine("\n***********************закажите бургер со своими параметрами,новая функция прям из ДУБАЯ***********************\n");
            Console.WriteLine("  Форма булочки");
            Console.WriteLine("  Размер булочки");
            Console.WriteLine("  Выбор катлеты");
            Console.WriteLine("  Форма катлеты");
            Console.WriteLine("  Размер катлеты");
            Console.WriteLine("  Форма сыра");
            Console.WriteLine("  Форма салата");
            Console.WriteLine("  Соус");
            Console.WriteLine("  Конец покупки");
            Console.WriteLine("  ");
            Console.WriteLine("  Цена; " + pokupka);
            Console.WriteLine("  ВАШ бургер\n" + pokupka);
            posicion = arrow1111.Arrow(posicion, 3, 11, cena, pokupka);
            haracteristik(posicion, cena, pokupka);
        }

        private static void haracteristik(int posicion, int cena, string pokupka)
        {

            {



                if (posicion == 3)
                {
                    Console.Clear();
                    Console.WriteLine("  Выйти: Escape");
                    Console.WriteLine("  Выберите форму булочки");
                    Console.WriteLine(" >>>>>>>>>>>>> ");
                    posicion = 3;
                    Console.WriteLine("  Квадрат - 45р");
                    Console.WriteLine("  Круг - 35р");
                    Console.WriteLine("  Треугольник - 50р");
                    posicion = arrow1111.Arrow(posicion, 3, 5, cena, pokupka);
                    if (posicion == 3)
                    {
                        cena += 45;
                        pokupka += "Квдарат: форма булочки - 45р \n";


                    }
                    else if (posicion == 4)
                    {
                        cena += 35;
                        pokupka += "Круг: форма булочки - 35р \n";



                    }
                    else if (posicion == 5)
                    {
                        cena += 50;
                        pokupka += "Треугольник: форма булочки - 50р\n";

                    }

                    Console.Clear();
                    Menu1(
                        posicion,
                        cena,
                        pokupka);



                }
                else if (posicion == 4)
                {
                    posicion = 3;
                    Console.Clear();
                    Console.WriteLine("  Выйти - Escape");
                    Console.WriteLine("  Выбрать размер булочки");
                    Console.WriteLine("  >>>>>>>>>>>>> ");
                    Console.WriteLine("  Маленькая - 45р");
                    Console.WriteLine("  Средняя - 75р");
                    Console.WriteLine("  Большая - 105р");
                    posicion = arrow1111.Arrow(posicion, 3, 5, cena, pokupka);
                    if (posicion == 3)
                    {
                        cena += 45;
                        pokupka += "Маленькая булочка - 45р\n";
                    }
                    if (posicion == 4)
                    {
                        cena += 75;
                        pokupka += "Средняя булочка - 75р\n";
                    }
                    if (posicion == 5)
                    {
                        cena += 105;
                        pokupka += "Большая булочка - 105р\n";
                    }

                    Console.Clear();
                    Menu1(posicion, cena, pokupka);



                }
                else if (posicion == 5)
                {
                    posicion = 3;
                    Console.Clear();
                    Console.WriteLine("  Выйти - Escape");
                    Console.WriteLine("  Выберите катлету");
                    Console.WriteLine("  >>>>>>>>>>>>> ");
                    Console.WriteLine("  Курица - 35р");
                    Console.WriteLine("  Говядина - 55р");
                    Console.WriteLine("  Рыба - 75р");
                    Console.WriteLine("  Краб - 190р");
                    Console.WriteLine("  Вегантерианская - 25р");
                    posicion = arrow1111.Arrow(posicion, 3, 7, cena, pokupka);

                    if (posicion == 3)
                    {
                        cena += 35;
                        pokupka += "Курица - 35р\n";
                    }
                    if (posicion == 4)
                    {
                        cena += 55;
                        pokupka += "Говядина - 55р\n";
                    }
                    if (posicion == 5)
                    {
                        cena += 75;
                        pokupka += "Рыба - 75р\n";

                    }
                    if (posicion == 6)
                    {
                        cena += 190;
                        pokupka += "Краб - 190р\n";
                    }
                    if (posicion == 7)
                    {
                        cena += 25;
                        pokupka += "Вегантерианская - 25р\n";
                    }

                    Console.Clear();
                    Menu1(posicion, cena, pokupka);
                }
                else if (posicion == 6)
                {
                    posicion = 3;
                    Console.Clear();
                    Console.WriteLine("  Выйти - Escape");
                    Console.WriteLine("  Выберите форму катлеты");
                    Console.WriteLine("   >>>>>>>>>>>>> ");
                    Console.WriteLine("  Квадрат - 45р");
                    Console.WriteLine("  Круг - 35р");
                    Console.WriteLine("  Треугольник - 50");
                    posicion = arrow1111.Arrow(posicion, 3, 5, cena, pokupka);


                    if (posicion == 3)
                    {
                        cena += 45;
                        pokupka += "Квдарат: форма катлеты - 45р\n";

                    }
                    if (posicion == 4)
                    {
                        cena += 35;
                        pokupka += "Круг: форма катлеты - 35р \n";
                    }
                    if (posicion == 5)
                    {
                        cena += 50;
                        pokupka += "Треугольник: форма катлеты- 50р\n";

                    }

                    Console.Clear();
                    Menu1(posicion, cena, pokupka);

                }
                else if (posicion == 7)
                {
                    posicion = 3;
                    Console.Clear();
                    Console.WriteLine("  Выйти - Escape");
                    Console.WriteLine("  Выберите размер котлеты");
                    Console.WriteLine("  >>>>>>>>>>>>> ");
                    Console.WriteLine("  Маленький - 45р");
                    Console.WriteLine("  Средний - 75р");
                    Console.WriteLine("  Большой - 105р");
                    posicion = arrow1111.Arrow(posicion, 3, 5, cena, pokupka);


                    if (posicion == 3)
                    {
                        cena += 45;
                        pokupka += "Маленький: размер катлеты- 45р\n";
                    }
                    if (posicion == 4)
                    {
                        cena += 75;
                        pokupka += "Средний: размер катлеты - 75р\n";

                    }
                    if (posicion == 5)
                    {
                        cena += 105;
                        pokupka += "Большой: размер катлеты - 105р\n";
                    }

                    Console.Clear();
                    Menu1(posicion, cena, pokupka);

                }
                else if (posicion == 8)
                {
                    posicion = 3;
                    Console.Clear();
                    Console.WriteLine("  Выйти - Escape");
                    Console.WriteLine("  Выберите форму сыра");
                    Console.WriteLine("  >>>>>>>>>>>>> ");
                    Console.WriteLine("  Квадрат- 25р");
                    Console.WriteLine("  Круг - 35р");
                    Console.WriteLine("  Треугольник - 45р");
                    posicion = arrow1111.Arrow(posicion, 3, 5, cena, pokupka);

                    if (posicion == 3)
                    {
                        cena += 25;
                        pokupka += "Квдарат: форма сыра - 25р \n";
                    }
                    if (posicion == 4)
                    {
                        cena += 35;
                        pokupka += "Круг форма: сыра - 35р \n";

                    }
                    if (posicion == 5)
                    {
                        cena += 45;
                        pokupka += "Треугольник: форма сыра - 45р\n";

                    }

                    Console.Clear();
                    Menu1(posicion, cena, pokupka);

                }
                else if (posicion == 9)
                {
                    posicion = 3;
                    Console.Clear();
                    Console.WriteLine("  Выйти - Escape");
                    Console.WriteLine("  Выберите форму салата");
                    Console.WriteLine("  >>>>>>>>>>>>> ");
                    Console.WriteLine("  Квадрат- 25р");
                    Console.WriteLine("  Круг - 35р");
                    Console.WriteLine("  Треугольник - 45р");
                    posicion = arrow1111.Arrow(posicion, 3, 5, cena, pokupka);

                    if (posicion == 3)
                    {
                        cena += 25;
                        pokupka += "Квдарат: форма салата - 25р \n";
                    }
                    if (posicion == 4)
                    {
                        cena += 35;
                        pokupka += "Круг: форма салата - 35 \n";

                    }
                    if (posicion == 5)
                    {
                        cena += 45;
                        pokupka += "Треугольник: форма салата - 45\n";

                    }
                    Console.Clear();
                    Menu1(posicion, cena, pokupka);


                }
                else if (posicion == 10)
                {
                    posicion = 3;
                    Console.Clear();
                    Console.WriteLine("  Выйти - Escape");
                    Console.WriteLine("  Выберите соус");
                    Console.WriteLine("  >>>>>>>>>>>>> ");
                    Console.WriteLine("  Кетчуп- 25р");
                    Console.WriteLine("  Горчица - 35р");
                    Console.WriteLine("  Майонез  - 35р");
                    Console.WriteLine("  Кетчонез  - 50р");
                    posicion = arrow1111.Arrow(posicion, 3, 6, cena, pokupka);

                    if (posicion == 3)
                    {
                        cena += 25;
                        pokupka += "Кетчуп- 25р \n";
                    }
                    if (posicion == 4)
                    {
                        cena += 35;
                        pokupka += "Горчица - 35р \n";
                    }
                    if (posicion == 5)
                    {
                        cena += 35;
                        pokupka += "Майонез - 35р\n";
                    }
                    if (posicion == 6)
                    {
                        cena += 50;
                        pokupka += "Кетчонез - 50р\n";
                    }
                    Console.Clear();
                    Menu1(posicion, cena, pokupka);
                }
                else if (posicion == 11)
                {
                    Console.Clear();
                    Console.WriteLine("Покупка создана, нажмите Enter, если хотите заказать еще.");
                    File.AppendAllText("C:\\Users\\User\\Desktop\\Ващи заказы си шарп.txt", "Заказ от: " + DateTime.Now + "\n");
                    File.AppendAllText("C:\\Users\\User\\Desktop\\Ващи заказы си шарп.txt", pokupka + "\n");
                    File.AppendAllText("C:\\Users\\User\\Desktop\\Ващи заказы си шарп.txt", "Итоговая сумма :" + cena + "рубля..яяя" + "\n");
                    File.AppendAllText("C:\\Users\\User\\Desktop\\Ващи заказы си шарп.txt", "  ");
                    cena = 0;
                    pokupka = "";
                    arrow1111.Arrow(posicion, 3, 6, cena, pokupka);
                }
            }
        }
    }
}



