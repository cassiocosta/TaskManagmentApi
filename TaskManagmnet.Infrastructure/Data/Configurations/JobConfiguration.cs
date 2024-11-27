using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagmnet.Domain.Entities;

namespace TaskManagmnet.Infrastructure.Data.Configurations
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {

            builder.Property(t => t.Title)
                .HasColumnName("varchar(200)");
            builder.Property(t => t.Description)
                .HasColumnName("varchar(1000)");
            builder.Property(t => t.Status)
                .HasColumnName("varchar(20)");
            builder.Property(t => t.DueDate)
                .HasColumnName("datetime");    
        }
    }
}