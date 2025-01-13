namespace ARobinsonP2All4OneAPI.Services
{
    public class Add2NumServices
    {
        public string Add2Num(int Num1, int Num2)
        {
            int sum = Num1 + Num2;
            return "The sum of " + Num1 + " and " + Num2 + " is " + sum + ".";
        }
    }
}