using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Proj1
{
    internal class utalityParse
    {

       public static int ReadIntoTryParse(string text)
        {
            bool isParsed = int.TryParse(text, out int result);

            while (!isParsed)
            {
                Console.WriteLine("Invalid input, try again:");
                text = Console.ReadLine()!; 
                isParsed = int.TryParse(text, out result);
            }

            return result;
        }


        public static int ReadParse(string text)
        {
            int result;
            bool isParsed = false;

            while (!isParsed)
            {
                try
                {
                    result = int.Parse(text); 
                    return result;            
                }
                catch
                {
                    Console.WriteLine("Invalid input, try again:");
                    text = Console.ReadLine()!; 
                }
            }

            return 0; 
        }

       public  static int ReadConvert(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0; 

            return Convert.ToInt32(text);
        }

    }
}
