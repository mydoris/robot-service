using System;
using System.Collections.Generic;

namespace Slb.InversionOptimization.RobotWcfService
{
    public class Robot : IRobot
    {
        //owner inversion Map
        IDictionary<Guid, IInversion> _ownerInversionLookup = new Dictionary<Guid, IInversion>();

        //accessCode inversion Map
        IDictionary<string, IInversion> _accessInversionLookup = new Dictionary<string, IInversion>();

        //inversionID userID Map
        IDictionary<Guid, Guid> _inversionUserLookup = new Dictionary<Guid, Guid>();


        //private List<byte[]> GetFileData(Guid inversionId, string accessCode)
        //{
        //    throw new NotImplementedException();
        //}


        public Guid InitInversion(Settings settingsRequest, Guid ownerId)
        {
            IInversion inversion = InversionFactory.CreateInversion( settingsRequest, ownerId);
            _ownerInversionLookup.Add(ownerId, inversion);
            
            return inversion.InversionId;

        }

        public bool StartInversion(Guid ownerId, Guid inversionId)
        {
            IInversion inversion;
            if (_ownerInversionLookup.TryGetValue(ownerId, out inversion))
            {
                inversion.Start();
                return true;
            }
            return false;
        }

        public bool StopInversion(Guid ownerId, Guid inversionId)
        {
            IInversion inversion;
            if (_ownerInversionLookup.TryGetValue(ownerId, out inversion))
                return inversion.Stop();
            return false;
        }


        public List<IInversion> QueryInversion(Guid wellId)
        {

            List<IInversion> inversionList = new List<IInversion>();

            foreach (KeyValuePair<Guid, IInversion> pair in _ownerInversionLookup)
            {
                if (pair.Value.WellId.Equals(wellId))
                {
                    inversionList.Add(pair.Value);
                }
            }
            return inversionList;
            
        }

        public bool RetrieveInversion(Guid inversionId, string accessCode)
        {
            IInversion inversion;
            if (_accessInversionLookup.TryGetValue(accessCode, out inversion))
                return inversion.Retrieve();
            return false;
        }

        //public void UploadFile(FileUploadMessage request)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
