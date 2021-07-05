using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp_Number_IsRepeat_IsPrime_IsPolydrome_IsPerfect
{
    class Program
    {
        static void IsRepeat (int x)
        {
            int num = x;
            bool st = false;
            int z = 0;
            int t;
            while (x > 0)
            {
                int y = x % 10;
                t = x / 10;
                while (t > 0)
                {
                    z = t % 10;

                    if (y == z)
                    {
                        st = true;
                    }
                    t = t / 10;
                }
                x = x / 10;
            }
            if (st == true)
            {
                WriteLine($"Number {num} have repeated digits");
            }
            else
                WriteLine($"Number {num} have not repeated digits");
        }

        static void IsPrime(int n)
        {
            int x = 2;
            int z;
            do
            {
                z = n % x;
                if (z != 0)
                {
                    x++;
                }

            } while (z != 0);

            if (n == x)
            {
                WriteLine("The number you entered is Prime");
            }
            else
            {
                WriteLine("The number you entered is not Prime");
            }
        }

        static void IsPolydrome(int n)
        {
            string num = n.ToString();
            int zro = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == num[num.Length - 1 - zro])
                {
                    zro++;
                }
            }
            if (zro == num.Length)
            {
                WriteLine("Number is Polydrome");
            }
            else
            {
                WriteLine("Number is not Polydrome");
            }
        }

        static void IsPefect(int n)
        {
            int d;
            int f = 0;
            for (int i = 1; i <= n - 1; i++)
            {
                d = n % i;
                if (d == 0)
                {
                    f += i;
                }
            }
            //WriteLine("f = " + f);
            if (f == n)
            {
                WriteLine("Number is Perfect");
            }
            else
            {
                WriteLine("Number is NOT Perfect");
            }
        }
        static void Main(string[] args)
        {
            Write("Enter number: ");
            int x = int.Parse(ReadLine());
            Console.WriteLine();

            IsRepeat(x);

            IsPrime(x);

            IsPolydrome(x);

            IsPefect(x);
            
        }
    }
}
