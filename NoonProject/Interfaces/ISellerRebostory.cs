using NoonProject.Models.Seller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Interfaces
{
    public interface ISellerRebostory

    {
        void Add(Seller obj);
        void Update(Seller obj);
        void Delet(int Id);
        List<Seller> Get();

        Seller Get(int ID);
    }
}
