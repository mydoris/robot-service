using System;

namespace Slb.InversionOptimization.RobotWcfService
{
    public interface IInversion
    {
        Guid OwnerID { get; }
        string AccessCode { get; set; }
        //Settings Settings { get; set; }
        string Name { get; set; }
        Guid InversionID { get; set; }


        /// <summary>
        /// Check if user's accessCode matches Inversion's accessCode or not
        /// </summary>
        /// <param name="accessCode"></param>
        /// <returns>True or False</returns>
        bool CheckAccessCode(String accessCode);

        void ConfigurateSetup();

        void GetDataFromInterACT();



    }
}
