
using System.Linq.Expressions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Exceptions;
using Microsoft.Extensions.Logging;

[ApiController]
public class UserController(ILogger<UserController> logger) : ControllerBase {
    
    private readonly ILogger<UserController> _logger = logger;

    [HttpGet("/get-user/{userId}")]
    public IActionResult GetUserById(string userId) {
        return Ok("You just sent through the value: " + userId);
    }

    [HttpPost("/create-user")]
    public ActionResult<UserDto> CreateUser([FromBody] UserDto userDto) {
        var createdUser = new User(userDto.Email, userDto.Password, userDto.PhoneNumber);
        try {
            if (true) { // simulate triger of user already existing
                var existingUser = new User();
                existingUser.Email = "InUse";
                 _logger.LogInformation($"Attempted to create a user with email '{userDto.Email}', but a user already exists with the same email.");
                throw new EntityAlreadyExistsException<User>(existingUser);
            } 
            // else {
            //     createdUser.Id = Guid.NewGuid();
            //     return Ok(createdUser);
            // }
            
        } catch (EntityAlreadyExistsException<User> ex) {
            return Conflict($"User with email '{ex.ExistingEntity.Email}' already exists");
        }
    }
}
