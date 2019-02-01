using FluentValidation;
using Icatu.EmployeeManagerAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Icatu.EmployeeManagerAPI.Domain.Interfaces
{
    public interface IService<T> where T : BaseEntity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Delete(Guid id);

        T Get(Guid id);

        IList<T> Get();
    }
}
