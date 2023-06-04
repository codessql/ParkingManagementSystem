public class ParkingFeesFacadeTests
{
    [Fact]
    public void ParkingFeesFacade_StartTimeNull_ThrowsException()
    {
        // Arrange
        string? startTime = null;
        string endTime = "19/05/2023 01:00:00 AM";

        // Act
        Action action = () => ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message);
    }

    [Fact]
    public void ParkingFeesFacade_EndTimeNull_ThrowsException()
    {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string? endTime = null;

        // Act
        Action action = () => ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void ParkingFeesFacade_StartTimeAndEndTimeNull_ThrowsException()
    {
        // Arrange
        string? startTime = null;
        string? endTime = null;

        // Act
        Action action = () => ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void ParkingFeesFacade_StartTimeEmpty_ThrowsException()
    {
        // Arrange
        string startTime = "";
        string endTime = "19/05/2023 01:00:00 AM";

        // Act
        Action action = () => ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void ParkingFeesFacade_EndTimeEmpty_ThrowsException()
    {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "";

        // Act
        Action action = () => ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void ParkingFeesFacade_StartTimeAndEndTimeEmpty_ThrowsException()
    {
        // Arrange
        string startTime = "";
        string endTime = "";

        // Act
        Action action = () => ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void ParkingFeesFacade_StartTimeInvalid_ThrowsException()
    {
        // Arrange
        string startTime = "abcde";
        string endTime = "19/05/2023 01:00:00 AM";

        // Act
        Action action = () => ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        InvalidCastException exception = Assert.Throws<InvalidCastException>(action);
        Assert.Equal("Please input valid date time", exception.Message); 
    }

    [Fact]
    public void ParkingFeesFacade_EndTimeInvalid_ThrowsException()
    {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "abcde";

        // Act
        Action action = () => ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        InvalidCastException exception = Assert.Throws<InvalidCastException>(action);
        Assert.Equal("Please input valid date time", exception.Message); 
    }

    [Fact]
    public void ParkingFeesFacade_StartTimeAndEndTimeInvalid_ThrowsException()
    {
        // Arrange
        string startTime = "vwxyz";
        string endTime = "abcde";

        // Act
        Action action = () => ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        InvalidCastException exception = Assert.Throws<InvalidCastException>(action);
        Assert.Equal("Please input valid date time", exception.Message); 
    }

    [Fact]
    public void ParkingFeesFacade_StartTimeGreaterThanEndTime_ThrowsException()
    {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 00:00:00 AM";

        // Act
        Action action = () => ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        InvalidDataException exception = Assert.Throws<InvalidDataException>(action);
        Assert.Equal("Invalid start and end time", exception.Message); 
    }

    [Fact]
    public void ParkingFeesFacade_1Hour_Returns1HourFees() {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 02:00:00 AM";

        // Act
        decimal result = ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        Assert.Equal(2.20M, result);
    }

    [Fact]
    public void ParkingFeesFacade_2Hours_Returns2HoursFees() {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 03:00:00 AM";

        // Act
        decimal result = ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        Assert.Equal(5.50M, result);
    }

    [Fact]
    public void ParkingFeesFacade_3Hours_Returns3HoursFees() {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 04:00:00 AM";

        // Act
        decimal result = ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        Assert.Equal(8.80M, result);
    }

    [Fact]
    public void ParkingFeesFacade_4Hours_Returns4HoursFees() {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 05:00:00 AM";

        // Act
        decimal result = ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        Assert.Equal(14.30M, result);
    }

    [Fact]
    public void ParkingFeesFacade_5Hours_Returns5HoursFees() {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 06:00:00 AM";

        // Act
        decimal result = ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        Assert.Equal(19.80M, result);
    }

    [Fact]
    public void ParkingFeesFacade_23Hours_ReturnsDailyFees() {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "20/05/2023 00:00:00 AM";

        // Act
        decimal result = ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        Assert.Equal(77.00M, result);
    }

    [Fact]
    public void ParkingFeesFacade_27Hours_Returns27HoursFees() {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "20/05/2023 04:00:00 AM";

        // Act
        decimal result = ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        Assert.Equal(93.50M, result);
    }

    [Fact]
    public void ParkingFeesFacade_47Hours_Returns2DaysFees() {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "21/05/2023 00:00:00 AM";

        // Act
        decimal result = ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        Assert.Equal(154.00M, result);
    }

    [Fact]
    public void ParkingFeesFacade_52Hours_Returns52HoursFees() {
        // Arrange
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "21/05/2023 05:00:00 AM";

        // Act
        decimal result = ParkingFeesFacade.CalculateParkingFees(startTime, endTime);

        // Assert
        Assert.Equal(176.00M, result);
    }
}