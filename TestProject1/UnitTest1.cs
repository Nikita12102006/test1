using Xunit.Sdk;
using Podgotovka;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int prav = 4;
            int fun = Class1.summ(2, 2);
            Assert.Equal(prav, fun);

        }
    }
}