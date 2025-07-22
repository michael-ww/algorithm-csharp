namespace Belly.Algorithm.LeetCode;

public class LeetCode572
{
    public bool IsSubtree1(TreeNode root, TreeNode subRoot)
    {
        if (root != null && subRoot != null)
        {
            return IsSameTree(root, subRoot) || IsSubtree1(root.Left, subRoot) || IsSubtree1(root.Right, subRoot);
        }
        return subRoot == null;
    }

    private bool IsSameTree(TreeNode s, TreeNode t)
    {
        if (s == null && t == null)
        {
            return true;
        }
        if (s != null && t != null)
        {
            return s.Value == t.Value && IsSameTree(s.Left, t.Left) && IsSameTree(s.Right, t.Right);
        }
        return false;
    }

    public bool IsSubtree2(TreeNode root, TreeNode subRoot)
    {
        if (root != null && subRoot != null)
        {
            List<string> rs = [];
            List<string> ss = [];
            SerializePreOrder(root, rs);
            SerializePreOrder(subRoot, ss);
            return Kmp(rs, ss) != -1;
        }

        return subRoot == null;
    }

    private void SerializePreOrder(TreeNode node, List<string> list)
    {
        if (node == null)
        {
            list.Add("null");
        }
        else
        {
            list.Add(node.Value.ToString());
            SerializePreOrder(node.Left, list);
            SerializePreOrder(node.Right, list);
        }
    }

    private int Kmp(List<string> rs, List<string> ss)
    {
        if (rs == null || ss == null || rs.Count < ss.Count)
        {
            return -1;
        }
        int[] next = GetNext(ss);
        int rsIndex = 0, ssIndex = 0;
        while (rsIndex < rs.Count && ssIndex < ss.Count)
        {
            if (ssIndex == -1 || rs[rsIndex] == ss[ssIndex])
            {
                rsIndex++;
                ssIndex++;
            }
            else
            {
                ssIndex = next[ssIndex];
            }
        }

        return ssIndex == ss.Count ? rsIndex - ss.Count : -1;
    }

    private int[] GetNext(List<string> ss)
    {
        int[] next = new int[ss.Count];
        next[0] = -1;
        next[1] = 0;
        int nextIndex = 2, comparingIndex = 0;
        while (nextIndex < ss.Count)
        {
            if (ss[nextIndex] == ss[comparingIndex])
            {
                next[nextIndex++] = ++comparingIndex;
            }
            else if (comparingIndex > 0)
            {
                comparingIndex = next[comparingIndex];
            }
            else
            {
                next[nextIndex++] = 0;
            }
        }

        return next;
    }
}
