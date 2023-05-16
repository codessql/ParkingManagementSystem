using System.Text.RegularExpressions;

Console.Write("Please input total number of parking hours: ");
String? input = Console.ReadLine();
int result;

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Input cannot be empty");
}
else if (!Regex.IsMatch(input, @"^\d+$")) {
    Console.WriteLine("Input must be a positive integer");
}
else {
    int numberOfHours = int.Parse(input);

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