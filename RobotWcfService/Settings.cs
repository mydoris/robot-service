using System;
using System.IO;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Slb.InversionOptimization.RobotWcfService
{
    [DataContract]
    public class Settings
    {
        private string _fileName;
        private Guid _inversionId;
        private byte[] _bha;
        private byte[] _setup;
        private byte[] _connections;

        [DataMember]
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        [DataMember]
        public Guid InversionId
        {
            get { return _inversionId; }
            set { _inversionId = value; }
        }

        [DataMember]
        public byte[] Bha
        {
            get { return _bha; }
            set { _bha = value; }
        }

        [DataMember]
        public byte[] Setup
        {
            get { return _setup; }
            set { _setup = value; }
        }

        [DataMember]
        public byte[] Connections
        {
            get { return _connections; }
            set { _connections = value; }
        }
    }
}
