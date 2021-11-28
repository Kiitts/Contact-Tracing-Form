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
    public partial class ManagerList : Form
    {
        public string outputText = File.ReadAllText("Info.txt");
        public StreamReader dateRead;
        public ManagerList()
        {
            InitializeComponent();
        }

        private void dateShowBtn_Click(object sender, EventArgs e)
        {
            dateList.Visible = true;
        }

        private void dateList_Leave(object sender, EventArgs e)
        {
            dateList.Visible = false;
        }

        private void changePreview()
        {
            if (dateList.SelectedItem.ToString() == "All")
            {
                outputSaveFile.Text = File.ReadAllText(@"Info.txt");
            }
            else
            {
                outputSaveFile.Text = File.ReadAllText(@$"Datas\{dateList.SelectedItem}.txt");
            }
        }

        private void dateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateShowBtn.Text = dateList.SelectedItem.ToString();
            changePreview();
        }

        private void AddItems()
        {
            dateRead = File.OpenText(@"Datas\Dates.txt");
            while(!dateRead.EndOfStream)
            {
                string currentLine = dateRead.ReadLine();
                dateList.Items.Add(currentLine);
            }
        }
       
        private void ManagerList_Load(object sender, EventArgs e)
        {
            this.Enabled = true;
            dateList.SelectedItem = "All";
            AddItems();
            outputSaveFile.Text = outputText;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            changePreview();
        }

        private void ManagerList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = false;
            e.Cancel = true;
            this.Hide();
        }
    }
}
