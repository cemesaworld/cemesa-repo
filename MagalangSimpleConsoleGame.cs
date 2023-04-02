using System;

public class Program
{
    public static void Main()
    {
        string[] words = { "apple", "banana", "orange", "kiwi", "grape" };
        Random random = new Random();
        int index = random.Next(words.Length);
        string wordToGuess = words[index];
        bool[] lettersGuessed = new bool[wordToGuess.Length];
        int remainingGuesses = 6;
        
        Console.WriteLine("Welcome to the Word Guessing Game!");
        
        while (remainingGuesses > 0)
        {
            Console.Write("Guess a letter: ");
            char guess = Console.ReadLine()[0];
            bool foundMatch = false;
            
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == guess)
                {
                    lettersGuessed[i] = true;
                    foundMatch = true;
                    }

                    }
                    if (!foundMatch)
                    {
                        remainingGuesses--;
                        Console.WriteLine("Incorrect guess! You have " + remainingGuesses + " guesses remaining.");
                        }
                        
                        Console.Write("Word: ");
                        
                        for (int i = 0; i < wordToGuess.Length; i++)
                        {
                            if (lettersGuessed[i])
                            {
                                Console.Write(wordToGuess[i] + " ");
                                }
                                
                                else
                                {
                                    Console.Write("_ ");
                                    }
                                    }
                                    
                                    Console.WriteLine();
                                    
                                    if (!Array.Exists(lettersGuessed, element => element == false))
                                    {
                                        Console.WriteLine("Congratulations! You guessed the word.");
                                        break;
                                        }
                                        }
                                        
                                        if (remainingGuesses == 0)
                                        {
                                            Console.WriteLine("Sorry, you have run out of guesses. The word was " + wordToGuess + ".");
                                            }
                                            
                                            Console.WriteLine("Thanks for playing the Word Guessing Game!");
                                            Console.ReadLine();
    }
}