using System;
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] StringArray = { "1", "2", "3" };

            displayElement(intArray);
            displayElement(doubleArray);
            displayElement(StringArray);
        }
        public static void displayElement<T>(T[] array)
        {
            foreach (T item in array )
            {
                Console.Write(item + " ");
            }
        }

    }
}
