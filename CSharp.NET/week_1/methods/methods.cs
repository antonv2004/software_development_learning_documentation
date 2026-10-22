static void SayHello(string name, byte age) // Method without a return value
{
    Console.WriteLine("Hello, {0}, you are {1} years old!", name, age);
}

SayHello("Anton", 22);
SayHello("Leonie", 21);

static int Addition(int a, int b) // Method with a return value
{
    return a + b;
}

Console.WriteLine(Addition(10, 5));

Console.ReadKey();
