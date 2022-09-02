internal class Program
{
    private static void Main(string[] args)
    {
        //Variable Declaration
        int x, y, z, b;

        // Assignment Operator
        x = 3;
        y = 4;
        z = 5;  
        b = 6;

        // There are many other mathematical operators

        // Addition operators
        x = 3 + 4;

        // Substraction operators
        x = 4 - 2;

        // Multiplication operators
        x = 3 * 7;

        // Division operators
        x = 4 / 2;

        // Order of operations using parathesis
        x = (x * 7) + (y * 7);


        // There are many operators used to evaluate values ....

        // Equality operator
        if (x == y)
        {

        }

        // Greater than operator
        if (x > y)
        {

        }

        // Lesser than operator
        if (x < y)
        {

        }

        // Greater than or equal to operator
        if (x >= y)
        {

        }

        // Lessor than or equal to operator
        if (x <= y)
        {

        }


        // There are two "conditional" operators as well that can
        // be used to expand / enhance an evaluation ....
        // .... and they can be combined together multiple times.

        // Conditional and operator
        if ((x > y) && (x < y))
        {

        }
        
        // Conditional or operator
        if ((x < y) || (x > y))
        {

        }

        // Also here's is the in-line conditional operator we
        // learned about in the previous lesson ....
        string message = (x == 1) ? "man" : "woman";

        // Member access and method invocation
        Console.WriteLine("Hi");
    }
}