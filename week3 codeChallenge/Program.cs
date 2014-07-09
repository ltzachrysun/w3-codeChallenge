using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {

        static void Main(string[] args)
        {
            findPrimes(10001);
            evenFibonacciSequencer(1000000);
            longestCollatzSequence();

            Console.ReadKey();
        }


        static void findPrimes(int thisMany)
        {
            int counter = 0;
            int lastNumber = 0;

            for (int i = 0; counter < thisMany; i++)
            {
                if (isPrime(i))
                {
                    counter++;
                }
                lastNumber = i;
            }
            Console.WriteLine("the 10001st prime is " + lastNumber);
            Console.WriteLine();
        }

        static bool isPrime(int number)
        {
            bool prime = true;

            if (number < 2)
            {
                prime = false;
            }


            else
            {
                for (var i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
            }
            return prime;
        }


        static void evenFibonacciSequencer(int maxValue)
        {
            int lastNum = 1;
            int newNum = 2;
            int counter = 0;


            while (newNum < maxValue)
            {
                if (newNum % 2 == 0)
                {
                    counter += newNum;
                }

                int temp = newNum + lastNum;
                lastNum = newNum;
                newNum = temp;
            }

            Console.WriteLine("new number " + newNum);
            Console.WriteLine("counter " + counter);
            Console.WriteLine();
        }


        static void longestCollatzSequence()
        {
            int longestSequenceNumber = 0;
            int longestSequenceLength = 1;


            for (int i = 2; i < 1000000; i++)
            {
                long num = i;
                int tempSequenceLength = 1;

                while (num != 1)
                {
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                    }
                    else
                    {
                        num = ((3 * num) + 1);
                    }
                    tempSequenceLength++;
                }
                if (tempSequenceLength > longestSequenceLength)
                {
                    longestSequenceLength = tempSequenceLength;
                    longestSequenceNumber = i;
                }
            }

            Console.WriteLine("longest sequence number " + longestSequenceNumber);
            Console.WriteLine("longest sequence length " + longestSequenceLength);
        }
    }
}