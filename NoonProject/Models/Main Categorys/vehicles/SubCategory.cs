using NoonProject.Bases;
using NoonProject.Models.Main_Category;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models.Main_Categorys.vehicles
{
    public class SubCategory: Base

    {
        public string Name { get; set; }
        public int MainCategoryId { get; set; }
        [ForeignKey ("MainCategoryId") ]
        public MainCategory MainCategory {get;set;}
    }
}
