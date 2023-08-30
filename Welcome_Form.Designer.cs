namespace Project_Demon
{
    partial class Welcome_Form
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
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.cptbBird = new Project_Demon.CircularPicturebox();
            this.cptbExit = new Project_Demon.CircularPicturebox();
            ((System.ComponentModel.ISupportInitialize)(this.cptbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cptbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.BackColor = System.Drawing.Color.Transparent;
            this.lblGameName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGameName.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblGameName.Location = new System.Drawing.Point(158, 54);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(554, 68);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Flappy Vengeance";
            this.lblGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStart.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.Yellow;
            this.lblStart.Location = new System.Drawing.Point(278, 255);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(126, 58);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Chocolate;
            this.lblExit.Location = new System.Drawing.Point(290, 409);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(104, 58);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // cptbBird
            // 
            this.cptbBird.BackColor = System.Drawing.Color.Transparent;
            this.cptbBird.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cptbBird.Image = global::Project_Demon.Properties.Resources.Flappy_down_2;
            this.cptbBird.Location = new System.Drawing.Point(462, 236);
            this.cptbBird.Name = "cptbBird";
            this.cptbBird.Size = new System.Drawing.Size(115, 90);
            this.cptbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cptbBird.TabIndex = 3;
            this.cptbBird.TabStop = false;
            this.cptbBird.Click += new System.EventHandler(this.cptbBird_Click);
            // 
            // cptbExit
            // 
            this.cptbExit.BackColor = System.Drawing.Color.Transparent;
            this.cptbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cptbExit.Image = global::Project_Demon.Properties.Resources.exit_preview_rev_1;
            this.cptbExit.Location = new System.Drawing.Point(462, 384);
            this.cptbExit.Name = "cptbExit";
            this.cptbExit.Size = new System.Drawing.Size(115, 106);
            this.cptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cptbExit.TabIndex = 5;
            this.cptbExit.TabStop = false;
            this.cptbExit.Click += new System.EventHandler(this.cptbExit_Click);
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Demon.Properties.Resources.sky_sunset_sunrise_blank;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 578);
            this.Controls.Add(this.cptbExit);
            this.Controls.Add(this.cptbBird);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblGameName);
            this.Name = "Welcome_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome_Form";
            ((System.ComponentModel.ISupportInitialize)(this.cptbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cptbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblExit;
        private CircularPicturebox cptbBird;
        private CircularPicturebox cptbExit;
    }
}