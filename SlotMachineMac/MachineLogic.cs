namespace slotMachineMac;

public class MachineLogic
{

    private readonly SlotRoller slotRoller = new();
    public static readonly List<int> firstRowSymbols = new();
    public static readonly List<List<string>> columnsOfSymbols = new();
    public static List<string[]> result = new();
    public static int lastWinAmount;
    public static int totalWinnings;


    public void GetFirstRowSymbols()
    {
        firstRowSymbols.Clear();
        var random = new Random();

        foreach (var band in slotRoller.Bands)
        {
            int stop = random.Next(band.Symbols.Count);
            firstRowSymbols.Add(stop);
        }
    }


    public void GatherPositionsAnArrangeColumnsOfSymbols()
    {
        const int screenLinesToShow = 3;

        var positionIndex = 0;
        int columnIndex = 0;

        ResetColumns();
        ResetResults();

        void ResetLineAndPositionIndex()
        {
            positionIndex = 0;
            columnIndex = 0;
        }

        for (int screenLine = 0; screenLine < screenLinesToShow; screenLine++)
        {
            foreach (var position in firstRowSymbols)
            {
                int nextPosition = (position + screenLine) % slotRoller.Bands[positionIndex].Symbols.Count;
                string symbol = slotRoller.Bands[positionIndex].Symbols[nextPosition];
                columnsOfSymbols[columnIndex].Add(symbol);
                positionIndex++;
                columnIndex++;
            }
            ResetLineAndPositionIndex();
        }
    }


    private void ResetColumns()
    {
        columnsOfSymbols.Clear();
        for (int i = 0; i < firstRowSymbols.Count; i++)
        {
            columnsOfSymbols.Add(new List<string>());
        }
    }

    private void ResetResults()
    {
        result.Clear();
    }


    public void CalculateSlotWays()
    {

        var firstColumn = columnsOfSymbols[0];

        foreach (var symbol in firstColumn) // X3
        {
            var matchInColumns = 0;

            foreach (var column in columnsOfSymbols) // X5
            {
                if (!column.Contains(symbol))
                {
                    break;
                }
                matchInColumns++;
            }

            if (matchInColumns >= 3)
            {
                var ways = 1;

                for (int i = 0; i < matchInColumns; i++)
                {
                    var symbolsInThisColumn = columnsOfSymbols[i].Count(s => s == symbol);
                    ways *= symbolsInThisColumn;
                }

                result.Add(new[] { symbol, ways.ToString(), matchInColumns.ToString()  });

            }
        }
    }


    public void CalculateWinnings()
    {
        foreach (var win in result)
        {
            string symbol = win[0];
            int ways = int.Parse(win[1]);
            int matchingColumns = int.Parse(win[2]);

            if (WinningChart.payTable.ContainsKey(symbol))
            {
                int index = matchingColumns - 3;
                int multiplier = WinningChart.payTable[symbol][index];

                int winningForThisSymbol = ways * multiplier;
                lastWinAmount = winningForThisSymbol;
                totalWinnings += winningForThisSymbol;
                // Console.WriteLine($"Symbol: {symbol}, Ways: {ways}, Multiplier: {multiplier}, Win: {winningForThisSymbol}");
            }
        }
    }






}










