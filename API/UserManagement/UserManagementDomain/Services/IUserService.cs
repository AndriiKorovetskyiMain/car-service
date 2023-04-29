using UserManagementDomain.Dto;

namespace UserManagementDomain.Services;

public interface IUserService
{
    User? GetById(int id);

    IEnumerable<User> GetList(bool includeInactive = false);

    User Create(UserDto userDto);
    
    void Activate(int id);
    
    void Deactivate(int id);

    void Delete(int id);
}