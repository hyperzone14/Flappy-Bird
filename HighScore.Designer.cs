namespace Project_Demon
{
    partial class HighScore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvScoreBoard = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblScoreboard = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtScore);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(54, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 218);
            this.panel1.TabIndex = 0;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(234, 135);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(305, 42);
            this.txtScore.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(234, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(305, 42);
            this.txtName.TabIndex = 2;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Aqua;
            this.lblScore.Location = new System.Drawing.Point(102, 139);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(101, 34);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Aqua;
            this.lblName.Location = new System.Drawing.Point(102, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 34);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // dgvScoreBoard
            // 
            this.dgvScoreBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoreBoard.Location = new System.Drawing.Point(54, 355);
            this.dgvScoreBoard.Name = "dgvScoreBoard";
            this.dgvScoreBoard.RowHeadersWidth = 62;
            this.dgvScoreBoard.RowTemplate.Height = 28;
            this.dgvScoreBoard.Size = new System.Drawing.Size(696, 287);
            this.dgvScoreBoard.TabIndex = 1;
            this.dgvScoreBoard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScoreBoard_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.IndianRed;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(240, 674);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 47);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(445, 674);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(129, 47);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblScoreboard
            // 
            this.lblScoreboard.AutoSize = true;
            this.lblScoreboard.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreboard.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreboard.ForeColor = System.Drawing.Color.Lime;
            this.lblScoreboard.Location = new System.Drawing.Point(220, 9);
            this.lblScoreboard.Name = "lblScoreboard";
            this.lblScoreboard.Size = new System.Drawing.Size(348, 66);
            this.lblScoreboard.TabIndex = 4;
            this.lblScoreboard.Text = "Scoreboard";
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Demon.Properties.Resources.sky_sunset_sunrise_blank;
            this.ClientSize = new System.Drawing.Size(803, 736);
            this.Controls.Add(this.lblScoreboard);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvScoreBoard);
            this.Controls.Add(this.panel1);
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScore";
            this.Load += new System.EventHandler(this.HighScore_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvScoreBoard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblScoreboard;
    }
}