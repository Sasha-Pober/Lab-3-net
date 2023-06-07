using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Directive : Document
    {
        public string Department { get; set; }
        public DateTime? Deadline { get; set; }


        public override string GetDocument()
        {
            return base.GetDocument() + $"\nDepartment: {Department ?? "Main Deaprtment"}, Deadline: {Deadline ?? DateTime.Now}";
        }
    }
}
