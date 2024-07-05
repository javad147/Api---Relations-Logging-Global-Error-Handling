using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Id).ValueGeneratedOnAdd(); 
        builder.Property(s => s.Name).IsRequired().HasMaxLength(100);
        builder.HasOne(s => s.Group)
               .WithMany(g => g.Students)
               .HasForeignKey(s => s.GroupId);
    }
}