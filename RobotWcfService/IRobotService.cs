using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Slb.InversionOptimization.RobotWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRobotService" in both code and config file together.
    [ServiceContract]
    public interface IRobotService
    {
        /// <summary>
        /// Initialize inversion, send settings to Robot
        /// </summary>
        /// <param name="wellID"></param>
        /// <param name="OwnerID"></param>
        /// <param name="settings"></param>
        /// <returns>inversionID</returns>
        [OperationContract]
        Guid InitInversion(FileUploadMessage request, Guid ownerID);

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

        /// <summary>
        /// Upload 3 files to RobotService
        /// </summary>
        /// <param name="request"></param>
        [OperationContract(Action = "UploadFile", IsOneWay = true)]
        void UploadFile(FileUploadMessage request);

    }
}
