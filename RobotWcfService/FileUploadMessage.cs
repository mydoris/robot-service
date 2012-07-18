using System.IO;
using System.ServiceModel;

namespace Slb.InversionOptimization.RobotWcfService
{
    [MessageContract]
    public class FileUploadMessage
    {
        [MessageHeader(MustUnderstand = true)]
        public string SavePath;

        [MessageHeader(MustUnderstand = true)]
        public string FileName;

        [MessageBodyMember(Order = 1)]
        public Stream FileData;

    }
}