namespace Problem_1
{
    public class PascalScaleFormatter : IStringFormatter
    {

        public string toPascalScale(string userString)
        {
            string[] words = userString.Split(' ');

            for (int index = 0; index < words.Length; index++)
            {

                words[index] = char.ToUpper(words[index][0]) + words[index].Substring(1).ToLower();
            }

            return string.Join("", words);
        }
    }
}