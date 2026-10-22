// Declaration = Giving a variable a name and a data type.
string username;
byte age;

// Initialization = Giving a variable an initial value.
username = "Anton";
age = 22;

Console.WriteLine("My name is " + username + " and I am " + age + " years old!");

Console.WriteLine(byte.MaxValue);
Console.WriteLine(int.MinValue);

float decimalNumber = 2.25F;
double decimalNumber2 = 33.5463D;
decimal decimalNumber3 = 456.789M;

Console.WriteLine(decimalNumber);
Console.WriteLine(decimalNumber2);
Console.WriteLine(decimalNumber3);

// Another way to declare a variable. The data type is determined automatically.
var number2 = 4; // int number2 = 4;
Console.WriteLine(number2);

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your age: ");
int age2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello {0}, you are {1} years old!", name, age2);

Console.ReadKey();
