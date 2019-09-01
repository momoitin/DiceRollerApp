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
	public partial class DamageMenu : ContentPage
	{
		public DamageMenu ()
		{
            InitializeComponent();
		}

        const int minRoll = 1;
        bool isAttackRoll = false;

        //Creates a random integer and sends it to the right place
        private void RollDice(int maxRoll, object sender, int Bonus, bool isAttackRoll)
        {
            try
            {
                //If damage or attack roll bonus is blank, set equal to zero
                if (attackBonusTextBox.Text == "" || damageBonusTextBox.Text == "")
                {
                    attackBonusTextBox.Text = "0";
                    damageBonusTextBox.Text = "0";
                }

                Random GetRandom = new Random();
                int roll = 0;

                //If switch at Grid 8,0 is toggeled, Bonus will be shown outside roll
                if(ShowAddititivesSwitch.IsToggled == false)
                {
                    roll = GetRandom.Next(minRoll, maxRoll + 1) + Bonus;

                    //if this is an attack roll
                    if(isAttackRoll == true)
                    {
                        switch(roll - Bonus)
                        {
                            case 1:
                                ((Button)sender).Text = "Natural 1";
                                break;
                            case 20:
                                ((Button)sender).Text = "Natural 20";
                                break;
                            default:
                                ((Button)sender).Text = roll.ToString();
                                break;
                        }
                    }
                    else //if the attackRoll button is not clicked, this else is called instead
                    {
                        ((Button)sender).Text = roll.ToString();
                    }
                }
                else
                {
                    roll = GetRandom.Next(minRoll, maxRoll + 1);

                    //if this is an attack roll
                    if (isAttackRoll == true)
                    {
                        switch (roll)
                        {
                            case 1:
                                ((Button)sender).Text = $"Natural 1 + {Bonus}";
                                break;
                            case 20:
                                ((Button)sender).Text = $"Natural 20 + {Bonus}";
                                break;
                            default:
                                ((Button)sender).Text = $"{roll} + {Bonus}";
                                break;
                        }
                    }
                    else //if the attackRoll button is not clicked, this else is called instead
                    {
                        ((Button)sender).Text = $"{roll} + {Bonus}";
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Math is hard but the MultiattackRoll Method makes it easier to calculate
        private void MultiAttackRoll(int maxRoll, object sender, int Bonus)
        {
            try
            {
                //If damage or attack roll bonus is blank, set equal to zero
                if (attackBonusTextBox.Text == "" || damageBonusTextBox.Text == "")
                {
                    attackBonusTextBox.Text = "0";
                    damageBonusTextBox.Text = "0";
                }

                Random GetRandom = new Random();
                int roll = 0;

                //If switch at Grid 8,0 is toggeled, Bonus will be shown outside roll
                if (ShowAddititivesSwitch.IsToggled == false)
                {
                    roll = GetRandom.Next(minRoll, maxRoll + 1) + Bonus;
                    ((Button)sender).Text = roll.ToString();
                }
                else
                {
                    roll = GetRandom.Next(minRoll, maxRoll + 1);
                    ((Button)sender).Text = $"{roll} + {Bonus}";

                    //show total roll + bonus in multi attack menu
                    roll += Bonus;
                }

                int temp = Convert.ToInt32(MultiAttackLabel.Text);
                temp += roll;

                MultiAttackLabel.Text = temp.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Vibrate Method to call on all button presses
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


        //Dice Buttons
        private void AttackRollButton_Clicked(object sender, EventArgs e)
        {
            int D20 = 20;
            isAttackRoll = true;
            int attackBonus = Convert.ToInt32(attackBonusTextBox.Text);

            RollDice(D20, (Button)sender, attackBonus, isAttackRoll);
            
            VibrateDevice();
        }

        private void D12RollButton_Clicked(object sender, EventArgs e)
        {
            int D12 = 12;
            isAttackRoll = false;
            int damageBonus = Convert.ToInt32(damageBonusTextBox.Text);

            if (MultiAttackLabel.IsVisible == false)
            {
                RollDice(D12, (Button)sender, damageBonus, isAttackRoll);
            }
            else
            {
                MultiAttackRoll(D12, (Button)sender, damageBonus);
            }

            VibrateDevice();
        }

        private void D10RollButton_Clicked(object sender, EventArgs e)
        {
            int D10 = 10;
            isAttackRoll = false;
            int damageBonus = Convert.ToInt32(damageBonusTextBox.Text);

            if (MultiAttackLabel.IsVisible == false)
            {
                RollDice(D10, (Button)sender, damageBonus, isAttackRoll);
            }
            else
            {
                MultiAttackRoll(D10, (Button)sender, damageBonus);
            }

            VibrateDevice();
        }

        private void D8RollButton_Clicked(object sender, EventArgs e)
        {
            int D8 = 8;
            isAttackRoll = false;
            int damageBonus = Convert.ToInt32(damageBonusTextBox.Text);

            if (MultiAttackLabel.IsVisible == false)
            {
                RollDice(D8, (Button)sender, damageBonus, isAttackRoll);
            }
            else
            {
                MultiAttackRoll(D8, (Button)sender, damageBonus);
            }

            VibrateDevice();
        }

        private void D6RollButton_Clicked(object sender, EventArgs e)
        {
            int D6 = 6;
            isAttackRoll = false;
            int damageBonus = Convert.ToInt32(damageBonusTextBox.Text);

            if (MultiAttackLabel.IsVisible == false)
            {
                RollDice(D6, (Button)sender, damageBonus, isAttackRoll);
            }
            else
            {
                MultiAttackRoll(D6, (Button)sender, damageBonus);
            }

            VibrateDevice();
        }

        private void D4RollButton_Clicked(object sender, EventArgs e)
        {
            int D4 = 4;
            isAttackRoll = false;
            int damageBonus = Convert.ToInt32(damageBonusTextBox.Text);

            if (MultiAttackLabel.IsVisible == false)
            {
                RollDice(D4, (Button)sender, damageBonus, isAttackRoll);
            }
            else
            {
                MultiAttackRoll(D4, (Button)sender, damageBonus);
            }

            VibrateDevice();
        }

        private void MultiAttackMenuButton_Clicked(object sender, EventArgs e)
        {
            if(MultiAttackLabel.IsVisible == false)
            {
                MultiAttackLabel.IsVisible = true;
                MultiAttackResetButton.IsVisible = true;
            }
            else
            {
                MultiAttackLabel.IsVisible = false;
                MultiAttackResetButton.IsVisible = false;
            }

            VibrateDevice();
        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            //Multi attack Menu
            MultiAttackLabel.Text = "0";
            MultiAttackLabel.IsVisible = false;
            MultiAttackResetButton.IsVisible = false;

            //Dice buttons
            attackRollButton.Text = "Roll";
            D12RollButton.Text = "Roll";
            D10RollButton.Text = "Roll";
            D8RollButton.Text = "Roll";
            D6RollButton.Text = "Roll";
            D4RollButton.Text = "Roll";

            //resets text boxes
            attackBonusTextBox.Text = null;
            damageBonusTextBox.Text = null;

            //Bonus Switch
            ShowAddititivesSwitch.IsToggled = false;

            VibrateDevice();
        }

        private void MultiAttackResetButton_Clicked(object sender, EventArgs e)
        {
            MultiAttackLabel.Text = "0";
            VibrateDevice();
        }

        private async void Menu_Clicked(object sender, EventArgs e)
        {
            VibrateDevice();
            await Navigation.PushAsync(new MenuPage());
        }
    }
}