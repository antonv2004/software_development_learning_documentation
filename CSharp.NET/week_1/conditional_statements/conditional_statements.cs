int age = 22;
bool withParents = false;

if (age >= 18)
{
    Console.WriteLine("You are allowed to watch the movie!");
}
else if (withParents == true)
{
    Console.WriteLine("You are allowed to watch the movie with your parents!");
}
else
{
    Console.WriteLine("You are not allowed to watch the movie.");
}

int age2 = 22;
bool hasMobilePhone = true;
bool hasQualification = false;
bool passedTest = true;
bool isShy = false;

if ((age2 >= 18) && (hasMobilePhone == true) && (hasQualification == true || passedTest == true && isShy == false))
{
    Console.WriteLine("You get the job.");
}
else
{
    Console.WriteLine("You do not get the job.");
}

Console.Write("Command: ");
string command = Console.ReadLine();

switch (command)
{
    case "SayHello":
        Console.WriteLine("Hello");
        break;

    case "SayGoodbye":
        Console.WriteLine("Goodbye");
        break;

    default:
        Console.WriteLine("Unknown command");
        break;
}

Console.ReadKey();
