using System;
using System.Collections.Generic; 

// Foreach practice

class Phonebook 
{
  static void Main()
  {
    string[] myGroceryList = {"apples", "pears", "salad"};
    int[] groceryListPrices = {3,4,6};

    Console.WriteLine("My grocery list:");
    foreach (string item in myGroceryList) 
    {
      Console.WriteLine(item);
    }

    Console.WriteLine("Total:");
    int total = 0;
    foreach (int price in groceryListPrices)
    {
      total = total + price;
    }
    Console.WriteLine(total);
  }
}