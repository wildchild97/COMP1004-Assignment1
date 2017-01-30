using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        /// <summary>
        /// This method sees if hours entered is valid and stores it. if not it notifys the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method makes sure a vaild salary number is entered and stores it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SalesTextBox.Text.Any(c => Char.IsLetter(c)))
            {
                MessageBox.Show("Please enter a number only");
                SalesTextBox.Text = "";
            }
            else
            {
             
            }
        }

        /// <summary>
        /// this method changes all text on the form to french when the french language is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LanguageGroupBox.Text = "La Langue";
            EnglishRadioButton.Text = "Anglais";
            FrenchRadioButton.Text = "Français";
            SpanishRadioButton.Text = "Espanol";
            NameLabel.Text = "Nom de L'Employé";
            IdLabel.Text = "ID de L'Employé";
            HoursLabel.Text = "Total des Heures Travaillées";
            SalesLabel.Text = "Ventes Mensuelles Totales";
            BonusLabel.Text = "Bonus de vente";
            CalculateButton.Text = "Calculer";
            PrintButton.Text = "Imprimir";
            NextButton.Text = "Prochain";

        }

        /// <summary>
        /// This method changes all text on the form to spanish when the spanish language is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpanishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LanguageGroupBox.Text = "Idioma";
            EnglishRadioButton.Text = "Inglés";
            FrenchRadioButton.Text = "Francés";
            SpanishRadioButton.Text = "Español";
            NameLabel.Text = "Nombre de Empleado";
            IdLabel.Text = "ID de Empleado";
            HoursLabel.Text = "Total de Horas Trabajadas";
            SalesLabel.Text = "Ventas Mensuales Totales";
            BonusLabel.Text = "Bono de Ventas";
            CalculateButton.Text = "Calcular";
            PrintButton.Text = "Imprimer";
            NextButton.Text = "Entrante";
        }

        /// <summary>
        /// This method changes all text on the form to English when the english language is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LanguageGroupBox.Text = "Language";
            EnglishRadioButton.Text = "English";
            FrenchRadioButton.Text = "French";
            SpanishRadioButton.Text = "Spanish";
            NameLabel.Text = "Employee Name";
            IdLabel.Text = "Employee ID";
            HoursLabel.Text = "Total Hours Worked";
            SalesLabel.Text = "Total Monthly Sales";
            BonusLabel.Text = "Sales Bonus";
            CalculateButton.Text = "Calculate";
            PrintButton.Text = "Print";
            NextButton.Text = "Next";
        }

        /// <summary>
        /// This method gives the user a message saying their form is being printed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Form is being sent to the printer");
        }
    }
}
