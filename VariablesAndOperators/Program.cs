using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing new name and birthMonth variables
            /*comment
            string name = "Mike";
            Console.WriteLine(name);
    

            int birthMonth = 5;
            Console.WriteLine(birthMonth);
            
            int age = 65;
            string why = "because I said so";
            char firstInitial = 'L';

            //floating point types
            float floatNumber = 2.164403304897294849383961032f;
            Console.WriteLine(floatNumber);

            double doubleNumber = 2.164403304897294849383961032d;
            Console.WriteLine(doubleNumber);

            decimal decimalNumber = 2.164403304897294849383961032m;
            Console.WriteLine(decimalNumber);
          
            int jessicaAge = 23;
            int samAge = 47;
            Console.WriteLine(jessicaAge < samAge);
            
   
            Console.WriteLine("Reservation?");
            string reserveName = Console.ReadLine();
               
            Console.WriteLine("How many people are in your party?");
            int numberOfPeople = int.Parse(Console.ReadLine());
                       
        
            double amountEach = 13.53d;
             
            double totalBill = (numberOfPeople * amountEach);
            Console.WriteLine(totalBill);

            Console.WriteLine("Reservation: " + reserveName);
            Console.WriteLine("Total Due: $" + totalBill);

           
            int moneyAvailable = 40;
            int packageCost = 8;
            int packagesAvailable = (moneyAvailable / packageCost);

            Console.WriteLine(packagesAvailable); 

            

            Console.WriteLine("Name of Donor");
            string donorName = Console.ReadLine();

            Console.WriteLine("Address of Donor");
            string donorAddress = Console.ReadLine();

            Console.WriteLine("Email of Donor");
            string donorEmail = Console.ReadLine();

            Console.WriteLine("Fiscal Year");
            string year = Console.ReadLine();

            Console.WriteLine("Donated Ones");
            int ones = int.Parse(Console.ReadLine()) * 1;

            Console.WriteLine("Donated Fives");
            int fives = int.Parse(Console.ReadLine()) * 5;

            Console.WriteLine("Donated Tens");
            int tens = int.Parse(Console.ReadLine()) * 10;

            Console.WriteLine("Donated Twenties");
            int twenties = int.Parse(Console.ReadLine()) * 20;

            Console.WriteLine("Donated Fifties");
            int fifties = int.Parse(Console.ReadLine()) * 50;

            Console.WriteLine("Donated Hundreds");
            int hundreds = int.Parse(Console.ReadLine()) * 100;

            Console.WriteLine("Donated Quarters");
            double quarters = double.Parse(Console.ReadLine()) * .25d;

            double donationAmount = (ones + fives + tens + twenties + fifties + hundreds + quarters);
            Console.WriteLine(donationAmount);
            */

            Console.WriteLine("How many A courses?");
            double gradeA = double.Parse(Console.ReadLine()) * 4;
                           
            Console.WriteLine("How many B courses?");
            double gradeB = double.Parse(Console.ReadLine()) *3;

            Console.WriteLine("How many C courses?");
            double gradeC = double.Parse(Console.ReadLine()) * 2;

            Console.WriteLine("How many D courses?");
            double gradeD = double.Parse(Console.ReadLine()) * 1;

            double sum = (gradeA + gradeB + gradeC + gradeD);
           
            Console.WriteLine("How many total courses?");
            double totalCourses = double.Parse(Console.ReadLine());

            double gpa = (sum / totalCourses);
            Console.WriteLine(gpa);
           
            

        }
    }
}
