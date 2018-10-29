using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEntityFramework
{
    interface IPizzeriaRepository : IDisposable
    {
        Pizza Select(Pizza Pizza);
        void Insert(Pizza Pizza);
        void Delete(int Id);
        void Update(Pizza Pizza);
        void Save();
    }
}
