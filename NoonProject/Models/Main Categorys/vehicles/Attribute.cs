using NoonProject.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models.Main_Categorys.vehicles
{
    public class Attribute :Base
    {
        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        [ForeignKey ("SubCategory")]
        public SubCategory SubCategory { get; set; }
    }
}
