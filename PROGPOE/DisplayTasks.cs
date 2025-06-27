using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGPOE
{
    public partial class DisplayTasks : Form
    {
        List<string> nameDisplay = new List<string>();
        List<string> Descriptions = new List<string>();
        List<DateTime> Dates = new List<DateTime>();
        public DisplayTasks(List<string> name, List<string> description, List<DateTime> date)
        {
            InitializeComponent();
            nameDisplay = name;
            Descriptions = description;
            Dates = date;
            //function that counts the number of items in name list
            int count = nameDisplay.Count;
            //loop through the list and add each item to the DisplayBox
            for (int i = 0; i < count; i++)
            {
                DisplayBox.Items.Add($"Task name:{nameDisplay[i]} - Description:{Descriptions[i]} - {Dates[i]}");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            NavigationMenu navigationMenuForm = new NavigationMenu(nameDisplay, Descriptions, Dates);
            navigationMenuForm.Show();
            this.Hide();
        }

        private void DisplayTasks_Load(object sender, EventArgs e)
        {

        }
    }
}
