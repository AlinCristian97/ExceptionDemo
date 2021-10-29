using System;

namespace ExceptionsLibrary
{
    public class DemoCode
    {
        public int GrandparentMethod(int position)
        {
            int output = 0;
            
            Console.WriteLine("Open Database connection");

            try
            {
                output = ParentMethod(position);
            }
            catch (Exception ex)
            {
                // Do some logging
                throw ex; //pass it up the chain, to UI for example. ("I never caught it in the first place")
            }
            finally
            {
                Console.WriteLine("Close Database connection");
            } 
            
            return output;
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