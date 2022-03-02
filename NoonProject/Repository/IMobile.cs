using NoonProject.Models.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Repository
{
    public interface IMobileRepository : IGenericCRUD<Mobile>
    {
        List<Mobile> GetAll(int UserId);
        bool IsExist(int Id);
        bool IsExist(string Mobile);
        bool IsExist(Mobile entity);
        bool IsUserHasMobile(int UserId);
    }
}
