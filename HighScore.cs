using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Demon.BL;

namespace Project_Demon
{
    public partial class HighScore : Form
    {
        //int hs = Game_Form.Score;
        BLScore bs = new BLScore();
        bool inputted = false;
        //bool Add;
        public HighScore()
        {
            InitializeComponent();
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            LoadData();
            //check if the score is inputted or not 
            if (!inputted)
            {
                InputScore();
                inputted = true;
            }
            else
            {
                //when the data has been saved, the player can look through the other's score
                txtName.Enabled = false;
                txtScore.Enabled = false;
                LoadData();
            } 
        }

        private void InputScore() 
        {
            //add the name into the textbox Name to save
            txtScore.Text = Game_Form.Score.ToString();
            txtScore.Enabled = false;
            txtName.ResetText();
            txtName.Focus();
            
        }

        private void LoadData()
        {
            this.btnReload.Enabled = true;
            this.btnSave.Enabled = true;

            this.txtName.ResetText();
            this.txtScore.ResetText();

            dgvScoreBoard.DataSource = bs.GetScore();
            dgvScoreBoard.AutoResizeColumns();
            dgvScoreBoard_CellClick(null, null);
        }

        private void dgvScoreBoard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int s = dgvScoreBoard.CurrentCell.RowIndex;
            this.txtName.Text = dgvScoreBoard.Rows[s].Cells[0].Value.ToString();
            this.txtScore.Text = dgvScoreBoard.Rows[s].Cells[1].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BLScore bs = new BLScore();
                bs.AddScore(this.txtName.Text, Convert.ToInt32(this.txtScore.Text));
                MessageBox.Show("Added");            
            }
            catch
            {
                MessageBox.Show("Can't Added");
            }
        }
    }
}
