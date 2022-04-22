using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;


namespace Рекурсия
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {34, 35, 26, 546, 254};
            Array(myArray);
            
            Console.WriteLine("\nСумма чисел массива: " + Sum(myArray));

            Console.Write("Введите любое число, что бы сложить цифры этого числа: ");
            Console.WriteLine("Сумма цифр числа: " + SumOfDigits(int.Parse(Console.ReadLine())));

            Item item = InitItem();

            Console.ReadKey();
        }

        static void Array(int[] myArray, int i = 0)
        {
            if(i < myArray.Length)
            {
                Console.Write(myArray[i] + "\t");
                Array(myArray, i + 1);
            }
        }

        static int Sum(int[] myArray, int i = 0)
        {
            if(i >= myArray.Length)
            {
                return 0;
            }

            return myArray[i] + Sum(myArray, i + 1);
        }

        static int SumOfDigits(int Value)
        {            
            if (Value < 10)
            {
                return Value;
            }

            return Value % 10 + SumOfDigits(Value / 10);
        }

        class Item
        {
            public int Value { get; set; }

            public Item Child { get; set; } 
        }

        static Item InitItem()
        {
            return new Item()
            {
                Value = 7,
                Child = new Item()
                {
                    Value = 5,
                    Child = new Item()
                    {
                        Value = 6
                    }
                }
            };
        }
    }
}
