using System;
using System.Collections.Generic;

namespace Slb.InversionOptimization.RobotWcfService
{
    public class Robot : IRobot
    {
        public IInversion Inversion { get; set; }

        //owner inversion Map
        IDictionary<Guid, IInversion> _ownerInversionLookup = new Dictionary<Guid, IInversion>();
        //accessCode inversion Map
        IDictionary<string, IInversion> _accessInversionLookup = new Dictionary<string, IInversion>();
        //inversionID userID Map
        IDictionary<Guid, Guid> _inversionUserLookup = new Dictionary<Guid, Guid>();

        private List<byte[]> GetFileData(Guid inversionId, string accessCode)
        {
            throw new NotImplementedException();
        }


        public Guid InitInversion(Settings settingsRequest, Guid ownerId)
        {
            throw new NotImplementedException();
        }

        public bool StartInversion(Guid ownerId, Guid inversionId)
        {
            throw new NotImplementedException();
        }

        public bool StopInversion(Guid ownerId, Guid inversionId)
        {
            throw new NotImplementedException();
        }


        public List<Inversion> QueryInversion(Guid wellId)
        {
            throw new NotImplementedException();
        }

        public bool RetrieveInversion(Guid inversionId, string accessCode)
        {
            throw new NotImplementedException();
        }

        public void UploadFile(FileUploadMessage request)
        {
            throw new NotImplementedException();
        }

        public void UploadFile(Settings request)
        {
            throw new NotImplementedException();
        }
    }
}
