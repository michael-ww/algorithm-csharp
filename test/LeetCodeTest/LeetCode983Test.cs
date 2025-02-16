namespace Algorithm.LeetCodeTest;

public class LeetCode983Test
{
    [Fact]
    public void MincostTickets_ValidInput_ReturnMincost()
    {
        // Given
        int[] days1 = [1, 4, 6, 7, 8, 20], costs1 = [2, 7, 15], days2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31], costs2 = [2, 7, 15];

        // When
        LeetCode983 leetCode983 = new();
        int answer11 = leetCode983.MincostTickets1(days1, costs1);
        int answer12 = leetCode983.MincostTickets1(days2, costs2);
        int answer21 = leetCode983.MincostTickets2(days1, costs1);
        int answer22 = leetCode983.MincostTickets2(days2, costs2);
        int answer31 = leetCode983.MincostTickets3(days1, costs1);
        int answer32 = leetCode983.MincostTickets3(days2, costs2);

        // Then
        Assert.Equal(11, answer11);
        Assert.Equal(17, answer12);
        Assert.Equal(11, answer21);
        Assert.Equal(17, answer22);
        Assert.Equal(11, answer31);
        Assert.Equal(17, answer32);

    }
}
