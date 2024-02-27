using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good_Boy_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;

            string GoodBoy(bool isMultiple, bool isFirstSymbol) // кратное 3 и 5
            {
                string text;
                if (isMultiple && isFirstSymbol)
                {
                    text = "Good-Boy";
                    return text;
                }
                else if (isMultiple && !isFirstSymbol)
                {
                    text = "-Good-Boy";
                    return text;
                }
                else
                {
                    return null;
                }
            }

            string Dog(bool isMultiple, bool isFirstSymbol) // кратное 3
            {
                string text;
                if (isMultiple && isFirstSymbol)
                {
                    text = "Dog";
                    return text;
                }
                else if (isMultiple && !isFirstSymbol)
                {
                    text = "-Dog";
                    return text;
                }
                else
                {
                    return null;
                }
            }

            string Cat(bool isMultiple, bool isFirstSymbol) // кратное 5
            {
                string text;
                if (isMultiple && isFirstSymbol)
                {
                    text = "Cat";
                    return text;
                }
                else if (isMultiple && !isFirstSymbol)
                {
                    text = "-Cat";
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

            string Guzz(bool isMultiple, bool isFirstSymbol) // 7
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

            void DisplayQueryResult(bool isGoodBoy, bool isDog, bool isCat, bool isMuzz, bool isGuzz, bool isGoodBoyFirst, bool isDogFirst, bool isCatFirst, bool isMuzzFirst, bool isGuzzFirst)
            {
                Console.Write(GoodBoy(isGoodBoy, isGoodBoyFirst));
                Console.Write(Dog(isDog, isDogFirst));
                Console.Write(Cat(isCat, isCatFirst));
                Console.Write(Muzz(isMuzz, isMuzzFirst));
                Console.Write(Guzz(isGuzz, isGuzzFirst));
                Console.Write(", ");
            }

            void FirstCalculate(int numberCount)
            {
                Console.Write("Измените поведение для деления без остатка на 3 и 5. Если делится на 3 без остатка - заменить на \"dog\", если делится на 5 без остатка - заменить на \"cat, если на 3 и 5 без остатка - заменить на \"good-boy\". При кратности на 3 и 5 и другие числа - \"good-boy\" выводить вначале замены. ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                bool isFirstSymbol = true;
                bool isGoodBoy = false; // кртаное 3 и 5
                bool isDog = false; // кратное 3
                bool isCat = false; // кратное 5
                bool isMuzz = false; // кратное 4
                bool isGuzz = false; // кратное 7
                bool isGoodBoyFirst = false;
                bool isDogFirst = false; // является ли число первым ( для отображения "-" )
                bool isCatFirst = false;
                bool isMuzzFirst = false;
                bool isGuzzFirst = false;

                int i = 1;
                while (i != numberCount)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        if (isFirstSymbol)
                        {
                            isGoodBoy = true;
                            isGoodBoyFirst = true;
                            isFirstSymbol = false;
                        }
                        else
                        {
                            isGoodBoy = true;

                        }

                    }
                    else if (i % 3 == 0)
                    {
                        if (isFirstSymbol)
                        {
                            isDog = true;
                            isDogFirst = true;
                            isFirstSymbol = false;
                        }
                        else
                        {
                            isDog = true;
                        }
                    }
                    else if (i % 5 == 0)
                    {
                        if (isFirstSymbol)
                        {
                            isCat = true;
                            isCatFirst = true;
                            isFirstSymbol = false;
                        }
                        else
                        {
                            isCat = true;
                        }
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

                    if (!isGoodBoy && !isDog && !isCat && !isMuzz && !isGuzz)
                    {
                        Console.Write("{0} ", " " + i + ",");
                    }
                    else
                    {
                        DisplayQueryResult(isGoodBoy, isDog, isCat, isMuzz, isGuzz, isGoodBoyFirst, isDogFirst, isCatFirst, isMuzzFirst, isGuzzFirst);
                    }

                    isFirstSymbol = true;
                    isGoodBoy = false; // кртаное 3 и 5
                    isDog = false; // кратное 3
                    isCat = false; // кратное 5
                    isMuzz = false; // кратное 4
                    isGuzz = false; // кратное 7
                    isGoodBoyFirst = false;
                    isDogFirst = false; // является ли число первым ( для отображения "-" )
                    isCatFirst = false;
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
                while (true)
                {
                    ConsoleRead();
                    FirstCalculate(count);
                    Console.WriteLine();
                }
            }

            RunProgram();

        }
    }  
}
    