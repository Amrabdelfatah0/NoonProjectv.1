using NoonProject.Audits;
using NoonProject.Models.Addresss;
using NoonProject.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models.Addresss
{
    public class Address : Audit
    {
        public int UserId { get; set; }
        public int CityId { get; set; }
        public string AddressDetails { get; set; }
        [ForeignKey("CityId")]
        public City city { get; set; }
        [ForeignKey("UserId")]
        public User user { get; set; }
    }
}
