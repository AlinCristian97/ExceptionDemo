using System;
using ExceptionsLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var demo = new DemoCode();

            try
            {
                int result = demo.GrandparentMethod(4);
                Console.WriteLine($"The value at the given position is {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                Exception inner = ex.InnerException;

                while (inner != null)
                {
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }

        }
    }
}