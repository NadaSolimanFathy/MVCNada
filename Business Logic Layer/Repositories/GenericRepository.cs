using Business_Logic_Layer.Interfaces;
using Data_Access_Layer.Context;
using Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly CMSDbContext _context;

        public GenericRepository(CMSDbContext context)
        {
            _context = context;
        }

        public T GetById(int? id)
        {
           return  _context.Set<T>().FirstOrDefault(t=>t.Id ==id);
        }
        public IEnumerable<T> GetAll()
        {
            var listOfT= _context.Set<T>().ToList();
            return listOfT;
        }

       
        public int Add(T entity)
        {
            _context.Set<T>().Add(entity);
             return _context.SaveChanges();//return number of affected rows
        }

        public int Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges();
        }

     

        public int Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return _context.SaveChanges();
        }
    }
}
