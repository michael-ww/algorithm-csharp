namespace Algorithm.LeetCodeTest
{
    using Xunit.Abstractions;

    public class GiniCoefficientTest
    {
        private readonly ITestOutputHelper output;

        public GiniCoefficientTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Caculate_ValidInput_ReturnGiniCoefficient()
        {
            // Given
            int population = 100, round = 1000000;

            // When
            GiniCoefficient giniCoefficient = new();
            double answer = giniCoefficient.Experiment(population, round);

            // Then
            this.output.WriteLine($"Population:{population},Round:{round},Gini:{answer}");
        }
    }
}