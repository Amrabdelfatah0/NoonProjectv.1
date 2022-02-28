using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Audits
{
    public class Audits : Base
    {
      
            public int? CreatedBy { get; set; }
            public DateTime CreatedDate { get; set; }
            public int? LastModifiedBy { get; set; }
            public DateTime LastModifiedDate { get; set; } = DateTime.Now;
        
    }
}
