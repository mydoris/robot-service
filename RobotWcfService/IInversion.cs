using System;

namespace Slb.InversionOptimization.RobotWcfService
{
    public interface IInversion
    {

        /// <summary>
        /// Check if user's accessCode matches Inversion's accessCode or not
        /// </summary>
        /// <param name="accessCode"></param>
        /// <returns>True or False</returns>
        bool CheckAccessCode(String accessCode);

        void ConfigurateSetup();

        void GetDataFromInterAct();



    }
}
