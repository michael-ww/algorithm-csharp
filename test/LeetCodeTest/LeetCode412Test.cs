namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode412Test
{
    [Fact]
    public void FizzBuzz_ValidInput_ReturnArray()
    {
        // Given

        // When
        LeetCode412 leetCode412 = new();
        IList<string> answer1 = leetCode412.FizzBuzz(3);
        IList<string> answer2 = leetCode412.FizzBuzz(5);
        IList<string> answer3 = leetCode412.FizzBuzz(15);

        // Then
        Assert.Equal(3, answer1.Count);
        Assert.Contains("Fizz", answer1);
        Assert.Contains("1", answer1);
        Assert.Contains("2", answer1);

        Assert.Equal(5, answer2.Count);
        Assert.Contains("Fizz", answer2);
        Assert.Contains("1", answer2);
        Assert.Contains("2", answer2);
        Assert.Contains("4", answer2);
        Assert.Contains("Buzz", answer2);

        Assert.Equal(15, answer3.Count);
        Assert.Contains("FizzBuzz", answer3);

    }
}
