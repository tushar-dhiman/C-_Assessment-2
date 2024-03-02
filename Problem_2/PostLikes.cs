namespace Problem_2
{
    public class PostLikes
    {
        public void showLikes(List<string> listOfFriends)
        {

            switch (listOfFriends.Count)
            {
                case 0:
                    break;

                case 1:
                    Console.WriteLine(listOfFriends[0] + " liked your post");
                    break;

                case 2:
                    Console.WriteLine($"{listOfFriends[0]} and {listOfFriends[1]} liked your post");
                    break;

                default:
                    int othersCount = listOfFriends.Count - 2;
                    Console.WriteLine($"{listOfFriends[0]}, {listOfFriends[1]} and {othersCount} others liked your post");
                    break;
            }
        }
    }
}