namespace NumberTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenDivideTwoNumbers_ThenReturnDivisionOfTwoNumbers()
        {
            // Arrange
            var a = 300;
            var b = 100;
            var expected = 3;
            // Act
            var actual = a / b;
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}