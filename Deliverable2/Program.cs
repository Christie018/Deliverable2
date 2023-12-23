//Initializing variables
string name = "default name";
string input = "default choice";
int min = 0;
int max = 2;
int score = 0;

//Creating random object from Random class for compare aspect of coin flip challenge
Random random = new Random();

//Starting coin flip challenge game
Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");

//Asking the user what their name is
Console.WriteLine("What's your name?");
name = Console.ReadLine();

//Asking the user if they want to play
Console.WriteLine("Welcome, " + name + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
input = Console.ReadLine();

// Breaking out of the game if the user doesn't want to play
if (input == "No" || input == "no" || input == "N" || input == "n")
{
    Console.WriteLine("You're a coward " + name);
}
else
{
    // Looping the coin challenge 5 times
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine("Heads or Tails?");
        input = Console.ReadLine();

        //Generate random number from 0-1 and assign the number to heads or tails
        int randomNumber = random.Next(min, max);
        Console.WriteLine(randomNumber);

        //Compare random output to user input
        if (input == "Heads" || input == "heads" || input == "h")
        {
            int compareInput = 0;
            if (compareInput == randomNumber)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }
        else
        {
            int compareInput = 1;
            if (compareInput == randomNumber)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }

        // End game and display score
        if (i == 5)
        {
            Console.WriteLine("Thank you " + name + ". You got a score of " + score + "!");
        }
    }
}