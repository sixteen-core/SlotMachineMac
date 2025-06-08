using System;
using System.Collections.Generic;

namespace slotMachineMac
{
    public class SlotMachineCommands
    {
        public static void Execute(SlotMachine slotMachine)
        {
            
            Console.WriteLine("Use LIST to see commands");
            
            while (true)
            {
                var input = Console.ReadLine();
                
                switch (input)
                {

                    case "spin":
                        slotMachine.Spin();
                        break;

                    case "s":
                        slotMachine.Spin();
                        break;
                    
                    case "exit":
                        return;
                    
                    default:
                        ShowList();
                        break;
                }

                Console.WriteLine("--");

            }
            
        }

        private static void ShowList()
        {
            Console.WriteLine("Use LIST to see commands");
            Console.WriteLine("Use SPIN to spin the machine");
            Console.WriteLine("Use EXIT to turn off the machine");
        }
    }
}