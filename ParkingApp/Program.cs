using System;

Console.Write("Please input start time: ");
String? startTime = Console.ReadLine();
Console.Write("Please input end time: ");
String? endTime = Console.ReadLine();

ParkingFeesCalculator parkingFeesCalculator = new ParkingFeesCalculator();
decimal result = parkingFeesCalculator.CalculateParkingFees(startTime, endTime);
Console.WriteLine($"Total parking fees: ${result.ToString("0.00")}");