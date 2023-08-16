using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopperPractice15_08.Model
{
    interface IRepository<T>
    {
        int Create(T obj);

        int Delete(T obj);  

        int Update(T obj);

        IList<T> GetAll();

        T GetById(int id);
    }
}
