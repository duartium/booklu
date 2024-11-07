using booklu.api.Application.Interfaces;
using booklu.api.Core.Domain.Models;

namespace booklu.api.Application.Builders
{
    public class EmployeeBuilder : IBuilder<Employee>
    {
        private string _name;
        private int _age;
        private Address _address;
        private Contact _contact;

        //constructor for normal instance
        public EmployeeBuilder()
        {
        }

        #region setters that return the same class

        public EmployeeBuilder setName(string name)
        {
            _name = name;
            return this;
        }

        public EmployeeBuilder setAge(int age)
        {
            _age = age;
            return this;
        }

        public EmployeeBuilder setAddress(Address address)
        {
            _address = address;
            return this;
        }

        public EmployeeBuilder setContact(Contact contact)
        {
            _contact = contact;
            return this;
        }

        #endregion

        public Employee Build()
        {
            return new Employee(_name, _age, _address, _contact);
        }
    }
}
