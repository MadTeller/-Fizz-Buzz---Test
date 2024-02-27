using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int count;

            string Fizz(bool isMultiple, bool isFirstSymbol) // кратное 3
            {
                string text;
                if (isMultiple && isFirstSymbol)
                {
                    text = "Fizz";
                    return text;
                }
                else if (isMultiple && !isFirstSymbol)
                {
                    text = "-Fizz";
                    return text;
                }
                else
                {
                    return null;
                }
            }

            string Buzz(bool isMultiple, bool isFirstSymbol) // кратное 5
            {
                string text;
                if (isMultiple && isFirstSymbol)
                {
                    text = "Buzz";
                    return text;
                }
                else if (isMultiple && !isFirstSymbol)
                {
                    text = "-Buzz";
                    return text;
                }
                else
                {
                    return null;
                }
            }

            string Muzz(bool isMultiple, bool isFirstSymbol) // кратное 4
            {
                string text;
                if (isMultiple && isFirstSymbol)
                {
                    text = "Muzz";
                    return text;
                }
                else if (isMultiple && !isFirstSymbol)
                {
                    text = "-Muzz";
                    return text;
                }
                else
                {
                    return null;
                }
            }

            string Guzz(bool isMultiple, bool isFirstSymbol) // кратное 7
            {
                string text;
                if (isMultiple && isFirstSymbol)
                {
                    text = "Guzz";
                    return text;
                }
                else if (isMultiple && !isFirstSymbol)
                {
                    text = "-Guzz";
                    return text;
                }
                else
                {
                    return null;
                }
            }

            void DisplayQueryResult(bool isFizz, bool isBuzz, bool isMuzz, bool isGuzz, bool isFrizzFirst, bool isBuzzFirst, bool isMuzzFirst, bool isGuzzFirst)
            {
                Console.Write(Fizz(isFizz, isFrizzFirst));
                Console.Write(Buzz(isBuzz, isBuzzFirst));
                Console.Write(Muzz(isMuzz, isMuzzFirst));
                Console.Write(Guzz(isGuzz, isGuzzFirst));
                Console.Write(", ");
            }

            void FirstCalculate(int numberCount)
            {
                Console.Write("Задание: Если число делится на 3 без остатка - заменить его на \"fizz\", если делится на 5 без остатка - заменить его на \"buzz\", если делится на 3 и на 5 без остатка - заменить на \"fizz-buzz\": ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("Решение:");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                bool isFirstSymbol = true;
                bool isFizz = false; // кратное 3
                bool isBuzz = false; // кратное 5
                bool isMuzz = false; // кратное 4
                bool isGuzz = false; // кратное 7
                bool isFrizzFirst = false; // является ли число первым ( для отображения "-" )
                bool isBuzzFirst = false;
                bool isMuzzFirst = false;
                bool isGuzzFirst = false;

                int i = 1;
                while (i != numberCount)
                {
                    if (i % 3 == 0)
                    {
                        if (isFirstSymbol)
                        {
                            isFizz = true;
                            isFrizzFirst = true;
                            isFirstSymbol = false;
                        }
                        else
                        {
                            isFizz = true;
                        }

                    }
                    else
                    {
                        isFizz = false;
                    }
                    if (i % 5 == 0)
                    {
                        if (isFirstSymbol)
                        {
                            isBuzz = true;
                            isBuzzFirst = true;
                            isFirstSymbol = false;
                        }
                        else
                        {
                            isBuzz = true;
                        }
                    }
                    else
                    {
                        isBuzz = false;
                    }

                    if (!isFizz && !isBuzz)
                    {
                        Console.Write("{0} ", " " + i + ",");
                    }
                    else
                    {
                        DisplayQueryResult(isFizz, isBuzz, isMuzz, isGuzz, isFrizzFirst, isBuzzFirst, isMuzzFirst, isGuzzFirst);
                    }

                    // Возвращаем все bool переменные в исходное состояние
                    isFirstSymbol = true;
                    isFizz = false;
                    isBuzz = false;
                    isMuzz = false;
                    isGuzz = false;
                    isFrizzFirst = false;
                    isBuzzFirst = false;
                    isMuzzFirst = false;
                    isGuzzFirst = false;
                    i++;
                }
            }

            void SecondCalculate(int numberCount)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("Задание: На основе первой задачи. Нужно добавить аналогичное поведения для чисел кратным 7 и 4. Если делится на 4 без остатка - заменить на \"muzz\", если делится на 7 без остатка - заменить на \"guzz\", если делится на 4 и 7 без остатка - заменить на \"muzz-guzz\": ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("Решение:");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                bool isFirstSymbol = true;
                bool isFizz = false; // кратное 3
                bool isBuzz = false; // кратное 5
                bool isMuzz = false; // кратное 4
                bool isGuzz = false; // кратное 7
                bool isFrizzFirst = false; // является ли число первым ( для отображения "-" )
                bool isBuzzFirst = false;
                bool isMuzzFirst = false;
                bool isGuzzFirst = false;

                int i = 1;
                while (i != numberCount)
                {
                    if (i % 4 == 0)
                    {
                        if (isFirstSymbol)
                        {
                            isMuzz = true;
                            isMuzzFirst = true;
                            isFirstSymbol = false;
                        }
                        else
                        {
                            isMuzz = true;
                        }

                    }
                    else
                    {
                        isMuzz = false;
                    }
                    if (i % 7 == 0)
                    {
                        if (isFirstSymbol)
                        {
                            isGuzz = true;
                            isGuzzFirst = true;
                            isFirstSymbol = false;
                        }
                        else
                        {
                            isGuzz = true;
                        }
                    }
                    else
                    {
                        isGuzz = false;
                    }

                    if (!isMuzz && !isGuzz)
                    {
                        Console.Write("{0} ", " " + i + ",");
                    }
                    else
                    {
                        DisplayQueryResult(isFizz, isBuzz, isMuzz, isGuzz, isFrizzFirst, isBuzzFirst, isMuzzFirst, isGuzzFirst);
                    }

                    // Возвращаем все bool переменные в исходное состояние
                    isFirstSymbol = true;
                    isFizz = false;
                    isBuzz = false;
                    isMuzz = false;
                    isGuzz = false;
                    isFrizzFirst = false;
                    isBuzzFirst = false;
                    isMuzzFirst = false;
                    isGuzzFirst = false;
                    i++;
                }
            }

            void ThirdCalculate(int numberCount)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("Задание: Аналогичное поведения для всех комбинаций чисел при кратности. Пример: число 105 кратно 3, 5, 7 и не кратно 4 - его нужно заменить на \"fizz-buzz-guzz\": ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("Решение:");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                bool isFirstSymbol = true;
                bool isFizz = false; // кратное 3
                bool isBuzz = false; // кратное 5
                bool isMuzz = false; // кратное 4
                bool isGuzz = false; // кратное 7
                bool isFrizzFirst = false; // является ли число первым ( для отображения "-" )
                bool isBuzzFirst = false;
                bool isMuzzFirst = false;
                bool isGuzzFirst = false;

                int i = 1;
                while (i != numberCount)
                {
                    if (i % 3 == 0)
                    {
                        if (isFirstSymbol)
                        {
                            isFizz = true;
                            isFrizzFirst = true;
                            isFirstSymbol = false;
                        }
                        else
                        {
                            isFizz = true;
                        }

                    }
                    else
                    {
                        isFizz = false;
                    }
                    if (i % 5 == 0)
                    {
                        if (isFirstSymbol)
                        {
                            isBuzz = true;
                            isBuzzFirst = true;
                            isFirstSymbol = false;
                        }
                        else
                        {
                            isBuzz = true;
                        }
                    }
                    else
                    {
                        isBuzz = false;
                    }

                    if (i % 4 == 0)
                    {
                        if (isFirstSymbol)
                        {
                            isMuzz = true;
                            isMuzzFirst = true;
                            isFirstSymbol = false;
                        }
                        else
                        {
                            isMuzz = true;
                        }

                    }
                    else
                    {
                        isMuzz = false;
                    }
                    if (i % 7 == 0)
                    {
                        if (isFirstSymbol)
                        {
                            isGuzz = true;
                            isGuzzFirst = true;
                            isFirstSymbol = false;
                        }
                        else
                        {
                            isGuzz = true;
                        }
                    }
                    else
                    {
                        isGuzz = false;
                    }

                    if (!isFizz && !isBuzz && !isMuzz && !isGuzz)
                    {
                        Console.Write("{0} ", " " + i + ",");
                    }
                    else
                    {
                        DisplayQueryResult(isFizz, isBuzz, isMuzz, isGuzz, isFrizzFirst, isBuzzFirst, isMuzzFirst, isGuzzFirst);
                    }

                    // Возвращаем все bool переменные в исходное состояние
                    isFirstSymbol = true;
                    isFizz = false;
                    isBuzz = false;
                    isMuzz = false;
                    isGuzz = false;
                    isFrizzFirst = false;
                    isBuzzFirst = false;
                    isMuzzFirst = false;
                    isGuzzFirst = false;
                    i++;
                }
            }

            void ConsoleRead()
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.Write("Введите цело число - ");
                    string text = Console.ReadLine();
                    if (int.TryParse(text, out int anumber))
                    {
                        if (double.TryParse(text, out double a))
                        {
                            count = int.Parse(text);
                            Console.WriteLine();
                            Console.WriteLine("Вы ввели число {0}", count);
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ошибка 0x454564: Введите целое число");
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ошибка 0x454564: Введите целое число");
                    }

                }

            }

            

            void RunProgram()
            {
                while(true)
                {
                    ConsoleRead();
                    FirstCalculate(count);
                    SecondCalculate(count);
                    ThirdCalculate(count);
                    Console.WriteLine();
                }
            }

            RunProgram();
        }

       
    }
}
