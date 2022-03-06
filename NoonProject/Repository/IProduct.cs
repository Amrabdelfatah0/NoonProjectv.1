using NoonProject.Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Repository
{
    public interface IProduct : IGenericCRUD<Product>, IValidation<Product>
    {
        void Active(int id);
        void Dective(int id);
        List<Product> GetAll();//not needed
        bool IsProductValid(Product entity);
    }
}
