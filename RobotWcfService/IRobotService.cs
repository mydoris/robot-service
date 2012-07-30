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
        /// Initialize inversion, send settings to RobotService (Upload 3 files to RobotService)
        /// </summary>
        /// <param name="wellID"></param>
        /// <param name="OwnerID"></param>
        /// <param name="settings"></param>
        /// <returns>inversionID</returns>
        [OperationContract]
        Guid InitInversion(Settings settingsRequest, Guid ownerId);

        /// <summary>
        /// Start an inversion
        /// </summary>
        /// <param name="inversionId"></param>
        /// <returns></returns>
        [OperationContract]
        bool StartInversion(Guid ownerId, Guid inversionId);

        /// <summary>
        /// Stop  an inversion
        /// </summary>
        /// <param name="inversionId"></param>
        /// <returns></returns>
        [OperationContract]
        bool StopInversion(Guid ownerId, Guid inversionId);

        /// <summary>
        /// Query and get all inversions for a well
        /// </summary>
        /// <param name="wellId"></param>
        /// <returns>Dictionary with OwnerID, Inversion pair</returns> 
        [OperationContract]
        List<Inversion> QueryInversion(Guid wellId);

        /// <summary>
        /// Retrieve an inversion result which includes both Input and Output files
        /// </summary>
        /// <param name="inversionId"></param>
        /// <param name="accessCode"></param>
        /// <returns></returns>
        [OperationContract]
        bool RetrieveInversion(Guid inversionId, string accessCode);

    }
}
