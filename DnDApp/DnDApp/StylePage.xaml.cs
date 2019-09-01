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
    public partial class StylePage : ContentPage
    {
        public StylePage()
        {
            InitializeComponent();
        }

        void OnDoneButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        void OnApplyThemeClicked(object sender, EventArgs e)
        {
            try
            {
                //App.Current.Resources["backgroundColor"] = Color.FromHex(backgroundColorEntry.Text);
                //App.Current.Resources["textColor"] = Color.FromHex(textColorEntry.Text);
            }
            catch (Exception)
            {
                //Nothing Happens
            }
        }

        private void NormalTheme_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Color Black for Text
                App.Current.Resources["textColor"] = Color.FromHex("000000");
                //Color for Placeholder Text default is 40% opacity
                App.Current.Resources["placeholderTextColor"] = Color.FromHex("66000000");
                //Color for Background android:colorBackground
                App.Current.Resources["backgroundColor"] = Color.FromHex("FFFFFF");
                //color for Main Buttons
                App.Current.Resources["buttonColor"] = Color.FromHex("e0e0e0");
            }
            catch (Exception)
            {
                //Nothing Happens
            }
        }

        private void DarkTheme_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Color Black for Text android:colorForeground
                App.Current.Resources["textColor"] = Color.FromHex("FFFFFF");
                //Color for Placeholder Text default is 40% opacity
                App.Current.Resources["placeholderTextColor"] = Color.FromHex("66ffffff");
                //Color for Background android:colorBackground
                App.Current.Resources["backgroundColor"] = Color.FromHex("616161");
                //color for Main Buttons
                App.Current.Resources["buttonColor"] = Color.FromHex("373737");
            }
            catch (Exception)
            {
                //Nothing Happens
            }
        }
    }
}