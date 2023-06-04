using System;

Console.Write("Please input start time: ");
String? startTime = Console.ReadLine();
Console.Write("Please input end time: ");
String? endTime = Console.ReadLine();

try
{
    decimal result = ParkingFeesFacade.CalculateParkingFees(startTime, endTime);
    Console.WriteLine($"Total parking fees: ${result.ToString("0.00")}");
}
catch
{
    return;
}