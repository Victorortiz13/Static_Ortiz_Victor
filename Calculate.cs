using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Ortiz_Victor
{
    static class Calculate
    {
        public static float result = 0.0f;

        static Calculate()
        {
            result = 0.0f;
        }

        // Intergers!
        // Adds two intergers and returns the result
        public static int Add(int x, int y)
        {
            return x + y;
        }
        // Subtracts two intergers and returns the result
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        // Divides two intergers and returns the result
        public static int Divi(int x, int y)
        {
            return x / y;
        }
        // Multiplies two intergers and returns the result
        public static int Multi(int x, int y)
        {
            return x * y;
        }

        // Floats!
        // Adds two floats and returns the result
        public static float Add(float x, float y)
        {
            return x + y;
        }
        // Subtracts two floats and returns the result
        public static float Sub(float x, float y)
        {
            return x - y;
        }
        // Divides two floats and returns the result
        public static float Divi(float x, float y)
        {
            return x / y;
        }
        // Multiplies two floats and returns the result
        public static float Multi(float x, float y)
        {
            return x * y;
        }
    }
}
