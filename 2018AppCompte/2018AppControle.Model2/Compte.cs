using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018AppCompte.Model
{
    public class Compte
    {
        private int numCompte;

        public int NumCompte
        {
            get { return numCompte; }
            set { numCompte = value; }
        }


        private string nomCompte;

        public string NomCompte
        {
            get { return nomCompte; }
            set { nomCompte = value; }
        }

        private double montantInitial;

        public double MontantInitial
        {
            get { return montantInitial; }
            set { montantInitial = value; }
        }

        //private DateTime dateInitiale;

        //public DateTime DateInitiale
        //{
        //    get { return dateInitiale; }
        //    set { dateInitiale = value; }
        //}






    }
}
