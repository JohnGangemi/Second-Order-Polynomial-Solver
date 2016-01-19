using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polynomial_Solver
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            //Clear the contents of x1 and x2 text boxes
            x1txtbx.Clear();
            x2txtbx.Clear();

            //Initalize variables
            double aTerm;
            double bTerm;
            double cTerm;
            double ansPos;
            double ansNeg;
            double ansCom;
            double ansReal;
            int i;
            bool err = false;

            //Check the text boxes for null or letters and handle with msgbox
            if (String.IsNullOrEmpty(AtxtBox.Text) || String.IsNullOrEmpty(BtxtBox.Text) || String.IsNullOrEmpty(CtxtBox.Text))
            {
                MessageBox.Show("You must enter a value in the required input field(s)");
                err = true;
                if (String.IsNullOrEmpty(AtxtBox.Text))
                    AtxtBox.Focus();
                else if (String.IsNullOrEmpty(BtxtBox.Text))
                    BtxtBox.Focus();
                else
                    CtxtBox.Focus();
            }
            else
            {
                for (char.IsLetterOrDigit(AtxtBox.Text, i = 0); i < AtxtBox.Text.Length; i++)
                {
                    if (char.IsLetter(AtxtBox.Text, i))
                    {
                        MessageBox.Show("The A input field contains non-numerals.");
                        AtxtBox.Clear();
                        if (err == false)
                        {
                            err = true;
                            break;
                        }
                        break;
                    }
                }
                for (char.IsLetterOrDigit(BtxtBox.Text, i = 0); i < BtxtBox.Text.Length; i++)
                {
                    if (char.IsLetter(BtxtBox.Text, i))
                    {
                        MessageBox.Show("The B input field contains non-numerals.");
                        BtxtBox.Clear();
                        if (err == false)
                        {
                            err = true;
                            break;
                        }
                        break;
                    }
                }
                for (char.IsLetterOrDigit(CtxtBox.Text, i = 0); i < CtxtBox.Text.Length; i++)
                {
                    if (char.IsLetter(CtxtBox.Text, i))
                    {
                        MessageBox.Show("The C input field contains non-numerals.");
                        CtxtBox.Clear();
                        if (err == false)
                        {
                            err = true;
                            break;
                        }
                        break;
                    }
                }
            }

            //Check if there was no errors in user input then compute the solution
            if (err == false)
            {
                aTerm = Convert.ToDouble(AtxtBox.Text);
                bTerm = Convert.ToDouble(BtxtBox.Text);
                cTerm = Convert.ToDouble(CtxtBox.Text);

                //Operations
                if (aTerm == 0)
                {
                    MessageBox.Show("The A term cannot be zero.");
                    AtxtBox.Clear();
                    AtxtBox.Focus();
                }
                else if ((bTerm * bTerm) >= (4 * aTerm * cTerm))
                {
                    ansPos = quadraticFormPositive(aTerm, bTerm, cTerm);
                    ansNeg = quadraticFormNegative(aTerm, bTerm, cTerm);
                    x1txtbx.Text = Convert.ToString(Math.Round(ansPos, 3));
                    x2txtbx.Text = Convert.ToString(Math.Round(ansNeg, 3));
                }
                else if ((bTerm * bTerm) < (4 * aTerm * cTerm))
                {
                    ansReal = quadraticFormReal(aTerm, bTerm);
                    ansCom = quadraticFormComplex(aTerm, bTerm, cTerm);
                    x1txtbx.Text = Convert.ToString(Math.Round(ansReal, 3)) + " + " + Convert.ToString(Math.Round(ansCom, 3)) + "i";
                    x2txtbx.Text = Convert.ToString(Math.Round(ansReal, 3)) + " - " + Convert.ToString(Math.Round(ansCom, 3)) + "i";
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //Clear the contents of all text boxes
            x1txtbx.Clear();
            x2txtbx.Clear();
            AtxtBox.Clear();
            BtxtBox.Clear();
            CtxtBox.Clear();

            //Set-up text box instruction
            AtxtBox.Text = "Enter A";
            BtxtBox.Text = "Enter B";
            CtxtBox.Text = "Enter C";

            //Send input focus to first text box
            AtxtBox.Focus();
        }

        private void AtxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                if (AtxtBox.Text.Contains('.'))
                    e.Handled = true;
            }
            else if (e.KeyChar == '-')
            {
                if (AtxtBox.Text.Contains('-'))
                    e.Handled = true;
            }
        }

        private void BtxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                if (BtxtBox.Text.Contains('.'))
                    e.Handled = true;
            }
            else if (e.KeyChar == '-')
            {
                if (BtxtBox.Text.Contains('-'))
                    e.Handled = true;
            }
        }

        private void CtxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                if (CtxtBox.Text.Contains('.'))
                    e.Handled = true;
            }
            else if (e.KeyChar == '-')
            {
                if (CtxtBox.Text.Contains('-'))
                    e.Handled = true;
            }
        }

        private double quadraticFormPositive(double a, double b, double c)
        {
            double ansPositive;
            double numerator;
            double denominator;
            double determinantFactor;

            determinantFactor = ((b * b) - (4 * a * c));
            numerator = (-b + Math.Sqrt(determinantFactor));
            denominator = (2 * a);
            ansPositive = numerator / denominator;

            return ansPositive;
        }

        private double quadraticFormNegative(double a, double b, double c)
        {
            double ansNegative;
            double numerator;
            double denominator;
            double determinantFactor;

            determinantFactor = ((b * b) - (4 * a * c));
            numerator = (-b - Math.Sqrt(determinantFactor));
            denominator = (2 * a);
            ansNegative = numerator / denominator;

            return ansNegative;
        }

        private double quadraticFormComplex(double a, double b, double c)
        {
            double ansComplex;
            double denominator;
            double determinantFactor;

            determinantFactor = ((b * b) - (4 * a * c));
            determinantFactor = Math.Sqrt((determinantFactor * -1));
            denominator = (2 * a);
            ansComplex = determinantFactor / (2 * a);

            return ansComplex;
        }

        private double quadraticFormReal(double a, double b)
        {
            double answer;
            double numerator;
            double denominator;

            numerator = -b;
            denominator = 2 * a;
            answer = numerator / denominator;

            return answer;
        }

        private void abtBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was developed by John A. Gangemi.\n" + "Build date: October 22nd 2013\n" + "Build: v1.01\n" + "Visual Studio Express 2012 C#\n");
        }

        private void AtxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            AtxtBox.SelectAll();
        }

        private void AtxtBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AtxtBox.Clear();
        }

        private void BtxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            BtxtBox.SelectAll();
        }

        private void BtxtBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BtxtBox.Clear();
        }

        private void CtxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            CtxtBox.SelectAll();
        }

        private void CtxtBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CtxtBox.Clear();
        }
    }
}
