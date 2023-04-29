using Microsoft.AspNetCore.Mvc;
using UserManagementDomain;
using UserManagementDomain.Dto;
using UserManagementDomain.Services;

namespace UserManagementRestApi.Controllers;

[ApiController]
[Route("users/{id:int}")]
public class UserManagementController : ControllerBase
{
    private readonly IUserService _userService;

    public UserManagementController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("", Name = "GetUserById")]
    public ActionResult<User> GetById(int id)
    {
        var user = _userService.GetById(id);

        if (user is null) return NotFound();

        return Ok(user);
    }

    [HttpPost(Name = "CreateUser")]
    public ActionResult<User> Create([FromBody] UserDto userDto)
    {
        var user = _userService.Create(userDto);

        return Ok(user);
    }

    [HttpDelete("", Name = "DeleteUser")]
    public ActionResult Delete(int id)
    {
        _userService.Delete(id);

        return NoContent();
    }
}