using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnage.Models
{
    internal class Personnage
    {
        public int id { get; set; }
        public string Pseudo { get; set; }
        public int PointsDeVie { get; set; }
        public int Armure { get; set; }
        public int Degats { get; set; }
        public DateTime DateCreation { get; set; }
        public int Kills { get; set; }
    }
}
