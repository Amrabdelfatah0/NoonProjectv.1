using NoonProject.Audits;
using NoonProject.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models.Communication
{
    public class Mobile : Audit
    {
        public string Number { get; set; }
        public int UserId { get; set; }
        // Foriegn key
        public User user { get; set; }
    }
}
