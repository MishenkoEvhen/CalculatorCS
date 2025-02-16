﻿using System;

namespace Calculator;

public class Action
{
    public void Run()
    {
        var numOne = 0f;
        var numTwo = 0f;
        
        string operation;

        string input = "";
        var result = 0f;
        while (true)
        {
            Console.WriteLine("Enter number 1: ");
            numOne = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            numTwo = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation(+, -, *, /): ");
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
                        Console.WriteLine($"Результат: {result.ToString("0.00")}");
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Ошибка: " + e.Message);
                    }                    
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
            Console.WriteLine($"The result is: {result}");
        }
    }
}
