namespace Algorithm.LeetCode;

public class LeetCode127
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(beginWord);
        ArgumentException.ThrowIfNullOrWhiteSpace(endWord);
        ArgumentNullException.ThrowIfNull(wordList);
        ArgumentOutOfRangeException.ThrowIfNotEqual(beginWord.Length, endWord.Length);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(wordList.Count);

        return 0;
    }
}
