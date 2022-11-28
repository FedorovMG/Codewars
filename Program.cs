using static System.Console;
public class Program
{
    private static void Main(string[] args)
    {
        string sey = "The sunset sets at twelve o' clock.";
        var arr = new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1};
        foreach (var item in MoveZeroes(arr))
        {
            Console.WriteLine(item);
        }
        //WriteLine(AlphabetPosition(sey));
        //WriteLine(Disemvowel(sey));
        //WriteLine(ToCamelCase(sey));
        //WriteLine(ToJadenCase(sey));
        //Console.WriteLine(DigitalRoot(16));
    }

    public static int[] MoveZeroes(int[] arr)
    {
        var newArr = new int[arr.Length];
        var query = (from num in arr where num != 0 select num).ToArray();
        for (int i = 0; i < query.Length; i++)
        {
            newArr[i] = query[i];
        }
        return newArr;
    }
    public static string AlphabetPosition(string text)
    {
        List<int> letters = new List<int>();
        foreach (var t in text.ToLower())
        {
            if (Char.IsLetter(t))
            {
                letters.Add((int)t - 96);
            }
        }
        return string.Concat(letters.ToString(), " ");
    }
    public static string Disemvowel(string str)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        string newStr = "";
        foreach (var s in str.ToLower())
        {
            if (!vowels.Contains(s))
            {
                newStr += s;
            }
        }
        return newStr;
    }
    public static string ToCamelCase(string str)
    {
        string[] words = str.Split('-', '_');
        for (int i = 1; i < words.Length; i++)
        {
            char[] word = words[i].ToCharArray();
            word[0] = char.ToUpper(word[0]);
            words[i] = new string(word);
        }
        return string.Concat(words);
    }
    static string ToJadenCase(string phrase)
    {
        string[] words = phrase.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] word = words[i].ToCharArray();
            word[0] = char.ToUpper(word[0]);
            words[i] = new string(word);
        }
        return string.Join(" ", words);
    }
    static int DigitalRoot(long n)
    {
        string nString = n.ToString();
        int rezult = 0;
        if (nString.Length == 1)
        {
            return Int32.Parse(nString);
        }
        else
        {
            foreach (var item in nString)
            {
                rezult += Int32.Parse(item.ToString());
            }
            return DigitalRoot(rezult);
        }
    }
}