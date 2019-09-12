using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel prizeModel = new PrizeModel(
                    placeNameTextBox.Text,
                    placeNumberTextBoxOne.Text,
                    prizeAmmountTextBox.Text,
                    prizePercentageTextBox.Text);
               
                   GlobalConfig.Connection.CreatePrize(prizeModel);
                

                placeNameTextBox.Text = "";
                placeNumberTextBoxOne.Text = "";
                prizeAmmountTextBox.Text = "0";
                prizeAmmountTextBox.Text = "0"; 
            }
            else
            {
                MessageBox.Show("This form has invalid information");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;

            decimal prizeAmount = 0;
            int prizePercentage = 0;
         
            if(placeNumber>=1)
            {
                output = false;
            }
            if (int.TryParse(placeNumberTextBoxOne.Text, out placeNumber) == false)
            {
                output = false;
            }
            if (placeNameTextBox.Text.Length == 0)
            {
                output = false;
            }
            if (decimal.TryParse(prizeAmmountTextBox.Text,out prizeAmount) ==false || int.TryParse(prizeAmmountTextBox.Text, out prizePercentage) == false)
            {
                output = false;
            }

            if(prizeAmount <= 0 && prizePercentage <=0 )
            {
                output = false;
            }

            if(prizeAmount <0 && prizePercentage>100)
            {
                output = false;
            }
    
            return output;
        }

      
    }
}
