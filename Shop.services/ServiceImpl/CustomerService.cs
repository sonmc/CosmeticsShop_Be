using Shop.entities;
using Shop.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.services.ServiceImpl
{
    public class CustomerService : GeneralServiceImpl<Customer, ICustomerRepository>, ICustomerService
    {

        ICustomerRepository _repository;

        public CustomerService() { }
        public CustomerService(ICustomerRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
