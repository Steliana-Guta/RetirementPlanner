using System;

namespace RetirementPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputAge;
            //accepts sring for inputAge,all the rest has to be decimals 
            decimal age;
            decimal oldAge = 65;
            decimal difference;

            Console.WriteLine("Please enter your age in whole years");
            inputAge = Console.ReadLine();

            age = Convert.ToDecimal(inputAge);
            //i tried to use decimal.parse but itdidnt work,figured it mught work if i converted to decimal,but had to put eveything as decimals first
         difference = oldAge - age;
            Console.WriteLine("In {0:0.00} years you will be 65 years old", difference);
            Console.ReadLine();

        }
    }
}
