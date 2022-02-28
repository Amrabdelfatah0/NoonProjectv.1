using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models.Address
{
    public class City 
    {
        public string Name { get; set; }
        public int GovernroteId { get; set; }
        public Governrote governrote { get; set; }
        public List<Addres> addresses { get; set; }

    }
}
