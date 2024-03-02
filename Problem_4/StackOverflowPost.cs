namespace Problem_4
{
    public class StackOverflowPost : IDownVote, IUpVote, IDisplayVotes
    {
        private int _votes;

        public string Title { get; }
        public string Description { get; }
        public DateTime CreationTime { get; }
        public int Votes { get { return _votes; } }

        public StackOverflowPost(string title, string description)
        {
            Title = title;
            Description = description;
            CreationTime = DateTime.Now;
            _votes = 0;
        }

        public void incrementVote()
        {
            _votes++;
        }

        public void decrementVote()
        {
            if (_votes > 0)
            {
                _votes--;
            }

        }

        public void displayCurrentVote()
        {
            Console.WriteLine($"Current votes for post {Title}: {_votes}");
        }
    }

}