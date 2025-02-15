namespace Algorithm.LeetCode;

public class LeetCode126
{
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(beginWord);
        ArgumentException.ThrowIfNullOrWhiteSpace(endWord);
        ArgumentNullException.ThrowIfNull(wordList);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(wordList.Count);
        ArgumentOutOfRangeException.ThrowIfNotEqual(beginWord.Length, endWord.Length);
        ArgumentOutOfRangeException.ThrowIfNotEqual(beginWord.Length, wordList.First().Length);

        IList<IList<string>> answer = new List<IList<string>>();
        return answer;
    }
}