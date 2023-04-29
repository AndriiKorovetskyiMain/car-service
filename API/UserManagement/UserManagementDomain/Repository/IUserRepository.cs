namespace UserManagementDomain.Repository;

public interface IUserRepository
{
    User GetById(int id);
    void Create(User user);
    void Update(User user);
    void Delete(int id);
}