// COPYRIGHTS DANIEL GUEVARA - MONTREAL 2025
using System;

namespace slotMachineMac
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SLOT MACHINE ON");
            SlotMachineCommands.Execute(new SlotMachine());
        }
    }
}