using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radio_player_desktop.Views
{
    public partial class Main : Form
    {


        private BAL.Main _mainBal;

        public Main()
        {
            InitializeComponent();

            _mainBal = new BAL.Main();

        }

        private void start_Click(object sender, EventArgs e)
        {
            _mainBal.Play();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            _mainBal.Stop();
        }
    }
}
