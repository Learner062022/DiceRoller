using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DylanDeSouzaWk11ExDiceRoller
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        Random randomNumberGenerator = new Random();
        string str_individual_roll, str_individual_rolls;
        int int_total = 0;

        private void dice_blue_2sided_Click(object sender, RoutedEventArgs e)
        {
            int intResult2SidedDice = randomNumberGenerator.Next(1, 2);
            int_total += intResult2SidedDice;
            total_of_all_dice_rolls.Text = int_total.ToString();
            str_individual_roll = intResult2SidedDice.ToString();
            str_individual_rolls = individual_rolls.Text;
            if (str_individual_rolls.Length < 1)
            {
                individual_rolls.Text += str_individual_roll;
            }
            else
            {
                individual_rolls.Text = individual_rolls.Text + "+" + str_individual_roll;
            }
            
        }

        private void dice_blue_3sided_Click(object sender, RoutedEventArgs e)
        {
            int intResult3SidedDice = randomNumberGenerator.Next(1, 3);
            int_total += intResult3SidedDice;
            total_of_all_dice_rolls.Text = int_total.ToString();
            str_individual_roll = intResult3SidedDice.ToString();
            str_individual_rolls = individual_rolls.Text;
            if (str_individual_rolls.Length < 1)
            {
                individual_rolls.Text += str_individual_roll;
            }
            else
            {
                individual_rolls.Text = individual_rolls.Text + "+" + str_individual_roll;
            }
        }

        private void dice_blue_4sided_Click(object sender, RoutedEventArgs e)
        {
            int intResult4SidedDice = randomNumberGenerator.Next(1, 4);
            int_total += intResult4SidedDice;
            total_of_all_dice_rolls.Text = int_total.ToString();
            str_individual_roll = intResult4SidedDice.ToString();
            str_individual_rolls = individual_rolls.Text;
            if (str_individual_rolls.Length < 1)
            {
                individual_rolls.Text += str_individual_roll;
            }
            else
            {
                individual_rolls.Text = individual_rolls.Text + "+" + str_individual_roll;
            }
        }

        private void dice_blue_6sided_Click(object sender, RoutedEventArgs e)
        {
            int intResult6SidedDice = randomNumberGenerator.Next(1, 2);
            int_total += intResult6SidedDice;
            total_of_all_dice_rolls.Text = int_total.ToString();
            str_individual_roll = intResult6SidedDice.ToString();
            str_individual_rolls = individual_rolls.Text;
            if (str_individual_rolls.Length < 1)
            {
                individual_rolls.Text += str_individual_roll;
            }
            else
            {
                individual_rolls.Text = individual_rolls.Text + "+" + str_individual_roll;
            }
        }

        private void dice_blue_8sided_Click(object sender, RoutedEventArgs e)
        {
            int intResult8SidedDice = randomNumberGenerator.Next(1, 2);
            int_total += intResult8SidedDice;
            total_of_all_dice_rolls.Text = int_total.ToString();
            str_individual_roll = intResult8SidedDice.ToString();
            str_individual_rolls = individual_rolls.Text;
            if (str_individual_rolls.Length < 1)
            {
                individual_rolls.Text += str_individual_roll;
            }
            else
            {
                individual_rolls.Text = individual_rolls.Text + "+" + str_individual_roll;
            }
        }

        private void dice_blue_10sided_Click(object sender, RoutedEventArgs e)
        {
            int intResult10SidedDice = randomNumberGenerator.Next(1, 2);
            int_total += intResult10SidedDice;
            total_of_all_dice_rolls.Text = int_total.ToString();
            str_individual_roll = intResult10SidedDice.ToString();
            str_individual_rolls = individual_rolls.Text;
            if (str_individual_rolls.Length < 1)
            {
                individual_rolls.Text += str_individual_roll;
            }
            else
            {
                individual_rolls.Text = individual_rolls.Text + "+" + str_individual_roll;
            }
        }

        private void dice_blue_12sided_Click(object sender, RoutedEventArgs e)
        {
            int intResult12SidedDice = randomNumberGenerator.Next(1, 2);
            int_total += intResult12SidedDice;
            total_of_all_dice_rolls.Text = int_total.ToString();
            str_individual_roll = intResult12SidedDice.ToString();
            str_individual_rolls = individual_rolls.Text;
            if (str_individual_rolls.Length < 1)
            {
                individual_rolls.Text += str_individual_roll;
            }
            else
            {
                individual_rolls.Text = individual_rolls.Text + "+" + str_individual_roll;
            }
        }

        private void dice_blue_20sided_Click(object sender, RoutedEventArgs e)
        {
            int intResult20SidedDice = randomNumberGenerator.Next(1, 2);
            int_total += intResult20SidedDice;
            total_of_all_dice_rolls.Text = int_total.ToString();
            str_individual_roll = intResult20SidedDice.ToString();
            str_individual_rolls = individual_rolls.Text;
            if (str_individual_rolls.Length < 1)
            {
                individual_rolls.Text += str_individual_roll;
            }
            else
            {
                individual_rolls.Text = individual_rolls.Text + "+" + str_individual_roll;
            }
        }

        private void dice_blue_100sided_Click(object sender, RoutedEventArgs e)
        {
            int intResult100SidedDice = randomNumberGenerator.Next(1, 2);
            int_total += intResult100SidedDice;
            total_of_all_dice_rolls.Text = int_total.ToString();
            str_individual_roll = intResult100SidedDice.ToString();
            str_individual_rolls = individual_rolls.Text;
            if (str_individual_rolls.Length < 1)
            {
                individual_rolls.Text += str_individual_roll;
            }
            else
            {
                individual_rolls.Text = individual_rolls.Text + "+" + str_individual_roll;
            }
        }

        private void clear_button_Click(object sender, RoutedEventArgs e)
        {
            int_total = 0;
            total_of_all_dice_rolls.Text = int_total.ToString();
            individual_rolls.Text = string.Empty;
        }
    }
}
