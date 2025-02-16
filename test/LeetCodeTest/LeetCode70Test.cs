namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode70Test
{
    [Fact]
    public void ClimbStairs_ValidInput_ReturnWays()
    {
        // Given
        int n1 = 7, n2 = 10, n3 = 23;

        // When
        int answer1 = new LeetCode70().ClimbStairs1(n1);
        int answer2 = new LeetCode70().ClimbStairs2(n1);
        int answer3 = new LeetCode70().ClimbStairs3(n1);
        int answer4 = new LeetCode70().ClimbStairs4(n1);

        int answer5 = new LeetCode70().ClimbStairs1(n2);
        int answer6 = new LeetCode70().ClimbStairs2(n2);
        int answer7 = new LeetCode70().ClimbStairs3(n2);
        int answer8 = new LeetCode70().ClimbStairs4(n2);


        int answer9 = new LeetCode70().ClimbStairs1(n3);
        int answer10 = new LeetCode70().ClimbStairs2(n3);
        int answer11 = new LeetCode70().ClimbStairs3(n3);
        int answer12 = new LeetCode70().ClimbStairs4(n3);



        // Then
        Assert.Equal(21, answer1);
        Assert.Equal(21, answer2);
        Assert.Equal(21, answer3);
        Assert.Equal(21, answer4);

        Assert.Equal(89, answer5);
        Assert.Equal(89, answer6);
        Assert.Equal(89, answer7);
        Assert.Equal(89, answer8);

        Assert.Equal(46368, answer9);
        Assert.Equal(46368, answer10);
        Assert.Equal(46368, answer11);
        Assert.Equal(46368, answer12);

    }
}
