using System;
using System.Collections.Generic; 

// Dictionary practice

class Phonebook 
{
  Dictionary<string, string> phonebook = new Dictionary<string, string>();

  static void Main()
  {
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("Would you like to add a person to your phonebook?");
    string answer = Console.ReadLine();
    IsInputYes(answer);
  }

  static void IsInputYes(string answer) // better name
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

  static void isYes(string answer) // better name
  {
    
  } 

  static void AddContact()
  {
    Console.WriteLine("Would you like to add a new contact?");

  }

  static void LookUpContact()
  {
    Console.WriteLine("Would you like to look up a contact?");
    // if isYes is true then 
  }
}

// Create functions if you are repeating code