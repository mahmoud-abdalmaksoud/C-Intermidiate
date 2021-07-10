using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PStopWatch
{
    class StopWatch
    {
        private DateTime _tstart;
       private Boolean _timmerRunning;
        
        public void start()
        {
            if (_timmerRunning == true)
                throw new InvalidOperationException("A timmer is already running !");
            else
            {
                _tstart = DateTime.Now;
                _timmerRunning = true;
            }
            }


        public TimeSpan end()
        {
            if (_timmerRunning == false)
                throw new InvalidOperationException("there is no timer running");
            else
            {
                _timmerRunning = false;
                return DateTime.Now - _tstart;
            }
        }
    }
}
