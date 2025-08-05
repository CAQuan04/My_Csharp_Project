using System;
// This file is part of the HelloWorld project.
namespace HelloWorld
{
    /*class Student
    {
        public string StudentName { get; set; }

    }*/
    internal class Program
    {
        /*static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }

        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Nguyen Van A";
        }*/

        /*// Constant as a fields, kh the thay đổi giá trị của nó
        const double PI = 3.14159;
        const int NumberOfWeeksInYear = 52;
        const int NumberOfMonthsInYear = 12;
        const string MyBirthday = "01/01/2000";*/
        static void Main(string[] args)
        {
            // Ctrl + K + D to format the code

            /*//Lesson 5 - Data Types and Variables
            int iAmANumber = 5;
            long iAmALongNumber = 1234567890L;
            short iAmAShortNumber = 12345;
            byte iAmAByte = 255; // 0 to 255

            float pi = 3.14f;
            string myName = "Alice";
            char at = '@';
            bool isGPSEnabled = true;

            float myFloat = 1.212312f;
            double myDouble = 1.212312;
            decimal myDecimal = 1.212312M;

            Console.WriteLine("Hello, World!");*/

            /*//lesson 6 - Practice number patterns
            int number1 = 10;
            int number2 = 20;
            int number3, number4, number5, number6, number7, number8, number9, number10;
            int sum = number1 + number2;

            Console.WriteLine("Sum of " + number1 + " and " + number2 + ": " + sum);

            float floatNumber1 = 3.14f;
            float floatNumber2 = 2.71f;
            float sumFloat = floatNumber1 + floatNumber2;
            float divFloat = floatNumber1 / floatNumber2;
            float multiFloat = floatNumber1 * floatNumber2;

            Console.WriteLine("Sum of " + floatNumber1 + " and " + floatNumber2 + ": " + sumFloat);
            Console.WriteLine("Division of " + floatNumber1 + " and " + floatNumber2 + ": " + divFloat);
            Console.WriteLine("Multiple of " + floatNumber1 + " and " + floatNumber2 + ": " + multiFloat);
            Console.Read();*/

            /*//lesson 7 - String data type
            String myName = "Chu Anh Quan";// Declare a string variable and assign the value ""
            myName = myName.ToUpper(); // Convert to uppercase
            Console.WriteLine("My name is " + myName);
            Console.Read();*/

            /*//lesson 9 - Value Type & Reference Type
            int i = 100;
            Console.WriteLine(i);
            ChangeValue(i);// Call the method to change the value of i
            Console.WriteLine(i);


            Student std1 = new Student();
            std1.StudentName = "Nguyen Van B";
            ChangeReferenceType(std1); // Call the method to change the reference type
            Console.WriteLine(std1.StudentName);
            Console.Read();*/

            /*//Lesson 11 - Type Casting
            //Implicit Casting (chuyển đổi ngầm định tự động)
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            //Explicit Casting(chuyển đổi tường minh bằng tay)
            int five = 5;
            var doubleFive = (double)five;

            char a = 'a';
            var valueA = (int)a;

            float myFloat = 4.56F;

            //TryParse example
            decimal myMoney = (decimal)myFloat;
            string value = "5.0"; 
            decimal result;
            bool isValid = decimal.TryParse(value, out result);*/

            /*//lesson 12 - Constant as a fields
            double radus = 10;
            Console.WriteLine("My birthday is " + MyBirthday);
            Console.WriteLine(radus * radus * PI);
            Console.ReadLine();*/

        }
    }
}
