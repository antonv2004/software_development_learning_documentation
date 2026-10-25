// Vaulue Types
int number1 = 10;
int number2 = number1; // The value of number1 is copied into number2.

// Changing number2 does not change number1 because int is a Value Type.
Console.WriteLine(number1); 
Console.WriteLine(number2); 
Console.WriteLine();

number2 = 3; // Only the value of number2 is changed.

Console.WriteLine(number1); 
Console.WriteLine(number2);

// Reference Types

Person person1 = new Person();
Person person2 = person1; // The reference to the object is copied into person2.

// Both variables refer to the same object.
person1.Surname = "Anton";
person1.Lastname = "Berg";

// Changing the surname through person2 also affects person1
// because both variables refer to the same object.
person2.Surname = "Nico";

Console.WriteLine(person1.Surname + " " + person1.Lastname);
Console.WriteLine(person2.Surname + " " + person2.Lastname);


class Person
{
    public string Surname { get; set; } = "";
    public string Lastname { get; set; } = "";
}
