using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IProduct    product { get; }
        Iattributes attributes { get; }
        ICard       Card { get; }
        ICategorys  Categorys { get; }
        IColors     Colors { get; }
        ICustomer   Customer { get; }
        IImage      Image { get; }
        IOrder      Order { get; }
        IReviwe     reviwe { get; }
        ISizes      Sizes { get; }
        IwishList   wishList { get; }

        void Save();
    }
}
