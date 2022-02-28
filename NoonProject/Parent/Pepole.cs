using NoonProject.Base;
using NoonProject.Models;
using NoonProject.Models.Address;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Parent
{
    public class Pepole :BaseWithName

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BrithDay { get; set; }
        public List<Addres> addresses { get; set; }
        [NotMapped]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

    }
}
