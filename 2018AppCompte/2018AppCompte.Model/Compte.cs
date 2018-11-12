using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018AppCompte.Model
{
    public class Compte : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        private int numCompte;

        public int NumCompte
        {
            get { return numCompte; }
            set {
                numCompte = value;
                RaisePropertyChanged("NumCompte");
            }
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

        private DateTime dateInitiale;

        
        public DateTime DateInitiale
        {
            get { return dateInitiale; }
            set { dateInitiale = value; }
        }



    }
}
