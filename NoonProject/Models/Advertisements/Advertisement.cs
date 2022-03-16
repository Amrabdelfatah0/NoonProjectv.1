using NoonProject.Audits;
using NoonProject.Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Models.Advertisements
{
    public class Advertisement : Audit

    {
        List<Product> product { get; set; }
        public Category category { get; set; }
        public double priceTo { get; set; }
        public double priceForm { get; set; }
        public Model model { get; set; }
        public AdType Adtype { get; set; }
        public PaymentMethod Paymentmethod { get; set; }
         public DateTime DateTime { get; set; }
        public Kilometer kilometer { get; set; }
        public Color color { get; set; }
        public TransmissionType transmissionType { get; set; }
         public Condition condition { get; set; }
         public BodyType bodyType { get; set; }
         public FuelType fuelType { get; set; }
        public EngineCapacity Enginecapacity { get; set; }
        List<ExtraFeatures> ExtraFeatures { get; set; } 

    }
}
