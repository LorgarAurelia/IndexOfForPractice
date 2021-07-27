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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
