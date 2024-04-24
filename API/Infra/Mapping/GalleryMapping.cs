using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infra.Mapping
{
    public class GalleryMapping : IEntityTypeConfiguration<Gallery>
    {
        public void Configure(EntityTypeBuilder<Gallery> builder)
        {
            builder.HasKey(c => c.Id);         

            builder.Property(c => c.Title)
               .HasColumnType("varchar(250)");

            builder.Property(c => c.Legend)
               .HasColumnType("varchar(250)");

            builder.Property(c => c.Author)
               .HasColumnType("varchar(250)");

            builder.Property(c => c.Thumb)
             .HasColumnType("varchar(250)");

            builder.Property(c => c.Tags)
            .HasColumnType("varchar(250)");

            builder.Property(c => c.Slug)
           .HasColumnType("varchar(250)");

            builder.Property(c => c.GalleryImages);

            builder.Property(c => c.PublishDate);

            builder.Property(c => c.Deleted)
         .HasColumnType("int");

            builder.Property(c => c.Status);

            builder.ToTable("Gallery");

        }
    }
}
