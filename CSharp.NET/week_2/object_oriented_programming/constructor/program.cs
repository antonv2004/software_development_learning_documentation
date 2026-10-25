Dog dog = new Dog(5, "Mike", "Me"); // The constructor is called 
Console.WriteLine(dog.Name);
Console.WriteLine(dog.Owner);
Console.WriteLine(dog.Age);

class Dog
{
    //Properties
    public int Age { get; set; }
    
    public string Name { get; set; }

    public string Owner { get; set; }
    
    //Constructor 
    public  Dog(int age,string name,string owner)
    {
        Age = age;
        Name = name;
        Owner = owner;
    }
}
