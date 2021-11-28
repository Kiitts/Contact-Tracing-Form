using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        // initialize all needed string variable
        public static string fullName, age, address, temperature, gender, goneOutside, goneWhere, dateNow,
            timeNow, pNumber, emailAdd, sickness = string.Empty, datesString;
        DateTime dateToday;
        StreamWriter outputfile, datefile;
        Manager_Password passwordConfirm = new Manager_Password();
        public Form1()
        {
            InitializeComponent();
        }

        private void saveIt()
        {
            outputfile = File.AppendText(@$"Datas\{dateNow}.txt");
            outputfile.WriteLine($"Date: {dateNow}");
            outputfile.WriteLine($"Time: {timeNow}");
            outputfile.WriteLine($"Name: {fullName}");
            outputfile.WriteLine($"Address: {address}");
            outputfile.WriteLine($"Age: {age}");
            outputfile.WriteLine($"Gender: {gender}");
            outputfile.WriteLine($"Temperature: {temperature}");
            if (sickness != string.Empty)
            {
                outputfile.WriteLine($"Symptom/s: {sickness}");
            }
            else
            {
                outputfile.WriteLine($"Symptom/s: N/A");
            }
            outputfile.WriteLine($"Travelled: {goneOutside}");
            if (goneOutside == "Yes")
            {
                outputfile.WriteLine($"To: {goneWhere}");
            }
            else
            {
                outputfile.WriteLine($"To: N/A");
            }
            outputfile.WriteLine($"Number: {pNumber}");
            outputfile.WriteLine($"Email: {emailAdd}");
            outputfile.WriteLine();
            outputfile.WriteLine();
            outputfile.Close();
            outputfile = File.AppendText(@$"Info.txt");
            outputfile.WriteLine($"Date: {dateNow}");
            outputfile.WriteLine($"Time: {timeNow}");
            outputfile.WriteLine($"Name: {fullName}");
            outputfile.WriteLine($"Address: {address}");
            outputfile.WriteLine($"Age: {age}");
            outputfile.WriteLine($"Gender: {gender}");
            outputfile.WriteLine($"Temperature: {temperature}");
            if (sickness != string.Empty)
            {
                outputfile.WriteLine($"Symptom/s: {sickness}");
            }
            else
            {
                outputfile.WriteLine($"Symptom/s: N/A");
            }
            outputfile.WriteLine($"Travelled: {goneOutside}");
            if (goneOutside == "Yes")
            {
                outputfile.WriteLine($"To: {goneWhere}");
            }
            else
            {
                outputfile.WriteLine($"To: N/A");
            }
            outputfile.WriteLine($"Number: {pNumber}");
            outputfile.WriteLine($"Email: {emailAdd}");
            outputfile.WriteLine();
            outputfile.WriteLine();
            outputfile.Close();
            datesString = File.ReadAllText(@"Datas\Dates.txt");
            if(!datesString.Contains(dateNow))
            {
                datefile = File.AppendText($@"Datas\Dates.txt");
                datefile.WriteLine(dateNow);
                datefile.Close();
            }
        }
        private void reset()
        {
            // this will reset all inputted data
            fullName = string.Empty;
            age = string.Empty;
            address = string.Empty;
            temperature = string.Empty;
            gender = string.Empty;
            goneOutside = string.Empty;
            goneWhere = string.Empty;
            inputName.Text = string.Empty;
            inputAge.Text = string.Empty;
            inputAddress.Text = string.Empty;
            inputTemp.Text = string.Empty;
            inputNumber.Text = string.Empty;
            inputEmail.Text = string.Empty;
            sickness = string.Empty;
            maleRadio.Checked = false;
            femaleRadio.Checked = false;
            goesOutsideYes.Checked = false;
            goesOutsideNo.Checked = false;
            goesOutsideWhere.Text = string.Empty;
            inputName.BackColor = Color.White;
            inputAge.BackColor = Color.White;
            inputAddress.BackColor = Color.White;
            inputTemp.BackColor = Color.White;
            maleRadio.ForeColor = Color.Black;
            femaleRadio.ForeColor = Color.Black;
            goesOutsideYes.ForeColor = Color.Black;
            goesOutsideNo.ForeColor = Color.Black;
            goesOutsideWhere.BackColor = Color.White;
            inputEmail.BackColor = Color.White;
            inputNumber.BackColor = Color.White;
            for(int i = 0; i<sicknessCheckBox.Items.Count; i++)
            {
                sicknessCheckBox.SetItemChecked(i, false);
            }
            sicknessCheckBox.ClearSelected();
        }

        private bool CheckRequired()
        {
            // this will check if the required inputs is not empty
            bool returnValue = false;
            if(inputName.Text.TrimStart().TrimEnd() == string.Empty)
            {
                // will check if the inputName is empty
                inputName.BackColor = Color.DarkRed;
                returnValue = true;
            }
            if (inputAge.Text == string.Empty)
            {
                // will check if the inputAge is empty
                inputAge.BackColor = Color.DarkRed;
                returnValue = true;
            }
            if (inputNumber.Text.Length != 11)
            {
                inputNumber.BackColor = Color.DarkRed;
                returnValue = true;
            }
            if (inputAddress.Text.TrimStart().TrimEnd() == string.Empty)
            {
                inputAddress.BackColor = Color.DarkRed;
                returnValue = true;
            }
            if (inputTemp.Text == string.Empty)
            {
                inputTemp.BackColor = Color.DarkRed;
                returnValue = true;
            }
            if (!maleRadio.Checked && !femaleRadio.Checked)
            {
                maleRadio.ForeColor = Color.DarkRed;
                femaleRadio.ForeColor = Color.DarkRed;
                returnValue = true;
            }
            if (!goesOutsideYes.Checked && !goesOutsideNo.Checked)
            {
                goesOutsideYes.ForeColor = Color.DarkRed;
                goesOutsideNo.ForeColor = Color.DarkRed;
                returnValue = true;
            }
            if (goesOutsideYes.Checked)
            {
                if(goesOutsideWhere.Text.TrimStart().TrimEnd() == string.Empty)
                {
                    goesOutsideWhere.BackColor = Color.DarkRed;
                    returnValue = true;
                }
            }
            return returnValue;
        }

        private void getData()
        {
            // save the input data to the strings variable
            // array count will be reference for sickness aray of which element will append new
            // element
            fullName = inputName.Text.TrimEnd().TrimStart();
            age = inputAge.Text;
            address = inputAddress.Text.TrimStart().TrimEnd();
            temperature = inputTemp.Text;
            pNumber = inputNumber.Text;
            emailAdd = inputEmail.Text;
            if (maleRadio.Checked)
            {
                // this will check if the maleRadio is checked or not and initialize the gender
                // value to male, if not then gender will be female
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if (goesOutsideYes.Checked)
            {
                // this will check if the goesOutsideYes is checked or not and initialize the goneOutside
                // value to yess, if not then will be no
                goneOutside = "Yes";
                goneWhere = goesOutsideWhere.Text.TrimStart().TrimEnd();
            }
            else
            {
                goneOutside = "No";
            }
            for (int i = 0; i < sicknessCheckBox.CheckedItems.Count; i++)
            {
                if (sickness == "")
                {
                    sickness = sicknessCheckBox.CheckedItems[i].ToString();
                }
                else
                {
                    sickness += $", {sicknessCheckBox.CheckedItems[i].ToString()}";
                }
            }
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool leaveBlank = CheckRequired();
            if (!leaveBlank)
            {
                dateToday = DateTime.Now;
                dateNow = $"{dateToday:dddd, d MMMM yyyy}";
                timeNow = $"{dateToday:hh:mm}";
                getData();
                saveIt();
                MessageBox.Show("Submitted!", "Submit Message");
                reset();
            }
        }

        private void inputAddress_Click(object sender, EventArgs e)
        {
            inputAddress.BackColor = Color.White;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void manage_Click(object sender, EventArgs e)
        {
            passwordConfirm.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void inputTemp_Click(object sender, EventArgs e)
        {
            inputTemp.BackColor = Color.White;
        }

        private void goesOutsideWhere_Click(object sender, EventArgs e)
        {
            goesOutsideWhere.BackColor = Color.White;
        }

        private void inputNumber_Click(object sender, EventArgs e)
        {
            inputNumber.BackColor = Color.White;
        }

        private void inputName_Click(object sender, EventArgs e)
        {
            inputName.BackColor = Color.White;
        }
        private void inputAge_Click(object sender, EventArgs e)
        {
            inputAge.BackColor = Color.White;
        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {
            maleRadio.ForeColor = Color.Black;
            femaleRadio.ForeColor = Color.Black;
        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            maleRadio.ForeColor = Color.Black;
            femaleRadio.ForeColor = Color.Black;
        }

        private void inputAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // this will not handle any letters or capital letters, and will handle only numbers
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // if the pressed key is not number it will tell the application that the event is already
                // handled and not to worry about it. 
                e.Handled = true;
            }
        }

        private void inputTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // this will check if the keyboard press contains only "." or numbers and control key like 
            // backspace or enter or tab
            if (inputTemp.Text.Contains("."))
            {
                // if the inputTemp already have "." the pressed will be ignored
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                // if it's not digit or "." it will ignore the pressed key.
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void goesOutsideYes_Click(object sender, EventArgs e)
        {
            goesOutsideYes.ForeColor = Color.Black;
            goesOutsideNo.ForeColor = Color.Black;
            // this will enable the textbox that accepts address where he goes within 14days
            goesOutsideWhere.Enabled = true;
        }

        private void goesOutsideNo_CheckedChanged(object sender, EventArgs e)
        {
            goesOutsideYes.ForeColor = Color.Black;
            goesOutsideNo.ForeColor = Color.Black;
            // this will disable the textbox that accepts address where he goes within 14days
            // and clear its text
            goesOutsideWhere.Text = "";
            goesOutsideWhere.Enabled = false;
        }
    }
}
