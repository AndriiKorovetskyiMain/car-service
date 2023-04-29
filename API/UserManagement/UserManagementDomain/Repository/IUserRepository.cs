namespace UserManagementDomain.Repository;

public interface IUserRepository
{
    User? GetById(int id);
    
    IEnumerable<User> GetList(bool includeInactive = false);

    void Create(User user);

    void Update(User user);

    void Activate(int id);
    
    void Deactivate(int id);

    void Delete(int id);
}