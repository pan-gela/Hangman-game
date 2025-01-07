using System;

class Hangman
{   private string secretword;
    private char[] guessed;
    private int maxgeuss;
    private int wronggeuss;

    public Hangman(string word) {
        secretword = word.ToUpper();
        guessed = new char[secretword.Length];
        maxgeuss = 5;
        wronggeuss = 0;
}

public void Start()
{
    Console.WriteLine("This is a hangman game. You have to guess the word.");

    while (true)
    {
        console.WriteLine("\(^-^)/");
        DisplayGuessed();
        Console.WriteLine("Enter a letter or the whole word: ");

        char letter = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine("__________________________________");

        if (char.IsLetter(let))
        {
            if (!IsLetterGuessed(let))
            {
                if (secretword.Contains(let))
                {
                    UpdateGuessed(let);
                    if (IsWordGuessed())
                    {
                        Console.WriteLine("Good job!");
                        break;
                    }
                }
                else
                {
                    wronggeuss++;
                    Console.WriteLine("Try Again!" + (maxgeuss - wronggeuss) + " geusses left.");
                    if (wronggeuss == maxgeuss)
                    {
                        Console.WriteLine("You lost! The word was: " + secretword);
                        break;
                    }
                }
            } 
            else 
            {
                console.WriteLine ("don't repeat letters")
            }
        }   
        else 
        {
            console.WriteLine ("only letters")
        }
    }
    Console.WriteLine("Game Over!");
    
}

private void DisplayGuessed()
{
    foreach (char c in guessed)
    {
        if (c == '\0')
        {
            Console.Write("_ ");
        }
        else
        {
            Console.Write(c + " ");
        }
    }
    Console.WriteLine();
}

private bool IsLetterGuessed(char letter)
{
    for (int i = 0; i < wordToGuess.Length; i++)
    {
        if (guessedLetters[i] == letter)
        {
            return true;
        }
    }
    return false;
}

private void UpdateGuessed(char letter)
{
    for (int i = 0; i < secretword.Length; i++)
    {
        if (secretword[i] == letter)
        {
            guessed[i] = letter;
        }
    }
}

private bool IsWordGuessed()
{
    foreach (int i = 0; i < secretword.Length; i++)
    {
        if (guessedLetters[i] == '\0')
        {
            return false;
        }
    }
    return true;
}
}

class Program
{
    static void Main()
    {
        Hangman game = new Hangman("hello");
        game.Start();
    }
}
