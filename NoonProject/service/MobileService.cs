using NoonProject.Models.Communication;
using NoonProject.Parent;
using NoonProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.service
{
    public class MobileService : IMobile
    {
        EntityDbContext dbContext = new EntityDbContext();
        public void Add(Mobile entity)
        {
            entity.CreatedDate = DateTime.Now;
            dbContext.mobiles.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            dbContext.mobiles.Remove(Get(Id));
            dbContext.SaveChanges();
        }

        public Mobile Get(int id)
        {
            if (IsExistById(id))
            {
                return dbContext.mobiles.Where(x => x.Id == id).SingleOrDefault();
            }
            return null;
        }

        public List<Mobile> Get()
        {
            return dbContext.mobiles.ToList();
        }
        public void Update(Mobile entity)
        {
            if (IsExist(entity))
            {
                Mobile oldEntity = Get(entity.Id);
                oldEntity.Number = entity.Number;
            }
        }
        public List<Mobile> GetAll(int UserId)
        {
            if (IsUserHasMobile(UserId))
            {
                return dbContext.mobiles.Where(x => x.UserId == UserId).ToList();
            }
            return null;
        }


        public bool IsExist(string Mobile)
        {
            return dbContext.mobiles.Any(x => x.Number == Mobile);
        }

        public bool IsExist(Mobile entity)
        {
            return dbContext.mobiles.Any(x => x.Id == entity.Id || x.Number == entity.Number);
        }

        public bool IsUserHasMobile(int UserId)
        {
            return dbContext.mobiles.Any(x => x.UserId == UserId);
        }

        public bool IsExistById(int Id)
        {
            return dbContext.mobiles.Any(x => x.Id == Id);
        }
    }
}
