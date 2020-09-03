using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good morning!");

            Console.WriteLine("What is your name?");

            string Name;
            Name = Console.ReadLine();
            
            Console.WriteLine("Hello, " + Name);

            Console.WriteLine("In what year were you born in?");
            
            string UserInput;
            
            UserInput = Console.ReadLine();
            
            int YearOfBirth;
            
            YearOfBirth = Int32.Parse(UserInput);
            
            int Age = 2020 - YearOfBirth;
            
            Console.WriteLine("You are " + Age + "old.");




        
                

           

            


        }

    }
}
