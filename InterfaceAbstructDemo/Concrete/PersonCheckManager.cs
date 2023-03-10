using InterfaceAbstructDemo.Abstract;
using InterfaceAbstructDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstructDemo.Concrete
{
    public class PersonCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
