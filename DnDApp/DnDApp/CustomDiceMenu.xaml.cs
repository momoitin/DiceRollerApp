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
    public partial class CustomDiceMenu : ContentPage
    {
        public CustomDiceMenu()
        {
            InitializeComponent();
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

        private async void MenuButton_Clicked(object sender, EventArgs e)
        {
            VibrateDevice();
            await Navigation.PushAsync(new MenuPage());
        }

        private void MinRollInput_Completed(object sender, EventArgs e)
        {
            //sets focus to Max Roll for input.
            MaxRollInput.Focus();
        }

        private void RollButton_Clicked(object sender, EventArgs e)
        {
            VibrateDevice();
            int minRoll = Convert.ToInt32(MinRollInput.Text),
                maxRoll = Convert.ToInt32(MaxRollInput.Text);

            try
            {
                if(MinRollInput.Text != null && MaxRollInput.Text != null)
                {
                    Random GetRandom = new Random();
                    int roll = GetRandom.Next(minRoll, maxRoll + 1);
                    RollOutputLabel.Text = roll.ToString();
                }
            }
            catch(Exception)
            {

            }
        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                MinRollInput.Text = null;
                MaxRollInput.Text = null;
                RollOutputLabel.Text = "Roll Output";
            }
            catch(Exception)
            {

            };
        }
    }
}