namespace Problem_2
{
    public class UserInput
    {
        private List<string> friends = new List<string>();

        public List<string> getNames()
        {

            Console.WriteLine("Enter the names of your friends.");

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }
                else
                {
                    friends.Add(input);
                }
            }
            return friends;

        }
    }
}