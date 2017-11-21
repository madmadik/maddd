using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Task1()
        {
             Console.WriteLine("vvedite x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(7*x * x - 3* x +4);
            Console.ReadLine();
        }
        static void Task2()
        {
            /*2.	Дан радиус окружности. Найти длину окружности и площадь круга.*/
            Console.WriteLine("vvedite x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("dlina = " + 2 * Math.PI * x + ", plowad = " + Math.PI * x * x);
            Console.ReadLine();

        }
        static void Task3()
        {
            int sotka = 100;
            /*3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.*/
            Console.WriteLine("vvedite x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("metrov = " + x / sotka);
            Console.ReadLine();

        }
        static void Task4()
        {
            int den = 234;
            int nedel = 7;
            /*4.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?*/
            Console.WriteLine("polnix nedel: " + den/nedel);
            Console.ReadLine();

        }
        static void Task5()
        {
            /*5.	Дано двузначное число. Найти:
	                     число десятков в нем;
	                     число единиц в нем;
                        сумму его цифр;
	                      произведение его цифр
                                   */
            int count = 0,desyat=10;
            Console.WriteLine("vvedite x: ");
            int x = int.Parse(Console.ReadLine());
            if(x%desyat==1)
            {
                count++;
            }
            if(x-x%desyat==1)
            {
                count++;
            }
            Console.WriteLine("desyatkov = " + x / desyat+" , edinis = "+count+" , summa sifr = "+(x/desyat+x%desyat)+" , proizvedenie = "+ (x / desyat * x % desyat));
            Console.ReadLine();
        }
        static void Task6()
        {
            /*6.	Дано четырехзначное число. Найти:
a.	сумму его цифр;
b.	произведение его цифр
*/
            int tisyach = 1000, sotka = 100, desyat = 10;
            Console.WriteLine("vvedite 4 znachnoe chislo: ");
            int x = int.Parse(Console.ReadLine());
           Console.WriteLine("summa = "+(x/tisyach+x/sotka-x/tisyach*desyat+x/desyat-x/sotka*desyat+x-x/desyat*desyat));
            Console.WriteLine("summa = " + (x / tisyach *( x / sotka - x / tisyach * desyat )* (x / desyat - x / sotka * desyat) *( x - x / desyat * desyat)));
            Console.ReadLine();
        }
        static void Task7()
        {
            /*7.	В трехзначном числе x зачеркнули его вторую цифру. 
             * Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456.
             * Найти число x.*/
            int x = 465;
            Console.WriteLine(x);
            Console.ReadLine();
        }
        static void Task8()
        {
            /*8.	Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
a.	не X и не Y;
b.	X или (не X и Y);
c.	(не X и Y) или Y.
*/

            bool x = true;
            bool y = false;
            Console.WriteLine(!x &&!y);
            Console.WriteLine(x||(!x&&y));
            Console.WriteLine((!x&&y)||y);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
           Task3();
            Task4();
           Task5();
           Task6();
            Task7();
            Task8();

        }
    }
}
