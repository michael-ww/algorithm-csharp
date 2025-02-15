namespace Algorithm.LeetCodeTest
{
    public class LeetCode15Test
    {
        [Fact]
        public void ThreeSum_ValidInput_ReturnList()
        {
            //Arragne

            //Act
            IList<(int n1, int n2, int n3)> answer = new LeetCode15().ThreeSum([-1, 0, 1, 2, -1, -4]);

            //Assert [[-1,-1,2],[-1,0,1]]
            Assert.Equal(-1, answer[0].n1);
            Assert.Equal(0, answer[0].n2);
            Assert.Equal(1, answer[0].n3);
        }
    }
}