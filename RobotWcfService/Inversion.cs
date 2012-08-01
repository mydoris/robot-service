using System;
using System.ComponentModel;
using System.IO;

namespace Slb.InversionOptimization.RobotWcfService
{
    public class Inversion : IInversion
    {
        private SchedulerAdapter _scAdpt;

        private BackgroundWorker _backgroundworker1;

        private Guid _wellId ;
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

        public Guid WellId
        {
            get { return _wellId; }
            set { _wellId = value; }
        }


        public Inversion(){}

        public Inversion(Guid ownerId, Settings settingsRequest)
        {
            _backgroundworker1 = new BackgroundWorker();
            _backgroundworker1.DoWork += new DoWorkEventHandler(_backgroundworker1_DoWork);
            _backgroundworker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_backgroundworker1_RunWorkerCompleted);

            _ownerId = ownerId;
            _settingsRequest = settingsRequest;
            _accessCode = Guid.NewGuid().ToString();
            _inversionId = Guid.NewGuid();
            
            //Todo  how to get wellId from settings
            WellId = Guid.NewGuid();
            _name = ownerId.ToString() + _inversionId.ToString();
        }


        void _backgroundworker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Occurs when the background operation has completed, has been canceled, or has raised an exception.

            throw new NotImplementedException();
        }

        void _backgroundworker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //get data from InterACT &  call the cluster


            // Do not access the form's BackgroundWorker reference directly.
            // Instead, use the reference provided by the sender parameter.
           // BackgroundWorker bw = sender as BackgroundWorker;









            throw new NotImplementedException();
        }

        public bool CheckAccessCode(string accessCode)
        {
            if (_accessCode == accessCode)
                return true;
            return false;
        }

        public void GetDataFromInterAct()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            // ##################################
            // Start the download operation in the background.
            this._backgroundworker1.RunWorkerAsync();

            _input = ConfigurateSettings(_settingsRequest);
            GetDataFromInterAct();
            _scAdpt.Send(_input);
        }

        public bool Stop()
        {
            // ##################################

            // Cancel the asynchronous operation.
            _backgroundworker1.CancelAsync();

            return _scAdpt.Stop();
            throw new NotImplementedException();
        }

        public bool Retrieve()
        {
            GetFiles();
            throw new NotImplementedException();
        }

        private DirectoryInfo ConfigurateSettings(Settings settingsRequest)
        {
            GetBHA();
            GetChannels();
            GetSetup();
            SaveFiles(null);

            return Input;
        }

        private void GetFiles()
        {
            
        }

        private void SaveFiles(Settings settingsRequest)
        {
            string uploadFolder = @"C:\Robot\";

            string dateString = DateTime.Now.ToShortDateString() + @"\";
            string fileName = _settingsRequest.FileName;
            string inversionId = _inversionId.ToString();
            Stream sourceStream = _settingsRequest.Bha;
            FileStream targetStream = null;

            if (sourceStream == null) throw new ArgumentNullException("sourceStream can't be read.");

            uploadFolder = uploadFolder + dateString;
            if (!Directory.Exists(uploadFolder))
            {
                Directory.CreateDirectory(uploadFolder);
            }

            string filePath = Path.Combine(uploadFolder, inversionId);

            using (targetStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //read from the input stream in 4K chunks
                //and save to output stream
                const int bufferLen = 4096;
                byte[] buffer = new byte[bufferLen];
                int count = 0;
                while ((count = sourceStream.Read(buffer, 0, bufferLen)) > 0)
                {
                    targetStream.Write(buffer, 0, count);
                }
                targetStream.Close();
                sourceStream.Close();
            }

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