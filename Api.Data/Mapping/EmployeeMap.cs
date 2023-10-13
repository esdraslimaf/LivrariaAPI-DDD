using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class EmployeeMap : IEntityTypeConfiguration<EmployeeEntity>
    {
        public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(e=>e.Id);
            builder.Property(e=>e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e=>e.Email).HasMaxLength(100).IsRequired();
            builder.Property(e=>e.Password).HasMaxLength(100).IsRequired();
        }
    }
}
