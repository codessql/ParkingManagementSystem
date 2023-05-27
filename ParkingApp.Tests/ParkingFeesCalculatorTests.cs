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
}