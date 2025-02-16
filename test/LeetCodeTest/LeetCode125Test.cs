namespace Algorithm.LeetCodeTest;

public class LeetCode125Test
{
    [Fact]
    public void IsPalindrome1_ValidInput_ReturnBoolean()
    {
        // Given
        string s1 = "A man, a plan, a canal: Panama";
        string s2 = "race a car";
        string s3 = " ";

        // When
        LeetCode125 leetCode125 = new();
        bool answer11 = leetCode125.IsPalindrome1(s1);
        bool answer12 = leetCode125.IsPalindrome1(s2);
        bool answer13 = leetCode125.IsPalindrome1(s3);
        bool answer21 = leetCode125.IsPalindrome2(s1);
        bool answer22 = leetCode125.IsPalindrome2(s2);
        bool answer23 = leetCode125.IsPalindrome2(s3);
        bool answer31 = leetCode125.IsPalindrome3(s1);
        bool answer32 = leetCode125.IsPalindrome3(s2);
        bool answer33 = leetCode125.IsPalindrome3(s3);

        // Then
        Assert.True(answer11);
        Assert.False(answer12);
        Assert.True(answer13);
        Assert.True(answer21);
        Assert.False(answer22);
        Assert.True(answer23);
        Assert.True(answer31);
        Assert.False(answer32);
        Assert.True(answer33);
    }
}
