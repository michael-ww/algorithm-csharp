namespace Algorithm.LeetCode.Test
{
    public class LeetCode677Test
    {
        [Fact]
        public void MapSum_ValidInput_ReturnSum()
        {
            // Given

            // When
            MapSum mapSum = new();
            mapSum.Insert("apple", 3);
            int answer1 = mapSum.Sum("ap");
            mapSum.Insert("app", 2);
            int answer2 = mapSum.Sum("ap");

            // Then
            Assert.Equal(3, answer1);
            Assert.Equal(5, answer2);
        }
    }
}