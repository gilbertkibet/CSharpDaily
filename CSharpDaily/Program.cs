using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
            //int i = 10, j = 20;

            //if (i < j)

            //{
            //    //Console.WriteLine("this is true");
            //}

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

            //switch (i)
            //{
            //    case 0:
            //        Console.WriteLine("IS IS ZERO");
            //        break;
            //    case 10:
            //        Console.WriteLine("The value of i is 10");
            //        break;
            //    default:
            //        Console.WriteLine("This is unknown values");
            //        break;
            //}

            //STRING BUILDER IN C#

            string message = "Hello World";

            StringBuilder stringBuilder = new StringBuilder(message);

            //String builder is not a string so you can retrieve a string using ToString();

            var stringMessage = stringBuilder.ToString();

            Console.WriteLine(stringMessage);


            //to append a string to the end use AppendMethod


            //STRING BUILDER METHODS

            StringBuilder myname = new StringBuilder("Gilbert");

            myname.Append("kibet");

            Console.WriteLine(myname.ToString());

            // insert to insert a stringto

            myname.Insert(5, "korir");

            Console.WriteLine(myname.ToString());


            //remove is used to remove
            myname.Remove(0, 2);
            Console.WriteLine(myname.ToString());


            //you can replace string 

            myname.Replace("korir", "simon");
            Console.WriteLine(myname.ToString());



            ///Accessing enum values

            Console.WriteLine(WeekDays.Friday);

            //to get intergral type we used explicit typecasting

            int friday = (int)WeekDays.Monday;

            Console.WriteLine(friday);

            var WK = (WeekDays)6;

            Console.WriteLine(WK);

            //WORKING WITH DATETIME IN C#  CREATE AN INSTANCE OF DATETIME STRUCT
            DateTime dt = new DateTime();

            Console.WriteLine(dt);

            //assing year month and date

            DateTime today = new DateTime(2023, 03, 05);
            Console.WriteLine(today);



            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
            Console.WriteLine(dt3);
            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            Console.WriteLine(dt4);

            //CONVERTING STRING TO DATETIME VALID DATETIME IN STRING  CAN BE CONVERTED TO DATETIME USING PARSE()PARSEEXACT(),TRYPARSE(),TRYPARSEXACT()

            var str = "5/12/2020";

            DateTime DTT;

            var isValidDate = DateTime.TryParse(str, out DTT);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");
        }
    }

  public enum WeekDays
    {

        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    //Accessing enums
    

}
