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
            char korndiolle = char.Parse(Console.ReadLine());
            Console.Write("ndour: ");
            string ndour = Console.ReadLine();

            string fullName = firstName + " " + korndiolle + ". " + ndour;

            int heightinFeet = 6-03;
            double heightInFeet = 1.25;
            double heightInches = 0;

            double totalHeightInches = (heightinFeet * 12) + heightInches;
            double heightInCM = totalHeightInches * 2.54;
            Console.WriteLine(fullName);
            System.Threading.Thread.Sleep(3000);
            bool isCitizen = true;
            int age = 25;
            bool canVote = isCitizen && age >= 21;

            Console.WriteLine(sombelendour);
            System.Threading.Thread.Sleep(3000);
        }
    }
}
