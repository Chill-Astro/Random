using System;
namespace Randome;
    class Program {
        static void Main(string[]args) {
            Console.WriteLine("Random by Chill-Astro : A Simple Number Guessing Game!");
            Console.WriteLine();
            Random random = new Random();
            int num = random.Next(1,11); // Rando Numero
            int tr = 5; // No. of tries

            Console.WriteLine("Good Luck! You have 5 Tries to guess the number between 1 and 10!"); // Moved the good luck message

            while(tr > 0) { // Corrected the loop condition
                Console.Write("Enter a Number [ 1 - 10 ] : ");
                string input = Console.ReadLine(); // Get input as string

                if (int.TryParse(input, out int n)) // Use TryParse for safer conversion
                {
                    if(n < 1 || n > 10) { // Changed range to 1-10
                        Console.WriteLine("Enter a Number in the Range 1 - 10.");
                        continue;
                    }

                    if (n == num) {
                        Console.WriteLine("You Guessed It! Good Job!");
                        break; // Exit the loop if the guess is correct
                    }
                    else if (n < num) {
                        Console.WriteLine("Nope! Too Low!");
                        tr--;
                        Console.WriteLine("No. of Tries Left : " + tr);
                    }
                    else if (n > num) {
                        Console.WriteLine("Nope! Too High!");
                        tr--;
                        Console.WriteLine("No. of Tries Left : " + tr);
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Number!");
                }

                if(tr == 0) {
                    Console.WriteLine("You are one of Many! Well, you can try again!");
                    Console.WriteLine("The Number was : " + num);
                }
            }

            Console.WriteLine("Thanks for Playing!");
        }
    }