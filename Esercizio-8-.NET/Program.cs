using Esercizio_8_.NET;

Console.WriteLine("Please enter the word");
string input = Console.ReadLine();
ProgrammPalindromo programmPalindromo = new ProgrammPalindromo();

if (programmPalindromo.IsPalindromo(input)) 
    {
        Console.WriteLine("It's a palindrome");
    }
    else
    {
        Console.WriteLine("It is not a palindrome");
    }

