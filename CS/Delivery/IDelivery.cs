using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management.CS.Delivery
{
    public interface IDelivery
    {
        void AddOrderItem();
        void CreateOrder();
        void CollectDelivery();
    }
}
