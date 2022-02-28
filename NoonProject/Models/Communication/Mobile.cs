using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models.Communication
{
    public class Mobile
    {
        public string Number { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
    }
}
