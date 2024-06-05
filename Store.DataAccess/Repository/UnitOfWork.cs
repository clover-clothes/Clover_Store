using Clover_Store.Data;
using Store.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IProduct product {  get;private set; }
        public Iattributes attributes { get; private set; }
        public ICard Card { get; private set; }
        public ICategorys Categorys { get; private set; }
        public IColors Colors { get; private set; }
        public ICustomer Customer { get; private set; }
        public IImage Image { get; private set; }
        public IOrder Order { get; private set; }
        public IReviwe reviwe { get; private set; }
        public ISizes Sizes { get; private set; }
        public IwishList wishList { get; private set; }
        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            product = new ProductRepository(db);
            attributes = new attributesRepository(db);
            Card = new CardRepository(db);
            Categorys = new CategorysRepository(db);
            Colors = new ColorsRepository(db);
            Customer = new CustomerRepository(db);
            Image = new ImageRepository(db);
            Order = new OrderRepository(db);
            reviwe = new ReviweRepository(db);
            Sizes = new SizesRepository(db);
            wishList = new wishListRepository(db);
            

        }
        
        public void Save() {
            _db.SaveChanges();
        }
    }
}
