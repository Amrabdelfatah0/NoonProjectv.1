using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models.Address
{
    public class City 
    {
        public string Name { get; set; }
        public int GovernroteId { get; set; }
        [ForeignKey("GovernroteId")]
        public Governrote governrote { get; set; }
        public List<Address> addresses { get; set; }

    }
}
