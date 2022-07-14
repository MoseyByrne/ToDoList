using System;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      string response = "";
      while (response.ToUpper() != "END")
      {
        Console.WriteLine("Would you like to add an item to your list, view your list or end? (Add/View/End)");
          response = Console.ReadLine();

        if (response.ToUpper() == "ADD")
        {
          addItem();
        } 
        else if (response.ToUpper() == "VIEW")
        {
          viewItems();
        }
      }
    }

    public static void addItem()
    {
      Console.WriteLine("What would you like to add?");
      string newItemResponse = Console.ReadLine();
      Item newItem = new Item(newItemResponse);
      Console.WriteLine(newItemResponse + " has been added to your list.");
    }

    public static void viewItems()
    {
      List<Item> viewList = Item.GetAll();

      foreach(Item thisItem in viewList)
      {
        Console.WriteLine("Here what you have left to do: " + thisItem.Description);
      }
    }
  }
}

