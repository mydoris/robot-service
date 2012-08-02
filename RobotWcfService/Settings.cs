using System;
using System.IO;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Slb.InversionOptimization.RobotWcfService
{
    [DataContract]
    public class Settings
    {
        //This could be inversion name
        private string _fileName;
        private Guid _inversionId;

        private Stream _bha;
        private Stream _setup;
        private Stream _connections;

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
        public Stream Bha
        {
            get { return _bha; }
            set { _bha = value; }
        }

        [DataMember]
        public Stream Setup
        {
            get { return _setup; }
            set { _setup = value; }
        }

        [DataMember]
        public Stream Connections
        {
            get { return _connections; }
            set { _connections = value; }
        }
    }
}
