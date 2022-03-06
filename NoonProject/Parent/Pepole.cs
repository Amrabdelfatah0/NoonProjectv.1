using NoonProject.Audits;
using NoonProject.Bases;
using NoonProject.Models;
using NoonProject.Models.Addresss;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Parent
{
    public class Pepole :Audit

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BrithDay { get; set; }
        public List<Address> addresses { get; set; }
        [NotMapped]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

    }
}
