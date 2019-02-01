using Icatu.EmployeeManagerAPI.Data.Context;
using Icatu.EmployeeManagerAPI.Domain.Entities;
using Icatu.EmployeeManagerAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Icatu.EmployeeManagerAPI.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private EmployeeManagerAPIContext context = new EmployeeManagerAPIContext();

        //public BaseRepository(Icatu.EmployeeManagerAPIContext db)
        //{
        //    context = db;
        //}

        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            context.Set<T>().Remove(Select(id));
            context.SaveChanges();
        }

        public IList<T> Select()
        {
            return context.Set<T>().ToList();
        }

        public T Select(Guid id)
        {
            return context.Set<T>().Find(id);
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }


        public IList<T> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
