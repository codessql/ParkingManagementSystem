public class GetTimeDifferenceInHoursTests {
    DateTimeProcessor dateTimeProcessor = new DateTimeProcessor();
    
    [Fact]
    public void GetTimeDifferenceInHours_2305190100to2305190115_Returns025()
    {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 19, 1, 15, 0);

        // Act
        double totalHours = dateTimeProcessor.GetTimeDifferenceInHours(startTime, endTime);

        // Assert
        Assert.Equal(0.25, totalHours);
    }

    [Fact]
    public void GetTimeDifferenceInHours_2305190100to2305190200_Returns1() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 19, 2, 0, 0);

        // Act
        double totalHours = dateTimeProcessor.GetTimeDifferenceInHours(startTime, endTime);

        // Assert
        Assert.Equal(1, totalHours);
    }

    [Fact]
    public void GetTimeDifferenceInHours_2305190100to2305190300_Returns2() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 19, 3, 0, 0);

        // Act
        double totalHours = dateTimeProcessor.GetTimeDifferenceInHours(startTime, endTime);

        // Assert
        Assert.Equal(2, totalHours);
    }

    [Fact]
    public void GetTimeDifferenceInHours_2305190100to2305190400_Returns3() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 19, 4, 0, 0);

        // Act
        double totalHours = dateTimeProcessor.GetTimeDifferenceInHours(startTime, endTime);

        // Assert
        Assert.Equal(3, totalHours);
    }

    [Fact]
    public void GetTimeDifferenceInHours_2305190100to2305190500_Returns4() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 19, 5, 0, 0);

        // Act
        double totalHours = dateTimeProcessor.GetTimeDifferenceInHours(startTime, endTime);

        // Assert
        Assert.Equal(4, totalHours);
    }

    [Fact]
    public void GetTimeDifferenceInHours_2305190100to2305190600_Returns5() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 19, 6, 0, 0);

        // Act
        double totalHours = dateTimeProcessor.GetTimeDifferenceInHours(startTime, endTime);

        // Assert
        Assert.Equal(5, totalHours);
    }

    [Fact]
    public void GetTimeDifferenceInHours_2305190100to2305200000_Returns23() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 20, 0, 0, 0);

        // Act
        double totalHours = dateTimeProcessor.GetTimeDifferenceInHours(startTime, endTime);

        // Assert
        Assert.Equal(23, totalHours);
    }

    [Fact]
    public void GetTimeDifferenceInHours_2305190100to2305200400_Returns27() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 20, 4, 0, 0);

        // Act
        double totalHours = dateTimeProcessor.GetTimeDifferenceInHours(startTime, endTime);

        // Assert
        Assert.Equal(27, totalHours);
    }

    [Fact]
    public void GetTimeDifferenceInHours_2305190100to2305210000_Returns47() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 21, 0, 0, 0);

        // Act
        double totalHours = dateTimeProcessor.GetTimeDifferenceInHours(startTime, endTime);

        // Assert
        Assert.Equal(47, totalHours);
    }

    [Fact]
    public void GetTimeDifferenceInHours_2305190100to2305210500_Returns52() {
        // Arrange
        DateTime startTime = new DateTime(2023, 5, 19, 1, 0, 0);
        DateTime endTime = new DateTime(2023, 5, 21, 5, 0, 0);

        // Act
        double totalHours = dateTimeProcessor.GetTimeDifferenceInHours(startTime, endTime);

        // Assert
        Assert.Equal(52, totalHours);
    }
}