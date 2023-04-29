using Microsoft.AspNetCore.Mvc;
using UserManagementDomain;
using UserManagementDomain.Dto;
using UserManagementDomain.Services;

namespace UserManagementRestApi.Controllers;

[ApiController]
[Route("users")]
public class UserManagementController : ControllerBase
{
    private readonly IUserService _userService;

    public UserManagementController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost(Name = "CreateUser")]
    public ActionResult<User> Create([FromBody] UserDto userDto)
    {
        var user = _userService.Create(userDto);

        return Ok(user);
    }

    [HttpDelete("{id:int}", Name = "DeleteUser")]
    public ActionResult Delete(int id)
    {
        _userService.Delete(id);

        return NoContent();
    }
}