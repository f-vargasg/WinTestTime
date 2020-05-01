using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTestTime
{
    class LogProcess
    {
        private const string FMT_DATE = "dd/MM/yyyy HH:mm:ss";
        public ProcessSimulator ProcessExecute { get; set; }
        public DateTime DtInic { get; set; }
        public DateTime DtFin { get; set; }

        public int WaitTime { get; set; }


        public LogProcess()
        {
            this.ProcessExecute = null;
            this.DtInic = DateTime.Now;
            this.DtFin = DateTime.Now;
            this.WaitTime = 0;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pProcessExecute"></param>
        public LogProcess(ProcessSimulator pProcessExecute)
        {
            this.ProcessExecute = pProcessExecute;
            this.DtFin = this.DtInic = DateTime.Now;
        }


        public override string ToString()
        {
            return "[Pid: " + this.ProcessExecute.IdProcess.ToString() + Environment.NewLine +
                    "duracion: " + this.ProcessExecute.RealTimeDuration.ToString() + Environment.NewLine +
                    "Fec.Inic: " + this.DtInic.ToString(FMT_DATE) + Environment.NewLine +
                    "Fec.Fin: " + this.DtFin.ToString(FMT_DATE) + Environment.NewLine +
                    "Tiempo Espera: " + this.WaitTime.ToString() +  "]";
        }

    }
}
