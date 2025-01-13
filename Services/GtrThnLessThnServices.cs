namespace ARobinsonP2All4OneAPI.Services
{
    public class GtrThnLessThnServices
    {
        public string GtrLssThn(int Num1, int Num2)
        {
            if (Num1 < Num2)
            {
                return $"{Num1} is less than {Num2}. {Num2} is greater than {Num1}.";
            }
            if (Num1 > Num2)
            {
                return $"{Num1} is greater than {Num2}. {Num2} is less than {Num1}.";
            }
            if (Num1 == Num2)
            {
                return $"{Num1} is equal to {Num2}.";
            }
            return null!;
        }
    }
}