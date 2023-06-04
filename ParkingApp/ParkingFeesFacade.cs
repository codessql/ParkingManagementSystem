using ParkingApp.Validations;

public static class ParkingFeesFacade
{
    public static decimal CalculateParkingFees(string? startTime, string? endTime)
    {
        ParkingFeesCalculator parkingFeesCalculator = new ParkingFeesCalculator();

        try
        {
            decimal result = default(decimal);

            if (startTime.IsValid() && endTime.IsValid())
            {
                DateTime startTimeValue = startTime.ConvertToDateTime();
                DateTime endTimeValue = endTime.ConvertToDateTime();

                if (startTimeValue.IsValidTimeDifference(endTimeValue))
                {
                    DateTimeProcessor dateTimeProcessor = new DateTimeProcessor();
                    double totalHours = dateTimeProcessor.GetTimeDifferenceInHours(startTimeValue, endTimeValue);
                    int numberOfHours = dateTimeProcessor.RoundUp(totalHours);
                    result = parkingFeesCalculator.Calculate(numberOfHours);
                }
            }

            return result;
        }
        catch (Exception ex)
        {
            if (ex is ArgumentException || ex is InvalidCastException || ex is InvalidDataException)
            {
                Console.WriteLine(ex.Message);
            }
            throw;
        }
    }
}