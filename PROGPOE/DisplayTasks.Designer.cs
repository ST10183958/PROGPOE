namespace PROGPOE
{
    partial class DisplayTasks
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
            DisplayBox = new ListBox();
            BackBTN = new Button();
            SuspendLayout();
            // 
            // DisplayBox
            // 
            DisplayBox.FormattingEnabled = true;
            DisplayBox.ItemHeight = 15;
            DisplayBox.Location = new Point(-1, 5);
            DisplayBox.Name = "DisplayBox";
            DisplayBox.Size = new Size(800, 379);
            DisplayBox.TabIndex = 0;
            DisplayBox.SelectedIndexChanged += DisplayBox_SelectedIndexChanged;
            // 
            // BackBTN
            // 
            BackBTN.Location = new Point(329, 390);
            BackBTN.Name = "BackBTN";
            BackBTN.Size = new Size(104, 48);
            BackBTN.TabIndex = 1;
            BackBTN.Text = "button1";
            BackBTN.UseVisualStyleBackColor = true;
            BackBTN.Click += BackBTN_Click;
            // 
            // DisplayTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackBTN);
            Controls.Add(DisplayBox);
            Name = "DisplayTasks";
            Text = "DisplayTasks";
            Load += DisplayTasks_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox DisplayBox;
        private Button BackBTN;
    }
}