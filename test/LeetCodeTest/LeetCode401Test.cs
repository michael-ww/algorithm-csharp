namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode401Test
{
    [Fact]
    public void ReadBinaryWatch_ValidInput_ReturnTimes()
    {
        // Given

        // When
        LeetCode401 leetCode401 = new();
        IList<string> answer11 = leetCode401.ReadBinaryWatch1(1);
        IList<string> anser12 = leetCode401.ReadBinaryWatch1(9);
        IList<string> answer21 = leetCode401.ReadBinaryWatch2(1);
        IList<string> answer22 = leetCode401.ReadBinaryWatch2(9);

        // Then
        Assert.Equal(10, answer11.Count);
        Assert.Contains("0:01", answer11);
        Assert.Contains("0:02", answer11);
        Assert.Contains("0:04", answer11);
        Assert.Contains("0:08", answer11);
        Assert.Contains("0:16", answer11);
        Assert.Contains("0:32", answer11);
        Assert.Contains("1:00", answer11);
        Assert.Contains("2:00", answer11);
        Assert.Contains("4:00", answer11);
        Assert.Contains("8:00", answer11);

        Assert.Empty(anser12);

        Assert.Equal(10, answer21.Count);
        Assert.Contains("0:01", answer21);
        Assert.Contains("0:02", answer21);
        Assert.Contains("0:04", answer21);
        Assert.Contains("0:08", answer21);
        Assert.Contains("0:16", answer21);
        Assert.Contains("0:32", answer21);
        Assert.Contains("1:00", answer21);
        Assert.Contains("2:00", answer21);
        Assert.Contains("4:00", answer21);
        Assert.Contains("8:00", answer21);

        Assert.Empty(answer22);

    }
}
