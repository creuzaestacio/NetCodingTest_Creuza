using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Icatu.EmployeeManagerAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Icatu.EmployeeManagerAPI.Data.Mapping
{
    public class EmployeeMap: IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("TB_EMPLOYEE");

            builder.HasKey(c => c.Id);
            builder.Property(p => p.Id).HasColumnName("EmployeeId").IsRequired();

            builder.Property(c => c.name)
                .IsRequired()
                .HasColumnName("Name");

            builder.Property(c => c.department)
                .IsRequired()
                .HasColumnName("Departamento");



        }


    }
}
