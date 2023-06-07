using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Letter : Document
    {
        public string Correspondent { get; set; }
        public bool? IsIncoming { get; set; }
        

        public override string GetDocument()
        {
            return base.GetDocument() + $"\nFrom: {Correspondent ?? "Correspondent1"}, incoming letter: {IsIncoming ?? true }";
        }
    }
}
