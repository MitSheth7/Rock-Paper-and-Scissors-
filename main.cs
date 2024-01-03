using System;

// Define the namespace for the program
namespace MyFirstProgram
{
    // Define the class for the program
    class Program
    {
        // Define the main method
        static void Main(string[] args)
        {
            // Initialize a new random object
            Random random = new Random();
            
            // Initialize a boolean to control the game loop
            bool playAgain = true;
            
            // Initialize strings for player's choice, computer's choice, and answer for replaying the game
            String player;
            String computer;
            String answer;

            // Game loop
            while (playAgain)
            {
                // Reset player's choice, computer's choice, and answer for each game
                player = "";
                computer = "";
                answer = "";

                // Loop until player enters a valid choice
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                // Computer makes a random choice
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                // Display player's and computer's choices
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                // Determine the winner based on player's choice
                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                // Ask the player if they want to play again
                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                // If the player wants to play again, continue the game loop
                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
                
            }

            // Thank the player for playing
            Console.WriteLine("Thanks for playing!");

            // Wait for a key press before closing the console window
            Console.ReadKey();
        }
    }
}
