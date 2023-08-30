using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Project_Demon.Object;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Project_Demon.BL
{
    internal class BLScore
    {
        public System.Data.Linq.Table<HiScore> GetScore()
        {
            //connect to sql to take the table
            ScoreboardDataContext dbms = new ScoreboardDataContext();
            return dbms.HiScores;
        }
        public bool AddScore(string Name, int Score)
        {
            //add a new player with name and score
            ScoreboardDataContext dbms = new ScoreboardDataContext();
            HiScore hs = new HiScore();
            hs.SName = Name;
            hs.Score = Score;

            dbms.HiScores.InsertOnSubmit(hs);
            dbms.HiScores.Context.SubmitChanges();
            //dbms.HiScores.Context.Order
            return true;
        }
    }
}
