using FluentAssertions;
using Logic;

namespace TestCar
{
    public class UnitTest
    {
        [Theory]
        [InlineData(100, 200, $"RPM: 600 r/min. Torque: 900 nm")]
        [InlineData(100, 250, $"RPM: 700 r/min. Torque: 1050 nm")]
        [InlineData(100, 300, $"RPM: 800 r/min. Torque: 1200 nm")]

        public void TestCarIndicator(int air, int gas, string indication)
        {
            IEngine engineLS216 = new EngineLS216();
            Carting carting = new Carting(engineLS216);
            carting.GetIndicators(new FlammableMixture { Air = air, Gas = gas }).Should().Be(indication);
        }
    }
}