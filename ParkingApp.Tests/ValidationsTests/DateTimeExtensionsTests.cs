using ParkingApp.Validations;

public class DateTimeExtensionsTests
{
    [Fact]
    public void DateTimeExtensions_StartTimeNull_ThrowsException()
    {
        // Arrange
        string? startTime = null;

        // Act
        Action action = () => startTime.IsValid();

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message);
    }

    [Fact]
    public void DateTimeExtensions_EndTimeNull_ThrowsException()
    {
        // Arrange
        string? endTime = null;

        // Act
        Action action = () => endTime.IsValid();

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void DateTimeExtensions_StartTimeEmpty_ThrowsException()
    {
        // Arrange
        string startTime = "";

        // Act
        Action action = () => startTime.IsValid();

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void DateTimeExtensions_EndTimeEmpty_ThrowsException()
    {
        // Arrange
        string endTime = "";

        // Act
        Action action = () => endTime.IsValid();

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void DateTimeExtensions_StartTimeInvalid_ThrowsException()
    {
        // Arrange
        string startTime = "abcde";

        // Act
        Action action = () => startTime.ConvertToDateTime();

        // Assert
        InvalidCastException exception = Assert.Throws<InvalidCastException>(action);
        Assert.Equal("Please input valid date time", exception.Message); 
    }

    [Fact]
    public void DateTimeExtensions_EndTimeInvalid_ThrowsException()
    {
        // Arrange
        string endTime = "abcde";

        // Act
        Action action = () => endTime.ConvertToDateTime();

        // Assert
        InvalidCastException exception = Assert.Throws<InvalidCastException>(action);
        Assert.Equal("Please input valid date time", exception.Message); 
    }

    [Fact]
    public void DateTimeExtensions_StartTimeGreaterThanEndTime_ThrowsException()
    {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 00:00:00 AM";

        // Act
        DateTime startTimeValue = startTime.ConvertToDateTime();
        DateTime endTimeValue = endTime.ConvertToDateTime();
        Action action = () => startTimeValue.IsValidTimeDifference(endTimeValue);

        // Assert
        InvalidDataException exception = Assert.Throws<InvalidDataException>(action);
        Assert.Equal("Invalid start and end time", exception.Message); 
    }
}