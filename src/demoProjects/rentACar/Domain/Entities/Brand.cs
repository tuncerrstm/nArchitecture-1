using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
<<<<<<< HEAD
    public class Brand : Entity
    {
        public string Name { get; set; }
        public Brand()
        {
            
=======
    public class Brand:Entity
    {
        public string Name { get; set; }

        public virtual ICollection<Model> Models { get; set; }

        public Brand()
        {
>>>>>>> 125547c3f212856527ebc54ce59074606f091a66
        }

        public Brand(int id, string name):this()
        {
            Id = id;
            Name = name;
        }
    }
}
