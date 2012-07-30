using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Slb.InversionOptimization.RobotLibary;

namespace Slb.InversionOptimization.RobotService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class RobotService : IRobotService
    {
        private IRobot robot;

        public RobotService()
        {
            robot = new Robot();
        }


        public void UploadFile(FileUploadMessage request)
        {
            robot.UploadFile(request);
        }


        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}


        public bool InitInversion(Guid wellID, Guid inversionID, Guid ownerID)
        {
            return robot.InitInversion(wellID, inversionID, ownerID);
        }

        public bool StartInversion(Guid ownerID, Guid inversionID)
        {
            return robot.StartInversion(ownerID, inversionID);
        }

        public bool StopInversion(Guid ownerID, Guid inversionID)
        {
            return robot.StopInversion(ownerID, inversionID);
        }

        public IDictionary<Guid, IInversion> QueryInversion(Guid wellID)
        {
            return robot.QueryInversion(wellID);
        }

        public bool RetrieveInversion(Guid inversionID, string accessCode)
        {
            return robot.RetrieveInversion(inversionID, accessCode);
        }
    }
}
