
namespace Assignment_7
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.labWei = new System.Windows.Forms.Label();
            this.labGrade = new System.Windows.Forms.Label();
            this.labQuizes = new System.Windows.Forms.Label();
            this.labAssign = new System.Windows.Forms.Label();
            this.labMidExam = new System.Windows.Forms.Label();
            this.labFinalExam = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbQuizesWei = new System.Windows.Forms.TextBox();
            this.tbAssignWei = new System.Windows.Forms.TextBox();
            this.tbMidWei = new System.Windows.Forms.TextBox();
            this.tbFinalWei = new System.Windows.Forms.TextBox();
            this.tbQuizGrade = new System.Windows.Forms.TextBox();
            this.tbAssignGrade = new System.Windows.Forms.TextBox();
            this.tbMidGrade = new System.Windows.Forms.TextBox();
            this.tbFinalGrade = new System.Windows.Forms.TextBox();
            this.tbTotalGrade = new System.Windows.Forms.TextBox();
            this.tbTotalWei = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(162, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 33);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Calculate Weighted Average";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labWei
            // 
            this.labWei.AutoSize = true;
            this.labWei.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWei.Location = new System.Drawing.Point(180, 36);
            this.labWei.Name = "labWei";
            this.labWei.Size = new System.Drawing.Size(52, 16);
            this.labWei.TabIndex = 1;
            this.labWei.Text = "Weight";
            this.labWei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labGrade
            // 
            this.labGrade.AutoSize = true;
            this.labGrade.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGrade.Location = new System.Drawing.Point(254, 36);
            this.labGrade.Name = "labGrade";
            this.labGrade.Size = new System.Drawing.Size(47, 16);
            this.labGrade.TabIndex = 2;
            this.labGrade.Text = "Grade";
            this.labGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labQuizes
            // 
            this.labQuizes.AutoSize = true;
            this.labQuizes.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuizes.Location = new System.Drawing.Point(99, 62);
            this.labQuizes.Name = "labQuizes";
            this.labQuizes.Size = new System.Drawing.Size(59, 16);
            this.labQuizes.TabIndex = 3;
            this.labQuizes.Text = "Quizzes";
            this.labQuizes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labAssign
            // 
            this.labAssign.AutoSize = true;
            this.labAssign.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAssign.Location = new System.Drawing.Point(69, 93);
            this.labAssign.Name = "labAssign";
            this.labAssign.Size = new System.Drawing.Size(89, 16);
            this.labAssign.TabIndex = 4;
            this.labAssign.Text = "Assignments";
            this.labAssign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labMidExam
            // 
            this.labMidExam.AutoSize = true;
            this.labMidExam.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMidExam.Location = new System.Drawing.Point(56, 126);
            this.labMidExam.Name = "labMidExam";
            this.labMidExam.Size = new System.Drawing.Size(102, 16);
            this.labMidExam.TabIndex = 5;
            this.labMidExam.Text = "Midtrem Exam";
            this.labMidExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labFinalExam
            // 
            this.labFinalExam.AutoSize = true;
            this.labFinalExam.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFinalExam.Location = new System.Drawing.Point(77, 162);
            this.labFinalExam.Name = "labFinalExam";
            this.labFinalExam.Size = new System.Drawing.Size(81, 16);
            this.labFinalExam.TabIndex = 6;
            this.labFinalExam.Text = "Final Exam";
            this.labFinalExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Final Grade";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbQuizesWei
            // 
            this.tbQuizesWei.Location = new System.Drawing.Point(165, 62);
            this.tbQuizesWei.Name = "tbQuizesWei";
            this.tbQuizesWei.Size = new System.Drawing.Size(67, 22);
            this.tbQuizesWei.TabIndex = 8;
            // 
            // tbAssignWei
            // 
            this.tbAssignWei.Location = new System.Drawing.Point(165, 93);
            this.tbAssignWei.Name = "tbAssignWei";
            this.tbAssignWei.Size = new System.Drawing.Size(67, 22);
            this.tbAssignWei.TabIndex = 9;
            // 
            // tbMidWei
            // 
            this.tbMidWei.Location = new System.Drawing.Point(165, 126);
            this.tbMidWei.Name = "tbMidWei";
            this.tbMidWei.Size = new System.Drawing.Size(67, 22);
            this.tbMidWei.TabIndex = 10;
            // 
            // tbFinalWei
            // 
            this.tbFinalWei.Location = new System.Drawing.Point(165, 162);
            this.tbFinalWei.Name = "tbFinalWei";
            this.tbFinalWei.Size = new System.Drawing.Size(67, 22);
            this.tbFinalWei.TabIndex = 11;
            // 
            // tbQuizGrade
            // 
            this.tbQuizGrade.Location = new System.Drawing.Point(257, 62);
            this.tbQuizGrade.Name = "tbQuizGrade";
            this.tbQuizGrade.Size = new System.Drawing.Size(99, 22);
            this.tbQuizGrade.TabIndex = 12;
            // 
            // tbAssignGrade
            // 
            this.tbAssignGrade.Location = new System.Drawing.Point(257, 93);
            this.tbAssignGrade.Name = "tbAssignGrade";
            this.tbAssignGrade.Size = new System.Drawing.Size(99, 22);
            this.tbAssignGrade.TabIndex = 13;
            // 
            // tbMidGrade
            // 
            this.tbMidGrade.Location = new System.Drawing.Point(257, 126);
            this.tbMidGrade.Name = "tbMidGrade";
            this.tbMidGrade.Size = new System.Drawing.Size(99, 22);
            this.tbMidGrade.TabIndex = 14;
            // 
            // tbFinalGrade
            // 
            this.tbFinalGrade.Location = new System.Drawing.Point(257, 162);
            this.tbFinalGrade.Name = "tbFinalGrade";
            this.tbFinalGrade.Size = new System.Drawing.Size(99, 22);
            this.tbFinalGrade.TabIndex = 15;
            // 
            // tbTotalGrade
            // 
            this.tbTotalGrade.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbTotalGrade.Location = new System.Drawing.Point(257, 197);
            this.tbTotalGrade.Name = "tbTotalGrade";
            this.tbTotalGrade.Size = new System.Drawing.Size(99, 22);
            this.tbTotalGrade.TabIndex = 17;
            // 
            // tbTotalWei
            // 
            this.tbTotalWei.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbTotalWei.Location = new System.Drawing.Point(165, 197);
            this.tbTotalWei.Name = "tbTotalWei";
            this.tbTotalWei.Size = new System.Drawing.Size(67, 22);
            this.tbTotalWei.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(494, 326);
            this.Controls.Add(this.tbTotalGrade);
            this.Controls.Add(this.tbTotalWei);
            this.Controls.Add(this.tbFinalGrade);
            this.Controls.Add(this.tbMidGrade);
            this.Controls.Add(this.tbAssignGrade);
            this.Controls.Add(this.tbQuizGrade);
            this.Controls.Add(this.tbFinalWei);
            this.Controls.Add(this.tbMidWei);
            this.Controls.Add(this.tbAssignWei);
            this.Controls.Add(this.tbQuizesWei);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labFinalExam);
            this.Controls.Add(this.labMidExam);
            this.Controls.Add(this.labAssign);
            this.Controls.Add(this.labQuizes);
            this.Controls.Add(this.labGrade);
            this.Controls.Add(this.labWei);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Assignment 7 by Cindy Cheng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labWei;
        private System.Windows.Forms.Label labGrade;
        private System.Windows.Forms.Label labQuizes;
        private System.Windows.Forms.Label labAssign;
        private System.Windows.Forms.Label labMidExam;
        private System.Windows.Forms.Label labFinalExam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbQuizesWei;
        private System.Windows.Forms.TextBox tbAssignWei;
        private System.Windows.Forms.TextBox tbMidWei;
        private System.Windows.Forms.TextBox tbFinalWei;
        private System.Windows.Forms.TextBox tbQuizGrade;
        private System.Windows.Forms.TextBox tbAssignGrade;
        private System.Windows.Forms.TextBox tbMidGrade;
        private System.Windows.Forms.TextBox tbFinalGrade;
        private System.Windows.Forms.TextBox tbTotalGrade;
        private System.Windows.Forms.TextBox tbTotalWei;
    }
}

