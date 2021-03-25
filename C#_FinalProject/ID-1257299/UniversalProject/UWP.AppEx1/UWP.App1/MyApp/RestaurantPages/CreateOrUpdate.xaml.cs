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
    // _dev


    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateOrUpdate : Page
    {
        IRepository<Product> repo = null;
        public CreateOrUpdate()
        {
            repo = (IRepository<Product>)Factory.GetRepo();// _dev
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            if (e.Parameter != null)
            {
                AddUpdatePageTitle.Text = "Update existing Item";

                var Id = (int)e.Parameter;
                var item = repo.Get(Id);
                ID.Text = item.ID.ToString();
                Name.Text = item.Name;
                Quantity.Text = item.Quantity.ToString();
                Buyer.Text = item.Buyer.ToString();
                Price.Text = item.Price.ToString();



            }
            else
            {
                AddUpdatePageTitle.Text = "Create a new Item";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Content.ToString() == "Cancel")
            {
                App.RootFrame.Navigate(typeof(ShowAll));
            }
            else
            {
                int tempId = 0;
                if (ID.Text != null && ID.Text != "")
                    tempId = int.Parse(ID.Text.Trim());

                var inputData = new Product
                {
                    ID = tempId, 
                    Name = Name.Text,
                    Quantity = int.Parse(Quantity.Text),
                    Buyer = Buyer.Text.Trim().ToLower(),
                    Price = double.Parse(Price.Text.ToString())
                };  

                if (inputData.ID > 0) repo.Update(inputData);
                else repo.Add(inputData);

            }

            // go back to list page
            App.RootFrame.Navigate(typeof(ShowAll));
        }

    }//c
}//ns