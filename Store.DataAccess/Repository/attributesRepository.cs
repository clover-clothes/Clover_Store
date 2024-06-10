using Clover_Store.Data;
using Clover_Store.Models;
using Store.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess.Repository
{
    public class attributesRepository : Repository<attributes>, Iattributes
    {
        private ApplicationDbContext _db;
        public attributesRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(attributes obj)
        {
            _db.attributes.Update(obj);
        }
    }
}
