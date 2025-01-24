using ARobinsonP2All4OneAPI.Models;

namespace ARobinsonP2All4OneAPI.Services
{
    public class MadLibServices
    {
        public string goMadLib()
        {
            LibModel madLibs = new();
            return $"My birds are so cool! They are {madLibs.color}, {madLibs.adjective} animals which have wings. They like to fly around the {madLibs.place} which makes some people scared of them. But my birds are {madLibs.adjective_2}, and they don't want to hurt people. I have pet birds that live in {madLibs.place_2}. I like to feed them one {madLibs.food_S} and some {madLibs.food_P}. They like to {madLibs.verb}. I am their favorite person, but they also like {madLibs.noun_P}. I want to convince my parents to get me {madLibs.adjective_3} bats.";
        }
    }
}