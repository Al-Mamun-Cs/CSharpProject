using ConPJ1.DTO;
using ConPJ1.MyApp;
using ConPJ1.Repository;
using ConPJ1.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP.App1.MyApp.RestaurantPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShowAll : Page
    {
        IRepository<Product> repo = null;
        public ShowAll()
        {
            Factory.SelectedPackage = Packages.Product;// _dev
            repo = (IRepository<Product>)Factory.GetRepo();
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            listView.ItemsSource = repo.GetAll();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            switch ((sender as Button).Content.ToString())
            {
                case "Add New Item":
                    App.RootFrame.Navigate(typeof(CreateOrUpdate));
                    break;

                default:
                    break;
            }
        }

        private void Update_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            int ItempId = int.Parse((sender as Button).CommandParameter.ToString());
            App.RootFrame.Navigate(typeof(CreateOrUpdate), ItempId);
        }

        private void Delete_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            int ItempId = int.Parse((sender as Button).CommandParameter.ToString());
            App.RootFrame.Navigate(typeof(Delete), ItempId);
        }

    }//c
}//ns
