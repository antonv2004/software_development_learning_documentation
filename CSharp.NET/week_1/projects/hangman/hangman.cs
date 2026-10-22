MainMenu();

static void MainMenu()
{
    while (true)
    {
        Console.WriteLine("### HANGMAN ###");
        Console.WriteLine("###############");
        Console.WriteLine();

        Console.WriteLine("Choose an option:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[1] Play");
        Console.WriteLine("[2] Exit");
        Console.ResetColor();
        Console.WriteLine();

        Console.Write("Option: ");

        if (!int.TryParse(Console.ReadLine(), out int action))
        {
            Console.WriteLine("Invalid input!");
            Console.ReadKey();
            Console.Clear();
            continue;
        }

        switch (action)
        {
            case 1:
                StartGame();
                break;

            case 2:
                return;

            default:
                Console.WriteLine("Invalid option!");
                Console.ReadKey();
                break;
        }

        Console.Clear();
    }
}

static void StartGame()
{
    string[] words =
    {
        "ApplePie",
        "VegetableSoup",
        "MotorVehicle",
        "Truck",
        "VideoGame",
        "AlarmSystem",
        "WholeGrainBread"
    };

    Random random = new Random();
    int index = random.Next(0, words.Length);
    string word = words[index].ToLower();

    GameLoop(word);
}

static void GameLoop(string word)
{
    int lives = 10;
    string hiddenWord = "";

    for (int i = 0; i < word.Length; i++)
    {
        hiddenWord += "_";
    }

    while (lives > 0 && hiddenWord != word)
    {
        Console.Clear();

        Console.WriteLine("Word to guess: " + hiddenWord);
        Console.Write("Attempts left: ");

        for (int i = 0; i < lives; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("X");
            Console.ResetColor();
        }

        Console.WriteLine();
        Console.Write("Letter: ");

        string input = Console.ReadLine().ToLower();

        if (input.Length != 1 || !char.IsLetter(input[0]))
        {
            Console.WriteLine("Please enter exactly one letter!");
            Console.ReadKey();
            continue;
        }

        char character = input[0];
        bool foundCharacterInWord = false;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == character)
            {
                foundCharacterInWord = true;
                break;
            }
        }

        if (foundCharacterInWord)
        {
            string tempHiddenWord = hiddenWord;
            hiddenWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == character)
                {
                    hiddenWord += character;
                }
                else
                {
                    hiddenWord += tempHiddenWord[i];
                }
            }
        }
        else
        {
            lives--;
        }
    }

    Console.Clear();

    if (hiddenWord == word)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("YOU WON!");
        Console.WriteLine("The word was: " + word);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("GAME OVER");
        Console.WriteLine("The word was: " + word);
    }

    Console.ResetColor();
    Console.ReadKey();
}
