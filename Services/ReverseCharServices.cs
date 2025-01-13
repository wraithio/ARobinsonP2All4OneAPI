namespace ARobinsonP2All4OneAPI.Services
{
    public class ReverseCharServices
    {
        public string GoReverseChar(string userString)
        {
            string reverseResult = "";
            for (int i = userString.Length - 1; i >= 0; i--)
            {
                reverseResult += userString[i];
            }
            return $"You entered {userString}, reversed is {reverseResult}.";
        }
    }
}