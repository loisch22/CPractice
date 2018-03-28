using System;
using System.Collections.Generic; 

// Class practice

class Contact 
{
  public string Name;
  public string Phone;
  public string Address;
}

class Program 
{
  public static void Main()
  {
    // Action
    Contact boyfriend = new Contact();
    boyfriend.Name = "Andrew";
    boyfriend.Phone = "2063040901";
    boyfriend.Address = "Bellevue"; 

    Contact myself = new Contact();
    myself.Name = "Lois";
    myself.Phone = "2532494375";
    myself.Address = "Federal Way";

    List<Contact> addressBook = new List<Contact> { boyfriend, myself };
    foreach (Contact person in addressBook)
    {
      Console.WriteLine("Name: " + person.Name);
      Console.WriteLine("Phone: " + person.Phone);
      Console.WriteLine("Address: " + person.Address);
    } 

  }
}