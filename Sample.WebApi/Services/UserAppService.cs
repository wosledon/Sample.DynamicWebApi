using Sample.DynamicWebApi;

namespace Sample.WebApi.Services;

public class CreateOrUpdateUser
{
    public string Name { get; set; }
}

public class UserDto
{
    public string Name { get; set; }
}

public class UserAppService : IApplicationService
{
    public string Create(CreateOrUpdateUser input)
    {
        return $"Hello {input.Name}";
    }

    public string Delete(int id)
    {
        return $"You deleted user with id {id}";
    }

    public string Get(int id)
    {
        return $"You got user with id {id}";
    }

    public IEnumerable<UserDto> GetAll()
    {
        return "You got all users"
        .Split("")
        .Select(temp => new UserDto { Name = temp })
        .ToList();
    }

    public string Update(int id, CreateOrUpdateUser input)
    {
        return $"You updated user with id {id} to {input.Name}";
    }
}