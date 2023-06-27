namespace BackDotnet.Tests.UnitTests;

[TestFixture]
public class CalculatorTests
{
    private CalculatorForDummyTests _calculator;

    [SetUp]
    public void SetUp()
    {
        // Arrange: Create an instance of the Calculator class or initialize dependencies
        _calculator = new CalculatorForDummyTests();
    }

    [TearDown]
    public void TearDown()
    {
        // Clean up resources or reset state after each test
    }

    [Test]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Act: Invoke the method being tested
        int result = _calculator.Add(5, 7);

        // Assert: Verify the expected outcome
        Assert.AreEqual(12, result);
    }

    [Test]
    public void Add_NegativeAndPositiveNumber_ReturnsCorrectSum()
    {
        // Act
        int result = _calculator.Add(-3, 9);

        // Assert
        Assert.AreEqual(6, result);
    }

    // More test methods...

}

public class CalculatorForDummyTests
{
    public int Add(int a, int b) => a + b;
}