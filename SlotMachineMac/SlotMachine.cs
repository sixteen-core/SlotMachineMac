using System;
using System.Collections.Generic;
using System.Threading;

namespace slotMachineMac
{
    public class SlotMachine
    {

        private readonly Random _random = new Random();
        private readonly MachineScreen machineScreen = new();
        private readonly MachineLogic machineLogic = new();
        
        public void Spin()
        {

          Console.WriteLine("machine spinning!");

          machineLogic.GetFirstRowSymbols();
          machineLogic.GatherPositionsAnArrangeColumnsOfSymbols();
          machineLogic.CalculateSlotWays();
          machineLogic.CalculateWinnings();

          machineScreen.PrintFirstRowSymbols();
          machineScreen.PrintColumnSymbols();
          machineScreen.PrintColumnWayResults();
          machineScreen.PrintTotalMoneyAmount();

        }
    }
}