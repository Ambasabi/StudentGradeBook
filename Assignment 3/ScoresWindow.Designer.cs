namespace Assignment_3
{
    partial class ScoresWindow
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
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.cmdCloseSecondWindow = new System.Windows.Forms.Button();
            this.txtDisplayAllScores = new System.Windows.Forms.TextBox();
            this.dgvAllAssignments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Location = new System.Drawing.Point(97, 54);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(0, 13);
            this.lblAverageScore.TabIndex = 1;
            // 
            // cmdCloseSecondWindow
            // 
            this.cmdCloseSecondWindow.Location = new System.Drawing.Point(167, 396);
            this.cmdCloseSecondWindow.Name = "cmdCloseSecondWindow";
            this.cmdCloseSecondWindow.Size = new System.Drawing.Size(75, 23);
            this.cmdCloseSecondWindow.TabIndex = 2;
            this.cmdCloseSecondWindow.Text = "Close";
            this.cmdCloseSecondWindow.UseVisualStyleBackColor = true;
            this.cmdCloseSecondWindow.Click += new System.EventHandler(this.cmdCloseSecondWindow_Click);
            // 
            // txtDisplayAllScores
            // 
            this.txtDisplayAllScores.Location = new System.Drawing.Point(33, 12);
            this.txtDisplayAllScores.Multiline = true;
            this.txtDisplayAllScores.Name = "txtDisplayAllScores";
            this.txtDisplayAllScores.ReadOnly = true;
            this.txtDisplayAllScores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplayAllScores.Size = new System.Drawing.Size(354, 190);
            this.txtDisplayAllScores.TabIndex = 7;
            // 
            // dgvAllAssignments
            // 
            this.dgvAllAssignments.AllowUserToAddRows = false;
            this.dgvAllAssignments.AllowUserToDeleteRows = false;
            this.dgvAllAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAssignments.Location = new System.Drawing.Point(33, 229);
            this.dgvAllAssignments.Name = "dgvAllAssignments";
            this.dgvAllAssignments.ReadOnly = true;
            this.dgvAllAssignments.RowHeadersVisible = false;
            this.dgvAllAssignments.Size = new System.Drawing.Size(354, 150);
            this.dgvAllAssignments.TabIndex = 8;
 
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.dgvAllAssignments);
            this.Controls.Add(this.txtDisplayAllScores);
            this.Controls.Add(this.cmdCloseSecondWindow);
            this.Controls.Add(this.lblAverageScore);
            this.Name = "Scores";
            this.Text = "Scores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAssignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Button cmdCloseSecondWindow;
        private System.Windows.Forms.TextBox txtDisplayAllScores;
        private System.Windows.Forms.DataGridView dgvAllAssignments;
    }
}