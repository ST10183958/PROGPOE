using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGPOE
{
    public partial class QuizzForm : Form
    {
        List<string> Instruction1NLP = new List<string>()
        {
            "reminder",
            "add",

        };
        Random random = new Random();
        // Create an instance of QuizzManagement to handle quiz logic
        QuizzManagement quizzManagement = new QuizzManagement();
        int SelectedQuestion = 0;
        bool WaitingForAnswer = false;

        public QuizzForm()
        {
            InitializeComponent();
        }

        private void QuizzForm_Load(object sender, EventArgs e)
        {

        }

        private void LabelA_Click(object sender, EventArgs e)
        {

        }

        private void Abtn_Click(object sender, EventArgs e)
        {
            if (WaitingForAnswer == true)
            {
                int ButtonValue = 0;
                string DisplayOutput = quizzManagement.GetCorrectAnswers(SelectedQuestion, ButtonValue);
                QuestionTxt.Text = DisplayOutput;
            }
            WaitingForAnswer = false;
        }

        private void Bbtn_Click(object sender, EventArgs e)
        {
            if (WaitingForAnswer == true)
            {
                int ButtonValue = 1;
                string DisplayOutput = quizzManagement.GetCorrectAnswers(SelectedQuestion, ButtonValue);
                QuestionTxt.Text = DisplayOutput;
            }
            WaitingForAnswer = false;
        }

        private void Cbtn_Click(object sender, EventArgs e)
        {
            if (WaitingForAnswer == true)
            {
                int ButtonValue = 2;
                string DisplayOutput = quizzManagement.GetCorrectAnswers(SelectedQuestion, ButtonValue);
                QuestionTxt.Text = DisplayOutput;
            }
            WaitingForAnswer = false;
        }

        private void Dbtn_Click(object sender, EventArgs e)
        {
            if (WaitingForAnswer == true)
            {
                int ButtonValue = 3;
                string DisplayOutput = quizzManagement.GetCorrectAnswers(SelectedQuestion, ButtonValue);
                QuestionTxt.Text = DisplayOutput;
            }
            WaitingForAnswer = false;
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            SelectedQuestion = random.Next(0, quizzManagement.GetQuestions().Count);
            List<string> Question1 = quizzManagement.Question1();
            List<string> Question2 = quizzManagement.Question2();
            List<string> Question3 = quizzManagement.Question3();
            string DisplayQuestion = quizzManagement.GetQuestions()[SelectedQuestion];

            QuestionTxt.Text = DisplayQuestion;



            if (SelectedQuestion == 0)
            {
                LabelA.Text = $"A: {Question1[0]}";
                LabelB.Text = $"B: {Question1[1]}";
                LabelC.Text = $"C: {Question1[2]}";
                LabelD.Text = $"D: {Question1[3]}";
            }
            if (SelectedQuestion == 1)
            {
                LabelA.Text = $"A: {Question2[0]}";
                LabelB.Text = $"B: {Question2[1]}";
                LabelC.Text = $"C: {Question2[2]}";
                LabelD.Text = $"D: {Question2[3]}";
            }
            if (SelectedQuestion == 2)
            {
                LabelA.Text = $"A: {Question3[0]}";
                LabelB.Text = $"B: {Question3[1]}";
                LabelC.Text = $"C: {Question3[2]}";
                LabelD.Text = $"D: {Question3[3]}";
            }
            if (SelectedQuestion == 3)
            {
                LabelA.Text = $"A: {Question1[0]}";
                LabelB.Text = $"B: {Question1[1]}";
                LabelC.Text = $"C: {Question1[2]}";
                LabelD.Text = $"D: {Question1[3]}";
            }
            if (SelectedQuestion == 4)
            {
                LabelA.Text = $"A: {Question2[0]}";
                LabelB.Text = $"B: {Question2[1]}";
                LabelC.Text = $"C: {Question2[2]}";
                LabelD.Text = $"D: {Question2[3]}";
            }
            if (SelectedQuestion == 5)
            {
                LabelA.Text = $"A: {Question3[0]}";
                LabelB.Text = $"B: {Question3[1]}";
                LabelC.Text = $"C: {Question3[2]}";
                LabelD.Text = $"D: {Question3[3]}";
            }
            if (SelectedQuestion == 6)
            {
                LabelA.Text = $"A: {Question1[0]}";
                LabelB.Text = $"B: {Question1[1]}";
                LabelC.Text = $"C: {Question1[2]}";
                LabelD.Text = $"D: {Question1[3]}";
            }
            if (SelectedQuestion == 7) {
                LabelA.Text = $"A: {Question2[0]}";
                LabelB.Text = $"B: {Question2[1]}";
                LabelC.Text = $"C: {Question2[2]}";
                LabelD.Text = $"D: {Question2[3]}";
            }
            if (SelectedQuestion == 8)
            {
                LabelA.Text = $"A: {Question3[0]}";
                LabelB.Text = $"B: {Question3[1]}";
                LabelC.Text = $"C: {Question3[2]}";
                LabelD.Text = $"D: {Question3[3]}";
            }
            if (SelectedQuestion == 9)
            {
                LabelA.Text = $"A: {Question1[0]}";
                LabelB.Text = $"B: {Question1[1]}";
                LabelC.Text = $"C: {Question1[2]}";
                LabelD.Text = $"D: {Question1[3]}";
            }

            WaitingForAnswer = true;
        }

        private void QuestionTxt_Click(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            NavigationMenu navigationMenu = new NavigationMenu(null,null,null);
            navigationMenu.Show();
            this.Hide();
        }
    }
}
