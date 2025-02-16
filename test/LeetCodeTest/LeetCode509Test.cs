namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode509Test
{
    [Fact]
    public void Fibonacci_ValidInput_ReturnResult()
    {
        // Given

        // When
        LeetCode509 leetCode509 = new();
        int answer1 = leetCode509.Fibonacci1(5);
        int answer2 = leetCode509.Fibonacci2(5);
        int answer3 = leetCode509.Fibonacci3(5);
        int answer4 = leetCode509.Fibonacci4(5);

        // Then
        Assert.Equal(5, answer1);
        Assert.Equal(answer1, answer2);
        Assert.Equal(answer3, answer4);
        Assert.Equal(answer1, answer4);
    }
}
