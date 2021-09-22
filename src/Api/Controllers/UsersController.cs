using MediatR;
using Microsoft.AspNetCore.Mvc;
using Rusv.UserManagement.Core.Users.Commands;
using Rusv.UserManagement.Core.Users.Dtos;
using Rusv.UserManagement.Core.Users.Queries;
using Rusv.UserManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rusv.UserManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public UsersController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var query = new GetAllUsersQuery();
            var result = await _mediatr.Send(query);           
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateUser(CreateUserDto userDto)
        {
            var query = new CreateUserCommand(userDto);
            var result = await _mediatr.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(Guid id)
        {
            var query = new GetUserByIdQuery(id);
            var result = await _mediatr.Send(query);
            if (result == null)
                return NotFound();
            return Ok(result);            
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> DeleteUser(Guid id)
        {
            var query = new DeleteUserCommand(id);
            var result = await _mediatr.Send(query);
            return Ok(result);            
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProduct(Guid id, UpdateUserDto userDto)
        {
            var query = new UpdateUserCommand(id, userDto);
            var result = await _mediatr.Send(query);
            return Ok(result);            
        }
    }
}
