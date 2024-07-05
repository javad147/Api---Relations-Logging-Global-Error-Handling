public interface IGroupService
{
    Task<IEnumerable<GroupDto>> GetAll();
    Task<GroupDto> GetById(int id);
    Task Add(GroupDto groupDto);
    Task Update(GroupDto groupDto);
    Task Delete(int id);
    Task<IEnumerable<GroupDto>> Search(string name);
}
