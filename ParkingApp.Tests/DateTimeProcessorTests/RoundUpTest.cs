public class RoundUpTests {
    DateTimeProcessor dateTimeProcessor = new DateTimeProcessor();

    [Fact]
    public void RoundUp_015_Returns1()
    {
        // Arrange
        double totalHours = 0.15;

        // Act
        int roundUpHours = dateTimeProcessor.RoundUp(totalHours);

        // Assert
        Assert.Equal(1, roundUpHours);
    }

    [Fact]
    public void RoundUp_1_Returns1()
    {
        // Arrange
        double totalHours = 1;

        // Act
        int roundUpHours = dateTimeProcessor.RoundUp(totalHours);

        // Assert
        Assert.Equal(1, roundUpHours);
    }

    [Fact]
    public void RoundUp_115_Returns2()
    {
        // Arrange
        double totalHours = 1.15;

        // Act
        int roundUpHours = dateTimeProcessor.RoundUp(totalHours);

        // Assert
        Assert.Equal(2, roundUpHours);
    }
}