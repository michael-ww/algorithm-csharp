namespace Algorithm.LeetCode;

public class LeetCode68
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        IList<string> answer = [];
        this.FullJustify(words, 0, 0, maxWidth, answer);
        return answer;
    }

    private void FullJustify(string[] words, int startIndex, int currentIndex, int leftWidth, IList<string> answer)
    {

    }
}
