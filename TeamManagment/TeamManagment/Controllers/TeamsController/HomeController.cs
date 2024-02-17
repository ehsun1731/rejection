using Microsoft.AspNetCore.Mvc;
using TeamManagement.Services.Teams.Contracts;
using TeamManagement.Services.Teams.Contracts.Dtos;

namespace TeamManagment.Controllers.TeamsController
{
    [Route("api/Teams")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly TeamService _service;

        public TeamsController(TeamService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task AddTeam(AddTeamDto dto)
        {
            await _service.AddTeam(dto);
        }


    }
}
