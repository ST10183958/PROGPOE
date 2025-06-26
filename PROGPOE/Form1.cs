using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PROGPOE
{
    public partial class Form1 : Form
    {

        List<string> TaskNames = new List<string>();
        List<string> Descriptions = new List<string>();
        List<DateTime> Dates = new List<DateTime>();

        string Bot = "Chatbot:";
        string AddTaskComand = "Add task -";
        string pattern = @"Add task -\s*(\w+)";
        string addedTask = null;
        bool WaitingForDescription = false;
        bool WaitingForDate = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterBTN_Click(object sender, EventArgs e)
        {

            if (UserInput.Text == "hello")
            {
                ChatBox.Items.Add($"User:{UserInput.Text}");
                ChatBox.Items.Add($"{Bot} Hello! How can I assist you today?");
            }

            // function that checks if the add command is present and performs the function  
            if (UserInput.Text.Contains(AddTaskComand))
            {
                // Check if the input matches the pattern for adding a task  
                Match match = Regex.Match(UserInput.Text, pattern);
                if (match.Success)
                {
                    string word = "";
                    word = match.Groups[1].Value;
                    TaskNames.Add(word); // Use the instance of TaskManagement  
                    WaitingForDescription = true;
                    //TaskNames.Add(UserInput.Text);
                    ChatBox.Items.Add($"{Bot}Task added " + word);
                }
                // function to append task description  

                // function to append task date  
                /*
                if (WaitingForDate == true && WaitingForDescription == false)
                {
                    ChatBox.Items.Add("Chatbot: Add date. (e.g., 2025-06-06): ");
                    if (DateTime.TryParseExact(UserInput.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        Dates.Add(parsedDate); // Use the instance of TaskManagement  
                    }
                    ChatBox.Items.Add($"User:{UserInput}");
                }
                */
            }


        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            DisplayTasks navigationMenuForm = new DisplayTasks(TaskNames, Descriptions, Dates);
            navigationMenuForm.Show();
            this.Hide();
        }

        private void ChatBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
