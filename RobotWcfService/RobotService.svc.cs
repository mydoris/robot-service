using System;
using System.Collections.Generic;

namespace Slb.InversionOptimization.RobotWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RobotService" in code, svc and config file together.
    public class RobotService : IRobotService
    {
        
        private IRobot robot;

        public RobotService()
        {
            robot = new Robot();
        }

        public Guid InitInversion(Settings request, Guid ownerId)
        {
            return robot.InitInversion(request, ownerId);
        }

        public bool StartInversion(Guid ownerId, Guid inversionId)
        {
            return robot.StartInversion(ownerId, inversionId);
        }

        public bool StopInversion(Guid ownerId, Guid inversionId)
        {
            return robot.StopInversion(ownerId, inversionId);
        }

        public List<Inversion> QueryInversion(Guid wellId)
        {
            return robot.QueryInversion(wellId);
        }

        public bool RetrieveInversion(Guid inversionId, string accessCode)
        {
            return robot.RetrieveInversion(inversionId, accessCode);
        }

    }
}
