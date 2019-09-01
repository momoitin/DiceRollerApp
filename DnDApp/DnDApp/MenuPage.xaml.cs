using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace DnDApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
        public MenuPage ()
		{
			InitializeComponent ();
		}

        private void VibrateDevice()
        {
            try
            {
                //Vibrate for 20 milliseconds
                var duration = TimeSpan.FromMilliseconds(20);
                Vibration.Vibrate(duration);
            }
            catch (FeatureNotSupportedException)
            {
                // Feature not supported on device
            }
            catch (Exception)
            {
                // Other error has occurred.
            }
        }

        private async void DicePage_Clicked(object sender, EventArgs e)
        {
            VibrateDevice();
            await Navigation.PushAsync(new MainPage());
        }
        private async void CustomDice_Clicked(object sender, EventArgs e)
        {
            VibrateDevice();
            await Navigation.PushAsync(new CustomDiceMenu());
        }

        private async void DamageMenu_Clicked(object sender, EventArgs e)
        {
            VibrateDevice();
            await Navigation.PushAsync(new DamageMenu());
        }

        private async void WalletMenu_Clicked(object sender, EventArgs e)
        {
            VibrateDevice();
            await Navigation.PushAsync(new WalletMenu());
        }

        private void ColorMenu_Clicked(object sender, EventArgs e)
        {
            VibrateDevice();
            Navigation.PushModalAsync(new ColorNavigationPage(new StylePage()));
        }
    }
}