namespace PROGPOE
{
    partial class NavigationMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChatbotBTN = new Button();
            DisplayBTN = new Button();
            Quizzbtn = new Button();
            SuspendLayout();
            // 
            // ChatbotBTN
            // 
            ChatbotBTN.Location = new Point(323, 26);
            ChatbotBTN.Name = "ChatbotBTN";
            ChatbotBTN.Size = new Size(135, 58);
            ChatbotBTN.TabIndex = 0;
            ChatbotBTN.Text = "Chatbot";
            ChatbotBTN.UseVisualStyleBackColor = true;
            ChatbotBTN.Click += ChatbotBTN_Click;
            // 
            // DisplayBTN
            // 
            DisplayBTN.Location = new Point(323, 129);
            DisplayBTN.Name = "DisplayBTN";
            DisplayBTN.Size = new Size(135, 58);
            DisplayBTN.TabIndex = 1;
            DisplayBTN.Text = "Tasks page";
            DisplayBTN.UseVisualStyleBackColor = true;
            DisplayBTN.Click += DisplayBTN_Click;
            // 
            // Quizzbtn
            // 
            Quizzbtn.Location = new Point(323, 230);
            Quizzbtn.Name = "Quizzbtn";
            Quizzbtn.Size = new Size(135, 58);
            Quizzbtn.TabIndex = 2;
            Quizzbtn.Text = "Quizz Game";
            Quizzbtn.UseVisualStyleBackColor = true;
            Quizzbtn.Click += Quizzbtn_Click;
            // 
            // NavigationMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 450);
            Controls.Add(Quizzbtn);
            Controls.Add(DisplayBTN);
            Controls.Add(ChatbotBTN);
            Name = "NavigationMenu";
            Text = "NavigationMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button ChatbotBTN;
        private Button DisplayBTN;
        private Button Quizzbtn;
    }
}