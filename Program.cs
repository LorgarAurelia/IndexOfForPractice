using System;

namespace IndexOfForPractice

    /*
     *      Написать метод для поиска индекса элемента массива (тип элементов массива int),
     *      метод должен вернуть индекс ПЕРВОГО найденного элемента (если он будет найден).
     */
{
    class Program
    {
        static int IndexOf(int[] array, string valueForSearch) 
        {
            int parsedValue;

            try
            {
                parsedValue = int.Parse(valueForSearch);
            }
            catch (Exception)
            {
                return -1;
            }

            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] == parsedValue)
                {
                    return i;
                }
            }

            return -1;
        }

        static int[] GetRandomArray(string length, string minValue, string maxValue)
        {
            int[] randomArray;
            uint parsedLength;
            int parsedMinValue = 0, parsedMaxValue = 0;

            Random random = new Random();

            try
            {
                parsedLength = uint.Parse(length);
            }
            catch (Exception)
            {
                Console.WriteLine("Введены некорректные данные для параметры длины массива");
                parsedLength = 0;
            }

            try
            {
                parsedMinValue = int.Parse(minValue);
                parsedMaxValue = int.Parse(maxValue);
            }
            catch (Exception)
            {
                Console.WriteLine("Введены некорректные данные для верхнего или нижнего предела значений в элементах массива");
                parsedLength = 0; 
            }

            randomArray = new int[parsedLength];

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(parsedMinValue, parsedMaxValue);
            }

            return randomArray;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
