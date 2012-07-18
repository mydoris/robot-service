using System;
using System.Collections.Generic;

namespace Slb.InversionOptimization.RobotWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RobotService" in code, svc and config file together.
    public class RobotService : IRobotService
    {
        public void UploadFile(FileUploadMessage request)
        {
            throw new NotImplementedException();
        }

        public bool InitInversion(Guid wellID, Guid inversionID, Guid ownerID)
        {
            throw new NotImplementedException();
        }

        public bool StartInversion(Guid ownerID, Guid inversionID)
        {
            throw new NotImplementedException();
        }

        public bool StopInversion(Guid ownerID, Guid inversionID)
        {
            throw new NotImplementedException();
        }

        public IDictionary<Guid, IInversion> QueryInversion(Guid wellID)
        {
            throw new NotImplementedException();
        }

        public bool RetrieveInversion(Guid inversionID, string accessCode)
        {
            throw new NotImplementedException();
        }
    }
}
