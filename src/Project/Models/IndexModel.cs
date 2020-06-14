using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class IndexModel
    {
        public IndexModel(string jargon)
        {
            Jargon = jargon;
        }

        public string Jargon { get; }
    }
}
