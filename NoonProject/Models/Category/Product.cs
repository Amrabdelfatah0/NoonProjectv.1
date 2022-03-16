using NoonProject.Audits;
using NoonProject.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models.Category
{
    public class Product : Audit
    {
       
            public string ProductName { get; set; }
            public double Price { get; set; }
            public bool IsDisplay { get; set; }
            public DateTime ProductionDate { get; set; }
            
        

    }
}
