// Task 1
// Write a program that asks the user to enter two numbers.
// Then perform all mathematical operations learned in this module
// using these two numbers. Display each operation and its result
// on a separate line in the console.

Console.Write("Enter number 1: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter number 2: ");
double number2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);
Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
Console.WriteLine("{0} % {1} = {2}", number1, number2, number1 % number2);

Console.ReadKey();
Console.Clear();
