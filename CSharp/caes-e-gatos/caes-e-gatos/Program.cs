// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:

            animalSpecies = "tba";
            animalID = "tba";
            animalAge = "tba";
            animalPhysicalDescription = "tba";
            animalPersonalityDescription = "tba";
            animalNickname = "tba";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}
do
{
    // display the top-level menu options

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");


    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    //Console.WriteLine($"You selected menu option {menuSelection}.");
    //Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    //readResult = Console.ReadLine();
    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {

                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "2":
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }
            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            if (petCount < maxPets)
            {
                while (anotherPet == "y" && petCount < maxPets)
                {
                    bool validEntry = false;
                    do
                    {
                        Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalSpecies = readResult.ToLower();
                            if (animalSpecies == "dog" || animalSpecies == "cat")
                            {
                                validEntry = false;
                                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
                                // get the pets age. can be ? at initial entry
                                do
                                {
                                    int petAge;
                                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        animalAge = readResult;
                                        if (animalAge != "?")
                                        {
                                            validEntry = int.TryParse(animalAge, out petAge);
                                        }
                                        else
                                        {
                                            validEntry = true;
                                        }
                                        do
                                        {
                                            Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                                            readResult = Console.ReadLine();
                                            if (readResult != null)
                                            {
                                                animalPhysicalDescription = readResult.ToLower();
                                                if (animalPhysicalDescription == "")
                                                {
                                                    animalPhysicalDescription = "tbd";
                                                }

                                            }
                                        } while (animalPhysicalDescription == "");
                                        do // gets animel personaliy can be blank
                                        {
                                            Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                                            readResult = Console.ReadLine();
                                            if (readResult != null)
                                            {
                                                animalPersonalityDescription = readResult.ToLower();
                                                if (animalPersonalityDescription == "")
                                                {
                                                    animalPersonalityDescription = "tbd";
                                                }
                                            }
                                        } while (animalPersonalityDescription == "");
                                        do
                                        {
                                            Console.WriteLine("Enter a nickname for the pet");
                                            readResult = Console.ReadLine();
                                            if (readResult != null)
                                            {
                                                animalNickname = readResult.ToLower();
                                                if (animalNickname == "")
                                                {
                                                    animalNickname = "tbd";
                                                }
                                            }
                                        } while (animalNickname == "");
                                        ourAnimals[petCount, 0] = "ID #: " + animalID;
                                        ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                                        ourAnimals[petCount, 2] = "Age: " + animalAge;
                                        ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                                        ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                                        ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;
                                    }
                                } while (validEntry == false);

                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                    } while (validEntry == false);
                    // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                    petCount = petCount + 1;
                    if (petCount < maxPets)
                    {
                        // another pet?
                        Console.WriteLine("Do you want to enter info for another pet (y/n)");
                        do
                        {
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                anotherPet = readResult.ToLower();
                            }
                        } while (anotherPet != "y" && anotherPet != "n");
                    }
                }
            }
            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }
            break;
        case "3":
            petCount = 0;

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            for (int i = 0; i < petCount; i++)
            {

                if (ourAnimals[i, 2] != "Age: " + "?")
                {

                }
                else
                {
                    Console.WriteLine($"There is a pet {ourAnimals[i, 0]} which age is not in our System\nWould you like to add his/her age?");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        readResult = readResult.ToLower();
                        switch (readResult)
                        {
                            case "yes":

                                bool valueFound = true;
                                int rowIndex = -1;
                                int colIndex = -1;
                                string targetValue = "Age: " + "?";

                                for (int row = 0; row < ourAnimals.GetLength(0); row++)
                                {
                                    for (int col = 2; col < ourAnimals.GetLength(1); col++)
                                    {

                                        // DEBUG for finding the "?"
                                        // string currentValue = ourAnimals[row, col];
                                        // Console.WriteLine($"Checking row: {row}, col: {col}, value: {ourAnimals[row, col]}");
                                        if (ourAnimals[row, col] == targetValue)
                                        {
                                            rowIndex = row;
                                            colIndex = col;
                                            Console.WriteLine($"Value '{targetValue}' found at index [{rowIndex}, {colIndex}].");
                                            Console.WriteLine("What is the age of the pet?");
                                            var newPetAge = Console.ReadLine();
                                            ourAnimals[row, col] = "Age: " + newPetAge;
                                            Console.WriteLine(ourAnimals[row, col]);
                                            valueFound = true;
                                            Console.Clear();
                                            if (ourAnimals[i, 4] != "")
                                            {
                                                Console.WriteLine("There is a pet which physical description is not in our System\nWould you like to add his/her description?");
                                                var confirmation = Console.ReadLine();
                                                if (confirmation != null)
                                                {
                                                    confirmation = confirmation.ToLower();
                                                    switch (confirmation)
                                                    {
                                                        case "yes":
                                                            targetValue = "Physical description: " + "";
                                                            for (int rowphy = 0; rowphy < ourAnimals.GetLength(0); rowphy++)
                                                            {
                                                                for (int colphy = 4; colphy < ourAnimals.GetLength(1); colphy++)
                                                                {

                                                                    // DEBUG for finding the "?"
                                                                    //string currentValue = ourAnimals[rowphy, colphy];
                                                                    //Console.WriteLine($"Checking row: {rowphy}, col: {colphy}, value: {ourAnimals[rowphy, colphy]}");
                                                                    if (ourAnimals[rowphy, colphy] == targetValue)
                                                                    {
                                                                        rowIndex = rowphy;
                                                                        colIndex = colphy;
                                                                        Console.WriteLine($"Value '{targetValue}' found at index [{rowIndex}, {colIndex}].");
                                                                        Console.WriteLine("What is the physical description of the pet?");
                                                                        var newPetPhysical = Console.ReadLine();
                                                                        ourAnimals[rowphy, colphy] = "Physical description: " + newPetPhysical;
                                                                        Console.WriteLine(ourAnimals[rowphy, colphy]);
                                                                        valueFound = true;
                                                                    }
                                                                }
                                                            }
                                                            break;
                                                        case "no":
                                                            break;
                                                        default:
                                                            Console.WriteLine("Choose yey or nay.");
                                                            break;
                                                    }
                                                }
                                            }
                                        }
                                        if (valueFound) // Check if value is found to exit the outer loop
                                            break;
                                    }
                                }

                                break;
                            case "no":
                                Console.WriteLine("oh... Okay!");
                                break;
                            default:
                                Console.WriteLine("Yes, or no, not that deep");
                                break;
                        }

                    }

                }
            }
            Console.WriteLine("\nPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "4":

            petCount = 0;

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            for (int i = 0; i < petCount; i++)
            {

                if (ourAnimals[i, 3] != "Nickname: " + "")
                {

                }
                else
                {
                    Console.WriteLine($"There is a pet {ourAnimals[i, 0]} which Nickname is not in our System\nWould you like to add his/her Nickname?");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        readResult = readResult.ToLower();
                        switch (readResult)
                        {
                            case "yes":

                                bool valueFound = true;
                                int rowIndex = -1;
                                int colIndex = -1;
                                string targetValue = "Nickname: " + "";

                                for (int row = 0; row < ourAnimals.GetLength(0); row++)
                                {
                                    for (int col = 3; col < ourAnimals.GetLength(1); col++)
                                    {

                                        // DEBUG for finding the "?"
                                        // string currentValue = ourAnimals[row, col];
                                        // Console.WriteLine($"Checking row: {row}, col: {col}, value: {ourAnimals[row, col]}");
                                        if (ourAnimals[row, col] == targetValue)
                                        {
                                            rowIndex = row;
                                            colIndex = col;
                                            Console.WriteLine($"Value '{targetValue}' found at index [{rowIndex}, {colIndex}].");
                                            Console.WriteLine("What is the Nickname of the pet?");
                                            var newPetNickname = Console.ReadLine();
                                            ourAnimals[row, col] = "Nickname: " + newPetNickname;
                                            Console.WriteLine(ourAnimals[row, col]);
                                            valueFound = true;
                                            Console.Clear();
                                            if (ourAnimals[i, 5] != "")
                                            {
                                                Console.WriteLine("There is a pet which Personality is not in our System\nWould you like to add his/her description?");
                                                var confirmation = Console.ReadLine();
                                                if (confirmation != null)
                                                {
                                                    confirmation = confirmation.ToLower();
                                                    switch (confirmation)
                                                    {
                                                        case "yes":
                                                            targetValue = "Personality: " + "";
                                                            for (int rowphy = 0; rowphy < ourAnimals.GetLength(0); rowphy++)
                                                            {
                                                                for (int colphy = 5; colphy < ourAnimals.GetLength(1); colphy++)
                                                                {

                                                                    // DEBUG for finding the "?"
                                                                    //string currentValue = ourAnimals[rowphy, colphy];
                                                                    //Console.WriteLine($"Checking row: {rowphy}, col: {colphy}, value: {ourAnimals[rowphy, colphy]}");
                                                                    if (ourAnimals[rowphy, colphy] == targetValue)
                                                                    {
                                                                        rowIndex = rowphy;
                                                                        colIndex = colphy;
                                                                        Console.WriteLine($"Value '{targetValue}' found at index [{rowIndex}, {colIndex}].");
                                                                        Console.WriteLine("What is the Personality of the pet?");
                                                                        var newPetPersonality = Console.ReadLine();
                                                                        ourAnimals[rowphy, colphy] = "Personality: " + newPetPersonality;
                                                                        Console.WriteLine(ourAnimals[rowphy, colphy]);
                                                                        valueFound = true;
                                                                    }
                                                                }
                                                            }
                                                            break;
                                                        case "no":
                                                            break;
                                                        default:
                                                            Console.WriteLine("Choose yey or nay.");
                                                            break;
                                                    }
                                                }
                                            }
                                        }
                                        if (valueFound) // Check if value is found to exit the outer loop
                                            break;
                                    }
                                }

                                break;
                            case "no":
                                Console.WriteLine("oh... Okay!");
                                break;
                            default:
                                Console.WriteLine("Yes, or no, not that deep");
                                break;
                        }

                    }

                }
            }
            Console.WriteLine("\nPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "5":
            // UNDER CONSTRUCTION - please check back next month to see progress.
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            break;
        case "6":
            // UNDER CONSTRUCTION - please check back next month to see progress.
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            break;
        case "7":
            // UNDER CONSTRUCTION - please check back next month to see progress.
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            break;
        case "8":
            // UNDER CONSTRUCTION - please check back next month to see progress.
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            break;
        default:
            break;
    }
} while (menuSelection != "exit");