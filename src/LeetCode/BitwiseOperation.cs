namespace Belly.Algorithm.LeetCode;

public class BitwiseOperation
{
    public int Flip(int n)
    {
        return n ^ 1;
    }

    //0 negative
    //1 positive
    public int Sign(int n)
    {
        return this.Flip((n >> 31) & 1);
    }

    public int Max1(int a, int b)
    {
        int c = a - b;
        int scA = this.Sign(c);
        int scB = this.Flip(scA);
        //scA 0, scB 1
        //scA 1, scB 0
        return (a * scA) + (b * scB);
    }

    public int Max2(int a, int b)
    {
        int c = a - b;
        int aSign = this.Sign(a);
        int bSign = this.Sign(b);
        int cSign = this.Flip(c);
        int difabSign = aSign ^ bSign;
        int sameabSign = this.Flip(difabSign);
        int returnA = difabSign * aSign + sameabSign * cSign;
        int returnB = this.Flip(returnA);
        return (a * returnA) + (b * returnB);
    }

    public string ByteString(int n)
    {
        StringBuilder sb = new();
        for (int i = 31; i >= 0; i--)
        {
            if ((n & (1 << i)) == 0)
            {
                sb.Append('0');
            }
            else
            {
                sb.Append('1');
            }
        }

        return sb.ToString();
    }
}
