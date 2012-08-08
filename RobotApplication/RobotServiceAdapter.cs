using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slb.InversionOptimization.InversionManagerFormsApplication;

using Slb.InversionOptimization.RobotController.RobotServiceReference;


namespace Slb.InversionOptimization.RobotController
{
    public class RobotServiceAdapter : IRobotServiceAdapter
    {
        private RobotServiceClient robotServiceClient;

        public RobotServiceClient RobotServiceClient
        {
            get { return robotServiceClient; }
            set { robotServiceClient = value; }
        }



        public bool InitInversion(Guid wellID, Guid inversionID, Guid ownerID)
        {
            //Slb.InversionOptimization.RobotLibary.Settings st = new RobotLibary.Settings();
            //for test, we assign setting's property and instantiate it
            //settings = new InversionManagerFormsApplication.Settings();
            //settings.InversionID = Guid.NewGuid();
            //st.InversionID = settings.InversionID;
            
            return robotServiceClient.InitInversion(wellID, inversionID, ownerID);
        }

        public bool StartInversion(Guid ownerID, Guid inversionID)
        {
            return robotServiceClient.StartInversion(ownerID, inversionID);
        }

        public bool StopInversion(Guid ownerID, Guid inversionID)
        {
            return robotServiceClient.StopInversion(ownerID, inversionID);
        }

        public IDictionary<Guid, InversionManagerFormsApplication.IInversion> QueryInversion(Guid wellID)
        {
            throw new NotImplementedException();
        }

        public bool RetrieveInversion(Guid inversionID, string accessCode)
        {
            return robotServiceClient.RetrieveInversion(inversionID, accessCode);
        }
    }
}
