using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            string donorName = "";
            string donorAddress = "";
            string donorEmail = "";
            string fiscalYear = "";

            Console.WriteLine("Name of Donor");
            donorName = Console.ReadLine();

            Console.WriteLine("Address of Donor");
            donorAddress = Console.ReadLine();

            Console.WriteLine("Email of Donor");
            donorEmail = Console.ReadLine();

            Console.WriteLine("Fiscal Year");
            fiscalYear = Console.ReadLine();

            Console.WriteLine("Number of quarters: ");
            double quarters = double.Parse(Console.ReadLine())*.25;

            Console.WriteLine("Number of ones: ");
            int ones = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of fives: ");
            int fives = int.Parse(Console.ReadLine())*5;

            Console.WriteLine("Number of tens: ");
            int tens = int.Parse(Console.ReadLine())*10;

            Console.WriteLine("Number of twenties: ");
            int twenties = int.Parse(Console.ReadLine()) * 20;

            Console.WriteLine("Number of fifties: ");
            int fifties = int.Parse(Console.ReadLine()) * 50;

            Console.WriteLine("Number of hundreds: ");
            int hundreds = int.Parse(Console.ReadLine()) * 100;

            Console.WriteLine("Name of Donor: "+donorName);
            Console.WriteLine("Address of Donor: "+donorAddress);
            Console.WriteLine("Email of Donor: "+donorEmail);
            Console.WriteLine("Fiscal Year: "+fiscalYear);
            double donationAmount = quarters + ones + fives + tens + twenties + fifties + hundreds;
            Console.WriteLine("Donataion Amount: "+donationAmount);

        }
    }
}
