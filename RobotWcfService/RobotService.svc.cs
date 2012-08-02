using System;
using System.Collections;
using System.Collections.Generic;

namespace Slb.InversionOptimization.RobotWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RobotService" in code, svc and config file together.
    public class RobotService : IRobotService
    {
        
        private readonly IRobot _robot;

        public RobotService()
        {
            _robot = new Robot();
        }


        public Guid InitInversion(Guid ownerId, Settings settings)
        {
            return _robot.InitInversion(ownerId, settings);
        }

        public bool StartInversion(Guid ownerId, Guid inversionId)
        {
            return _robot.StartInversion(ownerId, inversionId);
        }

        public bool StopInversion(Guid ownerId, Guid inversionId)
        {
            return _robot.StopInversion(ownerId, inversionId);
        }

        public IList<IInversion> QueryInversion(Guid wellId)
        {
            return _robot.QueryInversion(wellId);
        }

        public IInversion RetrieveInversion(Guid userId, Guid inversionId, string accessCode)
        {
            return _robot.RetrieveInversion(userId, inversionId, accessCode);
        }

    }
}
