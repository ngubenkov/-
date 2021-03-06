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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            test();
        }

    
        private void btnStart_Click(object sender, EventArgs e)
        {
            getPlayers();
            List<Player> players = getPlayers();

            

            if (areNamesUnique(players))
            {
                if (isNumberOfPlayersGood(players)) {
                    this.Hide();
                    GameScreen game = new GameScreen(players);
                    game.Show();
                }
                else
                {
                    MessageBox.Show("Колличество игроков должно быть четно 3");
                }
                
            }
            else
            {
                MessageBox.Show("Имена игроков должны быть уникальны");
            }
            
        }
           
        private bool areNamesUnique(List<Player> players)
        {
            // check if dublicate names appears in players list
            HashSet<string> names = new HashSet<string>();

            foreach(Player p in players )
                {
                    names.Add(p.name);
                }

            if (names.Count() == players.Count()){
                // if names size and number of players are equal -> no dublicate names
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isNumberOfPlayersGood(List<Player> players)
        {
            // check is valid number of players
            if (players.Count() % 3 == 0 && players.Count() >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnAddPlayer_Click_1(object sender, EventArgs e)
        {
            tblPlayers.RowCount += 1;

            string ind = (tblPlayers.RowCount - 2).ToString();
            TextBox txt = new TextBox();
            txt.Name = "txtBox" + ind;
            tblPlayers.Controls.Add(new Label() { Text = "Игрок "+ ind }, 0, tblPlayers.RowCount  );
            tblPlayers.Controls.Add(txt, 1, tblPlayers.RowCount );

        }


        private List<Player> getPlayers()
        {

            List<Player> Players = new List<Player>();
            
            for (int i=0; i< tblPlayers.RowCount - 2; i++)
            {
                var txtBox = this.Controls.Find("txtBox" + (i+1).ToString(),true);
                Players.Add(new Player(i, txtBox[0].Text, Statics.defaultPoints));
            }

            return Players;
        }

        private void test()
        {
            btnAddPlayer_Click_1(null, new EventArgs());
            btnAddPlayer_Click_1(null, new EventArgs());
            btnAddPlayer_Click_1(null, new EventArgs());
            btnAddPlayer_Click_1(null, new EventArgs());
            btnAddPlayer_Click_1(null, new EventArgs());
            btnAddPlayer_Click_1(null, new EventArgs());
            btnAddPlayer_Click_1(null, new EventArgs());
            btnAddPlayer_Click_1(null, new EventArgs());
            btnAddPlayer_Click_1(null, new EventArgs());
            var txtBox = this.Controls.Find("txtBox1",  true);
            txtBox[0].Text = "a";
            txtBox = this.Controls.Find("txtBox2", true);
            txtBox[0].Text = "B";
            txtBox = this.Controls.Find("txtBox3", true);
            txtBox[0].Text = "C";
            txtBox = this.Controls.Find("txtBox4", true);
            txtBox[0].Text = "D";
            txtBox = this.Controls.Find("txtBox5", true);
            txtBox[0].Text = "E";
            txtBox = this.Controls.Find("txtBox6", true);
            txtBox[0].Text = "F";
            txtBox = this.Controls.Find("txtBox7", true);
            txtBox[0].Text = "G";
            txtBox = this.Controls.Find("txtBox8", true);
            txtBox[0].Text = "H";
            txtBox = this.Controls.Find("txtBox9", true);
            txtBox[0].Text = "I";



        }
 
    }
}
