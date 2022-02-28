using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models.Address
{
    public class Addres : Audits
    {
        public int UserId { get; set; }
        public int CitiyId { get; set; }
        public string AddressDetails { get; set; }
        public City city { get; set; }
        

    }
}
