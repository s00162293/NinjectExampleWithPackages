using Ex32.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32.DAL
{
    public interface ICustomerRepository:IDisposable
    {
        List<Customers> GetCustomers();
        Customers GetCustomerByID(int Id);
    }
}
