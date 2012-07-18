using System;

namespace Slb.InversionOptimization.RobotWcfService
{
    public class Inversion : IInversion
    {
        private string _accessCode;

        private string _name;
        public string Name
        {
            get { return _name; } 
        }

        private Guid _ownerId;
        public Guid OwnerId
        {
            get { return _ownerId; }
        }

        private Settings _settings;
        public Settings Settings
        {
            get { return _settings; }
            set { _settings = value; }
        }

        public Inversion()
        {
        }

        public Inversion(Guid ownerId, string accessCode, Settings settings)
        {
            this._ownerId = ownerId;
            this._accessCode = accessCode;
            this._settings = settings;
        }

        public bool CheckAccessCode(string accessCode)
        {
            if (this._accessCode == accessCode)
                return true;
            else
                return false;
        }



        public void ConfigurateSetup()
        {
            throw new NotImplementedException();
        }

        public void GetDataFromInterAct()
        {
            throw new NotImplementedException();
        }
    }
}