using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Models.TaskModels;

namespace Persistence.Configurations
{
    public class TaskItemConfiguration : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasIndex(t => t.Id).IsUnique();
            builder.Property(t => t.Title)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}
