using Properties; // Allows access to the namespace

Car car = new Car();

car.Manufacturer = "Mercedes-Benz";
Console.WriteLine(car.Manufacturer);

car.Manufacturer = "BMW";
Console.WriteLine(car.Manufacturer);

// Assigns the value 4 to the NumberOfDoors property.
// The set accessor then receives the value 4 through the value keyword.
car.NumberOfDoors = 4;

Console.WriteLine(car.NumberOfDoors);
