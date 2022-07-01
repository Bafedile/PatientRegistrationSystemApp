using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientRegistrationSystemApp
{
    public partial class PatientReg : Form
    {
        string firstname, lastname, idNumber, gender, race, country, province, city, streetName, date;
        public PatientReg()
        {
            InitializeComponent();
        }

        private void FirstnameTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LastnameTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void IdentityTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DateTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = MaleRadioButton.Text;
            
        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = FemaleRadioButton.Text;

        }

        private void OtherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = OtherRadioButton.Text;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CountryTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ProvinceTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SuburbTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void StreetNameTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // grab information from the entities in the form
            firstname = FirstnameTextBox.Text;
            lastname = LastnameTextBox.Text;
            idNumber = IdentityTextBox.Text;
            date = DateTextBox.Text;
            race = RaceComboBox.Text;
            country = CountryTextBox.Text;
            city = SuburbTextBox.Text;
            streetName = StreetNameTextBox.Text;


        }
    }
}
