/*
 * Created by: Allison Cook
 * Created on: 13 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Temperature Converter
 * This program converts the temp from celsuis to fahrenheit
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConvertAllisonC
{
    public partial class frmTempConvert : Form
    {
        public frmTempConvert()
        {
            InitializeComponent();
        }
        public void ConvertCelFah(float Celsuis)
        {
            //variable
            float fahrenheit;

            //calculating
            fahrenheit = ((float)(9) / (float)(8)) * Celsuis + 32;

            //set to label
            this.lblA.Text = Convert.ToString(fahrenheit);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //variables
            float UserCel;

            //taking the text to number
            UserCel = float.Parse(txtCelsuis.Text);

            //calling the procedure 
            this.ConvertCelFah(UserCel);
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program when clicked
            this.Close();
        }
    }
}
