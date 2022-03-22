using NoonProject.Audits;
using NoonProject.Models.Advertisements;
using NoonProject.Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace NoonProject.Models.Main_Categorys.vehicles.Buying
{
    public class BuyingType : Audit
    {

        List<Product> product { get; set; }
        public double priceTo { get; set; }
        public double priceForm { get; set; }
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
