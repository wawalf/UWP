using _2018AppCompte.Model;
using _2018AppCompte.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace _2018AppCompte.View
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class CompteDetailView : Page
    {
        public CompteDetailViewModel dataContextView;
        public CompteDetailView()
        {
            this.InitializeComponent();
            
        }

        //protected override void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    base.OnNavigatedTo(e);
        //    //dataContextView = (CompteDetailViewModel)e.Parameter;
        //    //this.DataContext = dataContextView.SelectedCompte;

        //}

        private void btnTest2_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
