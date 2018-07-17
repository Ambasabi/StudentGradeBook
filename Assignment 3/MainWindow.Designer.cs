namespace Assignment_3
{
    partial class MainWindow
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
            this.lblTest = new System.Windows.Forms.Label();
            this.txtNumStudents = new System.Windows.Forms.TextBox();
            this.pnlSetup = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAssignments = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.cmdNavigate = new System.Windows.Forms.Button();
            this.txtNumAssignments = new System.Windows.Forms.TextBox();
            this.pnlModify = new System.Windows.Forms.Panel();
            this.lblOutputToFile = new System.Windows.Forms.Label();
            this.btnOutputToFile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdDisplayScores = new System.Windows.Forms.Button();
            this.cmdSaveScore = new System.Windows.Forms.Button();
            this.txtEnterAssignmentScore = new System.Windows.Forms.TextBox();
            this.txtEnterAssignmentNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateStudentName = new System.Windows.Forms.TextBox();
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.cmdUpdateStudentName = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.txtOutputName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlSetup.SuspendLayout();
            this.pnlModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(176, 42);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 13);
            this.lblTest.TabIndex = 1;
            // 
            // txtNumStudents
            // 
            this.txtNumStudents.Location = new System.Drawing.Point(32, 61);
            this.txtNumStudents.Name = "txtNumStudents";
            this.txtNumStudents.Size = new System.Drawing.Size(100, 20);
            this.txtNumStudents.TabIndex = 2;
            this.txtNumStudents.Text = "0";
            // 
            // pnlSetup
            // 
            this.pnlSetup.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlSetup.Controls.Add(this.label5);
            this.pnlSetup.Controls.Add(this.lblAssignments);
            this.pnlSetup.Controls.Add(this.lblStudents);
            this.pnlSetup.Controls.Add(this.cmdNavigate);
            this.pnlSetup.Controls.Add(this.txtNumAssignments);
            this.pnlSetup.Controls.Add(this.lblTest);
            this.pnlSetup.Controls.Add(this.txtNumStudents);
            this.pnlSetup.Location = new System.Drawing.Point(12, 12);
            this.pnlSetup.Name = "pnlSetup";
            this.pnlSetup.Size = new System.Drawing.Size(661, 115);
            this.pnlSetup.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Set the above numbers";
            // 
            // lblAssignments
            // 
            this.lblAssignments.AutoSize = true;
            this.lblAssignments.Location = new System.Drawing.Point(216, 33);
            this.lblAssignments.Name = "lblAssignments";
            this.lblAssignments.Size = new System.Drawing.Size(173, 13);
            this.lblAssignments.TabIndex = 7;
            this.lblAssignments.Text = "Enter number of assignments (1-99)";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(29, 33);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(128, 13);
            this.lblStudents.TabIndex = 6;
            this.lblStudents.Text = "Amount of students (1-10)";
            // 
            // cmdNavigate
            // 
            this.cmdNavigate.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cmdNavigate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdNavigate.Location = new System.Drawing.Point(446, 59);
            this.cmdNavigate.Name = "cmdNavigate";
            this.cmdNavigate.Size = new System.Drawing.Size(123, 23);
            this.cmdNavigate.TabIndex = 5;
            this.cmdNavigate.Text = "Set Numbers";
            this.cmdNavigate.UseVisualStyleBackColor = true;
            this.cmdNavigate.Click += new System.EventHandler(this.cmdNavigate_Click);
            // 
            // txtNumAssignments
            // 
            this.txtNumAssignments.Location = new System.Drawing.Point(219, 61);
            this.txtNumAssignments.Name = "txtNumAssignments";
            this.txtNumAssignments.Size = new System.Drawing.Size(100, 20);
            this.txtNumAssignments.TabIndex = 3;
            this.txtNumAssignments.Text = "0";
            // 
            // pnlModify
            // 
            this.pnlModify.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlModify.Controls.Add(this.label8);
            this.pnlModify.Controls.Add(this.txtOutputName);
            this.pnlModify.Controls.Add(this.lblOutputToFile);
            this.pnlModify.Controls.Add(this.btnOutputToFile);
            this.pnlModify.Controls.Add(this.label7);
            this.pnlModify.Controls.Add(this.label6);
            this.pnlModify.Controls.Add(this.label4);
            this.pnlModify.Controls.Add(this.label3);
            this.pnlModify.Controls.Add(this.cmdDisplayScores);
            this.pnlModify.Controls.Add(this.cmdSaveScore);
            this.pnlModify.Controls.Add(this.txtEnterAssignmentScore);
            this.pnlModify.Controls.Add(this.txtEnterAssignmentNumber);
            this.pnlModify.Controls.Add(this.label2);
            this.pnlModify.Controls.Add(this.label1);
            this.pnlModify.Controls.Add(this.txtUpdateStudentName);
            this.pnlModify.Controls.Add(this.listBoxStudent);
            this.pnlModify.Controls.Add(this.cmdUpdateStudentName);
            this.pnlModify.Controls.Add(this.cmdReset);
            this.pnlModify.Enabled = false;
            this.pnlModify.Location = new System.Drawing.Point(12, 133);
            this.pnlModify.Name = "pnlModify";
            this.pnlModify.Size = new System.Drawing.Size(661, 215);
            this.pnlModify.TabIndex = 4;
            // 
            // lblOutputToFile
            // 
            this.lblOutputToFile.AutoSize = true;
            this.lblOutputToFile.Location = new System.Drawing.Point(373, 173);
            this.lblOutputToFile.Name = "lblOutputToFile";
            this.lblOutputToFile.Size = new System.Drawing.Size(0, 13);
            this.lblOutputToFile.TabIndex = 22;
            // 
            // btnOutputToFile
            // 
            this.btnOutputToFile.Location = new System.Drawing.Point(376, 189);
            this.btnOutputToFile.Name = "btnOutputToFile";
            this.btnOutputToFile.Size = new System.Drawing.Size(75, 23);
            this.btnOutputToFile.TabIndex = 21;
            this.btnOutputToFile.Text = "Ouput to file";
            this.btnOutputToFile.UseVisualStyleBackColor = true;
            this.btnOutputToFile.Click += new System.EventHandler(this.outputToFile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Display the students Scores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Click to reset the program";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Enter Assignment Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Enter Assignment Number:";
            // 
            // cmdDisplayScores
            // 
            this.cmdDisplayScores.Location = new System.Drawing.Point(480, 189);
            this.cmdDisplayScores.Name = "cmdDisplayScores";
            this.cmdDisplayScores.Size = new System.Drawing.Size(101, 23);
            this.cmdDisplayScores.TabIndex = 16;
            this.cmdDisplayScores.Text = "Display Scores";
            this.cmdDisplayScores.UseVisualStyleBackColor = true;
            this.cmdDisplayScores.Click += new System.EventHandler(this.cmdDisplayScores_Click);
            // 
            // cmdSaveScore
            // 
            this.cmdSaveScore.Location = new System.Drawing.Point(480, 114);
            this.cmdSaveScore.Name = "cmdSaveScore";
            this.cmdSaveScore.Size = new System.Drawing.Size(75, 23);
            this.cmdSaveScore.TabIndex = 15;
            this.cmdSaveScore.Text = "Save Score";
            this.cmdSaveScore.UseVisualStyleBackColor = true;
            this.cmdSaveScore.Click += new System.EventHandler(this.cmdSaveScore_Click);
            // 
            // txtEnterAssignmentScore
            // 
            this.txtEnterAssignmentScore.Location = new System.Drawing.Point(480, 76);
            this.txtEnterAssignmentScore.Name = "txtEnterAssignmentScore";
            this.txtEnterAssignmentScore.Size = new System.Drawing.Size(100, 20);
            this.txtEnterAssignmentScore.TabIndex = 14;
            // 
            // txtEnterAssignmentNumber
            // 
            this.txtEnterAssignmentNumber.Location = new System.Drawing.Point(480, 43);
            this.txtEnterAssignmentNumber.Name = "txtEnterAssignmentNumber";
            this.txtEnterAssignmentNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEnterAssignmentNumber.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Student Names";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            // 
            // txtUpdateStudentName
            // 
            this.txtUpdateStudentName.Location = new System.Drawing.Point(186, 40);
            this.txtUpdateStudentName.Name = "txtUpdateStudentName";
            this.txtUpdateStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateStudentName.TabIndex = 10;
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.DisplayMember = "studentName";
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.Location = new System.Drawing.Point(0, 31);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(120, 160);
            this.listBoxStudent.TabIndex = 9;
            this.listBoxStudent.SelectedIndexChanged += new System.EventHandler(this.listBoxStudent_SelectedIndexChanged);
            // 
            // cmdUpdateStudentName
            // 
            this.cmdUpdateStudentName.Location = new System.Drawing.Point(186, 71);
            this.cmdUpdateStudentName.Name = "cmdUpdateStudentName";
            this.cmdUpdateStudentName.Size = new System.Drawing.Size(109, 23);
            this.cmdUpdateStudentName.TabIndex = 8;
            this.cmdUpdateStudentName.Text = "Update Student";
            this.cmdUpdateStudentName.UseVisualStyleBackColor = true;
            this.cmdUpdateStudentName.Click += new System.EventHandler(this.cmdUpdateStudentName_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(186, 179);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(75, 23);
            this.cmdReset.TabIndex = 0;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // txtOutputName
            // 
            this.txtOutputName.Location = new System.Drawing.Point(273, 189);
            this.txtOutputName.Name = "txtOutputName";
            this.txtOutputName.Size = new System.Drawing.Size(100, 20);
            this.txtOutputName.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Enter file name:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 349);
            this.Controls.Add(this.pnlModify);
            this.Controls.Add(this.pnlSetup);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(694, 387);
            this.MinimumSize = new System.Drawing.Size(694, 387);
            this.Name = "MainWindow";
            this.Text = "Assignment 3";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.pnlSetup.ResumeLayout(false);
            this.pnlSetup.PerformLayout();
            this.pnlModify.ResumeLayout(false);
            this.pnlModify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox txtNumStudents;
        private System.Windows.Forms.Panel pnlSetup;
        private System.Windows.Forms.TextBox txtNumAssignments;
        private System.Windows.Forms.Button cmdNavigate;
        private System.Windows.Forms.Label lblAssignments;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Panel pnlModify;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdUpdateStudentName;
        private System.Windows.Forms.ListBox listBoxStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdateStudentName;
        private System.Windows.Forms.Button cmdSaveScore;
        private System.Windows.Forms.TextBox txtEnterAssignmentScore;
        private System.Windows.Forms.TextBox txtEnterAssignmentNumber;
        private System.Windows.Forms.Button cmdDisplayScores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOutputToFile;
        private System.Windows.Forms.Label lblOutputToFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOutputName;
    }
}

