using NoonProject.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models.Main_Categorys.vehicles
{
    public class SubCategoryAttribute : Base
    {
        [ForeignKey (" SubCategory")]
        public int SubCategoryId { get; set; }
        [ForeignKey(" Attribute")]
        public int AttributeId { get; set;}
    }
}
