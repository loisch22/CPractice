using System;
using System.Collections.Generic; 

// Dictionary practice

class Phonebook 
{
  Dictionary<string, string> phonebook = new Dictionary<string, string>();

  public static void Main()
  {
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("Would you like to add a person to your phonebook?");
    string answer = Console.ReadLine();
    AddContactYes(answer);
  }

  public static void AddContactYes(string answer) // better name
  {
    string answerLowerCase = answer.ToLower();
    if ("y".Equals(answerLowerCase)) 
    {
      AddContact();
    }
    else 
    {
     LookUpContact();
    }
  }

  public static void AddContact()
  {
    Console.WriteLine("ADD CONTACT");
    Console.WriteLine("Enter contact name:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter contact phone number:");
    string number = Console.ReadLine();
    ContactExists(name, number);
  }

  public static void ContactExists(string name, string number)
  {
    if (phonebook.ContainsKey(name))
    {
      Console.WriteLine("This contact already exists and their number is: " + phonebook[name]);
    }
    else
    {
      phonebook.Add(name, number);
      Console.WriteLine("Your new contact has been added.");
    }
  }



  public static void LookUpContact()
  {
    Console.WriteLine("Would you like to look up a contact?");
    // if isYes is true then 
  }
}

// Create functions if you are repeating code