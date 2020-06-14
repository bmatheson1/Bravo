using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class CorporateJargonGenerator : ICorporateJargonGenerator
    {
        private readonly string[] Verbs = { "Use", "Implement", "Collaborate", "Synergise" } ;
        private readonly string[] Nouns = { "Systems", "DevOps", "Cross-Platform Tools" };
        private readonly string[] Adjectives = { "Efficiently", "Effectively" };

        public string GetFluff()
        {
            Random rand = new Random();

            var verb = Verbs[rand.Next(Verbs.Length)];
            var noun = Nouns[rand.Next(Nouns.Length)];
            var adjective = Adjectives[rand.Next(Adjectives.Length)];

            return $"Here at Bravo! we {verb} {noun} {adjective}";
        }
    }
}
