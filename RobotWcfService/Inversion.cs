using System;
using System.ComponentModel;
using System.IO;

namespace Slb.InversionOptimization.RobotWcfService
{
    public class Inversion : IInversion
    {
        private Guid _inversionId;
        private string _name;
        private Guid _ownerId;
        private Settings _settings;
        private readonly string _accessCode;
        private Guid _wellId;
        
        // Adapter for cluster
        private SchedulerAdapter _schedulerAdpt;

        private BackgroundWorker _backgroundworker1;
        private BackgroundWorker _backgroundWorker2;

        private DirectoryInfo _input;
        private DirectoryInfo _output;

        public Guid InversionId
        {
            get { return _inversionId; }
            set { _inversionId = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Guid OwnerId
        {
            get { return _ownerId; }
            set { _ownerId = value; }
        }

        public Guid WellId
        {
            get { return _wellId; }
            set { _wellId = value; }
        }


        public Inversion(){}
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="settings"></param>
        public Inversion(Guid ownerId, Settings settings)
        {
            _inversionId = Guid.NewGuid();
            // TODO  how to define the name ???
            _name = ownerId.ToString() + InversionId.ToString();
            _ownerId = ownerId;
            _settings = settings;
            // TODO how to generate the accessCode
            _accessCode = Guid.NewGuid().ToString();
            _wellId = GetWellId(_settings);

            _backgroundworker1 = new BackgroundWorker();
            _backgroundworker1.DoWork += new DoWorkEventHandler(_backgroundworker1_DoWork);
            _backgroundworker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_backgroundworker1_RunWorkerCompleted);

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

        /// <summary>
        /// Owner gets accessCode
        /// </summary>
        /// <param name="ownerId"></param>
        /// <returns></returns>
        public string GetAccessCode(Guid ownerId)
        {
            if (_ownerId == ownerId)
                return _accessCode;
            return null;
        }

        public void GetDataFromInterAct()
        {
            throw new NotImplementedException();
        }

        public bool Start()
        {
            // ##################################
            // Start the download operation in the background
            // Send the downloaded files to cluseter through SchedulerAdapter
            _backgroundworker1.RunWorkerAsync();

            _input = ConfigurateSettings(_settings);
            GetDataFromInterAct();
            _schedulerAdpt.Send(_input);

            return true;
        }

        public bool Stop()
        {
            // ##################################
            // Cancel the asynchronous operation.
            _backgroundworker1.CancelAsync();

            return _schedulerAdpt.Stop();
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

            return _input;
        }

        private void GetFiles()
        {
            
        }

        private void SaveFiles(Settings settingsRequest)
        {
            string uploadFolder = @"C:\Robot\";

            string dateString = DateTime.Now.ToShortDateString() + @"\";
            string fileName = _settings.FileName;
            string inversionId = InversionId.ToString();
            Stream sourceStream = _settings.Bha;
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


        /// <summary>
        /// Get wellId from Settings
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        private Guid GetWellId(Settings settings)
        {

            //TODO how to get wellId ?????????  from InterAct ??????
            return Guid.NewGuid();
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