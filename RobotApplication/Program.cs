using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Slb.InversionOptimization.InversionManagerFormsApplication;
using Slb.InversionOptimization.RobotController.RobotServiceReference;

namespace Slb.InversionOptimization.RobotController
{
    class Program
    {
        InversionManagerForm inversionManagerForm;
        RobotServiceClient robotServiceClient = new RobotServiceClient();

        public Program()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RobotServiceAdapter robotServiceAdapter = new RobotServiceAdapter();
            robotServiceClient = new RobotServiceClient();
            robotServiceAdapter.RobotServiceClient = robotServiceClient;

            inversionManagerForm = new InversionManagerForm(robotServiceAdapter);

        }

        public void Run()
        {
            Application.Run(inversionManagerForm);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
    }
}
