
using _2018AppCompte.Data;
using _2018AppCompte.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018AppCompte.ViewModel
{
    public class CompteDetailViewModel :INotifyPropertyChanged
    {
        public CompteDetailViewModel()
        {
            var service = new CompteDataService();
            this.LstComptes= service.GetLesComptes();
            //UnCompte = lesCpt[0];
        }

        private List<Compte> lstComptes;

        public List<Compte> LstComptes
        {
            get { return lstComptes; }
            set { lstComptes = value; }
        }

        private Compte selectedCompte;


        public Compte SelectedCompte
        {
            get { return selectedCompte; }
            set {
                selectedCompte = value;
                RaisePropertyChanged("SelectedCompte");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


    }
}
