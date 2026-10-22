Console.Write("Enter integer 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter integer 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

while (number1 <= number2)
{
    Console.WriteLine(number1);
    number1 += 1;
}

string password = "Hello World";
string input = "";

do
{
    Console.Write("Enter the password: ");
    input = Console.ReadLine();

} while (password != input);

Console.WriteLine("Correct!");

for (int i = 3; i < 21; i++)
{
    Console.WriteLine(i);
}

string[] names = new string[]
{
    "Sebastian",
    "Sabine",
    "James",
    "Klaus"
};

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

string[,] products = new string[,]
{
    {
        "Apple",
        "Phone",
        "Chocolate"
    },
    {
        "Food",
        "Electronics",
        "Food"
    }
};

// Display the 2D array using a for loop
for (int row = 0; row < products.GetLength(1); row++)
{
    for (int column = 0; column < products.GetLength(0); column++)
    {
        Console.Write(products[column, row]);
        Console.Write(" ");
    }

    Console.WriteLine();
}

Console.WriteLine();

foreach (var product in products)
{
    Console.WriteLine(product);
}
