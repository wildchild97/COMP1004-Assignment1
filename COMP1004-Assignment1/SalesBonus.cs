using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment1
{
    public partial class SalesBonus : Form
    {
        //PRIVATE INSTANCE VARIABLES    
        private int _hoursWorked;

        //Constructors++++++++++++++++++++++

        /// <summary>
        /// Default constructor
        /// </summary>
        public SalesBonus()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// This method clears all textboxes when the next button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            IdTextBox.Text = "";
            HoursTextBox.Text = "";
            SalesTextBox.Text = "";
            BonusTextBox.Text = "";
        }

        private void HoursTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(HoursTextBox.Text, out _hoursWorked))
            {
                if(_hoursWorked > 161)
                {
                    MessageBox.Show("Invalid number. Hours exceed 160");
                    HoursTextBox.Text = "";
                }  
            }

            else
            {
                MessageBox.Show("Please enter a number only");
                HoursTextBox.Text = "";
            }
            
        }
    }
}
