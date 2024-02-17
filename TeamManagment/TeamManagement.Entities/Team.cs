using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManagement.Entities
{
    public class Team
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ClothColor Cloth { get; set; }
    }
    public enum ClothColor
    {
        White = 1,
        Red = 2,
        Blue = 3,
        Yellow = 4,

    }
}
