using System;
using System.Text.RegularExpressions;

// Program to remove vowels from Strings
class RemoveVowels2
{
    static String RemVow(String str)
    {
        str = str.Replace("a","").Replace("e","").Replace("i","").Replace("o","").Replace("u","").Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", "");
        return str;
    }

    // Calling Function Here...
    public static void Main()
    {
        String str = "Hello World - This Is My RemoveVowels Program";
        Console.WriteLine(RemVow(str));
    }
}