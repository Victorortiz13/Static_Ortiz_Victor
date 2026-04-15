namespace Static_Ortiz_Victor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interger Ops!
            Console.WriteLine("Interger Operations:");                              // Prints a message to the console
            Console.WriteLine("Addition: 434 + 343 = " + Calculate.Add(434, 343));     // Calls the Add method in Calculate from the intergers and replaces the paramiters with new values and prints a message and the answer
            Console.WriteLine("Subtraction: 67 - 69 = " + Calculate.Sub(67, 69));         // Calls the Sub method in Calculate from the intergers and replaces the paramiters with new values and prints a message and the answer
            Console.WriteLine("Division: 61 / 41 = " + Calculate.Divi(61, 41));              // Calls the Divi method in Calculate from the intergers and replaces the paramiters with new values and prints a message and the answer
            Console.WriteLine("Multiplication: 86 * 13 = " + Calculate.Multi(86, 13));          // Calls the Multi method in Calculate from the intergers and replaces the paramiters with new values and prints a message and the answer

            // Float Ops!
            Console.WriteLine("\nFloat Operations:");                                                   // Adds a line of space and prints a message to the console
            Console.WriteLine("Addition: 434.334 + 343.443 = " + Calculate.Add(434.334f, 343.443f));       // Calls the Add method in Calculate from the floats and replaces the paramiters with new values and prints a message and the answer
            Console.WriteLine("Subtraction: 67.7 - 69.9 = " + Calculate.Sub(67.7f, 69.9f));                   // Calls the Sub method in Calculate from the floats and replaces the paramiters with new values and prints a message and the answer
            Console.WriteLine("Division: 61.1 / 41.4 = " + Calculate.Divi(61.6f, 41.4f));                        // Calls the Divi method in Calculate from the floats and replaces the paramiters with new values and prints a message and the answer
            Console.WriteLine("Multiplication: 86.13 * 13.86 = " + Calculate.Multi(86.13f, 13.86f));                // Calls the Multi method in Calculate from the floats and replaces the paramiters with new values and prints a message and the answer
        }
    } 
}
