using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;

namespace Дз_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Задание 1. Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май" (кавычки
                не нужны). Причем сделайте так, чтобы выводилось сначала так:
                a.Мир Труд Май
                b.Затем так:
                    Мир
                        Труд
                            Май */
            Console.WriteLine("Задание 1: Ввывести Мир Труд Май в двух вариантах");
            Console.WriteLine("\n\tПункт а: \nМир Труд Май\n");
            Console.WriteLine("\tПункт b: \nМир\n    Труд\n\t Май\n");

            /* Задание 2.Программа просит пользователя ввести 2 числовые переменные. А после она меняет
                   их местами и выводит результат на экран. Но, так как пользователь может
                       ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
                        например, букву или строку, а так же учесть, что число может быть дробным, и для
                            выделения ее дробной части одни используют точку, другие – запятую. */
                try

                {
                    Console.WriteLine("\nЗадание 2: Ввести два числа, в случае неправильного ввода исправить их");
                    Console.WriteLine("\tВведите первое число:");
                    string number1 = Console.ReadLine();
                    Console.WriteLine("\tВведите второе число:");
                    string number2 = Console.ReadLine();
                    number1 = number1.Replace(".", ",");
                    number2 = number2.Replace(".", ",");
                    double number3 = Convert.ToDouble(number1);
                    double number4 = Convert.ToDouble(number2);
                    Console.WriteLine("Ответ:{0}, {1}", number4, number3);
                }
                catch
                    {
                    Console.WriteLine("Вы ввели неверные данные");
                    }

            /* Задание 3. Дан радиус окружности. Найти длину окружности и площадь круга. */

            Console.WriteLine("\nЗадание 3: Найти длину окружности и площадь круга");
            Console.WriteLine("\tВведите радиус окружности");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circle = 2 * radius * Math.PI;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Радиус = {0}, Окружность = {1}, Площадь = {2}",radius, circle, area);

            /* Задание 4. Найти значение y=cos(x) */

            Console.WriteLine("\nЗадание 4: Найти значение y=cos(x)");
            Console.WriteLine("\tВведите значание x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Значение равно: cos({0}) = {1}", x, Math.Cos(x));

            /* Задание 5. Найти корни квадратного уравнения(коэффициенты задаются пользователем с
                клавиатуры) */

            Console.WriteLine("\nЗадание 5: Найти корни квадратного уравнения");
            Console.WriteLine("\tВведите первый коэффицент");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tВведите второй коэффинцент:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tВведите третий коэффицент:");
            int c = Convert.ToInt32(Console.ReadLine());
            double discrininant = b * b - 4 * a * c;
            if (discrininant == 0)
                {
                double X1 = -b / 2;
                Console.WriteLine("Имеется единственный квадратный корень: {0}", X1);
                }
            else if (discrininant > 0)
                {
                double x1 = (-b - Math.Sqrt(discrininant) / 2 * a);
                double x2 = (-b + Math.Sqrt(discrininant) / 2 * a);
                Console.WriteLine("Имеется два корня: x1 = {0}, x2 = {1}", x1, x2);
                }
            else
                {
                Console.WriteLine("Не имеется корней");
                }

            /* Задание 6.Составить программу обмена значениями трех переменных величин а, b, c по
                следующим двум схемам:
                a. b присвоить значение c, а присвоить значение b, с присвоить значение а;
                b. b присвоить значение а, с присвоить значение b, а присвоить значение с. */

            Console.WriteLine("\nЗадание 6: обменять значениями три переменные");
            Console.WriteLine("\tВведите величину 'a':");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tВведите величину 'b':");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tВведите величину 'c':");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\tПункт a:");
            Console.WriteLine("Значение 'b' присвоило значение 'c', b = {0}", C);
            Console.WriteLine("Значение 'a' присвоило значение 'b', a = {0}", B);
            Console.WriteLine("Значение 'b' присвоило значение 'c', b = {0}", A);
            Console.WriteLine("\tПункт b:");
            Console.WriteLine("Значение 'b' присвоило значение 'a', b = {0}", A);
            Console.WriteLine("Значение 'c' присвоило значение 'b', a = {0}", B);
            Console.WriteLine("Значение 'a' присвоило значение 'c', b = {0}", C);

            /* Задание 7.Составить программу вывода на экран «столбиком» четырех случайных чисел. */

            Console.WriteLine("\nЗадание 7: Вывести 4 случайных числа");
            Random X = new Random();
            int n1 = X.Next();
            int n2 = X.Next();
            int n3 = X.Next();
            int n4 = X.Next();
            Console.WriteLine("\n{0}\n{1}\n{2}\n{3}", n1, n2, n3, n4);

            /* Задание 8. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее
            в начале. Найти полученное число. */

            Console.WriteLine("\nЗадание 8: Работа со строкой");
            int number = Convert.ToInt32(Console.ReadLine());
            string Number = Convert.ToString(number);
            int len = Number.Length;
            if (len == 3) 
                {            
                Console.WriteLine("Ответ: {0}{1}{2}",Number[2], Number[0], Number[1]);
                }
            else
                {
                Console.WriteLine("Вы ввели некорреткное число!!!");
                }

            /* Известна стоимость 1 кг конфет, 1 кг печенья и 1 кг яблок. Найти стоимость всей
            покупки, если купили x кг конфет, у кг печенья и z кг яблок. */ 
            Console.WriteLine("\nЗадание 9: Посчитать стоимость");
            Console.WriteLine("\tВведите стоимость конфет, печенья, яблок:");
            double candies = Convert.ToDouble(Console.ReadLine());
            double cookies = Convert.ToDouble(Console.ReadLine());
            double apples = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\tВведите вес конфет, печенья, яблок:");
            double x1kg = Convert.ToDouble(Console.ReadLine());
            double y1kg = Convert.ToDouble(Console.ReadLine());
            double z1kg = Convert.ToDouble(Console.ReadLine());
            double Summa1 = candies * x1kg + cookies * y1kg + apples * z1kg;
            Console.WriteLine("Чек:\nвы купили\n{0} кг конфет\n{1} кг печенья\n{2} кг яблок\nОбщая сумма:{3} рублей\nБлагодарим за покупку",x1kg,y1kg,z1kg,Summa1);


            Console.ReadKey();

        }
    }
}
