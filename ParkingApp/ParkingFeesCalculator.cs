using System;
using System.Text.RegularExpressions;

public class ParkingFeesCalculator
{
    public decimal Calculate(int numberOfHours)
    {
        decimal firstHourRate = Math.Round(2 * 1.10M, 2);
        decimal secondAndThirdHourRate = Math.Round(3 * 1.10M, 2);
        decimal fourthAndAboveHourRate = Math.Round(5 * 1.10M, 2);
        decimal dailyRate = Math.Round(70 * 1.10M, 2);

        decimal result;

        if (numberOfHours == 0)
        {
            result = 0;
        }
        else if (numberOfHours == 1)
        {
            result = firstHourRate;
        }
        else if (numberOfHours == 2)
        {
            result = firstHourRate + secondAndThirdHourRate;
        }
        else if (numberOfHours == 3)
        {
            result = firstHourRate + secondAndThirdHourRate * 2;
        }
        else if (numberOfHours < 24)
        {
            if (firstHourRate + secondAndThirdHourRate * 2 + fourthAndAboveHourRate * (numberOfHours - 3) > dailyRate)
            {
                result = dailyRate;
            }
            else
            {
                result = firstHourRate + secondAndThirdHourRate * 2 + fourthAndAboveHourRate * (numberOfHours - 3);
            }
        }
        else
        {
            decimal remainingHoursFees;
            if (numberOfHours % 24 * fourthAndAboveHourRate > dailyRate)
            {
                remainingHoursFees = dailyRate;
            }
            else
            {
                remainingHoursFees = numberOfHours % 24 * fourthAndAboveHourRate;
            }
            result = (numberOfHours / 24) * dailyRate + remainingHoursFees;
        }

        return result;
    }
}