using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManagement.Entities;

namespace TeamManagement.Services.Teams.Contracts
{
    public interface TeamRepository
    {
        void AddTeam(Team team);
        void UpdateTeam(Team team);

        List<Team> GetAllTeam();

        List<Team> DeleteTeam(Team team);
    }
}
