using System;
using System.Text.RegularExpressions;

// Program to remove vowels from Strings
class RemoveVowels
{
    static String RemVow(String str)
    {
        str = Regex.Replace(str, "[aeiouAEIOU]", "");
        return str;
    }

    // Calling Function Here...
    public static void Main()
    {
        String str = "Hello World - This Is My RemoveVowels Program";
        Console.WriteLine(RemVow(str));
    }
}