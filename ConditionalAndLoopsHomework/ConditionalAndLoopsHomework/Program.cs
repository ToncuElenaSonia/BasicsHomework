using System;
using System.Linq;
using System.Collections.Generic;

namespace ConditionalAndLoopsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfThreeNumbers();
            MaxOfFiveNumbers();
            AreaAndPerimeterOfCircle();
            PrintNumbersDivisibleWith5();
            MaxFromTwoNumbers();
            FiveNumbers();
            PrintNumbers();
            DivisibleNumbers();
            LargestSmallestFiveNumbers();
            TrianglePattern();
            DecimalToBinary();
            RandomNumbers();
            FizzBuzz();
            Company();
        }
        //1.Write a program that reads from the console three numbers of type int and prints their sum.

        static void SumOfThreeNumbers()
        {
            Console.WriteLine("Please introduce the first integer number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please introduce the second integer number: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please introduce the third integer number: ");
            int number3 = int.Parse(Console.ReadLine());
            int sum = number1 + number2 + number3;
            Console.WriteLine("Sum of these three numbers is {0}", sum);
        }
        //2.	Write a program that reads five numbers from the console and prints the greatest of them.
        static int[] GetArrayFromUser()
        {
            //get lenght
            Console.WriteLine("Add the lenght of the array:");
            int lenght = int.Parse(Console.ReadLine());
            //initialize
            int[] MyArray = new int[lenght];
            //Add elements to array
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine($"Add element {i}");
                MyArray[i] = int.Parse(Console.ReadLine());
            }

            return MyArray;
        }
        static void MaxOfFiveNumbers()
        {
            var myArray = GetArrayFromUser();
            var max = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }
            Console.WriteLine($"The greatest number is:{max}");
        }
        //3.	Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
        //P=2*pi*r
        //A=pi*r^2
        static void AreaAndPerimeterOfCircle()
        {
            Console.WriteLine("Introduce the radius:");
            float radius = float.Parse(Console.ReadLine());
            const float numberPi = 3.14F;
            float perimeter = 2 * numberPi * radius;
            Console.WriteLine($"The perimeter of circle is:{perimeter}");
            float area = numberPi * radius * radius;
            Console.WriteLine($"The area of circle is:{area}");
        }
        //4.	Write a program that reads from the console two integer numbers(int) and prints how many
        //numbers between them exist that are divisible with 5. such that the remainder of their division by 5 is 0.
        static void PrintNumbersDivisibleWith5()
        {
            Console.WriteLine("Please enter the first integer number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second integer number:");
            int number2 = int.Parse(Console.ReadLine());
            int number3 = number1;
            int counter = 0;
            while (number3 < number2)
            {
                if (number3 % 5 == 0)
                {
                    counter++;
                    Console.WriteLine($"Numbers divisible with 5 are:{number3}");
                }
                number3++;
            }
            Console.WriteLine($"Between two integer numbers exist {counter} numbers that are divisible with 5");
        }
        //5.	Write a program that reads two numbers from the console and prints the greater of them. 
        //Solve the problem without using conditional statements and with conditional statements.
        static void MaxFromTwoNumbers()
        {
            Console.WriteLine("Please enter the first number:");
            decimal number1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            decimal number2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"The greater of them is:{Math.Max(number1, number2)}");
        }
        //6.	Write a program that reads five integer numbers and prints their sum.
        //If an invalid number is entered the program should prompt the user to enter another number(only once).
        static void FiveNumbers()
        {
            int a, b, c, d, e;
            int sum = 0;
            bool invalidNumber = false;

            Console.Write("Enter the first number:");
            invalidNumber = Int32.TryParse(Console.ReadLine(), out a);
            if (invalidNumber == false)
            {
                Console.WriteLine("Number not integer, try again");
                //Console.ReadLine();
                invalidNumber = Int32.TryParse(Console.ReadLine(), out a);
                if (invalidNumber == true)
                {
                    sum = a;
                }
            }
            Console.Write("Enter the second number:");
            invalidNumber = Int32.TryParse(Console.ReadLine(), out b);
            if (invalidNumber == false)
            {
                Console.WriteLine("Number not integer, try again");
                //Console.ReadLine();
                invalidNumber = Int32.TryParse(Console.ReadLine(), out b);
                if (invalidNumber == true)
                {
                    sum = a + b;
                }
            }
            Console.Write("Enter the third number:");
            invalidNumber = Int32.TryParse(Console.ReadLine(), out c);
            if (invalidNumber == false)
            {
                Console.WriteLine("Number not integer, try again");
                //Console.ReadLine();
                invalidNumber = Int32.TryParse(Console.ReadLine(), out c);
                if (invalidNumber == true)
                {
                    sum = a + b + c;
                }
            }
            Console.Write("Enter the fourth number:");
            invalidNumber = Int32.TryParse(Console.ReadLine(), out d);
            if (invalidNumber == false)
            {
                Console.WriteLine("Number not integer, try again");
                //Console.ReadLine();
                invalidNumber = Int32.TryParse(Console.ReadLine(), out d);
                if (invalidNumber == true)
                {
                    sum = a + b + c + d;
                }
            }
            Console.Write("Enter the fifth number:");
            invalidNumber = Int32.TryParse(Console.ReadLine(), out e);
            if (invalidNumber==false)
            {
                Console.WriteLine("Number not integer, try again");
                //Console.ReadLine();
                invalidNumber = Int32.TryParse(Console.ReadLine(), out e);
                if (invalidNumber == true)
                {
                    sum =a + b + c + d + e;
                }
            }
            if (invalidNumber)
            {
                sum = a + b + c + d + e;
                Console.WriteLine($"Sum of the five numbers is:{sum}");
            }
            else
            {
                Console.WriteLine("Not all numbers are integer");
            }
           
        }
        //7.	Write a program that prints on the console the numbers from 1 to N. 
        //The number N should be read from the standard input.
        static void PrintNumbers()
        {
            Console.WriteLine("Please enter the number n:");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"The numbers from 1 to n are:{i}");
            }
        }
        // 8.	Write a program that prints on the console the numbers from 1 to N, 
        //which are not divisible by 3 and 7 simultaneously.The number N should be read from the standard input.
        static void DivisibleNumbers()
        {
            Console.WriteLine("Please enter the number n:");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            for (int i = 1; i <= n; i++)
            {
                if((i % 3 != 0) && (i % 7 !=0)){
                Console.WriteLine($"The numbers from 1 to n wich are not divisible by 3 and 7 simultaneously are:{i}");
                }
               
            }
        }
      
        // 9.	Write a program that reads from the console a series of 5 integers and 
        //prints the smallest and largest of them.
        static void LargestSmallestFiveNumbers()
        {
            Console.WriteLine("Please enter the 5 integers:");
            int[] myArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Add element {i}:");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            int lowestNumber = myArray[0];
            int highestNumber = myArray[0];

            for (int i = 0; i < 5; i++)
            {
                if (lowestNumber > myArray[i])
                {
                    lowestNumber = myArray[i];
                }
                if (highestNumber < myArray[i])
                {
                    highestNumber = myArray[i];
                }
            }
            Console.WriteLine("Lowest number={0}, Highest number={1}", lowestNumber, highestNumber);
        }
        //10.	Write program that outputs a triangle made of stars with variable size, depending 
        //on an input parameter. Look at the examples to get an idea. The input comes as a 
        //string number, which needs to be parsed to a number. The output is a series of 
        //lines printed on the console, forming a triangle of variable size.
        public static void TrianglePattern()
        {
            int i, j;
            int count = 1;
            Console.Write("Enter number of rows\n");
            int number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (j = 1; j <= number - 1; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - j) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            //Console.ReadLine();
        }
        //11* . Write a program that converts a given number from decimal to binary notation(numeral system).
        static void DecimalToBinary()
        {
            Console.Write("Introduce the decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber=decimalNumber/2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary number is:  {0}", result);
        }
        //12*. Write a program that by a given integer N prints the numbers from 1 to N in random order
        public static void RandomNumbers()
        {
            Console.WriteLine("Give the biggest number from the list");
            var number = Convert.ToInt32(Console.ReadLine());
            //var listanumere = new List<int>();
            int[] myArray = new int[number];

            for (int i = 0; i <= number - 1; i++)
            {
                myArray[i] = i + 1;
            }
            Console.WriteLine("The ordered list is: ");
            for (int i = 0; i <= number - 1; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Random r = new Random();
            for (int n = myArray.Length - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                int value = myArray[n];
                myArray[n] = myArray[k];
                myArray[k] = value;

            }
            Console.WriteLine();
            Console.WriteLine("The list with random numbers is: ");
            for (int i = 0; i <= number - 1; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.ReadLine();
        }
        //13*. A program which iterates the integers from 1 to 50 For multiples of three print 
        //"Fizz" instead of the number and for the multiples of five print "Buzz". For numbers 
        //which are multiples of both three and five print "FizzBuzz".
        static void FizzBuzz()
        {
            Console.WriteLine("FizzBuzz program is:");
            Console.ReadLine();
            int n = 50;
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
            //14 A given company has name, address, phone number, fax number, web site and 
            //manager. The manager has name, surname and phone number. Write a program that 
            //reads information about the company and its manager and then prints it on the console.
        static void Company()
        {
            //Information about company:
            Console.WriteLine("Information about company: ");

            Console.Write("Name: ");
            string companyName = Console.ReadLine();

            Console.Write("Address: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Phone number: ");
            int companyPhoneNumber = int.Parse(Console.ReadLine());

            Console.Write("Fax number: ");
            int companyFaxNumber = int.Parse(Console.ReadLine());

            Console.Write("Web site: ");
            string companyWebSite = Console.ReadLine();

            //Information about manager:
            Console.WriteLine("\nEnter information about the manager: ");

            Console.Write("First name: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Last name: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Age: ");
            byte managerAge = byte.Parse(Console.ReadLine());

            Console.Write("Phone number: ");
            int managerPhoneNumber = int.Parse(Console.ReadLine());
 
            Console.WriteLine("\nInformation abuot company: ");
            Console.WriteLine($"Name: {companyName}, Address: {companyAddress}, Phone number: {companyPhoneNumber}, Fax number: {companyFaxNumber}, Web site: {companyWebSite}");

            Console.WriteLine("\nInformation about manager: ");
            Console.WriteLine($"First name: {managerFirstName}, Last name: {managerLastName}, Age: {managerAge}, Phone number: {managerPhoneNumber}");
        }
    }
}


