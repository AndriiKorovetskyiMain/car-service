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

    [HttpGet("{id:int}", Name = "GetUserById")]
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
    
    [HttpPut("{id:int}/activate", Name = "ActivateUser")]
    public ActionResult Activate(int id)
    {
        _userService.Activate(id);

        return NoContent();
    }
    
    [HttpPut("{id:int}/deactivate", Name = "DeactivateUser")]
    public ActionResult Deactivate(int id)
    {
        _userService.Deactivate(id);
    
        return NoContent();
    }

    [HttpDelete("{id:int}", Name = "DeleteUser")]
    public ActionResult Delete(int id)
    {
        _userService.Delete(id);

        return NoContent();
    }
}