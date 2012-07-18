using System;

namespace Slb.InversionOptimization.RobotWcfService
{
    public class Inversion : IInversion
    {
        private string name;
        private Guid inversionID;
        private Guid ownerID;
        private string accessCode;
        private Settings settings;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Guid InversionID
        {
            get { return inversionID; }
            set { inversionID = value; }
        }
        

        public Guid OwnerID
        {
            get { return ownerID; }
            set { ownerID = value; }
        }

        public string AccessCode
        {
            get { return accessCode; }
            set { accessCode = value; }
        }

        public Settings Settings
        {
            get { return settings; }
            set { settings = value; }
        }

        public Inversion(Guid ownerID, string accessCode, Settings settings)
        {
            this.ownerID = ownerID;
            this.accessCode = accessCode;
            this.settings = settings;
        }

        public bool CheckAccessCode(string accessCode)
        {
            if (this.accessCode == accessCode)
                return true;
            else
                return false;
        }



        public void ConfigurateSetup()
        {
            throw new NotImplementedException();
        }

        public void GetDataFromInterACT()
        {
            throw new NotImplementedException();
        }
    }
}