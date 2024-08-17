using System;
using System.Collections.Generic;

class Hangman
{
    static void Main()
    {
        string[] words = { "PTG", "chovek", "lujica", "c#", "Gabrovo" };
        Random random = new Random();
        string wordToGuess = words[random.Next(0, words.Length)];
        char[] guessedWord = new string('_', wordToGuess.Length).ToCharArray();
        List<char> incorrectGuesses = new List<char>();
        int attempts = 6;

        Console.WriteLine("Welcome to Hangman!");

        while (attempts > 0 && new string(guessedWord) != wordToGuess)
        {
            Console.WriteLine($"Word: {new string(guessedWord)}");
            Console.WriteLine($"Incorrect guesses: {string.Join(", ", incorrectGuesses)}");
            Console.WriteLine($"Attempts left: {attempts}");
            Console.Write("Guess a letter: ");
            char guess = Console.ReadLine()[0];

            if (wordToGuess.Contains(guess))
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        guessedWord[i] = guess;
                    }
                }
            }
            else
            {
                incorrectGuesses.Add(guess);
                attempts--;
            }
        }

        if (new string(guessedWord) == wordToGuess)
        {
            Console.WriteLine($"Congratulations! You guessed the word: {wordToGuess}");
        }
        else
        {
            Console.WriteLine($"Game over! The word was: {wordToGuess}");
        }
    }
}
