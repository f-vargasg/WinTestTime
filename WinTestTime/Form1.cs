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
            LogProcess logProc = new LogProcess();
            if (!processActivateBrgWrk.IsBusy)
            {
                this.timeWaitLoading = Convert.ToInt32(txtTimeWait.Text); // miliseconds
                processActivateBrgWrk.RunWorkerAsync(logProc);  // Start del work
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
            //DateTime currentDate;
            //int waitTime;
            //string dateStr;
            //List<Price> argumList = e.Argument as List<Price>;
            // DoWorkLoadParams dwParams = e.Argument as DoWorkLoadParams;
            LogProcess logProc = e.Argument as LogProcess;
            
            BackgroundWorker worker = (BackgroundWorker)sender;
            while (!worker.CancellationPending)
            {
                ProcessSimulator ps = new ProcessSimulator();
                logProc.ProcessExecute = ps;
                logProc.DtInic = DateTime.Now;
                Thread.Sleep(ps.TimeDuration * 1000 );
                logProc.DtFin = DateTime.Now;
                //dateStr = currentDate.ToString("dd/MM/yyyy HH:mm:ss");
                e.Result = logProc;   // esto es para que en el evento progress changed poder atrapar
                                      // en el metodo ProcessActivateBrgWrk_RunWorkerCompleted
                worker.ReportProgress(0, logProc); // hace que se dispare el evento ProgressChanged
                TimeSpan ts = logProc.DtFin - logProc.DtInic;
                logProc.WaitTime =  this.timeWaitLoading - ts.Seconds;
                if (logProc.WaitTime <= 0 )
                {
                    logProc.WaitTime = 1;    // espere 1 seg
                }
                int miliSecs = logProc.WaitTime * 1000;
                Thread.Sleep(miliSecs);

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
                LogProcess dt = (LogProcess)(e.Result);
                MessageBox.Show("The task has been completed. Results: " + dt.ToString());
            }
        }

        private void ProcessActivateBrgWrk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //string logStr = e.UserState as string;
            LogProcess logProc = (LogProcess)(e.UserState);
            //Console.WriteLine(dateStr);
            txtOutPut.Text += (logProc.ToString() + Environment.NewLine);

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
