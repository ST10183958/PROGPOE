using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGPOE
{
    internal class QuizzManagement
    {
        List<int> CorrectAnswers = new List<int>()
        {
            2,0,1
        };
        List<String> AllQuestions = new List<string>()
        {
            "Which of the following is the best example of a phishing attempt?",
            "What is the main characteristic of a Trojan virus?",
            "Which of the following best describes a social engineering attack?",
        };
        List<char> Chars = new List<char>()
        {
            'A', 'B', 'C', 'D'
        };

        public QuizzManagement()
        {

        }

        public List<String> GetQuestions()
        {
            return AllQuestions;
        }
        // This method returns the correct answer for a given question index and user choice.
        public String GetCorrectAnswers(int SelectedQuestion, int UserChoice)
        {
            if (CorrectAnswers[SelectedQuestion] == UserChoice)
            {
                return "Correct answer";
            }
            else
            {
                return $"Incorrect answer, correct answer was {Chars[SelectedQuestion]}";
            }
        }


        public List<String> Question1()
        {
            List<List<string>> ListOfOptions = new List<List<string>>();
            //ListOfOptions.Add()
            ListOfOptions.Add(new List<string>()
            {
                "A legitimate email from your bank asking you to update your account through their secure website.",
                "A phone call from a known coworker asking about a recent meeting.",
                "An email claiming you've won a prize, asking you to click a link and enter your personal information.",
                "A software update notification from your computer’s built-in updater."
            });

            List<string> Options = new List<string>()
            {
                "A legitimate email from your bank asking you to update your account through their secure website.",
                "A phone call from a known coworker asking about a recent meeting.",
                "An email claiming you've won a prize, asking you to click a link and enter your personal information.",
                "A software update notification from your computer’s built-in updater."
            };
            return Options;
        }
        public List<String> Question2()
        {
            List<string> Options = new List<string>()
            {
                "It replicates itself and spreads to other systems without user consent.",
                "It disguises itself as legitimate software to trick users into installing it.",
                "It encrypts files and demands a ransom to unlock them.",
                "A software update notification from your computer’s built-in updater."
            };
            return Options;
        }
        public List<String> Question3()
        {
            List<string> Options = new List<string>()
            {
                "Using advanced software to scan for system vulnerabilities.",
                "Tricking someone into revealing confidential information through manipulation.",
                "Infecting a device with a virus through a malicious website.",
                "Guessing a user’s password using brute-force techniques."
            };
            return Options;
        }
    }
}
