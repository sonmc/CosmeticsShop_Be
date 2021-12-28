﻿using Shop.entities;
using System.Collections.Generic;

namespace Shop.repositories
{
    public interface IOrderRepository : IGeneralRepository<Order>
    {
        List<Order> SearchOrderByCode(string code);
    }
}
