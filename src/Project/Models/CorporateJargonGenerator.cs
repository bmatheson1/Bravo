using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class CorporateJargonGenerator : ICorporateJargonGenerator
    {
        private readonly string[] Verbs = { "Use", "Implement", "Collaborate", "Synergise", "Integrate", "Cloudify" } ;
        private readonly string[] Nouns = { "Systems", "DevOps", "Cross-Platform Tools", "E-Commerce Products", "Web-Readiness Strategies" };
        private readonly string[] Adverbs = { "Efficiently", "Effectively", "Holistically", "Seamlessly", "With Great Vigor" };

        public string GetFluff()
        {
            Random rand = new Random();

            var verb = Verbs[rand.Next(Verbs.Length)];
            var noun = Nouns[rand.Next(Nouns.Length)];
            var adjective = Adverbs[rand.Next(Adverbs.Length)];

            return $"{verb} {noun} {adjective}";
        }
    }
}
