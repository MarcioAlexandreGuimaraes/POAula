using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine();
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        Console.WriteLine("String invertida em maiúscula: " + reversedString.ToUpper());
    }
}
