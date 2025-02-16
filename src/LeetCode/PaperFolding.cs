namespace Belly.Algorithm.LeetCode;

public class PaperFolding
{
    public string PrintCrease(int n)
    {
        if (n <= 0)
        {
            return string.Empty;
        }
        StringBuilder sb = new();
        this.PrintCrease(1, n, true, sb);
        return sb.ToString().Trim();
    }

    public void PrintCrease(int currentDepth, int maxDepth, bool isDown, StringBuilder sb)
    {
        if (currentDepth > maxDepth)
        {
            return;
        }
        this.PrintCrease(currentDepth + 1, maxDepth, true, sb);
        sb.Append(isDown ? " down" : " up");
        this.PrintCrease(currentDepth + 1, maxDepth, false, sb);
    }
}
