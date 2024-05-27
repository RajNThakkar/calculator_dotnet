using calculator;

double number1 = 0;
double number2 = 0;
int operation = -1;

Console.WriteLine("Enter Number 1:");
while (!double.TryParse(Console.ReadLine(), out number1))
{
    Console.WriteLine("Please enter valid number:");
}

Console.WriteLine("Enter Number 2:");
while (!double.TryParse(Console.ReadLine(), out number2))
{
    Console.WriteLine("Please enter valid number:");
}

Console.WriteLine("Please enter the operation you want to perform on the number.");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");

while (!int.TryParse(Console.ReadLine(), out operation))
{
    Console.WriteLine("Please enter valid operation:");
}

CalculatorOperations calculatorOperations = new CalculatorOperations();

switch (operation)
{
    case 1:
        //Addition
        Console.WriteLine($"Addition of {number1} and {number2} is {calculatorOperations.Addition(number1, number2)}");
        break;
    case 2:
        //Subtraction
        Console.WriteLine($"Subtraction of {number1} and {number2} is {calculatorOperations.Subtraction(number1, number2)}");
        break;
    case 3:
        //Multiplication
        Console.WriteLine($"Multiplication of {number1} and {number2} is {calculatorOperations.Multiplication(number1, number2)}");
        break;
    case 4:
        //Division
        if (number2 == 0) // Checking if number is not zero or on dividing will throw error
        {
            Console.WriteLine("Cannot divide by zero");
        }
        Console.WriteLine($"Division of {number1} and {number2} is {calculatorOperations.Division(number1, number2)}");
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}

Console.ReadLine();