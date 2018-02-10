using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ex32.Models;

namespace Ex32.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private SampleDBEntities context;
        public CustomerRepository(SampleDBEntities context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public Customers GetCustomerByID(int Id)
        {
            return context.Customers.Find(Id);
        }

        public List<Customers> GetCustomers()
        {
            return context.Customers.ToList();
        }
    }
}