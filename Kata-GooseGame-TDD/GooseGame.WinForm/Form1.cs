using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GooseGame.WinForm
{
    public partial class Form1 : Form
    {
        private Business.Game _gooseGame;
        public Form1()
        {
            InitializeComponent();
            _gooseGame = new GooseGame.Business.Game();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            txtLog.AppendText(_gooseGame.AddPlayer(txtPlayer.Text));
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            txtLog.AppendText(_gooseGame.Move(txtPlayer.Text, int.Parse(txtDice1.Text), int.Parse(txtDice2.Text)));
            txtLog.AppendText("\r\n");
        }
    }
}
