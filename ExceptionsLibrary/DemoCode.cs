using System;

namespace ExceptionsLibrary
{
    public class DemoCode
    {
        public int GrandparentMethod(int position)
        {
            return ParentMethod(position);
        }

        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }
        
        public int GetNumber(int position)
        {
            // try
            // {
                int[] numbers = {1, 4, 7, 2};
                return numbers[position];
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            //     Console.WriteLine(ex.StackTrace);
            // }
        }
    }
}