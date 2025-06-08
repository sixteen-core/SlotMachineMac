namespace slotMachineMac;

public class MachineScreen
{

    public void PrintFirstRowSymbols()
    {
        Console.WriteLine("Stop Positions: " + string.Join(", ", MachineLogic.firstRowSymbols));
    }

    public void PrintColumnSymbols()
    {
        Console.WriteLine("Screen:");
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                Console.Write(MachineLogic.columnsOfSymbols[col][row] + " ");
            }
            Console.WriteLine();
        }
    }

    public void PrintColumnWayResults()
    {
        Console.WriteLine("Results:");
        if (MachineLogic.result.Any())
        {
            foreach (var result in MachineLogic.result)
            {
                Console.WriteLine("WON!! with " + result[0] + " you got " + result[1] + " ways");
            }
        }
        else
        {
            Console.WriteLine("Keep spinning!");
        }
    }

    public void PrintTotalMoneyAmount()
    {
        Console.WriteLine("Total Winnings: $" + MachineLogic.totalWinnings);
        Console.WriteLine("Last Win Amount: $" + MachineLogic.lastWinAmount);
    }

}