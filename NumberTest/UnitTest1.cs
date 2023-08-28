namespace NumberTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(SourceProvider))]
        public void WhenDivideTwoNumbers_ThenReturnDivisionOfTwoNumbers(int a, int b, int expected)
        {

            // Act
            var actual = a / b;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<int[]> SourceProvider()
        {
            // Arrange
            yield return new int[] { 300, 100, 3 };
            yield return new int[] { 400, 200, 2 };
            yield return new int[] { 100, 100, 1 };
            yield return new int[] { 400, 100, 4 };
            yield return new int[] { 300, 50, 6 };
            yield return new int[] { 400, 20, 20 };
            yield return new int[] { 30, 10, 3 };
            yield return new int[] { 500, 100, 5 };
            yield return new int[] { 300, 100, 3 };
            yield return new int[] { 400, 200, 1 };
            yield return new int[] { 300, 100, 3 };
            yield return new int[] { 400, 200, 8 };
        }
    }
}