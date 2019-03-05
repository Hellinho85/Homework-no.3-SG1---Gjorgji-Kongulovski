using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_Homework3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task 1.
            //Write a program that will print out all numbers from the range 1 - N
            //(N is input from keyboard, N > 2) that divide with 3.

            Console.WriteLine("Please enter your number:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"The num is {i}");
                }
            }

            //Console.Read();


            //Task 2.
            //Write a program that will print out all numbers in the range 1 - N
            //(N is input from keyboard, N > 5) that divide 2 and 3.

            Console.WriteLine("Please enter your number:");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = 1; i < num2; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine($"The num is {i}");
                }

            }

            //Console.Read();


            //Task 3.
            //Write a program, which will be calculating the product of the digits of an input number.

            Console.WriteLine("Please enter your number:");
            int num3 = int.Parse(Console.ReadLine());

            int product = 1;

            while (num3 != 0)
            {
                int div = num3 % 10;
                num3 /= 10;

                if (div > 0)
                {
                    product *= div;
                }
            }

            Console.WriteLine($"The product is {product}.");
            //Console.Read();


            //Task 4.
            //Write a program that will find out the sum of all even numbers in the range 1 - N
            //(N is input from keyboard).

            Console.WriteLine("Please enter your number:");
            int num4 = int.Parse(Console.ReadLine());

            int sumEven = 0;
            for (int i = 0; i < num4; i += 2)
            {
                sumEven += i;
            }

            Console.WriteLine($"The sum of even numbers is {sumEven}.");
            //Console.Read();


            //Task 5.
            //Write a program that will find out the sum of all odd numbers in the range 1 - N
            //(N is input from keyboard).

            Console.WriteLine("Please enter your number:");
            int num5 = int.Parse(Console.ReadLine());

            int sumOdd = 0;
            for (int i = 1; i < num5; i += 2)
            {
                sumOdd += i;
            }

            Console.WriteLine($"The sum of odd numbers is {sumOdd}.");
            //Console.Read();


            //Task 6.
            //Write a program that will find out the sum of all numbers that divide 5 in the range 1 - N
            //(N is input from keyboard);

            Console.WriteLine("Please enter your number:");
            int num6 = int.Parse(Console.ReadLine());

            int sum6 = 0;
            for (int i = 0; i < num5; i++)
            {
                if (i % 5 == 0)
                {
                    sum6 += i;
                }
            }

            Console.WriteLine($"The sum of all numbers div by 5 is {sum6}");
            //Console.Read();


            //Task 7.
            //Write a program that will reverse the array {“a”,”b”,”c”,”d”}
            //so that the output is {“d”,“c”,“b”,“a”}. Hint: use Array.Reverse().

            string[] letters = new string[] { "G", "J", "O", "R", "G", "J", "I" };
            Array.Reverse(letters);
            foreach (string letter in letters)
            {
                Console.WriteLine(letter);
            }

            //Console.ReadLine();


            //Task 8.
            //Write a program that will read two arrays Niza1 and Niza2.
            //Then the program has to make a comparison of the arrays and determine 
            //whether they are equal or not.

            // Option 1 - The long way using only if/else;

            int[] niza1 = new int[] { 1, 9, 8, 5 };
            int[] niza2 = new int[] { 2, 0, 1, 9 };


            if (niza1[0] == niza2[0] && niza1[1] == niza2[1] && niza1[2] == niza2[2] && niza1[3] == niza2[3])
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadLine();


            // Option 2 - The short way using SequenceEqual;

            int[] niza3 = new int[] { 1, 9, 8, 5 };
            int[] niza4 = new int[] { 1, 9, 8, 5 };

            Console.WriteLine(niza3.SequenceEqual(niza4));
            //Console.ReadLine();


            //Task 9.
            //Write a program that will find all numbers in between 1 and 1000, 
            //that divide the sum composed of their digits. The requirements of the Task are not exactly clear to me.
            // Might need more clarification. I solved them in a way different from the task requirements
            // just for practice.

            // Option 1 (For Loop) - Sum the numbers between 1 - 1000 then divide the sum of their digits
            int sum = 0;
            int divideSum = 0;

            for (int i = 1; i < 1000; i++)
            {
                sum += i;
                divideSum = sum / i;

            }

            Console.WriteLine(divideSum);
            //Console.Read();


            // Option 2 (While loop)

            int n9 = 999;
            int total = 0;

            while (n9 != 0)
            {
                int div = n9 % 10;
                n9 /= 10;

                if (div > 0 && n9 % div == 0)
                {
                    total += div;
                    Console.WriteLine(div);
                }
            }


            Console.WriteLine(total);
            //Console.Read();


            //Task 10.
            //Write a program that will find out all numbers in the range[1 : 1000] that 
            //divide the product composed of their digits.
            // The requirements of the Task are not exactly clear to me.
            // Might need more clarification. I solved them in a way different from the task requirements
            // just for practice.

            int n = 999;
            int totalProduct = 1;


            while (n != 0)
            {
                int div = n % 10;
                n /= 10;

                if (div > 0 && n % div == 0)
                {
                    totalProduct *= div;
                    Console.WriteLine(div);
                }
            }


            Console.WriteLine(totalProduct);
            //Console.Read();


            //Task 11.
            //Write a program that will print out all two-digit numbers, 
            //which have the first digit greater than the second digit.
            // The requirements of the Task are not exactly clear to me.
            // Might need more clarification.

            for (int i = 10; i < 100; i++)
            {
                if (i / 10 > i % 10)
                {
                    Console.WriteLine(i);
                }


            }

            //Console.Read();


            //Task 12: 
            //Write a short program that prints each number from 1 to 100 on a new line.
            //For each number that is divided by 3 print “Fizz” instead of the number.
            //For each number that is divided by 5 print “Buzz” instead of the number.
            //For each number that is divided by 3 and 5  print “FizzBuzz” instead of the number.

            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.Read();

        }
    }
}
