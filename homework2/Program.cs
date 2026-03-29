using System;
class Program
{
    static bool IsPalindrome(string s)
    {
        string normalized = s.ToLower().Replace(" ", "");//litera mici si scoate spatiile
        char[] chars = normalized.ToCharArray();
        Array.Reverse(chars);//de la coada la cap
        string reversed = new string(chars);
        return normalized == reversed;
    }
    static void Main()
    {
        Console.WriteLine(IsPalindrome("Ana"));                         
        Console.WriteLine(IsPalindrome("A man a plan a canal Panama"));
        Console.WriteLine(IsPalindrome("Hello"));
        Console.WriteLine("Sula");
    }
}