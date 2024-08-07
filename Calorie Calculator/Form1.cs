using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Calculator
{
    public partial class formBMRCalculator : Form
    {
        private decimal userBMR;
        
        public formBMRCalculator()
        {
            InitializeComponent();
        }

        //Method that instantializes new labels for the hidden numericUpDown elements for imperial measurements and any other hidden elements as needed
        private void instantializeImperialLabels()
        {
            Label labelFeet = new Label();
            labelFeet.AutoSize = true;
            labelFeet.Text = "Feet";
            labelFeet.Location = new Point(numFeet.Location.X - 40, numFeet.Location.Y + 3);
            this.Controls.Add(labelFeet);

            Label labelInches = new Label();
            labelInches.AutoSize = true;
            labelInches.Text = "Inches";
            labelInches.Location = new Point(numInches.Location.X - 42, numInches.Location.Y + 3);
            this.Controls.Add(labelInches);

            Label labelLbs = new Label();
            labelLbs.AutoSize = true;
            labelLbs.Text = "Weight (lbs.)";
            labelLbs.Location = new Point(numWeightlbs.Location.X - 70, numWeightlbs.Location.Y + 3);
            this.Controls.Add(labelLbs);

        }
        private void displayUserBMR()
        {
            textBoxBMR.Enabled = true;
            textBoxBMR.Visible = true;
            textBoxBMR.Text = string.Empty;
            textBoxBMR.Text = "Your BMR is: " + userBMR + " Calories";
            textBoxBMR.AutoSize = true;
        }
        //Method that enables and shows hidden elements
        private void enableHiddenElements()
        {

            numWeightlbs.Enabled = true;
            numWeightlbs.Visible = true;

            numFeet.Enabled = true;
            numFeet.Visible = true;

            numInches.Enabled = true;
            numInches.Visible = true;

            buttonFinalConversion.Enabled = true;
            buttonFinalConversion.Visible = true;
        }
        //Function to calculate BMR. BMR is calculate differently based on if male or female is checked.
        //Final BMR affected by user selected activity level.
        private void calculateBMR()
        {
            if (cbFemale.Checked)
            {
                userBMR = 655m + (9.6m * numWeightKg.Value) + (1.8m * numHeightInCm.Value) - (4.7m * numAge.Value);
            }
            if (cbMale.Checked)
            {
                userBMR = 66m + (13.7m * numWeightKg.Value) + (5m * numHeightInCm.Value) - (6.8m * numAge.Value);
            }

            if (cbSedentary.Checked)
                userBMR = userBMR * 1.2m;
            if (cbLight.Checked)
                userBMR = userBMR * 1.375m;
            if (cbModerate.Checked)
                userBMR = userBMR * 1.55m;
            if (cbVery.Checked)
                userBMR = userBMR * 1.725m;

            userBMR = Math.Truncate(userBMR);
        }

        //Method hides the convert button and instantializes new control boxes and labels
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            buttonConvert.Enabled = false;
            buttonConvert.Visible = false;

            enableHiddenElements();
            instantializeImperialLabels();
        }

        //Control Method takes user imperial data and converts it to the corresponding metric measurements
        private void buttonFinalConversion_Click(object sender, EventArgs e)
        {
            decimal userInches = numInches.Value;
            decimal userFeet = numFeet.Value;

            decimal userConvertCM = (userFeet * 30.48m) + (userInches * 2.54m);
            numHeightInCm.Value = userConvertCM;

            if ((numWeightlbs.Value * 0.4m) < 1)
                numWeightKg.Value = 1m;
            else
                numWeightKg.Value = numWeightlbs.Value * 0.4534m;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            calculateBMR();
            displayUserBMR();
        }

        //Disables other checked genders to only allow for one option to be chosen
        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMale.Checked)
                cbFemale.Checked = false;
        }
        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFemale.Checked)
                cbMale.Checked = false;
        }

        //Disables other checked activity levels to only allow for one option to be chosen
        private void cbVery_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVery.Checked)
                cbModerate.Checked = cbLight.Checked = cbSedentary.Checked = false;
        }
        private void cbModerate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbModerate.Checked)
                cbVery.Checked = cbLight.Checked = cbSedentary.Checked = false;
        }
        private void cbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLight.Checked)
                cbVery.Checked = cbModerate.Checked = cbSedentary.Checked = false;
        }
        private void cbSedentary_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSedentary.Checked)
                cbVery.Checked = cbModerate.Checked = cbLight.Checked = false;
        }

        private void richTextHeading_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void linkLabelMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabelMe.LinkVisited = true;
            System.Diagnostics.Process.Start("https://dishsoap.me");
        }
    }
}
