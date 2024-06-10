using Clover_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess.Repository.IRepository
{
    public interface IOrderItem: IRepository<OrderItem>
    {
        void Update(OrderItem obj);

    }
}
