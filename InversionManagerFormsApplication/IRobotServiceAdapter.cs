using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slb.InversionOptimization.InversionManagerFormsApplication
{
    public interface IRobotServiceAdapter
    {
        /// <summary>
        /// Initialize inversion, send settings to Robot
        /// </summary>
        /// <param name="wellID"></param>
        /// <param name="OwnerID"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        bool InitInversion(Guid wellID, Guid inversionID, Guid ownerID);

        /// <summary>
        /// Start an inversion
        /// </summary>
        /// <param name="inversionID"></param>
        /// <returns></returns>
        bool StartInversion(Guid ownerID, Guid inversionID);

        /// <summary>
        /// Stop  an inversion
        /// </summary>
        /// <param name="inversionID"></param>
        /// <returns></returns>
        bool StopInversion(Guid ownerID, Guid inversionID);

        /// <summary>
        /// Query and get all inversions for a well
        /// </summary>
        /// <param name="wellID"></param>
        /// <returns>Dictionary with OwnerID, Inversion pair</returns>
        IDictionary<Guid, IInversion> QueryInversion(Guid wellID);

        /// <summary>
        /// Retrieve an inversion result which includes both Input and Output files
        /// </summary>
        /// <param name="inversionID"></param>
        /// <param name="accessCode"></param>
        /// <returns></returns>
        bool RetrieveInversion(Guid inversionID, string accessCode);

    }
}
