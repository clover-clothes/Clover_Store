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
    public class ReviweRepository : Repository<Reviwe>, IReviwe
    {
        private ApplicationDbContext _db;
        public ReviweRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Reviwe obj)
        {
            _db.Reviwe.Update(obj);
        }
    }
}
