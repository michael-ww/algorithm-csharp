namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode766Test
{
    [Fact]
    public void IsToeplitzMatrix_ValidInput_ReturnBoolean()
    {
        // Given
        int[][] matrix = { [1, 2, 3, 4], [5, 1, 2, 3], [9, 5, 1, 2] };

        // When
        bool answer = new LeetCode766().IsToeplitzMatrix(matrix);

        // Then
        Assert.True(answer);
    }
}
