using Microsoft.EntityFrameworkCore;
using Icatu.EmployeeManagerAPI.Data.Mapping;
using Icatu.EmployeeManagerAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Icatu.EmployeeManagerAPI.Data.Context
{
    public class EmployeeManagerAPIContext: DbContext
    {
        public DbSet<Employee> Employee { get; set; }
      
            

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string strConexao = "Data Source=.\\sqlexpress;Database=EmployeeManager;User Id=sa;Password=sa;MultipleActiveResultSets=true;";

            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(strConexao);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>(new EmployeeMap().Configure);
 
        }
    }
}
