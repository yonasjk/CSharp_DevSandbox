using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Console.WriteLine
{
    public class Program
    {
        public static void Main()
        {
            string[] lines = { "This is the first line.",
                         "This is the second line." };
            // Output the lines using the default newline sequence.
            Console.WriteLine("With the default new line characters:");
            Console.WriteLine();
            foreach (string line in lines)
                Console.WriteLine(line);

            Console.WriteLine();

            // Redefine the newline characters to double space.
            Console.Out.NewLine = "\r\n\r\n";
            // Output the lines using the new newline sequence.
            Console.WriteLine("With redefined new line characters:");
            Console.WriteLine();
            foreach (string line in lines)
                Console.WriteLine(line);
        }
    }
    // The example displays the following output:
    //       With the default new line characters:
    //       
    //       This is the first line.
    //       This is the second line.
    //       
    //       With redefined new line characters:
    //       
    //       
    //       
    //       This is the first line.
    //       
    //       This is the second line.
}
