using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Жестокие_Игры
{
    public partial class GameScreen : Form
    {
        List<Player> players = new List<Player>();
        int round = 1;
        public GameScreen(List<Player> players)
        {
            InitializeComponent();
            lblRound.Text = "Раунд " + round.ToString();
            this.players = players;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            PlayersStatistics statistics = new PlayersStatistics(players);
            statistics.Show();
        }

        private void btnNextRound_Click(object sender, EventArgs e)
        {
            // Upgrade lblRound, count votes, update player statistics
            this.round += 1;
            lblRound.Text = "Раунд " + this.round.ToString();
            MessageBox.Show("Начинаем раунд " + this.round.ToString());
        }
    }
}
