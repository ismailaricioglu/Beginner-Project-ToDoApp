﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId); // PK
            builder.Property(c => c.CategoryName).IsRequired();

            builder.HasData(
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Yapılacakların 1. Kategorisi"
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Yapılacakların 2. Kategorisi"
                },
                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Yapılacakların 3. Kategorisi"
                }
            );
        }
    }
}