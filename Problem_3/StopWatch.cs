namespace Problem_3
{
    public class StopWatch : IStartWatch, IStopWatch
    {

        private bool _isRunning;
        private TimeSpan _startTime;

        public void start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running.");
            }

            _startTime = DateTime.Now.TimeOfDay;
            _isRunning = true;
            Console.WriteLine("Stopwatch started");
        }

        public void stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is not running");
            }

            TimeSpan duration = DateTime.Now.TimeOfDay - _startTime;
            _isRunning = false;
            Console.WriteLine($"Stopwatch stopped. Duration: {duration}");

        }
    }
}