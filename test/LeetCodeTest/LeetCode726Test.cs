namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode726Test
{
    [Fact]
    public void CountOfAtoms_ValidInput_ReturnCount()
    {
        // Given
        string formula1 = "H2O", formula2 = "Mg(OH)2", formula3 = "K4(ON(SO3)2)2";

        // When
        LeetCode726 leetCode726 = new();
        string answer1 = leetCode726.CountOfAtoms(formula1);
        string answer2 = leetCode726.CountOfAtoms(formula2);
        string answer3 = leetCode726.CountOfAtoms(formula3);

        // Then
        Assert.Equal("H2O", answer1);
        Assert.Equal("H2MgO2", answer2);
        Assert.Equal("K4N2O14S4", answer3);

    }
}