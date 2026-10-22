// Task 1
// Write a method called GetTextInput(string message) that asks the user
// to enter a text value. The method should display the message in the console
// and return the text entered by the user as a string.
//
// Then, ask the user for their first and last name using this method.
// Finally, greet the user using their first and last name.

static string GetTextInput(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

string firstName = GetTextInput("Enter your first name: ");
string lastName = GetTextInput("Enter your last name: ");

Console.WriteLine("Hello {0} {1}", firstName, lastName);

// Task 2
// Write a method called GetCircleArea(double radius) that calculates
// the area of a circle and returns the result as a double.
//
// Formula: A = PI * radius * radius
// Tip: You can use the PI property from the Math class.

static double GetCircleArea(double radius)
{
    return Math.PI * radius * radius;
}

// Ask the user to enter a radius when the program starts.
// Then display the area of the circle in the console.

Console.Write("Enter a radius: ");
double radius = Convert.ToDouble(Console.ReadLine());

double area = GetCircleArea(radius);

Console.WriteLine(
    "The area of a circle with a radius of {0} cm is {1} cm².",
    radius,
    area
);

Console.ReadKey();
