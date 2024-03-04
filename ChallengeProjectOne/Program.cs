// Constant username and password, these are set and we don't want them to change throught the program
const string username = "anish";
const string password = "Peregrine1";

// Check that log-in credentials are correct, if they are then proceed, else repeat until they enter the correct username and password.
bool inputSuccess = false;
while (!inputSuccess)
{
    // Ask user for username, not case sensitive, so we convert to the same case
    Console.Write("Please enter your username: ");
    string? inputUsername = Console.ReadLine().ToLower().Trim();
    // Password IS case sensitive, so we don't change case
    Console.Write("Please enter your password: ");
    string? inputPassword = Console.ReadLine().Trim();

    // Only leave the log in page if BOTH username and password are the same
    if (inputUsername == username && inputPassword == password)
    {
        inputSuccess = true;
        Console.WriteLine();
    }
    else
    {
        // Message to let user know that input is incorrect
        Console.WriteLine("Username or password is incorrect, please try again.\n");
    }
}




// menu choices using switch statement, within while loop to keep repeating menu until user selects exit menu
bool quitMenu = false;
while (!quitMenu)
{
    //Single writeline statement as it is more efficient than printing multiple.
    Console.WriteLine("""
    -- Main menu --
    1. create a new member
    2. view members
    3. delete members
    x. exit system   
    """);

    //using a try statement incase user enters an incorrect input (null or letters)
    int? menuChoice = 0;
    string? menuChoiceString;
    Console.Write("Please enter a the menu option number: ");
    try
    {
        //if the user entered x, then quit the program
        menuChoiceString = Console.ReadLine();
        if (menuChoiceString == "x")
        {
            Console.WriteLine("Exiting the sysem, thank you :)\n\n");
            quitMenu = true;
            break;
        }
        else
        {
            // If the user hasn't enetered 'x', then we try to parse the value as an integer. Here we are assuming that the user is inputting a menu option other than 'x'.
            // If the value can't be parsed, the catch block will be executed as an exception will be thrown
            menuChoice = int.Parse(menuChoiceString);
        }

        // If a number was entered then run the corresponding menu item, or ask again if incorrect input
        switch (menuChoice)
        {
            case 1:
                Console.WriteLine("Created a new member...\n\n");
                break;
            case 2:
                Console.WriteLine("Displaying all members...\n\n");
                break;
            case 3:
                Console.WriteLine("Deleting all members...\n\n");
                break;
            default:
                // Erroneous input will be caught by the catch clause
                throw new Exception();
        }

    }
    catch (Exception)
    {
        Console.WriteLine("You have entered an invalid input, please try again. Returning to main menu...\n\n");
    }

}