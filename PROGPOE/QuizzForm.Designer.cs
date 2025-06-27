namespace PROGPOE
{
    partial class QuizzForm
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
            QuestionTxt = new Label();
            LabelA = new Label();
            LabelD = new Label();
            LabelC = new Label();
            LabelB = new Label();
            Abtn = new Button();
            Cbtn = new Button();
            Bbtn = new Button();
            Dbtn = new Button();
            Nextbtn = new Button();
            Backbtn = new Button();
            SuspendLayout();
            // 
            // QuestionTxt
            // 
            QuestionTxt.AutoSize = true;
            QuestionTxt.Font = new Font("Segoe UI", 25F);
            QuestionTxt.Location = new Point(0, 0);
            QuestionTxt.Name = "QuestionTxt";
            QuestionTxt.Size = new Size(156, 46);
            QuestionTxt.TabIndex = 0;
            QuestionTxt.Text = "Question";
            QuestionTxt.Click += QuestionTxt_Click;
            // 
            // LabelA
            // 
            LabelA.AutoSize = true;
            LabelA.Font = new Font("Segoe UI", 25F);
            LabelA.Location = new Point(0, 62);
            LabelA.Name = "LabelA";
            LabelA.Size = new Size(42, 46);
            LabelA.TabIndex = 1;
            LabelA.Text = "A";
            LabelA.Click += LabelA_Click;
            // 
            // LabelD
            // 
            LabelD.AutoSize = true;
            LabelD.Font = new Font("Segoe UI", 25F);
            LabelD.Location = new Point(0, 298);
            LabelD.Name = "LabelD";
            LabelD.Size = new Size(44, 46);
            LabelD.TabIndex = 2;
            LabelD.Text = "D";
            // 
            // LabelC
            // 
            LabelC.AutoSize = true;
            LabelC.Font = new Font("Segoe UI", 25F);
            LabelC.Location = new Point(0, 215);
            LabelC.Name = "LabelC";
            LabelC.Size = new Size(41, 46);
            LabelC.TabIndex = 3;
            LabelC.Text = "C";
            // 
            // LabelB
            // 
            LabelB.AutoSize = true;
            LabelB.Font = new Font("Segoe UI", 25F);
            LabelB.Location = new Point(0, 139);
            LabelB.Name = "LabelB";
            LabelB.Size = new Size(39, 46);
            LabelB.TabIndex = 4;
            LabelB.Text = "B";
            // 
            // Abtn
            // 
            Abtn.Font = new Font("Segoe UI", 25F);
            Abtn.Location = new Point(12, 373);
            Abtn.Name = "Abtn";
            Abtn.Size = new Size(69, 65);
            Abtn.TabIndex = 5;
            Abtn.Text = "A";
            Abtn.UseVisualStyleBackColor = true;
            Abtn.Click += Abtn_Click;
            // 
            // Cbtn
            // 
            Cbtn.Font = new Font("Segoe UI", 25F);
            Cbtn.Location = new Point(162, 373);
            Cbtn.Name = "Cbtn";
            Cbtn.Size = new Size(69, 65);
            Cbtn.TabIndex = 6;
            Cbtn.Text = "C";
            Cbtn.UseVisualStyleBackColor = true;
            Cbtn.Click += Cbtn_Click;
            // 
            // Bbtn
            // 
            Bbtn.Font = new Font("Segoe UI", 25F);
            Bbtn.Location = new Point(87, 373);
            Bbtn.Name = "Bbtn";
            Bbtn.Size = new Size(69, 65);
            Bbtn.TabIndex = 7;
            Bbtn.Text = "B";
            Bbtn.UseVisualStyleBackColor = true;
            Bbtn.Click += Bbtn_Click;
            // 
            // Dbtn
            // 
            Dbtn.Font = new Font("Segoe UI", 25F);
            Dbtn.Location = new Point(237, 373);
            Dbtn.Name = "Dbtn";
            Dbtn.Size = new Size(69, 65);
            Dbtn.TabIndex = 8;
            Dbtn.Text = "D";
            Dbtn.UseVisualStyleBackColor = true;
            Dbtn.Click += Dbtn_Click;
            // 
            // Nextbtn
            // 
            Nextbtn.Font = new Font("Segoe UI", 15F);
            Nextbtn.Location = new Point(312, 373);
            Nextbtn.Name = "Nextbtn";
            Nextbtn.Size = new Size(69, 65);
            Nextbtn.TabIndex = 9;
            Nextbtn.Text = "Next";
            Nextbtn.UseVisualStyleBackColor = true;
            Nextbtn.Click += Nextbtn_Click;
            // 
            // Backbtn
            // 
            Backbtn.Font = new Font("Segoe UI", 15F);
            Backbtn.Location = new Point(387, 373);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(69, 65);
            Backbtn.TabIndex = 10;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = true;
            Backbtn.Click += Backbtn_Click;
            // 
            // QuizzForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1633, 450);
            Controls.Add(Backbtn);
            Controls.Add(Nextbtn);
            Controls.Add(Dbtn);
            Controls.Add(Bbtn);
            Controls.Add(Cbtn);
            Controls.Add(Abtn);
            Controls.Add(LabelB);
            Controls.Add(LabelC);
            Controls.Add(LabelD);
            Controls.Add(LabelA);
            Controls.Add(QuestionTxt);
            Name = "QuizzForm";
            Text = "QuizzForm";
            Load += QuizzForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuestionTxt;
        private Label LabelA;
        private Label LabelD;
        private Label LabelC;
        private Label LabelB;
        private Button Abtn;
        private Button Cbtn;
        private Button Bbtn;
        private Button Dbtn;
        private Button Nextbtn;
        private Button Backbtn;
    }
}