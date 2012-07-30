using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slb.InversionOptimization.InversionManagerFormsApplication
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
