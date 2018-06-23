using System.Collections.Generic;

namespace Lecture2_7
{
    public class Customer
    {
        public int Id;
        public string Name;
        List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
             : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
