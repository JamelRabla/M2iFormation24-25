using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using csharp.classe;

namespace salarie.classe
{
    internal class Commercial : Salarie
    {
        public decimal ChiffreAffaire { get; set; } = 0;

        public decimal Commission { get; set; } = 0;

        public Commercial() : base()
        {
            Prenom = "Defaut";
        }

        public Commercial(string matricule, string prenom, double salaire,
                            string categorie, string service, decimal chiffreAffaire,
                            decimal commission) : base(matricule, prenom, salaire, categorie, service)
        {
            ChiffreAffaire = chiffreAffaire;
            Commission = commission;
        }

    }
}
