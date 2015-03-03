using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using RestfulApplication.Clients.Core;

namespace RestfulApplication.Clients.CrossPlatforms.Views
{
    public partial class MainPageView //: NavigationPage
    {
        public MainPageView()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }

        private async void NavigateToDetailsPage(object sender, EventArgs e)
        {
            try
            {
                var detailsPage = new DetailsPageView();
                //var navigationPage = new NavigationPage(new DetailsPageView());
                //await 
                //Navigation.PushAsync(detailsPage);
                await Navigation.PushModalAsync(detailsPage);
            }
            catch(Exception exc)
            {
                throw;
            }
        }
    }
}
