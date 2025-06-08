using System.Collections.Generic;

namespace slotMachineMac
{
    public class SlotBand
    {
        public List<string> Symbols { get; }

        public SlotBand(List<string> symbols)
        {
            Symbols = symbols;
        }
    }
}