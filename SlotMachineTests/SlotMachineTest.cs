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
                // ARRAY: [SYMBOL, WAYS MATCH, MAX COLUMN REACHED for MULTIPLIER]
                new[] { "sym8", "2" , "4" }
            };

            machineLogic.CalculateWinnings();

            Assert.Equal(40, MachineLogic.totalWinnings);

        }


    [Fact]
    public void TestATotalWinningsCalculation()
    {

        var machineLogic = new MachineLogic();
        MachineLogic.result = new List<string[]>
        {
            new[] { "sym8", "2" , "4" }, //  total = 40
            new[] { "sym2", "2" , "3" }, //  total = 2
            new[] { "sym5", "1" , "5" }  //  total = 15
            // GRAND TOTAL = 40 + 2 + 15 = 57
        };

        machineLogic.CalculateWinnings();

        Assert.Equal(57, MachineLogic.totalWinnings);

    }
}

}