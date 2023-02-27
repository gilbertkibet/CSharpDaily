using System;

namespace DataTypes
{

    class Program
    {
        static void Main(string[] args) {

            //DAY ONE DATATYEPES IN C#
            string stringVar = "This is a string ";
            int intVar = 10;
            float floatVar = 10.2f;  // we must add suffix f to float otherwise it will be a decimal
            char charVar='A';//array of character can be used to create strings in c#
            bool boolVar = false;
            DateTime dateTimeVar = DateTime.Now;


            //DEFAULT VALUES IN C#
            int varint = default; //zero
            bool isMale = default; //zero
            decimal dec=default;//zero
            float f=default; //zero

            Console.WriteLine(isMale);

            //REFERENCES TYPES BY DEFAULT ARE STRING AND OBJECT
            String si = "Hello";
            string s2 = "World";

            //when a variable of value type is converted to object it is called boxing
            //when a variable of type object is converted to value type it is called unboxing

            //
            string A = "Geeks";
            A += "for";
            A += "Geeks";
            //obj
            object obj = 20;
            Console.WriteLine(obj.GetType());

            //SHOULD LEARN ABOUT pointer datatypes(&AND *)
            int n = 10;
           // int* p = &n;
        }
    }
}
