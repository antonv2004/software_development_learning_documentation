// Task 1
// Create a 1D array of product names containing:
// - Water bottle
// - Chewing gum
// - Pasta
// - Potatoes
//
// First, add the values to the array one index at a time.
// Then, create the array and add all values directly.

string[] productNames = new string[4];

productNames[0] = "Water bottle";
productNames[1] = "Chewing gum";
productNames[2] = "Pasta";
productNames[3] = "Potatoes";

Console.WriteLine(productNames[0]);

string[] productNames2 = new string[]
{
    "Water bottle",
    "Chewing gum",
    "Pasta",
    "Potatoes"
};

// Task 2
// Create a 2D array with first names and last names.
// Each row should contain a first name in the first column
// and the last name in the second column.
//
// Add the following names:
// - Sabine Müller
// - Sandra Maier
// - Klaus Schmied
// - Max Mustermann
//
// First, add the values to the array one index at a time.
// Then, create the array and add all values directly.

string[,] names = new string[2, 4];

names[0, 0] = "Sabine";
names[1, 0] = "Müller";

names[0, 1] = "Sandra";
names[1, 1] = "Maier";

names[0, 2] = "Klaus";
names[1, 2] = "Schmied";

names[0, 3] = "Max";
names[1, 3] = "Mustermann";

string[,] names2 = new string[,]
{
    // First names
    {
        "Sabine",
        "Sandra",
        "Klaus",
        "Max"
    },

    // Last names
    {
        "Müller",
        "Maier",
        "Schmied",
        "Mustermann"
    }
};

Console.WriteLine(names[0, 0]);
