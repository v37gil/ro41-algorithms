public static class TextTools
{
    public static int CountWords(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        int count = 0;
        bool inWord = false;

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsWhiteSpace(s[i]))
            {
                inWord = false;
            }
            else
            {
                if (!inWord)
                {
                    count++;
                    inWord = true;
                }
            }
        }

        return count;
    }

    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return true;

        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && char.IsWhiteSpace(s[left]))
                left++;

            while (left < right && char.IsWhiteSpace(s[right]))
                right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }

    public static string Initials(string fullName)
    {
        if (string.IsNullOrEmpty(fullName))
            return "";

        StringBuilder sb = new StringBuilder();
        bool inWord = false;

        for (int i = 0; i < fullName.Length; i++)
        {
            if (char.IsWhiteSpace(fullName[i]))
            {
                inWord = false;
            }
            else
            {
                if (!inWord)
                {
                    char firstChar = char.ToUpper(fullName[i]);
                    if (sb.Length > 0)
                        sb.Append(" ");
                    
                    sb.Append(firstChar).Append(".");
                    inWord = true;
                }
            }
        }

        return sb.ToString();
    }

    public static string Repeat(string s, int n)
    {
        if (string.IsNullOrEmpty(s) || n <= 0)
            return "";

        StringBuilder sb = new StringBuilder(s.Length * n);
        for (int i = 0; i < n; i++)
        {
            sb.Append(s);
        }

        return sb.ToString();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ТЕСТ: CountWords ===");
        Test("CountWords", "", "0", TextTools.CountWords("").ToString());
        Test("CountWords", "   ", "0", TextTools.CountWords("   ").ToString());
        Test("CountWords", " a b ", "2", TextTools.CountWords(" a b ").ToString());
        Test("CountWords", "А роза упала на лапу Азора", "6", TextTools.CountWords("А роза упала на лапу Азора").ToString());
        Test("CountWords", "Ахметов Ерлан", "2", TextTools.CountWords("Ахметов Ерлан").ToString());

        Console.WriteLine("\n=== ТЕСТ: IsPalindrome ===");
        Test("IsPalindrome", "", "True", TextTools.IsPalindrome("").ToString());
        Test("IsPalindrome", "   ", "True", TextTools.IsPalindrome("   ").ToString());
        Test("IsPalindrome", " a b ", "False", TextTools.IsPalindrome(" a b ").ToString());
        Test("IsPalindrome", "А роза упала на лапу Азора", "True", TextTools.IsPalindrome("А роза упала на лапу Азора").ToString());
        Test("IsPalindrome", "Ахметов Ерлан", "False", TextTools.IsPalindrome("Ахметов Ерлан").ToString());

        Console.WriteLine("\n=== ТЕСТ: Initials ===");
        Test("Initials", "", "", TextTools.Initials(""));
        Test("Initials", "   ", "", TextTools.Initials("   "));
        Test("Initials", " a b ", "A. B.", TextTools.Initials(" a b "));
        Test("Initials", "Ахметов Ерлан Серикулы", "А. Е. С.", TextTools.Initials("Ахметов Ерлан Серикулы"));
        Test("Initials", "Ахметов Ерлан", "А. Е.", TextTools.Initials("Ахметов Ерлан"));

        Console.WriteLine("\n=== ТЕСТ: Repeat (n = 2) ===");
        Test("Repeat", "", "", TextTools.Repeat("", 2));
        Test("Repeat", " ", "  ", TextTools.Repeat(" ", 2));
        Test("Repeat", " a b ", " a b  a b ", TextTools.Repeat(" a b ", 2));
        Test("Repeat", "Ахметов Ерлан", "Ахметов ЕрланАхметов Ерлан", TextTools.Repeat("Ахметов Ерлан", 2));
    }

    static void Test(string methodName, string input, string expected, string actual)
    {
        string status = (expected == actual) ? "OK" : "FAIL";
        Console.WriteLine($"[{methodName}] Вход: \"{input}\" | Ожидаемое: \"{expected}\" | Фактическое: \"{actual}\" -> {status}");
    }
}
