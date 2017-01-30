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
            NameTextBox.Text = String.Empty;
            IdTextBox.Text = String.Empty;
            HoursTextBox.Text = String.Empty;
            SalesTextBox.Text = String.Empty;
            BonusTextBox.Text = String.Empty;
        }
    }
}
