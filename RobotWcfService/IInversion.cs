using System;
using System.IO;

namespace Slb.InversionOptimization.RobotWcfService
{
    public interface IInversion
    {
        Guid OwnerId { get; }
        Settings SettingsRequest { get; set; }
        Guid InversionId { get; }
        string Name { get; }
        bool CheckAccessCode(string accessCode);
        DirectoryInfo ConfigurateSettings();
        void GetDataFromInterAct();
    }
}
