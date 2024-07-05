using Domain.Common;

public class Group : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Student> Students { get; set; }
}
