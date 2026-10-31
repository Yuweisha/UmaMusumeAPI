using System;
using System.Collections.Generic;

namespace UmaMusumeAPI.Models.Tables
{
    public class MetaA
    {
        public int I { get; set; }
        public string N { get; set; }
        public string D { get; set; }
        public int G { get; set; }
        public int L { get; set; }
        public int C { get; set; }
        public string H { get; set; }
        public string M { get; set; }
        public int K { get; set; }
        public int S { get; set; }
        public int P { get; set; }

        /// <summary>Per-entry decryption key. Present in the game's own meta, null for entries
        /// that are not encrypted (and absent entirely in a CDN-rebuilt database).</summary>
        public long? E { get; set; }
    }
}
