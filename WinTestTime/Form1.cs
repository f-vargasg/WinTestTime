using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestTime
{
    public partial class Form1 : Form
    {

        private const string FMT_DATE_TIME = "dd/MM/yyyy HH:mm:ss";

        int timeWaitLoading;

        public Form1()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            txtTimeWait.Text = ConfigurationManager.AppSettings["defTimeWait"];
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            ProcessSimulator ps = new ProcessSimulator();
            if (!processActivateBrgWrk.IsBusy)
            {
                this.timeWaitLoading = Convert.ToInt32(txtTimeWait.Text) * 1000; // miliseconds
                processActivateBrgWrk.RunWorkerAsync();  // Start del work
            }
            else
            {
                MessageBox.Show("La tarea esta ejecutando!!!");
            }
            
        }

        /// <summary>
        /// Handler que se utiliza para hacer el work
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessActivateBrgWrk_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime currentDate;
            //string dateStr;
            //List<Price> argumList = e.Argument as List<Price>;
            // DoWorkLoadParams dwParams = e.Argument as DoWorkLoadParams;

            BackgroundWorker worker = (BackgroundWorker)sender;
            while (!worker.CancellationPending)
            {
                currentDate = DateTime.Now;
                //dateStr = currentDate.ToString("dd/MM/yyyy HH:mm:ss");
                e.Result = currentDate;
                worker.ReportProgress(0, currentDate); // hace que se dispare el evento ProgressChanged
                Thread.Sleep(this.timeWaitLoading);

            }
        }

        private void ProcessActivateBrgWrk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("The task has been cancelled");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error. Details: " + (e.Error as Exception).ToString());
            }
            else
            {
                DateTime dt = Convert.ToDateTime( e.Result);
                MessageBox.Show("The task has been completed. Results: " + dt.ToString(FMT_DATE_TIME));
            }
        }

        private void ProcessActivateBrgWrk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //string logStr = e.UserState as string;
            DateTime dt = Convert.ToDateTime ( e.UserState );
            Console.WriteLine(dt.ToString (FMT_DATE_TIME));
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.processActivateBrgWrk.CancelAsync();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            processActivateBrgWrk.CancelAsync();
        }
    }
}
