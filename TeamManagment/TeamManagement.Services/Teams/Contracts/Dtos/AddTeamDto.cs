using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManagement.Entities;

namespace TeamManagement.Services.Teams.Contracts.Dtos
{
    public class AddTeamDto
    {
        public string Name { get; set; }
        public ClothColor Cloth  { get; set; }
    }
}
