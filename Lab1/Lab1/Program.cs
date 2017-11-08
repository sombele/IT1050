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

            Console.WriteLine(" please enter your age");
            int age = int.Parse(System.Console.ReadLine());
            Console.WriteLine("please answer if you are  citizen");
            bool iscitizen = bool.Parse(System.Console.ReadLine());
            Console.WriteLine("Rule for your voter eligibility?");
            bool CanVote = bool.Parse(System.Console.ReadLine());
            
           
            

            Console.WriteLine("Please enter your fullName");
            String FullName = firstName + " " + middlename + " " + lastname;
            Console.WriteLine(" Please enter your totalHeightCM");
            double heightCM = totalHeightInches * 2.54;
            Console.Write("Eligibility of you canVote?");
            bool CanVote = iscitizen && age >= 18;
            System.Threading.Thread.Sleep(3000);
        }
    }
}
