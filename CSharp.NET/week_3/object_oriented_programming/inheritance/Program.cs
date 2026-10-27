Dog mike = new Dog();
mike.Name = "Coco";
mike.Age = 10;
mike.Breed = "Dachshund";
mike.Eat();
mike.Bark();

GuardDog nico = new GuardDog();
nico.Name = "Nico";
nico.Age = 8;
nico.Breed = "Pug";
nico.Eat();
nico.Bark();
nico.GuardHouse();

class Dog
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }

    // Methods
    public void Eat()
    {
        Console.WriteLine("The dog {0} is eating!", Name);
    }

    public void Bark()
    {
        Console.WriteLine("The dog {0} is barking!", Name);
    }
}

class GuardDog : Dog // The Dog class is inherited by the GuardDog class
{
    // Methods
    public void GuardHouse()
    {
        Console.WriteLine("The dog {0} is guarding the house.", Name);
    }
}
