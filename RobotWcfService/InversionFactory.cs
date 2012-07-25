using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slb.InversionOptimization.RobotWcfService
{
    public class InversionFactory
    {
        public static IInversion CreateInversion()
        {
            IInversion inversion = new Inversion();
            return inversion;
        }

        public static IInversion CreateInversion(Settings settings, Guid ownerId)
        {
            IInversion inversion = new Inversion(ownerId, settings);
            return inversion;
        }

    }
}