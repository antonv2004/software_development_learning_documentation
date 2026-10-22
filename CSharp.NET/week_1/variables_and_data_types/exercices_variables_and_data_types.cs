// Task 1
// Create variables for the following information. Choose a suitable and memory-efficient
// data type for each variable. Also choose meaningful variable names:
// - The age of an employee
// - The wealth of the richest person in the world as a whole number: 185 billion dollars
// - Whether a person is married or not
// - Our name
// - The first letter of our name
// - The price of a cereal (4.98 euros)

byte workerAge = 22;
ulong richestPersonWealth = 185_000_000_000;
bool isMarried = false;
string name = "Anton Voronko";
char nameInitial = 'A';
decimal cerealPrice = 4.98M;

// Task 2
// Write a program that asks the user for the following information:
// - First name
// - Last name
// - Age
// Then display this information in the console, each item on a separate line.
//
// Bonus:
// At the end, also display:
// "Hello [First name] [Last name], welcome back!"
// Use normal string concatenation for this output once, and placeholder formatting
// with the Console.WriteLine() method once.

Console.Write("Enter your full name: ");
string fullName = Console.ReadLine();

Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello {0}, welcome back!", fullName);

Console.ReadKey();
