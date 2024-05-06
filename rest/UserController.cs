
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class UserController : ControllerBase {


    [HttpGet("/get-user/{userId}")]
    public IActionResult CreateUser(string userId) {
        return Ok("You just sent through the value: " + userId);
    }
}
