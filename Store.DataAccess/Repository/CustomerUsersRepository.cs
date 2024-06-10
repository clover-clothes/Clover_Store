using Clover_Store.Data;
using Clover_Store.Models;
using Store.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess.Repository
{
    public class CustomerUsersRepository : Repository<CustomerUsers>, ICustomerUsers
    {
        private ApplicationDbContext _db;
        public CustomerUsersRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

       
        public void Update(CustomerUsers obj)
        {
            _db.CustomerUsers.Update(obj);
        }
    }
}
