using slotMachineMac;

namespace SlotMachineTests
{
    public class SlotMachineTest
    {
        [Fact]
        public void TheSlotMachineCanBeCreatedAsAnObject()
        {
            var slotMachine = new SlotMachine();
            Assert.NotNull(slotMachine);
        }

        [Fact]
        public void TheSlotMachineCanSpin()
        {
            var slotMachine = new SlotMachine();
            var spin = slotMachine.Spin();
            Assert.True(spin);
        }

        [Fact]
        public void CalculateWinningsFunctionIsCalculatingTheCorrectPaymentAmount()
        {

            var machineLogic = new MachineLogic();
            MachineLogic.result = new List<string[]>
            {
                // HERE YOU CAN TEST ANY COMBINATION OF SYMBOLS AND RESULTS
                // ARRAY: [SYMBOL, RESULTS, MAX COLUMN REACHED MULTIPLIER]
                new[] { "sym8", "2" , "4" }
            };

            machineLogic.CalculateWinnings();

            Assert.Equal(40, MachineLogic.totalWinnings);

        }
    }
}