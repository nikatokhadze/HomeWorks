using System;

namespace homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

                {
                    #region task 1

                    Console.WriteLine("enter number - ");
                    var number = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("divided to 5 ? ");
                    if (number % 5 == 0)
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");

                    #endregion
                }
                {
                    #region task 2

                    var x = 0;
                    var y = 9;

                    Console.WriteLine(x + y);
                    Console.WriteLine(x * y);
                    if (x < y)
                        Console.WriteLine(y - x);
                    else
                        Console.WriteLine(x - y);
                    try
                    {
                        if (x < y)
                        {
                            Console.WriteLine(y / x);
                        }
                        else
                        {
                            Console.WriteLine(x / y);
                        }
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Not Allowed To Divide By Zero");
                    }

                    #endregion
                }
                {
                    #region task 3

                    Console.WriteLine("enter x - ");
                    var x = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("enter y - ");
                    var y = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"y  and x - {(x, y) = (y, x)}");

                    #endregion
                }
                {
                    #region task 4

                    Console.WriteLine("enter number - ");
                    var i = Convert.ToDecimal(Console.ReadLine());
                    var u = 0;
                    Console.WriteLine("multiplication tabel");
                    while (u < 10)
                    {
                        u++;
                        Console.WriteLine($"{i} * {u} = {i * u}");
                    }
                    #endregion
                }
                {
                    #region task 5
                    Console.WriteLine("Write Number - ");
                    var a = Convert.ToDecimal(Console.ReadLine());
                    var b = 0;

                    while (b < a)
                    {
                        b += 2;
                        Console.WriteLine(b * b);
                    }
                    #endregion
                }
            }
        }
    }


    

