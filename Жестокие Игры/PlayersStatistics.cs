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
    public partial class PlayersStatistics : Form
    {
        public PlayersStatistics(List<Player> players)
        {
            InitializeComponent();
            
            int i = 1;
           
            foreach(Player player in players.OrderByDescending(p => p.points))
            {
                tblStatistics.Controls.Add(new Label() { Text = i.ToString() }, 0, tblStatistics.RowCount+i);
                tblStatistics.Controls.Add(new Label() { Text = player.name }, 1, tblStatistics.RowCount+i);
                tblStatistics.Controls.Add(new Label() { Text = player.points.ToString() }, 2, tblStatistics.RowCount+i);
                i++;
            }
        }
    }
}
