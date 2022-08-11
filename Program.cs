internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double num_one = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Operator: ");
        string op = Console.ReadLine();

        Console.Write("Enter a number: ");
        double num_two = Convert.ToDouble(Console.ReadLine());

        if (op == "+")
        {
            Console.WriteLine(num_one + num_two);
        }
        else if (op == "-")
        {
            Console.WriteLine(num_one - num_two);
        }
        else if (op == "/")
        {
            Console.WriteLine(num_one / num_two);
        }
        else if (op == "*")
        {
            Console.WriteLine(num_one * num_two);
        }
        else
        {
            Console.WriteLine("Invalid operator");
        }
    }
}