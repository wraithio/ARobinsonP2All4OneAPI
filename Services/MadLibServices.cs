using ARobinsonP2All4OneAPI.Models;

namespace ARobinsonP2All4OneAPI.Services
{
    public class MadLibServices
    {
        public string goMadLib(string color, string adjective, string place, string adjective_2, string place_2, string food_S, string food_P, string verb, string noun_P, string adjective_3)
        {
            
            return $"My birds are so cool! They are {color}, {adjective} animals which have wings. They like to fly around the {place} which makes some people scared of them. But my birds are {adjective_2}, and they don't want to hurt people. I have pet birds that live in {place_2}. I like to feed them one {food_S} and some {food_P}. They like to {verb}. I am their favorite person, but they also like {noun_P}. I want to convince my parents to get me {adjective_3} bats.";
        }
    }
}