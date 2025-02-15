namespace Algorithm.LeetCode;

public class Bitset
{
    private int[] bits;
    private int size;
    private int ones;
    private int zeros;

    public Bitset(int size)
    {
        this.bits = new int[(size + 31) / 32];
        this.size = size;
        this.ones = 0;
        this.zeros = size;
    }

    public void Fix(int idx)
    {
        if ((this.bits[idx / 32] & (1 << (idx % 32))) == 0)
        {
            this.bits[idx / 32] |= 1 << (idx % 32);
            this.ones++;
            this.zeros--;
        }
    }

    public void Unfix(int idx)
    {
        if ((this.bits[idx / 32] & (1 << (idx % 32))) != 0)
        {
            this.bits[idx / 32] &= ~(1 << (idx % 32));
            this.ones--;
            this.zeros++;
        }
    }

    public bool All()
    {
        return this.ones == this.size;
    }

    public bool One()
    {
        return this.ones > 0;
    }

    public int Count()
    {
        return this.ones;
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        for (int i = 0; i < this.size; i++)
        {
            sb.Append((this.bits[i / 32] & (1 << (i % 32))) != 0 ? "1" : "0");
        }
        return sb.ToString();
    }
}
