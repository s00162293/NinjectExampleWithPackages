using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ex32.Models;

namespace Ex32.DAL
{
    public class DummyCustomerRepository : ICustomerRepository
    {
        public DummyCustomerRepository()
        {

        }
        public void Dispose()
        {
            
        }

        public Customers GetCustomerByID(int Id)
        {
            return new Customers()
            {
                CustomerID = "cust01",
                CompanyName = "Fake Name",
                Country = "Ireland"
            };
        }

        public List<Customers> GetCustomers()
        {
            return new List<Customers>()
            {
                new Customers()
                {
                    CustomerID = "cust01",
                    CompanyName = "Fake Name",
                    Country = "Ireland"
                }
                
            };
        }
    }
}