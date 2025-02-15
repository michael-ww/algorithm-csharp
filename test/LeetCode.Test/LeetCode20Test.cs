namespace Algorithm.LeetCode.Test
{
    public class LeetCode20Test
    {
        [Fact]
        public void IsValid_ValidInput_ReturnBool()
        {
            //Arrange
            string s1 = "()";
            string s2 = "[]";
            string s3 = "{}";
            string s4 = "()[]{}";
            string s5 = "{[()]}";
            string s6 = "{[}]";
            string s7 = "{";

            //Act
            LeetCode20 parentheses = new();
            bool isS1Valid = parentheses.IsValid(s1);
            bool isS2Valid = parentheses.IsValid(s2);
            bool isS3Valid = parentheses.IsValid(s3);
            bool isS4Valid = parentheses.IsValid(s4);
            bool isS5Valid = parentheses.IsValid(s5);
            bool isS6Valid = parentheses.IsValid(s6);
            bool isS7Valid = parentheses.IsValid(s7);

            //Assert
            Assert.True(isS1Valid);
            Assert.True(isS2Valid);
            Assert.True(isS3Valid);
            Assert.True(isS4Valid);
            Assert.True(isS5Valid);
            Assert.False(isS6Valid);
            Assert.False(isS7Valid);
        }
    }
}