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
        //DirectoryInfo ConfigurateSettings(Settings settingsRequest);
        void GetDataFromInterAct();
        void Start();
        bool Stop();
        bool Retrieve();
    }
}
