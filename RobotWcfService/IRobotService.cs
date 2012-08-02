using System;
using System.Collections;
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
        /// <returns>inversionID</returns>
        [OperationContract]
        Guid InitInversion(Guid ownerId, Settings settings);

        /// <summary>
        /// Start an inversion
        /// </summary>
        /// <param name="ownerId"> </param>
        /// <param name="inversionId"></param>
        /// <returns></returns>
        [OperationContract]
        bool StartInversion(Guid ownerId, Guid inversionId);

        /// <summary>
        /// Stop  an inversion
        /// </summary>
        /// <param name="ownerId"> </param>
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
        IList<IInversion> QueryInversion(Guid wellId);

        /// <summary>
        /// Retrieve an inversion result which includes both Input and Output files
        /// return what?
        /// </summary>
        /// <param name="userId"> </param>
        /// <param name="inversionId"></param>
        /// <param name="accessCode"></param>
        /// <returns></returns>
        [OperationContract]
        IInversion RetrieveInversion(Guid userId, Guid inversionId, string accessCode);

    }
}
