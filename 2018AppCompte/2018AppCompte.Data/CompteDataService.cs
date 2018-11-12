using _2018AppCompte.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018AppCompte.Data
{
    public class CompteDataService
    {

        public List<Compte> GetLesComptes()
        {
            var lesComptes = new List<Compte>();
            lesComptes.Add(new Compte()
            {
                DateInitiale = new DateTime(2018, 09, 01),
                MontantInitial = 1234.56,
                NomCompte = "Compte Cheque",
                NumCompte = 123456
            });
            lesComptes.Add(new Compte()
            {
                DateInitiale = new DateTime(2018, 09, 01),
                MontantInitial = 1000.43,
                NomCompte = "Livret",
                NumCompte = 789012
            });

            return lesComptes;
        }
    }
}
