using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEntityFramework
{
    class Pizza
    {
        public int Id { get; }
        public String Name { get; }
        public ICollection<Ingrediente> Ingredientes { get; }   
    }
}
