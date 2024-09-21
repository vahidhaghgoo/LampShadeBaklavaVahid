﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.Slider2Agg;

namespace ShopManagement.Infrastructure.EFCore.Mappings;

public class Slide2Mapping : IEntityTypeConfiguration<Slide2>
{
    public void Configure(EntityTypeBuilder<Slide2> builder)
    {
        builder.ToTable("Slides2");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Picture).HasMaxLength(1000).IsRequired();
        builder.Property(x => x.PictureAlt).HasMaxLength(500).IsRequired();

        builder.Property(x => x.PictureTitle).HasMaxLength(500).IsRequired();
        builder.Property(x => x.Title).HasMaxLength(255).IsRequired();
        builder.Property(x => x.Text).HasMaxLength(255);
        builder.Property(x => x.BtnText).HasMaxLength(50).IsRequired();
    }
}