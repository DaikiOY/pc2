using System;

namespace si730pc2u20201f846.Domain.Entities
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }
    }
}
