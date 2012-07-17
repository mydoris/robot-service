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
        private IRobot robot = new Robot();

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public void UploadFile(FileUploadMessage request)
        {
            string uploadFolder = @"C:\Inversion\";
            string savaPath = request.SavePath;
            string dateString = DateTime.Now.ToShortDateString() + @"\";
            string fileName = request.FileName;
            Stream sourceStream = request.FileData;
            FileStream targetStream = null;

            if (!sourceStream.CanRead)
            {
                throw new Exception("Stream cannot be read!");
            }
            if (savaPath == null) savaPath = @"Default\";
            if (!savaPath.EndsWith("\\")) savaPath += "\\";

            uploadFolder = uploadFolder + savaPath + dateString;
            if (!Directory.Exists(uploadFolder))
            {
                Directory.CreateDirectory(uploadFolder);
            }

            string filePath = Path.Combine(uploadFolder, fileName);
            using (targetStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //read from the input stream in 4K chunks
                //and save to output stream
                const int bufferLen = 4096;
                byte[] buffer = new byte[bufferLen];
                int count = 0;
                while ((count = sourceStream.Read(buffer, 0, bufferLen)) > 0)
                {
                    targetStream.Write(buffer, 0, count);
                }
                targetStream.Close();
                sourceStream.Close();
            }
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
