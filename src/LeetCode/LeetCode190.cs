namespace Belly.Algorithm.LeetCode;

public class LeetCode190
{
    public uint ReverseBits1(uint n)
    {
        uint answer = 0;
        for (int i = 0; i < 32 & n > 0; i++)
        {
            answer = (answer << 1) | (n & 1);
            n >>= 1;
        }

        return answer;
    }

    // 0xff00ff00  11111111000000001111111100000000
    // 0x00ff00ff  00000000111111110000000011111111
    // 0xf0f0f0f0  11110000111100001111000011110000
    // 0x0f0f0f0f  00001111000011110000111100001111
    // 0xcccccccc  11001100110011001100110011001100
    // 0x33333333  00110011001100110011001100110011
    // 0xaaaaaaaa  10101010101010101010101010101010
    // 0x55555555  01010101010101010101010101010101
    public uint ReverseBits2(uint n)
    {
        n = (n >> 16) | (n << 16);
        n = ((n & 0xff00ff00) >> 8) | ((n & 0x00ff00ff) << 8);
        n = ((n & 0xf0f0f0f0) >> 4) | ((n & 0x0f0f0f0f) << 4);
        n = ((n & 0xcccccccc) >> 2) | ((n & 0x33333333) << 2);
        n = ((n & 0xaaaaaaaa) >> 1) | ((n & 0x55555555) << 1);
        return n;
    }

    public uint ReverseBits3(uint n)
    {
        n = ((n >> 1) & 0x55555555) | ((n << 1) & 0x55555555);
        n = ((n >> 2) & 0x33333333) | ((n << 2) & 0x33333333);
        n = ((n >> 4) & 0x0f0f0f0f) | ((n << 4) & 0x0f0f0f0f);
        n = ((n >> 8) & 0x00ff00ff) | ((n << 8) & 0x00ff00ff);
        n = (n >> 16) | (n << 16);
        return n;
    }
}
