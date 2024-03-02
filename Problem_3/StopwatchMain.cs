namespace Problem_3
{

    class StopWatchMain
    {
        public static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();

            try
            {
                stopWatch.start();

                Thread.Sleep(2000);
                stopWatch.stop();

                stopWatch.start();

                Thread.Sleep(3000);
                stopWatch.stop();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}