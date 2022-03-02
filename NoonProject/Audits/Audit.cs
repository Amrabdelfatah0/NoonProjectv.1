using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoonProject.Bases;
namespace NoonProject.Audits
{
    public class Audit : Base
    {
      
            public int? CreatedBy { get; set; }
            public DateTime CreatedDate { get; set; }
            public int? LastModifiedBy { get; set; }
            public DateTime LastModifiedDate { get; set; } = DateTime.Now;
        
    }
}
