// You can use +, -, *, and / for calculations. Multiplication and division are done before addition and subtraction.
byte number1 = 3;
byte number2 = 4;
byte number3 = 5;

int result = number1 + number2 * number3 + (5 + 2);

// Modulo operator: It returns the remainder after division.
int result2 = number3 % number1;

Console.WriteLine(result);
Console.WriteLine(result2);

Console.WriteLine(number3 += 1); // += increases the value by 1. The same idea applies to -=, *=, and /=.

Console.ReadKey();
