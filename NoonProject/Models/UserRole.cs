using NoonProject.Bases;
using NoonProject.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models
{
    public class UserRole : Base
    {
        public string Name { get; set; }
        public List<User> users { get; set; }
    }
}
