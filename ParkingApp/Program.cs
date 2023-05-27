using System;

Console.Write("Please input start time: ");
String? startTime = Console.ReadLine();
Console.Write("Please input end time: ");
String? endTime = Console.ReadLine();

ParkingFeesCalculator parkingFeesCalculator = new ParkingFeesCalculator();
try
{
    decimal result = parkingFeesCalculator.CalculateParkingFees(startTime, endTime);
    Console.WriteLine($"Total parking fees: ${result.ToString("0.00")}");
}
catch (Exception ex)
{
    if (ex is ArgumentException || ex is InvalidCastException || ex is InvalidDataException)
    {
        Console.WriteLine(ex.Message);
        return;
    }
    throw;
}