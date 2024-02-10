using System.Net.NetworkInformation;

namespace Logic
{
    public class EngineLS216 : IEngine
    {
        public PhysicalMovingParameters Working(FlammableMixture flammableMixture)
        {
            PhysicalMovingParameters physicalMovingParameters = new PhysicalMovingParameters();

            physicalMovingParameters.RPM = flammableMixture.Air * 2 + flammableMixture.Gas * 2;
            physicalMovingParameters.Torque = flammableMixture.Air * 3 + flammableMixture.Gas * 3;

            return physicalMovingParameters;
        }
    }
}
