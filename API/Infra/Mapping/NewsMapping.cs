using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infra.Mapping
{
    public class NewsMapping : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                .HasColumnType("varchar(250)");

            builder.Property(c => c.Hat)
                .HasColumnType("varchar(80)");

            builder.Property(c => c.Author)
                .HasColumnType("varchar(80)");

            builder.Property(c => c.Text)
                .HasColumnType("varchar(255)");

            builder.Property(c => c.Img)
               .HasColumnType("varchar(255)");

            builder.Property(c => c.Slug)
            .HasColumnType("varchar(255)");

            builder.Property(c => c.Status);

            builder.Property(c => c.PublishDate);

            builder.Property(c => c.Deleted)
         .HasColumnType("int");

            builder.ToTable("News");

        }
    }
}
