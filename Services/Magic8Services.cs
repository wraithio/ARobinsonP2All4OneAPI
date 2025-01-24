namespace ARobinsonP2All4OneAPI.Services
{
    public class Magic8Services
    {
        public string goMagic8()
        {
            string[] QuestionReplies = {"Yes of course.","Absolutely.", "Possibly.", "I am unsure.", "I don't know.", "I don't think so.", "Maybe yes, maybe no.", "No, take caution.", "Absolutely not."};
            Random rng = new Random();
            int randomReply = rng.Next(QuestionReplies.Length + 1);
            return QuestionReplies[randomReply];
        }
    }
}