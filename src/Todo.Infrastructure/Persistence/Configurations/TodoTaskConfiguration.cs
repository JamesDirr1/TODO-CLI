using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todo.Core;

namespace Todo.Infrastructure.Persistence.Configurations;

public class TodoTaskConfiguration : IEntityTypeConfiguration<TodoTask>
{
    public void Configure(EntityTypeBuilder<TodoTask> builder)
    {
        builder.HasKey(task => task.Id);
        builder.Property(task => task.Id).ValueGeneratedOnAdd();

        builder.Property(task => task.Title)
            .IsRequired()
            .HasMaxLength(TodoTask.MaxTitleLength);

        builder.Property(task => task.Status)
            .IsRequired()
            .HasConversion<string>();
    }
}