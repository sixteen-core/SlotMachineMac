using Xunit;
using slotMachineMac;

namespace SlotMachineTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var slotMachine = new slotMachineMac.SlotMachine();
            Assert.NotNull(slotMachine);
        }
    }
}