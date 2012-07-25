﻿using System;
using System.IO;

namespace Slb.InversionOptimization.RobotWcfService
{
    public class Inversion : IInversion
    {
        private Settings _settingsRequest;
        private Guid _ownerId;
        private Guid _inversionId;

        private string _name;
        private string _accessCode;

        private DirectoryInfo _input;
        private DirectoryInfo _output;

        public string Name
        {
            get { return _name; } 
        }

        public Guid OwnerId
        {
            get { return _ownerId; }
        }

        public Settings SettingsRequest
        {
            get { return _settingsRequest; }
            set { _settingsRequest = value; }
        }

        public Guid InversionId
        {
            get { return _inversionId; }
        }

        public DirectoryInfo Input
        {
            get { return _input; }
            set { _input = value; }
        }

        public DirectoryInfo Output
        {
            get { return _output; }
            set { _output = value; }
        }


        public Inversion(){}

        public Inversion(Guid ownerId, Settings settingsRequest)
        {
            _ownerId = ownerId;
            _settingsRequest = settingsRequest;
            _accessCode = Guid.NewGuid().ToString();
            _inversionId = Guid.NewGuid();
            _name = ownerId.ToString() + _inversionId.ToString();

        }

        public bool CheckAccessCode(string accessCode)
        {
            if (_accessCode == accessCode)
                return true;
            else
                return false;
        }

        public void GetDataFromInterAct()
        {
            throw new NotImplementedException();
        }

        public DirectoryInfo ConfigurateSettings()
        {
            GetBHA();
            GetChannels();
            GetSetup();
            SaveFiles();

            return Input;

        }

        private void SaveFiles()
        {
            throw new NotImplementedException();
        }

        private void GetChannels()
        {
            throw new NotImplementedException();
        }

        private void GetBHA()
        {
            throw new NotImplementedException();
        }

        private void GetSetup()
        {
            throw new NotImplementedException();
        }


    }

}