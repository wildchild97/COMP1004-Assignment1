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

        private void SalesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
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

        private void SpanishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
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

        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
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
    }
}
