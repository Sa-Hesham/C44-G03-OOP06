using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.project2
{
    public class Math
    {

    
       
        public static int Add(int a, int b)
        {
            return a + b;
        }

       
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

    
        public static int Multiply(int a, int b)
        {
            return a * b;
        }


        public static double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Error: Cannot divide by zero.");

            return (double)a / b;
        }
    }



}

