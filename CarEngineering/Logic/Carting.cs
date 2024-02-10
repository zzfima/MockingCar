namespace Logic
{
    public class Carting
    {
        private IEngine _engine;

        public Carting(IEngine engine)
        {
            _engine = engine;
        }

        public string GetIndicators(FlammableMixture flammableMixture)
        {
            var physicalMovingParameters = _engine.Working(flammableMixture);
            return $"RPM: {physicalMovingParameters.RPM} r/min. Torque: {physicalMovingParameters.Torque} nm";
        }
    }
}
