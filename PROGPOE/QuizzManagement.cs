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
            2,1,1,2,3,0,6,1,2,2
        };
        List<int> CorrectAnswersOri = new List<int>()
        {
            0,1,2,3,4,5,6,7,8,9,10
        };

        List<String> AllQuestions = new List<string>()
        {
            "Which of the following is the best example of a phishing attempt?",
            "What is the main characteristic of a Trojan virus?",
            "Which of the following best describes a social engineering attack?",
            "What is the primary purpose of a botnet in a cyber attack?",
            "What distinguishes a computer worm from other types of malware like viruses?",
            "What is the main goal of an SQL injection attack?",
            "What makes a zero-day exploit particularly dangerous?",
            "What is credential stuffing in the context of cybersecurity?",
            "What is the primary goal of a ransomware attack?",
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
            int gamp = CorrectAnswersOri[SelectedQuestion];
           
            if (CorrectAnswers[gamp] == UserChoice)
            {
                return "Correct answer";
            }
            else
            {
                return $"Incorrect answer.";

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
        public List<String> Question4()
        {
            List<string> Options = new List<string>()
            {
                "To clean and optimize infected computers.",
                "To allow users to remotely access their home network.",
                "To coordinate a group of compromised devices for malicious activities.",
                "To provide free antivirus updates"
            };
            return Options;
        }
        public List<String> Question5()
        {
            List<string> Options = new List<string>()
            {
                "It only infects smartphones and not computers.",
                "It requires user interaction to spread.",
                "It can only be detected by hardware firewalls",
                "It spreads automatically without needing to attach to other programs."
            };
            return Options;
        }
        public List<String> Question6()
        {
            List<string> Options = new List<string>()
            {
                "It only targets outdated software.",
                "It spreads through email attachments only.",
                "It relies on user error to function.",
                "It exploits a previously unknown vulnerability with no available patch."
            };
            return Options;
        }
        public List<String> Question7()
        {
            List<string> Options = new List<string>()
            {
                " It only infects smartphones and not computers.",
                "Guessing passwords using random combinations.",
                "It can only be detected by hardware firewalls",
                "It spreads automatically without needing to attach to other programs."
            };
            return Options;
        }
        public List<String> Question8()
        {
            List<string> Options = new List<string>()
            {
                "To infect a server with ransomware.",
                "To trick users into running malicious scripts in their browser.",
                "To brute-force login credentials",
                "To overload the network with excessive traffic."
            };
            return Options;
        }
        public List<String> Question9()
        {
            List<string> Options = new List<string>()
            {
                "To gain physical access to a victim’s device.",
                "To display pop-up ads on the victim’s screen.",
                "To encrypt a victim’s files and demand payment for decryption.",
                "To monitor user activity for targeted advertising."
            };
            return Options;
        }
        public List<String> Question10()
        {
            List<string> Options = new List<string>()
            {
                "The attacker physically steals the victim’s device.",
                "The attacker sends mass emails to trick users into revealing information.",
                "The attacker secretly intercepts and possibly alters communication between two parties",
                "The attacker brute-forces a network password using a dictionary attack."
            };
            return Options;
        }
    }
}
