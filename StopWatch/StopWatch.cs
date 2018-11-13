using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
    class StopWatch
    {
        private DateTime _startTime { get; set; }
        private DateTime _stopTime { get; set; }

        private bool _running = false;


        public void Start(DateTime start)
        {
            if (!_running)
            {
                _startTime = start;
                _running = true;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch is already running");
            }        
        }


        public void Stop(DateTime stop)
        {
            if (_running)
            {
                _stopTime = stop;
                _running = false;
            }
        }

        public TimeSpan GetInterval()
        {
            var durationTime = _stopTime - _startTime;
            return durationTime;
        }
        

    }
}
