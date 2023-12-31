﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TempusHub.API.Features.Ingests;

public class IngestEfConfiguration : IEntityTypeConfiguration<Ingest>
{
    public void Configure(EntityTypeBuilder<Ingest> builder)
    {
        builder.HasKey(x => x.Date);
        builder.Property(x => x.Date)
            .ValueGeneratedNever();
        builder.Property(x => x.RowsWritten)
            .IsRequired();
        builder.Property(x => x.Completed)
            .IsRequired();
        builder.Property(x => x.Duration)
            .IsRequired();
    }
}