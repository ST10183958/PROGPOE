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
                string[] parts = UserInput.Text.Split("^ ");
                // Check if the input matches the pattern for adding a task  
                Match match = Regex.Match(UserInput.Text, pattern);
                if (match.Success)
                {
                    string word = "";
                    word = match.Groups[1].Value;
                    TaskNames.Add(word); // Use the instance of TaskManagement  
                    Descriptions.Add(parts[1]);
                    Dates.Add(ConvertToDate(parts[2]));
                    //TaskNames.Add(UserInput.Text);
                    ChatBox.Items.Add($"{Bot}Task added " + word);
                }
                UserInput.Clear();
            }


        }
        // function that checks if the input is a date and converts it to a DateTime object
        static DateTime ConvertToDate(string dateString)
        {
            // Specify the expected format
            string format = "yyyy-MM-dd";

            if (DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                return parsedDate;
            }
            else
            {
                throw new FormatException("Invalid date format. Expected format: yyyy-MM-dd");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
