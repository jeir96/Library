using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App13
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SellAndBuy());
        }


    }
}
