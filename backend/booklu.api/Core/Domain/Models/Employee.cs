namespace booklu.api.Core.Domain.Models
{
    public class Employee
    {
        private string _name;
        public int _age;
        public Address _address;
        public Contact _contact;

        public Employee()
        {
        }

        public Employee(string name, int age, Address address, Contact contact)
        {
            _name = name;
            _age = age;
            _address = address;
            _contact = contact;
        }

    }
}
