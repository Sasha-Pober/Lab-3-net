using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public abstract class Document
    {
        public int? Number { get; set; }
        public DateTime? Date { get; set; }
        public string Info { get; set; }

       
        public virtual string GetDocument()
        {
            return $"{this.GetType().Name} #{Number ?? 1} ({Date ?? DateTime.Now})\n{Info ?? "default info"}";
        }

    }
}
