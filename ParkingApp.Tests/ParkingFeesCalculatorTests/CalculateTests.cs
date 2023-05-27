public class CalculateTests {
    ParkingFeesCalculator parkingFeesCalculator = new ParkingFeesCalculator();

    [Fact]
    public void Calculate_1Hour_Returns1HourFees() {
        // Arrange
        int numberOfHours = 1;

        // Act
        decimal result = parkingFeesCalculator.Calculate(numberOfHours);

        // Assert
        Assert.Equal(2.20M, result);
    }

    [Fact]
    public void Calculate_2Hours_Returns2HoursFees() {
        // Arrange
        int numberOfHours = 2;

        // Act
        decimal result = parkingFeesCalculator.Calculate(numberOfHours);

        // Assert
        Assert.Equal(5.50M, result);
    }

    [Fact]
    public void Calculate_3Hours_Returns3HoursFees() {
        // Arrange
        int numberOfHours = 3;

        // Act
        decimal result = parkingFeesCalculator.Calculate(numberOfHours);

        // Assert
        Assert.Equal(8.80M, result);
    }

    [Fact]
    public void Calculate_4Hours_Returns4HoursFees() {
        // Arrange
        int numberOfHours = 4;

        // Act
        decimal result = parkingFeesCalculator.Calculate(numberOfHours);

        // Assert
        Assert.Equal(14.30M, result);
    }

    [Fact]
    public void Calculate_5Hours_Returns5HoursFees() {
        // Arrange
        int numberOfHours = 5;

        // Act
        decimal result = parkingFeesCalculator.Calculate(numberOfHours);

        // Assert
        Assert.Equal(19.80M, result);
    }

    [Fact]
    public void Calculate_23Hours_ReturnsDailyFees() {
        // Arrange
        int numberOfHours = 23;

        // Act
        decimal result = parkingFeesCalculator.Calculate(numberOfHours);

        // Assert
        Assert.Equal(77.00M, result);
    }

    [Fact]
    public void Calculate_27Hours_Returns27HoursFees() {
        // Arrange
        int numberOfHours = 27;

        // Act
        decimal result = parkingFeesCalculator.Calculate(numberOfHours);

        // Assert
        Assert.Equal(93.50M, result);
    }

    [Fact]
    public void Calculate_47Hours_Returns2DaysFees() {
        // Arrange
        int numberOfHours = 47;

        // Act
        decimal result = parkingFeesCalculator.Calculate(numberOfHours);

        // Assert
        Assert.Equal(154.00M, result);
    }

    [Fact]
    public void Calculate_52Hours_Returns52HoursFees() {
        // Arrange
        int numberOfHours = 52;

        // Act
        decimal result = parkingFeesCalculator.Calculate(numberOfHours);

        // Assert
        Assert.Equal(176.00M, result);
    }
}