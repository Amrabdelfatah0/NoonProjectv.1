using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Audits
{
    public class FullAudit : Audits
    {
        public DateTime DeletedTime { get; set; }
        public bool IsDelete { get; set; }
    }

   
}
