using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ExamenEntityFramework
{
    class Ingrediente
    {
        public int Id { get; }
        public String Name { get; }
        private decimal _Price;
        public decimal Price
        {
            get
            {
                var percent = decimal.Parse(ConfigurationManager.AppSettings["Price"]);
                return _Price * percent;
            }
        }
        public ICollection<Pizza> Pizzas { get; }
    }
}
