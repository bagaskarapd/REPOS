using System;
using System.Collections.Generic;
namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> food = new List<String>();
            food.Add("rendang");//to add item to a list
            food.Add("ayam goreng");
            food.Add("ayam gulai");
            food.Add("ikan pindang");

            //food.Remove("rendang");//to remove specific item in a list
            //food.Insert(0, "kikil");//to insert a item in list by an index
            //Console.WriteLine(food.Count);//to count how many item in a list
            //Console.WriteLine(food.IndexOf("rendang"));//to search where the item index is in a list
            //Console.WriteLine(food.Contains("rendang"));//will answer boolean if it true or false something that you search are in the list
            //food.Sort();//to sort item in a list
            //food.Clear();//obviously for delete all the item in a list
            //String[] list = food.ToArray();//to change from a list to an array
            
            foreach (String item in food)
            {
                Console.Write(item + " ");
            }
        }
    }
}