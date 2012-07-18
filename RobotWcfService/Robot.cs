using System;
using System.Collections.Generic;

namespace Slb.InversionOptimization.RobotWcfService
{
    public class Robot : IRobot
    {
        IInversion inversion;

        public IInversion Inversion
        {
            get { return inversion; }
            set { inversion = value; }
        }

        //owner inversion Map
        IDictionary<Guid, IInversion> ownerInversionLookup = new Dictionary<Guid, IInversion>();
        //accessCode inversion Map
        IDictionary<string, IInversion> accessInversionLookup = new Dictionary<string, IInversion>();
        //inversionID userID Map
        IDictionary<Guid, Guid> inversionUserLookup = new Dictionary<Guid, Guid>();

        private List<byte[]> GetFileData(Guid inversionID, string accessCode)
        {
            throw new NotImplementedException();
        }

        public bool InitInversion(Guid wellID, Guid inversionID, Guid ownerID)
        {
            return true;
            //throw new NotImplementedException();
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

        public void UploadFile(FileUploadMessage request)
        {
            throw new NotImplementedException();
        }


        public IInversion CreateInversion(Guid ownerID, string accessCode, Settings settings)
        {
            return new Inversion(ownerID, accessCode, settings);
        }

    }
}
