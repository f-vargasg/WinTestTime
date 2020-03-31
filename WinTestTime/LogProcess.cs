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


        public LogProcess()
        {
            this.ProcessExecute = null;
            this.DtInic = DateTime.Now;
            this.DtFin = DateTime.Now;
        }
        public LogProcess(ProcessSimulator pProcessExecute)
        {
            this.ProcessExecute = pProcessExecute;
            this.DtFin = this.DtInic = DateTime.Now;
        }


        public override string ToString()
        {
            return "[Id: " + this.ProcessExecute.IdProcess.ToString()  + Environment.NewLine + 
                    "duracion: " + this.ProcessExecute.TimeDuration.ToString() + Environment.NewLine +
                    "Fec.Inic: "  + this.DtFin.ToString (FMT_DATE) +
                    "Fec.Fin: " + this.DtFin.ToString(FMT_DATE) + "]";
        }

    }
}
