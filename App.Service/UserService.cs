using App.DAL;
using App.Domain;

namespace App.Service;

public class UserService
{
    private readonly UserRepository _repository;

    public UserService(UserRepository repository)
    {
        _repository = repository;
    }

    public void Add(User user)
    {
        _repository.Add(user);
    }

    public User GetProductById(int id)
    {
        return _repository.GetById(id);
    }
}
