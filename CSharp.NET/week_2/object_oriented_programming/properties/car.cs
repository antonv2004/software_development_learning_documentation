namespace Properties; // Defines which namespace the class belongs to

class Car
{
    // Properties
    public string Manufacturer { get; set; }

    // Manual implementation of the getter and setter
    private int numberOfDoors;

    public int NumberOfDoors
    {
        get
        {
            return numberOfDoors;
        }
        set
        {
            if (value < 0)
            {
                numberOfDoors = 1;
            }
            else
            {
                // Value contains the new value (4) assigned to the property.
                numberOfDoors = value;
            }
        }
    }
}
