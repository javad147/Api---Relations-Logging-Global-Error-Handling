using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        //builder.HasKey(g => g.Id);
        builder.HasMany(g => g.Students)
               .WithOne(s => s.Group)
               .HasForeignKey(s => s.GroupId);
    }
}
