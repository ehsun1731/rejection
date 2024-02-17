using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManagement.Entities;
using TeamManagement.Services.Teams.Contracts.Dtos;

namespace TeamManagement.Services.Teams.Contracts
{
    public interface TeamService
    {
        public Task AddTeam(AddTeamDto Dto);
        public Task UpdateTeam(UpdateTeamDto Dto);

        Task<List<Team>> DeleteTeam(DeleteTeamDto Dto);
        Task<List<Team>> GetTeam();
    }
}
