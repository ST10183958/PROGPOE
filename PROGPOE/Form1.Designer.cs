namespace PROGPOE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserInput = new RichTextBox();
            EnterBTN = new Button();
            BackBTN = new Button();
            ChatBox = new ListBox();
            SuspendLayout();
            // 
            // UserInput
            // 
            UserInput.Location = new Point(12, 392);
            UserInput.Name = "UserInput";
            UserInput.Size = new Size(557, 46);
            UserInput.TabIndex = 0;
            UserInput.Text = "";
            UserInput.TextChanged += UserInput_TextChanged;
            // 
            // EnterBTN
            // 
            EnterBTN.Location = new Point(575, 392);
            EnterBTN.Name = "EnterBTN";
            EnterBTN.Size = new Size(110, 46);
            EnterBTN.TabIndex = 1;
            EnterBTN.Text = "Enter";
            EnterBTN.UseVisualStyleBackColor = true;
            EnterBTN.Click += EnterBTN_Click;
            // 
            // BackBTN
            // 
            BackBTN.Location = new Point(691, 392);
            BackBTN.Name = "BackBTN";
            BackBTN.Size = new Size(110, 46);
            BackBTN.TabIndex = 2;
            BackBTN.Text = "Back";
            BackBTN.UseVisualStyleBackColor = true;
            BackBTN.Click += BackBTN_Click;
            // 
            // ChatBox
            // 
            ChatBox.Font = new Font("Segoe UI", 30F);
            ChatBox.FormattingEnabled = true;
            ChatBox.ItemHeight = 54;
            ChatBox.Location = new Point(0, 0);
            ChatBox.Name = "ChatBox";
            ChatBox.Size = new Size(801, 382);
            ChatBox.TabIndex = 3;
            ChatBox.SelectedIndexChanged += ChatBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(ChatBox);
            Controls.Add(BackBTN);
            Controls.Add(EnterBTN);
            Controls.Add(UserInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox UserInput;
        private Button EnterBTN;
        private Button BackBTN;
        private ListBox ChatBox;
    }
}
