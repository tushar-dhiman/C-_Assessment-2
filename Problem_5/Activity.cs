namespace Problem_5
{
    public class Activity : IActivity
    {
        private string _name;

        public Activity(string name)
        {
            _name = name;
        }

        public void execute()
        {
            Console.WriteLine($"Executing Activity: {_name}");
        }
    }
}