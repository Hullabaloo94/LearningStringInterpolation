using System;

namespace LearningStringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new { x = 1, y = 2 };

            // String concatenation - Memory Issues: New string object is created each time a string is concatenated into another. 
            // Creates a lot of unnecessary work for the garbage collector.
            Console.WriteLine("x " + point.x + " y " + point.y);
            // String Formatting - Positioning issues: Changing positions would require changing the string literal AND the order of the parameter list. 
            Console.WriteLine("x {0} y {1}", point.x, point.y);
            // String Interpolation: Requires a '$' before the string literal. Easier to read. Cleaner overall as it does not have the shortcomings of String Concatenation and String Formatting.
            Console.WriteLine($"x {point.x} y {point.y}");







            // ---------------------------Learning String Formatters ----------------------------------------
            var coordinate = new { x = 1.1234, y= 2.1254 };
            // Putting a ':' followed by the formatters after a variable allows you to enter formatters after it. 
            // N followed by an int allows you to specify the number of decimal points to format a number. (N1 would produce 2.1 for coordinate.y)
            Console.WriteLine($"x: {coordinate.x} y: {coordinate.y:N1}");
            // You can also add a number of spaces between a string literal by appending a ',' character followed by the number of spaces you wish to put between the string literal.
            Console.WriteLine($"x: {coordinate.x} y: {coordinate.y,10:N1}");

        }
    }
}
