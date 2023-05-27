public class CalculateTests {
    ParkingFeesCalculator parkingFeesCalculator = new ParkingFeesCalculator();

    [Fact]
    public void Calculate_LessThan1Hour_Returns1HourFees() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 19, 1, 15, 0);

        // Act
        decimal result = parkingFeesCalculator.Calculate(startTime, endTime);

        // Assert
        Assert.Equal(2.20M, result);
    }

    [Fact]
    public void Calculate_1Hour_Returns1HourFees() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 19, 2, 0, 0);

        // Act
        decimal result = parkingFeesCalculator.Calculate(startTime, endTime);

        // Assert
        Assert.Equal(2.20M, result);
    }

    [Fact]
    public void Calculate_2Hours_Returns2HoursFees() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 19, 3, 0, 0);

        // Act
        decimal result = parkingFeesCalculator.Calculate(startTime, endTime);

        // Assert
        Assert.Equal(5.50M, result);
    }

    [Fact]
    public void Calculate_3Hours_Returns3HoursFees() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 19, 4, 0, 0);

        // Act
        decimal result = parkingFeesCalculator.Calculate(startTime, endTime);

        // Assert
        Assert.Equal(8.80M, result);
    }

    [Fact]
    public void Calculate_4Hours_Returns4HoursFees() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 19, 5, 0, 0);

        // Act
        decimal result = parkingFeesCalculator.Calculate(startTime, endTime);

        // Assert
        Assert.Equal(14.30M, result);
    }

    [Fact]
    public void Calculate_5Hours_Returns5HoursFees() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 19, 6, 0, 0);

        // Act
        decimal result = parkingFeesCalculator.Calculate(startTime, endTime);

        // Assert
        Assert.Equal(19.80M, result);
    }

    [Fact]
    public void Calculate_23Hours_ReturnsDailyFees() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 20, 0, 0, 0);

        // Act
        decimal result = parkingFeesCalculator.Calculate(startTime, endTime);

        // Assert
        Assert.Equal(77.00M, result);
    }

    [Fact]
    public void Calculate_27Hours_Returns27HoursFees() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 20, 4, 0, 0);

        // Act
        decimal result = parkingFeesCalculator.Calculate(startTime, endTime);

        // Assert
        Assert.Equal(93.50M, result);
    }

    [Fact]
    public void Calculate_47Hours_Returns2DaysFees() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 21, 0, 0, 0);

        // Act
        decimal result = parkingFeesCalculator.Calculate(startTime, endTime);

        // Assert
        Assert.Equal(154.00M, result);
    }

    [Fact]
    public void Calculate_52Hours_Returns52HoursFees() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 21, 5, 0, 0);

        // Act
        decimal result = parkingFeesCalculator.Calculate(startTime, endTime);

        // Assert
        Assert.Equal(176.00M, result);
    }
}