using static System.Console;
using System.Text.RegularExpressions;
using Codewars;
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(IsSolved(new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } }));
    }


    /// <summary>
    /// https://www.codewars.com/kata/525caa5c1bf619d28c000335
    /// </summary>
    /// <param name="board"></param>
    /// <returns></returns>
    public static int IsSolved(int[,] board)
    {
        bool isWin = false;
        static bool IsWin(int a, int b, int c) => (a == b && b == c && a !=0) ? true : false;
        List<int> field = new List<int>();
        foreach (var item in board)
        {
            field.Add(item);
        }
        if (isWin = IsWin(field[0], field[1], field[2]))
            return field[0];
        else if (isWin = IsWin(field[3], field[4], field[5]))
            return field[3];
        else if (isWin = IsWin(field[6], field[7], field[8]))
            return field[0];
        else if (isWin = IsWin(field[0], field[3], field[6]))
            return field[0];
        else if (isWin = IsWin(field[1], field[4], field[7]))
            return field[1];
        else if (isWin = IsWin(field[2], field[5], field[8]))
            return field[2];
        else if (isWin = IsWin(field[0], field[4], field[8]))
            return field[0];
        else if (isWin = IsWin(field[6], field[4], field[2]))
            return field[6];

        if(isWin == false && field.Contains(0))
            return -1;
        else
            return 0;
    }


    /// <summary>
    /// https://www.codewars.com/kata/5208f99aee097e6552000148/
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string BreakCamelCase(string str)
    {
        string newString = "";
        foreach (var ch in str)
        {
            if (Char.IsUpper(ch))
            {
                newString += $" {ch}";
            }
            else
            {
                newString += ch;
            }
        }
        return newString;
    }
    /// <summary>
    /// https://www.codewars.com/kata/545cedaa9943f7fe7b000048
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static bool IsPangram(string str)
    {
        Dictionary<char, char> latters = new Dictionary<char, char>();
        foreach (var item in str.ToLower())
        {
            if (Char.IsLetter(item))
            {
                latters.TryAdd(item, item);
            }
        }
        if (latters.Count == 26)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// https://www.codewars.com/kata/515decfd9dcfc23bb6000006/train/csharp
    /// </summary>
    /// <param name="ipAddres"></param>
    /// <returns></returns>
    public static bool IsValidIp(string ipAddres)
    {
        Regex rgx = new Regex(@"^((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\.){3}(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])$");
        return rgx.Match(ipAddres).Success;
    }

    /// <summary>
    /// https://www.codewars.com/kata/52597aa56021e91c93000cb0
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
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

    /// <summary>
    /// https://www.codewars.com/kata/546f922b54af40e1e90001da
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
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
    /// <summary>
    /// https://www.codewars.com/kata/52fba66badcd10859f00097e
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
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

    /// <summary>
    /// https://www.codewars.com/kata/517abf86da9663f1d2000003
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
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

    /// <summary>
    /// https://www.codewars.com/kata/5390bac347d09b7da40006f6
    /// </summary>
    /// <param name="phrase"></param>
    /// <returns></returns>
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

    /// <summary>
    /// https://www.codewars.com/kata/541c8630095125aba6000c00
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
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

    /// <summary>
    /// https://www.codewars.com/kata/5601c5f6ba804403c7000004
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <returns></returns>
    public static double[] BarTriang(double[] x, double[] y, double[] z)
    {
        return new double[]{
        Math.Round((x[0]+y[0]+z[0])/3, 4),
        Math.Round((x[1]+y[1]+z[1])/3, 4),
        };
    }
}