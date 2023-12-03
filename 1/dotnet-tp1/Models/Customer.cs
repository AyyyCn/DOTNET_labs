using Microsoft.AspNetCore.Authentication;

namespace WebApplication1.Models
{
    public class Customer
    {
        private static int nextId = 1;

        public int Id { get; private set; }
        public string Name { get; set; }

        public Customer()
        {
            Id = nextId++;
            Name = "Default";
        }
    }
}
