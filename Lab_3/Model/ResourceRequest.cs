using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ResourceRequest : Document
    {
        string EmployeeName { get; set; }
        string Resources { get; set; }

        public override string GetDocument()
        {
            return base.GetDocument() + $"\nName of Employee: {EmployeeName ?? "Dave Batista"}, Resources: {Resources ?? "All resources"}";
        }
    }
}
