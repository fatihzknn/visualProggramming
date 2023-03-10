using InterfaceAbstructDemo.Abstract;
using System;

namespace InterfaceAbstructDemo.Entites
{
    public class Customer:IEntity
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
