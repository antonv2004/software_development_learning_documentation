// Task 8
// Write a program that asks the user to enter some text.
// Use a foreach loop to remove all spaces, special characters, and numbers.
// The char data type provides useful methods for checking characters.

Console.Write("Enter some text: ");
string input = Console.ReadLine();
string newText = "";

foreach (char character in input)
{
    if (char.IsLetter(character))
    {
        newText += character;
    }
}

Console.WriteLine("New text: " + newText);


// Task 7
// Write a program that asks the user to enter a text.
// Check if the text is a palindrome.
// A palindrome is a word that reads the same backwards.

Console.Write("Enter some text: ");
string text = Console.ReadLine();

if (IsPalindrome(text))
{
    Console.WriteLine("{0} is a palindrome.", text);
}
else
{
    Console.WriteLine("{0} is not a palindrome.", text);
}

static bool IsPalindrome(string text)
{
    string reversed = "";

    for (int i = text.Length - 1; i >= 0; i--)
    {
        reversed += text[i];
    }

    return reversed.ToLower() == text.ToLower();
}


// Task 6
// Write a console application that displays a string horizontally
// on the first line and vertically on the following lines.
// Display the complete text first, then one character per line.

string text2 = "Hello World";

for (int i = 0; i < text2.Length; i++)
{
    if (i == 0)
    {
        Console.WriteLine(text2);
    }
    else
    {
        Console.WriteLine(text2[i]);
    }
}


// Task 5
// Write a program that displays the multiplication table
// from 1 to 10 in the console.
// Use two for loops.
//
// Bonus:
// Format the table neatly using Console.CursorLeft
// and an additional for loop.

for (int row = 1; row <= 10; row++)
{
    for (int column = 1; column <= 10; column++)
    {
        Console.Write("{0}*{1}={2}", row, column, row * column);

        int spaces = (column * 10) - Console.CursorLeft;

        for (int i = 0; i < spaces; i++)
        {
            Console.Write(" ");
        }
    }

    Console.WriteLine();
}

Console.WriteLine();


// Task 4
// Write a method that draws a rectangle in the console.
// The method should receive the width and height as parameters.
// Use the '#' character to draw the rectangle.
// The width is the number of '#' characters in each row,
// and the height is the number of rows.
// Use two nested for loops.

static void DrawRectangle(int height, int width)
{
    for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
        {
            Console.Write("#");
        }

        Console.WriteLine();
    }
}

DrawRectangle(3, 5);


// Task 3
// Write a method that receives a number as a parameter.
// Multiply this number by every number from 1 to 10.
// Display each calculation in the console.
// Use a for loop.

static void MultiplicationList(int number)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
    }
}

Console.Write("Enter a number: ");
int number = Convert
