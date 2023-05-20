using System.Text.RegularExpressions;
using System.Globalization;

Console.Write("Please input start time: ");
String? startTime = Console.ReadLine();
Console.Write("Please input end time: ");
String? endTime = Console.ReadLine();
int result;
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

    if (numberOfHours ==  0) {
        result = 0;
    }
    else if (numberOfHours == 1) {
        result = 2;
    }
    else if (numberOfHours == 2) {
        result = 2 + 3;
    }
    else if (numberOfHours == 3) {
        result = 2 + 3 * 2;
    }
    else {
        result = 2 + 3 * 2 + 5 * (numberOfHours - 3);
    }

    Console.WriteLine($"Total parking fees: ${result}");
}