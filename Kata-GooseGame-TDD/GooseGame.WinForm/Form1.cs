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
            MessageBox.Show(_gooseGame.AddPlayer(txtPlayer.Text));
        }
    }
}
