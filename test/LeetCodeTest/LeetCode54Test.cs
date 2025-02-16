namespace Algorithm.LeetCodeTest;

public class LeetCode54Test
{
    [Fact]
    public void SpiralOrder_ValidInput_ReturnArray()
    {
        // Given

        // When
        LeetCode54 leetCode54 = new();
        IList<int> answer1 = leetCode54.SpiralOrder(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
        IList<int> answer2 = leetCode54.SpiralOrder(new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } });

        // Then
        Assert.Equal([1, 2, 3, 6, 9, 8, 7, 4, 5], answer1);
        Assert.Equal([1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7], answer2);

    }
}
