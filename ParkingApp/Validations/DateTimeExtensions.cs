using System.Globalization;

namespace ParkingApp.Validations;

public static class DateTimeExtensions
{
    public static bool IsValid(this string? dateTime)
    {
        if (string.IsNullOrEmpty(dateTime))
        {
            throw new ArgumentException("Input cannot be empty");
        }
        else
        {
            return true;
        }
    }

    public static DateTime ConvertToDateTime(this string? dateTime)
    {
        DateTime output;
        if (!DateTime.TryParseExact(dateTime, "dd/MM/yyyy hh:mm:ss tt", new CultureInfo("en-US"), DateTimeStyles.None, out output))
        {
            throw new InvalidCastException("Please input valid date time");
        }
        else
        {
            return output;
        }
    }

    public static bool IsValidTimeDifference(this DateTime startTime, DateTime endTime)
    {
        if (endTime < startTime)
        {
            throw new InvalidDataException("Invalid start and end time");
        }
        else
        {
            return true;
        }
    }
}