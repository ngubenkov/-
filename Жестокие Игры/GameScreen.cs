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
            createPlayerBlocks();
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

        private void createPlayerBlocks()
        {
            int numberOfBlocks = players.Count() / 3;

            for (int i=0; i<numberOfBlocks; i++)
            {
                tblPlayersBlock.ColumnCount++;
                tblPlayersBlock.Controls.Add(createPlayerBlock(i, players[i * 3], players[i * 3 + 1], players[i * 3 + 2]), i , 0);
                
            }
        }



            private TableLayoutPanel createPlayerBlock(int block,Player p1, Player p2, Player p3)
        {
            // TODO: create user blocks
            TableLayoutPanel playerBlock = new TableLayoutPanel { Dock = DockStyle.Left, AutoSize = true, CellBorderStyle = TableLayoutPanelCellBorderStyle.Single };
            playerBlock.ColumnCount++;
            playerBlock.Controls.Add(new Label() { Text = "Пара" + block.ToString()}, 0, 0 );
            playerBlock.ColumnCount++;
            playerBlock.Controls.Add(new Label() { Text = "Соло" + block.ToString() }, 1, 0 );

            playerBlock.RowCount++;

            // create two cells for players in one
            TableLayoutPanel twoPlayersNameBlock = new TableLayoutPanel { Dock = DockStyle.Left, AutoSize = true, CellBorderStyle = TableLayoutPanelCellBorderStyle.Single };
            twoPlayersNameBlock.ColumnCount++;
            twoPlayersNameBlock.Controls.Add(new Label() { Text = p1.name + block.ToString() }, 0, 0);
            twoPlayersNameBlock.ColumnCount++;
            twoPlayersNameBlock.Controls.Add(new Label() { Text = p2.name + block.ToString() }, 1, 0);

            playerBlock.Controls.Add(twoPlayersNameBlock, 0, 1);
            playerBlock.Controls.Add(new Label() { Text = p3.name + block.ToString() }, 1, 1);

            // create two cells for players in one
            playerBlock.RowCount++;
            TableLayoutPanel twoPlayersScoresBlock = new TableLayoutPanel { Dock = DockStyle.Left, AutoSize = true, CellBorderStyle = TableLayoutPanelCellBorderStyle.Single };
            twoPlayersScoresBlock.ColumnCount++;
            twoPlayersScoresBlock.Controls.Add(new Label() { Text = p1.points + block.ToString() }, 0, 0);
            twoPlayersScoresBlock.ColumnCount++;
            twoPlayersScoresBlock.Controls.Add(new Label() { Text = p2.points + block.ToString() }, 1, 0);

            playerBlock.Controls.Add(twoPlayersScoresBlock, 0, 2);
            playerBlock.Controls.Add(new Label() { Text = p3.points + block.ToString() }, 1, 2);

            // players Choise
            playerBlock.RowCount++;
            playerBlock.Controls.Add(new Label() { Text = "Выбор пары" + block.ToString() }, 0, 3);
            playerBlock.Controls.Add(new Label() { Text = "Выбор соло" + block.ToString() }, 1, 3);

            // player score change
            playerBlock.RowCount++;
            playerBlock.Controls.Add(new Label() { Text = "Изменение пары" + block.ToString() }, 0, 3);
            playerBlock.Controls.Add(new Label() { Text = "Изменение соло" + block.ToString() }, 1, 3);

            // player total score
            playerBlock.RowCount++;
            TableLayoutPanel twoPlayersTotalScoresBlock = new TableLayoutPanel { Dock = DockStyle.Left, AutoSize = true, CellBorderStyle = TableLayoutPanelCellBorderStyle.Single };
            twoPlayersTotalScoresBlock.ColumnCount++;
            twoPlayersTotalScoresBlock.Controls.Add(new Label() { Text = "ОчкиПосле1" + block.ToString() }, 0, 0);
            twoPlayersTotalScoresBlock.ColumnCount++;
            twoPlayersTotalScoresBlock.Controls.Add(new Label() { Text = "ОчкиПосле2" + block.ToString() }, 1, 0);

            playerBlock.Controls.Add(twoPlayersTotalScoresBlock, 0, 4);
            playerBlock.Controls.Add(new Label() { Text = "ОчкиПосле3" + block.ToString() }, 1, 4);


            return playerBlock;
        }
    }
}
