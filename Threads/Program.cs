using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class Program
    {
        public delegate void ParameterizedThreadStart(object obj);

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №1");

                            Thread thread = new Thread(PrintMessage);

                            thread.Start();

                            thread.Join();

                            Console.WriteLine("Main thread finished");

                            Console.ReadKey();
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №2");

                            Thread threadOne = new Thread(PrintNumbersFromOneToFive);
                            Thread threadTwo = new Thread(PrintNumbersFromOneToFive);

                            threadOne.Start();
                            threadTwo.Start();

                            threadOne.Join();
                            threadTwo.Join();

                            Console.WriteLine("Пупупупу");

                            Console.ReadKey();
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №3");



                            Thread thread = new Thread(ThreadFromParameters);
                            thread.Start("Hello");


                            Console.ReadKey();
                        }
                        break;

                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №4");

                            for (int i = 1; i < 6; i++)
                            {
                                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                                Thread.Sleep(1000);
                            }


                            Console.ReadKey();
                        }
                        break;

                    case "5":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №5");


                        }
                        break;

                    default:
                        Console.WriteLine("Выберите корректное задание!");
                        Thread.Sleep(3000);
                        break;
                }
            }
        }

        static void PrintMessage()
        {
            Console.WriteLine("Hello from thread!");
        }

        static void PrintNumbersFromOneToFive()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        static void ThreadFromParameters(object message)
        {
            Console.WriteLine(message);
        }
    }
}
