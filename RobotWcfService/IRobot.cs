using System;
using System.Collections;
using System.Collections.Generic;

namespace Slb.InversionOptimization.RobotWcfService
{
    public interface IRobot
    {
        /// <summary>
        /// Initialize inversion, send settings to Robot
        /// </summary>
        /// <returns>inversionID</returns>
        Guid InitInversion(Guid ownerId, Settings settings);

        /// <summary>
        /// Start an inversion
        /// </summary>
        /// <param name="ownerId"> </param>
        /// <param name="inversionId"></param>
        /// <returns></returns>
        bool StartInversion(Guid ownerId, Guid inversionId);

        /// <summary>
        /// Stop  an inversion
        /// </summary>
        /// <param name="ownerId"> </param>
        /// <param name="inversionId"></param>
        /// <returns></returns>
        bool StopInversion(Guid ownerId, Guid inversionId);

        /// <summary>
        /// Query and get all inversions for a well
        /// </summary>
        /// <param name="wellId"></param>
        /// <returns>Dictionary with OwnerID, Inversion pair</returns>
        IList<IInversion> QueryInversion(Guid wellId);

        /// <summary>
        /// Retrieve an inversion result which includes both Input and Output files
        /// </summary>
        /// <param name="userId"> </param>
        /// <param name="inversionId"></param>
        /// <param name="accessCode"></param>
        /// <returns></returns>
        IInversion RetrieveInversion(Guid userId, Guid inversionId, string accessCode);
    }
}
