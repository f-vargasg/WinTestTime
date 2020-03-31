using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTestTime
{
    class ProcessSimulator
    {
        public int IdProcess { get; set; }
        public int TimeDuration { get; set; }


        public ProcessSimulator()
        {
            this.IdProcess = GenProcessId();
            this.TimeDuration = GenTimeDuration();
        }


        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private int GenTimeDuration()
        {
            int res = 0;
            res = RandomNumber(1, 10);
            return res;
        }

        private int GenProcessId()
        {
            int res = 0;
            res =       RandomNumber(1, 1000);
            return res;
        }
    }
}
