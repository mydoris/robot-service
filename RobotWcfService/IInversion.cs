using System;
using System.IO;

namespace Slb.InversionOptimization.RobotWcfService
{
    public interface IInversion
    {
        Guid InversionId { get; set; }
        string Name { get; }
        Guid OwnerId { get; set; }
        Guid WellId { get; set; }

        bool CheckAccessCode(string accessCode);
        bool Start();
        bool Stop();

    }
}
