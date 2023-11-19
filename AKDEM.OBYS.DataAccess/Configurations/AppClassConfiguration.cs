﻿using AKDEM.OBYS.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKDEM.OBYS.DataAccess.Configurations
{
    public class AppClassConfiguration : IEntityTypeConfiguration<AppClass>
    {
        public void Configure(EntityTypeBuilder<AppClass> builder)
        {
            builder.Property(x => x.Definition).HasMaxLength(200).IsRequired();

        }
    }
}
