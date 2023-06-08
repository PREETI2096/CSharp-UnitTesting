using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class LogicalProgram
    {
        public int fibonacciSeries(int number)
        {
            Console.WriteLine("Fibonacci Series :");
            int n1 = 0, n2 = 1, n3=1;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (int i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            return n3;
        }

        public bool perfectNumber(int number)
        {
            Console.WriteLine("Perfect Number Program : ");
            int  sum = 0, n;
            Console.Write("enter the Number : ");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                Console.ReadLine();
                return false;
            }
         
        }
        public bool primeNumber(int n)
        {
            Console.WriteLine("Prime Number Program");

            bool isPrime = true;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.Write("Number is Prime.");
            return isPrime;
        }

        public int ReverseNumber(int n)
        {
            Console.WriteLine("Reverse number: ");
            int  reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
            return reverse;

        }
        public void stopWatch()
        {
            Console.WriteLine("Question 6 : Stopwatch Program \n");
            Console.WriteLine("\n >>>> Press Enter to START <<<<");

            Console.ReadLine();
            var start = DateTime.Now;

            Console.WriteLine("\n >>>> Press Enter to Stop <<<<");
            Console.ReadLine();

            var end = DateTime.Now;

            var timeElapsed = end - start;

            Console.WriteLine("Time Elapsed : {0} Minutes and {1} Seconds and {2} Milliseconds", timeElapsed.Minutes, timeElapsed.Seconds, timeElapsed.Milliseconds);
        }
    }
}
