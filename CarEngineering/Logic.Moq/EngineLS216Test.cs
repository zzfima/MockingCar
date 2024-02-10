using Moq;

namespace Logic.Moq
{
    public class EngineLS216Test
    {
        private readonly Carting _sut;
        private readonly Mock<IEngine> _engineMock;

        public EngineLS216Test()
        {
            _engineMock = new Mock<IEngine>();
            _sut = new Carting(_engineMock.Object);
        }

        [Theory]
        [InlineData(100, 200, $"RPM: 600 r/min. Torque: 900 nm")]
        public void GetIndicators_ShouldReturnString(int air, int gas, string indication)
        {
            // Arrange
            var flammable = new FlammableMixture { Air = air, Gas = gas };
            _engineMock.Setup(x => x.Working(flammable)).Returns(new PhysicalMovingParameters()
            {
                RPM = 600,
                Torque = 900
            });

            // Act
            var res = _sut.GetIndicators(flammable);

            // Assert
            res.Should().Be(indication);
        }
    }
}
