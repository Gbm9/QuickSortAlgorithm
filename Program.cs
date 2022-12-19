using QuickSortAlgorithm;
using System.Globalization;

Console.WriteLine("Welcome to the QuickSortAlgorithm");

List<float> numbersToSort = new();
bool sortNumbers = false;

while (!sortNumbers)
{
    Console.Write("Introduce a number or S to Sort: ");
    string? input = Console.ReadLine();

    if (input is not null && input.ToLower() == "s") sortNumbers = true;

    // Decimal numbers separated with "," not allowed
    if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture,  out float number))
    {
        numbersToSort.Add(number);
        if (numbersToSort.Count >= 10) sortNumbers = true;
    }
    else
    {
        Console.WriteLine("Not a valid number");
    }
}

Console.WriteLine("This is your list of numbers:");

QuickSort.PrintArray(numbersToSort);

QuickSort.SortArray(numbersToSort, 0, numbersToSort.Count - 1);

Console.WriteLine("This is your list of numbers sorted:");

QuickSort.PrintArray(numbersToSort);

Console.Write("Press any key to exit the process...");
Console.ReadKey(false);