namespace Algorithm.LeetCodeTest;

public class LeetCode475Test
{
    [Fact]
    public void FindRadius_ValidInput_ReturnRadius()
    {
        // Given
        int[] houses1 = [1, 2, 3], houses2 = [1, 2, 3, 4], houses3 = [1, 5];
        int[] heaters1 = [2], heaters2 = [1, 4], heaters3 = [2];

        // When
        LeetCode475 leetCode475 = new();
        int answer1 = leetCode475.FindRadius(houses1, heaters1);
        int answer2 = leetCode475.FindRadius(houses2, heaters2);
        int answer3 = leetCode475.FindRadius(houses3, heaters3);

        // Then
        Assert.Equal(1, answer1);
        Assert.Equal(1, answer2);
        Assert.Equal(3, answer3);
    }
}
