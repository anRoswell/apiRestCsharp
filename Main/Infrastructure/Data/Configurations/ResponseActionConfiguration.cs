using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Configurations
{
    public class ResponseActionConfiguration : IEntityTypeConfiguration<ResponseAction>
    {
        public void Configure(EntityTypeBuilder<ResponseAction> builder)
        {
            builder.HasNoKey();
        }
    }
}
