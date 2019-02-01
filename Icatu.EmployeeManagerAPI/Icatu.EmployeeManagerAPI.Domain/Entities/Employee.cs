using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Icatu.EmployeeManagerAPI.Domain.Entities
{

    public class Employee : BaseEntity
    { 

        public string name { get; set; }

        public string email { get; set; }

        public string department { get; set; }


    }
}
