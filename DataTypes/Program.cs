using System;

namespace DataTypes
{

    class Program
    {
        static void Main(string[] args) {


            //int x = default;
            //Console.WriteLine(x);
            char[] chars = { 'h', 'e', 'l', 'l', 'o' };

            string  stri1=new string (chars); 
            //Console.WriteLine(stri1);
            foreach(char c in stri1)
            {
                //Console.WriteLine (c);
            }

            string message = "This is \"hello\" world";
            Console.WriteLine (message);


        }
    }
}
