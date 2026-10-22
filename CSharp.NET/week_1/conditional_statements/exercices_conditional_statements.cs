// Task 1
// Write a console program that calculates the BMI (Body Mass Index).
// The BMI is used to compare a person's weight with their height.
// Ask the user to enter their weight in kilograms and their height in meters.
//
// Formula: weight / (height * height)
//
// After calculating the BMI, display the result and its category:
// 0–18.4: Underweight
// 18.5–24.9: Normal weight
// 25–29.9: Overweight
// 30–34.9: Obesity Grade 1
// 35–39.9: Obesity Grade 2
// 40 and above: Obesity Grade 3

static double CalculateBMI(double weight, double height)
{
    return weight / (height * height);
}

Console.Write("Enter your weight in kilograms: ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter your height in meters: ");
double height = Convert.ToDouble(Console.ReadLine());

double bmi = CalculateBMI(weight, height);

switch (bmi)
{
    case <= 18.4:
        Console.WriteLine("Your BMI is: {0}", bmi);
        Console.WriteLine("Underweight");
        break;

    case <= 24.9:
        Console.WriteLine("Your BMI is: {0}", bmi);
        Console.WriteLine("Normal weight");
        break;

    case <= 29.9:
        Console.WriteLine("Your BMI is: {0}", bmi);
        Console.WriteLine("Overweight");
        break;

    case <= 34.9:
        Console.WriteLine("Your BMI is: {0}", bmi);
        Console.WriteLine("Obesity Grade 1");
        break;

    case <= 39.9:
        Console.WriteLine("Your BMI is: {0}", bmi);
        Console.WriteLine("Obesity Grade 2");
        break;

    default:
        Console.WriteLine("Your BMI is: {0}", bmi);
        Console.WriteLine("Obesity Grade 3");
        break;
}

// Task 2
// Write a console program that checks whether a year entered by the user is a leap year.
//
// A year is a leap year if it can be divided by 4.
// However, if the year can also be divided by 100, it is not a leap year.
// An exception is a year that can be divided by 400. It is a leap year.
//
// Tip: You will need the modulo operator (%).

Console.Write("Enter a year: ");
int year = Convert.ToInt32(Console.ReadLine());

if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
{
    Console.WriteLine("The year {0} is a leap year.", year);
}
else
{
    Console.WriteLine("The year {0} is not a leap year.", year);
}

// Task 3
// Write a simple calculator in the console.
// First, ask the user to enter the first number.
// Then ask for a mathematical operator (+, -, *, /).
// Finally, ask for the second number.
// Perform the selected operation and display the calculation and its result.
// Example: 2 + 4 = 6

Console.Write("Enter the first number: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter an operator (+, -, *, /): ");
string op = Console.ReadLine();

Console.Write("Enter the second number: ");
double number2 = Convert.ToDouble(Console.ReadLine());

double result = 0;

switch (op)
{
    case "+":
        result = number1 + number2;
        break;

    case "-":
        result = number1 - number2;
        break;

    case "*":
        result = number1 * number2;
        break;

    case "/":
        result = number1 / number2;
        break;
}

Console.WriteLine("{0} {1} {2} = {3}", number1, op, number2, result);
