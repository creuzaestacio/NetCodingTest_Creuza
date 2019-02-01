using FluentValidation;
using Icatu.EmployeeManagerAPI.Data.Repository;
using Icatu.EmployeeManagerAPI.Domain.Entities;
using Icatu.EmployeeManagerAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Icatu.EmployeeManagerAPI.Service.Services
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        private BaseRepository<T> repository = new BaseRepository<T>();

        //public BaseService(BaseRepository<T> baseRepository)
        //{
        //    repository = baseRepository;
        //}

        public T Post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Insert(obj);
            return obj;
        }

        public T Put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Update(obj);
            return obj;
        }

        public void Delete(Guid id)
        {
            if (id == new Guid())
                throw new ArgumentException("O id precisa ser informado.");

            repository.Delete(id);
        }

        public IList<T> Get() => repository.Select();

        public T Get(Guid id)
        {
            if (id == new Guid())
                throw new ArgumentException("O id precisa ser informado");

            return repository.Select(id);
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }

    }
}
