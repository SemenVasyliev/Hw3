#pragma warning disable IDE0160
using System.Linq;

namespace Hw3.Exercise4;
#pragma warning restore IDE0160

public static class WordsFinder
{
    public static List<string>? FindWords(string word, List<string> listOfWords)
    {
        var result = from w in listOfWords
                     where CheckEqual(w, word)
                     select w;
        return result.ToList();

    }

    private static bool CheckEqual(string s, string w)
    {
        var sl = s.OrderBy(ss => ss);
        var wl = w.OrderBy(ww => ww);
        return sl.SequenceEqual(wl);
    }
}
