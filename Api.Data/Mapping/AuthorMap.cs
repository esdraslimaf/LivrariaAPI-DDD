using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Mapping
{
    public class AuthorMap : IEntityTypeConfiguration<AuthorEntity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AuthorEntity> builder)
        {
            builder.ToTable("Authors");
            builder.HasKey(a=>a.Id);
            builder.Property(a=>a.Name).HasMaxLength(100).IsRequired();
           builder.HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId);
        }
    }
}
