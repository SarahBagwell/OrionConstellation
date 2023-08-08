// Programmer: Sarah Bagwell
// Class: CIS 3000-OL1 Summer 2023
// Program Purpose: Reveal the different star names that make up the Orion constellation. 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orion_Constellation___Bagwell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showStarNamesButton_Click(object sender, EventArgs e)
        {

            // Making the star labels visible when showStarNamesButton is clicked. 

            betelgeuseLabel.Visible = true;
            meissaLabel.Visible = true;
            alnitakLabel.Visible = true;
            alnilamLabel.Visible = true;
            mintakaLabel.Visible = true;
            saiphLabel.Visible = true;
            rigelLabel.Visible = true;

        }

        private void hideStarNamesButton_Click(object sender, EventArgs e)
        {

            // Making the star labels invisible when hideStarNamesButton is clicked.

            betelgeuseLabel.Visible = false;
            meissaLabel.Visible = false;
            alnitakLabel.Visible = false;   
            alnilamLabel.Visible = false;
            mintakaLabel.Visible = false;
            saiphLabel.Visible = false;
            rigelLabel.Visible = false;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            // Close the form. 

            this.Close();

        }
    }
}
