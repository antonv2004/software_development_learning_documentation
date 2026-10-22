string[] names = new string[4];

names[0] = "John";
names[1] = "Jane";
names[2] = "Nico";
names[3] = "Leonie";

Console.WriteLine(names[2]);

string[,] products = new string[2, 3];

// Row 1
products[0, 0] = "Mac";
products[1, 0] = "PC";

// Row 2
products[0, 1] = "App";
products[1, 1] = "Calculator";

// Row 3
products[0, 2] = "Keyboard";
products[1, 2] = "Phone";

Console.WriteLine(products[0, 0]);
Console.WriteLine(products[1, 0]);
