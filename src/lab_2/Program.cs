namespace lab_2;

public class Palindrome
{
    public static void Main()
    {
        try
        {
            string text = "Сьогодні на уроці мови ми обговорювали цікаві властивості слів." +
                          " Наш викладач Пилип розповів, що слово радар читається однаково в обох напрямках. " +
                          "Але справжнім відкриттям став хімічний термін аніліна, який виявився довшим за попередні приклади. " +
                          "Навіть дівчинка Анна помітила, що назва її улюбленого магазину Корок теж має таку властивість." +
                          " Це було схоже на якесь магічне заказне явище.";
            string longestPalindrome = FindLongestPalindrome(text);

            if (string.IsNullOrEmpty(longestPalindrome))
            {
                Console.WriteLine("Palindrome doesn't exist");
            }
            else
            {
                Console.WriteLine($"Initial text: {text}");
                Console.WriteLine($"Longest palindrome: {longestPalindrome}");
                Console.WriteLine($"Length: {longestPalindrome.Length}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    public static string FindLongestPalindrome(string text)
    {
        if (string.IsNullOrEmpty(text)) return "";

        char[] delimiters = { ' ', ',', '.', '!', '?', '-', ':', ';' };
        string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        string longest = "";

        foreach (string word in words)
        {
            if (IsPalindrome(word) && word.Length > longest.Length) longest = word;
        }    
            
        return longest;
    }
    
    public static bool IsPalindrome(string word)
    {
        if (word.Length < 2) return false;

        string cleanWord = word.ToLower();
        int left = 0;
        int right = cleanWord.Length - 1;

        while (left < right)
        {
            if (cleanWord[left] != cleanWord[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}

