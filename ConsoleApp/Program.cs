using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lines = File.ReadAllLines(text);
            StreamReader sr = new StreamReader("../../../textfile.txt");
            string data = sr.ReadLine();
            while (data != null)
            {
                Console.WriteLine(data);
                data = sr.ReadLine();
            }
            //string text = File.ReadAllText(@"~/textfile", Encoding.UTF8);

        }
        public static int SmallestMulti(int x)
        {
            int ans = 0;
            for(int i = 0; i < 3000; i++)
            {
                for(int w = 1; w <= x; w++)
                {
                    if(i % x <= 0)
                    {
                        //Console.WriteLine(i);
                        ans = i;
                    }
                }
            }
            return ans;
        }
        public static int PalindromLargest()
        {

            int res;
            int finale = 0;
            for(int i = 999 ; i > 0; i--)
            {
                for(int j = 999; j > 0; j--)
                {
                    res = i * j;
                    if(res == ReverseNum(res))
                    {
                        if(res > finale)
                        {
                            finale = res;
                        }
                    }

                }
            }
            return finale;
        }
        public static int ReverseNum(int x)
        {
            string numToString = x.ToString();
            string newString = "";
            for(int i = numToString.Length - 1; i >= 0; i--)
            {
                newString += numToString[i];
            }
            return Int32.Parse(newString);
        }
        public static long LargestPrimal(long chosenNumnber)
        {

            long largestPrimalFactor = 0;
            long ChosenNumber = chosenNumnber;
            long sqRoot = (int)Math.Sqrt(ChosenNumber);
            for (int i = 2; i <= sqRoot; i++)
            {
                if (ChosenNumber % i == 0)
                {
                    if (IsPrime(i))
                    {
                        largestPrimalFactor = i;
                    }

                }
            }
            return largestPrimalFactor;
        }
        public static bool IsPrime(int x)
        {
            for(int i = 2; i * i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                    //Console.WriteLine(i);
                }
            }
            //if (finale % 2 == 0 || finale % 5 == 0)
            //{
            //    return finale % 2;
            //}   
            return true;
        }
        public static int Fib(int num)
        {
            int a = 0;
            int b = 1;
            int c = a + b;
            int getEven = 0;

            for (int i = num; c < num; i++)
            {
                b = a;
                a = c;
                c = a + b;
                Console.WriteLine(c);
                if (c % 2 == 0)
                {
                    getEven += c;
                }
            }
            return getEven;
        }

        //static public int ThreeAndFive()
        //{
        //    int x = 1000;
        //    int counter = 0;
        //    for (int i = 0; i < x; i++)
        //    {
        //        if (i % 3 == 0 || i % 5 == 0)
        //        {
        //            counter += i;
        //        }
        //    }
        //    return counter;
        //}

    }
}
