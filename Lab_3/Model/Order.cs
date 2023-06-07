using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Order : Document
    {
        public string Department { get; set; }
        public DateTime? Deadline { get; set; }
        public string Executor { get; set; }

        public override string GetDocument()
        {
            return base.GetDocument() + $"\nDepartment: {Department ?? "main department"}, DeadLine: {Deadline ?? DateTime.Now}, Executor: {Executor ?? "Executor1"}";
        }
    }
}
