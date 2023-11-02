using System;

class Program
{
    static void Main(string[] args)
    {
        double heatingRate = 1.0;
        double waterRate = 1.0;
        double gasRate = 1.0;
        double repairRate = 1.0;

        double area = 100.0;
        int residents = 4;
        string season = "зима";
        bool isVeteranTruda = true;
        bool isVeteranVoiny = false;

        double heatingCost = heatingRate * area;
        double waterCost = waterRate * residents;
        double gasCost = gasRate * residents;
        double repairCost = repairRate * area;

        if (season == "зима")
        {
            heatingCost *= 1.5;
        }

        double totalCost = heatingCost + waterCost + gasCost + repairCost;

        if (isVeteranTruda)
        {
            heatingCost *= 0.7;
        }

        if (isVeteranVoiny)
        {
            heatingCost *= 0.5;
        }

        Console.WriteLine("Вид платежа\tНачислено\tЛьготная скидка\tИтого");
        Console.WriteLine($"Отопление\t{heatingCost:F2}\t{(totalCost - heatingCost):F2}\t{heatingCost:F2}");
        Console.WriteLine($"Вода\t\t{waterCost:F2}\t0.00\t\t{waterCost:F2}");
        Console.WriteLine($"Газ\t\t{gasCost:F2}\t0.00\t\t{gasCost:F2}");
        Console.WriteLine($"Ремонт\t\t{repairCost:F2}\t0.00\t\t{repairCost:F2}");
        Console.WriteLine($"Итого\t\t{totalCost:F2}\t{(totalCost - heatingCost):F2}\t{heatingCost:F2}");
    }
}
