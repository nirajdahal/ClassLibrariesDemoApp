using System;
using Library.Core;
//using Library.Framework;
//using Library.Standard;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel firstPerson = new PersonModel { FirstName = "Niraj", LastName="Dahal", Prefix = "Mr."};
            //PersonModel secondPerson = new PersonModel { FirstName = "Nirajala", LastName = "Dahal", Prefix = "Mrs." };
            Console.WriteLine(Generators.WelcomeMessage(firstPerson.Prefix, firstPerson.LastName)); 
            
        }
    }
}
