using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharpDaily
{
    class Program
    {
        static void Main(string[] args)
        {

            //WORKING WITH NUMBERS

            //INTERGER AND FLOATING  POINT NUMBERS
            //INT ARE WHOLE NUMBERS CAN BE POSITIVE OR NEGATIVE
            //FLOATING POINT NUMBERS WITH ONE OR MORE DECIMAL

            

            //Console.WriteLine("Hello World!");
            //DEFAULT VALUES IN C#

            // int x = default;
            int i = 10, j = 20;

            if (i < j)

            {
                //Console.WriteLine("this is true");
            }

            //YOU CAN CALL A METHOD THAT RETURN A BOOLEAN INSIDE AN IF STATEMENT



            //static bool IsGreater(int x, int y)
            //{
            //    return x > y;
            //}

            //if(IsGreater(10, 20))
            //{
            //    Console.WriteLine("THIS IS TRUE");
            //}
            //else
            //{
            //    Console.WriteLine("THIS IS FALSE");
            //}
            //if (i == j)
            //{

            //    Console.WriteLine("i is equal to j");

            //}

            //else if (
            //    i > j)
            //{
            //    Console.WriteLine("I IS GREATER THAN J");
            //}

            //else
            //{
            //    Console.WriteLine("I IS LESS THAN J");
            //}

            //terniary operator
            //condition?statetement1:statement2;  ?: ?:  start with boolena condition if true execute first statement
            //otherwise second 

            //you declare a variable

            //var outPut = i < j ? "i is less than j" : "i is greater than j";

            //Console.WriteLine(outPut);
            
            switch (i)
            {
                case 0:
                    Console.WriteLine("IS IS ZERO");
                    break;
                case 10:
                    Console.WriteLine("The value of i is 10");
                    break;
                default:
                    Console.WriteLine("This is unknown values");
                    break;
            }

        }
    }
}
