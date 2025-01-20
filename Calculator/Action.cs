namespace Calculator;

public class Action
{
    public static void Run()
    {
        float numOne;
        float numTwo;
        
        char operation;

        float result = 0;
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

            if (operation == '-')
            {
                result = numOne - numTwo;
            }

            if (operation == '*')
            {
                result = numOne * numTwo;
            }

            if (operation == '/')
            {
                result = numOne / numTwo;
            }
            else
            {
                Console.WriteLine("Error operation");
            }
            Console.WriteLine($"The result is: {result}");
        }
    }
}
