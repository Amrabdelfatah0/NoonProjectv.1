using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Base
{
    public class BaseWithName:Base
    {
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }
}
