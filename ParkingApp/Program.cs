﻿using System.Text.RegularExpressions;
using System.Globalization;

Console.Write("Please input start time: ");
String? startTime = Console.ReadLine();
Console.Write("Please input end time: ");
String? endTime = Console.ReadLine();
decimal result;
DateTime startTimeValue, endTimeValue;

if (string.IsNullOrEmpty(startTime) || string.IsNullOrEmpty(endTime))
{
    Console.WriteLine("Input cannot be empty");
}
else if (!DateTime.TryParseExact(startTime, "dd/MM/yyyy hh:mm:ss tt", new CultureInfo("en-US"), DateTimeStyles.None, out startTimeValue)) {
    Console.WriteLine("Please input valid start time");
}
else if (!DateTime.TryParseExact(endTime, "dd/MM/yyyy hh:mm:ss tt", new CultureInfo("en-US"), DateTimeStyles.None, out endTimeValue)) {
    Console.WriteLine("Please input valid end time");
}
else {
    startTimeValue = DateTime.ParseExact(startTime, "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
    endTimeValue = DateTime.ParseExact(endTime, "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
    int numberOfHours = (int)Math.Ceiling((endTimeValue - startTimeValue).TotalHours);

    decimal firstHourRate = Math.Round(2 * 1.10M, 2);
    decimal secondAndThirdHourRate = Math.Round(3 * 1.10M, 2);
    decimal fourthAndAboveHourRate = Math.Round(5 * 1.10M, 2);
    decimal dailyRate = Math.Round(70 * 1.10M, 2);

    if (numberOfHours ==  0) {
        result = 0;
    }
    else if (numberOfHours == 1) {
        result = firstHourRate;
    }
    else if (numberOfHours == 2) {
        result = firstHourRate + secondAndThirdHourRate;
    }
    else if (numberOfHours == 3) {
        result = firstHourRate + secondAndThirdHourRate * 2;
    }
    else if (numberOfHours < 24) {
        if (firstHourRate + secondAndThirdHourRate * 2 + fourthAndAboveHourRate * (numberOfHours - 3) > dailyRate) {
            result = dailyRate;
        }
        else {
            result = firstHourRate + secondAndThirdHourRate * 2 + fourthAndAboveHourRate * (numberOfHours - 3);
        }
    }
    else {
        decimal remainingHoursFees;
        if (numberOfHours % 24 * fourthAndAboveHourRate > dailyRate) {
            remainingHoursFees = dailyRate;
        }
        else {
            remainingHoursFees = numberOfHours % 24 * fourthAndAboveHourRate;
        }
        result = (numberOfHours / 24) * dailyRate + remainingHoursFees;
    }

    Console.WriteLine($"Total parking fees: ${result.ToString("0.00")}");
}