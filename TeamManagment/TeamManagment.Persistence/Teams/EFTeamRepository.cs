using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManagement.Entities;
using TeamManagement.Services.Teams.Contracts;

namespace TeamManagment.Persistence.Teams
{
    public class EFTeamRepository : TeamRepository
    {
        public readonly EFDataContext _context;
        public EFTeamRepository(EFDataContext context)
        {
            _context = context;
        }

        public void AddTeam(Team team)
        {
            _context.Teams.Add(team);
        }

        public List<Team> DeleteTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetAllTeam()
        {
            throw new NotImplementedException();
        }

        public void UpdateTeam(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
