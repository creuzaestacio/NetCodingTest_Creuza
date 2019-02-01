using Icatu.EmployeeManagerAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Icatu.EmployeeManagerAPI.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);
        void Update(T obj);
        void Remove(Guid id);
        T Select(Guid id);
        IList<T> SelectAll();
    }
}
