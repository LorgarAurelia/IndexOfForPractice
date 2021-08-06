using System;

namespace IndexOfForPractice

    /*
     *      Написать метод для поиска индекса элемента массива (тип элементов массива int),
     *      метод должен вернуть индекс ПЕРВОГО найденного элемента (если он будет найден).
     */
{
    class Program
    {
        /// <summary>
        /// Метод для поиска индекса элемента масиива, метод возвращает индекс первого найденного жэлемента.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="valueForSearch"></param>
        /// <returns></returns>
        static int IndexOf(int[] array, string valueForSearch) 
        {
            int parsedValue;
            bool succesParse = true;

            if (succesParse != int.TryParse(valueForSearch,out parsedValue))
            {
                Console.WriteLine("Введены некорректные для данные для поиска значения.");
                return -1;
            }


            for (int currentValue = 0; currentValue < array.Length; currentValue++) 
            {
                if (array[currentValue] == parsedValue)
                {
                    return currentValue;
                }
            }

            return -1;
        }

        /// <summary>
        /// Метод создаёт случайный массив int с заданными параметрами.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        static int[] GetRandomArray(string length, string minValue, string maxValue)
        {
            int[] randomArray;
            uint parsedLength;
            int parsedMinValue, parsedMaxValue;
            bool succesInParse = true;

            Random random = new Random();

            if (succesInParse != uint.TryParse(length,out parsedLength))
            {
                Console.WriteLine("Введены некорректные данные для параметры длины массива");
                parsedLength = 0;
            }

            if (succesInParse != int.TryParse(minValue,out parsedMinValue))
            {
                Console.WriteLine("Введены некорректные данные для верхнего предела значений в элементах массива");
                parsedLength = 0;
            }

            if (succesInParse != int.TryParse(maxValue,out parsedMaxValue))
            {
                Console.WriteLine("Введены некорректные данные для нижнего предела значений в элементах массива");
                parsedLength = 0;
            }

            randomArray = new int[parsedLength];

            for (int currentValue = 0; currentValue < randomArray.Length; currentValue++)
            {
                randomArray[currentValue] = random.Next(parsedMinValue, parsedMaxValue);
            }

            return randomArray;
        }
        static void Main(string[] args)
        {
            string length, minTestValue, maxTestValue, valueForSearching;
            int result;

            Console.Write("Введите значение длины массива: \t");
            length = Console.ReadLine();

            Console.Write("Введите минимальное значение элемента массива: \t");
            minTestValue = Console.ReadLine();

            Console.Write("Введите максимальное значение элемента массива: \t");
            maxTestValue = Console.ReadLine();

            Console.Write("Введите число которое вы хотели бы найти в массиве: \t");
            valueForSearching = Console.ReadLine();

            result = IndexOf(GetRandomArray(length,minTestValue,maxTestValue),valueForSearching);

            if (result == -1)
            {
                Console.WriteLine("Искомое значение в массиве не найдено!");
            }
            else 
            {
                Console.WriteLine("Искомое значение храниться в массиве под индексом: \t" + result);
            }

            Console.ReadLine();
        }
    }
}
