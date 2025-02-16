namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode85Test
{
    [Fact]
    public void MaximalRectangle_ValidInput_ReturnMaximalRectangleArea()
    {
        // Arrange

        // Act
        LeetCode85 leetCode85 = new();
        int answer = leetCode85.MaximalRectangle(new int[,] { { 1, 0, 1, 0, 0 }, { 1, 0, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 0, 0, 1, 0 } });

        // Assert
        Assert.Equal(6, answer);
    }
}
