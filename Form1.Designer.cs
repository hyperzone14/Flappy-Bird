namespace Project_Demon
{
    partial class Game_Form
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
            this.components = new System.ComponentModel.Container();
            this.timer_Control = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.lblBeScoCount = new System.Windows.Forms.Label();
            this.lblScoCount = new System.Windows.Forms.Label();
            this.cptbKeyItem = new Project_Demon.CircularPicturebox();
            this.ptbGound = new System.Windows.Forms.PictureBox();
            this.dbfBackground = new Project_Demon.DoubleBuffering();
            this.cptbKeyhole = new Project_Demon.CircularPicturebox();
            this.lblInform = new System.Windows.Forms.Label();
            this.cptbKey = new Project_Demon.CircularPicturebox();
            this.cptbBird_down = new Project_Demon.CircularPicturebox();
            this.ptbTopWall = new System.Windows.Forms.PictureBox();
            this.ptbBottomWall = new System.Windows.Forms.PictureBox();
            this.cptbBird_up = new Project_Demon.CircularPicturebox();
            ((System.ComponentModel.ISupportInitialize)(this.cptbKeyItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGound)).BeginInit();
            this.dbfBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cptbKeyhole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cptbKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cptbBird_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTopWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBottomWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cptbBird_up)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_Control
            // 
            this.timer_Control.Interval = 30;
            this.timer_Control.Tick += new System.EventHandler(this.timer_Control_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Khaki;
            this.lblScore.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Blue;
            this.lblScore.Location = new System.Drawing.Point(688, 824);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(101, 34);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.BackColor = System.Drawing.Color.Khaki;
            this.lblBestScore.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.ForeColor = System.Drawing.Color.Blue;
            this.lblBestScore.Location = new System.Drawing.Point(629, 868);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(160, 34);
            this.lblBestScore.TabIndex = 5;
            this.lblBestScore.Text = "Best score:";
            // 
            // lblBeScoCount
            // 
            this.lblBeScoCount.AutoSize = true;
            this.lblBeScoCount.BackColor = System.Drawing.Color.Khaki;
            this.lblBeScoCount.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeScoCount.ForeColor = System.Drawing.Color.Blue;
            this.lblBeScoCount.Location = new System.Drawing.Point(810, 868);
            this.lblBeScoCount.Name = "lblBeScoCount";
            this.lblBeScoCount.Size = new System.Drawing.Size(31, 34);
            this.lblBeScoCount.TabIndex = 6;
            this.lblBeScoCount.Text = "0";
            // 
            // lblScoCount
            // 
            this.lblScoCount.AutoSize = true;
            this.lblScoCount.BackColor = System.Drawing.Color.Khaki;
            this.lblScoCount.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoCount.ForeColor = System.Drawing.Color.Blue;
            this.lblScoCount.Location = new System.Drawing.Point(810, 824);
            this.lblScoCount.Name = "lblScoCount";
            this.lblScoCount.Size = new System.Drawing.Size(31, 34);
            this.lblScoCount.TabIndex = 7;
            this.lblScoCount.Text = "0";
            // 
            // cptbKeyItem
            // 
            this.cptbKeyItem.BackColor = System.Drawing.Color.Khaki;
            this.cptbKeyItem.Image = global::Project_Demon.Properties.Resources.key_preview_rev_1;
            this.cptbKeyItem.Location = new System.Drawing.Point(62, 824);
            this.cptbKeyItem.Name = "cptbKeyItem";
            this.cptbKeyItem.Size = new System.Drawing.Size(80, 60);
            this.cptbKeyItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cptbKeyItem.TabIndex = 10;
            this.cptbKeyItem.TabStop = false;
            // 
            // ptbGound
            // 
            this.ptbGound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbGound.Image = global::Project_Demon.Properties.Resources.floor_sprite;
            this.ptbGound.Location = new System.Drawing.Point(-48, 787);
            this.ptbGound.Name = "ptbGound";
            this.ptbGound.Size = new System.Drawing.Size(927, 136);
            this.ptbGound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGound.TabIndex = 3;
            this.ptbGound.TabStop = false;
            // 
            // dbfBackground
            // 
            this.dbfBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dbfBackground.BackgroundImage = global::Project_Demon.Properties.Resources.background;
            this.dbfBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbfBackground.Controls.Add(this.cptbKeyhole);
            this.dbfBackground.Controls.Add(this.lblInform);
            this.dbfBackground.Controls.Add(this.cptbKey);
            this.dbfBackground.Controls.Add(this.cptbBird_down);
            this.dbfBackground.Controls.Add(this.ptbTopWall);
            this.dbfBackground.Controls.Add(this.ptbBottomWall);
            this.dbfBackground.Controls.Add(this.cptbBird_up);
            this.dbfBackground.Location = new System.Drawing.Point(-48, 1);
            this.dbfBackground.Name = "dbfBackground";
            this.dbfBackground.Size = new System.Drawing.Size(927, 789);
            this.dbfBackground.TabIndex = 2;
            // 
            // cptbKeyhole
            // 
            this.cptbKeyhole.BackColor = System.Drawing.Color.Transparent;
            this.cptbKeyhole.Image = global::Project_Demon.Properties.Resources.keyhole_preview_rev_1__2_;
            this.cptbKeyhole.Location = new System.Drawing.Point(737, 520);
            this.cptbKeyhole.Name = "cptbKeyhole";
            this.cptbKeyhole.Size = new System.Drawing.Size(100, 60);
            this.cptbKeyhole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cptbKeyhole.TabIndex = 10;
            this.cptbKeyhole.TabStop = false;
            // 
            // lblInform
            // 
            this.lblInform.AutoSize = true;
            this.lblInform.BackColor = System.Drawing.Color.Transparent;
            this.lblInform.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInform.ForeColor = System.Drawing.Color.Firebrick;
            this.lblInform.Location = new System.Drawing.Point(133, 104);
            this.lblInform.Name = "lblInform";
            this.lblInform.Size = new System.Drawing.Size(514, 38);
            this.lblInform.TabIndex = 9;
            this.lblInform.Text = "Press w/Space to start the game";
            // 
            // cptbKey
            // 
            this.cptbKey.BackColor = System.Drawing.Color.Transparent;
            this.cptbKey.Image = global::Project_Demon.Properties.Resources.key_preview_rev_1;
            this.cptbKey.Location = new System.Drawing.Point(468, 564);
            this.cptbKey.Name = "cptbKey";
            this.cptbKey.Size = new System.Drawing.Size(80, 60);
            this.cptbKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cptbKey.TabIndex = 8;
            this.cptbKey.TabStop = false;
            // 
            // cptbBird_down
            // 
            this.cptbBird_down.BackColor = System.Drawing.Color.Transparent;
            this.cptbBird_down.Image = global::Project_Demon.Properties.Resources.Flappy_down_2;
            this.cptbBird_down.Location = new System.Drawing.Point(110, 361);
            this.cptbBird_down.Name = "cptbBird_down";
            this.cptbBird_down.Size = new System.Drawing.Size(135, 99);
            this.cptbBird_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cptbBird_down.TabIndex = 0;
            this.cptbBird_down.TabStop = false;
            // 
            // ptbTopWall
            // 
            this.ptbTopWall.Image = global::Project_Demon.Properties.Resources.brick_wall_4;
            this.ptbTopWall.Location = new System.Drawing.Point(737, 0);
            this.ptbTopWall.Name = "ptbTopWall";
            this.ptbTopWall.Size = new System.Drawing.Size(100, 272);
            this.ptbTopWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTopWall.TabIndex = 2;
            this.ptbTopWall.TabStop = false;
            // 
            // ptbBottomWall
            // 
            this.ptbBottomWall.Image = global::Project_Demon.Properties.Resources.brick_wall_4;
            this.ptbBottomWall.Location = new System.Drawing.Point(737, 619);
            this.ptbBottomWall.Name = "ptbBottomWall";
            this.ptbBottomWall.Size = new System.Drawing.Size(100, 246);
            this.ptbBottomWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBottomWall.TabIndex = 3;
            this.ptbBottomWall.TabStop = false;
            // 
            // cptbBird_up
            // 
            this.cptbBird_up.BackColor = System.Drawing.Color.Transparent;
            this.cptbBird_up.Image = global::Project_Demon.Properties.Resources.Flappy_up_3;
            this.cptbBird_up.Location = new System.Drawing.Point(110, 361);
            this.cptbBird_up.Name = "cptbBird_up";
            this.cptbBird_up.Size = new System.Drawing.Size(135, 99);
            this.cptbBird_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cptbBird_up.TabIndex = 1;
            this.cptbBird_up.TabStop = false;
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 923);
            this.Controls.Add(this.cptbKeyItem);
            this.Controls.Add(this.lblScoCount);
            this.Controls.Add(this.lblBeScoCount);
            this.Controls.Add(this.lblBestScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.ptbGound);
            this.Controls.Add(this.dbfBackground);
            this.Name = "Game_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_Form_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_Form_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Game_Form_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cptbKeyItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGound)).EndInit();
            this.dbfBackground.ResumeLayout(false);
            this.dbfBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cptbKeyhole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cptbKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cptbBird_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTopWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBottomWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cptbBird_up)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPicturebox cptbBird_down;
        private CircularPicturebox cptbBird_up;
        private DoubleBuffering dbfBackground;
        private System.Windows.Forms.PictureBox ptbGound;
        private System.Windows.Forms.PictureBox ptbTopWall;
        private System.Windows.Forms.PictureBox ptbBottomWall;
        private System.Windows.Forms.Timer timer_Control;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Label lblBeScoCount;
        private System.Windows.Forms.Label lblScoCount;
        private CircularPicturebox cptbKey;
        private System.Windows.Forms.Label lblInform;
        private CircularPicturebox cptbKeyhole;
        private CircularPicturebox cptbKeyItem;
    }
}

