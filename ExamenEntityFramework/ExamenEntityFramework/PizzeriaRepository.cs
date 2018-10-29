using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ExamenEntityFramework
{
    class PizzeriaRepository : IPizzeriaRepository, IDisposable
    {
        private PizzeriaContext context;
        public PizzeriaRepository(PizzeriaContext context)
        {
            this.context = context;
        }
        public void Delete(int Id)
        {
            Pizza pizza = context.Pizza.Find(Id);
            context.Pizza.Remove(pizza);
        }

        public void Dispose() { }

        public void Insert(Pizza Pizza)
        {
            context.Pizza.Add(Pizza);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public Pizza Select(Pizza Pizza)
        {
            return context.Pizza.Find(Pizza);
        }

        public void Update(Pizza Pizza)
        {
            context.Entry(Pizza).State = EntityState.Modified;
        }
    }
}
