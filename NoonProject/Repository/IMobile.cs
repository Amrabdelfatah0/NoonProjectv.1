using NoonProject.Models;
using NoonProject.Models.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Repository
{
    public interface IMobile : IGenericCRUD<Mobile>, IValidation<Mobile>
    {
        List<Mobile> GetAll(int UserId);
        bool IsExist(string Mobile);
        bool IsUserHasMobile(int UserId);
       
    }
}
