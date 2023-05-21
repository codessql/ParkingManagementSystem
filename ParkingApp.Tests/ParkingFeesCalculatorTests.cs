public class ParkingFeesCalculatorTests {
    ParkingFeesCalculator parkingFeesCalculator = new ParkingFeesCalculator();

    [Fact]
    public void ParkingFeesCalculator_StartTimeNull_ThrowsException()
    {
        // Given
        string? startTime = null;
        string endTime = "19/05/2023 02:00:00 AM";

        // When
        Action action = () => parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        // Then
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void ParkingFeesCalculator_EndTimeNull_ThrowsException()
    {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string? endTime = null;

        // When
        Action action = () => parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        // Then
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void ParkingFeesCalculator_StartTimeEmpty_ThrowsException()
    {
        // Given
        string startTime = "";
        string endTime = "19/05/2023 02:00:00 AM";

        // When
        Action action = () => parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        // Then
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void ParkingFeesCalculator_EndTimeEmpty_ThrowsException()
    {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "";

        // When
        Action action = () => parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        // Then
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void ParkingFeesCalculator_StartTimeAndEndTimeNull_ThrowsException()
    {
        // Given
        string? startTime = null;
        string? endTime = null;

        // When
        Action action = () => parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        // Then
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void ParkingFeesCalculator_StartTimeAndEndTimeEmpty_ThrowsException()
    {
        // Given
        string startTime = "";
        string endTime = "";

        // When
        Action action = () => parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        // Then
        ArgumentException exception = Assert.Throws<ArgumentException>(action);
        Assert.Equal("Input cannot be empty", exception.Message); 
    }

    [Fact]
    public void ParkingFeesCalculator_StartTimeInvalid_ThrowsException()
    {
        // Given
        string startTime = "abcde";
        string endTime = "19/05/2023 02:00:00 AM";

        // When
        Action action = () => parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        // Then
        InvalidCastException exception = Assert.Throws<InvalidCastException>(action);
        Assert.Equal("Please input valid start time", exception.Message); 
    }

    [Fact]
    public void ParkingFeesCalculator_EndTimeInvalid_ThrowsException()
    {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "abcde";

        // When
        Action action = () => parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        // Then
        InvalidCastException exception = Assert.Throws<InvalidCastException>(action);
        Assert.Equal("Please input valid end time", exception.Message); 
    }

    [Fact]
    public void ParkingFeesCalculator_StartTimeGreaterThanEndTime_ThrowsException()
    {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 00:00:00 AM";

        // When
        Action action = () => parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        // Then
        InvalidDataException exception = Assert.Throws<InvalidDataException>(action);
        Assert.Equal("Invalid start and end time", exception.Message); 
    }

    [Fact]
    public void ParkingFeesCalculator_LessThan1Hour_Returns1HourFees() {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 01:15:00 AM";

        decimal result = parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        Assert.Equal(2.20M, result);
    }

    [Fact]
    public void ParkingFeesCalculator_1Hour_Returns1HourFees() {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 02:00:00 AM";

        decimal result = parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        Assert.Equal(2.20M, result);
    }

    [Fact]
    public void ParkingFeesCalculator_2Hours_Returns2HoursFees() {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 03:00:00 AM";

        decimal result = parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        Assert.Equal(5.50M, result);
    }

    [Fact]
    public void ParkingFeesCalculator_3Hours_Returns3HoursFees() {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 04:00:00 AM";

        decimal result = parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        Assert.Equal(8.80M, result);
    }

    [Fact]
    public void ParkingFeesCalculator_4Hours_Returns4HoursFees() {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 05:00:00 AM";

        decimal result = parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        Assert.Equal(14.30M, result);
    }

    [Fact]
    public void ParkingFeesCalculator_5Hours_Returns5HoursFees() {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "19/05/2023 06:00:00 AM";

        decimal result = parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        Assert.Equal(19.80M, result);
    }

    [Fact]
    public void ParkingFeesCalculator_23Hours_ReturnsDailyFees() {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "20/05/2023 00:00:00 AM";

        decimal result = parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        Assert.Equal(77.00M, result);
    }

    [Fact]
    public void ParkingFeesCalculator_27Hours_Returns27HoursFees() {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "20/05/2023 04:00:00 AM";

        decimal result = parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        Assert.Equal(93.50M, result);
    }

    [Fact]
    public void ParkingFeesCalculator_47Hours_Returns2DaysFees() {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "21/05/2023 00:00:00 AM";

        decimal result = parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        Assert.Equal(154.00M, result);
    }

    [Fact]
    public void ParkingFeesCalculator_52Hours_Returns52HoursFees() {
        // Given
        string startTime = "19/05/2023 01:00:00 AM";
        string endTime = "21/05/2023 05:00:00 AM";

        decimal result = parkingFeesCalculator.CalculateParkingFees(startTime, endTime);

        Assert.Equal(176.00M, result);
    }
}