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
    public partial class NavigationMenu : Form
    {
        private List<string> taskNames = new List<string>();
        private List<string> descriptions = new List<string>();
        private List<DateTime> dates = new List<DateTime>();

        public NavigationMenu(List<string> name, List<string> descriptions, List<DateTime> dates)
        {
            InitializeComponent();
            this.taskNames = name;
            this.descriptions = descriptions;
            this.dates = dates;
        }

        public NavigationMenu(List<string> taskNames)
        {
            this.taskNames = taskNames;
        }

        private void ChatbotBTN_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void DisplayBTN_Click(object sender, EventArgs e)
        {
            DisplayTasks displayTasksForm = new DisplayTasks(taskNames, descriptions, dates);
            displayTasksForm.Show();
            this.Hide();
        }

        private void Quizzbtn_Click(object sender, EventArgs e)
        {
            QuizzForm quizzForm = new QuizzForm();
            quizzForm.Show();
            this.Hide();
        }
    }
}
