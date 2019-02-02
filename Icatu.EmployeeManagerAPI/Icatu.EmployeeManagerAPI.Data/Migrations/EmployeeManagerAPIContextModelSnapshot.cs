﻿// <auto-generated />
using System;
using Icatu.EmployeeManagerAPI.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Icatu.EmployeeManagerAPI.Data.Migrations
{
    [DbContext(typeof(EmployeeManagerAPIContext))]
    partial class EmployeeManagerAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Icatu.EmployeeManagerAPI.Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EmployeeId");

                    b.Property<string>("department")
                        .IsRequired()
                        .HasColumnName("Departamento");

                    b.Property<string>("email");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("TB_EMPLOYEE");
                });
#pragma warning restore 612, 618
        }
    }
}
