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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IRobotService : IRobot
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        /// <summary>
        /// Initialize inversion, send settings to Robot
        /// </summary>
        /// <param name="wellID"></param>
        /// <param name="OwnerID"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        [OperationContract]
        bool InitInversion(Guid wellID, Guid inversionID, Guid ownerID);

        /// <summary>
        /// Start an inversion
        /// </summary>
        /// <param name="inversionID"></param>
        /// <returns></returns>
        [OperationContract]
        bool StartInversion(Guid ownerID, Guid inversionID);

        /// <summary>
        /// Stop  an inversion
        /// </summary>
        /// <param name="inversionID"></param>
        /// <returns></returns>
        [OperationContract]
        bool StopInversion(Guid ownerID, Guid inversionID);

        /// <summary>
        /// Query and get all inversions for a well
        /// </summary>
        /// <param name="wellID"></param>
        /// <returns>Dictionary with OwnerID, Inversion pair</returns>
        [OperationContract]
        IDictionary<Guid, IInversion> QueryInversion(Guid wellID);

        /// <summary>
        /// Retrieve an inversion result which includes both Input and Output files
        /// </summary>
        /// <param name="inversionID"></param>
        /// <param name="accessCode"></param>
        /// <returns></returns>
        [OperationContract]
        bool RetrieveInversion(Guid inversionID, string accessCode);

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}


    [MessageContract]
    public class FileUploadMessage
    {
        [MessageHeader(MustUnderstand = true)]
        public string SavePath;

        [MessageHeader(MustUnderstand = true)]
        public string FileName;

        [MessageBodyMember(Order = 1)]
        public Stream FileData;

    }


}
