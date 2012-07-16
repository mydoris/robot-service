using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slb.InversionOptimization.InversionManagerFormsApplication
{
    public interface IInversion
    {
        Guid OwnerID { get; }
        string AccessCode { get; set; }
        Settings Settings { get; set; }

        /// <summary>
        /// Check if user's accessCode matches Inversion's accessCode or not
        /// </summary>
        /// <param name="accessCode"></param>
        /// <returns>True or False</returns>
        bool CheckAccessCode(String accessCode);


        Guid InversionID { get; set; }

        string Name { get; set; }
    }
}
