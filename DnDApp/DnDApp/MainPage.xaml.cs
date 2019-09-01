using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace DnDApp
{
    public partial class MainPage : ContentPage
    {
        private void RollDice(int maxRoll, object sender)
        {
            int minRoll = 1;
            Random GetRandom = new Random();
            int roll = GetRandom.Next(minRoll, maxRoll+1);
            MainLabel.Text = ((Button)sender).Text + $":\n\n {roll}";
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

        public MainPage()
        {
            InitializeComponent();
        }

        private void D20_Clicked(object sender, EventArgs e)
        {
            RollDice(20, (Button)sender);
            VibrateDevice();
        }

        private void D12_Clicked(object sender, EventArgs e)
        {
            RollDice(12, (Button)sender);
            VibrateDevice();
        }

        private void D10_Clicked(object sender, EventArgs e)
        {
            RollDice(10, (Button)sender);
            VibrateDevice();
        }

        private void D8_Clicked(object sender, EventArgs e)
        {
            RollDice(8, (Button)sender);
            VibrateDevice();
        }

        private void D6_Clicked(object sender, EventArgs e)
        {
            RollDice(6, (Button)sender);
            VibrateDevice();
        }

        private void D4_Clicked(object sender, EventArgs e)
        {
            RollDice(4, (Button)sender);
            VibrateDevice();
        }

        private async void MenuPageButton_Clicked(object sender, EventArgs e)
        {
            VibrateDevice();
            await Navigation.PushAsync(new MenuPage());
        }
    }
}
