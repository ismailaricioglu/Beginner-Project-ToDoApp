using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, CategoryId = 1, Text = "1 nolu kategorinin 1. yapılacak işi", DateTime = DateTime.UtcNow },
                new Book { Id = 2, CategoryId = 2, Text = "2 nolu kategorinin 1. yapılacak işi", DateTime = DateTime.UtcNow },
                new Book { Id = 3, CategoryId = 1, Text = "1 nolu kategorinin 2. yapılacak işi", DateTime = DateTime.UtcNow }
                );
        }
    }
}
