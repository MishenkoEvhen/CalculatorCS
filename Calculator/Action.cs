namespace Calculator;

public class Action
{
    public void Run()
    {
        var numOne = 0f;
        var numTwo = 0f;
        
        string operation;
        
        var result = 0f;
        
        while (true)
        {
            try
            {
                Console.WriteLine("Enter number 1: ");
                numOne = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter number 2: ");
                numTwo = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter operation(+, -, *, /, sin, cos, tan): ");
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        result = numOne + numTwo;
                        break;
                    case "-":
                        result = numOne - numTwo;
                        break;
                    case "*":
                        result = numOne * numTwo;
                        break;
                    case "/":
                        result = numOne / numTwo;
                        try
                        {
                            if (numTwo == 0)
                            {
                                throw new DivideByZeroException("Нельзя делить на ноль");
                            }

                            result = numOne / numTwo;
                        
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine("Ошибка: " + e.Message);
                        }                    
                        break;
                    case "sin":
                        result = (float)Math.Sin(numOne);
                        break;
                    case "cos":
                        result = (float)Math.Cos(numOne);
                        break;
                    case "tan":
                        result = (float)Math.Tan(numOne);
                        break;
                    default:
                        Console.WriteLine("Такого оператора нету!");
                        break;
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine("Ошибка!" +e.Message);
            }
            
            Console.WriteLine($"The result is: {result}");
        }
    }
}
