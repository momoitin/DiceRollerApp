using DnDApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Linq;

namespace DnDApp
{

    //Data is saved to database
    //Listview updates when page is refreshed
    //ToDo: 
    //1. Make a new screen to add money
    //2. make copper, silver, gold, and platinum display seperatly
    //3. Make a useable UI for the Wallet

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WalletMenu : ContentPage
	{
		public WalletMenu ()
		{
			InitializeComponent ();
            
		}

        //Updates database then clears all text box fields to null
        private void UpdateDataClearFields()
        {
            
            
            //Reset input boxes on press
            CopperTextBox.Text = null;
            SilverTextBox.Text = null;
            GoldTextBox.Text = null;
            PlatinumTextBox.Text = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        private async void MainMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }

        
        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            //Generates data from text boxes to be sent to the database
            Money money = new Money()
            {
                Copper = CopperTextBox.Text,
                Silver = SilverTextBox.Text,
                Gold = GoldTextBox.Text,
                Platinum = PlatinumTextBox.Text
            };

            //insert money into table
            try
            {
                
            }
            catch
            {

            }

            UpdateDataClearFields();

        }
        private void UpdateButton_Clicked(object sender, EventArgs e)
        {
           
        }

        private void ClearData_Clicked(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {

            }
        }

        
    }
}