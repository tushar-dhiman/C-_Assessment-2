namespace Problem_4
{
    public class PostMain
    {
        public static void Main(string[] args)
        {
            StackOverflowPost myPost = new StackOverflowPost("C#", "Basics of C#");

            myPost.incrementVote();
            myPost.incrementVote();
            myPost.incrementVote();
            myPost.decrementVote();
            myPost.displayCurrentVote();
        }
    }
}