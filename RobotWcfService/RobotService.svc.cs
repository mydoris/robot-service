using System;
using System.Collections.Generic;

namespace Slb.InversionOptimization.RobotWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RobotService" in code, svc and config file together.
    public class RobotService : IRobotService
    {
        private Robot robot;

        public RobotService()
        {
            robot = new Robot();
        }

        public Guid InitInversion(FileUploadMessage request, Guid ownerID)
        {
            return robot.InitInversion(request, ownerID);
        }

        public bool StartInversion(Guid ownerID, Guid inversionID)
        {
            return robot.StartInversion(ownerID, inversionID);
        }

        public bool StopInversion(Guid ownerID, Guid inversionID)
        {
            return robot.StopInversion(ownerID, inversionID);
        }

        public IDictionary<Guid, IInversion> QueryInversion(Guid wellID)
        {
            return robot.QueryInversion(wellID);
        }

        public bool RetrieveInversion(Guid inversionID, string accessCode)
        {
            return robot.RetrieveInversion(inversionID, accessCode);
        }

        public void UploadFile(FileUploadMessage request)
        {
            robot.UploadFile(request);
        }
    }
}
