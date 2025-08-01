namespace Belly.Algorithm.Common;

public class UnionFindSet
{
    private readonly int[] _father;

    public UnionFindSet(int capacity = 64)
    {
        this._father = [capacity];
        for (int i = 0; i < capacity; i++)
        {
            this._father[i] = i;
        }
    }

    public int Find(int x)
    {
        if (x != this._father[x])
        {
            this._father[x] = this.Find(this._father[x]);
        }
        return this._father[x];
    }

    public void Union(int x, int y)
    {
        this._father[this.Find(x)] = this.Find(y);
    }
}
