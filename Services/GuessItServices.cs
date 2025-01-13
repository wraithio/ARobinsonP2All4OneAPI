namespace ARobinsonMC5Eight2Ten_EndPnt.Services
{
    public class GuessItServices
    {
        Random generate = new Random();
        public string EasygoGuessIt(int guessInt)
        {

            int correctNum = generate.Next(1, 10);
            if(guessInt < 1 || guessInt > 10)
            {
                return "This value is outside of the number range.(1-10)";
            } else if(guessInt < correctNum)
            {
                return $"Your guess is less than the correct number by {correctNum - guessInt}.";
            }else if(guessInt > correctNum)
            {
                return $"Your guess is greater than the correct number by {guessInt - correctNum}.";
            }else if (guessInt == correctNum)
            {
                return "You guessed the right number!";
            }
            return "Your answer is invalid.";
        }
        public string MediumgoGuessIt(int guessInt)
        {

            int correctNum = generate.Next(1, 50);
            if(guessInt < 1 || guessInt > 50)
            {
                return "This value is outside of the number range.(1-50)";
            } else if(guessInt < correctNum)
            {
                return $"Your guess is less than the correct number by {correctNum - guessInt}.";
            }else if(guessInt > correctNum)
            {
                return $"Your guess is greater than the correct number by {guessInt - correctNum}.";
            }else if (guessInt == correctNum)
            {
                return "You guessed the right number!";
            }
            return "Your answer is invalid.";
        }
        public string HardgoGuessIt(int guessInt)
        {

            int correctNum = generate.Next(1, 100);
            if(guessInt < 1 || guessInt > 100)
            {
                return "This value is outside of the number range.(1-100)";
            } else if(guessInt < correctNum)
            {
                return $"Your guess is less than the correct number by {correctNum - guessInt}.";
            }else if(guessInt > correctNum)
            {
                return $"Your guess is greater than the correct number by {guessInt - correctNum}.";
            }else if (guessInt == correctNum)
            {
                return "You guessed the right number!";
            }
            return "Your answer is invalid.";
        }
    }
}