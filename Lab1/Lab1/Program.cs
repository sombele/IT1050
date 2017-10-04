using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please Enter Your Middle Initial: ");
            char middlename = char.Parse(Console.ReadLine());
            Console.Write("please enter your last name: ");
            string lastname = Console.ReadLine();
            string fullName = firstName + " " + middlename + ". " + lastname;

            Console.Write("How tall are you in feet?");
            int heightinFeet = int.Parse(Console.ReadLine());

            double heightInches = 0;
            double totalHeightInches = (heightinFeet * 12) + heightInches;
            double heightInCM = totalHeightInches * 2.54;
            
            bool isCitizen = true;
            int age = 25;
            bool canVote = isCitizen && age >= 21;

            Console.WriteLine(fullName);
            System.Threading.Thread.Sleep(3000);
        }
    }
}
