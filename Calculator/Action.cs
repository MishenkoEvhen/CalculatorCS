namespace Calculator;

public class Action
{
    public void Run()
    {
        var numOne = 0f;
        var numTwo = 0f;
        
        char operation;

        string input = "";
        var result = 0f;
        while (true)
        {
            Console.WriteLine("Enter number 1: ");
            numOne = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            numTwo = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation(+, -, *, /): ");
            operation = char.Parse(Console.ReadLine());
            if (operation == '+')
            {
                result = numOne + numTwo;
            }

            else if (operation == '-')
            {
                result = numOne - numTwo;
            }

            else if (operation == '*')
            {
                result = numOne * numTwo;
            }

            else if (operation == '/')
            {
                result = numOne / numTwo;
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine($"The result is: {result}");
        }
    }
}
