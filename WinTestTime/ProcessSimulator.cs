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
        public int MaxTimeDuration { get; set; }

        public int RealTimeDuration { get; set; }



        public ProcessSimulator(int pMaxTimeDuration)
        {
            this.IdProcess = GenProcessId();
            this.MaxTimeDuration = pMaxTimeDuration;
            this.RealTimeDuration = GenTimeDuration();

        }


        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private int GenTimeDuration()
        {
            int res = 0;
            
            res =   RandomNumber(1, (this.MaxTimeDuration <= 0 ? 1 : this.MaxTimeDuration) );
            return res;
        }

        private int GenProcessId()
        {
            int res = 0;
            res = RandomNumber(1, 1000);
            return res;
        }
    }
}
