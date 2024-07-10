// Oroginal code
using System;

namespace CSC205
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Prod(1, 4));
        }
        public static int Prod(int m, int n)
        {
            if (m == n)
            {
                return n;
            }
            else
            {
                int recurse = Prod(m, n - 1);
                int result = n * recurse;
                return result;
            }
        }
    }
}

    /* Stack diagram starts here:

    // The stack diagram just before the last instance of 'Prod' completes would look like this:
    Prod(1, 4);
    Prod(1, 3)
    Prod(1, 2)
    Prod(1, 1) -> returns 1
    /* The ouput of the program is '24'.
    Prod(1, 1) returns 1
    Prod(1, 2) computes 2 * 1 = 2 and returns 2
    Prod(1, 3) computes 3 * 2 = 6 and returns 6
    Prod(1, 4) computes 4 * 6 = 24 and returns 24 

The Prod method calculates the product of all integers in the range from m to n, inclusive.
If m equals n, it simply returns n.
Otherwise, it recursively calculates the product of the range [m, n-1] and multiplies the result by n. */

/* public class Prod
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Prod(1, 4));
        }

        public static int Prod(int m, int n)
        {
            if (m == n)
            {
                return n;
            }
            else
            {
                return n * Prod(m, n - 1);
            }
        }
    }
} */