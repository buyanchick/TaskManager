using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Models.TaskModels;

namespace Persistence.Configurations
{
    public class TaskListConfiguration : IEntityTypeConfiguration<TaskList>
    {
        public void Configure(EntityTypeBuilder<TaskList> builder)
        {
            builder.Property(t => t.Title)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
