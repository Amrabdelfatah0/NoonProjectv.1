using NoonProject.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models.Main_Categorys.vehicles
{
    public class AttributeOption : Base
    {
        public int AttributeId { get; set; }
        public string Name { get; set; }
        [ForeignKey ("Attribute")]
        public Attribute Attribute { get; set; }
    }
}
