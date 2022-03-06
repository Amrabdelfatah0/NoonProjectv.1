using NoonProject.Models.Addresss;
using NoonProject.Models.Communication;
using NoonProject.Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models.Users
{
    public class User : Pepole

    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public int UserRoleId { get; set; }
        public UserRole userRole { get; set; }
        public List<Mobile> mobiles { get; set; }
        public List<Address> addresses { get; set; }
      

    }
}
