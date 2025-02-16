namespace Belly.Algorithm.LeetCodeTest;

public class PaperFoldingTest
{
    [Fact]
    public void PrintCrease_ValidInput_PrintCrease()
    {
        // Given
        int maxDepth = 3;

        // When
        PaperFolding paperFolding = new();
        string print = paperFolding.PrintCrease(maxDepth);

        // Then
        Assert.Equal("down down up down down up up", print);
    }
}
