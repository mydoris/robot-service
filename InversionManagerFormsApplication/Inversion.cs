using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slb.InversionOptimization.InversionManagerFormsApplication
{
    public class Inversion : IInversion
    {
        private Guid ownerID;
        private string accessCode;
        private Settings settings;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Guid inversionID;

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


    }
}