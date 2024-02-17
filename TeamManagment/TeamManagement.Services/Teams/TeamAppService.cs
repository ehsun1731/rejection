using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManagement.Entities;
using TeamManagement.Services.Teams.Contracts;
using TeamManagement.Services.Teams.Contracts.Dtos;

using UnitOfWorks;

namespace TeamManagement.Services.Teams
{
    public class TeamAppService : TeamService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly TeamRepository _teamRepository;
        public TeamAppService(UnitOfWork unitOfWork, TeamRepository teamrepository)
        {
            _unitOfWork = unitOfWork;
           this. _teamRepository = teamrepository;

        }
        public async Task AddTeam(AddTeamDto Dto)
        {
            var team = new Team
            { Name = Dto.Name ,
            Cloth=Dto.Cloth
            };
            _teamRepository.AddTeam(team);
            await _unitOfWork.Complete();
        }

       
            public  Task<List<Team>> DeleteTeam(DeleteTeamDto Dto )
            {
            
            


        }

        public async Task<List<Team>> GetAllTeam()
        {
            return _teamRepository.GetAllTeam();
        }

        public Task UpdateTeam(UpdateTeamDto Dto)
        {
            throw new NotImplementedException();
        }
    }
}
