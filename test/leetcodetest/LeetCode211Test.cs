namespace Algorithm.LeetCodeTest
{
    public class LeetCode211Test
    {
        [Fact]
        public void WordDictionary_ValidInput_ReturnBool()
        {
            // Given

            // When
            WordDictionary wordDictionary = new WordDictionary();
            wordDictionary.AddWord("bad");
            wordDictionary.AddWord("dad");
            wordDictionary.AddWord("mad");
            bool answer1 = wordDictionary.Search("pad");
            bool answer2 = wordDictionary.Search("bad");
            bool answer3 = wordDictionary.Search(".ad");
            bool answer4 = wordDictionary.Search("b..");

            // Then
            Assert.False(answer1);
            Assert.True(answer2);
            Assert.True(answer3);
            Assert.True(answer4);
        }
    }
}