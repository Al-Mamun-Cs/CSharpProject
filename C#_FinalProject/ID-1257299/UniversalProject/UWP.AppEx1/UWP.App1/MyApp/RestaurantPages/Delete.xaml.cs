using ConPJ1.DTO;
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
    public sealed partial class Delete : Page
    {
        private int itemId = 0; // _dev
        IRepository<Product> repo = null;
        public Delete()
        {
            repo = (IRepository<Product>)Factory.GetRepo();
            this.InitializeComponent();
        }
        // _dev
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                itemId = (int)e.Parameter;
                var item = repo.Get(itemId);

                message.Text = string.Format("Are you sure you want to delete {0}?", item.Name);
            }
        }

        // _dev
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Content.ToString())
            {
                case "Yes":
                    repo.Remove(itemId);
                    App.RootFrame.Navigate(typeof(ShowAll));
                    break;

                case "Cancel":
                    App.RootFrame.Navigate(typeof(ShowAll));
                    break;

                default:
                    break;
            }
        }


    }//c
}//ns
