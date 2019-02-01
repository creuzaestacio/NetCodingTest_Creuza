using System;
using System.Collections.Generic;
using System.Text;

namespace Icatu.EmployeeManagerAPI.Domain.Entities
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
    }
}
