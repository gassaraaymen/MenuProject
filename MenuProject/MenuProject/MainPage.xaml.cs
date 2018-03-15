using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MenuProject
{
	public partial class MainPage : MasterDetailPage
    {
		public MainPage()
		{
			InitializeComponent();

            ListView1.ItemsSource = new List<Menu>
            {
                     new Menu{ Name ="My ACCOUNT"},
                     new Menu{ Name ="SHOP"},
                     new Menu{ Name ="FAQ"},
                     new Menu{ Name ="NOTIFICATIONS",Status = "2"}

        };
        }
        private void LV1(object sender, SelectedItemChangedEventArgs e)
        {
            var Item = e.SelectedItem as Menu;

            if (Item.Name.Equals("My ACCOUNT"))
            {
                Detail = new AccountPage();
                IsPresented = false;
            }
            else
               if (Item.Name.Equals("SHOP"))
            {
                Detail = new ShopPage();
                IsPresented = false;
            }
            else
               if (Item.Name.Equals("FAQ"))
            {
                Detail = new FAQPage();
                IsPresented = false;
            }
            else
               if (Item.Name.Equals("NOTIFICATIONS"))
            {
                Detail = new NotificationPage();
                IsPresented = false;
            }

        }

    }
}
