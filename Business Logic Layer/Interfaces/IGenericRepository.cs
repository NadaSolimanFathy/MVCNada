using Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Interfaces
{
    internal interface IGenericRepository<T> where T : BaseEntity
    {
        //BaseEntity : admin ,instructor ,student ,course
        T GetById(int? id);
        IEnumerable<T> GetAll();

        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
