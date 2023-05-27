public class DateTimeProcessor
{
    public double GetTimeDifferenceInHours(DateTime startTime, DateTime endTime)
    {
        return (endTime - startTime).TotalHours;
    }

    public int RoundUp(double totalHours)
    {
        return (int)Math.Ceiling(totalHours);
    }
}