using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using RestfulApplication.Clients.Core;
using RestfulApplication.Models;

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

        private async void NavigateToDetailsPageView(object sender, EventArgs e)
        {
            try
            {
                var detailsPage = new DetailsPageView();

                var mainViewModel = BindingContext as MainViewModel;

                var selectedEmployee = ((ListView)sender).SelectedItem as Employee;

                //detailsPage.BindingContext = selectedEmployee;

                mainViewModel.SendEmployeeMessageCommand.Execute(selectedEmployee);

                await Navigation.PushModalAsync(detailsPage);
            }
            catch(Exception exc)
            {
                throw;
            }
        }
    }
}
