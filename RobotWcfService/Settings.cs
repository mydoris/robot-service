using System;

namespace Slb.InversionOptimization.RobotWcfService
{
    public class Settings
    {
        Guid inversionID;

        public Guid InversionID
        {
            get { return inversionID; }
            set { inversionID = value; }
        }
    }
}
