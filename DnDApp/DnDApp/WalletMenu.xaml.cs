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
using System.IO;

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
        public string FilePath = @"C:\Users\ringo\source\repos\DiceRollerApp\DnDApp\DnDApp.Android\Resources\Wallet.txt";


        public WalletMenu ()
		{
			InitializeComponent ();

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(FilePath).ToList();
            foreach (string line in lines)
            {
                CopperValue.Text = lines.ElementAt(0);
                SilverValue.Text = lines.ElementAt(1);
                GoldValue.Text = lines.ElementAt(2);
                PlatValue.Text = lines.ElementAt(3);
            }
        }
        private int StringToInt(string Money, string Total)
        {
            if (Money != "")
            {
                int value = Convert.ToInt32(Money) + Convert.ToInt32(Total);
                return value;
            }
            else
            {
                return Convert.ToInt32(Total);
            }
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
            CopperValue.Text = (StringToInt(CopperTextBox.Text, CopperValue.Text)).ToString();

            SilverValue.Text = (StringToInt(SilverTextBox.Text, SilverValue.Text)).ToString();

            GoldValue.Text = (StringToInt(GoldTextBox.Text, GoldValue.Text)).ToString();

            PlatValue.Text = (StringToInt(PlatTextBox.Text, PlatValue.Text)).ToString();

            //creates a single string with multiple lines with each value.
            String Wallet = CopperValue.Text + "\n" + SilverValue.Text + "\n" + GoldValue.Text + "\n" + PlatValue.Text;
            File.WriteAllText(FilePath, Wallet);
        }

        private void ClearData_Clicked(object sender, EventArgs e)
        {
            
        }

        private void UpdateButton_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}