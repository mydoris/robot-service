using System;
using System.Collections.Generic;

namespace Slb.InversionOptimization.RobotWcfService
{
    public interface IRobot
    {
        /// <summary>
        /// Initialize inversion, send settings to Robot
        /// </summary>
        /// <param name="wellID"></param>
        /// <param name="OwnerID"></param>
        /// <param name="settings"></param>
        /// <param name="request"> </param>
        /// <returns>inversionID</returns>
        Guid InitInversion(Settings settingsRequest, Guid ownerId);

        /// <summary>
        /// Start an inversion
        /// </summary>
        /// <param name="inversionId"></param>
        /// <returns></returns>
        bool StartInversion(Guid ownerId, Guid inversionId);

        /// <summary>
        /// Stop  an inversion
        /// </summary>
        /// <param name="inversionId"></param>
        /// <returns></returns>
        bool StopInversion(Guid ownerId, Guid inversionId);

        /// <summary>
        /// Query and get all inversions for a well
        /// </summary>
        /// <param name="wellId"></param>
        /// <returns>Dictionary with OwnerID, Inversion pair</returns>
        List<IInversion> QueryInversion(Guid wellId);

        /// <summary>
        /// Retrieve an inversion result which includes both Input and Output files
        /// </summary>
        /// <param name="inversionId"></param>
        /// <param name="accessCode"></param>
        /// <returns></returns>
        bool RetrieveInversion(Guid inversionId, string accessCode);


    }
}
