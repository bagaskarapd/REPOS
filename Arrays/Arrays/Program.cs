using System;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] food = new string[3];
            food[0] = "WARTEG";
            food[1] = "PADANG";
            food[2] = "PSP";

            foreach(String item in food)
            {
                Console.Write(item + " ");
            }
        }
    }
}