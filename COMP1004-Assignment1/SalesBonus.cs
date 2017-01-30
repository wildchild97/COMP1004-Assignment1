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

//Caitlin Foster    #200311158
//Sales Bonus form  
//Created: January 16th 2017     Last Modified: January 29th 2017	

//Created GUI - made and placed company logo - code to validate hours worked - allow language changes - code to validate sales

//Form will allow user to enter an employee's name, Id, #hours worked and their 
//total sales and calculate their sales bonus. 
//Will also allow user to change language an print the form

namespace COMP1004_Assignment1
{
    public partial class SalesBonus : Form
    {
        //PRIVATE INSTANCE VARIABLES    
        private int _hoursWorked;
        private int _totalSales;
        
        //CONSTRUCTORS

        /// <summary>
        /// Default constructor
        /// </summary>
        public SalesBonus()
        {
            InitializeComponent();
            
        }

        //EVENT HANDLERS

        /// <summary>
        /// This method clears all textboxes when the next button is clicked except for total sales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            IdTextBox.Text = "";
            HoursTextBox.Text = "";
            BonusTextBox.Text = "";
        }

        /// <summary>
        /// This method sees if hours entered is valid and stores it. if not it notifys the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoursTextBox_TextChanged(object sender, EventArgs e)
        {
            //see if input is a number
            if (Int32.TryParse(HoursTextBox.Text, out _hoursWorked))
            {
                //if yes see if its 160 or less
                if (_hoursWorked > 161)
                {
                    MessageBox.Show("Invalid number. Hours exceed 160");
                    HoursTextBox.Text = "";
                }  
            }

            else
            {
                //if no ask user for a number
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
            //radio buttons language being changed
            LanguageGroupBox.Text = "La Langue";
            EnglishRadioButton.Text = "Anglais";
            FrenchRadioButton.Text = "Français";
            SpanishRadioButton.Text = "Espanol";
            //labels language being changed
            NameLabel.Text = "Nom de L'Employé";
            IdLabel.Text = "ID de L'Employé";
            HoursLabel.Text = "Total des Heures Travaillées";
            SalesLabel.Text = "Ventes Mensuelles Totales";
            BonusLabel.Text = "Bonus de vente";
            //buttons language beng changed
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
            //radio buttons language being changed
            LanguageGroupBox.Text = "Idioma";
            EnglishRadioButton.Text = "Inglés";
            FrenchRadioButton.Text = "Francés";
            SpanishRadioButton.Text = "Español";
            //labels language being changed
            NameLabel.Text = "Nombre de Empleado";
            IdLabel.Text = "ID de Empleado";
            HoursLabel.Text = "Total de Horas Trabajadas";
            SalesLabel.Text = "Ventas Mensuales Totales";
            BonusLabel.Text = "Bono de Ventas";
            //buttons language beng changed
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
            //radio buttons language being changed
            LanguageGroupBox.Text = "Language";
            EnglishRadioButton.Text = "English";
            FrenchRadioButton.Text = "French";
            SpanishRadioButton.Text = "Spanish";
            //labels language being changed
            NameLabel.Text = "Employee Name";
            IdLabel.Text = "Employee ID";
            HoursLabel.Text = "Total Hours Worked";
            SalesLabel.Text = "Total Monthly Sales";
            BonusLabel.Text = "Sales Bonus";
            //buttons language beng changed
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
